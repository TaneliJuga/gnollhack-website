﻿using System;
using Umbraco.Core;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PublishedCache;
using ContentModels = Umbraco.Web.PublishedModels;

namespace gnollhack2.App_code
{
    public class TableDataCoverter : IPropertyValueConverter
    {
        private readonly IPublishedSnapshotAccessor _publishedSnapshotAccessor;

        //Injecting the PublishedSnapshotAccessor for fetching content
        public TableDataCoverter(IPublishedSnapshotAccessor publishedSnapshotAccessor)
        {
            _publishedSnapshotAccessor = publishedSnapshotAccessor;
        }

        public bool IsConverter(IPublishedPropertyType propertyType)
        {
            return propertyType.ContentType.Equals(ContentModels.TableData5.GetModelContentType());
        }

        public bool? IsValue(object value, PropertyValueLevel level)
        {
            switch (level)
            {
                case PropertyValueLevel.Source:
                    return value != null && (!(value is string) || string.IsNullOrWhiteSpace((string)value) == false);
                default:
                    throw new NotSupportedException($"Invalid level: {level}.");
            }
        }

        public Type GetPropertyValueType(IPublishedPropertyType propertyType)
        {
            return typeof(TableColumn);
        }

        public PropertyCacheLevel GetPropertyCacheLevel(IPublishedPropertyType propertyType)
        {
            return PropertyCacheLevel.Elements;
        }

        public object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object source, bool preview)
        {
            if (source == null) return null;

            var attemptConvertInt = source.TryConvertTo<int>();
            if (attemptConvertInt.Success)
                return attemptConvertInt.Result;

            var attemptConvertUdi = source.TryConvertTo<Udi>();
            if (attemptConvertUdi.Success)
                return attemptConvertUdi.Result;

            return null;
        }

        public object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        {
            if (inter == null)
                return null;

            if ((propertyType.Alias != null) == false)
            {
                IPublishedContent content;
                if (inter is int id)
                {
                    content = _publishedSnapshotAccessor.PublishedSnapshot.Content.GetById(id);
                    if (content != null)
                        return content;
                }
                else
                {
                    var udi = inter as GuidUdi;
                    if (udi == null)
                        return null;
                    content = _publishedSnapshotAccessor.PublishedSnapshot.Content.GetById(udi.Guid);
                    if (content != null && content.ContentType.ItemType == PublishedItemType.Content)
                        return content;
                }

            }

            return inter;
        }

        public object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview)
        {
            if (inter == null) return null;
            return inter.ToString();
        }
    }
}
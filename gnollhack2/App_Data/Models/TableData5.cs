using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedModels
{
    public partial class TableData5
    {
        public TableColumn Column
        {
            get
            {
                return new TableColumn();
            }
        }

        public class TableColumn
        {
            public TableColumn(IHtmlString columnHeader, IHtmlString cellData)
            {
                ColumnHeader = columnHeader;
                CellData = cellData;
            }

            IHtmlString ColumnHeader { get; }
            IHtmlString CellData { get; }

        }
    }
}

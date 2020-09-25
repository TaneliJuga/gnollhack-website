//using Umbraco.Core.PropertyEditors;
//using Umbraco.Core.Logging;

//namespace Umbraco.Web.PropertyEditors.ParameterEditors
//{
//    [DataEditor("propertyTypePickerMultiple", "Multiple Property Type Picker", "entitypicker")]
//    public class MultiplePropertyTypeParameterEditor : DataEditor
//    {
//        public MultiplePropertyTypeParameterEditor(ILogger logger)
//            : base(logger)
//        {
//            DefaultConfiguration.Add("multiple", "1");
//            DefaultConfiguration.Add("entityType", "PropertyType");
//            //don't publish the id for a property type, publish it's alias
//            DefaultConfiguration.Add("publishBy", "alias");
//        }
//    }
//}
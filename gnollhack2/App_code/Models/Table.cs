//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using ContentModels = Umbraco.Web.PublishedModels;
//public class Table <T> where T : Umbraco.Core.Models.PublishedContent.PublishedContentModel
//{
//    public String Caption { get; set; }
//    public IHtmlString Description { get; set; }
//    public IEnumerable<IEnumerable<String>> Content { get; set; }
//    public IEnumerable<String> Headers { get; set; }

//    public Boolean AlignLeft { get; set; }

//    public Table()
//    {
//        T t;
//        Umbraco.Web.PublishedContentExtensions.Value("asd");
//        public decimal BasePrice => this.Value<decimal>("basePrice");
//}

//    public TableSettings(string caption, IHtmlString description, IEnumerable<IEnumerable<string>> content, IEnumerable<string> headers, bool alignLeft)
//    {
//        Caption = caption;
//        Description = description;
//        Content = content;
//        Headers = headers;
//        AlignLeft = alignLeft;
//    }

//    public TableSettings(string caption, IHtmlString description, IEnumerable<IEnumerable<string>> content, IEnumerable<string> headers) : this(caption, description, content, headers, false) { }

//    public TableSettings(string caption, IEnumerable<IEnumerable<string>> content, IEnumerable<string> headers) : this(caption, null, content, headers, false) { }

//    public TableSettings(string caption, IEnumerable<IEnumerable<string>> content, IEnumerable<string> headers, bool alignLeft) : this(caption, null, content, headers, alignLeft) { }
//}
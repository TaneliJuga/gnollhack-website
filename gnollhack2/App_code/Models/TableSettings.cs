using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class TableSettings
{
    public String Caption { get; set; }
    public IHtmlString Description { get; set; }
    public IEnumerable<IEnumerable<String>> Content { get; set; }
    public IEnumerable<String> Headers { get; set; }

    public Boolean AlignLeft { get; set; }

    public TableSettings()
    {

    }

    public TableSettings(string caption, IHtmlString description, IEnumerable<IEnumerable<string>> content, IEnumerable<string> headers, bool alignLeft)
    {
        Caption = caption;
        Description = description;
        Content = content;
        Headers = headers;
        AlignLeft = alignLeft;
    }

    public TableSettings(string caption, IHtmlString description, IEnumerable<IEnumerable<string>> content, IEnumerable<string> headers) : this(caption, description, content, headers, false) { }

    public TableSettings(string caption, IEnumerable<IEnumerable<string>> content, IEnumerable<string> headers) : this(caption, null, content, headers, false) { }

    public TableSettings(string caption, IEnumerable<IEnumerable<string>> content, IEnumerable<string> headers, bool alignLeft) : this(caption, null, content, headers, alignLeft) { }
}
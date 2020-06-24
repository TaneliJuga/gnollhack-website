using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class NavigationData
{
    public String Name { get; set; }
    public String Url { get; set; }

    public NavigationData(string name, string url)
    {
        Name = name;
        Url = url;
    }
}

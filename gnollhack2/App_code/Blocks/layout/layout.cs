using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BemModels
{
    public class Layout : Block
    {
        static string NAME = "layout";

        public Layout() : base(NAME)
        {
        }

        public String Style { get; set; }

        public IEnumerable<String> NavItems { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels4
{

    public class Js : BemEntityDecorator<Block>
    {
        static string SEPARATOR = "_";

        public Js(Block entity, string name, string value) : base(entity, name, SEPARATOR)
        {

        }

    }

}
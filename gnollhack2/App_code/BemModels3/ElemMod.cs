using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels3
{
    public class ElemMod : BemEntityDecorator<Elem>
    {
        static string SEPARATOR = "_";

        public ElemMod(Elem entity, string name, string value) : base(entity, name, SEPARATOR)
        {

        }

    }

}
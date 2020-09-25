using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BemModels
{

    public class Mod : BemEntityDecorator<Block>
    {
        static string SEPARATOR = "_";

        public Mod(Block entity, string name, string value) : base(entity, name, SEPARATOR)
        {

        }

    }

}
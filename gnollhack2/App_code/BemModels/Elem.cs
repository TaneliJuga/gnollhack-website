﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BemModels
{
    public class Elem : BemEntityDecorator<Block>
    {
        static string SEPARATOR = "__";

        public Elem(Block entity, string name) : base(entity, name, SEPARATOR)
        {
        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels4
{
    public abstract class ClassWriter : BemEntityVisitor<BemEntity>
    {
        public ClassWriter(BemEntity entity, string name, string separator) : base(entity, name, separator)
        {
        }
    }

}
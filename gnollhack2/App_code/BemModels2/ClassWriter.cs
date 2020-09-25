using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels2
{
    public abstract class ClassWriter : IBemEntityVisitor
    {
        public void Visit(Block block)
        {
            
        }

        public void Visit(Elem elem)
        {
            throw new NotImplementedException();
        }

        public void Visit(Mod mod)
        {
            throw new NotImplementedException();
        }

        public void Visit(Js js)
        {
            throw new NotImplementedException();
        }
    }

}
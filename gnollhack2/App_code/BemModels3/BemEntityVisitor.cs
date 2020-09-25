using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels3
{
    public abstract class BemEntityVisitor<T> : BemEntity where T : BemEntity
    {
        private T entity;
        private string separator;

        public BemEntityVisitor(T entity, string name, string separator) : base(name)
        {
            this.entity = entity;
            this.separator = separator;
        }

        public override string getClass()
        {
            return entity.getClass() + separator + base.getClass();
        }
    }

}
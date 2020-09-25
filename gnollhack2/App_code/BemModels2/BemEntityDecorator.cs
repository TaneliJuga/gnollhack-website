﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels2
{
    public abstract class BemEntityDecorator<T> : BemEntity where T : BemEntity
    {
        private T entity;
        private string separator;

        public BemEntityDecorator(T entity, string name, string separator) : base(name)
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
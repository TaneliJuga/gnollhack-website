using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BemModels
{
    public abstract class Block : BemEntity
    {
        public Block(string name) : base(name)
        {
        }
    }

}
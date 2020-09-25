using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels2
{
    public abstract class BemEntity
    {
        public String Name { get; set; }

        public Dictionary<BemEntity, dynamic> Js { get; set; }

        public IEnumerable<BemEntity> Content { get; set; }

        public BemEntity(string name)
        {
            this.Name = name;
        }

        public virtual string getClass()
        {
            return Name;
        }


    }

}
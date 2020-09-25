using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BemModels
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
            if (this.Js.Count > 0)
            {
                return "i-bem " + Name;
            }
            return Name;
        }

        

    }

}
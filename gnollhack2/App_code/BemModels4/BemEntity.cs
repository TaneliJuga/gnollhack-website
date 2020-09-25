using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels4
{
    public abstract class BemEntity
    {
        private static string JSCLASS = "i-bem";
        public String Name { get; set; }

        public string Js { get; set; }

        public IEnumerable<BemEntity> Content { get; set; }

        public IEnumerable<BemEntity> Mix { get;}

        public BemEntity(string name)
        {
            this.Name = name;
            this.Mix = new List<BemEntity>();
        }

        public void AddMix(BemEntity entity)
        {
            Mix.Append(entity);
        }

        public virtual string GetClass()
        {
            return Name;
        }

        public virtual bool HasJs()
        {
            return String.IsNullOrEmpty(this.Js);
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels3
{
    public abstract class BemEntity
    {
        public String Name { get; set; }

        public Dictionary<BemEntity, dynamic> Js { get; set; }

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

        public virtual string getClass()
        {
            return Name;
        }

        public bool hasJs()
        {
            return Mix.Concat(new BemEntity[] { this }).Any(e => e.Js.Count > 0);
        }
    }

}
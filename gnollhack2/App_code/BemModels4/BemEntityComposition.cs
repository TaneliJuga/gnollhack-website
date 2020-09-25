using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels4
{
    public abstract class BemEntityComposition : BemEntity
    {
        private IEnumerable<BemEntity> entities;

        public BemEntityComposition(string name) : base(name)
        {
        }

        public override string GetClass()
        {
            return entities.Aggregate("", (prev, cur) => {
                return prev + cur.GetClass();
            });
        }

        public override bool HasJs()
        {
            return entities.Any(e => e.HasJs());
        }

        public void addEntity(BemEntity entity)
        {
            entities.Append(entity);
        }

        public void removeEntity(BemEntity entity)
        {
            this.entities = entities.Except(new BemEntity[] { entity });
        }
    }

}
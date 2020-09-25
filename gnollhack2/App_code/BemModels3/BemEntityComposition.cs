using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels3
{
    public abstract class BemEntityComposition<T> : BemEntity where T : BemEntity
    {
        private IEnumerable<BemEntity> entities;

        public BemEntityComposition(string name) : base(name)
        {
        }

        public override string getClass()
        {
            return entities.Aggregate("", (prev, cur) => {
                return prev + cur.getClass();
            });
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
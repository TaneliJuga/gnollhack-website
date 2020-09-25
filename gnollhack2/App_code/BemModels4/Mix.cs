using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gnollhack2.App_code.BemModels4
{
    public class Mix : BemEntityComposition
    {

        public Mix(string name, BemEntity entity1, BemEntity entity2) : base(name)
        {
            this.addEntity(entity1);
            this.addEntity(entity2);
        }
    }

}
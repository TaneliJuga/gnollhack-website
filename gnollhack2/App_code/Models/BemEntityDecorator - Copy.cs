//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;


//public abstract class BemEntityDecorator : BemEntity
//{
//    private BemEntity entity;
//    private string separator;

//    public BemEntityDecorator(BemEntity entity, string name, string separator) : base(name)
//    {
//        this.entity = entity;
//        this.separator = separator;
//    }

//    public override string getClass()
//    {
//        return entity.getClass() + separator + base.getClass();
//    }
//}
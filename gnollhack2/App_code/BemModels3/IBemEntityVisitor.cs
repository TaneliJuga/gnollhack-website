using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnollhack2.App_code.BemModels3
{
    interface IBemEntityVisitor
    {
        void Visit(Block block);
        void Visit(Elem elem);
        void Visit(Mod mod);
        void Visit(Js js);
    }
}

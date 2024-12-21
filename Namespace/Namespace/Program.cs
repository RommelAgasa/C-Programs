using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace N1
{
    public class C1 { };


}

namespace Namespace
{
    internal class C2 { };
    public class C3 { };

    namespace N3{
        public class C4 {
            C2 v;
        }
    }
}
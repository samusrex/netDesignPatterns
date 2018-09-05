using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProj
{
    public interface ITem
    {
        String Name();
        IPacking Packing();
        float Price();



    }
}

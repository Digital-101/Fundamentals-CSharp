using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public interface Reproducible<T> where T : Felidae
    {
        T[] Reproduce(T mate);
    }
}

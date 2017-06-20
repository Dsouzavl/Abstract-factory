using AbstractFactory.HumanProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IHumano
    {
        Cabelo cabelo();
        Boca boca();
        Pes pes();
    }
}

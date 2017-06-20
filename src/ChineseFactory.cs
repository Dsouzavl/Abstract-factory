using AbstractFactory.HumanProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ChineseFactory : IHumano
    {
        public Boca boca()
        {
            Boca boca = new Boca();
            boca.Tamanho = "Pequena";

            return boca;
        }

        public Pes pes()
        {
            Pes pes = new Pes();
            pes.Tamanho = "Pequeno";
            pes.TemChule = true;

            return pes;
        }

        public Cabelo cabelo()
        {
            Cabelo cabelo = new Cabelo();
            cabelo.Cor = "Preto";
            cabelo.Tamanho = "Curto";

            return cabelo;
        }
    }
}

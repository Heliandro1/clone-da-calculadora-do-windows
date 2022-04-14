using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Calculator : Calculadora
    {
        public double Adicionar(params int[] valores)
        {
            return 9 ;
        }
        public double Subtrair(params int[] valores)
        {
            return 1;
        }

        public double Dividir(params double[] valores)
        {
            return 2;
        }
        public double Multiplicar(params double[] valores)
        {
            return 3;
        }
        public void Clear()
        {

        }
        public void ClearAll()
        {

        }
      


    }
}

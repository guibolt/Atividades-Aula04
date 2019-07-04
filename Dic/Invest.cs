using System;
using System.Collections.Generic;
using System.Text;

namespace Dic
{
    class Invest
    {
        
        public double CalcularInvestimento(int code,double valor,int mes)
        {
            if (code == 1)
                return valor + (0.375 * mes * 1);


            else if (code == 2)
                return valor + (0.541 * mes * 10);


            else if(code == 3)
                return valor + (0.6 * mes * 10);

            else return 0;
        }
    }
}

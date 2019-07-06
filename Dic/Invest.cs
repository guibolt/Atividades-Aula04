using System;
using System.Collections.Generic;
using System.Text;

namespace Dic
{
    class Invest
    {
        double fatorRendimento = 0.00036, fatorRendimento1 = 0.00051;

        public double CalcularInvestimento(int code,double valor,int mes)
        {
            if (code == 1)
                return  valor *(fatorRendimento * mes * 10) + valor;


            else if (code == 2)
                return valor *(fatorRendimento1 * mes * 10) + valor;



            else return 0;
        }
    }
}

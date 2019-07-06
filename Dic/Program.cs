using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
namespace Dic
{
    class Program
    {
        static void Main(string[] args)
        {
            string decisao;
            do
            {
            
            Invest invest = new Invest();
            Dictionary<string, double> pessoas = new Dictionary<string, double>();
            Dictionary<string, double> dinheiro = new Dictionary<string, double>();
            Console.WriteLine("SEJA BEM VINDO ! DIGITE QUANTOS CADASTROS QUER REALIZAR");
            int num = int.Parse(Console.ReadLine());
            double cc =0,c1=0;
            for (int i = 0; i < num; i++)
            {
                    try
                    {
                        Console.WriteLine("INFORME SEU NOME");
                        string name = Console.ReadLine();
                        Console.WriteLine("INFORME O VALOR DO INVESTIMENTO");
                        double inv = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("DIGITE AGORA O TIPO DE INVESTIMENTO, 1 PARA POUPANCA E 2 PARA TESOURO DIRETO ");
                        int op = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("QUANTO MESES DE INVESTIMENTO?");
                        int mes = int.Parse(Console.ReadLine());

                        while (inv < 0 || op < 0 || mes < 0)
                        {
                            Console.WriteLine("ERRO, DADOS INVÁLIDOS, OS DIGITE NOVAMENTE!");
                            Console.WriteLine("INFORME O VALOR DO INVESTIMENTO");
                            inv = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.WriteLine("DIGITE AGORA O TIPO DE INVESTIMENTO, 1 PARA POUPANCA E 2 PARA TESOURO DIRETO E 3 PARA CDI");
                            op = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("QUANTO MESES DE INVESTIMENTO?");
                            mes = int.Parse(Console.ReadLine());

                        }
                        double d = invest.CalcularInvestimento(op, inv, mes);

                        pessoas.Add(name, inv);
                        dinheiro.Add(name, d);
                        c1 += inv;
                        cc += d;

                        Console.Clear();
                        Console.WriteLine("INFORMAÇÕES CADASTRADAS!");
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("ERRO DADOS INVÁLIDOS, DIGITE NOVAMENTE!");
                        i--;
                    }
            }

            foreach (KeyValuePair<string,double> pessoa in pessoas )
            {
               Console.WriteLine($"NOME: {pessoa.Key} INVENTIMENTO INICAL: {pessoa.Value}");
                    Console.WriteLine("");
            }

            foreach (KeyValuePair<string, double> investe in dinheiro)
            {
                Console.WriteLine($"NOME: {investe.Key} INVENTIMENTO FINAL: {investe.Value}");
                    Console.WriteLine("");
                }
            Console.WriteLine("");

            double media = cc / num;
            Console.WriteLine($"A MEDIA DOS REDIMENTOS É:{media.ToString("F2",CultureInfo.InvariantCulture)}");

                Console.WriteLine("DESEJA CONSULTAR NOVAMENTE ? ? DIGITE SIM PARA CONTINUAR E NAO PARA SAIR");
                decisao = Console.ReadLine().ToUpper();

                Console.Clear();
            } while (decisao == "SIM");
        }
    }
}

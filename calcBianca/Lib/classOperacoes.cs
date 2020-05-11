using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcBianca.Lib
{
    class classOperacoes
    {
        // variavel criada para guardar um log temporario para possivel erro em tempo de execução
        static string errorMsg;

        public double pegaOperacao(double n1, double n2, string operacao)
        {
            Nullable<double> valida = 0;

            switch (operacao) 
            {
                case "+":
                    valida = soma(n1, n2);
                    break;
                case "-":
                    valida = subtracao(n1,n2);
                    break;
                case "/":
                    valida = divisao(n1, n2);
                    break;
                case "*":
                    valida = multiplicacao(n1, n2);
                    break;
                default:
                    valida = 0;
                    break;
            }

            return Convert.ToDouble(valida);
        }

        public double soma(double n1, double n2)
        {
            try
            {
                return n1 + n2;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return 0;
            }
        }

        public double subtracao(double n1, double n2)
        {
            try
            {
                return n1 - n2;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return 0;
            }
        }
        public double divisao(double n1, double n2)
        {
            try
            {
                return n1 / n2;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return 0;
            }
        }
        public double multiplicacao(double n1, double n2)
        {
            try
            {
                return n1 * n2;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return 0;
            }
        }

    }
}

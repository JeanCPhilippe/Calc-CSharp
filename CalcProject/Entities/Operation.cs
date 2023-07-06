using CalcProject.Exception;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcProject.Entities
{
    public class Operation
    {
        public string Manipulation { get; set; }
        public Operation() { }

        //Método responsável por fazer a Soma dos valores
        public string Sum (string value1, string value2)
        {
            int v1 = int.Parse(value1);
            int v2 = int.Parse(value2);
            int r = v1 + v2;
            return r.ToString();
        }
        //Método responsável por fazer a subtração dos valores
        public string Sub(string value1, string value2)
        {
            int v1 = int.Parse(value1);
            int v2 = int.Parse(value2);
            int r = v1 - v2;
            return r.ToString();
        }
        //Método responsável por fazer a divisão dos valores
        public string Div(string value1, string value2)
        {
            int v1 = int.Parse(value1);
            int v2 = int.Parse(value2);
            int r;

            //Verificando se a divisão será feita por 0
            if (v2 == 0)
            {
                return "Impossible to divide by zero";
            }
            r = v1 / v2;
            return r.ToString();
        }
        //Método responsável por fazer a multiplicação dos valores
        public string Mult(string value1, string value2)
        {
            int v1 = int.Parse(value1);
            int v2 = int.Parse(value2);
            int r = v1 * v2;
            return r.ToString();
        }

        //Método que recebe a string com os valores e operadores e separa eles em um array
        public string[] Exec(string account)
        {
            
            return account.Split();
        }

        //Método que irá receber os valores e irá fazer as contas
        public string ExecAcc(string[] count)
        {
            //Utilizamos a Lista para que possamos remover os valores já utilizados no calculo
            List<string> values = new List<string>(count);
            //String que será retornada no final do método
            string result = "";
            
            //Laço de repetição que será executado enquanto houver valores no array 
            while (values.Count > 1)
            {
                //Laço que é responsável por fazer as contas de divisão e multiplicação
                for (int i = 1; i < values.Count;i+=2)
                {
                    if (values[i] == "/")
                    {

                        string value1 = values[i - 1];
                        string value2 = values[i + 1];

                        values[i - 1] = Div(value1, value2);
                        values.RemoveAt(i);
                        values.RemoveAt(i);

                        i -= 2;
                    }
                    else if (values[i] == "*")
                    {
                        string value1 = values[i - 1];
                        string value2 = values[i + 1];

                        values[i - 1] = Mult(value1, value2);
                        values.RemoveAt(i);
                        values.RemoveAt(i);

                        i -= 2;
                    }
                }
                //Laço que é responsável por fazer as contas de divisão e multiplicação
                for (int i = 1; i < values.Count; i+=2)
                {
                    if (values[i] == "+")
                    {
                        string value1 = values[i - 1];
                        string value2 = values[i + 1];

                        values[i - 1] = Sum(value1, value2);
                        values.RemoveAt(i);
                        values.RemoveAt(i);

                        i -= 2;
                    }
                    else if (values[i] == "-")
                    {
                        string value1 = values[i - 1];
                        string value2 = values[i + 1];

                        values[i - 1] = Sub(value1, value2);
                        values.RemoveAt(i);
                        values.RemoveAt(i);

                        i -= 2;
                    }
                }
                /*  
                 * Existem 2 laços for para que o primeiro seja percorrido e a preferência de divisão e multiplicação e
                 * somente após as contas preferênciais serem executadas as somas e subtrações;
                */
            }

            result = values[0];

            return result;
        }
    }
}

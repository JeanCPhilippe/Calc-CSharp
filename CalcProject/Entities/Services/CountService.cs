using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcProject.Entities.Services
{
    public class CountService
    {
        public string Value { get; set; }

        public CountService()
        {
            Value = string.Empty;
        }
        public CountService(string value)
        {
            this.Value = value;
        }

        //Adiciona o valor na string para fazer a conta
        public string AddValue(string valueS)
        {
            Value = Value.Insert(Value.Length , valueS);
            return Value;
        }
        //Remove o valor da string
        public string RemoveValue()
        {
            Value = Value.Remove(Value.Length, 1);
            return Value;
        }
        public string Count()
        {
            return Value;
        }
        
    }
}

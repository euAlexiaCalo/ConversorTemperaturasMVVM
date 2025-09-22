using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturasMVVM.Models
{
    public class MainModels
    {
        // Dicionário para armazenar as taxas de conversão
        private readonly Dictionary<string, double> _conversionRates = new()
        {
            { "Celsius = Fahrenheit", 9.0 / 5.0 }, // Taxa de conversão de Celsius para Fahrenheit
            { "Fahrenheit = Celsius", 5.0 / 9.0 }  // Taxa de conversão de Fahrenheit para Celsius
        };

        // Propriedade pública para acessar as taxas de conversão
        public IReadOnlyDictionary<string, double> ConversionRates => _conversionRates;

        // Retorna os tipos de conversão disponíveis
        public IEnumerable<string> GetConversionTypes() => _conversionRates.Keys;

        public double Convert(double amount, string from)
        {
            // Cálculo de conversão de Celsius para Fahrenheit
            if (from == "Celsius = Fahrenheit")
            {
                return (amount * _conversionRates[from]) + 32;
            }
            else if (from == "Fahrenheit = Celsius")
            {
                return (amount - 32) * _conversionRates[from];
            }
            else
            {
                return amount;
            }
        }
    }
}

using ConversorTemperaturasMVVM.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ConversorTemperaturasMVVM.ViewModels
{
    public partial class MainViewModels : INotifyPropertyChanged
    {
        // Aviso de evento para notificar a View sobre mudanças nas propriedades do ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;

        // Método que dispara o evento PropertyChanged para notificar a View sobre mudanças nas propriedades do ViewModel
        // CallerMemberName - atributo que permite obter o nome do membro que chamou o método, sem especificar o nome manualmente.
        void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        // Instância do modelo que contém a lógica de conversão
        private readonly MainModels _models = new();

        public IList<string> Temperatures { get; } // Lista de tipos de conversão disponíveis

        string? _from;

        public string? From // Propriedade pública para o tipo de conversão
        {
            get => _from; // Obtém o tipo de conversão
            set
            {
                if (_from != value)
                {
                    _from = value; // Atualiza com o novo tipo de conversão
                    OnPropertyChanged(); // Notifica a View sobre a mudança
                }
            }
        }

        string? _amountText; // Campo privado para armazenar o valor de entrada

        public string? AmountText // Propriedade pública para o valor de entrada
        {
            get => _amountText; // Obtém o valor de entrada
            set
            {
                if (_amountText != value)
                {
                    _amountText = value; // Atualiza com o novo valor
                    OnPropertyChanged(); // Notifica a View sobre a mudança
                }
            }
        }

        string? _resultText; // Resultado da conversão

        public string? ResultText // Propriedade pública para o resultado da conversão
        {
            get => _resultText;
            set
            {
                if (_resultText != value)
                {
                    _resultText = value; //Atualiza com o novo valor
                    OnPropertyChanged(); // Notifica a View sobre a mudança}
                }
            }
        }

        public ICommand ConvertCommand { get; } // Comando para acionar a conversão

        public ICommand ClearCommand { get; } // Comando para limpar os campos

        public MainViewModels() // Construtor do ViewModel
        {
            // Inicializa a lista de tipos de conversão
            Temperatures = _models.GetConversionTypes().ToList();
            // Inicializa o comando de conversão
            ConvertCommand = new Command(execute: () =>
            {
                if (string.IsNullOrWhiteSpace(AmountText)) // Verifica se o campo está nulo ou vazio
                {
                    ResultText = "Por favor, insira um valor numérico válido."; // Mensagem de erro
                    return; // Sai do método
                }

                // Tenta converter o valor para decimal
                if (double.TryParse(AmountText.Replace(".", ","), out double amount))
                {
                    double fahrenheit = _models.Convert(amount, From);
                    if (From == "Celsius = Fahrenheit")
                    {
                        ResultText = $"{amount:F2} °C = {fahrenheit:F2} °F";
                    }
                    else if (From == "Fahrenheit = Celsius")
                    {
                        ResultText = $"{amount:F2} °F = {fahrenheit:F2} °C";
                    }
                }
                else
                {
                    ResultText = "Digite um valor válido!";
                }
            });

            // Inicializa o comando de limpar
            ClearCommand = new Command(execute: () =>
            {
                AmountText = string.Empty; // Limpa o valor digitado pelo usuário
                ResultText = string.Empty; // Limpa o resultado exibido
            });
        }
    }
}

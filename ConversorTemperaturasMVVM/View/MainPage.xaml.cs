using ConversorTemperaturasMVVM.ViewModels;

namespace ConversorTemperaturasMVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModels();
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QedClientApp.Models;
using QedClientApp.Services.Abstract;
using System.Threading.Tasks;

namespace QedClientApp.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        IHttpService _service;
        public IRelayCommand PerformOperation { get; }

        [ObservableProperty]
        private Data data;

        [ObservableProperty]
        private string result;

        public MainWindowViewModel(IHttpService service)
        {
            result = string.Empty;
            data = new Data();
            _service = service;
            PerformOperation = new AsyncRelayCommand(AddNumbersAsync);

        }
        
        private async Task AddNumbersAsync()
        {
            var result = await _service.PerformApiOperationAsync(Data.FirstNumber, Data.SecondNumber);

            if (!string.IsNullOrEmpty(result))
            {
                Result = result;
            }

        }

    }
}

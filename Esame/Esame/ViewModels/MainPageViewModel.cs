using Template10.Mvvm;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using Esame.Models;
using Windows.UI.Xaml;

namespace Esame.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand<TipoGruppo> DeleteItemCommand
        {
            get; set;
        }

        public MainPageViewModel()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
            }

            DeleteItemCommand = new DelegateCommand<TipoGruppo>
            (
                gruppo => { DeleteItem(gruppo); }, //Execute
                gruppo => { return gruppo != null; } //CanExecute
            );
        }


        private ObservableCollection<TipoGruppo> _GruppoList;
        public ObservableCollection<TipoGruppo> GruppoList
        {
            get
            {
                if (_GruppoList == null)
                    _GruppoList = new ObservableCollection<TipoGruppo>(Services.DataServices.DefaultService.getGruppi());
                return _GruppoList;
            }
        }


        TipoGruppo m_SelectedGruppo;
        public TipoGruppo SelectedGruppo
        {
            get
            {
                return m_SelectedGruppo;
            }
            set
            {
                m_SelectedGruppo = value;
                RaisePropertyChanged();
                RaisePropertyChanged("GruppoControlVisibility");
            }
        }

        public Visibility GruppoControlVisibility
        {
            get
            {
                if (SelectedGruppo != null)
                    return Visibility.Visible;
                else
                    return Visibility.Collapsed;
            }
        }
        
        public void DeleteItem(TipoGruppo g)
        {
            Services.DataServices.DefaultService.Delete(g);
            _GruppoList.Remove(g);
        }

        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            if (state.Any())
            {
                //Value = state[nameof(Value)]?.ToString();
                state.Clear();
            }
            return Task.CompletedTask;
        }

        public override Task OnNavigatedFromAsync(IDictionary<string, object> state, bool suspending)
        {
            if (suspending)
            {
                //state[nameof(Value)] = Value;
            }
            return Task.CompletedTask;
        }

        public override Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            return Task.CompletedTask;
        }
        
        public void GotoSettings() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 0);

        public void GotoPrivacy() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 1);

        public void GotoAbout() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 2);

    }
}


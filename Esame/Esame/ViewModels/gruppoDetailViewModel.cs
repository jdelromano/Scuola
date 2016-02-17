using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

using Template10.Mvvm;
using Template10.Services.NavigationService;
using System;

namespace Esame.ViewModels
{
    public class gruppoDetailViewModel : ViewModelBase
    {

        public gruppoDetailViewModel()
        {
            Model = new gruppoDetail();
        }

        public void gruppoDetailChanged(gruppoDetail newValue)
        {
            Model = newValue;
        }
        
        public String Nome
        {
            get { return Model.Nome; }
            set
            {
                Model.Nome = value;
                RaisePropertyChanged();
            }
        }


        public String ID
        {
            get { return Model.ID; }
            set
            {
                Model.ID = value;
                RaisePropertyChanged();
            }
        }


        private gruppoDetail m_Model;

        public gruppoDetail Model
        {
            get { return m_Model; }
            set
            {
                m_Model = value;
                RaisePropertyChanged();
                RaisePropertyChanged("Nome");
                RaisePropertyChanged("ID");

            }
        }


        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            if (state.ContainsKey(nameof(Model)))
            {

                Model = gruppoDetail.fromJson(state[nameof(Model)]?.ToString());
                state.Clear();
            }
            else
            {
                Model = gruppoDetail.fromJson(parameter?.ToString());
            }
            return Task.CompletedTask;
        }

        public override Task OnNavigatedFromAsync(IDictionary<string, object> state, bool suspending)
        {
            if (suspending)
            {
                state[nameof(Model)] = Model.toJson();
            }
            return Task.CompletedTask;
        }

        public override Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            return Task.CompletedTask;
        }
    }
}

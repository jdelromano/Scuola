using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Windows.UI.Xaml;
using Esame.Services;
using Esame.Models;
using System.Collections.ObjectModel;

namespace Esame.ViewModels
{
    class GruppoViewModel : ViewModelBase
    {
        public string Nome
        {
            get { return Model.Nome; }
            set
            {
                Model.Nome = value;
                RaisePropertyChanged();
            }
        }

        public string Responsabile
        {
            get { return Model.Responsabile; }
            set
            {
                Model.Responsabile = value;
                RaisePropertyChanged();
            }
        }

        public int ID
        {
            get { return Model.ID; }
        }

        public GruppoViewModel()
        {
            Model = new TipoGruppo();
        }

        public void GruppoChanged(object newValue)
        {
            Model = (TipoGruppo)newValue;
        }

        TipoGruppo m_Model;
        private TipoGruppo Model
        {
            get
            {
                return m_Model;
            }
            set
            {
                m_SelectedPersona = null;
                RaisePropertyChanged("PersonaControlVisibility");
                _PersonePerGruppoList = null;
                m_Model = value;
                if (m_Model != null)
                {
                    _PersonePerGruppoList = new ObservableCollection<TipoPersona>(Services.DataServices.DefaultService.getPersonePerGruppo(m_Model));
                    RaisePropertyChanged();
                    RaisePropertyChanged("ID");
                    RaisePropertyChanged("Nome");
                    RaisePropertyChanged("Responsabile");
                    RaisePropertyChanged("PersonePerGruppoList");
                }
            }
        }
        
        private ObservableCollection<TipoPersona> _PersonePerGruppoList;
        public ObservableCollection<TipoPersona> PersonePerGruppoList
        {
            get
            {
                return _PersonePerGruppoList;
            }
        }


        TipoPersona m_SelectedPersona;
        public TipoPersona SelectedPersona
        {
            get
            {
                return m_SelectedPersona;
            }
            set
            {
                m_SelectedPersona = value;
                RaisePropertyChanged();
                RaisePropertyChanged("PersonaControlVisibility");
            }
        }

        public Visibility PersonaControlVisibility
        {
            get
            {
                if (SelectedPersona != null)
                    return Visibility.Visible;
                else
                    return Visibility.Collapsed;
            }
        }

    }
}

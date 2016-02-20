using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Windows.UI.Xaml;
using Esame.Services;
using Esame.Models;

namespace Esame.ViewModels
{
    class PersonaViewModel : ViewModelBase
    {

        public int ID
        {
            get { return Model.ID; }
        }

        public string Nome
        {
            get { return Model.Nome; }
            set
            {
                Model.Nome = value;
                RaisePropertyChanged();
            }
        }

        public string Cognome
        {
            get { return Model.Cognome; }
            set
            {
                Model.Cognome = value;
                RaisePropertyChanged();
            }
        }

        public string Telefono
        {
            get { return Model.Telefono; }
            set
            {
                Model.Telefono = value;
                RaisePropertyChanged();
            }
        }

        public DateTime Nascita
        {
            get { return Model.Nascita; }
            set
            {
                Model.Nascita = value;
                RaisePropertyChanged();
            }
        }

        public int GruppoId
        {
            get { return Model.GruppoId; }
            set
            {
                Model.GruppoId = value;
                RaisePropertyChanged();
            }
        }

        public PersonaViewModel()
        {
            Model = new TipoPersona();
        }

        public void PersonaChanged(object newValue)
        {
            Model = (TipoPersona)newValue;
        }

        TipoPersona m_Model;
        private TipoPersona Model
        {
            get
            {
                return m_Model;
            }
            set
            {
                m_Model = value;
                if (m_Model != null)
                {
                    RaisePropertyChanged();
                    RaisePropertyChanged("ID");
                    RaisePropertyChanged("Nome");
                    RaisePropertyChanged("Cognome");
                    RaisePropertyChanged("Telefono");
                    RaisePropertyChanged("Nascita");
                    RaisePropertyChanged("GruppoId");
                }
            }
        }

    }
}

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
                m_Model = value;
                RaisePropertyChanged();
                RaisePropertyChanged("ID");
                RaisePropertyChanged("Nome");
                RaisePropertyChanged("Responsabile");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;


using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;

namespace Esame.ViewModels
{
    public class personaDetail : INotifyPropertyChanged
    {
        private String nome = "";
        private String cognome = "";
        private String telefono = "";
        private DateTime nascita = new DateTime();
        private gruppoDetail gr = null;

        public personaDetail()
        {
        }

        public personaDetail(String nome)
        {
            this.nome = nome;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
                
        public String Nome
        {
            get { return nome; }
            set {
                nome = value;
                NotifyPropertyChanged("Nome");
            }
        }

        public gruppoDetail Gruppo
        {
            get { return gr; }
            set {
                gr = value;
                NotifyPropertyChanged("Gruppo");
            }
        }

        public String Cognome
        {
            get { return cognome; }
            set {
                cognome = value;
                NotifyPropertyChanged("Cognome");
            }
        }
        public String Telefono
        {
            get { return telefono; }
            set {
                telefono = value;
                NotifyPropertyChanged("Telefono");
            }
        }
        public DateTime Nascita
        {
            get { return nascita; }
            set {
                nascita = value;
                NotifyPropertyChanged("Nascita");
            }
        }

        public String textPerTitolo { get { return Cognome + " " + Nome; } }

        public String toJson()
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(personaDetail));
            ser.WriteObject(stream, this);
            return ser.ToString();
        }

        public static personaDetail fromJson(String json)
        {
            if (json.Length == 0)
                return new personaDetail("");

            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(json);
            writer.Flush();
            stream.Position = 0;
            
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(personaDetail));
            personaDetail toReturn = (personaDetail)ser.ReadObject(stream);
            return toReturn;
        }
        
    }

    public class personaViewModel : ViewModelBase
    {
        public personaViewModel()
        {
            Value = new personaDetail();
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                Value.Nome = "nome";
                Value.Cognome = "cognome";
                Value.Telefono = "telefono";
                Value.Nascita = new DateTime(1982, 12, 19);
                Value.Gruppo = new gruppoDetail();
            }
            else
            {
                Value.Nome = "nome";
                Value.Cognome = "cognome";
                Value.Telefono = "telefono";
                Value.Nascita = new DateTime(1982, 12, 19);
                Value.Gruppo = new gruppoDetail();
                Value.Gruppo.Nome = "nomeGruppo";
            }
        }

        private personaDetail _Value;
        public personaDetail Value { get { return _Value; } set { Set(ref _Value, value); } }

        public String Nome { get { return _Value.Nome; } set { _Value.Nome = value; } }

        public String Cognome { get { return _Value.Cognome; } set { _Value.Cognome = value; } }

        public String Telefono { get { return _Value.Telefono; } set { _Value.Telefono = value; } }

        public DateTime Nascita { get { return _Value.Nascita; } set { _Value.Nascita = value; } }

        public gruppoDetail Gruppo { get { return _Value.Gruppo; } set { _Value.Gruppo = value; } }

        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            if (state.ContainsKey(nameof(Value)))
            {

                Value = personaDetail.fromJson(state[nameof(Value)]?.ToString());
                state.Clear();
            }
            else
            {
                Value = personaDetail.fromJson(parameter?.ToString());
            }
            return Task.CompletedTask;
        }

        public override Task OnNavigatedFromAsync(IDictionary<string, object> state, bool suspending)
        {
            if (suspending)
            {
                state[nameof(Value)] = Value.toJson();
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

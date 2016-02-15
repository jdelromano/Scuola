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
    public class gruppoDetail : INotifyPropertyChanged
    {
        private int _ID;
        private String nome;
        private personaDetail responsabile;

        public int ID
        {
            get { return ID; }
        }

        public gruppoDetail(String nome, personaDetail responsabile)
        {
            this.nome = nome;
            this.responsabile = responsabile;
        }

        public gruppoDetail(String nome)
        {
            this.nome = nome;
            this.responsabile = null;
        }
        
        public gruppoDetail()
        {
            this.nome = "";
            this.responsabile = null;
        }

        public String Nome
        {
            get { return nome; }
            set {
                nome = value;
                NotifyPropertyChanged("Nome");
            }
        }

        public personaDetail Responsabile
        {
            get { return responsabile; }
            set { responsabile = value;
                NotifyPropertyChanged("Responsabile");
            }
        }

        public String toJson()
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(gruppoDetail));
            ser.WriteObject(stream, this);
            return ser.ToString();
        }

        public static gruppoDetail fromJson(String json)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(json);
            writer.Flush();
            stream.Position = 0;
            
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(gruppoDetail));
            gruppoDetail toReturn = (gruppoDetail)ser.ReadObject(stream);
            return toReturn;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public static IEnumerable<gruppoDetail> generateGroupList()
        {
            var list = new List<gruppoDetail>();

            var gr = new gruppoDetail();
            gr.Nome = "Gruppo 1";
            gr.Responsabile = new personaDetail();
            gr.responsabile.Nome = "Responsabile1 Nome";
            gr.responsabile.Cognome = "Responsabile1 Cognome";
            gr.responsabile.Telefono = "Responsabile1 Telefono";
            list.Add(gr);

            gr = new gruppoDetail();
            gr.Nome = "Gruppo 2";
            gr.Responsabile = new personaDetail();
            gr.responsabile.Nome = "Responsabile2 Nome";
            gr.responsabile.Cognome = "Responsabile2 Cognome";
            gr.responsabile.Telefono = "Responsabile2 Telefono";
            list.Add(gr);
            return list;
        }

    }

    public class gruppoViewModel : ViewModelBase
    {
        public gruppoViewModel()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                personaDetail p = new personaDetail("responsabile");
                Value = new gruppoDetail("nome gruppo", p);
            }
        }

        private gruppoDetail _Value;
        public gruppoDetail Value { get { return _Value; } set { Set(ref _Value, value); } }

        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            if (state.ContainsKey(nameof(Value)))
            {

                Value = gruppoDetail.fromJson(state[nameof(Value)]?.ToString());
                state.Clear();
            }
            else
            {
                Value = gruppoDetail.fromJson(parameter?.ToString());
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

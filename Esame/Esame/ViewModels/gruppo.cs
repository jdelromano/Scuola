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
    public class gruppoDetail
    {
        private String _ID;
        private String nome;
        private personaDetail responsabile;

        public String ID
        {
            get { return _ID; }
            set { this._ID = value; }
        }

        private void RaisePropertyChanged()
        {
            throw new NotImplementedException();
        }

        public String Nome
        {
            get { return nome; }
            set
            {
                nome = value;
            }
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
            this._ID = "";
            this.nome = "";
            this.responsabile = null;
        }


        public personaDetail Responsabile
        {
            get { return responsabile; }
            set { responsabile = value;
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


    }
    
    public class gruppoService
    {

        public static IEnumerable<gruppoDetail> getList()
        {
            var list = new List<gruppoDetail>();

            var gr = new gruppoDetail();
            gr.Nome = "Gruppo 1";
            gr.Responsabile = new personaDetail();
            gr.Responsabile.Nome = "R1nome";
            gr.Responsabile.Cognome = "R1cognome";
            gr.Responsabile.Telefono = "R1telefono";
            list.Add(gr);

            gr = new gruppoDetail();
            gr.Nome = "Gruppo 2";
            gr.Responsabile = new personaDetail();
            gr.Responsabile.Nome = "R2nome";
            gr.Responsabile.Cognome = "R2cognome";
            gr.Responsabile.Telefono = "R2 telefono";
            list.Add(gr);
            return list;
        }
    }
}

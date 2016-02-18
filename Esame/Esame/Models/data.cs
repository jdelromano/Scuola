using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Esame.Models
{
    public interface IDataService
    {
        List<TipoPersona> getPersone();
        List<TipoGruppo> getGruppi();
        List<TipoPersona> getPersonePerGruppo(TipoGruppo gr);
        void Delete(TipoPersona p);
        void Delete(TipoGruppo g);
    }

    public class DataServices
    {
        public static IDataService DataService { get; set; }
    }


    public class TipoPersona
    {
        private int m_id;
        public int ID { get { return m_id; } set { m_id = value; } }

        private string m_nome;
        public string Nome { get { return m_nome; } set { m_nome = value; } }
        private string m_cognome;
        public string Cognome { get { return m_cognome; } set { m_cognome = value; } }
        private string m_telefono;
        public string Telefono { get { return m_telefono; } set { m_telefono = value; } }
        private DateTime m_nascita;
        public DateTime Nascita { get { return m_nascita; } set { m_nascita = value; } }
        private int m_gruppo = -1;
        public int GruppoId { get { return m_gruppo; } set { m_gruppo = value; } }


        public String toJson()
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TipoPersona));
            ser.WriteObject(stream, this);
            return ser.ToString();
        }

        public static TipoPersona fromJson(String json)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(json);
            writer.Flush();
            stream.Position = 0;

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TipoPersona));
            TipoPersona toReturn = (TipoPersona)ser.ReadObject(stream);
            return toReturn;
        }

    }

    public class TipoGruppo
    {
        private int m_id;
        public int ID { get { return m_id; } set { m_id = value; } }

        private string m_nome;
        public string Nome { get { return m_nome; } set { m_nome = value; } }

        private string m_responsabile;
        public string Responsabile { get { return m_responsabile; } set { m_responsabile = value; } }

        public String toJson()
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TipoGruppo));
            ser.WriteObject(stream, this);
            return ser.ToString();
        }

        public static TipoGruppo fromJson(String json)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(json);
            writer.Flush();
            stream.Position = 0;

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TipoGruppo));
            TipoGruppo toReturn = (TipoGruppo)ser.ReadObject(stream);
            return toReturn;
        }

    }

}

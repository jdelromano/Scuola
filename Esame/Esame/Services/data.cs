
using System;
using System.Collections.Generic;

namespace Esame.Services
{
    public class Persona
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
        private Gruppo m_gruppo = null;
        public Gruppo GruppoId { get { return m_gruppo; } set { m_gruppo = value; } }

    }

    public class Gruppo
    {
        private string m_nome;
        public string Nome { get { return m_nome; } set { m_nome = value; } }

        private string m_responsabile;
        public string Responsabile { get { return m_responsabile; } set { m_responsabile = value; } }
    }


    public class myService
    {
        public static IEnumerable<Gruppo> getGruppi()
        {
            var list = new List<Gruppo>();

            var retList = new List<Gruppo>();

            retList.Add(new Gruppo() { Nome = "Gruppo 1", Responsabile = "Resp1" });
            retList.Add(new Gruppo() { Nome = "Gruppo 2", Responsabile = "Resp2" });
            retList.Add(new Gruppo() { Nome = "Gruppo 3", Responsabile = "Resp3" });
            retList.Add(new Gruppo() { Nome = "Gruppo 4", Responsabile = "Resp4" });
            retList.Add(new Gruppo() { Nome = "Gruppo 5", Responsabile = "Resp5" });
            retList.Add(new Gruppo() { Nome = "Gruppo 6", Responsabile = "Resp6" });

            return retList;
            
        }

        public static IEnumerable<Persona> getPersone()
        {

            var retList = new List<Persona>();

            retList.Add(new Persona() { Nome = "Gruppo 1", Responsabile = "Resp1" });
            retList.Add(new Persona() { Nome = "Gruppo 2", Responsabile = "Resp2" });
            retList.Add(new Persona() { Nome = "Gruppo 3", Responsabile = "Resp3" });
            retList.Add(new Persona() { Nome = "Gruppo 4", Responsabile = "Resp4" });
            retList.Add(new Persona() { Nome = "Gruppo 5", Responsabile = "Resp5" });
            retList.Add(new Persona() { Nome = "Gruppo 6", Responsabile = "Resp6" });

            return retList;

        }
    }
}
    
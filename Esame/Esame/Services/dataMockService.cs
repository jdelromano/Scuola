using Esame.Models;
using System;
using System.Collections.Generic;

namespace Esame.Services
{
    
    public class mockServices : IDataService
    {
        public List<TipoGruppo> getGruppi()
        {
            var list = new List<TipoGruppo>();

            var retList = new List<TipoGruppo>();

            retList.Add(new TipoGruppo() { ID = 1, Nome = "TipoGruppo 1", Responsabile = "Resp1" });
            retList.Add(new TipoGruppo() { ID = 2, Nome = "TipoGruppo 2", Responsabile = "Resp2" });
            retList.Add(new TipoGruppo() { ID = 3, Nome = "TipoGruppo 3", Responsabile = "Resp3" });

            return retList;

        }
               
        public List<TipoPersona> getPersone()
        {

            var retList = new List<TipoPersona>();
            for (int i = 10; i < 40; i++)
            {
                TipoPersona toAdd = new TipoPersona();
                toAdd.ID = i;
                toAdd.Nome = "Nome" + i;
                toAdd.Cognome = "Cognome" + i;
                toAdd.Telefono = "Telefono" + i;
                toAdd.Nascita = DateTime.Now;
                toAdd.GruppoId = (i % 3) + 1;
                retList.Add(toAdd);
            }
            return retList;

        }
               
        public List<TipoPersona> getPersonePerGruppo(TipoGruppo gr)
        {
            var retList = new List<TipoPersona>();
            for (int i = 10; i < 40; i++)
            {
                int grId = (i % 3) + 1;
                if (grId != gr.ID)
                    continue;

                TipoPersona toAdd = new TipoPersona();
                toAdd.ID = i;
                toAdd.Nome = "Nome" + i;
                toAdd.Cognome = "Cognome" + i;
                toAdd.Telefono = "Telefono" + i;
                toAdd.Nascita = DateTime.Now;
                retList.Add(toAdd);
            }
            return retList;
        }


        public void Delete(TipoPersona p)
        {
            //al momento non faccio nulla
        }

        public void Delete(TipoGruppo g)
        {

        }
    }
}

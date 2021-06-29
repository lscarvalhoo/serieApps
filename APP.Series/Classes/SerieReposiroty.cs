using System;
using System.Collections.Generic;
using APP.Series.Interfaces;

namespace APP.Series
{
  public class SerieRepository : IRepository<Series>
	{
        private List<Series> listaSerie = new List<Series>();
		public void Atualiza(int id, Series objeto)
		{
			listaSerie[id] = objeto;
		}

        public void Exclude(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insert(Series entity)
        {
            listaSerie.Add(entity);
        }

        public List<Series> List()
        {
            return listaSerie;
        }

        public int NextId()
        {
            return listaSerie.Count;
        }

        public void Refresh(int id, Series entity)
        {
            throw new NotImplementedException();
        }

        public Series ReturnById(int id)
        {
            return listaSerie[id];
        }

        void IRepository<Series>.NextId()
        {
            throw new NotImplementedException();
        }
    }
}
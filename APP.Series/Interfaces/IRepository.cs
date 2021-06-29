using System.Collections.Generic;
namespace APP.Series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnById(int id);
        void Insert(T entity);
        void Exclude(int id);
        void Refresh(int id, T entity);
        void NextId();
    }
}
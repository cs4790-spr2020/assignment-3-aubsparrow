using System.Collections.Generic;

namespace BlabberApp.Domain
{
    public interface IRepository
    {
        T Add<T>(T item) where T : BaseDatum;
        void Delete<T>(T item) where T : BaseDatum;
        List<BaseDatum> GetAll<T>() where T : BaseDatum;
        T GetByID<T>(string sysId) where T : BaseDatum;
        void Update <T> (T oldItem, T newItem) where T : BaseDatum;
    }
}
using System.Collections.Generic;

namespace BlabberApp.Domain
{
    public interface IRepository
    {
        T Add<T>(T item) where T : BaseDatum;
        void Delete<T>(T item) where T : BaseDatum;
        List<T> GetAll<T>(ISpecification<T> spec = null) where T : BaseDatum;
        T GetByID<T>(string sysId) where T : BaseDatum;
        void Update <T> (T item) where T : BaseDatum;
    }
}
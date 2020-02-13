using System;
using System.Collections;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class InMemory : IDataStore
    {

        private ArrayList _items = new ArrayList();

        public bool Create(IDatum datum)
        {
            int idx = this._items.Add(datum);
            if(idx < 0)
            {
                throw new ArgumentOutOfRangeException("OH HELL NO");
            }
            return true;
        }

        public IDatum Read(int index)
        {
            return (IDatum)this._items[index];
        }

        public bool Update(IDatum datum)
        {
            return true;
        }

        public bool Delete(int index)
        {
            try
            {
                this._items.RemoveAt(index);
            }
            catch(ArgumentOutOfRangeException ex){
                throw ex;
            }
            return true;
        }
    }
}

using System;
using System.Collections;
using BlabberApp.Domain;
using System.Collections.Generic;

namespace BlabberApp.DataStore
{
    public class InMemory : IRepository
    {

        private List<BaseDatum> _items;
        public List<BaseDatum> Items
        {
            get
            {
                return this._items;
            }
        }

        public InMemory()
        {
            this._items = new List<BaseDatum>();
        }

        public T Add<T>(T item) where T : BaseDatum
        {
            this._items.Add(item);
            return item;
        }

        public void Delete<T>(T item) where T : BaseDatum
        {
            this._items.Remove(item);
            return;
        }

        public T GetByID<T>(string sysId) where T : BaseDatum
        {
            int index = this._items.FindIndex(item => item.getSysId() == sysId);
            //Console.WriteLine("for now returns items at 0, needs helper method");
            return (T)this._items[index];
        }

        public List<BaseDatum> GetAll<T>() where T : BaseDatum
        {
            return this._items;
        }

        public void Update <T> (T oldItem, T newItem) where T : BaseDatum
        {
            int index = this._items.FindIndex(itemInList => itemInList == oldItem);
            this._items[index] = newItem;
            return;
        }


        // public bool Create(IDatum datum)
        // {
        //     int idx = this._items.Add(datum);
        //     if(idx < 0)
        //     {
        //         throw new ArgumentOutOfRangeException("OH HELL NO");
        //     }
        //     return true;
        // }

        // public IDatum Read(int index)
        // {
        //     return (IDatum)this._items[index];
        // }

        // public bool Update(IDatum datum)
        // {
        //     return true;
        // }

        // public bool Delete(int index)
        // {
        //     try
        //     {
        //         this._items.RemoveAt(index);
        //     }
        //     catch(ArgumentOutOfRangeException ex){
        //         throw ex;
        //     }
        //     return true;
        // }
    }
}

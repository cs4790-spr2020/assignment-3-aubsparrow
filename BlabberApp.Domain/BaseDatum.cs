using System;
//using BlabberApp.Domain.IDatum;

namespace BlabberApp.Domain
{
    public class BaseDatum : IDatum 
    {
        private string _sysId;
        public BaseDatum()
        {
            this._sysId = Guid.NewGuid().ToString();
        }
        public string getSysId()
        {
            return this._sysId;
        }
    }    
}
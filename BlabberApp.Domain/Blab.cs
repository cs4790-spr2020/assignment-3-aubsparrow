using System;

namespace BlabberApp.Domain
{
    public class Blab : BaseDatum
    {
        private string _message;
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        private DateTime _dttm;
        public DateTime DTTM
        {
            get { return this._dttm; }
            set { this._dttm = value; }
        } //DTTM = DateTime
        private string _userId; //probably will change
        public string UserID
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

    }
}
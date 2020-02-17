
using System;

namespace BlabberApp.Domain
{
    public class Notification : BaseDatum
    {
        private DateTime _regDTTM;
        public DateTime RegDTTM
        {
            get { return this._regDTTM; }
            set { this._regDTTM = value; }
        }

        private string _contentText;
        public string ContentText
        {
            get{return this._contentText;}
            set{this._contentText = value;}
        }

        private string _contentTitle;
        public string ContentTitle
        {
            get{return this._contentTitle;}
            set{this._contentTitle = value;}
        }

    }
}
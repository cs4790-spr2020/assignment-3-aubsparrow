using System;
using System.Net.Mail;
using BlabberApp.Domain;

namespace BlabberApp.Domain
{
    public class User : BaseDatum
    {
        private DateTime _regDTTM;
        public DateTime RegDTTM
        {
            get { return this._regDTTM; }
            set { this._regDTTM = value; }
        }

        private DateTime _lastLoginDTTM;
        public DateTime LastLoginDTTM
        {
            get { return this._lastLoginDTTM; }
            set { this._lastLoginDTTM = value; }
        }

        private string _userId;
        public string UserID
        {
            get { return this._userId; }
            set
            {
                try
                {
                    MailAddress m = new MailAddress(value);
                    this._userId = value;
                }
                catch (FormatException)
                {
                    throw new FormatException("not an email");
                }
            }
        }
    }

}
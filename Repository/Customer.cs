using System;

namespace Repository
{
    /// <summary>
    /// Mathias
    /// </summary>
    public class Customer : DollarRate
    {
        private int _Id;
        private string _Name;
        private string _Address;
        private string _ZipCity;
        private string _Country;
        private string _Phone;
        private string _MailAdr;
        private string _MemberKey;
        private DateTime _MemberDate;

        public Customer()
        {

        }



        public int Id
        {
            get { return _Id; }
            set
            {
                if (value != _Id)
                {
                    _Id = value;
                    Notify("Id");
                }
            }
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != _Name)
                {
                    _Name = value;
                    Notify("Name");
                }
            }
        }

        public string Address
        {
            get { return _Address; }
            set
            {
                if (value != _Address)
                {
                    _Address = value;
                    Notify("Address");
                }
            }
        }

        public string ZipCity
        {
            get { return _ZipCity; }
            set
            {
                if (value != _ZipCity)
                {
                    _ZipCity = value;
                    Notify("ZipCity");
                }
            }
        }

        public string Country
        {
            get { return _Country; }
            set
            {
                if (value != _Country)
                {
                    _Country = value;
                    Notify("Country");
                }
            }
        }

        public string Phone
        {
            get { return _Phone; }
            set
            {
                if (value != _Phone)
                {
                    _Phone = value;
                    Notify("Phone");
                }
            }
        }

        public string MailAdr
        {
            get { return _MailAdr; }
            set
            {
                if (value != _MailAdr)
                {
                    _MailAdr = value;
                    Notify("MailAdr");
                }
            }
        }

        public string MemberKey
        {
            get { return _MemberKey; }
            set
            {
                if (value != _MemberKey)
                {
                    _MemberKey = value;
                    Notify("MemberKey");
                }
            }
        }

        public DateTime MemberDate
        {
            get { return _MemberDate; }
            set
            {
                if (value != _MemberDate)
                {
                    _MemberDate = value;
                    Notify("MemberDate");
                }
            }
        }
    }
}

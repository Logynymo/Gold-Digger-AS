using System;

namespace Repository
{
    /// <summary>
    /// Mathias
    /// </summary>
    public class DollarRate : PreciusMetals
    {
        private int _Id;
        private double _Rate;
        private DateTime _RateDate;

        public DollarRate()
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

        public double Rate
        {
            get { return _Rate; }
            set
            {
                if (value != _Rate)
                {
                    _Rate = value;
                    Notify("Rate");
                }
            }
        }

        public DateTime RateDate
        {
            get { return _RateDate; }
            set
            {
                if (value != _RateDate)
                {
                    _RateDate = value;
                    Notify("RateDate");
                }
            }
        }
    }
}

using System;

namespace Repository
{
    public class ClassDollarRate : ClassPreciusMetals
    {
        private int _Id;
        private double _Rate;
        private DateTime _RateDate;

        public ClassDollarRate()
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassPreciusMetals : ClassNotify
    {

        public ClassPreciusMetals()
        {

        }

        private int _Id;

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

        private string _Name;

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

        private double _DkkPrice;

        public double DkkPrice
        {
            get { return _DkkPrice; }
            set
            {
                if (value != _DkkPrice)
                {
                    _DkkPrice = value;
                    Notify("DkkPrice");
                }
            }
        }

        private double _UsdPrice;

        public double UsdPrice
        {
            get { return _UsdPrice; }
            set
            {
                if (value != _UsdPrice)
                {
                    _UsdPrice = value;
                    Notify("UsdPrice");
                }
            }
        }

        public double CalculateUsdPriceFromDkkPrice(double dkkPrice)
        {
           // return dkkPrice;
        }
    }
}

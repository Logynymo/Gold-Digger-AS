using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using IO;
using System.Collections.ObjectModel;

namespace BIZ
{

    public class ClassBiz : ClassNotify
    {
        ControllerDB CDB;
        private Customer _currentCustomer;
        private ObservableCollection<Customer> _customers;

        private ObservableCollection<PreciusMetals> _preciusMetals;

        public ClassBiz()
        {
            CDB = new ControllerDB();
            GetAllCustomersFromDB();
        }


        private Customer _fallbackCustomer;

        public Customer fallbackCustomer
        {
            get { return _fallbackCustomer; }
            set
            {
                if (value != _fallbackCustomer)
                {
                    _fallbackCustomer = value;
                    Notify("fallbackCustomer");
                }
            }
        }

        private PreciusMetals _cureentMetals;

        public PreciusMetals currentMetals
        {
            get { return _cureentMetals; }
            set
            {
                if (value != _cureentMetals)
                {
                    _cureentMetals = value;
                    Notify("currentMetals");
                }
            }
        }

        public ObservableCollection<PreciusMetals> preciusMetals
        {
            get { return _preciusMetals; }
            set
            {
                if (value != _preciusMetals)
                {
                    _preciusMetals = value;
                    Notify("preciusMetals");
                }
            }
        }

        public ObservableCollection<Customer> customers       
        {
            get { return _customers; }
            set
            {
                if (value != _customers)
                {
                    _customers = value;
                    Notify("customers");
                }
            }
        }

        public Customer currentCustomer
        {
            get { return _currentCustomer; }
            set
            {
                if (value != _currentCustomer)
                {
                    _currentCustomer = value;
                    Notify("currentCustomer");
                }
            }
        }
        

        public void GetAllCustomersFromDB()
        {
            customers = CDB.GetAllCustomers();
        }

        public void AddCustomer(Customer inCus)
        {
            CDB.InsertNewCustomer(inCus);
        }

        public void UpdateCustomer(Customer inCus)
        {
            CDB.UpdateCustomer(inCus);
        }

        public void DeleteCustomer(Customer inCus)
        {
            CDB.RemoveCustomer(inCus);
        }
    }
}

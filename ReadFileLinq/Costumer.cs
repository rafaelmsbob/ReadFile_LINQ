using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileLinq
{
    class Customer
    {
        private string _ID;
        private string _name;
        private string _lname;
        private string _city;
        private string _state;
        private string _postal;
        private string _balance; 

        public Customer (string ID, string name, string lname, string city, string state, string postal, string balance)
        {
            _ID = ID;
            _name = name;
            _lname = lname;
            _city = city;
            _state = state;
            _postal = postal;
            _balance = balance;
        }

        public string getID
        {
            get { return _ID; }
        }
        public string getname
        {
            get { return _name; }
        }

        public string getlname
        {
            get { return _lname; }
        }
        public string getcity
        {
            get { return _city; }
        }

        public string getstate
        {
            get { return _state; }
        }

        public string getpostal
        {
            get { return _postal; }
        }

        public string getbalance
        {
            get { return _balance; }
        }

    }
}

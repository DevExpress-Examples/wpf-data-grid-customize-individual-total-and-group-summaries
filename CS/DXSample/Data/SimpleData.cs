using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace DXSample {
    public class SimpleData : INotifyPropertyChanged   {

        private int _Count;
        private double _Price;
        private string _Description;
        private string _Name;
        private int _ID;

        
        public int ID {
            get { return _ID; }
            set {
                if (_ID == value)
                    return;
                _ID = value;
                OnPropertyChanged("ID");
            }
        }

        public string Name {
            get { return _Name; }
            set {
                if (_Name == value)
                    return;
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Description
        {
            get { return _Description; }
            set
            {
                if (_Description == value)
                    return;
                _Description = value;
                OnPropertyChanged("Description");
            }
        }

        public double Price
        {
            get { return _Price; }
            set
            {
                if (_Price == value)
                    return;
                _Price = value;
                OnPropertyChanged("Price");
            }
        }


        public int Count
        {
            get { return _Count; }
            set
            {
                if (_Count == value)
                    return;
                _Count = value;
                OnPropertyChanged("Count");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}

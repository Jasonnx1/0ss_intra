using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace intra_model
{
    public class Customer : INotifyPropertyChanged
    {


        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string ContactInfo { get; set; }
        public string PicturePath { get; set; }


        private string name;
        public string Name
        {
            get => Name;
            set
            {
                name = value;
                OnPropertyChanged();
                OnPropertyChanged("Info");
            }
        }

        public string Info => $"{Name}";




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

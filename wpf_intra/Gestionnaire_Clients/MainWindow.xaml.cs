using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using intra_model;

namespace Gestionnaire_Clients
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public ObservableCollection<Customer> customers { get; set; } = new ObservableCollection<Customer>();

        Customer current_customer;

        public event PropertyChangedEventHandler PropertyChanged;

        public Customer Current_customer {
            get => current_customer;
            set
            {
                current_customer = value;
                OnPropertyChanged();

            }
        }

        
       

        public MainWindow()
        {
            InitializeComponent();



            customers.Add(new Customer() { Name = "Ayanna", LastName = "Vargas", Address = "401-3122 Nullam Ave", City = "Pickering", Province = "ON", PostalCode = "N6C 7M5", PicturePath = "images/user.png", ContactInfo = "Work : 624-767-4994" });
            customers.Add(new Customer() { Name = "Whitney", LastName = "Parks", Address = "563-3207 Mi Rd.", City = "Greater Sudbury", Province = "ON", PostalCode = "N9G 5V1", PicturePath = "images/user.png", ContactInfo = "Cell : 175-370-4839" });
            customers.Add(new Customer() { Name = "Louis", LastName = "Watts", Address = "P.O. Box 529, 6291 Aliquam Road", City = "Fredericton", Province = "NB", PostalCode = "E2T 4M4", PicturePath = "images/user.png", ContactInfo = "Cell : 734-499-0531" });
            customers.Add(new Customer() { Name = "Pamela", LastName = "Knapp", Address = "2425 Urna Road", City = "Mission", Province = "BC", PostalCode = "V6W 1J0", PicturePath = "images/user.png", ContactInfo = "Home : 510-433-5623" });
            customers.Add(new Customer() { Name = "Clinton", LastName = "Gallagher", Address = "Ap #150-7450 Sapien Rd.", City = "Scarborough", Province = "ON", PostalCode = "M5V 7N1", PicturePath = "images/user.png", ContactInfo = "Home : 328-524-0475" });
            customers.Add(new Customer() { Name = "Amal", LastName = "Cross", Address = "P.O. Box 738, 9025 Sed Street", City = "Parkland County", Province = "AB", PostalCode = "T6S 6A4", PicturePath = "images/user.png", ContactInfo = "Cell : 250-555-4617" });
            customers.Add(new Customer() { Name = "Vanna", LastName = "Hyde", Address = "5671 Eros Rd.", City = "Daly", Province = "MB", PostalCode = "R0E 5T0", PicturePath = "images/user.png", ContactInfo = "Email : Quisque@neque.net" });
            Current_customer = customers[0];



        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

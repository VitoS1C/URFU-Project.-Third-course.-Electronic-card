using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using URFU_Project._Third_course.Models;


namespace URFU_Project._Third_course
{
    /// <summary>
    /// Логика взаимодействия для DoctorWindow.xaml
    /// </summary>
    public partial class SearcWindow : Window
    {
        AddUserWindow? addUserWindow;

        public BindingList<Patient>? patients;

        public SearcWindow()
        {
            InitializeComponent();
        }

        private void AddUserButton_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            addUserWindow = new AddUserWindow(this);
            addUserWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (HospitalContext context = new())
            {
                patients = new BindingList<Patient>(context.Patients.ToList());
                patientsDG.ItemsSource = patients;
            }
        }

        private void PatientListChancged(object sender, ListChangedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
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
using System.ComponentModel;

namespace URFU_Project._Third_course
{
    /// <summary>
    /// Логика взаимодействия для AdminAutorize.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        SearcWindow searcWindow;

        public AddUserWindow(SearcWindow searcWindow)
        {
            InitializeComponent();
            this.searcWindow = searcWindow;
        }

        private void DoctorRB_Checked(object sender, RoutedEventArgs e)
        {
            birthDayDP.IsEnabled = false;
            policyTB.IsEnabled = false;
            genderCB.IsEnabled = false;
            address.IsEnabled = false;
        }

        private void PatientRB_Checked(object sender, RoutedEventArgs e)
        {

            birthDayDP.IsEnabled = true;
            policyTB.IsEnabled = true;
            genderCB.IsEnabled = true;
            address.IsEnabled = true;
        }

        private void PolicyTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void BirthDayDP_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsLetter(e.Text, 0)) e.Handled = true;
        }

        private void AddButton_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (patientRB.IsChecked == true)
            {
                using (HospitalContext context = new HospitalContext())
                {
                    context.AddAsync(new Patient
                    {
                        Name = nameTB.Text,
                        Surname = surnameTB.Text,
                        MiddleName = middlenameTB.Text,
                        BirthDate =birthDayDP.DisplayDate.ToShortDateString(),
                        MedicalPolicy = long.Parse(policyTB.Text),
                        Sex = (Gender)Enum.Parse(typeof(Gender), genderCB.Text),
                        Address = address.Text,
                    });

                    context.SaveChangesAsync();
                }

                MessageBox.Show("Пользователь добавлен!");

                using (HospitalContext context = new HospitalContext())
                {
                    searcWindow.patients.Add(context.Patients.ToArray()[^1]);
                }

                Close();

                

            }

            
            
        }

    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
using System.Data;
using System.Drawing;
using URFU_Project._Third_course.Models;

namespace URFU_Project._Third_course
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HospitalContext dataBase = new HospitalContext();

        public MainWindow() => InitializeComponent();

        private void BAutorize_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            
        }

    }
}

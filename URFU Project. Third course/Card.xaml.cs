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

namespace URFU_Project._Third_course
{
    /// <summary>
    /// Логика взаимодействия для Card.xaml
    /// </summary>
    public partial class Card : Window
    {
        public Card()
        {
            InitializeComponent();
            complaintsTBl.Text = new string('?', 300);
            anamnesisTBl.Text = new string('?', 300);
            objectiveDataTBl.Text = new string('?', 300);
            therapyTBl.Text = new string('?', 300);
        }
    }
}

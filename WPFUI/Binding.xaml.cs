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

namespace WPFUI
{
    /// <summary>
    /// Interakční logika pro Binding.xaml
    /// </summary>
    public partial class Binding : Window
    {
        List<Person> p = new List<Person>();
        public Binding()
        {
            InitializeComponent();

          UpdateBind();

        }

        private void UpdateBind()
        {
            this.DataContext = p;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var person = new Person();
            DataAccess data = new DataAccess(FirstNameText.Text,LastNameText.Text);
             data.AddPerson(person);
            UpdateBind();
        }
    }
}

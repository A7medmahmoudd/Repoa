using Admin1;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace Adminn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       EmploysEntities db=new EmploysEntities();
        public MainWindow()
        {
            InitializeComponent();
           datag.ItemsSource=db.Admins.ToList();

        }

        private void inert_Click(object sender, RoutedEventArgs e)
        {
      Admin admin = new Admin();

            admin.id=int.Parse(id.Text);
            admin.name=name.Text;
           admin.Position=stutus.Text;

           db.Admins.Add(admin);
            MessageBox.Show("TRaa Donee");
            db.SaveChanges();
       

            datag.ItemsSource = db.Admins.ToList();
        }

        private void ubdet_Click(object sender, RoutedEventArgs e)
        {
           
           
        }
    }
}

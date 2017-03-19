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

namespace KDZVershinin3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Game> _games = new List<Game>();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int age;
            if (int.TryParse(textBox1.Text, out age))
            {

                var game = new Game(textBox.Text,
                    age);

                _games.Add(game);
                textBox.Text = "";
                textBox1.Text = "";

            }
            else
                MessageBox.Show("Неверно введены данные");
        }
    }
}

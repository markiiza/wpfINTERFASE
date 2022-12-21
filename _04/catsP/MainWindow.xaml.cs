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

namespace zadanoeone
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
        private void red(object sender, RoutedEventArgs e)
        {
            gridiiii.Background = new SolidColorBrush(Colors.Red);
        }
        private void yellow(object sender, RoutedEventArgs e)
        {
            gridiiii.Background = new SolidColorBrush(Colors.Yellow);
        }
        private void green(object sender, RoutedEventArgs e)
        {
            gridiiii.Background = new SolidColorBrush(Colors.Green);
        }
        private void lightblue(object sender, RoutedEventArgs e)
        {
            gridiiii.Background = new SolidColorBrush(Colors.DeepSkyBlue);
        }
        private void blue(object sender, RoutedEventArgs e)
        {
            gridiiii.Background = new SolidColorBrush(Colors.Blue);
        }
        private void fiolet(object sender, RoutedEventArgs e)
        {
            gridiiii.Background = new SolidColorBrush(Colors.Violet);
        }

        private void rose(object sender, RoutedEventArgs e)
        {
            gridiiii.Background = new SolidColorBrush(Colors.LightPink);
        }

        private void orange(object sender, RoutedEventArgs e)
        {
            gridiiii.Background = new SolidColorBrush(Colors.Orange);
        }
        private void mess(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: ученица группы ПР-31 Седунова Елизавета");
        }
        private void clo(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mousemove(object sender, MouseEventArgs e)
        {
            one.Text = " ";
            two.Text = "Информация о разработчике";
           
        }

        private void MouseEnter(object sender, MouseEventArgs e)
        {
            one.Text = " ";
            two.Text = "Выход";
        }

        private void Image1_MouseEnter(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить фон на: ";
            two.Text = "Красный";
        }
        private void Image2_MouseEnter(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить фон на: ";
            two.Text = "Оранжевый";
        }
        private void Image3_MouseEnter(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить фон на: ";
            two.Text = "Жёлтый";
        }
        private void Image4_MouseEnter(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить фон на: ";
            two.Text = "Голубой";
        }
        private void Image5_MouseEnter(object sender, MouseEventArgs e)
        {
            one.Text = "Изменить фон на: ";
            two.Text = "Розовый";
        }
    }
}

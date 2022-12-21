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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace paint
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

        private void valuechanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (null != slid && Pen != null)
            {
                Pen.Width = slid.Value;
                Pen.Height = slid.Value;
            }             
        }

        private void select(object sender, SelectionChangedEventArgs e)
        {
            if (null != slid && Pen != null)
            {
                if (selectBox.SelectedIndex == 0)
                {
                    Pen.Color = Colors.Red;
                }
                if (selectBox.SelectedIndex == 1)
                {
                    Pen.Color = Colors.Orange;
                }
                if (selectBox.SelectedIndex == 2)
                {
                    Pen.Color = Colors.Yellow;
                }
                if (selectBox.SelectedIndex == 3)
                {
                    Pen.Color = Colors.Green;
                }
                if (selectBox.SelectedIndex == 4)
                {
                    Pen.Color = Colors.Aqua;
                }
                if (selectBox.SelectedIndex == 5)
                {
                    Pen.Color = Colors.Blue;
                }
                if (selectBox.SelectedIndex == 6)
                {
                    Pen.Color = Colors.BlueViolet;
                }
            }
        }

        private void Changed(object sender, RoutedEventArgs e)
        {
            if (RadioButton_Boot1.IsChecked == true)
                holst.EditingMode = InkCanvasEditingMode.Ink;
            else
            if (RadioButton_Boot2.IsChecked == true)
                holst.EditingMode = InkCanvasEditingMode.Select;
            else
            if (RadioButton_Boot3.IsChecked == true)
                holst.EditingMode = InkCanvasEditingMode.EraseByStroke;

        }
    }
}

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

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation da = new DoubleAnimation(0, 360, new Duration(TimeSpan.FromSeconds(9)));
            RotateTransform rt = new RotateTransform();
            Image.RenderTransform = rt;
            Image.RenderTransformOrigin = new Point(0.5,0.5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }

        //private void zero_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "0";

        //}

        //private void point_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += ".";
        //}

        //private void one_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "1";
        //}

        //private void two_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "2";
        //}

        //private void three_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "3";
        //}

        //private void four_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "4";
        //}

        //private void five_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "5";
        //}

        //private void six_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "6";
        //}

        //private void seven_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "7";
        //}

        //private void eight_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "8";
        //}

        //private void nine_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "9";
        //}

        //private void par1_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "(";
        //}

        //private void par2_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += ")";
        //}

        //private void plus_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "+";
        //}

        //private void minus_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "-";
        //}

        //private void mul_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "*";
        //}

        //private void div_Click(object sender, RoutedEventArgs e)
        //{
        //    Screen.Text += "/";
        //}

            //Instaed using top lumsum code, changing all the "Click" to "Button_Click"
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Screen.Text += btn.Content.ToString();

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = "";
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text.Length != 0)
            {
                Screen.Text =Screen.Text.Remove (Screen.Text.Length - 1);
            }
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
            //calling javascript inside C# ID: 0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC
            dynamic obj = Activator.CreateInstance(scriptType, false);
            obj.Language = "javascript";
            string str = null;
            try
            {
                var res = obj.Eval(Screen.Text);
                str = Convert.ToString(res);
                Screen.Text = Screen.Text + " = " + str;
            }
            catch (SystemException)
            {
                Screen.Text = "Syntex Error";
               
            }
          
        }

    }
}

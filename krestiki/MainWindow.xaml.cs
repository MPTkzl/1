using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace krestiki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int turn;
        int i, j;

        public MainWindow()
: base()
        {
            this.InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            turn = 1;
        }

        private void win(string btnContent)
        {
            if ((Button1.Content == btnContent & Button2.Content == btnContent &
Button3.Content == btnContent)
| (Button1.Content == btnContent & Button4.Content == btnContent &
Button7.Content == btnContent)
| (Button1.Content == btnContent & Button5.Content == btnContent &
Button9.Content == btnContent)
| (Button2.Content == btnContent & Button5.Content == btnContent &
Button8.Content == btnContent)
| (Button3.Content == btnContent & Button6.Content == btnContent &
Button9.Content == btnContent)
| (Button4.Content == btnContent & Button5.Content == btnContent &
Button6.Content == btnContent)
| (Button7.Content == btnContent & Button8.Content == btnContent &
Button9.Content == btnContent)
| (Button3.Content == btnContent & Button5.Content == btnContent &
Button7.Content == btnContent))
            {
                if (btnContent == "O")
                {

                    MessageBox.Show("Нолики выиграли");
                    Label1.Content = ++i;
                }
                else if (btnContent == "X")
                {
                    MessageBox.Show("Крестики выиграли");
                    Label2.Content = ++j;
                }
                disablebuttons();
            }

            else
            {
                foreach (Button btn in wrapPanel1.Children)
                {
                    if (btn.IsEnabled == true)
                        return;
                }
                MessageBox.Show("НИЧЬЯ");
            }
        }
        private void disablebuttons()
        {
            foreach (Button btn in wrapPanel1.Children)
            {
                btn.IsEnabled = false;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (turn == 1)
            {
                btn.Content = "O";
               
            }
            else
            {
                btn.Content = "X";
                
            }
            btn.IsEnabled = false;
            win(btn.Content.ToString());
            turn += 1;
            if (turn > 2)
                turn = 1;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button btn in wrapPanel1.Children)
            {
                btn.Content = "";
                btn.IsEnabled = true;

            }

        }

    }
}

    

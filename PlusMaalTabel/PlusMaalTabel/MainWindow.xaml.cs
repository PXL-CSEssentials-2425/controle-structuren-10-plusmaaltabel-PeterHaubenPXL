using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlusMaalTabel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            bool isNumber = int.TryParse(maximumValueTextBox.Text, out int number);
            string result = "";

            if (isNumber)
            {
                if (number <= 20 && number >= 1)
                {
                    for (int i = 0; i <= number; i++)
                    {
                        if (i == 0)
                        {
                            result += "\t";
                        }

                        for (int j = 0; j <= number; j++)
                        {
                            if (i == 0)
                            {
                                if (j > 0)
                                {
                                    result += $"{j}\t";
                                }
                            }
                            else
                            {
                                result += (j + i).ToString() + "\t";
                            }
                        }

                        result += "\n\n";
                    }
                    resultTextBox.Text = result;
                }
                else
                {
                    MessageBox.Show("Geef getal van 1 tot en met 20 in", "foutieve ingave");
                    maximumValueTextBox.Text = "";
                    maximumValueTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Geef getal van 1 tot en met 20 in", "foutieve ingave");
                maximumValueTextBox.Text = "";
                maximumValueTextBox.Focus();
            }
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            bool isNumber = int.TryParse(maximumValueTextBox.Text, out int number);
            string result = "";

            if (isNumber)
            {
                if (number <= 20 && number >= 1)
                {
                    for (int i = 0; i <= number; i++)
                    {
                        if (i == 0)
                        {
                            result += "\t";
                        }

                        for (int j = 0; j <= number; j++)
                        {
                            if (i == 0)
                            {
                                if (j > 0)
                                {
                                    result += $"{j}\t";
                                }
                            }
                            else if (j == 0)
                            {
                                result += i.ToString() + "\t";
                            }
                            else if (j > 0)
                            {
                                result += (j * i).ToString() + "\t";
                            }
                            
                        }

                        result += "\n\n";
                    }
                    resultTextBox.Text = result;
                }
                else
                {
                    MessageBox.Show("Geef getal van 1 tot en met 20 in", "foutieve ingave");
                    maximumValueTextBox.Text = "";
                    maximumValueTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Geef getal van 1 tot en met 20 in", "foutieve ingave");
                maximumValueTextBox.Text = "";
                maximumValueTextBox.Focus();
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = "";
            maximumValueTextBox.Text = "10";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
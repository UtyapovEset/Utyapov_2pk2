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

namespace Шифровальщик
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Schifr(object sender, RoutedEventArgs e)
        {
            string text_start = start.Text; // записываем введенную  пользователем информация
            char[] buffer = text_start.ToCharArray();
            int encryptedCount = 0; // счетчик зашифрованных символов
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                
                if (char.IsLetter(letter))  //шифруем информацию
                {
                    if (letter >= 'A' && letter <= 'Z') //для заглавных латинских букв
                    {
                        buffer[i] = (char)('Z' - (letter - 'A'));
                        encryptedCount++;
                    }
                    else if (letter >= 'a' && letter <= 'z') //для строчных латинских букв
                    {
                        buffer[i] = (char)('z' - (letter - 'a'));
                        encryptedCount++;
                    }
                    else if (letter >= 'А' && letter <= 'Я') //для заглавных букв кириллица
                    {
                        buffer[i] = (char)('Я' - (letter - 'А'));
                        encryptedCount++;
                    }
                    else if (letter >= 'а' && letter <= 'я') //для строчных букв кириллица
                    {
                        buffer[i] = (char)('я' - (letter - 'а'));
                        encryptedCount++;
                    }

                }
            }

            end.Text = new string(buffer); //выводим зашифрованную информацию 
            MessageBox.Show($"Зашифровано символов: {encryptedCount}"); // выводим количество зашифрованных символов
        }          
        
    }
}
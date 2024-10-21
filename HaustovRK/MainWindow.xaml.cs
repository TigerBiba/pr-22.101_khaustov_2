using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.DesignerServices;
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

namespace HaustovRK
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

        private void btnOtvet_Click(object sender, RoutedEventArgs e)
        {
            string text = tbText.Text;

            if (text == null) 
            {
                MessageBox.Show("Введите текст");
                return;
            }
            try
            {
                char[] letter = { 'a', 'e', 'i', 'o','y', 'u' };
                int letterCount = 0;
                foreach (char c in text)
                {
                    char lowerC = char.ToLower(c);
                    bool isLetter = false;
                    for (int i = 0; i < letter.Length; i++)
                    {
                        if (letter[i] == lowerC)
                        {
                            isLetter = true;
                            break;
                        }
                    }
                    if (isLetter)
                    {
                        letterCount++;
                    }
                }
                tbOtvetCount.Text = letterCount.ToString();

                string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string longestWord = "";
                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
                tbOtvetWord.Text = longestWord.ToString();
            }
            catch(ArgumentException)
            {
                MessageBox.Show($"Ошибка");
            }
        }

    }
    }


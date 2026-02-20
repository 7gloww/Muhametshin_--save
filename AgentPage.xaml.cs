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

namespace Muhametshin_Глазки_save
{
    /// <summary>
    /// Логика взаимодействия для AgentPage.xaml
    /// </summary>
    public partial class AgentPage : Page
    {
        public AgentPage()
        {
            InitializeComponent();
            var currentAgent = MuhametshinEyesEntities.GetContext().Agent.ToList();
            AgentListView.ItemsSource = currentAgent;
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TBoxSearch_GotFocus(object sender, RoutedEventArgs e)
        {

            if (TBoxSearch.Text == "Введите для поиска")
            {
                TBoxSearch.Text = "";
                TBoxSearch.Foreground = Brushes.Black;
            }
        }

        private void TBoxSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBoxSearch.Text))
            {
                TBoxSearch.Foreground = Brushes.Gray;
                TBoxSearch.Text = "Введите для поиска";
            }
        }
    }
}

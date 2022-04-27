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
using BLL;


namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TelegramManeger _telegramManager;
        private const string _token = "5361971025:AAFZPT93Oh3qrcnm0BlL4xPzkFbFquIoJ6Y";
        private List<string> _labels;

        public List<User> listOfUsers = UsersMock.GetUsersListMock();
        public List<Group> listOfGroups = new List<Group> {new Group("Other")};



        public void AddGroup(string groupsName)
        {
            listOfGroups.Add(new Group(groupsName));
        }

        public string GetGroupsInfo(List<Group> listOfGroups)
        {
            string info = "";

            foreach (Group crnt in listOfGroups)
            {
                info += crnt.Name;
                info += "\n";
            }

            return info;
        }

        public MainWindow()
        {
            InitializeComponent();
            ListBox_Groups.ItemsSource = listOfGroups;
        }

        private void ComboBoxQuestion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboBoxQuestion.SelectedIndex)
            {
                case 0:
                    StackPanelYesNo.Visibility = Visibility.Visible;
                    StackPanelWriteAQuestion.Visibility = Visibility.Hidden;
                    StackPanelChooseOneAnswerFromSeveral.Visibility = Visibility.Hidden;
                    StackPanelSelectMultipleAnswersFromMultiple.Visibility = Visibility.Hidden;
                    StackPanelSorting.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    StackPanelWriteAQuestion.Visibility = Visibility.Visible;
                    StackPanelYesNo.Visibility = Visibility.Hidden;
                    StackPanelChooseOneAnswerFromSeveral.Visibility = Visibility.Hidden;
                    StackPanelSelectMultipleAnswersFromMultiple.Visibility = Visibility.Hidden;
                    StackPanelSorting.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    StackPanelChooseOneAnswerFromSeveral.Visibility = Visibility.Visible;
                    StackPanelWriteAQuestion.Visibility = Visibility.Hidden;
                    StackPanelYesNo.Visibility = Visibility.Hidden;
                    StackPanelSelectMultipleAnswersFromMultiple.Visibility = Visibility.Hidden;
                    StackPanelSorting.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    StackPanelSelectMultipleAnswersFromMultiple.Visibility = Visibility.Visible;
                    StackPanelChooseOneAnswerFromSeveral.Visibility = Visibility.Hidden;
                    StackPanelWriteAQuestion.Visibility = Visibility.Hidden;
                    StackPanelYesNo.Visibility = Visibility.Hidden;
                    StackPanelSorting.Visibility = Visibility.Hidden;
                    break;

                case 4:
                    StackPanelSorting.Visibility = Visibility.Visible;
                    StackPanelSelectMultipleAnswersFromMultiple.Visibility = Visibility.Hidden;
                    StackPanelChooseOneAnswerFromSeveral.Visibility = Visibility.Hidden;
                    StackPanelWriteAQuestion.Visibility = Visibility.Hidden;
                    StackPanelYesNo.Visibility = Visibility.Hidden;
                    break;
            }
        }



        private void ButtonAddGroup_Click(object sender, RoutedEventArgs e)
        {
            string groupName = TextBoxAddGroup.Text;
            AddGroup(groupName);
            ListBox_Groups.Items.Refresh();
        }

        

        private void TextBoxAddGroup_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextBoxAddGroup.Text = "";
        }



        private void TextBoxAddGroup_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

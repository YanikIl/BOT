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
using System.Windows.Threading;
using BLL;


namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TelegramManager _telegramManager;
        private const string _token = "5361971025:AAFZPT93Oh3qrcnm0BlL4xPzkFbFquIoJ6Y";
        private List<string> _labels;
        private DispatcherTimer _timer;

        public List<Group> listOfGroups = new List<Group> { new Group("Other", UsersMock.GetUsersListMock()) };
        //public List<Group> listOfGroups = new List<Group> { new Group("Other", UsersMock.GetUsersListMock()) };

        public MainWindow()
        {
            InitializeComponent();
            ListBox_Groups.ItemsSource = listOfGroups;
            ComboBox_Groups.ItemsSource = listOfGroups;


            _telegramManager = new TelegramManager(_token, OnMessage);
            _labels = new List<string>();

            Chat.ItemsSource = _labels;
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += OnTick;
            _timer.Start();

        }

        public void OnMessage(string send)
        {
            _labels.Add(send);
        }
        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            _telegramManager.Start();
        }
        private void OnTick(object sender, EventArgs e)
        {
            Chat.Items.Refresh();
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
            listOfGroups.Add(new Group(groupName, new List<User>()));
            ListBox_Groups.Items.Refresh();
            ComboBox_Groups.Items.Refresh();
            TextBoxAddGroup.Text = "";

        }



        private void TextBoxAddGroup_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextBoxAddGroup.Text = "";
        }


        private void TextBoxAddGroup_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_Groups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox_UsersOfGroup.ItemsSource = listOfGroups[ListBox_Groups.SelectedIndex].Users;
            ListBox_UsersOfGroup.Items.Refresh();
        }

        

        private void ListBox_UsersOfGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox_Groups.IsEnabled = true;
            Button_ChangeGroup.IsEnabled = true;
        }


        private void Button_ChangeGroup_Click(object sender, RoutedEventArgs e)
        {
            listOfGroups[ComboBox_Groups.SelectedIndex].Users.Add((User)ListBox_UsersOfGroup.SelectedItem);
            listOfGroups[ListBox_Groups.SelectedIndex].Users.Remove((User)ListBox_UsersOfGroup.SelectedItem);
            ListBox_UsersOfGroup.Items.Refresh();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using BLL.Questions;


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

        private GroupsStorage listOfGroups = GroupsStorage.GetInstance();
        private TestsStorage listOfTests = TestsStorage.GetInstance();
        private GroupsController controller = new GroupsController();
        private TestsController testController = new TestsController();
        //public List<Group> listOfGroups = new List<Group> { new Group("Other", UsersMock.GetUsersListMock()) };
        //public List<Test> listOfTests = new List<Test> { };

        public MainWindow()
        {
            InitializeComponent();


            //listOfGroups.Groups.Add(new Group("Other", UsersMock.GetUsersListMock()));
            GroupsController controller = new GroupsController();
            //controller.Save(listOfGroups.Groups);
            listOfGroups.Groups = controller.Load();
            listOfTests.Tests = testController.Load();
            ListBox_Groups.ItemsSource = listOfGroups.Groups;
            ComboBox_Groups.ItemsSource = listOfGroups.Groups;
            ListBox_ListOfTest.ItemsSource = listOfTests.Tests;
            ListBox_Tests.ItemsSource = listOfTests.Tests;
            ListBox_Groups1.ItemsSource = listOfGroups.Groups;
            _telegramManager = new TelegramManager(_token, OnMessage, TestMock.GetTestMock());
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

        
        private void ButtonAddGroup_Click(object sender, RoutedEventArgs e)
        {
            string groupName = TextBoxAddGroup.Text;
            listOfGroups.Groups.Add(new Group(groupName, new List<User>()));
            ListBox_Groups.Items.Refresh();
            ComboBox_Groups.Items.Refresh();
            TextBoxAddGroup.Text = "";

        }

        private void buttonAddQuestion_Click(object sender, RoutedEventArgs e)
        {
            //listBoxTest.Items.Add(TextBoxQuestion.Text);
        }

        private void buttonEditQuestion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonDeleteQuestion_Click(object sender, RoutedEventArgs e)
        {
            //listBoxTest.Items.RemoveAt(1);
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
            ListBox_UsersOfGroup.ItemsSource = listOfGroups.Groups[ListBox_Groups.SelectedIndex].Users;
            ListBox_UsersOfGroup.Items.Refresh();
        }

        

        private void ListBox_UsersOfGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox_Groups.IsEnabled = true;
            Button_ChangeGroup.IsEnabled = true;
        }


        private void Button_ChangeGroup_Click(object sender, RoutedEventArgs e)
        {
            listOfGroups.Groups[ComboBox_Groups.SelectedIndex].Users.Add((User)ListBox_UsersOfGroup.SelectedItem);
            listOfGroups.Groups[ListBox_Groups.SelectedIndex].Users.Remove((User)ListBox_UsersOfGroup.SelectedItem);
            ListBox_UsersOfGroup.Items.Refresh();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TestName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Button_AddTestName.IsEnabled = true;
        }

        

        private void Button_AddTestName_Click(object sender, RoutedEventArgs e)
        {
            listOfTests.Tests.Add(new Test(TextBox_TestName.Text));
            TextBox_TestName.Text = "";
            ListBox_ListOfTest.Items.Refresh();
            

        }

        private void Button_AddNewQu_Click(object sender, RoutedEventArgs e)
        {
            Label_ChooseTypeOfQ.IsEnabled = true;
            ComboBox_ChooseQType.IsEnabled = true;
        }

        private void TextBox_QName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_ChooseQType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Label_WriteAQuestion.IsEnabled = true;
            TextBox_QName.IsEnabled = true;


            switch (ComboBox_ChooseQType.SelectedIndex)
            {
                case 0:
                    Button_SaveQ.IsEnabled = true;
                    //RadioButton_Yes.Visibility = Visibility.Hidden;
                    //RadioButton_No.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    Button_SaveQ.IsEnabled = true;
                    //RadioButton_Yes.Visibility = Visibility.Visible;
                    //RadioButton_No.Visibility = Visibility.Visible;
                    break;
                case 2:
                    StackPanel_AnswersOptions.Visibility = Visibility.Visible;
                    Button_SaveQ.IsEnabled = true;
                    
                    break;
                    //case 3:

                    //    break;
                    //case 4:

                    //    break;
            }
        }



        private void Button_SaveQ_Click(object sender, RoutedEventArgs e)
        {
            switch (ComboBox_ChooseQType.SelectedIndex)
            {
                case 0:
                    listOfTests.Tests[ListBox_ListOfTest.SelectedIndex].questions.Add(new OpenQuestion(TextBox_QName.Text));
                    ListBox_QuOfTest.Items.Refresh();
                    break;
                case 1:
                    listOfTests.Tests[ListBox_ListOfTest.SelectedIndex].questions.Add(new YesOrNot(TextBox_QName.Text));
                    ListBox_QuOfTest.Items.Refresh();
                    break;
                case 2:
                    listOfTests.Tests[ListBox_ListOfTest.SelectedIndex].questions.Add(new RadioButtonQuestion(TextBox_QName.Text, new List<string> { 
                        TextBox_Option1.Text, 
                        TextBox_Option2.Text,
                        TextBox_Option3.Text,
                        TextBox_Option4.Text
                    }));
                    ListBox_QuOfTest.Items.Refresh();
                    TextBox_Option1.Text = "";
                    TextBox_Option2.Text = "";
                    TextBox_Option3.Text = "";
                    TextBox_Option4.Text = "";
                    break;
                case 3:

                    break;
                case 4:

                    break;
            }
            ComboBox_ChooseQType.SelectedIndex = -1;
            ComboBox_ChooseQType.IsEnabled = false;

            Label_WriteAQuestion.IsEnabled = false;
            TextBox_QName.Text = "";
            TextBox_QName.IsEnabled = false;
            Button_SaveQ.IsEnabled = false;
            StackPanel_AnswersOptions.Visibility = Visibility.Hidden;



        }

        private void ListBox_ListOfTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox_QuOfTest.ItemsSource = ((Test)ListBox_ListOfTest.SelectedItem).questions;
            Button_AddNewQu.IsEnabled = true;
        }

        private void Button_SaveUsers_Groups_Click(object sender, RoutedEventArgs e)
        {
            //GroupsController controller = new GroupsController();

            controller.Save(listOfGroups.Groups);
        }
        private void Button_SaveTestChange_Click(object sender, RoutedEventArgs e)
        {
            //TestsController controller = new TestsController();
            testController.Save(listOfTests.Tests);
        }


        private void ListBox_QuOfTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Button_DeleteQuestion.IsEnabled = true;
        }

        private void Button_DeleteQuestion_Click(object sender, RoutedEventArgs e)
        {
            listOfTests.Tests[ListBox_ListOfTest.SelectedIndex].questions.Remove((AbstractQuestion)ListBox_QuOfTest.SelectedItem);
            ListBox_QuOfTest.Items.Refresh();
        }

        
    }
}

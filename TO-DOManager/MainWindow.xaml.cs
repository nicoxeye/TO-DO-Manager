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

namespace TO_DOManager
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
        private void add_Click(object sender, RoutedEventArgs e)
        {
            Border taskBorder = new Border
            {
                Background = Brushes.White,
                CornerRadius = new CornerRadius(5),
                Padding = new Thickness(10),
                Margin = new Thickness(5),
                BorderBrush = Brushes.Gray,
                BorderThickness = new Thickness(1)
            };

            Grid taskGrid = new Grid();
            taskGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) });
            taskGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            TextBox taskBox = new TextBox
            {
                Text = "New Task",
                TextWrapping = TextWrapping.Wrap,
                FontFamily = new FontFamily("Consolas"),
                FontSize = 20
            };

            Grid.SetColumn(taskBox, 0);

            DatePicker dueDatePicker = new DatePicker
            {
                SelectedDate = DateTime.Now.AddDays(1),
                DisplayDateStart = DateTime.Now,
                Margin = new Thickness(5, 0, 0, 0),
                FontSize = 20,
            };
            Grid.SetColumn(dueDatePicker, 1);

            taskGrid.Children.Add(taskBox);
            taskGrid.Children.Add(dueDatePicker);

            taskBorder.Child = taskGrid;
            TasksPanel.Children.Add(taskBorder);
        }
    }
}
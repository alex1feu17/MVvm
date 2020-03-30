using System.Windows;
using SchoolManagement.UI.ViewModel;


namespace SchoolManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(StudentsViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
 
       
    }
}

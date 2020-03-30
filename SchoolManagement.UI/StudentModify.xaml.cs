using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SchoolManagement.UI
{
    /// <summary>
    /// Logique d'interaction pour StudentModify.xaml
    /// </summary>
    public partial class StudentModify : Window, INotifyPropertyChanged
    {
        Student student;
        public StudentModify(Student _student)
        {
            InitializeComponent();
            Student = _student;
        }
        public Student Student { 
            get => Student;
            set { 
                student = value;
                OnPropertyChanged();
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Validate_Click(object sender, RoutedEventArgs e)
        {
            Student.FirstName = txtFirstName.Text;
            Student.LastName = txtLastName.Text;
            Student.RegistrationNumber = txtRegistrationNumber.Text;

           
            this.Close();
        }
    }
}

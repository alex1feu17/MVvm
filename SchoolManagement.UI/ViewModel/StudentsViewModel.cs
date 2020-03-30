﻿using SchoolManagement.Models;
using System.Collections.ObjectModel;

namespace SchoolManagement.UI.ViewModel
{
     public class StudentsViewModel:BaseViewModels
    {
        StudentDataService studentDAtaService;
        private ObservableCollection<Student> students;
        private Student selectedStudent;
        private StudentDataService studentDataService;

        public ObservableCollection<Student> Students
        {
            get => students;
            set
            {
                students = value;
                OnPropertyChanged();
            }
        }
        public Student SelectedStudent
        {
            get => selectedStudent;
            set
            {
                selectedStudent = value;
                OnPropertyChanged();
            }
        }
        public StudentsViewModel() 
        {
            initValues();
        }
        private void initValues()
        {
            studentDataService = new StudentDataService();
            Students = new ObservableCollection<Student>(studentDataService.GetAll());
        }

    }
}

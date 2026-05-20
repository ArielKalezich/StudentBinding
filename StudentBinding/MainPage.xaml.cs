using StudentBinding.Models;
using System.ComponentModel.Design.Serialization;

namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        private Student stu;
        private Student stu2;
        private Student CurrentStudent { get; set; }
        public MainPage()
        {
            InitializeComponent();
          stu = new Student
            {
                Name = "Daniel Cohen",
                Image = "daniel.png",
                BirthDate = new DateTime(2007, 1, 7),
                Email = "daniel123@gmail.com",
                PhoneNum = "050-0765283"
          };

            stu2 = new Student
            {
                Name = "Noa Perez",
                Image = "noa.png",
                BirthDate = new DateTime(2009, 5, 3),
                Email = "noa456@gmail.com",
                PhoneNum = "050-9286541"
            };
            CurrentStudent = stu;
            this.BindingContext = CurrentStudent;

        }
        private void StudentChangeOnClick(object sender, EventArgs e)
        {
            if (CurrentStudent == stu)
            {
                CurrentStudent = stu2;

            }
            else if (CurrentStudent == stu2)
            {
                CurrentStudent = stu;

            }
            this.BindingContext = CurrentStudent;
        }
        private void UpdateBirthDateOnClick(object sender, EventArgs e)
        {
            CurrentStudent.BirthDate = BirthDatePicker.Date;
        }
    }
}



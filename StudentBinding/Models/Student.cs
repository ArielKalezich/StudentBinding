using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBinding.Models
{
   public partial class Student : ObservableObject
    {
        private string? name;
        public string? Name
        {
            get { return name; }

            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        private string? image;
        public string? Image
        {
            get { return image; }
            set
            {
                if (image != value)
                {
                    image = value;
                    OnPropertyChanged("Image");

                }
            }
        }

        private DateTime? birthdate;
        public DateTime? BirthDate { get { return birthdate; } 
            set
            {
                if (birthdate != value)
                {
                    birthdate = value;
                    OnPropertyChanged("BirthDate");
                    OnPropertyChanged("Age");
                }
            }
}

      
        public DateTime CurrentDate
        {
            get { return DateTime.Now; }
          
        }

        public int Age
        {
            get
            {
                if(BirthDate!=null)
                    return (int)(CurrentDate -(DateTime) BirthDate).TotalDays/ 365;
                return 0;
            }

        }

        private string? email;
        public string? Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged();

                }
            }
        }
        private string? phonenum;
        public string? PhoneNum
        {
            get { return phonenum; }
            set
            {
                if (phonenum != value)
                {
                    phonenum = value;
                    OnPropertyChanged();

                }
            }
        }
        public Student()

        {

           
        }
    }
}

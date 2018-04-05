using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using System.Xml.Serialization;
using FinalCap.Annotations;
using Xamarin.Forms;

namespace FinalCap.ViewModel
{
    public class SchoolViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private StudentBody studentBody;

        public StudentBody StudentBody
        {
            get => studentBody;
            set
            {
                if (studentBody != value)
                {
                    studentBody = value;
                    OnPropertyChanged(nameof(StudentBody));
                }
            }
        }

        Random rand = new Random();

        public SchoolViewModel() :this(null)
        {
            
        }

        public SchoolViewModel(IDictionary<string, object> properties)
        {
            StudentBody = new StudentBody();
            StudentBody.Students.Add(new Student());
            string uri = "http://xamarin.github.io/xamarin-forms-book-samples" +
                         "/SchoolOfFineArt/students.xml";
            HttpWebRequest request = WebRequest.CreateHttp(uri);

            request.BeginGetResponse((arg) =>
            {
                //Deserialize XML File
                Stream stream = request.EndGetResponse(arg).GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                XmlSerializer xml = new XmlSerializer(typeof(StudentBody));
                StudentBody = xml.Deserialize(reader) as StudentBody;

                //Enumerate through all the students
                foreach (Student student in StudentBody.Students)
                {
                    //set StudentBody propert in each Student object
                    student.Stud = StudentBody;

                    if (properties != null && properties.ContainsKey(student.FullName))
                    {
                        student.Notes = (string) properties[student.FullName];
                    }
                }
            }, null);

            Device.StartTimer(TimeSpan.FromSeconds(0.1), () =>
            {
                if (studentBody != null)
                {
                    int index = rand.Next(studentBody.Students.Count);
                    Student student = studentBody.Students[index];
                    double factor = 1 + (rand.NextDouble() - 0.5) / 5;
                    student.GradePoint = Math.Round(Math.Max(0, Math.Min(5, factor * student.GradePoint)), 2);
                }

                return true;
            });
        }

        public void SaveNotes(IDictionary<string, object> properties)
        {
            foreach (Student student in StudentBody.Students)
            {
                properties[student.FullName] = student.Notes;
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    public class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string fullName, firstName, middleName;
        string lastName, sex, photoFilename;
        double gradePointAverage;
        string notes;

        public string FullName
        {
            get => fullName;
            set
            {
                if (fullName != null)
                {
                    fullName = value;
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }
        public string FirstName
        {
            get => firstName;
            set
            {
                if (firstName != null)
                {
                    firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName != null)
                {
                    lastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }

        public string MiddleName
        {
            get => middleName;
            set
            {
                if (middleName != null)
                {
                    middleName = value;
                    OnPropertyChanged(nameof(MiddleName));
                }
            }
        }

        public string Sex
        {
            get => sex;
            set
            {
                if (sex != null)
                {
                    sex = value;
                    OnPropertyChanged(nameof(Sex));
                }
            }
        }

        public string PhotoFile
        {
            get => photoFilename;
            set
            {
                if (photoFilename != null)
                {
                    fullName = value;
                    OnPropertyChanged(nameof(PhotoFile));
                }
            }
        }

        public double GradePoint
        {
            get => gradePointAverage;
            set
            {
                gradePointAverage = value;
                OnPropertyChanged(nameof(GradePoint));
            }
        }

        public string Notes
        {
            get => notes;
            set
            {
                if (notes != null)
                {
                    notes = value;
                    OnPropertyChanged(nameof(Notes));
                }
            }
        }
        public StudentBody Stud = new StudentBody();
        public Student()
        {
            ResetGpaCommand = new Command(() => GradePoint = 2.6d);
            MoveToTopCommand = new Command((() => Stud.MoveStudentToTop(this)));
            MoveToBottomCommand = new Command((() => Stud.MoveStudentToBottom(this)));
            RemoveCommand = new Command((() => Stud.RemoveStudent(this)));
        }

        [XmlIgnore]
        public ICommand ResetGpaCommand { get; set; }
        [XmlIgnore]
        public ICommand MoveToTopCommand { get; set; }
        [XmlIgnore]
        public ICommand MoveToBottomCommand { get; set; }
        [XmlIgnore]
        public ICommand RemoveCommand { get; set; }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class StudentBody :INotifyPropertyChanged
    {
        private string school;
        ObservableCollection<Student> students = new ObservableCollection<Student>();

        public string School
        {
            get => school;
            set
            {
                if (school != value)
                {
                    school = value;
                    OnPropertyChanged(nameof(School));
                }
            }
        }

        public ObservableCollection<Student> Students
        {
            get => students;
            set
            {
                if (students != value)
                {
                    students = value;
                    OnPropertyChanged(nameof(Students));
                }
            }
        }

        public void MoveStudentToTop(Student schoolViewModel)
        {
            Students.Move(Students.IndexOf(schoolViewModel), 0);
        }

        public void MoveStudentToBottom(Student schoolViewModel)
        {
            Students.Move(Students.IndexOf(schoolViewModel), Students.Count - 1);
        }

        public void RemoveStudent(Student schoolViewModel)
        {
            Students.Remove(schoolViewModel);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

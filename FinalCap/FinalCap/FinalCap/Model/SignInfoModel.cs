using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FinalCap.Annotations;

namespace FinalCap.Model
{
    public class SignInfoModel : INotifyPropertyChanged
    {
        private int _studentId;
        private string _password;
        private readonly string[] _department = {"CSC", "PSY", "PYCH", "ENGR", "MATH", "BUS"};
        private int _departmentIndex = -1;
        private bool _isValid;

        public int StudentId
        {
            get => _studentId; 
            set
            {
                // ReSharper disable once RedundantCheckBeforeAssignment
                if (_studentId != value)
                {
                    _studentId = value;
                    OnPropertyChanged(nameof(StudentId));
                    TestIfValid();
                }
                
            }
        }
        public IEnumerable<string> Departments
        {
            get => _department; 
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != null && _password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                    TestIfValid();
                }
            }
        }

        public string Department { get; set; }

        public int DepartmentIndex
        {
            /** This set accessor uses the value to set the Department property
             * from an array of strings in the Departments Collections
             */ 

            private set
            {
                if (_departmentIndex != value)
                {
                    _departmentIndex = value;
                    OnPropertyChanged(nameof(DepartmentIndex));

                    if (_departmentIndex >= 0 && _departmentIndex < _department.Length)
                    {
                        Department = _department[_departmentIndex];
                        OnPropertyChanged(nameof(DepartmentIndex));
                    }

                    TestIfValid();
                }
            }
            get => _departmentIndex;
        }

        public bool IsValid
        {
            private set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    OnPropertyChanged(nameof(IsValid));
                }
            }
            get => _isValid;
        }

        /** When the StudentID, Password and DepartmentIndex changes,
         * the TestIfValid method is called to set the IsValid property.
         * The property is bound to the isEnabled property of a button
         */ 
        private void TestIfValid()
        {
            IsValid = !string.IsNullOrWhiteSpace(Password) &&
                      !string.IsNullOrWhiteSpace(StudentId.ToString()) &&
                      !string.IsNullOrWhiteSpace(Department);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

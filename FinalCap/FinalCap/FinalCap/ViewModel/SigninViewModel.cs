
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using FinalCap.Annotations;
using FinalCap.Model;
using FinalCap.Services;
using Xamarin.Forms;

namespace FinalCap.ViewModel
{
    class SigninViewModel : BaseViewModel
    {
        private List<SignInfoModel> _studentList;

        public List<SignInfoModel> StudentList
        {
            get => _studentList;
            set => _studentList = value;

            
        }

        public SigninViewModel()
        {
            var studentList = new UserDataStore();
            
        }
        
    }
}

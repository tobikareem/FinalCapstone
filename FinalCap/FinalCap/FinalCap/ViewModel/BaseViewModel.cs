using System.ComponentModel;
using System.Runtime.CompilerServices;
using FinalCap.Annotations;
using FinalCap.Model;
using FinalCap.Services;
using Xamarin.Forms;

namespace FinalCap.ViewModel
{
    class BaseViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public IDataStore<CoursesModel> DataStore =>
            DependencyService.Get<IDataStore<CoursesModel>>() ?? new CourseDataStore();

        private bool _isBusy;
        private string _title = string.Empty;

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (_isBusy != value)
                {
                    _isBusy = value;
                    OnPropertyChanged(nameof(IsBusy));
                }
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}

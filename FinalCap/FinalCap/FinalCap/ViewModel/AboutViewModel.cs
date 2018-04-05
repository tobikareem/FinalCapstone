using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FinalCap.Annotations;
using Xamarin.Forms;

namespace FinalCap.ViewModel
{
    public class AboutViewModel : INotifyPropertyChanged
    {
        private string _title;

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

        public AboutViewModel()
        {
            Title = " About";
            OpenWebsiteCommand = new Command(
                () =>
                {
                    Device.OpenUri(new Uri("http://www.tobikareem.com"));
                });
        }

        public ICommand OpenWebsiteCommand { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

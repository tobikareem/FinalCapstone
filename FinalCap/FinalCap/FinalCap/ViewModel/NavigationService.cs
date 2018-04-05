
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalCap.ViewModel
{
    internal class NavigationService : INavigation
    {
        public INavigation Navi { get; internal set; }

        public Task<Page> PopAsync() => Navi.PopAsync();

        public Task PushAsync(Page page) => Navi.PushAsync(page);

        public IReadOnlyList<Page> ModalStack => throw new System.NotImplementedException();

        public IReadOnlyList<Page> NavigationStack => throw new System.NotImplementedException();

        public void InsertPageBefore(Page page, Page before)
        {
            throw new System.NotImplementedException();
        }
        
        public Task<Page> PopAsync(bool animated)
        {
            throw new System.NotImplementedException();
        }
        public Task<Page> PopModalAsync(bool animated)
        {
            throw new System.NotImplementedException();
        }

        public Task PopToRootAsync() => Navi.PopToRootAsync();

        public Task PopToRootAsync(bool animated)
        {
            throw new System.NotImplementedException();
        }

        

        public Task PushAsync(Page page, bool animated)
        {
            throw new System.NotImplementedException();
        }

        public Task<Page> PopModalAsync() => Navi.PopModalAsync();
        public Task PushModalAsync(Page page) => Navi.PushModalAsync(page);

        public Task PushModalAsync(Page page, bool animated)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePage(Page page)
        {
            throw new System.NotImplementedException();
        }

    }
}

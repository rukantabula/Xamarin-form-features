using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SearchBar
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            MainListView.ItemsSource = _names;
        }

        private readonly List<string> _names = new List<string>
            {
            "Mohamed", "mamu", "ali", "erasmus", "ellan", "ben","m0O", "Oli", "smus", "Qlla", "ZIn"
            };

         private void MainSearchBar_OnSearchButtonPressed(object sender, EventArgs e)
        {

            string keyword = MainSearchBar.Text;

            IEnumerable<string> searchResult = from name
                                               in _names
                                               where name.StartsWith(keyword)
                                               select name;

            //IEnumerable<string> searchResult = _names.Where(name => name.ToLower().StartsWith(keyword.ToLower()));

            MainListView.ItemsSource = searchResult; 
        }

        private void Add_OnClicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;

            if (menuItem != null)
            {

                var name = menuItem.BindingContext as string;

                DisplayAlert("Alert", "Do you want to Add " + name + "?", "OK", "Cancel");
            }
        }

        private void Edit_OnClicked(object sender, EventArgs e)
        {

            var menuItem = sender as MenuItem;

            if (menuItem != null)
            {

                var name = menuItem.BindingContext as string;

                DisplayAlert("Alert", "Do you want to Edit " + name + "?", "OK", "Cancel");
            }

        }

        private void Delete_OnClicked(object sender, EventArgs e)
        {

            var menuItem = sender as MenuItem;

            if (menuItem != null)
            {

                var name = menuItem.BindingContext as string;

                DisplayAlert("Alert", "Do you want to Delete " + name + "?", "OK", "Cancel");
            }

        }

    }
}

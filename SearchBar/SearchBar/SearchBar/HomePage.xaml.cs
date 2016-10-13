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

    }
}

using System.Diagnostics;
using System.Windows.Input;

namespace ScottsSortOfNewCars
{
    public partial class AppShell : Shell
    {

        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            var button = sender as Button; //reference to sender button
            string buttonText = string.Empty; //variable for sender button's text

            if (button != null)
            {
                buttonText = button.Text; //if not null capture sender button text
            }
            

            switch(buttonText) //switch on buttonText and route to associated page
            {
                case "MainPage":
                    await Shell.Current.GoToAsync($"//{buttonText}");
                break;

                case "Inventory":
                    await Shell.Current.GoToAsync($"//{buttonText}");
                break;

                case "Locations":
                    await Shell.Current.GoToAsync($"//{buttonText}");
                break;

                case "Contact":
                    await Shell.Current.GoToAsync($"//{buttonText}");
                break;

                default:
                    Debug.WriteLine("No ButtonText");
                break;

            }
        }

    }
}

using CommunityToolkit.Maui.Views;
using ScottsSortOfNewCars.ViewModels;
using ScottsSortOfNewCars.Models;

namespace ScottsSortOfNewCars;

public partial class DetailPopup : Popup
{
	public Car SelectedCar { get; set; }
	public DetailPopup(Car SelectedCar)
	{
		this.SelectedCar = SelectedCar;
		BindingContext = this.SelectedCar; //Set bindingContext to Car object passed in

		InitializeComponent();
	}


    private async void RequestInfo(object sender, EventArgs e) //button command to go to Contact page
    {
        Close(); //Close Popup
        await Shell.Current.GoToAsync($"//Contact");
    }
}
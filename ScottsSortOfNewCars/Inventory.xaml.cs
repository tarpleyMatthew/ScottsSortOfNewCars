using CommunityToolkit.Maui.Views;
using ScottsSortOfNewCars.Models;
using ScottsSortOfNewCars.ViewModels;

namespace ScottsSortOfNewCars;

public partial class Inventory : ContentPage
{
	public Inventory()
	{
		InitializeComponent();
		BindingContext = new InventoryViewModel();
	}

    public void DisplayCarDetail(object sender, EventArgs e) //DisplayPopup
    {
        var selectedCar = ((sender as VerticalStackLayout)?.BindingContext as Car); //Grab selected Car object 
        var popup = new DetailPopup(selectedCar); //Pass to popup page
        this.ShowPopup(popup);
    }
}
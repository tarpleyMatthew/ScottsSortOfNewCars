using ScottsSortOfNewCars.ViewModels;

namespace ScottsSortOfNewCars
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }

    }

}

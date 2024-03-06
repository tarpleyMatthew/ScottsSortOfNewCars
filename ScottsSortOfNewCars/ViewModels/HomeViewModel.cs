using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using ScottsSortOfNewCars.Models;

namespace ScottsSortOfNewCars.ViewModels
{
    public class HomeViewModel
    {
        public ObservableCollection<Car> Cars {  get; set; }
        public HomeViewModel() 
        {
            Cars = new ObservableCollection<Car>();
            Click = new Command(ButtonClicked);
            FetchData();
        }

        private async void FetchData()
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetFromJsonAsync<ObservableCollection<Car>>("http://localhost/Cars.json");

                if (response != null)
                {
                    foreach (var item in response)
                    {
                       Cars.Add(item);
                    }
                }
                else
                {
                    Debug.WriteLine("Failed to retrieve data.");
                }
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine($"HTTP request failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public ICommand Click {  get; private set; }
        private async void ButtonClicked()
        {
            await Shell.Current.GoToAsync($"//Inventory");
        }
    
    }
}

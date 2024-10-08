using EstonianAnimalsApp.Models;

namespace EstonianAnimalsApp.Views;

public partial class AnimalsDetailsPage : ContentPage
{
	public AnimalsDetailsPage(Animal animal)
	{
        InitializeComponent();

        this.BindingContext = animal;
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
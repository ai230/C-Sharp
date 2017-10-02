using Xamarin.Forms;

namespace ConformationBox
{
    public partial class ConformationBoxPage : ContentPage
    {
        public ConformationBoxPage()
        {
            InitializeComponent();
        }

		//we don't want to stop app while this method so --> asyc
		private async void Handle_Clicked(object sender, System.EventArgs e)
        {
			//return true or false
			var responce = await DisplayAlert("Warning", "Are you sure", "OK", "Cancel");
            if(responce)
            {
                await DisplayAlert("Done", "Yor responce is OK", "OK");
            }
            else
            {
                await DisplayAlert("Done", "Your responce is Cancel", "OK");
            }
        }
    }
}

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class HelloWorldPage : ContentPage
    {
        public HelloWorldPage()
        {
            InitializeComponent();
            slider1.Value = 0.5;
            if(Device.RuntimePlatform.Equals("iOS"))
            {
                Padding = new Thickness(0, 20, 0, 0);
            }
            else if(Device.RuntimePlatform.Equals("Android"))
            {
                Padding = new Thickness(20, 0, 0, 0);
            }
            else if(Device.RuntimePlatform.Equals("Windows"))
            {
                Padding = new Thickness(0, 0, 20, 0);
            }
        }
    }
}

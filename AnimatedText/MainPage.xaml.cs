using System;
using Xamarin.Forms;

namespace AnimatedText
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            AnimatedTextControl.IsRunning = !AnimatedTextControl.IsRunning;
            RunButton.Text = AnimatedTextControl.IsRunning ? "Run" : "Stop";
        }
    }
}
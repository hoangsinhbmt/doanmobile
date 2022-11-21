using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace doan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtUsername.Text == null)
            {
                DisplayAlert("Ops...", "Please enter your username", "OK");
            } else if(txtPassword.Text == null)
            {
                DisplayAlert("Ops...", "Please enter your password", "OK");
            }
            else if (txtPasswordconfirm.Text != txtPassword.Text)
            {
                DisplayAlert("Ops...", "Please enter your passwordconfirm again", "OK");
            }
            else {
            Navigation.PushAsync(new HomePage());
            }
        }
    }
}
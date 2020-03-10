using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Hi.Models;

namespace Hi
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           InitializeComponent();


            var users = new List<User>()
            {
                new User("Marco"),new User( "Cat"),new User( "Rob")
            };
            CarouselView.ItemsSource = users;
        }
    }
}

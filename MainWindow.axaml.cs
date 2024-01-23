using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Threading.Tasks;

namespace WebsiteTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        async public void SignUpButtonPressed (object sender, RoutedEventArgs args)
        {
            Welcome_page.Opacity = 0;
            await Task.Delay(1000);
            Login_page.IsVisible = false;
            Login_page.IsVisible = true;
            Login_page.Opacity= 1;
        }
        public void SignUp(object sender, RoutedEventArgs args)
        {
            if (!String.IsNullOrEmpty(LoginSignUp.Text) && !String.IsNullOrEmpty(PasswordSignUp.Text))
            {
                 
            }
        }
    }
}
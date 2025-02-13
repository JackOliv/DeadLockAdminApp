using Microsoft.Maui.Controls;

namespace DeadLockApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Shell.SetBackgroundColor(this, Color.FromArgb("#23221e")); 
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(BuildsPage), typeof(BuildsPage));
            Routing.RegisterRoute(nameof(ItemDetailsPage), typeof(ItemDetailsPage));
            Routing.RegisterRoute(nameof(BuildDetailsPage), typeof(BuildDetailsPage));
            Routing.RegisterRoute(nameof(BuildCreatePage), typeof(BuildCreatePage));
            Routing.RegisterRoute(nameof(ItemSelectionPage), typeof(ItemSelectionPage));
            Routing.RegisterRoute(nameof(BuildsPage), typeof(BuildsPage));
            Routing.RegisterRoute(nameof(CreateCharacterPage), typeof(CreateCharacterPage));
            Routing.RegisterRoute(nameof(CreateItemPage), typeof(CreateItemPage));
            Routing.RegisterRoute(nameof(EditCharacterPage), typeof(EditCharacterPage));
            Routing.RegisterRoute(nameof(Heroes), typeof(Heroes));
            Routing.RegisterRoute(nameof(Items), typeof(Items));
            Routing.RegisterRoute(nameof(UserPage), typeof(UserPage));
        }
    }
}

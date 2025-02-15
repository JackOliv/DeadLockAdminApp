using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using DeadLockApp.ViewModels;

namespace DeadLockApp
{
    [QueryProperty(nameof(BuildId), "buildId")]
    public partial class BuildEditPage : ContentPage
    {
        public int BuildId { get; set; }

        public BuildEditPage()
        {
            InitializeComponent();
        }
    }

}

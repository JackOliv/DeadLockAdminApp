using DeadLockApp.ViewModels;
using System.Diagnostics;

namespace DeadLockApp;

public partial class Items : ContentPage
{
    private readonly ItemsViewModel _viewModel;

    public Items()
    {
        InitializeComponent();
        _viewModel = new ItemsViewModel();
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        Debug.WriteLine("�������� Items ��������� � ��������� ������...");
        await _viewModel.LoadItemsAsync(); // ��������� �������� ��� ������ ��������� ��������
    }
    private async void OnCreateItemButtonClicked(object sender, EventArgs e)
    {
        // ������� �� �������� �������� ���������
        var token = await SecureStorage.GetAsync("auth_token");
        if (token != null)
        {
            await Shell.Current.GoToAsync("CreateItemPage");
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
        
    }
}

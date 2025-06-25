namespace chatntq.APP.UI.Setting;
#if WINDOWS
using Microsoft.UI.Xaml.Input;
using WinUI = Microsoft.UI.Xaml;
#endif
public partial class SettingPage : ContentPage
{
	public SettingPage()
	{
		InitializeComponent();
#if WINDOWS
        Button_Change_Image.HandlerChanged += (s, e) =>
        {
            var nativeButton = (WinUI.Controls.Button)Button_Change_Image.Handler!.PlatformView!;

            nativeButton.PointerEntered += (sender, args) =>
            {
                Button_Change_Image.BackgroundColor = Colors.Green;
                Button_Change_Image.Scale = 0.95;
            };

            nativeButton.PointerExited += (sender, args) =>
            {
                Button_Change_Image.BackgroundColor = Colors.AliceBlue;
                Button_Change_Image.Scale = 1.0;
            };
        };
        Button_Change_Password.HandlerChanged += (s, e) =>
        {
            var nativeButton = (WinUI.Controls.Button)Button_Change_Password.Handler!.PlatformView!;

            nativeButton.PointerEntered += (sender, args) =>
            {
                Button_Change_Password.BackgroundColor = Colors.Green;
                Button_Change_Password.Scale = 0.95;
            };

            nativeButton.PointerExited += (sender, args) =>
            {
                Button_Change_Password.BackgroundColor = Colors.Orange;
                Button_Change_Password.Scale = 1.0;
            };
        };
        Button_Delete_Account.HandlerChanged += (s, e) =>
        {
            var nativeButton = (WinUI.Controls.Button)Button_Delete_Account.Handler!.PlatformView!;

            nativeButton.PointerEntered += (sender, args) =>
            {
                Button_Delete_Account.BackgroundColor = Colors.Green;
                Button_Delete_Account.Scale = 0.95;
            };

            nativeButton.PointerExited += (sender, args) =>
            {
                Button_Delete_Account.BackgroundColor = Colors.Red;
                Button_Delete_Account.Scale = 1.0;
            };
        };
        Button_Logout.HandlerChanged += (s, e) =>
        {
            var nativeButton = (WinUI.Controls.Button)Button_Logout.Handler!.PlatformView!;

            nativeButton.PointerEntered += (sender, args) =>
            {
                Button_Logout.BackgroundColor = Colors.Green;
                Button_Logout.Scale = 0.95;
            };

            nativeButton.PointerExited += (sender, args) =>
            {
                Button_Logout.BackgroundColor = Colors.Purple;
                Button_Logout.Scale = 1.0;
            };
        };
#endif
    }
    private void Pressed_Change_Image(object sender, EventArgs e)
    {
        Button_Change_Image.BackgroundColor = Colors.Green;
        Button_Change_Image.Scale = 0.95;
    }

    private void Released_Change_Image(object sender, EventArgs e)
    {
        Button_Change_Image.BackgroundColor = Colors.AliceBlue;
        Button_Change_Image.Scale = 1.0;
    }
    private void Pressed_Change_Password(object sender, EventArgs e)
    {
        Button_Change_Password.BackgroundColor = Colors.Green;
        Button_Change_Password.Scale = 0.95;
    }

    private void Released_Change_Password(object sender, EventArgs e)
    {
        Button_Change_Password.BackgroundColor = Colors.Orange;
        Button_Change_Password.Scale = 1.0;
    }
    private void Pressed_Delete_Account(object sender, EventArgs e)
    {
        Button_Delete_Account.BackgroundColor = Colors.Green;
        Button_Delete_Account.Scale = 0.95;
    }

    private void Released_Delete_Account(object sender, EventArgs e)
    {
        Button_Delete_Account.BackgroundColor = Colors.Red;
        Button_Delete_Account.Scale = 1.0;
    }
    private void Pressed_Logout(object sender, EventArgs e)
    {
        Button_Logout.BackgroundColor = Colors.Green;
        Button_Logout.Scale = 0.95;
    }

    private void Released_Logout(object sender, EventArgs e)
    {
        Button_Logout.BackgroundColor = Colors.Purple;
        Button_Logout.Scale = 1.0;
    }
    private void Change_Image(object sender, EventArgs e)
    {
        //Hiển thị giao diện chọn ảnh trong máy local (giống gg drive)
    }
    private void Change_Password(object sender, EventArgs e)
    {
        Navigation.PushAsync(new UI.Change_Password.ChangePasswordPage());
    }
    private async void Delete_Account(object sender, EventArgs e)
    {
        //Thông báo xác nhận, ra trang đăng nhập và xóa tài khoản cùng các dữ liệu
        //liên quan
        bool result = await DisplayAlert("Xác nhận xóa", "Bạn có chắc chắn muốn xóa tài khoản",
                                   "Có", "Không");
        if (result)
        {
            await DisplayAlert("Thông báo", "Xóa thành công", "OK");
            if (Application.Current?.Windows.FirstOrDefault() != null)
                Application.Current.Windows[0].Page = new NavigationPage(new UI.Login.LoginPage());
        }
        //Xóa
    }
    private void Logout(object sender, EventArgs e)
    {
        if (Application.Current?.Windows.FirstOrDefault() != null)
            Application.Current.Windows[0].Page = new NavigationPage(new UI.Login.LoginPage());
    }
}
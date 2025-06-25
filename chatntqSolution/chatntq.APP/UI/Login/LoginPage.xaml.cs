using System.Xml.XPath;

namespace chatntq.APP.UI.Login;
#if WINDOWS
using Microsoft.UI.Xaml.Input;
using WinUI = Microsoft.UI.Xaml;
#endif
public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
        //Khởi tạo model + viewmodel cho tài khoản
		InitializeComponent();
#if WINDOWS
        Button_Login.HandlerChanged += (s, e) =>
        {
            var nativeButton = (WinUI.Controls.Button)Button_Login.Handler!.PlatformView!;

            nativeButton.PointerEntered += (sender, args) =>
            {
                Button_Login.BackgroundColor = Colors.Green;
                Button_Login.Scale = 0.95;
            };

            nativeButton.PointerExited += (sender, args) =>
            {
                Button_Login.BackgroundColor = Colors.AliceBlue;
                Button_Login.Scale = 1.0;
            };
        };
        Button_Register.HandlerChanged += (s, e) =>
        {
            var nativeButton = (WinUI.Controls.Button)Button_Register.Handler!.PlatformView!;

            nativeButton.PointerEntered += (sender, args) =>
            {
                Button_Register.BackgroundColor = Colors.Green;
                Button_Register.Scale = 0.95;
            };

            nativeButton.PointerExited += (sender, args) =>
            {
                Button_Register.BackgroundColor = Colors.Orange;
                Button_Register.Scale = 1.0;
            };
        };
        Button_Forget_Password.HandlerChanged += (s, e) =>
        {
            var nativeButton = (WinUI.Controls.Button)Button_Forget_Password.Handler!.PlatformView!;

            nativeButton.PointerEntered += (sender, args) =>
            {
                Button_Forget_Password.BackgroundColor = Colors.Green;
                Button_Forget_Password.Scale = 0.95;
            };

            nativeButton.PointerExited += (sender, args) =>
            {
                Button_Forget_Password.BackgroundColor = Colors.Purple;
                Button_Forget_Password.Scale = 1.0;
            };
        };
#endif
    }
    private void Focused_Account(object sender, FocusEventArgs e)
	{
		Border_Account.Stroke = Colors.AliceBlue;
	}
    private void Unfocused_Account(object sender, FocusEventArgs e)
    {
        Border_Account.Stroke = Colors.Black;
    }
    private void Handle_Account(object sender, EventArgs e)
	{
        if (string.IsNullOrWhiteSpace(Account.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung tên đăng nhập", "Bạn chưa nhập tên đăng nhập", "OK");
        }
        else if(Account.Text.Trim() != "a")
        {
            DisplayAlert("Xin vui lòng đổi tên đăng nhập", "Tên đăng nhập không tồn tại", "OK");
        }
        else
        {
            if (string.IsNullOrWhiteSpace(Password.Text.Trim()))
            {
                Password.Focus();
            }
            else
            {
                DisplayAlert("Thông báo", "Đăng nhập thành công", "OK");
                if (Application.Current?.Windows.FirstOrDefault() != null)
                    Application.Current.Windows[0].Page = new NavigationPage(new UI.Main.ChatPage());
            }
            
        }
	}
    private void Focused_Password(object sender, FocusEventArgs e)
    {
        Border_Password.Stroke = Colors.AliceBlue;
    }
    private void Unfocused_Password(object sender, FocusEventArgs e)
    {
        Border_Password.Stroke = Colors.Black;
    }
    private void Handle_Password(object sender, EventArgs e)
	{
        if (string.IsNullOrWhiteSpace(Password.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung mật khẩu ", "Bạn chưa nhập mật khẩu", "OK");
        }
        else
        {
            if (string.IsNullOrWhiteSpace(Account.Text.Trim()))
            {
                Account.Focus();
            }
            else if (Account.Text.Trim() != "a")
            {
                DisplayAlert("Xin vui lòng đổi tên đăng nhập", "Tên đăng nhập không tồn tại", "OK");
            }
            else
            {
                DisplayAlert("Thông báo", "Đăng nhập thành công", "OK");
                if (Application.Current?.Windows.FirstOrDefault() != null)
                    Application.Current.Windows[0].Page = new NavigationPage(new UI.Main.ChatPage());
            }
        }
	}
    private void Pressed_Login(object sender, EventArgs e)
    {
        Button_Login.BackgroundColor = Colors.Green;
        Button_Login.Scale = 0.95;
    }

    private void Released_Login(object sender, EventArgs e)
    {
        Button_Login.BackgroundColor = Colors.AliceBlue;
        Button_Login.Scale = 1.0;
    }
    private void Handle_Login(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Account.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung tên đăng nhập", "Bạn chưa nhập tên đăng nhập", "OK");
        }
        else if (Account.Text.Trim() != "a")
        {
            DisplayAlert("Xin vui lòng đổi tên đăng nhập", "Tên đăng nhập không tồn tại", "OK");
        }
        else if (string.IsNullOrWhiteSpace(Password.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung mật khẩu", "Bạn chưa nhập mật khẩu", "OK");
        }
        else
        {
            DisplayAlert("Thông báo", "Đăng nhập thành công", "OK");
            if (Application.Current?.Windows.FirstOrDefault() != null)
                Application.Current.Windows[0].Page = new NavigationPage(new UI.Main.ChatPage());
        }
    }
    //Ghi nhớ thông tin đăng nhập
    private void Handle_Check_Login_Remember(object sender, CheckedChangedEventArgs e)
    {
        if(Check_Login_Remember.IsChecked == true)
        {
            //
        }    
    }
    private void Pressed_Register(object sender, EventArgs e)
    {
        Button_Register.BackgroundColor = Colors.Green;
        Button_Register.Scale = 0.95;
    }

    private void Released_Register(object sender, EventArgs e)
    {
        Button_Register.BackgroundColor = Colors.Orange;
        Button_Register.Scale = 1.0;
    }
    private void Handle_Register(object sender, EventArgs e)
    {
        Navigation.PushAsync(new UI.Register.RegisterPage());
    }
    private void Pressed_Forget_Password(object sender, EventArgs e)
    {
        Button_Forget_Password.BackgroundColor = Colors.Green;
        Button_Forget_Password.Scale = 0.95;
    }

    private void Released_Forget_Password(object sender, EventArgs e)
    {
        Button_Forget_Password.BackgroundColor = Colors.Purple;
        Button_Forget_Password.Scale = 1.0;
    }
    private void Handle_Forget_Password(object sender, EventArgs e)
    {
        Navigation.PushAsync(new UI.Forget_Password.ForgetPasswordPage());
    }
}
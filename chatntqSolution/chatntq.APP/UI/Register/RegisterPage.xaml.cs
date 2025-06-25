namespace chatntq.APP.UI.Register;
#if WINDOWS
using Microsoft.UI.Xaml.Input;
using WinUI = Microsoft.UI.Xaml;
#endif
public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
#if WINDOWS
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
                Button_Register.BackgroundColor = Colors.AliceBlue;
                Button_Register.Scale = 1.0;
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
            DisplayAlert("Xin vui lòng bổ sung tên đăng ký", "Bạn chưa nhập tên đăng ký", "OK");
        }
        else if (Account.Text.Trim() == "a")
        {
            DisplayAlert("Xin vui lòng đổi tên đăng ký", "Tên đăng ký đã tồn tại", "OK");
        }
        else
        {
            if (string.IsNullOrWhiteSpace(Name.Text.Trim()))
            {
                Name.Focus();
            }
            else if(Name.Text.Trim() == "b")
            {
                DisplayAlert("Xin vui lòng đổi tên hiển thị", "Tên hiển thị đã tồn tại", "OK");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Password.Text.Trim()))
                {
                    Password.Focus();
                }
                else
                {
                    DisplayAlert("Thông báo", "Đăng ký thành công", "OK");
                    if (Application.Current?.Windows.FirstOrDefault() != null)
                        Application.Current.Windows[0].Page = new NavigationPage(new UI.Main.ChatPage());
                }
            }
        }
    }
    private void Focused_Name(object sender, FocusEventArgs e)
    {
        Border_Name.Stroke = Colors.AliceBlue;
    }
    private void Unfocused_Name(object sender, FocusEventArgs e)
    {
        Border_Name.Stroke = Colors.Black;
    }
    private void Handle_Name(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Name.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung tên hiển thị", "Bạn chưa nhập tên hiển thị", "OK");
        }
        else if (Name.Text.Trim() == "b")
        {
            DisplayAlert("Xin vui lòng đổi tên hiển thị", "Tên hiển thị đã tồn tại", "OK");
        }
        else
        {
            if (string.IsNullOrWhiteSpace(Account.Text.Trim()))
            {
                Account.Focus();
            }
            else if (Account.Text.Trim() == "a")
            {
                DisplayAlert("Xin vui lòng đổi tên đăng ký", "Tên đăng ký đã tồn tại", "OK");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Password.Text.Trim()))
                {
                    Password.Focus();
                }
                else
                {
                    DisplayAlert("Thông báo", "Đăng ký thành công", "OK");
                    if (Application.Current?.Windows.FirstOrDefault() != null)
                        Application.Current.Windows[0].Page = new NavigationPage(new UI.Main.ChatPage());
                }
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
            else if (Account.Text.Trim() == "a")
            {
                DisplayAlert("Xin vui lòng đổi tên đăng ký", "Tên đăng ký đã tồn tại", "OK");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Name.Text.Trim()))
                {
                    Name.Focus();
                }
                else if (Name.Text.Trim() == "b")
                {
                    DisplayAlert("Xin vui lòng đổi tên hiển thị", "Tên hiển thị đã tồn tại", "OK");
                }
                else
                {
                    DisplayAlert("Thông báo", "Đăng ký thành công", "OK");
                    if (Application.Current?.Windows.FirstOrDefault() != null)
                        Application.Current.Windows[0].Page = new NavigationPage(new UI.Main.ChatPage());
                }
            }
        }
    }
    private void Pressed_Register(object sender, EventArgs e)
    {
        Button_Register.BackgroundColor = Colors.Green;
        Button_Register.Scale = 0.95;
    }

    private void Released_Register(object sender, EventArgs e)
    {
        Button_Register.BackgroundColor = Colors.AliceBlue;
        Button_Register.Scale = 1.0;
    }
    private void Handle_Register(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Account.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung tên đăng ký", "Bạn chưa nhập tên đăng ký", "OK");
        }
        else if (Account.Text.Trim() == "a")
        {
            DisplayAlert("Xin vui lòng đổi tên đăng ký", "Tên đăng ký đã tồn tại", "OK");
        }
        if (string.IsNullOrWhiteSpace(Name.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung tên hiển thị", "Bạn chưa nhập tên hiển thị", "OK");
        }
        else if (Name.Text.Trim() == "b")
        {
            DisplayAlert("Xin vui lòng đổi tên hiển thị", "Tên hiển thị đã tồn tại", "OK");
        }
        else if (string.IsNullOrWhiteSpace(Password.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung mật khẩu", "Bạn chưa nhập mật khẩu", "OK");
        }
        else
        {
            DisplayAlert("Thông báo", "Đăng ký thành công", "OK");
            if (Application.Current?.Windows.FirstOrDefault() != null)
                Application.Current.Windows[0].Page = new NavigationPage(new UI.Main.ChatPage());
        }
    }
}
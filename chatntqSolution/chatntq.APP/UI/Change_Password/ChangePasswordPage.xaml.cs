namespace chatntq.APP.UI.Change_Password;
#if WINDOWS
using Microsoft.UI.Xaml.Input;
using WinUI = Microsoft.UI.Xaml;
#endif
public partial class ChangePasswordPage : ContentPage
{
	public ChangePasswordPage()
	{
		InitializeComponent();
#if WINDOWS
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
                Button_Change_Password.BackgroundColor = Colors.AliceBlue;
                Button_Change_Password.Scale = 1.0;
            };
        };
#endif
    }
    private void Focused_Old_Password(object sender, FocusEventArgs e)
    {
        Border_Old_Password.Stroke = Colors.AliceBlue;
    }
    private void Unfocused_Old_Password(object sender, FocusEventArgs e)
    {
        Border_Old_Password.Stroke = Colors.Black;
    }
    private void Handle_Old_Password(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Old_Password.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung mật khẩu cũ", "Bạn chưa nhập mật khẩu cũ", "OK");
        }
        else if (Old_Password.Text.Trim() != "c")
        {
            DisplayAlert("Xin vui lòng đổi mật khẩu cũ", "Mật khẩu cũ không trùng khớp", "OK");
        }
        else
        {
            if (string.IsNullOrWhiteSpace(New_Password.Text.Trim()))
            {
                New_Password.Focus();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Re_New_Password.Text.Trim()))
                {
                    Re_New_Password.Focus();
                }
                else if(New_Password.Text.Trim() != Re_New_Password.Text.Trim())
                {
                    DisplayAlert("Mật khẩu mới không khớp", "Mật khẩu mới không khớp với phần nhập lại mật khẩu mới", "OK");
                }    
                else
                {
                    DisplayAlert("Thông báo", "Đổi mật khẩu thành công", "OK");
                    if (Application.Current?.Windows.FirstOrDefault() != null)
                        Application.Current.Windows[0].Page = new NavigationPage(new UI.Setting.SettingPage());
                }
            }
        }
    }
    private void Focused_New_Password(object sender, FocusEventArgs e)
    {
        Border_New_Password.Stroke = Colors.AliceBlue;
    }
    private void Unfocused_New_Password(object sender, FocusEventArgs e)
    {
        Border_New_Password.Stroke = Colors.Black;
    }
    private void Handle_New_Password(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(New_Password.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung mật khẩu mới", "Bạn chưa nhập mật khẩu mới", "OK");
        }
        else
        {
            if (string.IsNullOrWhiteSpace(Old_Password.Text.Trim()))
            {
                Old_Password.Focus();
            }
            else if (Old_Password.Text.Trim() != "c")
            {
                DisplayAlert("Xin vui lòng đổi mật khẩu cũ", "Mật khẩu cũ không trùng khớp", "OK");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Re_New_Password.Text.Trim()))
                {
                    Re_New_Password.Focus();
                }
                else if (New_Password.Text.Trim() != Re_New_Password.Text.Trim())
                {
                    DisplayAlert("Mật khẩu mới không khớp", "Mật khẩu mới không khớp với phần nhập lại mật khẩu mới", "OK");
                }
                else
                {
                    DisplayAlert("Thông báo", "Đổi mật khẩu thành công", "OK");
                    if (Application.Current?.Windows.FirstOrDefault() != null)
                        Application.Current.Windows[0].Page = new NavigationPage(new UI.Setting.SettingPage());
                }
            }
        }
    }
    private void Focused_Re_New_Password(object sender, FocusEventArgs e)
    {
        Border_Re_New_Password.Stroke = Colors.AliceBlue;
    }
    private void Unfocused_Re_New_Password(object sender, FocusEventArgs e)
    {
        Border_Re_New_Password.Stroke = Colors.Black;
    }
    private void Handle_Re_New_Password(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Re_New_Password.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung nhập lại mật khẩu mới", "Bạn chưa nhập lại mật khẩu mới", "OK");
        }
        else
        {
            if (string.IsNullOrWhiteSpace(Old_Password.Text.Trim()))
            {
                Old_Password.Focus();
            }
            else if (Old_Password.Text.Trim() != "c")
            {
                DisplayAlert("Xin vui lòng đổi mật khẩu cũ", "Mật khẩu cũ không trùng khớp", "OK");
            }
            else
            {
                if (New_Password.Text.Trim() != Re_New_Password.Text.Trim())
                {
                    DisplayAlert("Mật khẩu mới không khớp", "Mật khẩu mới không khớp với phần nhập lại mật khẩu mới", "OK");
                }
                else
                {
                    DisplayAlert("Thông báo", "Đổi mật khẩu thành công", "OK");
                    if (Application.Current?.Windows.FirstOrDefault() != null)
                        Application.Current.Windows[0].Page = new NavigationPage(new UI.Setting.SettingPage());
                }
            }
        }
    }
    private void Pressed_Change_Password(object sender, EventArgs e)
    {
        Button_Change_Password.BackgroundColor = Colors.Green;
        Button_Change_Password.Scale = 0.95;
    }

    private void Released_Change_Password(object sender, EventArgs e)
    {
        Button_Change_Password.BackgroundColor = Colors.AliceBlue;
        Button_Change_Password.Scale = 1.0;
    }
    private void Handle_Change_Password(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Old_Password.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung mật khẩu cũ", "Bạn chưa nhập mật khẩu cũ", "OK");
        }
        else if (Old_Password.Text.Trim() != "c")
        {
            DisplayAlert("Xin vui lòng đổi mật khẩu cũ", "Mật khẩu cũ không trùng khớp", "OK");
        }
        else if (string.IsNullOrWhiteSpace(New_Password.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung mật khẩu mới", "Bạn chưa nhập mật khẩu mới", "OK");
        }
        else if (string.IsNullOrWhiteSpace(Re_New_Password.Text.Trim()))
        {
            DisplayAlert("Xin vui lòng bổ sung nhập lại mật khẩu mới", "Bạn chưa nhập lại mật khẩu mới", "OK");
        }
        else if (New_Password.Text.Trim() != Re_New_Password.Text.Trim())
        {
            DisplayAlert("Mật khẩu mới không khớp", "Mật khẩu mới không khớp với phần nhập lại mật khẩu mới", "OK");
        }
        else
        {
            DisplayAlert("Thông báo", "Đổi mật khẩu thành công", "OK");
            if (Application.Current?.Windows.FirstOrDefault() != null)
                Application.Current.Windows[0].Page = new NavigationPage(new UI.Setting.SettingPage());
        }
    }
}
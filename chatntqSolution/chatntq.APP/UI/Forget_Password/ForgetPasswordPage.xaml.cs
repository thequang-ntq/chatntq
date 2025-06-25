namespace chatntq.APP.UI.Forget_Password;
#if WINDOWS
using Microsoft.UI.Xaml.Input;
using WinUI = Microsoft.UI.Xaml;
#endif
public partial class ForgetPasswordPage : ContentPage
{
	public ForgetPasswordPage()
	{
		//Binding data của entry Account từ trang LoginPage
        //True/False cho thuộc tính IsVisible: check xem tài khoản với tên đăng nhập
        //có tồn tại trong CSDL / Gọi API
		InitializeComponent();
#if WINDOWS
        Button_Return.HandlerChanged += (s, e) =>
        {
            var nativeButton = (WinUI.Controls.Button)Button_Return.Handler!.PlatformView!;

            nativeButton.PointerEntered += (sender, args) =>
            {
                Button_Return.BackgroundColor = Colors.Green;
                Button_Return.Scale = 0.95;
            };

            nativeButton.PointerExited += (sender, args) =>
            {
                Button_Return.BackgroundColor = Colors.AliceBlue;
                Button_Return.Scale = 1.0;
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
        else if (Account.Text.Trim() != "a")
        {
            DisplayAlert("Không tồn tại tài khoản với tên đăng nhập được nhập", "Tên đăng nhập không tồn tại", "OK");
        }
        else
        {
            //Lấy thông tin password từ account trong CSDL
            //Binding cho text của Password
            Password.IsVisible = true;
            Button_Return.IsVisible = true;
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
    private void Pressed_Return(object sender, EventArgs e)
    {
        Button_Return.BackgroundColor = Colors.Green;
        Button_Return.Scale = 0.95;
    }

    private void Released_Return(object sender, EventArgs e)
    {
        Button_Return.BackgroundColor = Colors.AliceBlue;
        Button_Return.Scale = 1.0;    
    }
    private void Handle_Return(object sender, EventArgs e)
    {
        if (Application.Current?.Windows.FirstOrDefault() != null)
            Application.Current.Windows[0].Page = new NavigationPage(new UI.Login.LoginPage());
    }
}
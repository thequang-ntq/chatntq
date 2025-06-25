namespace chatntq.APP.UI.Main;

public partial class ChatPage : ContentPage
{
	public ChatPage()
	{
		InitializeComponent();
	}
	private void Handle_Search_Person(Object sender, EventArgs e)
	{

	}
    private void Focused_Reply_Message(object sender, FocusEventArgs e)
    {
        Border_Reply_Message.Stroke = Colors.AliceBlue;
    }
    private void Unfocused_Reply_Message(object sender, FocusEventArgs e)
    {
        Border_Reply_Message.Stroke = Colors.White;
    }
    private void Handle_Reply_Message(Object sender, EventArgs e)
    {

    }
    private void Handle_Search_Message(Object sender, EventArgs e)
    {

    }
    private void Setting(Object sender, EventArgs e)
    {
        Navigation.PushAsync(new UI.Setting.SettingPage();
    }
}
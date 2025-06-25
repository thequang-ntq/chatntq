using System.Windows.Input;

namespace chatntq.APP.Components.Button;

public partial class ButtonComp : ContentView
{
	public ButtonComp()
	{
		InitializeComponent();
	}
    // TEXT
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(
            nameof(Text), 
            typeof(string), 
            typeof(ButtonComp), 
            String.Empty,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (ButtonComp)bindable;
                control.ButtonComponent.Text = (string)newValue!;
            });
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    // BACKGROUND COLOR
    public new static readonly BindableProperty BackgroundColorProperty =
        BindableProperty.Create(
            nameof(BackgroundColor), 
            typeof(Color), 
            typeof(ButtonComp), 
            Colors.AliceBlue,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (ButtonComp)bindable;
                control.ButtonComponent.BackgroundColor = (Color)newValue!;
            });
    public new Color BackgroundColor
    {
        get => (Color)GetValue(BackgroundColorProperty);
        set => SetValue(BackgroundColorProperty, value);
    }

    // BORDER COLOR
    public static readonly BindableProperty BorderColorProperty =
        BindableProperty.Create(
            nameof(BorderColor), 
            typeof(Color), 
            typeof(ButtonComp), 
            Colors.AliceBlue,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (ButtonComp)bindable;
                control.ButtonComponent.BorderColor = (Color)newValue!;
            });
    public Color BorderColor
    {
        get => (Color)GetValue(BorderColorProperty);
        set => SetValue(BorderColorProperty, value);
    }

    // IsVisible
    public new static readonly BindableProperty IsVisibleProperty =
        BindableProperty.Create(
            nameof(IsVisible), 
            typeof(bool), 
            typeof(ButtonComp), 
            true,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (ButtonComp)bindable;
                control.ButtonComponent.IsVisible = (bool)newValue!;
            });
    public new bool IsVisible
    {
        get => (bool)GetValue(IsVisibleProperty);
        set => SetValue(IsVisibleProperty, value);
    }

    // HORIZONTAL OPTIONS
    public new static readonly BindableProperty HorizontalOptionsProperty =
        BindableProperty.Create(
            nameof(HorizontalOptions), 
            typeof(LayoutOptions), 
            typeof(ButtonComp), 
            LayoutOptions.Center,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (ButtonComp)bindable;
                control.ButtonComponent.HorizontalOptions = (LayoutOptions)newValue!;
            });
    public new LayoutOptions HorizontalOptions
    {
        get => (LayoutOptions)GetValue(HorizontalOptionsProperty);
        set => SetValue(HorizontalOptionsProperty, value);
    }

    // EVENT (Nullable)
    public event EventHandler? Clicked;
    public event EventHandler? Pressed;
    public event EventHandler? Released;
    private void ButtonComponent_Clicked(object sender, EventArgs e) => Clicked?.Invoke(this, e);
    private void ButtonComponent_Pressed(object sender, EventArgs e) => Pressed?.Invoke(this, e);
    private void ButtonComponent_Released(object sender, EventArgs e) => Released?.Invoke(this, e);

    // COMMAND
    public static readonly BindableProperty CommandProperty =
        BindableProperty.Create(
            nameof(Command), 
            typeof(ICommand), 
            typeof(ButtonComp),
            default(ICommand),
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (ButtonComp)bindable;
                control.ButtonComponent.Command = (ICommand?)newValue;
            });
    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    // COMMAND PARAMETER
    public static readonly BindableProperty CommandParameterProperty =
        BindableProperty.Create(
            nameof(CommandParameter), 
            typeof(object), 
            typeof(ButtonComp),
            default(object),
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (ButtonComp)bindable;
                control.ButtonComponent.CommandParameter = (object?)newValue;
            });
    public object CommandParameter
    {
        get => GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }
}
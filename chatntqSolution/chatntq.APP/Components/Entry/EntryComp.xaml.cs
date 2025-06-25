namespace chatntq.APP.Components.Entry;

public partial class EntryComp : ContentView
{
	public EntryComp()
	{
		InitializeComponent();
	}

    // TEXT
    public static readonly BindableProperty TextProperty =
    BindableProperty.Create(
        nameof(Text),
        typeof(string),
        typeof(EntryComp),
        default(string),
        BindingMode.TwoWay,
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (EntryComp)bindable;
            control.EntryComponent.Text = (string)newValue!;
        });
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    // IsPassword
    public static readonly BindableProperty IsPasswordProperty =
        BindableProperty.Create(
            nameof(IsPassword),
            typeof(bool),
            typeof(EntryComp),
            true,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (EntryComp)bindable;
                control.EntryComponent.IsPassword = (bool)newValue!;
            });
    public bool IsPassword
    {
        get => (bool)GetValue(IsPasswordProperty);
        set => SetValue(IsPasswordProperty, value);
    }

    // BACKGROUND COLOR
    public new static readonly BindableProperty BackgroundColorProperty =
        BindableProperty.Create(
            nameof(BackgroundColor),
            typeof(Color),
            typeof(EntryComp),
            Colors.AliceBlue,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (EntryComp)bindable;
                control.EntryComponent.BackgroundColor = (Color)newValue!;
            });
    public new Color BackgroundColor
    {
        get => (Color)GetValue(BackgroundColorProperty);
        set => SetValue(BackgroundColorProperty, value);
    }

    // Placeholder
    public static readonly BindableProperty PlaceholderProperty =
        BindableProperty.Create(
            nameof(Placeholder),
            typeof(string),
            typeof(EntryComp),
            String.Empty,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (EntryComp)bindable;
                control.EntryComponent.Placeholder = (string)newValue!;
            });
    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    // EVENT (Nullable)
    public new event EventHandler<FocusEventArgs>? Focused;
    public new event EventHandler<FocusEventArgs>? Unfocused;
    public event EventHandler? Completed;
    private void EntryComponent_Focused(object sender, FocusEventArgs e) => Focused?.Invoke(this, e);
    private void EntryComponent_Unfocused(object sender, FocusEventArgs e) => Unfocused?.Invoke(this, e);
    private void EntryComponent_Completed(object sender, EventArgs e) => Completed?.Invoke(this, e);

}
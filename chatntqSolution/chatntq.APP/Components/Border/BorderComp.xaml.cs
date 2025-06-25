namespace chatntq.APP.Components.Border;

public partial class BorderComp : ContentView
{
	public BorderComp()
	{
		InitializeComponent();
	}

    // Stroke
    public static readonly BindableProperty StrokeProperty =
        BindableProperty.Create(
            nameof(Stroke),
            typeof(Color),
            typeof(BorderComp),
            Colors.Black,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (BorderComp)bindable;
                control.BorderComponent.Stroke = (Color)newValue!;
            });
    public Color Stroke
    {
        get => (Color)GetValue(StrokeProperty);
        set => SetValue(StrokeProperty, value);
    }

    // BACKGROUND COLOR
    public new static readonly BindableProperty BackgroundColorProperty =
        BindableProperty.Create(
            nameof(BackgroundColor),
            typeof(Color),
            typeof(BorderComp),
            Colors.LightYellow,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (BorderComp)bindable;
                control.BorderComponent.BackgroundColor = (Color)newValue!;
            });
    public new Color BackgroundColor
    {
        get => (Color)GetValue(BackgroundColorProperty);
        set => SetValue(BackgroundColorProperty, value);
    }

    // Padding
    public new static readonly BindableProperty PaddingProperty =
        BindableProperty.Create(
            nameof(Padding),
            typeof(Thickness),
            typeof(BorderComp),
            new Thickness(10),
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (BorderComp)bindable;
                control.BorderComponent.Padding = (Thickness)newValue!;
            });
    public new Thickness Padding
    {
        get => (Thickness)GetValue(PaddingProperty);
        set => SetValue(PaddingProperty, value);
    }

    //Margin
    public new static readonly BindableProperty MarginProperty =
    BindableProperty.Create(
        nameof(Margin),
        typeof(Thickness),
        typeof(BorderComp),
        new Thickness(10),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (BorderComp)bindable;
            if (control.BorderComponent != null)
                control.BorderComponent.Margin = (Thickness)newValue!;
        });
    public new Thickness Margin
    {
        get => (Thickness)GetValue(MarginProperty);
        set => SetValue(MarginProperty, value);
    }
}
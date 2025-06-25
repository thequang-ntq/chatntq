namespace chatntq.APP.Components.Label;

public partial class LabelComp : ContentView
{
	public LabelComp()
	{
		InitializeComponent();
	}

    // TEXT
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(LabelComp),
            String.Empty,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (LabelComp)bindable;
                control.LabelComponent.Text = (string)newValue!;
            });
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    // Padding
    public new static readonly BindableProperty PaddingProperty =
        BindableProperty.Create(
            nameof(Padding),
            typeof(Thickness),
            typeof(LabelComp),
            new Thickness(10),
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (LabelComp)bindable;
                control.LabelComponent.Padding = (Thickness)newValue!;
            });
    public new Thickness Padding
    {
        get => (Thickness)GetValue(PaddingProperty);
        set => SetValue(PaddingProperty, value);
    }

    // FontSize
    public static readonly BindableProperty FontSizeProperty =
        BindableProperty.Create(
            nameof(FontSize),
            typeof(double),
            typeof(LabelComp),
            14.0,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (LabelComp)bindable;
                control.LabelComponent.FontSize = (double)newValue!;
            });
    public double FontSize
    {
        get => (double)GetValue(FontSizeProperty);
        set => SetValue(FontSizeProperty, value);
    }

    // FontFamily
    public static readonly BindableProperty FontFamilyProperty =
        BindableProperty.Create(
            nameof(FontFamily),
            typeof(string),
            typeof(LabelComp),
            string.Empty,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (LabelComp)bindable;
                control.LabelComponent.FontFamily = (string?)newValue;
            });

    public string? FontFamily
    {
        get => (string?)GetValue(FontFamilyProperty);
        set => SetValue(FontFamilyProperty, value);
    }

    // FontAttributes
    public static readonly BindableProperty FontAttributesProperty =
        BindableProperty.Create(
            nameof(FontAttributes),
            typeof(FontAttributes),
            typeof(LabelComp),
            FontAttributes.None,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (LabelComp)bindable;
                control.LabelComponent.FontAttributes = (FontAttributes)newValue!;
            });

    public FontAttributes FontAttributes
    {
        get => (FontAttributes)GetValue(FontAttributesProperty);
        set => SetValue(FontAttributesProperty, value);
    }

    // VERTICAL OPTIONS
    public new static readonly BindableProperty VerticalOptionsProperty =
        BindableProperty.Create(
            nameof(VerticalOptions),
            typeof(LayoutOptions),
            typeof(LabelComp),
            LayoutOptions.Center,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (LabelComp)bindable;
                control.LabelComponent.VerticalOptions = (LayoutOptions)newValue!;
            });
    public new LayoutOptions VerticalOptions
    {
        get => (LayoutOptions)GetValue(HorizontalOptionsProperty);
        set => SetValue(HorizontalOptionsProperty, value);
    }

    // HORIZONTAL OPTIONS
    public new static readonly BindableProperty HorizontalOptionsProperty =
        BindableProperty.Create(
            nameof(HorizontalOptions),
            typeof(LayoutOptions),
            typeof(LabelComp),
            LayoutOptions.Center,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (LabelComp)bindable;
                control.LabelComponent.HorizontalOptions = (LayoutOptions)newValue!;
            });
    public new LayoutOptions HorizontalOptions
    {
        get => (LayoutOptions)GetValue(HorizontalOptionsProperty);
        set => SetValue(HorizontalOptionsProperty, value);
    }
}
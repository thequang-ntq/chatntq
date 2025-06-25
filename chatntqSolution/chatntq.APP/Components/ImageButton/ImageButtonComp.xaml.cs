namespace chatntq.APP.Components.ImageButton;

public partial class ImageButtonComp : ContentView
{
	public ImageButtonComp()
	{
		InitializeComponent();
	}

    // Source
    public static readonly BindableProperty SourceProperty =
        BindableProperty.Create(
            nameof(Source),
            typeof(ImageSource),
            typeof(ImageButtonComp),
            default(ImageSource),
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (ImageButtonComp)bindable;
                control.ImageButtonComponent.Source = (ImageSource?)newValue!;
            });
    public ImageSource? Source
    {
        get => (ImageSource?)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    // VERTICAL OPTIONS
    public new static readonly BindableProperty VerticalOptionsProperty =
        BindableProperty.Create(
            nameof(VerticalOptions),
            typeof(LayoutOptions),
            typeof(ImageButtonComp),
            LayoutOptions.Center,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (ImageButtonComp)bindable;
                control.ImageButtonComponent.VerticalOptions = (LayoutOptions)newValue!;
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
            typeof(ImageButtonComp),
            LayoutOptions.Center,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var control = (ImageButtonComp)bindable;
                control.ImageButtonComponent.HorizontalOptions = (LayoutOptions)newValue!;
            });
    public new LayoutOptions HorizontalOptions
    {
        get => (LayoutOptions)GetValue(HorizontalOptionsProperty);
        set => SetValue(HorizontalOptionsProperty, value);
    }
}
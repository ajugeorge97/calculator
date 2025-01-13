namespace Calculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

	}

	protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window(new AppShell());
        
        // Set the window size constraints
        window.MinimumWidth = 260;
        window.MaximumWidth = 260;
        window.MinimumHeight = 500;
        window.MaximumHeight = 500;

        return window;
    }
}

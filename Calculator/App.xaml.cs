namespace Calculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		// MainPage = new AppShell();
	}

	protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window(new AppShell());
        
        // Set the window size constraints
        window.MinimumWidth = 260;
        window.MaximumWidth = 260;
        window.MinimumHeight = 500;
        window.MaximumHeight = 500;

        // Give the Window time to resize (via Dispatcher)
        // Dispatcher.Dispatch(() =>
        // {
        //     window.MinimumWidth = 0;
        //     window.MinimumHeight = 0;
        //     window.MaximumWidth = double.PositiveInfinity;
        //     window.MaximumHeight = double.PositiveInfinity;
        // });

        return window;
    }
}

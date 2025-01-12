namespace Calculator;
using System.Text.RegularExpressions;
using System.Data;

public partial class MainPage : ContentPage
{
	// int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	public static double EvaluateExpression(string expression)
    {
        try
        {
            // Use DataTable to compute the result of the expression
            DataTable table = new DataTable();
            var result = table.Compute(expression, string.Empty);

            // Convert the result to double and return
            return Convert.ToDouble(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error evaluating expression: {ex.Message}");
            return double.NaN; // Return NaN for invalid expressions
        }
    }

	public string FilterText(string text)
	{
	// filter text based on the operators
		string[] parts = Regex.Split(text, @"(?=[+\-*/])|(?<=[+\-*/])");

		for (int i = 0; i < parts.Length; i++)
		{	
			//  hanlde extra zeros
			if (decimal.TryParse(parts[i], out decimal number))
			{
				parts[i] = number.ToString();
			}
		}

		return string.Join(" ", parts); 
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		string Text = DisplayLabel.Text + button.Text;
		string Updated_Text = FilterText(Text);

		DisplayLabel.Text = Updated_Text;

	}

	

	public void OnClearClicked(object sender, EventArgs e)
	{
		DisplayLabel.Text = string.Empty;

		if (DisplayLabel.Text == string.Empty)
		{
			DisplayLabel.Text = "0";
		}
	}

	public void OnEqualClicked(object sender, EventArgs e)
	{
		string expression = DisplayLabel.Text;
		double result = EvaluateExpression(expression);
		DisplayLabelOperation.Text = expression;
		DisplayLabel.Text = result.ToString();
	}


}


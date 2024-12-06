namespace Factorial_prime_factorial_series_calculator_demo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Resize += Form1_Resize;
        CenterPanel();
    }
    
    private void Form1_Resize(object? sender, EventArgs e)
    {
        CenterPanel();
    }

    private void CenterPanel()
    {
        panel1.Location = new Point(
            (ClientSize.Width - panel1.Width) / 2,
            (ClientSize.Height - panel1.Height) / 2
        );
    }

    private int? GetInputInteger()
    {
        try
        {
            return int.Parse(textBox1.Text);
        }
        catch (Exception)
        {
            MessageBox.Show("Invalid input. Please enter a valid integer.");
            return null;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox2.Text = "";

        var input = GetInputInteger();
        if (input == null) return;
        var isPrime = true;
        for (var i = 2; i < input; i++)
        {
            if (input % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        textBox2.Text = isPrime ? "Prime" : "Not prime";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        textBox2.Text = "";

        var input = GetInputInteger();
        if (input == null) return;
        var factorial = 1;
        for (var i = 1; i <= input; i++)
        {
            factorial *= i;
        }

        textBox2.Text = factorial.ToString();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        textBox2.Text = "";

        var input = GetInputInteger();
        if (input == null) return;
        var factorialSeries = "";
        var factorial = 1;
        for (var i = 1; i <= input; i++)
        {
            factorial *= i;
            factorialSeries += $"{factorial} ";
        }

        textBox2.Text = factorialSeries;
    }
}
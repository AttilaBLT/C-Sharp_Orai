namespace Vehicle.Ui.CustomControls;

public class NumericBox : TextBox
{
    private static readonly CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;

    public NumericBox()
    {
        Text = string.Empty;
    }

    public int? IntValue
    {
        get
        {
            bool isNumber = int.TryParse(Text, cultureInfo, out int value);

            return isNumber ? value : null;
        }
        set
        {
            Text = value.ToString();
        }
    }

    public double? DoubleValue
    {
        get
        {
            bool isNumber = double.TryParse(Text, cultureInfo, out double value);

            return isNumber ? value : null;
        }
        set
        {
            Text = value.ToString();
        }
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);

        char key = e.KeyChar;

        if (!char.IsNumber(key) && key != 8 && key != 143 && key != 56 && key != 44 && key != 46)
        {
            e.Handled = true;
        }
    }
}

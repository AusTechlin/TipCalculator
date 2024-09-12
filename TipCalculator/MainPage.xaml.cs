namespace TipCalculator;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        Title = "Tip Calculator Pro";
    }


    private void Calculate_OnClicked(object sender, EventArgs e)
    {
        var TipPercent = Double.Parse(((Button)sender).CommandParameter.ToString());
        var strPercent = (TipPercent * 100).ToString();
        Double dblAmount, dblTip, dblTotal;
        Double.TryParse(txtAmount.Text, out dblAmount);
        dblTip = TipPercent * dblAmount;
        dblTotal = dblAmount + dblTip;
        lblResult.Text = strPercent + "% Tip | " + dblTip.ToString("C2") + " Tip | Total " + dblTotal.ToString("C2");
    }
}
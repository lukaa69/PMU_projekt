namespace PMU_projekt;

public partial class NewtonsLawPage : ContentPage
{
    public NewtonsLawPage()
    {
        InitializeComponent();
    }

    private void OnCalculateNewtonsLaw(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(MassEntry.Text) || string.IsNullOrWhiteSpace(AccelerationEntry.Text))
        {
            DisplayAlert("Greška", "Sva polja moraju biti popunjena!", "OK");
            return;
        }

        if (!double.TryParse(MassEntry.Text, out double mass) || !double.TryParse(AccelerationEntry.Text, out double acceleration))
        {
            DisplayAlert("Greška", "Unesite ispravne numeričke vrijednosti!", "OK");
            return;
        }

        if (mass <= 0)
        {
            DisplayAlert("Greška", "Masa mora biti veća od nule!", "OK");
            return;
        }

        double force = mass * acceleration;
        ResultLabel.Text = $"Sila: {force:F2} N";
    }
}

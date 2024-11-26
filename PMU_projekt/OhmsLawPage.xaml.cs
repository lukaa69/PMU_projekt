namespace PMU_projekt;

public partial class OhmsLawPage : ContentPage
{
    public OhmsLawPage()
    {
        InitializeComponent();
    }

    private void OnCalculateOhmsLaw(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(VoltageEntry.Text) || string.IsNullOrWhiteSpace(ResistanceEntry.Text))
        {
            DisplayAlert("Greška", "Sva polja moraju biti popunjena!", "OK");
            return;
        }

        if (!double.TryParse(VoltageEntry.Text, out double voltage) || !double.TryParse(ResistanceEntry.Text, out double resistance))
        {
            DisplayAlert("Greška", "Unesite ispravne numeričke vrijednosti!", "OK");
            return;
        }

        if (resistance <= 0)
        {
            DisplayAlert("Greška", "Otpor mora biti veći od nule!", "OK");
            return;
        }

        double current = voltage / resistance;
        ResultLabel.Text = $"Struja: {current:F2} A";
    }
}

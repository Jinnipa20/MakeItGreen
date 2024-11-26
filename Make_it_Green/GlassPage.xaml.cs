namespace Make_it_Green;

public partial class GlassPage : ContentPage
{
	public GlassPage()
	{
		InitializeComponent();
	// ซ่อนแถบ Navigation Bar PaperPage
        NavigationPage.SetHasNavigationBar(this, false);
	}
	private int stepperValue = 0;

        private async void OnMinusTapped(object sender, EventArgs e)
        {
            if (stepperValue > 0)
            {
                stepperValue--;
                StepperWeightLabel.Text = stepperValue.ToString();
                // แปลงค่าใน StepperWeightLabel เป็นตัวเลข
                if (double.TryParse(StepperWeightLabel.Text, out double weight))
                {
                    // คำนวณ Price rate paper 4 THB/kg.
                    double result = weight * 4;

                    // แสดงผลลัพธ์ใน Label
                    ResultLabel.Text = $"{result}";
                }
            }
        }
                

        private async void OnPlusTapped(object sender, EventArgs e)
        {
            stepperValue++;
            StepperWeightLabel.Text = stepperValue.ToString();

            // แปลงค่าใน StepperWeightLabel เป็นตัวเลข
            if (double.TryParse(StepperWeightLabel.Text, out double weight))
            {
                // คำนวณ Price rate paper 4 THB/kg.
                double result = weight * 4;

                // แสดงผลลัพธ์ใน Label
                 ResultLabel.Text = $"{result}";
            }
        }
	private void OnSaveClicked(object sender, EventArgs e)
    {
    }
}
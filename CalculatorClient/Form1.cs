using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace CalculatorClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tambahkan event handler btnCalculate_Click
        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtNumber1.Text);
            double number2 = double.Parse(txtNumber2.Text);
            string operation = cbOperation.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(operation))
            {
                lblResult.Text = "Error: Pilih operasi yang valid";
                return;
            }

            var request = new CalculationRequest
            {
                Number1 = number1,
                Number2 = number2,
                Operation = operation
            };

            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("http://localhost:5000/calculate", request);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<CalculationResponse>();
                    lblResult.Text = $"Hasil: {result?.Result}";
                }
                else
                {
                    lblResult.Text = "Error: Tidak dapat menghitung";
                }
            }
        }
    }

    public class CalculationRequest
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Operation { get; set; } = string.Empty; // Inisialisasi default
    }

    public class CalculationResponse
    {
        public double Result { get; set; }
    }
}
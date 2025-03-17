using KalkulatorApp.Interfaces;
using System.Globalization;


namespace KalkulatorApp;

public partial class Form1 : Form
{
    private ICalculationRepository _calculationRepository;
    private ICurrencyRepository _currencyRepository;
    private ICalcHistoryRepository _calcHistoryRepository;

    string currentInput = "";

    public Form1(ICalculationRepository calculationRepository, ICurrencyRepository currencyRepository, ICalcHistoryRepository calcHistoryRepository)
    {
        InitializeComponent();
        _calculationRepository = calculationRepository;
        _currencyRepository = currencyRepository;
        _calcHistoryRepository = calcHistoryRepository;
        RefreshHistory();

    }
    private void Button_Click(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
    }
    private void button17_Click(object sender, EventArgs e)
    {
        currentInput = "";
        textBox1.Text = "";
    }
    private void button12_Click(object sender, EventArgs e)
    {
        try
        {
            var expression = textBox1.Text.Trim();
            double calcResult = _calculationRepository.EvaluateExpression(expression);

            currentInput = calcResult.ToString(CultureInfo.InvariantCulture);
            textBox1.Text = calcResult.ToString(CultureInfo.InvariantCulture);

            _calcHistoryRepository.SaveCalculation(expression, calcResult);
            RefreshHistory();
        }
        catch (DivideByZeroException)
        {
            MessageBox.Show("Error: Attempt to divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            int index = textBox1.Text.IndexOf("/0");
            if (index != -1)
            {
                textBox1.Text = textBox1.Text.Substring(0, index);
                currentInput = textBox1.Text;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox1.Clear();
            currentInput = "";
        }
    }

    private void CustomizeDataGridView()
    {
        dataGridView1.BorderStyle = BorderStyle.None;
        dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);
        dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
        dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
        dataGridView1.BackgroundColor = System.Drawing.Color.White;

        dataGridView1.EnableHeadersVisualStyles = false;
        dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 25, 72);
        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        dataGridView1.Columns["Id"].Visible = false;
    }



    private async void buttonFetchRates_Click_1(object sender, EventArgs e)
    {
        DateTime startDate = dateTimePickerStart.Value.Date;
        DateTime endDate = dateTimePickerEnd.Value.Date;
        string? fromCurrency = comboBoxCurrency1.SelectedItem?.ToString();
        string? toCurrency = comboBoxCurrency2.SelectedItem?.ToString();

        if (fromCurrency == null || toCurrency == null)
        {
            labelBestDay.Text = "Please select currencies.";
            return;
        }

        if (startDate > endDate)
        {
            labelBestDay.Text = "The start date cannot be later than the end date.";
            return;
        }

        decimal amount = 0;
        if (!string.IsNullOrWhiteSpace(textBoxAmount.Text) && !decimal.TryParse(textBoxAmount.Text, out amount))
        {
            labelBestDay.Text = "Invalid amount.";
            return;
        }
        await _currencyRepository.FetchAndSaveExchangeRates(startDate, endDate, fromCurrency);
        await _currencyRepository.FetchAndSaveExchangeRates(startDate, endDate, toCurrency);
        labelBestDay.Text = _currencyRepository.GetBestExchangeDate(fromCurrency, toCurrency, startDate, endDate, amount);
    }
    private void RefreshHistory()
    {
        dataGridView1.DataSource = _calcHistoryRepository.GetCalcHistory();
        CustomizeDataGridView();
    }
}

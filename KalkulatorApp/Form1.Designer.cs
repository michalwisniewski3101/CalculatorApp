namespace KalkulatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button11 = new Button();
            button12 = new Button();
            textBox1 = new TextBox();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button18 = new Button();
            button17 = new Button();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxCurrency2 = new ComboBox();
            textBoxAmount = new TextBox();
            labelBestDay = new Label();
            buttonFetchRates = new Button();
            comboBoxCurrency1 = new ComboBox();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            calculatorContextBindingSource1 = new BindingSource(components);
            calculatorContextBindingSource = new BindingSource(components);
            calculatorContextBindingSource2 = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calculatorContextBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calculatorContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calculatorContextBindingSource2).BeginInit();
            SuspendLayout();

            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Zablokowanie zmiany rozmiaru
            this.MaximizeBox = false; // Zablokowanie maksymalizacji
            this.MinimizeBox = false; // Zablokowanie minimalizacji (opcjonalnie)
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(5, 47);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(88, 75);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(99, 47);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(88, 75);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.Location = new Point(191, 47);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(88, 75);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button4.Location = new Point(5, 127);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(88, 75);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button5.Location = new Point(99, 127);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(88, 75);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button6.Location = new Point(191, 127);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(88, 75);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button7.Location = new Point(5, 206);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(88, 75);
            button7.TabIndex = 5;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button8.Location = new Point(99, 207);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(88, 75);
            button8.TabIndex = 4;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button9.Location = new Point(191, 206);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(88, 75);
            button9.TabIndex = 11;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button11.Location = new Point(98, 286);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(88, 75);
            button11.TabIndex = 9;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Button_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button12.Location = new Point(6, 365);
            button12.Margin = new Padding(3, 2, 3, 2);
            button12.Name = "button12";
            button12.Size = new Size(273, 75);
            button12.TabIndex = 8;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(5, 4);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 39);
            textBox1.TabIndex = 12;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button13.Location = new Point(283, 286);
            button13.Margin = new Padding(3, 2, 3, 2);
            button13.Name = "button13";
            button13.Size = new Size(88, 154);
            button13.TabIndex = 16;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Button_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button14.Location = new Point(283, 207);
            button14.Margin = new Padding(3, 2, 3, 2);
            button14.Name = "button14";
            button14.Size = new Size(88, 75);
            button14.TabIndex = 15;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Button_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button15.Location = new Point(284, 127);
            button15.Margin = new Padding(3, 2, 3, 2);
            button15.Name = "button15";
            button15.Size = new Size(88, 75);
            button15.TabIndex = 14;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Button_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button16.Location = new Point(284, 47);
            button16.Margin = new Padding(3, 2, 3, 2);
            button16.Name = "button16";
            button16.Size = new Size(88, 75);
            button16.TabIndex = 13;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 11);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(385, 476);
            tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button18);
            tabPage1.Controls.Add(button17);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button13);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button14);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button15);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button16);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button9);
            tabPage1.Controls.Add(button8);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button11);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button12);
            tabPage1.Controls.Add(button5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(377, 448);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Calculator";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button18.Location = new Point(191, 286);
            button18.Margin = new Padding(3, 2, 3, 2);
            button18.Name = "button18";
            button18.Size = new Size(88, 75);
            button18.TabIndex = 18;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = true;
            button18.Click += Button_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button17.Location = new Point(6, 286);
            button17.Margin = new Padding(3, 2, 3, 2);
            button17.Name = "button17";
            button17.Size = new Size(88, 75);
            button17.TabIndex = 17;
            button17.Text = "C";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(377, 448);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Calculation History";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 2);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(371, 444);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(comboBoxCurrency2);
            tabPage3.Controls.Add(textBoxAmount);
            tabPage3.Controls.Add(labelBestDay);
            tabPage3.Controls.Add(buttonFetchRates);
            tabPage3.Controls.Add(comboBoxCurrency1);
            tabPage3.Controls.Add(dateTimePickerEnd);
            tabPage3.Controls.Add(dateTimePickerStart);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(377, 448);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Currency Calculator";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 189);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 13;
            label6.Text = "Date to:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 160);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 12;
            label5.Text = "Date from:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(77, 14);
            label4.Name = "label4";
            label4.Size = new Size(220, 20);
            label4.TabIndex = 11;
            label4.Text = "Best date for currency exchange";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 70);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 10;
            label3.Text = "Enter amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 128);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 9;
            label2.Text = "Select target currency:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 99);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 8;
            label1.Text = "Select source currency:";
            // 
            // comboBoxCurrency2
            // 
            comboBoxCurrency2.FormattingEnabled = true;
            comboBoxCurrency2.Items.AddRange(new object[] { "USD", "EUR", "GBP", "PLN" });
            comboBoxCurrency2.Location = new Point(200, 125);
            comboBoxCurrency2.Name = "comboBoxCurrency2";
            comboBoxCurrency2.Size = new Size(159, 23);
            comboBoxCurrency2.TabIndex = 7;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(200, 67);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(159, 23);
            textBoxAmount.TabIndex = 5;
            // 
            // labelBestDay
            // 
            labelBestDay.AutoSize = true;
            labelBestDay.Location = new Point(19, 294);
            labelBestDay.Name = "labelBestDay";
            labelBestDay.Size = new Size(0, 15);
            labelBestDay.TabIndex = 4;
            // 
            // buttonFetchRates
            // 
            buttonFetchRates.Location = new Point(284, 232);
            buttonFetchRates.Name = "buttonFetchRates";
            buttonFetchRates.Size = new Size(75, 23);
            buttonFetchRates.TabIndex = 3;
            buttonFetchRates.Text = "Calculate";
            buttonFetchRates.UseVisualStyleBackColor = true;
            buttonFetchRates.Click += buttonFetchRates_Click_1;
            // 
            // comboBoxCurrency1
            // 
            comboBoxCurrency1.FormattingEnabled = true;
            comboBoxCurrency1.Items.AddRange(new object[] { "USD", "EUR", "GBP", "PLN" });
            comboBoxCurrency1.Location = new Point(200, 96);
            comboBoxCurrency1.Name = "comboBoxCurrency1";
            comboBoxCurrency1.Size = new Size(159, 23);
            comboBoxCurrency1.TabIndex = 2;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "yyyy-MM-dd";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(200, 183);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(159, 23);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "yyyy-MM-dd";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(200, 154);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(159, 23);
            dateTimePickerStart.TabIndex = 0;
            // 
            // calculatorContextBindingSource1
            // 
            calculatorContextBindingSource1.DataSource = typeof(CalculatorContext);
            // 
            // calculatorContextBindingSource
            // 
            calculatorContextBindingSource.DataSource = typeof(CalculatorContext);
            // 
            // calculatorContextBindingSource2
            // 
            calculatorContextBindingSource2.DataSource = typeof(CalculatorContext);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 485);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)calculatorContextBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)calculatorContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)calculatorContextBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button11;
        private Button button12;
        private TextBox textBox1;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private BindingSource calculatorContextBindingSource1;
        private BindingSource calculatorContextBindingSource;
        private BindingSource calculatorContextBindingSource2;
        private TabPage tabPage3;
        private Label labelBestDay;
        private Button buttonFetchRates;
        private ComboBox comboBoxCurrency1;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private TextBox textBoxAmount;
        private ComboBox comboBoxCurrency2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button18;
        private Button button17;
    }
}

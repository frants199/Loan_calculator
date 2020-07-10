namespace Loan_calculator
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.credit_table = new System.Windows.Forms.DataGridView();
			this.calculate_button = new System.Windows.Forms.Button();
			this.reset_button = new System.Windows.Forms.Button();
			this.credit_amount_label = new System.Windows.Forms.Label();
			this.credit_term_label = new System.Windows.Forms.Label();
			this.interest_rate_label = new System.Windows.Forms.Label();
			this.payment_type_label = new System.Windows.Forms.Label();
			this.credit_amount_box = new System.Windows.Forms.TextBox();
			this.interest_rate_box = new System.Windows.Forms.TextBox();
			this.payment_type_box = new System.Windows.Forms.ComboBox();
			this.currency_box = new System.Windows.Forms.ComboBox();
			this.begin_label = new System.Windows.Forms.Label();
			this.month_box = new System.Windows.Forms.ComboBox();
			this.year_box = new System.Windows.Forms.ComboBox();
			this.credit_term_box = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.credit_table)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.credit_term_box)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// credit_table
			// 
			this.credit_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.credit_table.Location = new System.Drawing.Point(12, 161);
			this.credit_table.Name = "credit_table";
			this.credit_table.RowTemplate.Height = 24;
			this.credit_table.Size = new System.Drawing.Size(792, 244);
			this.credit_table.TabIndex = 0;
			// 
			// calculate_button
			// 
			this.calculate_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.calculate_button.Location = new System.Drawing.Point(619, 22);
			this.calculate_button.Name = "calculate_button";
			this.calculate_button.Size = new System.Drawing.Size(185, 34);
			this.calculate_button.TabIndex = 1;
			this.calculate_button.Text = "Рассчитать";
			this.calculate_button.UseVisualStyleBackColor = true;
			this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
			// 
			// reset_button
			// 
			this.reset_button.Location = new System.Drawing.Point(619, 60);
			this.reset_button.Name = "reset_button";
			this.reset_button.Size = new System.Drawing.Size(185, 34);
			this.reset_button.TabIndex = 2;
			this.reset_button.Text = "Сброс";
			this.reset_button.UseVisualStyleBackColor = true;
			this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
			// 
			// credit_amount_label
			// 
			this.credit_amount_label.AutoSize = true;
			this.credit_amount_label.Location = new System.Drawing.Point(6, 23);
			this.credit_amount_label.Name = "credit_amount_label";
			this.credit_amount_label.Size = new System.Drawing.Size(109, 17);
			this.credit_amount_label.TabIndex = 3;
			this.credit_amount_label.Text = "Сумма кредита:";
			// 
			// credit_term_label
			// 
			this.credit_term_label.AutoSize = true;
			this.credit_term_label.Location = new System.Drawing.Point(6, 52);
			this.credit_term_label.Name = "credit_term_label";
			this.credit_term_label.Size = new System.Drawing.Size(96, 17);
			this.credit_term_label.TabIndex = 4;
			this.credit_term_label.Text = "Срок кредита:";
			// 
			// interest_rate_label
			// 
			this.interest_rate_label.AutoSize = true;
			this.interest_rate_label.Location = new System.Drawing.Point(10, 88);
			this.interest_rate_label.Name = "interest_rate_label";
			this.interest_rate_label.Size = new System.Drawing.Size(131, 17);
			this.interest_rate_label.TabIndex = 5;
			this.interest_rate_label.Text = "Процентная ставка:";
			// 
			// payment_type_label
			// 
			this.payment_type_label.AutoSize = true;
			this.payment_type_label.Location = new System.Drawing.Point(10, 116);
			this.payment_type_label.Name = "payment_type_label";
			this.payment_type_label.Size = new System.Drawing.Size(92, 17);
			this.payment_type_label.TabIndex = 6;
			this.payment_type_label.Text = "Вид платежа:";
			// 
			// credit_amount_box
			// 
			this.credit_amount_box.Location = new System.Drawing.Point(146, 20);
			this.credit_amount_box.Name = "credit_amount_box";
			this.credit_amount_box.Size = new System.Drawing.Size(121, 25);
			this.credit_amount_box.TabIndex = 7;
			// 
			// interest_rate_box
			// 
			this.interest_rate_box.Location = new System.Drawing.Point(146, 85);
			this.interest_rate_box.Name = "interest_rate_box";
			this.interest_rate_box.Size = new System.Drawing.Size(121, 25);
			this.interest_rate_box.TabIndex = 9;
			// 
			// payment_type_box
			// 
			this.payment_type_box.AutoCompleteCustomSource.AddRange(new string[] {
            "Аннуитетный",
            "Дифференцированный"});
			this.payment_type_box.FormattingEnabled = true;
			this.payment_type_box.Items.AddRange(new object[] {
            "Аннуитетный",
            "Дифференцированный"});
			this.payment_type_box.Location = new System.Drawing.Point(146, 116);
			this.payment_type_box.Name = "payment_type_box";
			this.payment_type_box.Size = new System.Drawing.Size(121, 25);
			this.payment_type_box.TabIndex = 10;
			// 
			// currency_box
			// 
			this.currency_box.AutoCompleteCustomSource.AddRange(new string[] {
            "Рубли",
            "Доллары",
            "Евро"});
			this.currency_box.FormattingEnabled = true;
			this.currency_box.Items.AddRange(new object[] {
            "₽",
            "$",
            "€"});
			this.currency_box.Location = new System.Drawing.Point(273, 20);
			this.currency_box.Name = "currency_box";
			this.currency_box.Size = new System.Drawing.Size(121, 25);
			this.currency_box.TabIndex = 11;
			// 
			// begin_label
			// 
			this.begin_label.AutoSize = true;
			this.begin_label.Location = new System.Drawing.Point(273, 119);
			this.begin_label.Name = "begin_label";
			this.begin_label.Size = new System.Drawing.Size(106, 17);
			this.begin_label.TabIndex = 12;
			this.begin_label.Text = "Начало выплат:";
			// 
			// month_box
			// 
			this.month_box.AutoCompleteCustomSource.AddRange(new string[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
			this.month_box.FormattingEnabled = true;
			this.month_box.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
			this.month_box.Location = new System.Drawing.Point(385, 116);
			this.month_box.Name = "month_box";
			this.month_box.Size = new System.Drawing.Size(121, 25);
			this.month_box.TabIndex = 13;
			// 
			// year_box
			// 
			this.year_box.AutoCompleteCustomSource.AddRange(new string[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
			this.year_box.FormattingEnabled = true;
			this.year_box.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
			this.year_box.Location = new System.Drawing.Point(512, 116);
			this.year_box.Name = "year_box";
			this.year_box.Size = new System.Drawing.Size(81, 25);
			this.year_box.TabIndex = 14;
			// 
			// credit_term_box
			// 
			this.credit_term_box.Location = new System.Drawing.Point(202, 52);
			this.credit_term_box.Name = "credit_term_box";
			this.credit_term_box.Size = new System.Drawing.Size(65, 25);
			this.credit_term_box.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(273, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 17);
			this.label1.TabIndex = 16;
			this.label1.Text = "лет";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(273, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "% в год";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.year_box);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.begin_label);
			this.groupBox1.Controls.Add(this.month_box);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.credit_amount_box);
			this.groupBox1.Controls.Add(this.payment_type_box);
			this.groupBox1.Controls.Add(this.credit_term_box);
			this.groupBox1.Controls.Add(this.interest_rate_box);
			this.groupBox1.Controls.Add(this.currency_box);
			this.groupBox1.Controls.Add(this.payment_type_label);
			this.groupBox1.Controls.Add(this.credit_amount_label);
			this.groupBox1.Controls.Add(this.interest_rate_label);
			this.groupBox1.Controls.Add(this.credit_term_label);
			this.groupBox1.Location = new System.Drawing.Point(12, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(601, 147);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры кредита";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 420);
			this.Controls.Add(this.reset_button);
			this.Controls.Add(this.calculate_button);
			this.Controls.Add(this.credit_table);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "Form1";
			this.Text = "Калькулятор кредитов";
			((System.ComponentModel.ISupportInitialize)(this.credit_table)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.credit_term_box)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView credit_table;
		private System.Windows.Forms.Button calculate_button;
		private System.Windows.Forms.Button reset_button;
		private System.Windows.Forms.Label credit_amount_label;
		private System.Windows.Forms.Label credit_term_label;
		private System.Windows.Forms.Label interest_rate_label;
		private System.Windows.Forms.Label payment_type_label;
		private System.Windows.Forms.TextBox credit_amount_box;
		private System.Windows.Forms.TextBox interest_rate_box;
		private System.Windows.Forms.ComboBox payment_type_box;
		private System.Windows.Forms.ComboBox currency_box;
		private System.Windows.Forms.Label begin_label;
		private System.Windows.Forms.ComboBox month_box;
		private System.Windows.Forms.ComboBox year_box;
		private System.Windows.Forms.NumericUpDown credit_term_box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}


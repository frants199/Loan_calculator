using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Loan_calculator
{
	public partial class Form1 : Form
	{
		string[] month_collection = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
		string[] year_collection = { "2010", "2011", "2012", "2013", "2014", "2015", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030" };
		public Form1()
		{
			InitializeComponent();
			currency_box.SelectedItem = currency_box.Items[0];
			month_box.DataSource = month_collection;
			month_box.SelectedItem = month_box.Items[0];
			year_box.DataSource = year_collection;
			year_box.SelectedItem = year_box.Items[0];
			payment_type_box.SelectedItem = payment_type_box.Items[0];
		}

		private void reset_button_Click(object sender, EventArgs e)
		{
			credit_amount_box.Clear();
			credit_term_box.Value = 0;
			interest_rate_box.Clear();
			payment_type_box.SelectedItem = payment_type_box.Items[0];
			currency_box.SelectedItem = currency_box.Items[0];
			month_box.SelectedItem = month_box.Items[0];
			year_box.SelectedItem = year_box.Items[0];
			credit_table.Rows.Clear();
		}

		private void calculate_button_Click(object sender, EventArgs e)
		{
			try
			{
				List<Debt> credit_list = new List<Debt>();
				Credit credit = new Credit(Convert.ToDouble(credit_amount_box.Text),
					Convert.ToInt32(credit_term_box.Value),
					Convert.ToDouble(interest_rate_box.Text),
					Credit.PaymentType(payment_type_box.Text),
					Credit.ToDate(month_box.Text, year_box.Text));
				int m = month_box.SelectedIndex;
				int y = year_box.SelectedIndex;
				Debt debt = new Debt(credit);
				for (int i = 0; i < credit.Credit_term * 12; i++)
				{
					debt = new Debt(credit);
					string month = month_collection[m];
					string year = year_collection[y];
					debt.Date = month + " " + year;
					debt.Calculate_main_debt(credit);
					debt.Calculate_interest_changes(credit);
					debt.Calculate_monthly_payment(credit);
					credit_list.Add(debt);
					if (m == 11)
					{
						m = 0;
						y++;
					}
					else
						m++;
					credit.Credit_amount -= debt.Debt_balance;
				}
				credit_table.DataSource = credit_list;
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
	}
}

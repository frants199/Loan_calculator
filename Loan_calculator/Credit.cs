using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_calculator
{
	class Credit
	{
		protected double _credit_amount;//сумма кредита
		protected int _credit_term;//срок редита
		protected double _interest_rate;//ставка по кредиту (в год)
		protected bool _payment_type;//вид платежа true - дифференцированный false - аннуитетный
		protected string _begin_date;//дата первого платежа
		
		public Credit() { }
		public Credit(double credit_amount, int credit_term, double interest_rate, bool payment_type,
			string begin_date)
		{
			_credit_amount = credit_amount;
			_credit_term = credit_term;
			_interest_rate = interest_rate;
			_payment_type = payment_type;
			_begin_date = begin_date;
		}
		public double Credit_amount
		{
			get => _credit_amount;
			set => _credit_amount = value;
		}
		public int Credit_term
		{
			get => _credit_term;
			set => _credit_term =value;
		}
		public double Interest_rate
		{
			get => _interest_rate;
			set => _interest_rate = value;
		}
		public bool Payment_type
		{
			get => _payment_type;
			set => _payment_type = value;
		}
		public string Begin_date
		{
			get => _begin_date;
			set => _begin_date = value;
		}
		
		public static string ToPaymentType(bool value)
		{
			if (value) return "Дифференцированный";
			else return "Аннуитетный";
		}
		public static bool PaymentType(string value)
		{
			if (value == "Аннуитетный") return false;
			else return true;
		}
		public static string ToDate(string month, string year) => month + " " + year;
	}
	class Debt
	{
		private string _date;//дата выплаты
		private double _monthly_payment;//ежемесячный платеж
		private double _main_debt;//основной долг
		private double _interest_charges;//начисленные проценты
		private double _debt_balance;//остаток задолженности
		public Debt(Credit credit)
		{
			Debt_balance = credit.Credit_amount;
		}
		public string Date
		{
			get =>_date;
			set => _date = value;
		}
		public double Monthly_payment
		{
			get => Math.Round(_monthly_payment, 2);
			set => _monthly_payment = value;
		}
		public double Main_debt
		{
			get => Math.Round(_main_debt, 2);
			set => _main_debt = value;
		}
		public double Interest_charges
		{
			get => Math.Round(_interest_charges, 2);
			set => _interest_charges = value;
		}
		public double Debt_balance
		{
			get => Math.Round(_debt_balance, 2);
			set => _debt_balance = value;
		}
		public void Calculate_monthly_payment(Credit credit)//расчет ежемесячного платежа
		{
			if (credit.Payment_type)
				Monthly_payment = Main_debt + (Interest_charges * Debt_balance);
			else//для аннуитетных
			{
				Monthly_payment = credit.Credit_amount * (Interest_charges + (Interest_charges / ((Math.Pow(1 + Interest_charges, credit.Credit_term * 12)) - 1)));
			}
		}
		public void Calculate_main_debt(Credit credit)//расчет основного долга
		{
			Main_debt = credit.Credit_amount / (credit.Credit_term * 12);
			Calculate_Debt_Balance();
		}
		public void Calculate_interest_changes(Credit credit)//расчет ежемесячных процентов
		{
			if (credit.Payment_type)//для дифференцированного 
			{
				string month = Date.Trim().Split(' ')[0];
				switch (month)
				{
					case "Январь":
						Interest_charges = Debt_balance * credit.Interest_rate * (31 / 365);
						break;
					case "Февраль":
						Interest_charges = Debt_balance * credit.Interest_rate * (28 / 365);
						break;
					case "Март":
						Interest_charges = Debt_balance * credit.Interest_rate * (31 / 365);
						break;
					case "Апрель":
						Interest_charges = Debt_balance * credit.Interest_rate * (30 / 365);
						break;
					case "Май":
						Interest_charges = Debt_balance * credit.Interest_rate * (31 / 365);
						break;
					case "Июнь":
						Interest_charges = Debt_balance * credit.Interest_rate * (30 / 365);
						break;
					case "Июль":
						Interest_charges = Debt_balance * credit.Interest_rate * (31 / 365);
						break;
					case "Август":
						Interest_charges = Debt_balance * credit.Interest_rate * (31 / 365);
						break;
					case "Сентябрь":
						Interest_charges = Debt_balance * credit.Interest_rate * (30 / 365);
						break;
					case "Октябрь":
						Interest_charges = Debt_balance * credit.Interest_rate * (31 / 365);
						break;
					case "Ноябрь":
						Interest_charges = Debt_balance * credit.Interest_rate * (30 / 365);
						break;
					case "Декабрь":
						Interest_charges = Debt_balance * credit.Interest_rate * (31 / 365);
						break;
				}
			}
			else //для аннуитетных
				Interest_charges = (credit.Interest_rate / 100 / 12)/* * Debt_balance*/;
		}
		public void Calculate_Debt_Balance()//расчет остатка задоженности
		{
			Debt_balance -= Main_debt;
		}
	}
}

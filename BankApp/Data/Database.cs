using BankApp.Data.ContainerScripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Data
{
	public class Database
	{
		public string PersonFullName = "Сущенко Андрей Андреевич";
		public string Login = "Susch228";
		public string Password = "12345678";

		public List<System.DateTime> EntersTime;
		public List<CashMachine> CashMachines;
		public List<BankAccount> BankAccounts;
		public List<Card> Cards;
		public List<Credit> Credits;
	}
}

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
		public List<CashMachine> CashMachines = new List<CashMachine> { new CashMachine { Addres = "с. Чапаево, ул. Николаева 1",
                                                                                Otdel="Отделение",
                                                                                Open=false,
                                                                                OpenTime = TimeSpan.Parse("08:00"),
                                                                                CloseTime = TimeSpan.Parse("18:00") },
                                                                new CashMachine{Addres = "Якутск, ул. Вавилова, д.7",
                                                                                Otdel="Банкомат",
                                                                                Open=true,
                                                                                OpenTime = TimeSpan.Parse("00:00"),
                                                                                CloseTime = TimeSpan.Parse("00:00") },
                                                                new CashMachine{Addres = "Новосибирск, ул. Вавилова, д.7",
                                                                                Otdel="Отделение",
                                                                                Open=false,
                                                                                OpenTime = TimeSpan.Parse("08:00"),
                                                                                CloseTime = TimeSpan.Parse("18:00") },
                                                                new CashMachine{Addres = "Иркутск, ул. Вавилова, д.7",
                                                                                Otdel="Банкомат",
                                                                                Open=true,
                                                                                OpenTime = TimeSpan.Parse("00:00"),
                                                                                CloseTime = TimeSpan.Parse("00:00") },
                                                                new CashMachine{Addres = "Владивосток, ул. Вавилова, д.7",
                                                                                Otdel="Отделение",
                                                                                Open=false,
                                                                                OpenTime = TimeSpan.Parse("08:00"),
                                                                                CloseTime = TimeSpan.Parse("18:00") },
                                                                new CashMachine{Addres = "Владивосток, ул. Вавилова, д.7",
                                                                                Otdel="Банкомат",
                                                                                Open=true,
                                                                                OpenTime = TimeSpan.Parse("00:00"),
                                                                                CloseTime = TimeSpan.Parse("00:00") },
                                                                new CashMachine{Addres = "Владивосток, ул. Вавилова, д.7",
                                                                                Otdel="Банкомат",
                                                                                Open=true,
                                                                                OpenTime = TimeSpan.Parse("00:00"),
                                                                                CloseTime = TimeSpan.Parse("00:00") },
                                                                new CashMachine{Addres = "Владивосток, ул. Вавилова, д.7",
                                                                                Otdel="Отделение",
                                                                                Open=false,
                                                                                OpenTime = TimeSpan.Parse("08:00"),
                                                                                CloseTime = TimeSpan.Parse("18:00") },
                                                                new CashMachine{Addres = "Владивосток, ул. Вавилова, д.7",
                                                                                Otdel="Банкомат",
                                                                                Open=true,
                                                                                OpenTime = TimeSpan.Parse("00:00"),
                                                                                CloseTime = TimeSpan.Parse("00:00") },
                                                                new CashMachine{Addres = "Владивосток, ул. Вавилова, д.7",
                                                                                Otdel="Банкомат",
                                                                                Open=true,
                                                                                OpenTime = TimeSpan.Parse("00:00"),
                                                                                CloseTime = TimeSpan.Parse("00:00") },
                                                                new CashMachine{Addres = "Владивосток, ул. Вавилова, д.7",
                                                                                Otdel="Банкомат",
                                                                                Open=true,
                                                                                OpenTime = TimeSpan.Parse("00:00"),
                                                                                CloseTime = TimeSpan.Parse("00:00") },
                                                                new CashMachine{Addres = "Владивосток, ул. Вавилова, д.7",
                                                                                Otdel="Отделение",
                                                                                Open=false,
                                                                                OpenTime = TimeSpan.Parse("08:00"),
                                                                                CloseTime = TimeSpan.Parse("18:00") }
                                                                };
		public List<BankAccount> BankAccounts;
		public List<Card> Cards;
		public List<Credit> Credits;
	}
}

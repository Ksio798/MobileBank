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
        public List<BankAccount> BankAccounts = new List<BankAccount>
        {
            new BankAccount
            {
                Name = "Текущий счет",
                MoneyCount = 11000.00,
                Number = 123456
            },
            new BankAccount
            {
                Name = "Текущий счет",
                MoneyCount = 11000.00,
                Number = 123456
            }

        };
        public List<Credit> Credits = new List<Credit>
        {
            new Credit
            {
                CreditType = "Кредит наличными",
                MoneyCount = 5000.00,
                PayData = "12.04.2018"
            },
             new Credit
            {
                CreditType = "Ипотека",
                MoneyCount = 5000.00,
                PayData = "12.04.2018"
            }
        };
        public List<Card> Cards = new List<Card>
        {
            new Card
            {
                    svgcode = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAAACXBIWXMAAAsTAAALEwEAmpwYAAAB00lEQVR4nO2Wz0sCQRTHjaB/I6/1t0SEh4iCsqwsKFDo0D0qiwrq0CEioqBDlwo0k+gXpOZBtEgy0rTw17qzM2sXT/HijeyWpbREaoEPvsx782bnszPs2xmdrm51q4YR8tJKWM4oyvLwbwrnxLlLQ1nOIlL5lbAcVEJiYW5LERQAmgiV85WCqqJyHlkqmFLaXHEoKwhZKpgxpq8WmDGm/zvgtCTCXSoCD0KsaDDG2I/5JzHF/QQReC4jUR5HhDjcp2XwPxfrWdQAvoz5oG2vg2sjuM0HYqv0YX49sMn9/Ts7JEkWBo7MPJ44m4RVPwXdcrZIjStZsJ5K2sGDrhE+0OQylwVvXe+oOQSLLAf9TgkaPsFR51H5e3Dv4QBvz6Nu3irwj+Dd0B50O/pg/MSqgpVVXcVlWAswWPK96yapYcUznnnosvfAkGsUjE4T2LwLX8Bm1xi07xvUl1PAyg58FD6vaatt3kWYcs9yf8m3wuPPYNS0Zw7C6egXMO7ExaOHK5gIaf+4bN5FOAg7uH8cOSsJNhx0wm0yXBJsdA7+rJxiQgIyEuE+lgvG5cpJoO/lhDH695nHf/IDIdUG01odElCrY7FmF4EqXX1aVFDd6qaroL0Bznpah4S81u8AAAAASUVORK5CYII=",
                    Name = "Дебетовая карта",
                    Money = 22000.00,
                    Number = 12344321
            },
            new Card
            {
                    svgcode = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAAACXBIWXMAAAsTAAALEwEAmpwYAAACMklEQVR4nO3WzWsTQRgG8HooWiniNUWb2SCCvS4ziR5cndlaLWLVg1i/8JqeFIlUD0U8ik2aZGdCDvonCH4cRT3osfQgKB5EXQu2RomZmdiKtiOpbLIJcTObm5gXntvAj515dnb7+nrTm/9uIkW1dWe+OrQrqzZ3WqtMs79q7xtSicRAV9hwrmwAyvOAcddgQm2E8nWD8QWD8mvRTHm7t/bLYbRNYnRdYLQgCVJeBEauxCi3YsVBZ1GpTTHGpwHlP+pgmwDKl6JMHpE2HJMYffaDrREYrUqCUoGuQXk2CPTnwK1XLwSGv4LQ5sBMWxQweV4X9TKSL6nXxyY0YaSEDc80oTtm1YBB+aIuOHP57svHk0lVSyiYwI/KsrbU4RjlJ3VRwPjPzFR2LTuVVl4Wx0e18SpGxxtny0RBF96TK32dvPFM+fP81EVtWGJEfecrHunC52aePNUvVLvtRg8aMBUPwxbLHyd5O8w53/fDTBcx0+4br1he3h4dD/HU0KnD0QI/oQvHnG+luWS6Xq7a01bshH65CJro+nWC6Q/SK9bNS3f0txkjt+l12mh2QZzVhXfny27p0H4Zulg4fvpvV2ZGe8tpZe3ehZT+lYnRbOB9DVglBRhfDYb5p5gjiMDxUUngUocWrwgMrwSijbKVwZ8PBn/f8lmcB5RfHXGWB721y5Y1KG04LQicFwSt+8B3ksC57wf3RrXQ1qkVb7goI2ZR9ev8CMgxM9L1j0BvevNPz2/ykvaLxe3RYAAAAABJRU5ErkJggg==",
                    Name = "Дебетовая карта",
                    Money = 22000.00,
                    Number = 12344321
            },
            new Card
            {
                    svgcode = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAAACXBIWXMAAAsTAAALEwEAmpwYAAACgElEQVR4nO1WX0hTYRTfU73L1qyIDCws6WHhQy/1EkG9BkL2EJF3mxiCKZKIgZDkQ4S1LKgoiuzPoMjCbCDr3qmbG9OcazSXYrlsNvdHs83N/bm/+M5sI/DBgVsF+8Hhnvu733d+95zvcM+VSAooIB+Qc/pyGcefkXKCaiONxWSx1xSVckKDTMmLMqWA3BgvSpX8+T9ES+v6Nks5IZo7UYFMqhQikkrHprRw8Vn9zlyLylaNaWXOVs2X5EtYruZL/n3hPfVDqGgxY1fdIBQXhqFoNmdKpzagvNGErWpDmttWY6D1+5tM6xMuq3uFK13ViPJFmOzdje01/bRY7wiA4VCbFdFYEhOeMPHX+mbonmElnqSXYnzjIxdxXwPR7DLWmYexbFLgWMsdyjaWEGGeXKQsGHpHfTje8Z58w8cgKjvH0aqdglyV2u+cDSEp0mOUNRjXL1z/cAKI+XHr2e2UD+DcfSeqNHbyO9/M4MilkVRW/ghO33Sk9564aiNea/pO15PX7esXrljN7LFhEu8cASyE49hRO4CL2inia+850yVdiiSIu6ufJa5vzIf5Hys42GohvqPnc3bN5fZHMO1dpjL/DvrA4KFgR9tH0+tYKRfDcQRDMRxoNiORFOHyhHFD56Zyvx3zZSf8ZGgudUgADrdZiTO6FiCKoO5mZ95vD1BFGC6/nEaXzk3++MxP2L4sIRiK41swmp1wlcZOjdM9OJfmXli8eD0yT03EMtLZ/Hhu8eKU5gO2qAT0WOfx1JhZ39T9iWKwF/2/PiCyXAkX/60hUcrGolKI5H0sMrAhLeP4ZM6EOT4p5fh6yVooUg/sy9WvT1G1sHdN0QIKkGwwfgGAhAscjIGtjgAAAABJRU5ErkJggg==",
                    Name = "Дебетовая карта",
                    Money = 22000.00,
                    Number = 12344321
            }
        };
    }
}

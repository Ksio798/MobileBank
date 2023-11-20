using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Data.ContainerScripts
{
	public enum CardSystem
	{
		MIR,
		VISA,
		MASTERCARD
	}
	public class Card : BankAccount
	{
		public CardSystem System;
	}
}

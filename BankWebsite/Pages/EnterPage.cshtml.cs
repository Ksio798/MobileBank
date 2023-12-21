using BankWedsite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankWebsite.Pages
{
	public class EnterPageModel : PageModel
	{
		bool isEntered;
		public async Task<IActionResult> OnPostAsync(string username, string password)
		{
			await isEner(username, password);
			if (isEntered)
				return RedirectToPage("MainPage");
			else
				return RedirectToPage();
		}

		Task isEner(string username, string password)
		{
			isEntered = Database.Instans.Login == username && Database.Instans.Password == password;
			return Task.CompletedTask;
		}
	}
}

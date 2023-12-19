using BankApp.Data;
using BankApp.Data.ContainerScripts;

namespace BankApp.Pages
{
    
    public class IndexModel
    {
        Database userinfo;
        public List<Card> Cardinfo { get; set; } = new();

        public IndexModel(Database db)
        {
            userinfo = db;
        }

        public void OnGet()
        {
            Cardinfo = userinfo.Cards.ToList();
        }
    }
}
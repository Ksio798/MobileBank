using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
namespace MauiApp1.Components.Pages
{
    public partial class Loginpage : ComponentBase
    {
        private bool showDialog = false;
        private string login = "";
        private string password = "";
        private bool loggedIn = false;

        private void ShowLoginDialog()
        {
            showDialog = true;
        }

        private void Login()
        {
            // Здесь можно добавить обработку входа пользователя
            // на основе введенного логина и пароля

            showDialog = false;
            loggedIn = true;
        }

        private void Cancel()
        {
            showDialog = false;
        }
    }
}
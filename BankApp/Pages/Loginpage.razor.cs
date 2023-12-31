﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
namespace BankApp.Pages
{
    public partial class  Loginpage: ComponentBase
    {
        private bool showDialog = false;
        private string login = "";
        private string password = "";
        private bool loggedIn = false;
        private string message = "";
        private void ShowLoginDialog()
        {
            showDialog = true;
        }

        private void Login()
        {
            message = "";
            showDialog = false;
            loggedIn = true;
            if(login==db.Login && password==db.Password) {
                NavigationManager.NavigateTo("/"); 
            }
            else
            {
                showDialog = true; 
                message = "Неверно введен логин или пароль";
            }
            
        }

        private void Cancel()
        {
            showDialog = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using IDA.App.Models;
using IDA.App.Views;
using Xamarin.Forms;

namespace IDA.App.ViewModels
{
    class TheMainTabbedPageViewModels : ViewModelBase
    {

        private User loginUser = null;
        public User LoginUser
        {
            get { return loginUser; }
            set
            {
                loginUser = value;
                TheMainTabbedPage theMainTabbedPage = (TheMainTabbedPage)Application.Current.MainPage;
                if (loginUser == null) //Logout
                {
                    theMainTabbedPage.AddTab(theMainTabbedPage.logIn);
                    theMainTabbedPage.AddTab(theMainTabbedPage.register);


                }
                else // Login
                {
                    theMainTabbedPage.RemoveTab(theMainTabbedPage.logIn);
                    theMainTabbedPage.RemoveTab(theMainTabbedPage.register);


                }
            }
        }


    }
}

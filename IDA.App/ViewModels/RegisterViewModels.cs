using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using IDA.App.Models;
using IDA.App.Services;
using IDA.App.Views;
using System.Collections.ObjectModel;
using System;

namespace IDA.App.ViewModels
{
    class RegisterViewModel : ViewModelBase
    {
        private string entryUserName;
        public string EntryNickName
        {
            get => this.entryUserName;
            set
            {
                if (value != this.entryUserName)
                {
                    this.entryUserName = value;
                    OnPropertyChanged("EntryUserName");
                }
            }
        }

        private string entryEmail;
        public string EntryEmail
        {
            get => this.entryEmail;
            set
            {
                if (value != this.entryEmail)
                {
                    this.entryEmail = value;
                    OnPropertyChanged("EntryEmail");
                }
            }
        }

        private string entryPass;
        public string EntryPass
        {
            get => this.entryPass;
            set
            {
                if (value != this.entryPass)
                {
                    this.entryPass = value;
                    OnPropertyChanged("EntryPass");
                }
            }
        }

        public RegisterViewModel()
        {

        }

        public ICommand RegisterCommand => new Command(Register);
        private async void Register()
        {
            if ((EntryNickName == "") || (EntryEmail == "") || (EntryPass == ""))
            {
                await App.Current.MainPage.DisplayAlert("IDA", "Please fill all the fields", "Ok");
                return;
            }
            User user = new User();
            user.UserName = EntryNickName;
            user.Email = EntryEmail;
            user.UserPswd = EntryPass;
           IDAAPIProxy triviaWebAPIProxy = IDAAPIProxy.CreateProxy();
            bool isRegister = await triviaWebAPIProxy.RegisterUser(user);
            if (isRegister)
            {
                TheMainTabbedPage theMainTabbedPage = (TheMainTabbedPage)Application.Current.MainPage;
                ((TheMainTabbedPageViewModels)(theMainTabbedPage).BindingContext).LoginUser = user;
                await App.Current.MainPage.DisplayAlert("IDA", "You are logged in now!", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("IDA", "Register failed, please try enter another fields", "Ok");
            }
            EntryEmail = "";
            EntryUserName = "";
            EntryPass = "";
        }
    }
}

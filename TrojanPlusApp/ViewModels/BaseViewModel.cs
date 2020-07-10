﻿using TrojanPlusApp.Models;
using TrojanPlusApp.Services;
using Xamarin.Forms;

namespace TrojanPlusApp.ViewModels
{
    public class BaseViewModel : NotificationModel
    {
        public IDataStore<HostModel> DataStore { get; } = DependencyService.Get<IDataStore<HostModel>>();

        private string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
    }
}

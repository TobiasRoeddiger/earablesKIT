using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AktivpauseRemastered.ViewModels
{
    class ImportExportViewModel
    {
        public ICommand Import { private get; set; }
        public ICommand Export { private get; set; }
        public ICommand Delete{ private get; set; }
        public ImportExportViewModel()
        {
            Import = new Command(() => ImportClicked());
            Export = new Command(() => ExportClicked());
            Delete = new Command(() => DeleteClicked());
        }

        private void ImportClicked()
        {
            Application.Current.MainPage.DisplayAlert("Alert", "Hello", "Cancel", "ok");
        }
        private void ExportClicked()
        {

        }
        private void DeleteClicked()
        {

        }

    }
}

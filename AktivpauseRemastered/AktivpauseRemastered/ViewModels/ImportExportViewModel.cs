using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
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
        public ICommand Import {  get; private set; }
        public ICommand Export {  get; private set; }
        public ICommand Delete {  get; private set; }
        public ImportExportViewModel()
        {
            Import = new Command(() => ImportClicked());
            Export = new Command(() => ExportClicked());
            Delete = new Command(() => DeleteClicked());
        }

        private async void ImportClicked()
        {
            try
            {
                FileData fileData = await CrossFilePicker.Current.PickFile();
                if (fileData == null)
                    return; // user canceled file picking

                string fileName = fileData.FileName;
                //string contents = System.Text.Encoding.UTF8.GetString(fileData.DataArray); hier könnte theoretisch auch direkt der content gezogen werden.
                await Application.Current.MainPage.DisplayAlert("debug display alert", "File name chosen:\n"+fileName, "ok");//debug
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception choosing file: " + ex.ToString()); //debug, sollte exception viewmodel machen.
            }
        }
        private void ExportClicked()
        {

        }
        private void DeleteClicked()
        {

        }

    }
}

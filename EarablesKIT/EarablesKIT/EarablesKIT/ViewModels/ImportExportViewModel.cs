using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using EarablesKIT.Models.DatabaseService;
using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
using Xamarin.Forms;

namespace EarablesKIT.ViewModels
{
    public class ImportExportViewModel
    {
        public Command ImportCommand { get; private set; }
        public Command ExportCommand { get; private set; }
        public Command DeleteCommand { get; private set; }

        public ImportExportViewModel()
        {
            ImportCommand = new Command(() => ImportClicked());
            ExportCommand = new Command(() => ExportClicked());
            DeleteCommand = new Command(() => DeleteClicked());
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
                await Application.Current.MainPage.DisplayAlert("debug display alert", "File name chosen:\n" + fileName,
                    "ok"); //debug
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception choosing file: " +
                                         ex.ToString()); //debug, sollte exception viewmodel machen.
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

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

        public Command ExportCommand { get; set; }
        public Command ImportCommand { get; set; } = new Command(() =>
        {
            Debug.WriteLine("test");
            Application.Current.Quit();
        }, () => true);
        public Command DeleteCommand
        {
            get
            {
                return new Command(
                    () =>
                        {
                            LoadFileAsync();
                        });
            }
            set { return; }
        }

        private async System.Threading.Tasks.Task<StreamReader> LoadFileAsync()
        {
            try
            {
                FileData fileData = await CrossFilePicker.Current.PickFile();
                if (fileData == null)
                    return null; // user canceled file picking

                string fileName = fileData.FileName;
                string contents = System.Text.Encoding.UTF8.GetString(fileData.DataArray);

                System.Console.WriteLine("File name chosen: " + fileName);
                System.Console.WriteLine("File data: " + contents);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception choosing file: " + ex.ToString());
            }

            return null;
        }

        private List<DBEntry> ParseCsv(StreamReader fileStream)
        {
            /* File format:
             Date,Dictionary
             19398450,'PushUps=12,SitUps=34'
             19398354,'PushUps=32,SitUps=4'
             ...
             */

            var entries = new List<DBEntry>();
            string line;

            while ((line = fileStream.ReadLine()) != null)
            {
                var entry = DBEntry.ParseDBEntry(line);
                if (entry != null)
                {
                    entries.Append(entry);
                }
            }

            return entries;
        }
    }
}

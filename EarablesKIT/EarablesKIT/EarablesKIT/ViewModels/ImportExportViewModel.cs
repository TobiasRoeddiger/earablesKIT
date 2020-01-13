using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EarablesKIT.Models.DatabaseService;
using Xamarin.Forms;

namespace EarablesKIT.ViewModels
{
    public class ImportExportViewModel
    {

        public Command ExportCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Command ImportCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Command DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

using AktivpauseRemastered.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AktivpauseRemastered.ViewModels
{
    class SettingsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool needsRestart;
        public string Username;
        public SamplingRate SamplingRate;
        public CultureInfo Language;
        public ICommand ClickSave;


        public IList<SamplingRate> SamplingRateItemSource
        {
            get
            {
                List<SamplingRate> temp = Enum.GetValues(typeof(SamplingRate))
                .Cast<SamplingRate>()
                .ToList();
                Application.Current.MainPage.DisplayAlert("debug display alert", "getting samplingrate enum values:\n" + SamplingRateItemSource[0], "ok");

                return temp;
            }
        }
    public SettingsViewModel()
        {
            ClickSave = new Command(_ => SaveClicked());
            Language = CultureInfo.CurrentCulture; //..
            needsRestart = false;
            SamplingRate = SamplingRate.S_100Hz;//..

        }
        
        void OnPropertyChanged()
        {
            // do stuff.
        }
        private void SaveClicked()
        {
            // do stuff
        }
    }
}

using AktivpauseRemastered.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AktivpauseRemastered.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImportExportPage : ContentPage
    {
        public ImportExportPage()
        {
            InitializeComponent();

            BindingContext = new ImportExportViewModel();
        }
    }
}
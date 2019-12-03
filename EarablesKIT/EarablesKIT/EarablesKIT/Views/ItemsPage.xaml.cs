using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EarablesKIT.ViewModels;
using System.Collections.Generic;
using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using System.Collections.ObjectModel;

namespace EarablesKIT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {

        List<String> foundDevices = new List<String>();
        private ObservableCollection<IDevice> devices;

        public ObservableCollection<IDevice> Devices
        {
            get { return devices; }
            set => devices = value;
        }

        private async void scanBLEdevices()
        {
            var ble = CrossBluetoothLE.Current;
            var adapter = CrossBluetoothLE.Current.Adapter;


            adapter.DeviceDiscovered += (s, a) =>
            {
                if (a.Device.Name != null)
                {
                    Devices.Add(a.Device);
                }
            };

            if(!ble.Adapter.IsScanning)
            {
                await adapter.StartScanningForDevicesAsync();
            }
            
        }

        public ItemsPage()
        {
            InitializeComponent();
            Devices = new ObservableCollection<IDevice>();
            BindingContext = this;
        }

        private void Scan_Clicked(object sender, EventArgs e)
        {
            scanBLEdevices();
        }

        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                await Navigation.PushModalAsync(new DeviceInfo((IDevice)sender));
            }
        }

    }
}
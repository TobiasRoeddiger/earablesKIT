﻿using System;
using System.Collections.Generic;
using static EarablesKIT.Models.Library.Constants;
using System.Text;

namespace EarablesKIT.Models.Library
{
    class EarablesConnection : IEarablesConnection
    {
        public EventHandler<DataEventArgs> IMUDataReceived { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public EventHandler<ButtonEventArgs> ButtonPressed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public EventHandler<DeviceEventArgs> DeviceConnectionStateChanged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool ConnectToDevice(object device)
        {
            throw new NotImplementedException();
        }

        public bool DisconnectFromDevice()
        {
            throw new NotImplementedException();
        }

        public bool IsBluetoothActive()
        {
            throw new NotImplementedException();
        }

        public bool IsConnected()
        {
            throw new NotImplementedException();
        }

        public void OnDeviceConnected(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        public void OnPushButtonPressed(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        public void OnValueUpdatedIMU(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        public bool SetSamplingRate(int rate)
        {
            throw new NotImplementedException();
        }

        public bool StartSampling()
        {
            throw new NotImplementedException();
        }

        public List<object> StartScanning()
        {
            throw new NotImplementedException();
        }

        public bool StopSampling()
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Gpio;
using IoTHelpers.Extensions;

namespace IoTHelpers.Modules
{
    public class ActiveBuzzer : SwitchGpioModule
    {
        private const int BUZZER_PIN = 12;

        public ActiveBuzzer(int buzzerPinNumber, GpioPinValue onValue = GpioPinValue.High)
            : base(buzzerPinNumber, onValue)
        { }   
    }
}


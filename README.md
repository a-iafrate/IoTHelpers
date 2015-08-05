# IoT Helpers

Windows 10 Core IoT Helpers to use with common sensors kit
---------------------------------------------------------
This library allows to easily interact with GPIO, I2C and SPI in Windows 10 IoT Core with boards like Raspberry Pi 2 and MinnowBoard Max.

**Installation**

The **IoTHelpers** library is available on [NuGet](http://www.nuget.org/packages/IoTHelpers/). Just search *IoTHelpers* in the **Package Manager GUI** or run the following command in the **Package Manager Console**:

    Install-Package IoTHelpers
    
Note that the current NuGet packages hasn't been yet updated to RTM version of Windows 10 IoT Core. While we'are working on it, please include the **IoTHelpers** project source directly in your solution.
    
**Usage**

Refer to the [project documentation](https://github.com/Dot-and-Net/IoTHelpers/wiki/Home) to find examples about how to use this library. You can also find some code samples in the **Examples** folder.

**Support**

GPIO features have been tested with modules available in the [SunFounder 37 modules Sensor Kit](http://www.amazon.it/gp/product/B00P66XRNK?psc=1&redirect=true&ref_=oh_aui_detailpage_o00_s00). If you try other modules and encounter some issues, please let us know and we'll fix the problem as soon as possible!

Please keep in mind that Windows 10 IoT Core is currently in preview.

<p align="center">
  <a href="https://binquantum.wordpress.com/2020/05/16/bqbus-protocol/" target="_blank">
    <img src="https://i.ytimg.com/vi/EyJjiy2n3Zc/hqdefault.jpg?sqp=-oaymwEZCPYBEIoBSFXyq4qpAwsIARUAAIhCGAFwAQ==&rs=AOn4CLDv3W4lTz5kJmcDFF81dBJ7OTIupw" alt="Druida IDE">
    <p align="center">Open source easy of use protocol<p>
  </a>
</p>

# BqBusNet

BqBus is an extremely simple and intuitive open source communication protocol, whose objective is to allow data transmission between embedded devices and high-level computer systems, prioritizing performance and ease of implementation.

## Table of contents 

- [Features](#features)
- [Quickstart](#quickstart)
- [Example](#example)

## Features

* Versatile data exchange beetween devices
* Lite implementation
* Easy of use

## Quickstart

* Create a new Visual Studio Windows Forms Project, and import BqBusNet library to him

* You can use Visual Studio designer to add an System.IO.Ports.SerialPort, and a BqBusNet.BqBus instance to your form. Or declare instances on your code manually: 

```C#
private System.IO.Ports.SerialPort serial = new System.IO.Ports.SerialPort();
private BqBusNet.BqBus bqbus = new BqBusNet.BqBus();
```

* On Serial PortName property, you can select serial port

```C#
serial.PortName = "COM7";
```

* Then, on BqBus Serial property, you can select an System.IO.Ports.SerialPort instance to be used by protocol to exchange data with other device. 

```C#
bqbus.Serial = serial;
```

* On Size property, you can defines size of data that you want to share beetween devices.

```C#
bqbus.Size = dataSize;
```

* To initialize communication, use Connect() method, to stop use Disconnect().

```C#
bqbus.Connect();
```

```C#
bqbus.Disconnect();
```

* To write a value on a register use SetReg(ushort address, int value) method.

```C#
bqbus.SetReg(address, value);
```

* To read value from a register use GetReg(ushort address) method.

```C#
bqbus.GetReg(address);
```

## Example

This example, connect/disconnect from arduino, read an checkbox, and send his values to device.

```C#

using System;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort serial = new System.IO.Ports.SerialPort();
        BqBusNet.BqBus arduino = new BqBusNet.BqBus();

        public Form1()
        { 
            InitializeComponent();
            serial.PortName = "COM7";
            arduino.Serial = serial;
            arduino.Size = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bt = (Button)sender;
            if (arduino.IsConnected)
            {
                arduino.Disconnect();
                bt.Text = "Connect";
            }
            else
            {
                arduino.Connect();
                bt.Text = "Disconnect";
            }
        }

        private void cbLed_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            int value = cb.Checked ? 1 : 0;
            arduino.SetReg(0, value);
        }
    }
}

```

Execution:

<p align="center">
  <img src="https://binaryquantum.files.wordpress.com/2020/05/novo-projeto.gif?w=544">
</p>

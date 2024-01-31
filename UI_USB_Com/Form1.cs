using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsbLibrary; //Using usb lib

namespace UI_USB_Com
{
    public partial class UI_usb_hdi : Form
    {
        byte[] readbuff = new byte[2]; //2 byte read (base on USB config) (if 64 byte => 64 + 1 = 65)
        byte[] writebuff = new byte[2]; //2 byte write (base on USB config) (if 64 byte => 64 + 1 = 65)
        int countswa = 0, countswb = 0, countswc = 0;  //counting variable of swa 
        public UI_usb_hdi()
        {
            InitializeComponent(); //initialize the form's content
        }
        //
        //UI USB 
        //
        private void UI_usb_hdi_Load(object sender, EventArgs e)
        {
            usbHidPort.VendorId = 0x04D8; //Vendor ID (Microchip)
            usbHidPort.ProductId = 0x0001; //Product ID (PIC18F4550) 
            usbHidPort.CheckDevicePresent(); //Check USB are available or not 

            textBox_Vid.Text = usbHidPort.VendorId.ToString("x4");//Display VID of the device 
            textBox_Pid.Text = usbHidPort.ProductId.ToString("x4");//Display PID of the device 
            textBox_vendorName.Text = "NguyenNgocThang"; //Display Vendor Name 
            textBox_productName.Text = "PIC18F4550"; //Display Product Name 
        }
        //
        //Form Closinng 
        //
        private void UI_usb_hdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you wanna close this program ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) //Case No
            {
               e.Cancel = true; //Stop closing the program 
            }
        }
        //
        //Exit button 
        //
        private void button_exit_Click(object sender, EventArgs e)
        {
             this.Close(); //Close the program
        }
        //
        //LED1 control
        //
        private void button_onLed1_Click(object sender, EventArgs e)//On button
        {
            if (usbHidPort.SpecifiedDevice != null)
            {
                writebuff[1] = (byte)'1'; //Data that control led 1 (On)
                usbHidPort.SpecifiedDevice.SendData(writebuff); //Send data to the simulator
            }
            else
            {
                MessageBox.Show("Device not found, please try to reconnect to the USB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error info 
            }
        }
        private void button_offLed1_Click(object sender, EventArgs e) //Off button
        {
            if (usbHidPort.SpecifiedDevice != null) 
            {
                writebuff[1] = (byte)'0'; //Data that control led 1 (Off)
                usbHidPort.SpecifiedDevice.SendData(writebuff); //Send data to the simulator
            }
            else
            {
                MessageBox.Show("Device not found, please try to reconnect to the USB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error info
            }
            
        }
        //
        //On data received 
        //
        private void usbHidPort_OnDataRecieved(object sender, DataRecievedEventArgs args)
        {
            if (InvokeRequired) //Check current thread is created from control obj 
            {
                try
                {
                    Invoke(new DataRecievedEventHandler(usbHidPort_OnDataRecieved), new object[] {sender, args}); //create a new one (InvokeRequried == true)
                }
                catch (Exception)
                { }
            }
            else
            {
                readbuff = args.data; //Assign data received from device 
                label_usbStatus.Text = "New Received Data"; 

                switch (readbuff[1]) 
                {
                    case (byte)'O': //Received char 
                        pictureBox_led1.Image = UI_USB_Com.Properties.Resources.densang__1_;//Set immges led1 to on bulb
                        break;
                    case (byte)'F': //Received char 
                        pictureBox_led1.Image = UI_USB_Com.Properties.Resources.dentat__1_;//Set immges led1 to of bulb
                        break;
                    case (byte)'1': //Received char 
                        pictureBox_led2.Image = UI_USB_Com.Properties.Resources.densang__1_;//Set immges led1 to on bulb
                        break;
                    case (byte)'0': //Received char 
                        pictureBox_led2.Image = UI_USB_Com.Properties.Resources.dentat__1_;//Set immges led1 to of bulb
                        break;
                    case (byte)'2': //Received char 
                        pictureBox_led3.Image = UI_USB_Com.Properties.Resources.densang__1_;//Set immges led1 to on bulb
                        break;
                    case (byte)'3': //Received char 
                        pictureBox_led3.Image = UI_USB_Com.Properties.Resources.dentat__1_;//Set immges led1 to of bulb
                        break;
                    case (byte)'S': //Received char 
                        countswa++; //Increase counting value 
                        textBox_couterSwa.Text = countswa.ToString(); //display counting value on swa texbox
                        break;
                    case (byte)'W': //Received char 
                        countswb++; //Increase counting value 
                        textBox_couterSwb.Text = countswb.ToString(); //display counting value on swa texbox
                        break;
                    case (byte)'P': //Received char 
                        countswc++; //Increase counting value 
                        textBox_couterSwc.Text = countswc.ToString(); //display counting value on swa texbox
                        break;
                }               
            }
        }
        //
        //On data send
        //
        private void usbHidPort_OnDataSend(object sender, EventArgs e)
        {
            label_usbStatus.Text = "Data sent"; //Display USB status that which VID and PID not equal to default value
        }
        //
        //On device arrived 
        //
        private void usbHidPort_OnDeviceArrived(object sender, EventArgs e)
        {
            label_usbStatus.Text = "USB Connected";//Display USB status that which VID and PID not equal to default value 
        }
        //
        //On Device removed 
        //
        private void usbHidPort_OnDeviceRemoved(object sender, EventArgs e)
        {
            if (InvokeRequired) //Check current thread is created from control obj
            {
                Invoke(new EventHandler(usbHidPort_OnDeviceRemoved), new object[] { sender, e }); //create a new one (InvokeRequried == true)
            }
            else
            {
                label_usbStatus.Text = "USB Removed"; //Display USB status that which VID and PID not equal to default value is disconnected  
            }
        }
        //
        //On specified device arrived 
        //
        private void usbHidPort_OnSpecifiedDeviceArrived(object sender, EventArgs e)
        {
            label_usbStatus.Text = "Device Detected";//Display device info on label 
            textBox_deviceStatus.Text = "Connected";textBox_deviceStatus.BackColor = Color.Lime;//Display device on textbox status 
            textBox_couterSwa.Text = "0"; //Default value of counter sw 
            pictureBox_led1.Image = UI_USB_Com.Properties.Resources.dentat__1_;//Default value of the image
        }
        //
        //On device specified device removed 
        //
        private void usbHidPort_OnSpecifiedDeviceRemoved(object sender, EventArgs e)
        {
            if (InvokeRequired) //Check current thread is created from control obj 
            {
                Invoke(new EventHandler(usbHidPort_OnSpecifiedDeviceRemoved), new object[] { sender, e }); //create a new one (InvokeRequried == true)
            }
            else
            {
                label_usbStatus.Text = "Device Disconnected"; //Display device info on label
                textBox_deviceStatus.Text = "Disconnected";textBox_deviceStatus.BackColor = Color.Red; //Display device on textbox status 
            }
        }
        //
        //LED2 control 
        //
        private void button_onLed2_Click(object sender, EventArgs e)
        {
            if (usbHidPort.SpecifiedDevice != null)
            {
                writebuff[1] = (byte)'@'; //Data that control led 2 (On)
                usbHidPort.SpecifiedDevice.SendData(writebuff); //Send data to the simulator
            }
            else
            {
                MessageBox.Show("Device not found, please try to reconnect to the USB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error info 
            }
        }
        private void button_offLed2_Click(object sender, EventArgs e)
        {
            if (usbHidPort.SpecifiedDevice != null)
            {
                writebuff[1] = (byte)'&'; //Data that control led 2 (Off)
                usbHidPort.SpecifiedDevice.SendData(writebuff); //Send data to the simulator
            }
            else
            {
                MessageBox.Show("Device not found, please try to reconnect to the USB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error info 
            }
        }
        //
        //LED3 Control 
        //
        private void button_onLed3_Click(object sender, EventArgs e)
        {
            if (usbHidPort.SpecifiedDevice != null)
            {
                writebuff[1] = (byte)'#'; //Data that control led 3 (On)
                usbHidPort.SpecifiedDevice.SendData(writebuff); //Send data to the simulator
            }
            else
            {
                MessageBox.Show("Device not found, please try to reconnect to the USB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error info 
            }
        }

        private void button_offLed3_Click(object sender, EventArgs e)
        {
            if (usbHidPort.SpecifiedDevice != null)
            {
                writebuff[1] = (byte)'$'; //Data that control led 3 (Off)
                usbHidPort.SpecifiedDevice.SendData(writebuff); //Send data to the simulator
            }
            else
            {
                MessageBox.Show("Device not found, please try to reconnect to the USB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error info 
            }
        }
        //
        //Activate USB event
        //
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e); //Call handle event
            usbHidPort.RegisterHandle(Handle); //Resgister handle of control event with usbhidport 
        }
        protected override void WndProc(ref Message m)
        {
            usbHidPort.ParseMessages(ref m);//Analysing the data (device - usb) 
            base.WndProc(ref m); //(Analysing the data (usb - computer)        
        }
        //
        //Reset counter sw button
        //
        private void button_resetCounterSw_Click(object sender, EventArgs e)
        {
            countswa = 0; countswb = 0; countswc = 0; //Set to default value 
            textBox_couterSwa.Text = "0"; textBox_couterSwb.Text = "0"; textBox_couterSwc.Text = "0";//Set to default value 
        }
    }
}

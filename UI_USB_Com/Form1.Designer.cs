namespace UI_USB_Com
{
    partial class UI_usb_hdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbox_deviceInfo = new System.Windows.Forms.GroupBox();
            this.textBox_deviceStatus = new System.Windows.Forms.TextBox();
            this.textBox_Vid = new System.Windows.Forms.TextBox();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.textBox_vendorName = new System.Windows.Forms.TextBox();
            this.textBox_Pid = new System.Windows.Forms.TextBox();
            this.label_forPic = new System.Windows.Forms.Label();
            this.label_forMicrochip = new System.Windows.Forms.Label();
            this.label_productName = new System.Windows.Forms.Label();
            this.label_vendorName = new System.Windows.Forms.Label();
            this.label_productID = new System.Windows.Forms.Label();
            this.label_vendorID = new System.Windows.Forms.Label();
            this.label_deviceStatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbox_LedControl = new System.Windows.Forms.GroupBox();
            this.label_Led1 = new System.Windows.Forms.Label();
            this.pictureBox_led1 = new System.Windows.Forms.PictureBox();
            this.button_offLed1 = new System.Windows.Forms.Button();
            this.button_onLed1 = new System.Windows.Forms.Button();
            this.gbox_swData = new System.Windows.Forms.GroupBox();
            this.label_counterSwa = new System.Windows.Forms.Label();
            this.textBox_couterSwa = new System.Windows.Forms.TextBox();
            this.usbHidPort = new UsbLibrary.UsbHidPort(this.components);
            this.label_title = new System.Windows.Forms.Label();
            this.label_signature = new System.Windows.Forms.Label();
            this.label_usbStatus = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_resetCounterSw = new System.Windows.Forms.Button();
            this.label_counterSwb = new System.Windows.Forms.Label();
            this.textBox_couterSwb = new System.Windows.Forms.TextBox();
            this.textBox_couterSwc = new System.Windows.Forms.TextBox();
            this.label_counterSwc = new System.Windows.Forms.Label();
            this.button_onLed2 = new System.Windows.Forms.Button();
            this.button_offLed2 = new System.Windows.Forms.Button();
            this.button_offLed3 = new System.Windows.Forms.Button();
            this.button_onLed3 = new System.Windows.Forms.Button();
            this.pictureBox_led2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_led3 = new System.Windows.Forms.PictureBox();
            this.label_Led2 = new System.Windows.Forms.Label();
            this.label_Led3 = new System.Windows.Forms.Label();
            this.gbox_deviceInfo.SuspendLayout();
            this.gbox_LedControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_led1)).BeginInit();
            this.gbox_swData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_led2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_led3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_deviceInfo
            // 
            this.gbox_deviceInfo.Controls.Add(this.button_exit);
            this.gbox_deviceInfo.Controls.Add(this.textBox_deviceStatus);
            this.gbox_deviceInfo.Controls.Add(this.textBox_Vid);
            this.gbox_deviceInfo.Controls.Add(this.textBox_productName);
            this.gbox_deviceInfo.Controls.Add(this.textBox_vendorName);
            this.gbox_deviceInfo.Controls.Add(this.textBox_Pid);
            this.gbox_deviceInfo.Controls.Add(this.label_forPic);
            this.gbox_deviceInfo.Controls.Add(this.label_forMicrochip);
            this.gbox_deviceInfo.Controls.Add(this.label_productName);
            this.gbox_deviceInfo.Controls.Add(this.label_vendorName);
            this.gbox_deviceInfo.Controls.Add(this.label_productID);
            this.gbox_deviceInfo.Controls.Add(this.label_vendorID);
            this.gbox_deviceInfo.Controls.Add(this.label_deviceStatus);
            this.gbox_deviceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_deviceInfo.Location = new System.Drawing.Point(12, 37);
            this.gbox_deviceInfo.Name = "gbox_deviceInfo";
            this.gbox_deviceInfo.Size = new System.Drawing.Size(292, 219);
            this.gbox_deviceInfo.TabIndex = 0;
            this.gbox_deviceInfo.TabStop = false;
            this.gbox_deviceInfo.Text = "Device Information";
            // 
            // textBox_deviceStatus
            // 
            this.textBox_deviceStatus.BackColor = System.Drawing.Color.Red;
            this.textBox_deviceStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_deviceStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_deviceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_deviceStatus.Location = new System.Drawing.Point(114, 24);
            this.textBox_deviceStatus.Name = "textBox_deviceStatus";
            this.textBox_deviceStatus.ReadOnly = true;
            this.textBox_deviceStatus.Size = new System.Drawing.Size(150, 22);
            this.textBox_deviceStatus.TabIndex = 15;
            this.textBox_deviceStatus.Text = "Disconnected";
            this.textBox_deviceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Vid
            // 
            this.textBox_Vid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Vid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Vid.Location = new System.Drawing.Point(125, 55);
            this.textBox_Vid.Name = "textBox_Vid";
            this.textBox_Vid.ReadOnly = true;
            this.textBox_Vid.Size = new System.Drawing.Size(50, 21);
            this.textBox_Vid.TabIndex = 14;
            this.textBox_Vid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_productName
            // 
            this.textBox_productName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_productName.Location = new System.Drawing.Point(107, 146);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.ReadOnly = true;
            this.textBox_productName.Size = new System.Drawing.Size(179, 21);
            this.textBox_productName.TabIndex = 13;
            this.textBox_productName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_vendorName
            // 
            this.textBox_vendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_vendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_vendorName.Location = new System.Drawing.Point(107, 119);
            this.textBox_vendorName.Name = "textBox_vendorName";
            this.textBox_vendorName.ReadOnly = true;
            this.textBox_vendorName.Size = new System.Drawing.Size(179, 21);
            this.textBox_vendorName.TabIndex = 12;
            this.textBox_vendorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Pid
            // 
            this.textBox_Pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pid.Location = new System.Drawing.Point(125, 82);
            this.textBox_Pid.Name = "textBox_Pid";
            this.textBox_Pid.ReadOnly = true;
            this.textBox_Pid.Size = new System.Drawing.Size(50, 21);
            this.textBox_Pid.TabIndex = 11;
            this.textBox_Pid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_forPic
            // 
            this.label_forPic.AutoSize = true;
            this.label_forPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forPic.Location = new System.Drawing.Point(181, 84);
            this.label_forPic.Name = "label_forPic";
            this.label_forPic.Size = new System.Drawing.Size(96, 16);
            this.label_forPic.TabIndex = 10;
            this.label_forPic.Text = "for PIC18F4450";
            // 
            // label_forMicrochip
            // 
            this.label_forMicrochip.AutoSize = true;
            this.label_forMicrochip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forMicrochip.Location = new System.Drawing.Point(181, 57);
            this.label_forMicrochip.Name = "label_forMicrochip";
            this.label_forMicrochip.Size = new System.Drawing.Size(83, 16);
            this.label_forMicrochip.TabIndex = 9;
            this.label_forMicrochip.Text = "for Microchip";
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productName.Location = new System.Drawing.Point(8, 148);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(93, 16);
            this.label_productName.TabIndex = 8;
            this.label_productName.Text = "Product Name";
            // 
            // label_vendorName
            // 
            this.label_vendorName.AutoSize = true;
            this.label_vendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vendorName.Location = new System.Drawing.Point(10, 119);
            this.label_vendorName.Name = "label_vendorName";
            this.label_vendorName.Size = new System.Drawing.Size(91, 16);
            this.label_vendorName.TabIndex = 7;
            this.label_vendorName.Text = "Vendor Name";
            // 
            // label_productID
            // 
            this.label_productID.AutoSize = true;
            this.label_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productID.Location = new System.Drawing.Point(10, 84);
            this.label_productID.Name = "label_productID";
            this.label_productID.Size = new System.Drawing.Size(107, 16);
            this.label_productID.TabIndex = 6;
            this.label_productID.Text = "Product ID (HEX)";
            // 
            // label_vendorID
            // 
            this.label_vendorID.AutoSize = true;
            this.label_vendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vendorID.Location = new System.Drawing.Point(12, 57);
            this.label_vendorID.Name = "label_vendorID";
            this.label_vendorID.Size = new System.Drawing.Size(105, 16);
            this.label_vendorID.TabIndex = 5;
            this.label_vendorID.Text = "Vendor ID (HEX)";
            // 
            // label_deviceStatus
            // 
            this.label_deviceStatus.AutoSize = true;
            this.label_deviceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deviceStatus.Location = new System.Drawing.Point(12, 26);
            this.label_deviceStatus.Name = "label_deviceStatus";
            this.label_deviceStatus.Size = new System.Drawing.Size(90, 16);
            this.label_deviceStatus.TabIndex = 4;
            this.label_deviceStatus.Text = "Device Status";
            // 
            // gbox_LedControl
            // 
            this.gbox_LedControl.Controls.Add(this.label_Led3);
            this.gbox_LedControl.Controls.Add(this.label_Led2);
            this.gbox_LedControl.Controls.Add(this.pictureBox_led3);
            this.gbox_LedControl.Controls.Add(this.pictureBox_led2);
            this.gbox_LedControl.Controls.Add(this.button_onLed3);
            this.gbox_LedControl.Controls.Add(this.button_offLed3);
            this.gbox_LedControl.Controls.Add(this.button_offLed2);
            this.gbox_LedControl.Controls.Add(this.button_onLed2);
            this.gbox_LedControl.Controls.Add(this.label_Led1);
            this.gbox_LedControl.Controls.Add(this.pictureBox_led1);
            this.gbox_LedControl.Controls.Add(this.button_offLed1);
            this.gbox_LedControl.Controls.Add(this.button_onLed1);
            this.gbox_LedControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_LedControl.Location = new System.Drawing.Point(310, 37);
            this.gbox_LedControl.Name = "gbox_LedControl";
            this.gbox_LedControl.Size = new System.Drawing.Size(206, 219);
            this.gbox_LedControl.TabIndex = 1;
            this.gbox_LedControl.TabStop = false;
            this.gbox_LedControl.Text = "LED Control";
            // 
            // label_Led1
            // 
            this.label_Led1.AutoSize = true;
            this.label_Led1.Location = new System.Drawing.Point(25, 36);
            this.label_Led1.Name = "label_Led1";
            this.label_Led1.Size = new System.Drawing.Size(40, 16);
            this.label_Led1.TabIndex = 3;
            this.label_Led1.Text = "LED1";
            // 
            // pictureBox_led1
            // 
            this.pictureBox_led1.Image = global::UI_USB_Com.Properties.Resources.dentat__1_;
            this.pictureBox_led1.Location = new System.Drawing.Point(71, 26);
            this.pictureBox_led1.Name = "pictureBox_led1";
            this.pictureBox_led1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox_led1.TabIndex = 5;
            this.pictureBox_led1.TabStop = false;
            // 
            // button_offLed1
            // 
            this.button_offLed1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_offLed1.Location = new System.Drawing.Point(114, 50);
            this.button_offLed1.Name = "button_offLed1";
            this.button_offLed1.Size = new System.Drawing.Size(72, 23);
            this.button_offLed1.TabIndex = 3;
            this.button_offLed1.Text = "OFF";
            this.button_offLed1.UseVisualStyleBackColor = true;
            this.button_offLed1.Click += new System.EventHandler(this.button_offLed1_Click);
            // 
            // button_onLed1
            // 
            this.button_onLed1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_onLed1.Location = new System.Drawing.Point(114, 20);
            this.button_onLed1.Name = "button_onLed1";
            this.button_onLed1.Size = new System.Drawing.Size(72, 23);
            this.button_onLed1.TabIndex = 4;
            this.button_onLed1.Text = "ON";
            this.button_onLed1.UseVisualStyleBackColor = true;
            this.button_onLed1.Click += new System.EventHandler(this.button_onLed1_Click);
            // 
            // gbox_swData
            // 
            this.gbox_swData.Controls.Add(this.button_resetCounterSw);
            this.gbox_swData.Controls.Add(this.label_counterSwc);
            this.gbox_swData.Controls.Add(this.textBox_couterSwc);
            this.gbox_swData.Controls.Add(this.textBox_couterSwb);
            this.gbox_swData.Controls.Add(this.label_counterSwb);
            this.gbox_swData.Controls.Add(this.label_counterSwa);
            this.gbox_swData.Controls.Add(this.textBox_couterSwa);
            this.gbox_swData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_swData.Location = new System.Drawing.Point(522, 37);
            this.gbox_swData.Name = "gbox_swData";
            this.gbox_swData.Size = new System.Drawing.Size(211, 177);
            this.gbox_swData.TabIndex = 2;
            this.gbox_swData.TabStop = false;
            this.gbox_swData.Text = "Switch Data";
            // 
            // label_counterSwa
            // 
            this.label_counterSwa.AutoSize = true;
            this.label_counterSwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_counterSwa.Location = new System.Drawing.Point(16, 26);
            this.label_counterSwa.Name = "label_counterSwa";
            this.label_counterSwa.Size = new System.Drawing.Size(95, 16);
            this.label_counterSwa.TabIndex = 1;
            this.label_counterSwa.Text = "Counter (SWA)";
            // 
            // textBox_couterSwa
            // 
            this.textBox_couterSwa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox_couterSwa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_couterSwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_couterSwa.Location = new System.Drawing.Point(117, 21);
            this.textBox_couterSwa.Name = "textBox_couterSwa";
            this.textBox_couterSwa.ReadOnly = true;
            this.textBox_couterSwa.Size = new System.Drawing.Size(76, 22);
            this.textBox_couterSwa.TabIndex = 0;
            this.textBox_couterSwa.Text = "0";
            this.textBox_couterSwa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usbHidPort
            // 
            this.usbHidPort.ProductId = 0;
            this.usbHidPort.VendorId = 0;
            this.usbHidPort.OnSpecifiedDeviceArrived += new System.EventHandler(this.usbHidPort_OnSpecifiedDeviceArrived);
            this.usbHidPort.OnSpecifiedDeviceRemoved += new System.EventHandler(this.usbHidPort_OnSpecifiedDeviceRemoved);
            this.usbHidPort.OnDeviceArrived += new System.EventHandler(this.usbHidPort_OnDeviceArrived);
            this.usbHidPort.OnDeviceRemoved += new System.EventHandler(this.usbHidPort_OnDeviceRemoved);
            this.usbHidPort.OnDataRecieved += new UsbLibrary.DataRecievedEventHandler(this.usbHidPort_OnDataRecieved);
            this.usbHidPort.OnDataSend += new System.EventHandler(this.usbHidPort_OnDataSend);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Blue;
            this.label_title.Location = new System.Drawing.Point(203, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(333, 25);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "USB (HID) Communication Lab";
            // 
            // label_signature
            // 
            this.label_signature.AutoSize = true;
            this.label_signature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signature.ForeColor = System.Drawing.Color.Blue;
            this.label_signature.Location = new System.Drawing.Point(564, 240);
            this.label_signature.Name = "label_signature";
            this.label_signature.Size = new System.Drawing.Size(143, 16);
            this.label_signature.TabIndex = 4;
            this.label_signature.Text = "Designed by Thang";
            // 
            // label_usbStatus
            // 
            this.label_usbStatus.AutoSize = true;
            this.label_usbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usbStatus.Location = new System.Drawing.Point(576, 223);
            this.label_usbStatus.Name = "label_usbStatus";
            this.label_usbStatus.Size = new System.Drawing.Size(121, 16);
            this.label_usbStatus.TabIndex = 6;
            this.label_usbStatus.Text = "USB Disconnected";
            // 
            // button_exit
            // 
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(91, 173);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(98, 35);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Exit Program";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_resetCounterSw
            // 
            this.button_resetCounterSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetCounterSw.Location = new System.Drawing.Point(19, 129);
            this.button_resetCounterSw.Name = "button_resetCounterSw";
            this.button_resetCounterSw.Size = new System.Drawing.Size(174, 35);
            this.button_resetCounterSw.TabIndex = 8;
            this.button_resetCounterSw.Text = "Reset SW counter";
            this.button_resetCounterSw.UseVisualStyleBackColor = true;
            this.button_resetCounterSw.Click += new System.EventHandler(this.button_resetCounterSw_Click);
            // 
            // label_counterSwb
            // 
            this.label_counterSwb.AutoSize = true;
            this.label_counterSwb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_counterSwb.Location = new System.Drawing.Point(16, 57);
            this.label_counterSwb.Name = "label_counterSwb";
            this.label_counterSwb.Size = new System.Drawing.Size(95, 16);
            this.label_counterSwb.TabIndex = 2;
            this.label_counterSwb.Text = "Counter (SWB)";
            // 
            // textBox_couterSwb
            // 
            this.textBox_couterSwb.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox_couterSwb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_couterSwb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_couterSwb.Location = new System.Drawing.Point(117, 54);
            this.textBox_couterSwb.Name = "textBox_couterSwb";
            this.textBox_couterSwb.ReadOnly = true;
            this.textBox_couterSwb.Size = new System.Drawing.Size(76, 22);
            this.textBox_couterSwb.TabIndex = 3;
            this.textBox_couterSwb.Text = "0";
            this.textBox_couterSwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_couterSwc
            // 
            this.textBox_couterSwc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox_couterSwc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_couterSwc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_couterSwc.Location = new System.Drawing.Point(117, 88);
            this.textBox_couterSwc.Name = "textBox_couterSwc";
            this.textBox_couterSwc.ReadOnly = true;
            this.textBox_couterSwc.Size = new System.Drawing.Size(76, 22);
            this.textBox_couterSwc.TabIndex = 4;
            this.textBox_couterSwc.Text = "0";
            this.textBox_couterSwc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_counterSwc
            // 
            this.label_counterSwc.AutoSize = true;
            this.label_counterSwc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_counterSwc.Location = new System.Drawing.Point(16, 90);
            this.label_counterSwc.Name = "label_counterSwc";
            this.label_counterSwc.Size = new System.Drawing.Size(95, 16);
            this.label_counterSwc.TabIndex = 5;
            this.label_counterSwc.Text = "Counter (SWC)";
            // 
            // button_onLed2
            // 
            this.button_onLed2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_onLed2.Location = new System.Drawing.Point(114, 82);
            this.button_onLed2.Name = "button_onLed2";
            this.button_onLed2.Size = new System.Drawing.Size(72, 23);
            this.button_onLed2.TabIndex = 6;
            this.button_onLed2.Text = "ON";
            this.button_onLed2.UseVisualStyleBackColor = true;
            this.button_onLed2.Click += new System.EventHandler(this.button_onLed2_Click);
            // 
            // button_offLed2
            // 
            this.button_offLed2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_offLed2.Location = new System.Drawing.Point(114, 112);
            this.button_offLed2.Name = "button_offLed2";
            this.button_offLed2.Size = new System.Drawing.Size(72, 23);
            this.button_offLed2.TabIndex = 7;
            this.button_offLed2.Text = "OFF";
            this.button_offLed2.UseVisualStyleBackColor = true;
            this.button_offLed2.Click += new System.EventHandler(this.button_offLed2_Click);
            // 
            // button_offLed3
            // 
            this.button_offLed3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_offLed3.Location = new System.Drawing.Point(114, 179);
            this.button_offLed3.Name = "button_offLed3";
            this.button_offLed3.Size = new System.Drawing.Size(72, 23);
            this.button_offLed3.TabIndex = 8;
            this.button_offLed3.Text = "OFF";
            this.button_offLed3.UseVisualStyleBackColor = true;
            this.button_offLed3.Click += new System.EventHandler(this.button_offLed3_Click);
            // 
            // button_onLed3
            // 
            this.button_onLed3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_onLed3.Location = new System.Drawing.Point(114, 146);
            this.button_onLed3.Name = "button_onLed3";
            this.button_onLed3.Size = new System.Drawing.Size(72, 23);
            this.button_onLed3.TabIndex = 9;
            this.button_onLed3.Text = "ON";
            this.button_onLed3.UseVisualStyleBackColor = true;
            this.button_onLed3.Click += new System.EventHandler(this.button_onLed3_Click);
            // 
            // pictureBox_led2
            // 
            this.pictureBox_led2.Image = global::UI_USB_Com.Properties.Resources.dentat__1_;
            this.pictureBox_led2.Location = new System.Drawing.Point(71, 88);
            this.pictureBox_led2.Name = "pictureBox_led2";
            this.pictureBox_led2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox_led2.TabIndex = 10;
            this.pictureBox_led2.TabStop = false;
            // 
            // pictureBox_led3
            // 
            this.pictureBox_led3.Image = global::UI_USB_Com.Properties.Resources.dentat__1_;
            this.pictureBox_led3.Location = new System.Drawing.Point(71, 151);
            this.pictureBox_led3.Name = "pictureBox_led3";
            this.pictureBox_led3.Size = new System.Drawing.Size(37, 37);
            this.pictureBox_led3.TabIndex = 11;
            this.pictureBox_led3.TabStop = false;
            // 
            // label_Led2
            // 
            this.label_Led2.AutoSize = true;
            this.label_Led2.Location = new System.Drawing.Point(25, 100);
            this.label_Led2.Name = "label_Led2";
            this.label_Led2.Size = new System.Drawing.Size(40, 16);
            this.label_Led2.TabIndex = 12;
            this.label_Led2.Text = "LED2";
            // 
            // label_Led3
            // 
            this.label_Led3.AutoSize = true;
            this.label_Led3.Location = new System.Drawing.Point(25, 161);
            this.label_Led3.Name = "label_Led3";
            this.label_Led3.Size = new System.Drawing.Size(40, 16);
            this.label_Led3.TabIndex = 13;
            this.label_Led3.Text = "LED3";
            // 
            // UI_usb_hdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(741, 261);
            this.Controls.Add(this.label_usbStatus);
            this.Controls.Add(this.label_signature);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.gbox_swData);
            this.Controls.Add(this.gbox_LedControl);
            this.Controls.Add(this.gbox_deviceInfo);
            this.MaximizeBox = false;
            this.Name = "UI_usb_hdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Interface - USB-HID Communication";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_usb_hdi_FormClosing);
            this.Load += new System.EventHandler(this.UI_usb_hdi_Load);
            this.gbox_deviceInfo.ResumeLayout(false);
            this.gbox_deviceInfo.PerformLayout();
            this.gbox_LedControl.ResumeLayout(false);
            this.gbox_LedControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_led1)).EndInit();
            this.gbox_swData.ResumeLayout(false);
            this.gbox_swData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_led2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_led3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_deviceInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbox_LedControl;
        private System.Windows.Forms.GroupBox gbox_swData;
        private System.Windows.Forms.PictureBox pictureBox_led1;
        private System.Windows.Forms.Button button_offLed1;
        private System.Windows.Forms.Button button_onLed1;
        private System.Windows.Forms.Label label_counterSwa;
        private System.Windows.Forms.TextBox textBox_couterSwa;
        private System.Windows.Forms.Label label_Led1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_signature;
        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.Label label_vendorName;
        private System.Windows.Forms.Label label_productID;
        private System.Windows.Forms.Label label_vendorID;
        private System.Windows.Forms.Label label_deviceStatus;
        private System.Windows.Forms.Label label_forPic;
        private System.Windows.Forms.Label label_forMicrochip;
        private System.Windows.Forms.TextBox textBox_deviceStatus;
        private System.Windows.Forms.TextBox textBox_Vid;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.TextBox textBox_vendorName;
        private System.Windows.Forms.TextBox textBox_Pid;
        private System.Windows.Forms.Label label_usbStatus;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_resetCounterSw;
        public UsbLibrary.UsbHidPort usbHidPort;
        private System.Windows.Forms.Button button_onLed2;
        private System.Windows.Forms.Label label_counterSwc;
        private System.Windows.Forms.TextBox textBox_couterSwc;
        private System.Windows.Forms.TextBox textBox_couterSwb;
        private System.Windows.Forms.Label label_counterSwb;
        private System.Windows.Forms.Label label_Led3;
        private System.Windows.Forms.Label label_Led2;
        private System.Windows.Forms.PictureBox pictureBox_led3;
        private System.Windows.Forms.PictureBox pictureBox_led2;
        private System.Windows.Forms.Button button_onLed3;
        private System.Windows.Forms.Button button_offLed3;
        private System.Windows.Forms.Button button_offLed2;
    }
}


namespace BluetoothLEnergy
{
    partial class fmMain
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
            this.btDiscover = new System.Windows.Forms.Button();
            this.lvDevices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvServices = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCharacteristics = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEvents = new System.Windows.Forms.ListView();
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btGetServices = new System.Windows.Forms.Button();
            this.btGetCharacteristics = new System.Windows.Forms.Button();
            this.btGetCharValue = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btValuePanel = new System.Windows.Forms.RichTextBox();
            this.cbSerialName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBaund = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbHandshake = new System.Windows.Forms.ComboBox();
            this.SerialScreen = new System.Windows.Forms.RichTextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btCloseSerial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDiscover
            // 
            this.btDiscover.Location = new System.Drawing.Point(16, 15);
            this.btDiscover.Margin = new System.Windows.Forms.Padding(4);
            this.btDiscover.Name = "btDiscover";
            this.btDiscover.Size = new System.Drawing.Size(100, 28);
            this.btDiscover.TabIndex = 0;
            this.btDiscover.Text = "Tara";
            this.btDiscover.UseVisualStyleBackColor = true;
            this.btDiscover.Click += new System.EventHandler(this.btDiscover_Click);
            // 
            // lvDevices
            // 
            this.lvDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDevices.FullRowSelect = true;
            this.lvDevices.GridLines = true;
            this.lvDevices.HideSelection = false;
            this.lvDevices.Location = new System.Drawing.Point(16, 50);
            this.lvDevices.Margin = new System.Windows.Forms.Padding(4);
            this.lvDevices.MultiSelect = false;
            this.lvDevices.Name = "lvDevices";
            this.lvDevices.Size = new System.Drawing.Size(416, 75);
            this.lvDevices.TabIndex = 1;
            this.lvDevices.UseCompatibleStateImageBehavior = false;
            this.lvDevices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adres";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ýsim";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cihaz Türü";
            this.columnHeader3.Width = 150;
            // 
            // lvServices
            // 
            this.lvServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvServices.FullRowSelect = true;
            this.lvServices.GridLines = true;
            this.lvServices.HideSelection = false;
            this.lvServices.Location = new System.Drawing.Point(16, 172);
            this.lvServices.Margin = new System.Windows.Forms.Padding(4);
            this.lvServices.MultiSelect = false;
            this.lvServices.Name = "lvServices";
            this.lvServices.Size = new System.Drawing.Size(416, 102);
            this.lvServices.TabIndex = 4;
            this.lvServices.UseCompatibleStateImageBehavior = false;
            this.lvServices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "UUID";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "UUID Kýsamý";
            this.columnHeader5.Width = 100;
            // 
            // lvCharacteristics
            // 
            this.lvCharacteristics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvCharacteristics.FullRowSelect = true;
            this.lvCharacteristics.GridLines = true;
            this.lvCharacteristics.HideSelection = false;
            this.lvCharacteristics.Location = new System.Drawing.Point(16, 318);
            this.lvCharacteristics.Margin = new System.Windows.Forms.Padding(4);
            this.lvCharacteristics.MultiSelect = false;
            this.lvCharacteristics.Name = "lvCharacteristics";
            this.lvCharacteristics.Size = new System.Drawing.Size(416, 89);
            this.lvCharacteristics.TabIndex = 5;
            this.lvCharacteristics.UseCompatibleStateImageBehavior = false;
            this.lvCharacteristics.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "UUID";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "UUID Kýsamý";
            this.columnHeader8.Width = 80;
            // 
            // lvEvents
            // 
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31});
            this.lvEvents.FullRowSelect = true;
            this.lvEvents.GridLines = true;
            this.lvEvents.HideSelection = false;
            this.lvEvents.Location = new System.Drawing.Point(16, 439);
            this.lvEvents.Margin = new System.Windows.Forms.Padding(4);
            this.lvEvents.MultiSelect = false;
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(416, 130);
            this.lvEvents.TabIndex = 8;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Adres";
            this.columnHeader28.Width = 100;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Olay";
            this.columnHeader29.Width = 150;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Param";
            this.columnHeader30.Width = 150;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Deðer";
            this.columnHeader31.Width = 150;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(124, 15);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(100, 28);
            this.btConnect.TabIndex = 9;
            this.btConnect.Text = "Baðlan";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(232, 15);
            this.btDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(120, 28);
            this.btDisconnect.TabIndex = 10;
            this.btDisconnect.Text = "Baðlantýyý Kes";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btGetServices
            // 
            this.btGetServices.Location = new System.Drawing.Point(16, 136);
            this.btGetServices.Margin = new System.Windows.Forms.Padding(4);
            this.btGetServices.Name = "btGetServices";
            this.btGetServices.Size = new System.Drawing.Size(100, 28);
            this.btGetServices.TabIndex = 13;
            this.btGetServices.Text = "Hizmet Al";
            this.btGetServices.UseVisualStyleBackColor = true;
            this.btGetServices.Click += new System.EventHandler(this.btGetServices_Click);
            // 
            // btGetCharacteristics
            // 
            this.btGetCharacteristics.Location = new System.Drawing.Point(16, 282);
            this.btGetCharacteristics.Margin = new System.Windows.Forms.Padding(4);
            this.btGetCharacteristics.Name = "btGetCharacteristics";
            this.btGetCharacteristics.Size = new System.Drawing.Size(157, 28);
            this.btGetCharacteristics.TabIndex = 15;
            this.btGetCharacteristics.Text = "Karakteristik Al";
            this.btGetCharacteristics.UseVisualStyleBackColor = true;
            this.btGetCharacteristics.Click += new System.EventHandler(this.btGetCharacteristics_Click);
            // 
            // btGetCharValue
            // 
            this.btGetCharValue.Location = new System.Drawing.Point(634, 18);
            this.btGetCharValue.Margin = new System.Windows.Forms.Padding(4);
            this.btGetCharValue.Name = "btGetCharValue";
            this.btGetCharValue.Size = new System.Drawing.Size(100, 28);
            this.btGetCharValue.TabIndex = 16;
            this.btGetCharValue.Text = "Oku";
            this.btGetCharValue.UseVisualStyleBackColor = true;
            this.btGetCharValue.Click += new System.EventHandler(this.btGetCharValue_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(1063, 593);
            this.btClear.Margin = new System.Windows.Forms.Padding(4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 28);
            this.btClear.TabIndex = 26;
            this.btClear.Text = "Temizle";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cihazlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hizmetler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Karakteristik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Durum";
            // 
            // btValuePanel
            // 
            this.btValuePanel.Location = new System.Drawing.Point(530, 50);
            this.btValuePanel.Name = "btValuePanel";
            this.btValuePanel.ReadOnly = true;
            this.btValuePanel.Size = new System.Drawing.Size(322, 224);
            this.btValuePanel.TabIndex = 31;
            this.btValuePanel.Text = "";
            // 
            // cbSerialName
            // 
            this.cbSerialName.FormattingEnabled = true;
            this.cbSerialName.Location = new System.Drawing.Point(1042, 344);
            this.cbSerialName.Name = "cbSerialName";
            this.cbSerialName.Size = new System.Drawing.Size(121, 24);
            this.cbSerialName.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Seri Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(946, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Ýsim:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(946, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Band Hýzý:";
            // 
            // cbBaund
            // 
            this.cbBaund.FormattingEnabled = true;
            this.cbBaund.Location = new System.Drawing.Point(1042, 387);
            this.cbBaund.Name = "cbBaund";
            this.cbBaund.Size = new System.Drawing.Size(121, 24);
            this.cbBaund.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(946, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Veri Boyutu:";
            // 
            // cbData
            // 
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(1042, 428);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(121, 24);
            this.cbData.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(946, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Eþik Biti:";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(1042, 474);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 24);
            this.cbParity.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(946, 528);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Handshake:";
            // 
            // cbHandshake
            // 
            this.cbHandshake.FormattingEnabled = true;
            this.cbHandshake.Location = new System.Drawing.Point(1042, 521);
            this.cbHandshake.Name = "cbHandshake";
            this.cbHandshake.Size = new System.Drawing.Size(121, 24);
            this.cbHandshake.TabIndex = 41;
            // 
            // SerialScreen
            // 
            this.SerialScreen.Location = new System.Drawing.Point(530, 344);
            this.SerialScreen.Name = "SerialScreen";
            this.SerialScreen.ReadOnly = true;
            this.SerialScreen.Size = new System.Drawing.Size(322, 204);
            this.SerialScreen.TabIndex = 43;
            this.SerialScreen.Text = "";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(696, 554);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 44;
            this.btOpen.Text = "Baþlat";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btCloseSerial
            // 
            this.btCloseSerial.Location = new System.Drawing.Point(777, 554);
            this.btCloseSerial.Name = "btCloseSerial";
            this.btCloseSerial.Size = new System.Drawing.Size(75, 23);
            this.btCloseSerial.TabIndex = 45;
            this.btCloseSerial.Text = "Kapat";
            this.btCloseSerial.UseVisualStyleBackColor = true;
            this.btCloseSerial.Click += new System.EventHandler(this.btCloseSerial_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 647);
            this.Controls.Add(this.btCloseSerial);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.SerialScreen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbHandshake);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBaund);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSerialName);
            this.Controls.Add(this.btValuePanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btGetCharValue);
            this.Controls.Add(this.btGetCharacteristics);
            this.Controls.Add(this.btGetServices);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.lvEvents);
            this.Controls.Add(this.lvCharacteristics);
            this.Controls.Add(this.lvServices);
            this.Controls.Add(this.lvDevices);
            this.Controls.Add(this.btDiscover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BluetoothLEnergy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmMain_FormClosed);
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDiscover;
        private System.Windows.Forms.ListView lvDevices;
        private System.Windows.Forms.ListView lvServices;
        private System.Windows.Forms.ListView lvCharacteristics;
        private System.Windows.Forms.ListView lvEvents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btGetServices;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btGetCharacteristics;
        private System.Windows.Forms.Button btGetCharValue;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox btValuePanel;
        private System.Windows.Forms.ComboBox cbSerialName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBaund;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbHandshake;
        private System.Windows.Forms.RichTextBox SerialScreen;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btCloseSerial;
    }
}


namespace PulsesGenerator
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.gpbPort = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gpbConfiguration = new System.Windows.Forms.GroupBox();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBetweenTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPulseTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPulses = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbxTrain = new System.Windows.Forms.PictureBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.gpbSend = new System.Windows.Forms.GroupBox();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.gpbPort.SuspendLayout();
            this.gpbConfiguration.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrain)).BeginInit();
            this.gpbSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortArduino_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "&About...";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(6, 19);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(105, 21);
            this.cmbPort.TabIndex = 1;
            this.cmbPort.Text = "Select port";
            this.cmbPort.SelectedIndexChanged += new System.EventHandler(this.cmbPort_SelectedIndexChanged);
            this.cmbPort.Click += new System.EventHandler(this.cmbPort_Click);
            // 
            // gpbPort
            // 
            this.gpbPort.Controls.Add(this.btnConnect);
            this.gpbPort.Controls.Add(this.cmbPort);
            this.gpbPort.Location = new System.Drawing.Point(8, 33);
            this.gpbPort.Name = "gpbPort";
            this.gpbPort.Size = new System.Drawing.Size(202, 56);
            this.gpbPort.TabIndex = 2;
            this.gpbPort.TabStop = false;
            this.gpbPort.Text = "Port selection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(117, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gpbConfiguration
            // 
            this.gpbConfiguration.Controls.Add(this.btnConfigure);
            this.gpbConfiguration.Controls.Add(this.label3);
            this.gpbConfiguration.Controls.Add(this.txtBetweenTime);
            this.gpbConfiguration.Controls.Add(this.label2);
            this.gpbConfiguration.Controls.Add(this.txtPulseTime);
            this.gpbConfiguration.Controls.Add(this.label1);
            this.gpbConfiguration.Controls.Add(this.txtPulses);
            this.gpbConfiguration.Location = new System.Drawing.Point(8, 95);
            this.gpbConfiguration.Name = "gpbConfiguration";
            this.gpbConfiguration.Size = new System.Drawing.Size(202, 133);
            this.gpbConfiguration.TabIndex = 3;
            this.gpbConfiguration.TabStop = false;
            this.gpbConfiguration.Text = "Train configuration";
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(6, 104);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(186, 23);
            this.btnConfigure.TabIndex = 5;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time between pulses [ms]";
            // 
            // txtBetweenTime
            // 
            this.txtBetweenTime.Location = new System.Drawing.Point(141, 75);
            this.txtBetweenTime.Name = "txtBetweenTime";
            this.txtBetweenTime.Size = new System.Drawing.Size(51, 20);
            this.txtBetweenTime.TabIndex = 4;
            this.txtBetweenTime.Text = "90";
            this.txtBetweenTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBetweenTime.TextChanged += new System.EventHandler(this.txtConfiguration_Changed);
            this.txtBetweenTime.Leave += new System.EventHandler(this.txtBetweenTime_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pulse time [ms]";
            // 
            // txtPulseTime
            // 
            this.txtPulseTime.Location = new System.Drawing.Point(141, 49);
            this.txtPulseTime.Name = "txtPulseTime";
            this.txtPulseTime.Size = new System.Drawing.Size(51, 20);
            this.txtPulseTime.TabIndex = 2;
            this.txtPulseTime.Text = "10";
            this.txtPulseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPulseTime.TextChanged += new System.EventHandler(this.txtConfiguration_Changed);
            this.txtPulseTime.Leave += new System.EventHandler(this.txtPulseTime_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of pulses";
            // 
            // txtPulses
            // 
            this.txtPulses.Location = new System.Drawing.Point(141, 23);
            this.txtPulses.Name = "txtPulses";
            this.txtPulses.Size = new System.Drawing.Size(51, 20);
            this.txtPulses.TabIndex = 0;
            this.txtPulses.Text = "10";
            this.txtPulses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPulses.TextChanged += new System.EventHandler(this.txtConfiguration_Changed);
            this.txtPulses.Leave += new System.EventHandler(this.txtPulses_Leave);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(12, 145);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(261, 44);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsbStatus
            // 
            this.tsbStatus.Name = "tsbStatus";
            this.tsbStatus.Size = new System.Drawing.Size(59, 17);
            this.tsbStatus.Text = "Select port";
            // 
            // pbxTrain
            // 
            this.pbxTrain.Location = new System.Drawing.Point(12, 41);
            this.pbxTrain.Name = "pbxTrain";
            this.pbxTrain.Size = new System.Drawing.Size(261, 74);
            this.pbxTrain.TabIndex = 5;
            this.pbxTrain.TabStop = false;
            // 
            // lblSend
            // 
            this.lblSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSend.ForeColor = System.Drawing.Color.Purple;
            this.lblSend.Location = new System.Drawing.Point(6, 15);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(267, 23);
            this.lblSend.TabIndex = 6;
            this.lblSend.Text = "10 pulses at 10 Hz";
            this.lblSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbSend
            // 
            this.gpbSend.Controls.Add(this.lblTotalTime);
            this.gpbSend.Controls.Add(this.lblSend);
            this.gpbSend.Controls.Add(this.btnSend);
            this.gpbSend.Controls.Add(this.pbxTrain);
            this.gpbSend.Location = new System.Drawing.Point(216, 33);
            this.gpbSend.Name = "gpbSend";
            this.gpbSend.Size = new System.Drawing.Size(279, 195);
            this.gpbSend.TabIndex = 7;
            this.gpbSend.TabStop = false;
            this.gpbSend.Text = "Send train";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalTime.Location = new System.Drawing.Point(10, 119);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(263, 23);
            this.lblTotalTime.TabIndex = 7;
            this.lblTotalTime.Text = "Total time: 1000 ms";
            this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt files (.txt)|*.txt|All files|*.*";
            this.openFileDialog.Title = "Open a txt file for train configuration";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt files (.txt)|*.txt|All files|*.*";
            this.saveFileDialog.Title = "Save a txt file for train configuration";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 259);
            this.Controls.Add(this.gpbSend);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gpbConfiguration);
            this.Controls.Add(this.gpbPort);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Pulse generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbPort.ResumeLayout(false);
            this.gpbConfiguration.ResumeLayout(false);
            this.gpbConfiguration.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrain)).EndInit();
            this.gpbSend.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.GroupBox gpbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gpbConfiguration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBetweenTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPulseTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPulses;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsbStatus;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.PictureBox pbxTrain;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.GroupBox gpbSend;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}


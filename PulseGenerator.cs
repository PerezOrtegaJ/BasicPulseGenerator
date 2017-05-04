using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace PulsesGenerator
{
    public partial class frmMain : Form
    {
        Image trainImage;
        Graphics trainDrawing;
        Pen trainPen;

        public frmMain()
        {
            InitializeComponent();
            btnConnect.Enabled = false;
            gpbConfiguration.Enabled = false;
            gpbSend.Enabled = false;
            trainImage = new Bitmap(pbxTrain.Width, pbxTrain.Height);
            trainPen = new Pen(Color.Purple);
            trainDrawing = Graphics.FromImage(trainImage);
            plotTrain();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortArduino.PortName = cmbPort.SelectedItem.ToString();
            btnConnect.Enabled = true;
            tsbStatus.Text = "Connect port";
        }

        private void cmbPort_Click(object sender, EventArgs e)
        {
            string[] NombresPuertos = SerialPort.GetPortNames();
            cmbPort.Items.Clear();
            foreach (string Nombre in NombresPuertos)
                cmbPort.Items.Add(Nombre);
            cmbPort.Text = "Select port";
            btnConnect.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                try
                {
                    serialPortArduino.Open();
                    btnConnect.Text = "Disconnect";
                    cmbPort.Enabled = false;
                    gpbSend.Enabled = true;
                    gpbConfiguration.Enabled = true;
                    tsbStatus.Text = "Configurate train and send it";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (serialPortArduino.IsOpen)
                {
                    serialPortArduino.Close();
                    btnConnect.Text = "Connect";
                    cmbPort.Enabled = true;
                    gpbSend.Enabled = false;
                    gpbConfiguration.Enabled = false;
                    tsbStatus.Text = "Select port";
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPortArduino.IsOpen)
            {
                serialPortArduino.Write("send\n");
            }
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            tsbStatus.Text = "Configuring...";
            if (serialPortArduino.IsOpen)
            {
                string message = "PP" + txtPulses.Text + "\n";
                serialPortArduino.Write(message);
                Thread.Sleep(10);
                message = "PT" + txtPulseTime.Text + "\n";
                serialPortArduino.Write(message);
                Thread.Sleep(10);
                message = "BT" + txtBetweenTime.Text + "\n";
                serialPortArduino.Write(message);
                Thread.Sleep(10);
                serialPortArduino.Write("check\n");    
            }
            else
                tsbStatus.Text = "Connect port";
        }

      

        private void serialPortArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            string Data = serialPortArduino.ReadExisting();
            string[] dataSplit=new string[4];
            if (Data.Length > 5)
            {
                if (Data.Substring(0, 5) == "check")
                {
                    dataSplit = Data.Split(',');
                    if (dataSplit[1] == txtPulses.Text &&
                       dataSplit[2] == txtPulseTime.Text &&
                       dataSplit[3] == txtBetweenTime.Text)
                    {
                        tsbStatus.Text = "Successful configuration!";
                        btnConfigure.BackColor = Color.Green;
                    }
                }
                else if (Data == "Done!\r\n")
                    tsbStatus.Text = "Done!";
            }
            else
                tsbStatus.Text = Data;
        }

        private void txtPulses_Leave(object sender, EventArgs e)
        {
            double n;
            if (!double.TryParse(txtPulses.Text, out n))
                txtPulses.Text = "1";
            else
            {
                n=Math.Round(n);
                if(n<1)
                    txtPulses.Text = "1";
                else if(n>100)
                    txtPulses.Text = "100";
                else
                    txtPulses.Text = n.ToString();
            }
            plotTrain();
            ComputeFrequency();
        }

        private void txtPulseTime_Leave(object sender, EventArgs e)
        {
            double n;
            if (!double.TryParse(txtPulseTime.Text, out n))
                txtPulseTime.Text = "1";
            else
            {
                n = Math.Round(n);
                if (n < 1)
                    txtPulseTime.Text = "1";
                else if (n > 10000)
                    txtPulseTime.Text = "10000";
                else
                    txtPulseTime.Text = n.ToString();
            }
            plotTrain();
            ComputeFrequency();
        }

        private void txtBetweenTime_Leave(object sender, EventArgs e)
        {
            double n;
            if (!double.TryParse(txtBetweenTime.Text, out n))
                txtBetweenTime.Text = "1";
            else
            {
                n = Math.Round(n);
                if (n < 1)
                    txtBetweenTime.Text = "1";
                else if (n > 10000)
                    txtBetweenTime.Text = "10000";
                else
                    txtBetweenTime.Text = n.ToString();
            }
            plotTrain();
            ComputeFrequency();
        }

        private void txtConfiguration_Changed(object sender, EventArgs e)
        {
            btnConfigure.BackColor = Color.Red;
        }

        private void plotTrain()
        {
            int nPulses=Convert.ToInt16(txtPulses.Text);
            int tPulse=Convert.ToInt16(txtPulseTime.Text);
            int tBetween=Convert.ToInt16(txtBetweenTime.Text);
            int nPoints=nPulses*4;
            Point[] P= new Point[nPoints];
            int top=(int)(pbxTrain.Height*0.1);
            int bottom=(int)(pbxTrain.Height*0.9);
            int left=(int)(pbxTrain.Width*0.05);
            int right = (int)(pbxTrain.Width * 0.95);
            int pulseWidth = (int)((double)tPulse / (double)(tPulse + tBetween) / (double)nPulses * 0.9 * (double)pbxTrain.Width);
            int betweenWidth = (int)((double)tBetween / (double)(tPulse + tBetween) / (double)nPulses * 0.9 * (double)pbxTrain.Width);

            for (int i=0,j=0;i<nPulses;i++,j+=4)
            {
                P[0 + j] = new Point(left + i * (pulseWidth + betweenWidth), bottom);
                P[1 + j] = new Point(left + i * (pulseWidth + betweenWidth), top);
                P[2 + j] = new Point(left + pulseWidth + i * (pulseWidth + betweenWidth), top);
                P[3 + j] = new Point(left + pulseWidth + i * (pulseWidth + betweenWidth), bottom);
            }
            trainDrawing.Clear(Color.White);
            trainDrawing.DrawLines(trainPen, P);
            pbxTrain.Image = trainImage;
        }

        private void ComputeFrequency()
        {
            int nPulses = Convert.ToInt16(txtPulses.Text);
            int tPulse = Convert.ToInt16(txtPulseTime.Text);
            int tBetween = Convert.ToInt16(txtBetweenTime.Text);
            double frequency = 1.0 / (double)(tPulse + tBetween) * 1000.0;
            lblSend.Text = txtPulses.Text + " pulses at " + frequency.ToString("F2") + " Hz";
            lblTotalTime.Text = "Total time: " + ((tPulse + tBetween) * nPulses).ToString() + " ms";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPortArduino.IsOpen)
                serialPortArduino.Close();
            Application.Exit();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader file = new StreamReader(openFileDialog.FileName);
            file.ReadLine();
            file.ReadLine();
            file.ReadLine();
            string allData=file.ReadLine();
            string[] data = allData.Split(',');
            txtPulses.Text = data[0];
            txtPulses_Leave(sender, e);
            txtPulseTime.Text = data[1];
            txtPulseTime_Leave(sender, e);
            txtBetweenTime.Text = data[2];
            txtBetweenTime_Leave(sender, e);
            file.Close();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter file = new StreamWriter(saveFileDialog.FileName);
            file.WriteLine("Pulse generator by Jesús Pérez 2017");
            file.WriteLine("Created: " + DateTime.Now.ToShortDateString());
            file.WriteLine("Pulses, pulse time, time between pulses");
            file.Write(txtPulses.Text + "," + txtPulseTime.Text + "," + txtBetweenTime.Text);
            file.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was developed by\nJesús Esteban Pérez Ortega\nJanuary 2017","Pulse generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

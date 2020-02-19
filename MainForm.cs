using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendVoiceCommands
{
    public partial class MainForm : Form
    {
        class ProcessItem
        {
            public string title;
            public System.Diagnostics.Process process;

            override public string ToString()
            {
                return title;
            }
        };

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private NAudio.Wave.WaveInEvent waveIn;

        public MainForm()
        {
            InitializeComponent();

            Text = "Send Voice Command";
            _closeButton.Text = "Close";
            _refreshButton.Text = "Refresh";
            _testButton.Text = "Test";

            refreshProcessList();

            waveIn = new NAudio.Wave.WaveInEvent();
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.StartRecording();
        }

        private void closeButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshProcessList()
        {
            _processesBox.Items.Clear();
            _testButton.Enabled = false;
            _processesBox.Text = "";

            System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcesses();
            Array.Sort(processList, (x, y) => String.Compare(x.ProcessName, y.ProcessName));

            foreach (System.Diagnostics.Process process in processList)
            {
                if (process.MainWindowHandle == null) continue;
                if (process.MainWindowHandle.ToInt32() == 0x00000000) continue;

                ProcessItem item = new ProcessItem();
                item.process = process;
                item.title = process.ProcessName + " [" + process.Id + "]";

                _processesBox.Items.Add(item);
            }
        }

        private void _testButton_Click(object sender, EventArgs e)
        {
            trigger();
        }

        private void _processesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_processesBox.SelectedItem != null)
            {
                _testButton.Enabled = true;
            }
            else
            {
                _testButton.Enabled = false;
            }
        }

        private void _refreshButton_Click(object sender, EventArgs e)
        {
            refreshProcessList();
        }

        private void OnDataAvailable(object sender, NAudio.Wave.WaveInEventArgs args)
        {
            float max = 0;
            // interpret as 16 bit audio
            for (int index = 0; index < args.BytesRecorded; index += 2)
            {
                short sample = (short)((args.Buffer[index + 1] << 8) |
                                        args.Buffer[index + 0]);
                // to floating point
                var sample32 = sample / 32768f;
                // absolute value 
                if (sample32 < 0) sample32 = -sample32;
                // is this the max value?
                if (sample32 > max) max = sample32;
            }

            int percentValue = (int)(100 * max);
            MethodInvoker mi = new MethodInvoker(() => calculateMaximum(percentValue));
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(mi);
            }
            else
            {
                mi.Invoke();
            }

        }

        private void calculateMaximum(int percentValue)
        {
            progressBar1.Value = percentValue;
            if (percentValue >= trackBar1.Value)
            {
                trigger();
            }
        }

        private void trigger()
        {
            ProcessItem item = _processesBox.SelectedItem as ProcessItem;
            if (item == null)
            {
                return;
            }

            SetForegroundWindow(item.process.MainWindowHandle);
            SendKeys.SendWait(" ");
            SendKeys.Flush();
        }
    }
}

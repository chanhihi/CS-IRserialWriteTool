using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;
using System.IO.Ports;

namespace IR_Serial_Write_Tool_
{
    public partial class IR_serial_write_tool : Form
    {
        public SerialPort Serial = new SerialPort();
        ProcessStartInfo cmd = new ProcessStartInfo();
        public static OpenFileDialog OpenDlg = new OpenFileDialog();
        public static string lastPath;
        public static string fContent;
        public static int portNumber;
        public IR_serial_write_tool()
        {
            InitializeComponent();
            ComPortDisplay(null,null);
        }
        private void ComPortDisplay(object sender, EventArgs e)
        {

            if (!Serial.IsOpen)
            {
                cbComPort.Items.Clear();
                var ports = System.IO.Ports.SerialPort.GetPortNames();

                foreach (string port in ports)
                {
                    cbComPort.Items.Add(port);
                }

                if (ports.Length > 0)
                {

                    try
                    {
                        cbComPort.SelectedIndex = 0;

                        int idx = cbComPort.FindStringExact(Properties.Settings.Default.ComPort);
                        if (idx >= 0)
                            cbComPort.SelectedIndex = idx;
                    }
                    catch { }
                }
            }
        }
        Tuple<string, string, string, string, string, string> SerialNumberDecToHex(string str)
        {
            string strHex1, strHex2, strHex3, strHex4, strHex5, strHex6;
            strHex1 = (str[0] - 18).ToString();
            strHex2 = (str[1] - 18).ToString();
            strHex3 = (str[2] - 18).ToString();
            strHex4 = (str[3] - 18).ToString();
            strHex5 = (str[4] - 18).ToString();
            strHex6 = (str[5] - 18).ToString();

            return new Tuple<string, string, string, string, string, string>(strHex1, strHex2, strHex3, strHex4, strHex5, strHex6);
        }
        private void serialWrite_Click(object sender, EventArgs e)
        {
            try
            {
                OpenDlg.InitialDirectory = @"C:\Program Files (x86)\IR_SerialWrite";
                OpenDlg.FileName = "ppcli.exe";
                OpenDlg.Filter = "exe Files|*.exe|All Files|*.*";
                OpenDlg.FilterIndex = 1;
                OpenDlg.RestoreDirectory = true;
            }
            catch
            {
            }
            if (SerialNumberWrite.Text.Length == 6)
            {
                if (OpenDlg.ShowDialog() == DialogResult.OK)
                {
                    var fPath = string.Empty;
                    fPath = OpenDlg.FileName;
                    lastPath = fPath;
                    cmd.Arguments = lastPath;
                    cmd.FileName = lastPath;
                    cmd.UseShellExecute = false;
                    cmd.RedirectStandardOutput = true;
                    textBox_msg.AppendText(cmd.Arguments);

                    Process process = Process.Start(cmd.FileName, cmd.Arguments);

                    Thread.Sleep(1000);
                    try
                    {
                        var DecToHex = SerialNumberDecToHex(SerialNumberWrite.Text);

                        textBox_msg.AppendText(
                            "\r\n   IR - " +
                            DecToHex.Item1  + "/" + DecToHex.Item2 + "/" + DecToHex.Item3 + "/" + DecToHex.Item4 + "/" + DecToHex.Item5 + "/" + DecToHex.Item6 +"  (" + 
                            (Convert.ToInt32(DecToHex.Item1) - 30) + (Convert.ToInt32(DecToHex.Item2) - 30) + (Convert.ToInt32(DecToHex.Item3) - 30) +
                            (Convert.ToInt32(DecToHex.Item4) - 30) + (Convert.ToInt32(DecToHex.Item5) - 30) + (Convert.ToInt32(DecToHex.Item6) - 30) + ")" + "\r\n");

                        config.Text = config.Text.Remove(108, 30);

                        config.Text = config.Text.Insert(108, " 0x" + DecToHex.Item6);
                        config.Text = config.Text.Insert(108, " 0x" + DecToHex.Item5);
                        config.Text = config.Text.Insert(108, " 0x" + DecToHex.Item4);
                        config.Text = config.Text.Insert(108, " 0x" + DecToHex.Item3);
                        config.Text = config.Text.Insert(108, " 0x" + DecToHex.Item2);
                        config.Text = config.Text.Insert(108, " 0x" + DecToHex.Item1);


                        textBox_msg.AppendText("Send Keys \r\n");

                        string[] temp = cbComPort.Text.Split('M');
                        portNumber = Convert.ToInt32(temp[1]);

                        textBox_msg.AppendText("Comport " + portNumber + "\r\n");


                        SendKeys.Send("OpenPort KitProg/");
                        SendKeys.Send(KitNum.Text + " .");
                        SendKeys.Send("{ENTER}");

                        SendKeys.Send("SetProtocol 8");
                        SendKeys.Send("{ENTER}");

                        SendKeys.Send(config.Text);
                        
                        Thread.Sleep(1000);

                        SendKeys.Send("quit");
                        SendKeys.Send("{ENTER}");
                        
                        textBox_msg.AppendText("Send Keys Complete\r\n");
                        //MessageBox.Show("Write Complete, Please Reset Kit");


                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }

                }
            }
            else
            {
                MessageBox.Show("SerialNumber has Only 6 Length. ex) 123456, 000001");
            }
        }

        private void loadConfig_Click(object sender, EventArgs e)
        {
            textBox_msg.AppendText("loadConfig init\r\n");
            OpenDlg.InitialDirectory = @"D:\GitHub\Tools\IR_Serial_Write_Tool_";
            OpenDlg.FileName = "config.txt";
            OpenDlg.Filter = "txt Files|*.txt";
            OpenDlg.FilterIndex = 1;
            OpenDlg.RestoreDirectory = true;
            textBox_msg.AppendText(OpenDlg.InitialDirectory + "\r\n");

            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                var fPath = string.Empty;
                fPath = OpenDlg.FileName;

                var fStream = OpenDlg.OpenFile();

                using (StreamReader reader = new StreamReader(fStream))
                {
                    fContent = reader.ReadToEnd();
                    config.Text = fContent;
                }
            }
        }

        private void config_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Config를 불러 오시겠습니까 ? ", "Detected Config Changed", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
                loadConfig_Click(null, null);
        }

        private void KitList_Click(object sender, EventArgs e)
        {
            KitNum.Text = KitList.SelectedItem.ToString();
        }
        private int StringToInt(string str)
        {
            int strInt;
            if (int.TryParse(str, out strInt))
            {
                strInt = Convert.ToInt32(str);
            }
            return strInt;
        }
        private void SerialNumberWrite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                SerialNumberWrite.Text = string.Format("{0:D1}", StringToInt(SerialNumberWrite.Text) + 1);
            }

            else if (e.KeyCode == Keys.Down && StringToInt(SerialNumberWrite.Text) > 0)
            {
                SerialNumberWrite.Text = string.Format("{0:D1}", StringToInt(SerialNumberWrite.Text) - 1);
            }
            else if (SerialNumberWrite.Text.Length > 6 
                    && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete
                    && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right )
            {
                SerialNumberWrite.Text = "";
            }

        }
    }
}
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


namespace arduinoSample
{



    public partial class MainForm : Form
    {
        private SerialPort _serialPort;
        private bool _isConnected = false;
        Thread th;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            InitializeSerialPort();
            th = new Thread(DoTask);
            th.Start();

            fun(100);

            int a = 100;
            int b = 80;
            int c = a - b;
            int d = b - 135;

        }

        private void DoTask()
        
        {

            int a = 100;
            for (int i = 0; i < 100; i++)
            {
                a += i;
                Thread.Sleep(200);

            }

        }

        private void InitializeSerialPort()
        {
            // 初始化串口
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            // 填充可用串口列表
            foreach (string port in SerialPort.GetPortNames())
            {
                cmbPorts.Items.Add(port);
            }

            if (cmbPorts.Items.Count > 0)
                cmbPorts.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!_isConnected)
            {
                try
                {
                    if (string.IsNullOrEmpty(cmbPorts.Text))
                    {
                        MessageBox.Show("请选择串口");
                        return;
                    }

                    _serialPort.PortName = cmbPorts.Text;
                    _serialPort.Open();
                    _isConnected = true;
                    btnConnect.Text = "断开连接";
                    groupBox1.Enabled = true;

                    MessageBox.Show("连接成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show( "连接失败: "+ex.Message);
                }
            }
            else
            {
                try
                {
                    _serialPort.Close();
                    _isConnected = false;
                    btnConnect.Text = "连接";
                    groupBox1.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("断开连接失败: "+ex.Message);
                }
            }
        }

        private void SendCommand(char command)
        {
            if (_isConnected && _serialPort.IsOpen)
            {
                try
                {
                    _serialPort.Write(command.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发送指令失败:"+ex.Message);
                }
            }
        }

        private void btnLed1_Click(object sender, EventArgs e)
        {
            SendCommand('0'); // 控制第一个LED (PIN 3)
        }

        private void btnLed2_Click(object sender, EventArgs e)
        {
            SendCommand('1'); // 控制第二个LED (PIN 4)
        }

        private void btnLed3_Click(object sender, EventArgs e)
        {
            SendCommand('2'); // 控制第三个LED (PIN 5)
        }

        private void btnStartMarquee_Click(object sender, EventArgs e)
        {
            SendCommand('S'); // 启动跑马灯
        }

        private void btnStopMarquee_Click(object sender, EventArgs e)
        {
            SendCommand('T'); // 停止跑马灯
        }

        private void btnAllOn_Click(object sender, EventArgs e)
        {
            SendCommand('A'); // 所有LED点亮
        }

        private void btnAllOff_Click(object sender, EventArgs e)
        {
            SendCommand('O'); // 所有LED熄灭
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialPort.IsOpen)
                _serialPort.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private int fun(int n)
        {
            if (n == 50)
            {
                int err = 0;
            }
            if (n > 1)
                return n + fun(n - 1);
            else
                return 1;
        }

    }
}

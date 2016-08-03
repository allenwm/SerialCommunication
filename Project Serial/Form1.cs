using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
  

namespace Project_Serial
{
    public partial class Form1 : Form
    {
        private SerialPort comm=new SerialPort();
        private StringBuilder builder = new StringBuilder();          //避免在事件处理中反复调用，定义在外面
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //<1>初始化串口下拉下表
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboPortName.Items.AddRange(ports);                    //获得串口名称
            comboPortName.SelectedIndex = comboPortName.Items.Count > 0 ? 0 : -1;               //初始化下拉下表
            comboBaudrate.SelectedIndex = comboBaudrate.Items.IndexOf("9600");

            //初始化SerialPort对象
            comm.NewLine = "\r\n";
            comm.RtsEnable = true;//根据实际情况吧。

            //使部分button失效
            buttonSend.Enabled=false;
            buttonReset.Enabled = false;


            //buttonSend.Enabled = comm.IsOpen;
            //添加事件注册
            comm.DataReceived += comm_DataReceived;
        }
        void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = comm.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            comm.Read(buf, 0, n);//读取缓冲数据
            builder.Clear();//清除字符串构造器的内容

            MessageBox.Show("here!", "接收到的字符", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
                ////判断是否是显示为16禁止
                //依次的拼接出16进制字符串
                bool startrecived = true;
                foreach (byte b in buf)
                {
                    builder.Append(b.ToString("X2") + " ");
                }

                MessageBox.Show(builder.ToString(), "接收到的字符", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                for (int i = 0; i < n; i++)
                {
                    if (buf[i] == 0x3d && buf[i + 1] == 0x3d && buf[i + 2] == 0x3d && buf[i + 3] == 0x3d)
                    {
                        //清空框内部数据
                        this.textBoxPreCoorX.Clear();
                        this.textBoxPreCoorY.Clear();
                        this.textBoxPreCoorZ.Clear();
                        int X_data = buf[i + 4] * 255 + buf[i + 5];
                        //int Y_data = buf[i + 10] * 256 + buf[i + 11];
                        //int Z_data = buf[i + 14] * 256 + buf[i + 15];
                        this.textBoxPreCoorX.AppendText(X_data.ToString());
                        //this.textBoxPreCoorY.AppendText(Y_data.ToString());
                        //this.textBoxPreCoorZ.AppendText(Z_data.ToString());
                        startrecived = false;                //开始接收数据显示
                    }
                }
            }));
        }

        private void buttonOpenClose_Click(object sender, EventArgs e)
        {
             //根据当前串口对象，来判断操作
            if (comm.IsOpen)
            {
                //打开时点击，则关闭串口
                comm.Close();
            }
            else
            {
                //关闭时点击，则设置好端口，波特率后打开
                comm.PortName = comboPortName.Text;
                comm.BaudRate = int.Parse(comboBaudrate.Text);
                try
                {
                    comm.Open();
                }
                catch(Exception ex)
                {
                    //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                    comm = new SerialPort();
                    //现实异常信息给客户。
                    MessageBox.Show(ex.Message);
                }
            }
            //设置按钮的状态
            buttonOpenClose.Text = comm.IsOpen ? "Close" : "Open";
            buttonSend.Enabled = comm.IsOpen;
            buttonSend.Enabled = comm.IsOpen;
            buttonReset.Enabled = comm.IsOpen;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //定义一个变量，记录发送了几个字节
            int n = 0;
            //16进制发送
            //将x,y,z的十进制字符串转化为十进制整型（int）
            int textX, textY, textZ;
            int.TryParse(textBoxNextCoorX.Text, out textX);
            int.TryParse(textBoxNextCoorY.Text, out textY);
            int.TryParse(textBoxNextCoorZ.Text, out textZ);
            int headint = 0xeeee;
            long endint = 0xdddddddd;
            //判断输入的值的防止溢出
            if(Math.Abs(textX)>=1000)
            {
                MessageBox.Show("X overflow!!!!", "X范围", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (Math.Abs(textY) >= 1000)
            {
                MessageBox.Show("Y  overflow!!!!", "Y范围", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (Math.Abs(textZ) >= 1000)
            {
                MessageBox.Show("Z  overflow!!!!", "Z范围", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            //选择运行指令模式
            int modeint=0x41;
            switch(comboMode.Text)
            {
                case "A":
                    modeint = 0x4100;
                    break;
                case "B":
                    modeint = 0x4200;
                    break;
                case "C":
                    modeint = 0x4300;
                    break;
                case "D":
                    modeint = 0x4400;
                    break;
                default:
                    MessageBox.Show("please select mode!!!!", "mode选择", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;   
            }

            //将十进制转化为十六进制
            string headstring = headint.ToString("x4");
            string modestring = modeint.ToString("x1");
            string Xstring = textX.ToString("x8");
            string Ystring = textY.ToString("x8");
            string Zstring = textZ.ToString("x8");
            string endstring = endint.ToString("x8");


            string textSend = headstring + modestring + Xstring + Ystring + Zstring + endstring;   //运行指令符

            byte[] buf;                           //填充到这个临时字节数组中  

            buf = Enumerable.Range(0, textSend.Length).Where(x => x % 2 == 0)
                 .Select(x => Convert.ToByte(textSend.Substring(x, 2), 16))
                 .ToArray();

            Array.Reverse(buf, 4, 4);
            Array.Reverse(buf, 8, 4);
            Array.Reverse(buf, 12, 4);
            Array.Reverse(buf, 16, 4);
            //将数组发送至CMD
            comm.Write(buf, 0, buf.Count());
            //记录发送的字节数
            n = buf.Count();
            MessageBox.Show(n.ToString(), "发送的字节数", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //复位接受和发送的字节数计数器并更新界面。
            int zero = 0;
            this.textBoxNextCoorX.Clear();
            this.textBoxNextCoorY.Clear();
            this.textBoxNextCoorZ.Clear();
            this.textBoxNextCoorX.AppendText(zero.ToString());
            this.textBoxNextCoorY.AppendText(zero.ToString());
            this.textBoxNextCoorZ.AppendText(zero.ToString());
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
   }
}

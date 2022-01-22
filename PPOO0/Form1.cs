using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIDLib;

namespace PPOO0
{
    public partial class Form1 : Form
    {
        HIDDevice dev = new HIDDevice();
        public Form1()
        {
            InitializeComponent();
            dev.vid = 0x2DBC;
            dev.pid = 0x0001;

            dev.in_size = 64;
            dev.out_size = 64;
            dev.Initialize();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gaugeControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            try
            {
                byte[] data = new byte[64];

                data = dev.Receive();
                if (data != null)
                {
        float act1= float.Parse((data[1].ToString()));
        float min1=  float.Parse((data[3].ToString()));
        float max1 = float.Parse((data[4].ToString()));
                    float act = act1/10;
                    float min = min1 / 10;
                    float max = max1/10;
                    arcScaleNeedleComponent1.Value = act;
                    arcScaleNeedleComponent2.Value = min;
                    arcScaleNeedleComponent3.Value = max;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPresMin_Click(object sender, EventArgs e)
        {
            int valCaseta1 = int.Parse(txtPresMin.Text.ToString());
            byte valCaseta = Convert.ToByte(valCaseta1);
            byte[] data = new byte[64];
            data[5] = valCaseta;
            if (!dev.Transmit(data)) MessageBox.Show("Device not ready");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valCaseta1 = int.Parse(txtPresMax.Text.ToString());
            byte valCaseta = Convert.ToByte(valCaseta1);
            byte[] data = new byte[64];
            data[6] = valCaseta;
            if (!dev.Transmit(data)) MessageBox.Show("Device not ready");
        }
    }
}

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

namespace ArduinoBluetoothCar
{
    
    public partial class Form1 : Form
    {

        SerialPort myport = new SerialPort();
        
        

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }



        private void baglan()
        {
            try
            {
                myport.BaudRate = 9600;
                myport.PortName = comboBox1.Text;
                myport.Open();
                MessageBox.Show(comboBox1.Text + " nolu porta bağlantı sağlandı");
            }

            catch (Exception)
            {
                MessageBox.Show("Port Bağlantısı Yok.");
            }
        }

        private void baglantikes()
        {
            myport.Close();
            MessageBox.Show("Bağlantı Kesildi.");
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W && radioButton1.Checked==true)
            {
                myport.WriteLine("1");
            }

            if(e.KeyCode==Keys.W && radioButton2.Checked==true)
            {
                myport.WriteLine("2");
            }

            if(e.KeyCode==Keys.W && radioButton3.Checked==true)
            {
                myport.WriteLine("3");
            }


            if (e.KeyCode==Keys.S)
            {
                myport.WriteLine("b");
            }

            if (e.KeyCode == Keys.A)
            {
                myport.WriteLine("l");
            }

            if (e.KeyCode == Keys.D)
            {
                myport.WriteLine("r");
            }


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W || e.KeyCode==Keys.S)
            {
                myport.WriteLine("s");
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.D)
            {
                myport.WriteLine("n");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string portlar in SerialPort.GetPortNames())
                comboBox1.Items.Add(portlar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Hız 100";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Hız 170";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Hız 255";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantikes();
        }
    }
}

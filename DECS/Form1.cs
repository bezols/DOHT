using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using soulsAPI;

namespace DECS
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/bezols");
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/@xxela");
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/PgdAeG9thF");
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(metroLabel2.Text == "Not Connected")
            {
                int num = (int)api.Connections.showConnectionWindow();
                metroLabel2.Text = "Connected!";
                metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            }
            else
            {
                metroLabel2.Text = "Not Connected";
                metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            }

        }

        private void metroLink4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("@Soul - API & Functions");
            MessageBox.Show("@Eddie Mac - Functions");
            MessageBox.Show("@Cyb3r - Functions");
            MessageBox.Show("@TheRealx5150xi - Functions");
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox1.Checked)
                api.Extension.WriteFloat(21212424U, -1f); 
            else
                api.Extension.WriteFloat(21212424U, 1f);
        }

        private void metroLink5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Use this function to effectively disable World Boxes & Turn Back Barriers");
            MessageBox.Show("Can also be used to get a huge upward burst of speed if you enable the cheat, and then jump on an elevated piece of geometry");
            MessageBox.Show("Enable No Gravity directly afterwards to give yourself the illusion of Noclip :)");
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox2.Checked)
                api.setMemory(20485984U, new byte[12]
                {
          (byte) 191,
          (byte) 33,
          (byte) 71,
          (byte) 174,
          (byte) 63,
          (byte) 99,
          (byte) 215,
          (byte) 10,
          (byte) 63,
          (byte) 56,
          (byte) 81,
          (byte) 236
                });
            else
                api.setMemory(20485984U, new byte[12]
                {
          (byte) 63,
          (byte) 128,
          (byte) 0,
          (byte) 0,
          (byte) 63,
          (byte) 128,
          (byte) 0,
          (byte) 0,
          (byte) 63,
          (byte) 128,
          (byte) 0,
          (byte) 0
                });
        }

        private void metroLink6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will allow you to walk through walls, doors, etc");
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox3.Checked)
                api.Extension.WriteFloat(22005392U, -1f);
            else
                api.Extension.WriteFloat(22005392U, 1f);
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            api.Extension.WriteFloat(7377004U, (float)(2.0 + (double)this.metroTrackBar1.Value / 10.0));
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox4.Checked)
                api.Extension.WriteFloat(23630960U, -1f);
            else
                api.Extension.WriteFloat(23630960U, 1f);
        }

        private void metroLink7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be Careful when using these; *High Ban Risk*");
            MessageBox.Show("These cheats are meant to be used in a solo instance, if another person joins you some of these cheats will no longer function");
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox5.Checked)
                api.Extension.WriteUInt32(4476064U, 3223389256U);
            else
                api.Extension.WriteUInt32(4476064U, 3223389016U);
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox6.Checked)
                api.Extension.WriteUInt32(5367776U, 0U);
            else
                api.Extension.WriteUInt32(5367776U, 1065353216U);
        }

        private void metroLink8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Completely stops all enemy bullets from moving. Can crash game if too many bullets are on screen at a time");
        }

        private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox7.Checked)
            {
                api.Extension.WriteUInt32(1599516U, 3221225472U);
                api.Extension.WriteUInt32(1610212U, 3221225472U);
            }
            else
            {
                api.Extension.WriteUInt32(1599516U, 1065353216U);
                api.Extension.WriteUInt32(1610212U, 1065353216U);
            }
        }

        private void metroCheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox9.Checked)
                api.Extension.WriteUInt32(3070660U, 0U);
            else
                api.Extension.WriteUInt32(3070660U, 1065353216U);
        }

        private void metroCheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox13.Checked)
                api.setMemory(3215252U, new byte[4]
                {
          (byte) 96,
          (byte) 0,
          (byte) 0,
          (byte) 0
                });
            else
                api.setMemory(3215252U, new byte[4]
                {
          (byte) 124,
          (byte) 158,
          (byte) 32,
          (byte) 16
                });
        }

        private void metroCheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox12.Checked)
                api.Extension.WriteUInt32(2897660U, 3284336644U);
            else
                api.Extension.WriteUInt32(2897660U, 3284336640U);
        }
    }

}

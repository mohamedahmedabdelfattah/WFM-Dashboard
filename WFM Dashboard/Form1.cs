using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFMDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVersion.Text = "v0." + new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).LastWriteTime.ToString().Remove(9).Remove(5, 2).Replace('/', '.');
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:mohamed.aabdelfattah@tedata.net?subject=WFM Dashboard " + lblVersion.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wFMDashboardDataSet.WFM' table. You can move, or remove it, as needed.
            this.wFMTableAdapter.Fill(this.wFMDashboardDataSet.WFM);
            // TODO: This line of code loads data into the 'wFMDashboardDataSet.Leaders' table. You can move, or remove it, as needed.
            this.leadersTableAdapter.Fill(this.wFMDashboardDataSet.Leaders);
            // TODO: This line of code loads data into the 'wFMDashboardDataSet1.Leaders' table. You can move, or remove it, as needed.
            this.leadersTableAdapter.Fill(this.wFMDashboardDataSet.Leaders);
            // TODO: This line of code loads data into the 'wFMDashboardDataSet1.WFM' table. You can move, or remove it, as needed.
            this.wFMTableAdapter.Fill(this.wFMDashboardDataSet.WFM);
            // TODO: This line of code loads data into the 'wFMDashboardDataSet.Leaders' table. You can move, or remove it, as needed.
            this.leadersTableAdapter.Fill(this.wFMDashboardDataSet.Leaders);
            // TODO: This line of code loads data into the 'wFMDashboardDataSet.Agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.Fill(this.wFMDashboardDataSet.Agents);
            // TODO: This line of code loads data into the 'wFMDashboardDataSet.Problems' table. You can move, or remove it, as needed.
            this.problemsTableAdapter.Fill(this.wFMDashboardDataSet.Problems);
            
            //foreach (TabPage tab in colFormType.TabPages)
            //{
            //    if (tab.TabIndex != 0)
            //        colFormType.TabPages.Remove(tab);
            //}
        }

        private void radioLeaders_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLeaders.Checked)
            {
                comboFollowerLeader.Visible = true;
                comboFollowerWFM.Visible = false;
            }
            else
            {
                comboFollowerWFM.Visible = true;
                comboFollowerLeader.Visible = false;
            }
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
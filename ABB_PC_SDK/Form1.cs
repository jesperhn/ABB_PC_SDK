using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABB.Robotics;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Discovery;
using ABB.Robotics.Controllers.RapidDomain;
using System.Threading;

namespace ABB_PC_SDK
{
    public partial class Form1 : Form
    {
        private NetworkScanner scanner = new NetworkScanner();
        private Controller controller = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            DisableControllerFunctionality();
            listView1.Items.Clear();
            this.scanner.Scan();
            ControllerInfoCollection controllers = scanner.Controllers;
            ListViewItem item = null;
            foreach (ControllerInfo controllerInfo in controllers)
            {
                item = new ListViewItem(controllerInfo.IPAddress.ToString());
                item.SubItems.Add(controllerInfo.Availability.ToString());
                item.SubItems.Add(controllerInfo.IsVirtual.ToString());
                item.SubItems.Add(controllerInfo.SystemName);
                item.SubItems.Add(controllerInfo.Version.ToString());
                item.SubItems.Add(controllerInfo.ControllerName);
                this.listView1.Items.Add(item);
                item.Tag = controllerInfo;
            }
        }

        private void EnableControllerFunctionality()
        {
            // put all the enable and disable functionality in the same place so that it is easy to reuse
            label1.Visible = false;
            listView1.Enabled = false;
            gbxControllerSelected.Visible = true;
        }
        private void DisableControllerFunctionality()
        {
            // put all the enable and disable functionality in the same place so that it is easy to reuse
            label1.Visible = true;
            listView1.Enabled = true;
            gbxControllerSelected.Visible = false;
            if (this.controller != null) //if selecting a new controller
            {
                this.controller.Logoff();
                this.controller.Dispose();
                this.controller = null;
            }
        }


        private void StartProduction()
        {
            try
            {
                if (controller.OperatingMode == ControllerOperatingMode.Auto)
                {
                    using (Mastership m = Mastership.Request(controller.Rapid))
                    {
                        this.controller.Rapid.Start();
                        label3.Text = "Production started";
                    }
                }
                else
                {
                    MessageBox.Show("Automatic mode is required to start execution from a remote client.");
                }
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("Mastership is held by another client. " + ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Unexpected error occurred: " + ex.Message);
            }
        }

        private void StopProduction()
        {

            try
            {
                if (controller.OperatingMode == ControllerOperatingMode.Auto)
                {

                    using (Mastership m = Mastership.Request(controller.Rapid))
                    {
                        this.controller.Rapid.Stop(StopMode.Immediate);
                        label3.Text = "Production stopped!";
                    }

                }
                else
                {
                    MessageBox.Show("Controller is not running");
                }
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("Mastership is held by another client. " + ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Unexpected error occurred: " + ex.Message);
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            ListViewItem item = this.listView1.SelectedItems[0]; if (item.Tag != null)
            {
                ControllerInfo controllerInfo = (ControllerInfo)item.Tag;
                if (controllerInfo.Availability == Availability.Available)
                {
                    if (controllerInfo.IsVirtual)
                    {
                        this.controller = ControllerFactory.CreateFrom(controllerInfo);
                        this.controller.Logon(UserInfo.DefaultUser);
                        listView1.Items.Clear();
                        listView1.Items.Add(item);
                        EnableControllerFunctionality();
                    }
                    else //real controller
                    {
                        if (MessageBox.Show("This is NOT a virtual controller, do you really want to connect to that?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.controller = ControllerFactory.CreateFrom(controllerInfo);
                            this.controller.Logon(UserInfo.DefaultUser);
                            listView1.Items.Clear();
                            listView1.Items.Add(item);
                            EnableControllerFunctionality();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected controller not available.");
                }
            }

        }

        private void btnProduction_Click_1(object sender, EventArgs e)
        {
            if (controller.IsVirtual)
            {
                StartProduction();
                //		controller.EventLog.MessageWritten() += Controller_EventLog_MessageWritten;
            }
            else
            {
                if (MessageBox.Show("Do you want to start production for the selected controller?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    StartProduction();
                }
            }
        }


        private void btnProduction_Click_2(object sender, EventArgs e)
        {
            if (controller.IsVirtual)
            {
                StopProduction();
                //		controller.EventLog.MessageWritten() += Controller_EventLog_MessageWritten;
            }
            else
            {
                if (MessageBox.Show("Do you want to stop production for the selected controller?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    StopProduction();
                }
            }
        }

        void Controller_EventLog_MessageWritten(object sender, ABB.Robotics.Controllers.EventLogDomain.MessageWrittenEventArgs e)
        {
            MessageBox.Show(e.Message.ToString());
        }
    }
}
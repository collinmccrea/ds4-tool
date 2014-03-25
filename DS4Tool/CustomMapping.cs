using DS4Control;
using DS4Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScpServer
{
    public partial class CustomMapping : Form
    {
        private int device;
        private bool handleNextKeyPress = false;
        private List<ComboBox> comboBoxes = new List<ComboBox>();
        private Dictionary<string, string> defaults = new Dictionary<string, string>();
        private ComboBox lastSelected;
        private Dictionary<DS4Controls, GraphicsPath> pictureBoxZones = new Dictionary<DS4Controls, GraphicsPath>();
        private DS4Control.Control rootHub = null;
        private System.Windows.Forms.Control mappingControl = null;

        //Below used to capture control zones
        //GraphicsPath test = new System.Drawing.Drawing2D.GraphicsPath();
        //Point lastPoint = Point.Empty;

        public CustomMapping(DS4Control.Control rootHub, int deviceNum)
        {
            InitializeComponent();
            this.rootHub = rootHub;
            device = deviceNum;
            DS4Color color = Global.loadColor(device);
            pictureBox.BackColor = Color.FromArgb(color.red, color.green, color.blue);
            List<object> availableButtons = new List<object>();
            foreach (System.Windows.Forms.Control control in this.Controls)
                if (control is ComboBox)
                {
                    comboBoxes.Add((ComboBox)control);
                    availableButtons.Add(control.Text);

                    // Add defaults
                    defaults.Add(((ComboBox)control).Name, ((ComboBox)control).Text);
                    // Add events here (easier for modification/addition)
                    ((ComboBox)control).SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChangedCommand);
                    ((ComboBox)control).Enter += new System.EventHandler(this.EnterCommand);
                    ((ComboBox)control).KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownCommand);
                    ((ComboBox)control).KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressCommand);
                    ((ComboBox)control).PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PreviewKeyDownCommand);
                }
            availableButtons.Sort();
            foreach (ComboBox comboBox in comboBoxes)
                comboBox.Items.AddRange(availableButtons.ToArray());
            // Do not add XInput to touchpad
            cbTouchButton.Items.Clear();
            cbTouchButton.Items.Add(cbTouchButton.Text);
            cbTouchUpper.Items.Clear();
            cbTouchUpper.Items.Add(cbTouchUpper.Text);
            cbTouchMulti.Items.Clear();
            cbTouchMulti.Items.Add(cbTouchMulti.Text);

            ComboBox[] boxes = { cbLX, cbLX2, cbLY, cbLY2, cbRX, cbRX2, cbRY, cbRY2 };
            foreach (ComboBox box in boxes)
            {
                box.Items.Add("Mouse Up");
                box.Items.Add("Mouse Left");
                box.Items.Add("Mouse Down");
                box.Items.Add("Mouse Right");
            }
            Global.loadCustomMapping(Global.getCustomMap(device), comboBoxes.ToArray());

            // Add coords where buttons are in pictureBox
            foreach (DS4Controls control in Enum.GetValues(typeof (DS4Controls)))
                pictureBoxZones[control] = new System.Drawing.Drawing2D.GraphicsPath();
            pictureBoxZones[DS4Controls.PS].AddLines(new Point[] { new Point(251, 209), new Point(258, 213), new Point(259, 218), new Point(252, 223), new Point(242, 220), new Point(239, 214), new Point(243, 208) });
            pictureBoxZones[DS4Controls.Square].AddLines(new Point[] { new Point(372, 169), new Point(369, 178), new Point(378, 189), new Point(394, 189), new Point(401, 175), new Point(397, 164), new Point(386, 160) });
            pictureBoxZones[DS4Controls.Triangle].AddLines(new Point[] { new Point(439, 134), new Point(450, 140), new Point(453, 150), new Point(449, 156), new Point(440, 162), new Point(428, 162), new Point(419, 160), new Point(417, 150), new Point(421, 140), new Point(427, 135) });
            pictureBoxZones[DS4Controls.Circle].AddLines(new Point[] { new Point(446, 184), new Point(455, 191), new Point(471, 191), new Point(479, 185), new Point(483, 174), new Point(478, 165), new Point(468, 161), new Point(454, 165), new Point(450, 173) });
            pictureBoxZones[DS4Controls.Cross].AddLines(new Point[] { new Point(423, 190), new Point(433, 205), new Point(427, 213), new Point(417, 217), new Point(400, 215), new Point(398, 202), new Point(404, 192), new Point(412, 187)});
            pictureBoxZones[DS4Controls.DpadUp].AddLines(new Point[] { new Point(63, 150), new Point(83, 149), new Point(90, 166), new Point(83, 173), new Point(67, 166), new Point(62, 151)});
            pictureBoxZones[DS4Controls.DpadDown].AddLines(new Point[] { new Point(84, 180), new Point(77, 187), new Point(78, 209), new Point(94, 212), new Point(102, 206), new Point(99, 191), new Point(84, 180)});
            pictureBoxZones[DS4Controls.DpadLeft].AddLines(new Point[] { new Point(40, 173), new Point(41, 184), new Point(45, 191), new Point(60, 190), new Point(67, 185), new Point(76, 176), new Point(63, 171), new Point(48, 170), new Point(40, 169)});
            pictureBoxZones[DS4Controls.DpadRight].AddLines(new Point[] { new Point(87, 174), new Point(95, 182), new Point(109, 188), new Point(122, 189), new Point(126, 182), new Point(126, 173), new Point(120, 167), new Point(105, 167), new Point(90, 167), new Point(88, 175) });
            pictureBoxZones[DS4Controls.L1].AddLines(new Point[] { new Point(44, 76), new Point(54, 81), new Point(81, 82), new Point(108, 74), new Point(114, 66), new Point(117, 59), new Point(107, 53), new Point(84, 48), new Point(61, 52), new Point(50, 56), new Point(41, 66), new Point(40, 75) });
            pictureBoxZones[DS4Controls.L2].AddLines(new Point[] { new Point(52, 54), new Point(64, 51), new Point(84, 50), new Point(99, 50), new Point(111, 54), new Point(115, 54), new Point(118, 50), new Point(119, 42), new Point(117, 32), new Point(110, 25), new Point(97, 21), new Point(81, 25), new Point(72, 33), new Point(64, 43), new Point(54, 52), new Point(55, 54) });
            pictureBoxZones[DS4Controls.L3].AddLines(new Point[] { new Point(169, 235), new Point(181, 238), new Point(188, 249), new Point(181, 257), new Point(169, 260), new Point(156, 258), new Point(149, 254), new Point(148, 244), new Point(155, 236) });
            pictureBoxZones[DS4Controls.R1].AddLines(new Point[] { new Point(394, 69), new Point(408, 76), new Point(420, 80), new Point(431, 82), new Point(455, 83), new Point(466, 80), new Point(468, 75), new Point(464, 69), new Point(456, 61), new Point(441, 53), new Point(422, 51), new Point(405, 52), new Point(393, 55), new Point(389, 61), new Point(394, 67) });
            pictureBoxZones[DS4Controls.R2].AddLines(new Point[] { new Point(381, 57), new Point(386, 60), new Point(392, 55), new Point(401, 52), new Point(415, 49), new Point(432, 51), new Point(450, 57), new Point(449, 49), new Point(440, 43), new Point(434, 37), new Point(428, 30), new Point(418, 24), new Point(406, 21), new Point(398, 21), new Point(392, 25), new Point(385, 36), new Point(382, 45), new Point(383, 54)});
            pictureBoxZones[DS4Controls.R3].AddLines(new Point[] { new Point(320, 242), new Point(328, 235), new Point(337, 232), new Point(350, 239), new Point(351, 247), new Point(346, 254), new Point(333, 256), new Point(322, 256), new Point(317, 250) });
            pictureBoxZones[DS4Controls.Share].AddLines(new Point[] { new Point(128, 122), new Point(137, 118), new Point(146, 125), new Point(146, 137), new Point(141, 146), new Point(135, 146), new Point(131, 140), new Point(128, 132) });
            pictureBoxZones[DS4Controls.Options].AddLines(new Point[] { new Point(366, 124), new Point(373, 117), new Point(381, 120), new Point(382, 128), new Point(380, 140), new Point(374, 144), new Point(367, 144), new Point(364, 140), new Point(364, 133) });
            pictureBoxZones[DS4Controls.LXPos].AddLines(new Point[] { new Point(186, 236), new Point(191, 226), new Point(200, 237), new Point(199, 247), new Point(195, 255), new Point(188, 257), new Point(185, 255), new Point(187, 246), new Point(188, 239) });
            pictureBoxZones[DS4Controls.LXNeg].AddLines(new Point[] { new Point(141, 232), new Point(144, 237), new Point(143, 243), new Point(143, 250), new Point(146, 256), new Point(145, 261), new Point(136, 250), new Point(136, 243), new Point(136, 235), new Point(141, 231) });
            pictureBoxZones[DS4Controls.LYPos].AddLines(new Point[] { new Point(142, 257), new Point(149, 253), new Point(162, 258), new Point(182, 258), new Point(185, 252), new Point(190, 255), new Point(193, 260), new Point(176, 267), new Point(166, 266), new Point(154, 263) });
            pictureBoxZones[DS4Controls.LYNeg].AddLines(new Point[] { new Point(140, 234), new Point(144, 235), new Point(158, 228), new Point(175, 228), new Point(185, 234), new Point(189, 236), new Point(196, 233), new Point(193, 227), new Point(174, 219), new Point(155, 220), new Point(144, 226) });
            pictureBoxZones[DS4Controls.RXPos].AddLines(new Point[] { new Point(355, 238), new Point(358, 230), new Point(364, 235), new Point(364, 240), new Point(362, 249), new Point(359, 256), new Point(352, 259), new Point(346, 259), new Point(352, 251), new Point(354, 243) });
            pictureBoxZones[DS4Controls.RXNeg].AddLines(new Point[] { new Point(311, 227), new Point(314, 233), new Point(312, 241), new Point(312, 251), new Point(314, 256), new Point(312, 260), new Point(305, 255), new Point(302, 246), new Point(302, 234), new Point(305, 230) });
            pictureBoxZones[DS4Controls.RYPos].AddLines(new Point[] { new Point(312, 258), new Point(318, 256), new Point(323, 257), new Point(330, 259), new Point(341, 259), new Point(350, 256), new Point(355, 255), new Point(353, 260), new Point(347, 263), new Point(334, 267), new Point(322, 263) });
            pictureBoxZones[DS4Controls.RYNeg].AddLines(new Point[] { new Point(305, 233), new Point(310, 238), new Point(316, 233), new Point(332, 229), new Point(342, 229), new Point(355, 236), new Point(360, 240), new Point(363, 235), new Point(358, 227), new Point(345, 220), new Point(328, 217), new Point(317, 221) });
            pictureBoxZones[DS4Controls.TouchButton].AddLines(new Point[] { new Point(158, 132), new Point(169, 179), new Point(184, 184), new Point(323, 185), new Point(339, 178), new Point(349, 141), new Point(349, 130), new Point(234, 127) });
            pictureBoxZones[DS4Controls.TouchMulti].AddLines(new Point[] { new Point(161, 107), new Point(161, 117), new Point(175, 120), new Point(217, 122), new Point(273, 121), new Point(322, 123), new Point(348, 123), new Point(352, 109), new Point(339, 104), new Point(296, 104), new Point(227, 107), new Point(195, 105) });
            pictureBoxZones[DS4Controls.TouchUpper].AddLines(new Point[] { new Point(159, 104), new Point(194, 109), new Point(253, 107), new Point(298, 108), new Point(339, 105), new Point(351, 105), new Point(352, 91), new Point(341, 83), new Point(322, 82), new Point(170, 83), new Point(159, 90), new Point(158, 109) });
        }

        private void EnterCommand(object sender, EventArgs e)
        {
            //Change image to represent button
            if (sender is ComboBox)
            {
                lastSelected = (ComboBox)sender;
                //switch (lastSelected.Name)
                //{
                //    #region Set pictureBox.Image to relevant Properties.Resources image
                //    case "cbL2": pictureBox.Image = Properties.Resources._2;
                //        break;
                //    case "cbL1": pictureBox.Image = Properties.Resources._3;
                //        break;
                //    case "cbR2": pictureBox.Image = Properties.Resources._4;
                //        break;
                //    case "cbR1": pictureBox.Image = Properties.Resources._5;
                //        break;
                //    case "cbUp": pictureBox.Image = Properties.Resources._6;
                //        break;
                //    case "cbLeft": pictureBox.Image = Properties.Resources._7;
                //        break;
                //    case "cbDown": pictureBox.Image = Properties.Resources._8;
                //        break;
                //    case "cbRight": pictureBox.Image = Properties.Resources._9;
                //        break;
                //    case "cbL3": pictureBox.Image = Properties.Resources._10;
                //        break;
                //    case "cbLY": pictureBox.Image = Properties.Resources._11;
                //        break;
                //    case "cbLX": pictureBox.Image = Properties.Resources._12;
                //        break;
                //    case "cbLY2": pictureBox.Image = Properties.Resources._11;
                //        break;
                //    case "cbLX2": pictureBox.Image = Properties.Resources._12;
                //        break;
                //    case "cbR3": pictureBox.Image = Properties.Resources._13;
                //        break;
                //    case "cbRY": pictureBox.Image = Properties.Resources._14;
                //        break;
                //    case "cbRX": pictureBox.Image = Properties.Resources._15;
                //        break;
                //    case "cbRY2": pictureBox.Image = Properties.Resources._14;
                //        break;
                //    case "cbRX2": pictureBox.Image = Properties.Resources._15;
                //        break;
                //    case "cbSquare": pictureBox.Image = Properties.Resources._16;
                //        break;
                //    case "cbCross": pictureBox.Image = Properties.Resources._17;
                //        break;
                //    case "cbCircle": pictureBox.Image = Properties.Resources._18;
                //        break;
                //    case "cbTriangle": pictureBox.Image = Properties.Resources._19;
                //        break;
                //    case "cbOptions": pictureBox.Image = Properties.Resources._20;
                //        break;
                //    case "cbShare": pictureBox.Image = Properties.Resources._21;
                //        break;
                //    case "cbTouchButton": pictureBox.Image = Properties.Resources._22;
                //        break;
                //    case "cbTouchUpper": pictureBox.Image = Properties.Resources._22;
                //        break;
                //    case "cbTouchMulti": pictureBox.Image = Properties.Resources._22;
                //        break;
                //    case "cbPS": pictureBox.Image = Properties.Resources._23;
                //        break;
                //    default: pictureBox.Image = Properties.Resources._1;
                //        break;
                //    #endregion
                //}
                if (lastSelected.ForeColor == Color.Red)
                    cbRepeat.Checked = true;
                else cbRepeat.Checked = false;
                if (lastSelected.Font.Bold)
                    cbScanCode.Checked = true;
                else cbScanCode.Checked = false;
            }
        }
        private void PreviewKeyDownCommand(object sender, PreviewKeyDownEventArgs e)
        {
            if (sender is ComboBox)
            {
                if (e.KeyCode == Keys.Tab)
                    if (((ComboBox)sender).Text.Length == 0)
                    {
                        ((ComboBox)sender).Tag = e.KeyValue;
                        ((ComboBox)sender).Text = e.KeyCode.ToString();
                        handleNextKeyPress = true;
                    }
            }
        }
        private void KeyDownCommand(object sender, KeyEventArgs e)
        {
            if (sender is ComboBox)
            {
                if (((ComboBox)sender).Tag is int)
                {
                    if (e.KeyValue == (int)(((ComboBox)sender).Tag) 
                        && !((ComboBox)sender).Name.Contains("Touch"))
                    {
                        if (((ComboBox)sender).ForeColor == SystemColors.WindowText)
                        {
                            ((ComboBox)sender).ForeColor = Color.Red;
                            cbRepeat.Checked = true;
                        }
                        else
                        {
                            ((ComboBox)sender).ForeColor = SystemColors.WindowText;
                            cbRepeat.Checked = false;
                        }
                        return;
                    }
                }
                if (((ComboBox)sender).Text.Length != 0)
                    ((ComboBox)sender).Text = string.Empty;
                else if (e.KeyCode == Keys.Delete)
                {
                    ((ComboBox)sender).Tag = e.KeyValue;
                    ((ComboBox)sender).Text = e.KeyCode.ToString();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                if (e.KeyCode != Keys.Delete)
                {
                    ((ComboBox)sender).Tag = e.KeyValue;
                    ((ComboBox)sender).Text = e.KeyCode.ToString();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
        private void KeyPressCommand(object sender, KeyPressEventArgs e)
        {
            if (handleNextKeyPress)
            {
                e.Handled = true;
                handleNextKeyPress = false;
            }
        }
        private void SelectedIndexChangedCommand(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                foreach (ComboBox comboBox in comboBoxes)
                    if (comboBox.Text == ((ComboBox)sender).Text && comboBox.Name != ((ComboBox)sender).Name)
                    {
                        comboBox.Text = "(Unbound)";
                        comboBox.Tag = comboBox.Text;
                    }
                if (((ComboBox)sender).Text != defaults[((ComboBox)sender).Name])
                    ((ComboBox)sender).Tag = ((ComboBox)sender).Text;

                else ((ComboBox)sender).Tag = null;
            }
        }
        private void cbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (!lastSelected.Name.Contains("Touch") &&
                (lastSelected.Tag is int || lastSelected.Tag is UInt16))
                if (cbRepeat.Checked)
                    lastSelected.ForeColor = Color.Red;
                else lastSelected.ForeColor = SystemColors.WindowText;
            else
            {
                cbRepeat.Checked = false;
                lastSelected.ForeColor = SystemColors.WindowText;
            }
        }
        private void cbScanCode_CheckedChanged(object sender, EventArgs e)
        {
            if (lastSelected.Tag is int || lastSelected.Tag is UInt16)
                if (cbScanCode.Checked)
                    lastSelected.Font = new Font(lastSelected.Font, FontStyle.Bold);
                else lastSelected.Font = new Font(lastSelected.Font, FontStyle.Regular);
            else
            {
                cbScanCode.Checked = false;
                lastSelected.Font = new Font(lastSelected.Font, FontStyle.Regular);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDg = new SaveFileDialog();
            saveFileDg.DefaultExt = "xml";
            saveFileDg.Filter = "SCP Custom Map Files (*.xml)|*.xml";
            saveFileDg.FileName = "SCP Custom Mapping.xml";
            if (saveFileDg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                if (Global.saveCustomMapping(saveFileDg.FileName, comboBoxes.ToArray()))
                {
                    if (MessageBox.Show("Custom mapping saved. Enable now?",
                        "Save Successfull", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        Global.setCustomMap(device, saveFileDg.FileName);
                        Global.Save();
                        Global.loadCustomMapping(device);
                    }
                }
                else MessageBox.Show("Custom mapping did not save successfully.", 
                    "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDg = new OpenFileDialog();
            openFileDg.CheckFileExists = true;
            openFileDg.CheckPathExists = true;
            openFileDg.DefaultExt = "xml";
            openFileDg.Filter = "SCP Custom Map Files (*.xml)|*.xml";
            openFileDg.Multiselect = false;
            if (openFileDg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Global.loadCustomMapping(openFileDg.FileName, comboBoxes.ToArray());
                Global.setCustomMap(device, openFileDg.FileName);
                Global.Save();
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                // Below used merely to add points easily (for now save region coords)
                //if (lastPoint != Point.Empty)
                //    test.AddLine(lastPoint, e.Location);
                //lastPoint = e.Location;

                foreach (KeyValuePair<DS4Controls, GraphicsPath> zone in pictureBoxZones)
                    if (zone.Value.IsVisible(e.Location))
                        Controls.Find(getNameByDS4Controls(zone.Key), false).FirstOrDefault().Focus();
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //Context menu
                // Below used merely to add points easily
                //txtZone.Text = string.Empty;
                //for (int i = 0; i < test.PointCount; i++)
                //    txtZone.Text += String.Format("new Point({0}, {1}), ", test.PathPoints[i].X, test.PathPoints[i].Y);
                //lastPoint = Point.Empty;
                //test = new GraphicsPath();
                foreach (KeyValuePair<DS4Controls, GraphicsPath> zone in pictureBoxZones)
                    if (zone.Value.IsVisible(e.Location))
                    {
                        mappingControl = Controls.Find(getNameByDS4Controls(zone.Key), false).FirstOrDefault();

                        if (mappingControl == cbLX || mappingControl == cbLX2 || mappingControl == cbRX || mappingControl == cbRX2)
                            contextMenuStrip1.Items.Find("mouseMovementToolStripMenuItem", true).FirstOrDefault().Visible = true;
                        else if (mappingControl == cbLY || mappingControl == cbLY2 || mappingControl == cbRY || mappingControl == cbRY2)
                            contextMenuStrip1.Items.Find("mouseMovementToolStripMenuItem", true).FirstOrDefault().Visible = true;
                        else
                            contextMenuStrip1.Items.Find("mouseMovementToolStripMenuItem", true).FirstOrDefault().Visible = false;


                        contextMenuStrip1.Show(pictureBox, e.Location);
                    }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtZone.Text != string.Empty)
                txtZone.Text = string.Empty;
            foreach (KeyValuePair<DS4Controls, GraphicsPath> zone in pictureBoxZones)
                if (zone.Value.IsVisible(e.Location))
                    txtZone.Text = (zone.Key.ToString());
        }

        private string getNameByDS4Controls(DS4Controls key)
        {
            switch (key)
            {
                // Regex Tip
                // Find:"(.*)": return (.*); Replace with:$2: return "$1";
                case DS4Controls.Share: return "cbShare";
                case DS4Controls.L3: return "cbL3";
                case DS4Controls.R3: return "cbR3";
                case DS4Controls.Options: return "cbOptions";
                case DS4Controls.DpadUp: return "cbUp";
                case DS4Controls.DpadRight: return "cbRight";
                case DS4Controls.DpadDown: return "cbDown";
                case DS4Controls.DpadLeft: return "cbLeft";

                case DS4Controls.L1: return "cbL1";
                case DS4Controls.R1: return "cbR1";
                case DS4Controls.Triangle: return "cbTriangle";
                case DS4Controls.Circle: return "cbCircle";
                case DS4Controls.Cross: return "cbCross";
                case DS4Controls.Square: return "cbSquare";

                case DS4Controls.PS: return "cbPS";
                case DS4Controls.LXNeg: return "cbLX";
                case DS4Controls.LYNeg: return "cbLY";
                case DS4Controls.RXNeg: return "cbRX";
                case DS4Controls.RYNeg: return "cbRY";
                case DS4Controls.LXPos: return "cbLX2";
                case DS4Controls.LYPos: return "cbLY2";
                case DS4Controls.RXPos: return "cbRX2";
                case DS4Controls.RYPos: return "cbRY2";
                case DS4Controls.L2: return "cbL2";
                case DS4Controls.R2: return "cbR2";

                case DS4Controls.TouchButton: return "cbTouchButton";
                case DS4Controls.TouchMulti: return "cbTouchMulti";
                case DS4Controls.TouchUpper: return "cbTouchUpper";
            }
            return string.Empty;
        }

        private string getX360InputNameFromEnum(X360Controls control)
        {
            switch (control)
            {
                case X360Controls.Back: return "Back";
                case X360Controls.LS: return "Left Stick";
                case X360Controls.RS: return "Right Stick";
                case X360Controls.Start: return "Start";
                case X360Controls.DpadUp: return "Up Button";
                case X360Controls.DpadRight: return "Right Button";
                case X360Controls.DpadDown: return "Down Button";
                case X360Controls.DpadLeft: return "Left Button";

                case X360Controls.LB: return  "Left Bumper";
                case X360Controls.RB: return "Right Bumper";
                case X360Controls.Y: return "Y Button";
                case X360Controls.B: return "B Button";
                case X360Controls.A: return "A Button";
                case X360Controls.X: return "X Button";

                case X360Controls.Guide: return "Guide";
                case X360Controls.LXNeg: return "Left X-Axis-";
                case X360Controls.LYNeg: return "Left Y-Axis-";
                case X360Controls.RXNeg: return "Right X-Axis-";
                case X360Controls.RYNeg: return "Right Y-Axis-";

                case X360Controls.LXPos: return "Left X-Axis+";
                case X360Controls.LYPos: return "Left Y-Axis+";
                case X360Controls.RXPos: return "Right X-Axis+";
                case X360Controls.RYPos: return "Right Y-Axis+";
                case X360Controls.LT: return "Left Trigger";
                case X360Controls.RT: return "Right Trigger";
                case X360Controls.LeftMouse: return "Click";
                case X360Controls.RightMouse: return "Right Click";
                case X360Controls.MiddleMouse: return  "Middle Click";
                case X360Controls.MouseUp: return "Mouse Up";
                case X360Controls.MouseDown: return "Mouse Down";
                case X360Controls.MouseLeft: return "Mouse Left";
                case X360Controls.MouseRight: return "Mouse Right";
                case X360Controls.Unbound: return "(Unbound)";

            }
            return "(Unbound)";
        }

        private void x360ControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadInputForm inputForm = new ReadInputForm();
            inputForm.DS4Device = rootHub.getDS4Controller(device);
            inputForm.Icon = this.Icon;
            inputForm.InputType = InputType.Controller;
            inputForm.ShowDialog();
            if (inputForm.X360Input != X360Controls.Unbound)
            {
                mappingControl.Text = getX360InputNameFromEnum(inputForm.X360Input);
                lastSelected = (ComboBox)mappingControl;
                cbRepeat.Checked = false;
                cbScanCode.Checked = false;
            }
            inputForm.Dispose();
        }

        private void keystrokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadInputForm inputForm = new ReadInputForm();
            inputForm.Icon = this.Icon;
            inputForm.InputType = InputType.Keyboard;
            inputForm.ShowDialog();
            if (inputForm.KeyCode != Keys.None)
            {
                mappingControl.Text = inputForm.KeyCode.ToString();
                mappingControl.Tag = inputForm.KeyValue;
                lastSelected = (ComboBox)mappingControl;
                if (inputForm.RepeatKey)
                    cbRepeat.Checked = true;
                else cbRepeat.Checked = false;
            }
            inputForm.Dispose();
        }

        private void mouseMovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem  menuItem = (ToolStripMenuItem) sender;
            mappingControl.Text = menuItem.Text;
        }
    }
}

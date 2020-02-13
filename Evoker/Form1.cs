using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evoker
{
    public partial class Form1 : Form
    {
        public Color textColor { get; set; }
        public Color backColor { get; set; }
        public Font font { get; set; }
        public int fontSize { get; set; }
        public Rectangle resolution { get; set; }
        public bool runningDynamic { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitForm();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                this.Visible = true;
            }
            base.WndProc(ref m);
        }

        void InitForm()
        {
            runningDynamic = false;
            try
            {
                resolution = Screen.PrimaryScreen.Bounds;
            } catch {
                ResolutionInputForm f = new ResolutionInputForm();
                while (f.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        string[] temp = f.txtReso.Text.Split('*');
                        bool xdone = Int16.TryParse(temp[0], out short x), ydone = Int16.TryParse(temp[1], out short y);
                        if (!xdone || !ydone) continue;
                        resolution = new Rectangle(0, 0, x, y);
                        break;
                    }
                    catch { continue; }
                }
            }

            textColor = btnFrontColor.FlatAppearance.BorderColor;
            backColor = btnBackColor.FlatAppearance.BorderColor;
            
            var fontNames = (from f in FontFamily.Families select f.Name).ToArray();
            font = new Font(fontNames[0], 50);
            cmbFonts.Items.AddRange(fontNames);
            cmbFonts.SelectedIndex = 0;
            
        }

        private void btnFrontColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == clrFront.ShowDialog()) {
                textColor = clrFront.Color;
                btnFrontColor.FlatAppearance.BorderColor = textColor;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == clrFront.ShowDialog()) {
                backColor = clrFront.Color;
                btnBackColor.FlatAppearance.BorderColor = backColor;
            }
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = new Font(FontFamily.Families[cmbFonts.SelectedIndex], font.Size);
            Console.Write("New font selected ");
            Console.WriteLine(font.Name);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            runningDynamic = checkDynamic.Checked;
            if((txtInput.Lines.Count() == 0 || txtInput.Lines.Count() == 3 || txtInput.Lines.Count() > 4) && !checkDynamic.Checked) {
                MessageBox.Show("You need to type 1, 2 or 4 lines when not selecting dynamic mode.");
                return;
            } else if (checkDynamic.Checked) {
                ImageLibrary.LoadDynamicWallpapers(resolution, txtInput.Lines, textColor, backColor, font, checkAppend.Checked, Decimal.ToInt32(numInterval.Value));
            } else {
                runningDynamic = false;
                var img = ImageLibrary.CreateWallpaper(resolution, txtInput.Lines, textColor, backColor, font);
                var path = Path.GetTempPath() + "wallpaper.jpg";
                img.Save(path);
                ImageLibrary.SetWallpaper(path);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (runningDynamic)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void checkDynamic_CheckedChanged(object sender, EventArgs e)
        {
            runningDynamic = !checkDynamic.Checked;
            checkAppend.Enabled = checkDynamic.Checked;
            numInterval.Enabled = checkDynamic.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/divisia/evoker");
        }
    }
}

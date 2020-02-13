namespace Evoker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.clrFront = new System.Windows.Forms.ColorDialog();
            this.clrBack = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.tabStatic = new System.Windows.Forms.TabPage();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFonts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFrontColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.checkDynamic = new System.Windows.Forms.CheckBox();
            this.checkAppend = new System.Windows.Forms.CheckBox();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabHelp.SuspendLayout();
            this.tabStatic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.label6);
            this.tabHelp.Controls.Add(this.linkLabel1);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(501, 137);
            this.tabHelp.TabIndex = 2;
            this.tabHelp.Text = "Help and About";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // tabStatic
            // 
            this.tabStatic.Controls.Add(this.label5);
            this.tabStatic.Controls.Add(this.numInterval);
            this.tabStatic.Controls.Add(this.checkAppend);
            this.tabStatic.Controls.Add(this.checkDynamic);
            this.tabStatic.Controls.Add(this.btnBackColor);
            this.tabStatic.Controls.Add(this.btnFrontColor);
            this.tabStatic.Controls.Add(this.label4);
            this.tabStatic.Controls.Add(this.label3);
            this.tabStatic.Controls.Add(this.label2);
            this.tabStatic.Controls.Add(this.cmbFonts);
            this.tabStatic.Controls.Add(this.label1);
            this.tabStatic.Controls.Add(this.txtInput);
            this.tabStatic.Controls.Add(this.btnSet);
            this.tabStatic.Location = new System.Drawing.Point(4, 22);
            this.tabStatic.Name = "tabStatic";
            this.tabStatic.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatic.Size = new System.Drawing.Size(501, 137);
            this.tabStatic.TabIndex = 0;
            this.tabStatic.Text = "Static";
            this.tabStatic.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.White;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSet.Location = new System.Drawing.Point(421, 102);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Apply";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInput.Location = new System.Drawing.Point(109, 7);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(184, 117);
            this.txtInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reminder text:";
            // 
            // cmbFonts
            // 
            this.cmbFonts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFonts.FormattingEnabled = true;
            this.cmbFonts.Location = new System.Drawing.Point(377, 63);
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new System.Drawing.Size(121, 21);
            this.cmbFonts.TabIndex = 5;
            this.cmbFonts.SelectedIndexChanged += new System.EventHandler(this.cmbFonts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Text color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Font:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Back color:";
            // 
            // btnFrontColor
            // 
            this.btnFrontColor.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnFrontColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrontColor.Location = new System.Drawing.Point(377, 14);
            this.btnFrontColor.Name = "btnFrontColor";
            this.btnFrontColor.Size = new System.Drawing.Size(121, 23);
            this.btnFrontColor.TabIndex = 13;
            this.btnFrontColor.Text = "Select";
            this.btnFrontColor.UseVisualStyleBackColor = true;
            this.btnFrontColor.Click += new System.EventHandler(this.btnFrontColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackColor.Location = new System.Drawing.Point(377, 38);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(121, 23);
            this.btnBackColor.TabIndex = 14;
            this.btnBackColor.Text = "Select";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // checkDynamic
            // 
            this.checkDynamic.AutoSize = true;
            this.checkDynamic.Location = new System.Drawing.Point(10, 44);
            this.checkDynamic.Name = "checkDynamic";
            this.checkDynamic.Size = new System.Drawing.Size(84, 17);
            this.checkDynamic.TabIndex = 15;
            this.checkDynamic.Text = "Set dynamic";
            this.checkDynamic.UseVisualStyleBackColor = true;
            this.checkDynamic.CheckedChanged += new System.EventHandler(this.checkDynamic_CheckedChanged);
            // 
            // checkAppend
            // 
            this.checkAppend.AutoSize = true;
            this.checkAppend.Enabled = false;
            this.checkAppend.Location = new System.Drawing.Point(10, 68);
            this.checkAppend.Name = "checkAppend";
            this.checkAppend.Size = new System.Drawing.Size(63, 17);
            this.checkAppend.TabIndex = 16;
            this.checkAppend.Text = "Append";
            this.checkAppend.UseVisualStyleBackColor = true;
            // 
            // numInterval
            // 
            this.numInterval.Enabled = false;
            this.numInterval.Location = new System.Drawing.Point(58, 89);
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(40, 20);
            this.numInterval.TabIndex = 17;
            this.numInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Interval";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStatic);
            this.tabControl1.Controls.Add(this.tabHelp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 163);
            this.tabControl1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Purple;
            this.linkLabel1.Location = new System.Drawing.Point(8, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub Repository";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contact me: omrfyyz@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 163);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evoker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabHelp.ResumeLayout(false);
            this.tabHelp.PerformLayout();
            this.tabStatic.ResumeLayout(false);
            this.tabStatic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog clrFront;
        private System.Windows.Forms.ColorDialog clrBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage tabStatic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.CheckBox checkAppend;
        private System.Windows.Forms.CheckBox checkDynamic;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnFrontColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFonts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label6;
    }
}


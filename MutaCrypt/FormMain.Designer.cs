namespace MutaCrypt {
    partial class FormMain {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBox_out = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.button_OriginalRight = new System.Windows.Forms.Button();
            this.button_OriginalLeft = new System.Windows.Forms.Button();
            this.button_SelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Close = new System.Windows.Forms.Button();
            this.radioButton_FE_OR = new System.Windows.Forms.RadioButton();
            this.radioButton_FE_SH = new System.Windows.Forms.RadioButton();
            this.radioButton_FE_DE = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_UseSumFact = new System.Windows.Forms.CheckBox();
            this.checkBox_UseSwitchKey = new System.Windows.Forms.CheckBox();
            this.radioButton_FE_NO = new System.Windows.Forms.RadioButton();
            this.radioButton_FN_RN = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_FN_DT = new System.Windows.Forms.RadioButton();
            this.radioButton_FN_OR = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_FE_AddReplace = new System.Windows.Forms.CheckBox();
            this.button_SelectFileForKey = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_out
            // 
            this.textBox_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_out.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox_out.Location = new System.Drawing.Point(9, 193);
            this.textBox_out.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_out.MaxLength = 1048576;
            this.textBox_out.Multiline = true;
            this.textBox_out.Name = "textBox_out";
            this.textBox_out.ReadOnly = true;
            this.textBox_out.Size = new System.Drawing.Size(622, 158);
            this.textBox_out.TabIndex = 1;
            this.textBox_out.Enter += new System.EventHandler(this.textBox_out_Enter);
            this.textBox_out.Leave += new System.EventHandler(this.textBox_out_Leave);
            // 
            // textBox_key
            // 
            this.textBox_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_key.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox_key.Location = new System.Drawing.Point(9, 38);
            this.textBox_key.Margin = new System.Windows.Forms.Padding(0, 0, 12, 6);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(535, 20);
            this.textBox_key.TabIndex = 2;
            this.textBox_key.Text = "Key";
            this.textBox_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_key.Enter += new System.EventHandler(this.textBox_key_Enter);
            this.textBox_key.Leave += new System.EventHandler(this.textBox_key_Leave);
            // 
            // button_OriginalRight
            // 
            this.button_OriginalRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OriginalRight.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_OriginalRight.Location = new System.Drawing.Point(326, 158);
            this.button_OriginalRight.Margin = new System.Windows.Forms.Padding(6, 0, 0, 12);
            this.button_OriginalRight.Name = "button_OriginalRight";
            this.button_OriginalRight.Size = new System.Drawing.Size(305, 23);
            this.button_OriginalRight.TabIndex = 3;
            this.button_OriginalRight.Text = "Original Right";
            this.button_OriginalRight.UseVisualStyleBackColor = true;
            this.button_OriginalRight.Click += new System.EventHandler(this.button_OriginalRight_Click);
            // 
            // button_OriginalLeft
            // 
            this.button_OriginalLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OriginalLeft.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_OriginalLeft.Location = new System.Drawing.Point(9, 158);
            this.button_OriginalLeft.Margin = new System.Windows.Forms.Padding(0, 0, 6, 12);
            this.button_OriginalLeft.Name = "button_OriginalLeft";
            this.button_OriginalLeft.Size = new System.Drawing.Size(305, 23);
            this.button_OriginalLeft.TabIndex = 4;
            this.button_OriginalLeft.Text = "Original Left";
            this.button_OriginalLeft.UseVisualStyleBackColor = true;
            this.button_OriginalLeft.Click += new System.EventHandler(this.button_OriginalLeft_Click);
            // 
            // button_SelectFile
            // 
            this.button_SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SelectFile.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_SelectFile.Location = new System.Drawing.Point(9, 9);
            this.button_SelectFile.Margin = new System.Windows.Forms.Padding(0, 0, 12, 6);
            this.button_SelectFile.Name = "button_SelectFile";
            this.button_SelectFile.Size = new System.Drawing.Size(588, 23);
            this.button_SelectFile.TabIndex = 5;
            this.button_SelectFile.Text = "Select File";
            this.button_SelectFile.UseVisualStyleBackColor = true;
            this.button_SelectFile.Click += new System.EventHandler(this.button_SelectFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderSize = 2;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.ForeColor = System.Drawing.Color.Red;
            this.button_Close.Location = new System.Drawing.Point(609, 9);
            this.button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(22, 22);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // radioButton_FE_OR
            // 
            this.radioButton_FE_OR.AutoSize = true;
            this.radioButton_FE_OR.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton_FE_OR.Location = new System.Drawing.Point(143, -2);
            this.radioButton_FE_OR.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.radioButton_FE_OR.Name = "radioButton_FE_OR";
            this.radioButton_FE_OR.Size = new System.Drawing.Size(82, 17);
            this.radioButton_FE_OR.TabIndex = 7;
            this.radioButton_FE_OR.Text = "Use Original";
            this.radioButton_FE_OR.UseVisualStyleBackColor = true;
            // 
            // radioButton_FE_SH
            // 
            this.radioButton_FE_SH.AutoSize = true;
            this.radioButton_FE_SH.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton_FE_SH.Location = new System.Drawing.Point(237, -2);
            this.radioButton_FE_SH.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.radioButton_FE_SH.Name = "radioButton_FE_SH";
            this.radioButton_FE_SH.Size = new System.Drawing.Size(72, 17);
            this.radioButton_FE_SH.TabIndex = 8;
            this.radioButton_FE_SH.Text = "Use Short";
            this.radioButton_FE_SH.UseVisualStyleBackColor = true;
            // 
            // radioButton_FE_DE
            // 
            this.radioButton_FE_DE.AutoSize = true;
            this.radioButton_FE_DE.Checked = true;
            this.radioButton_FE_DE.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton_FE_DE.Location = new System.Drawing.Point(321, -2);
            this.radioButton_FE_DE.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.radioButton_FE_DE.Name = "radioButton_FE_DE";
            this.radioButton_FE_DE.Size = new System.Drawing.Size(86, 17);
            this.radioButton_FE_DE.TabIndex = 9;
            this.radioButton_FE_DE.TabStop = true;
            this.radioButton_FE_DE.Text = "Use Detailed";
            this.radioButton_FE_DE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "File Ending : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Options : ";
            // 
            // checkBox_UseSumFact
            // 
            this.checkBox_UseSumFact.AutoSize = true;
            this.checkBox_UseSumFact.Checked = true;
            this.checkBox_UseSumFact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_UseSumFact.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_UseSumFact.Location = new System.Drawing.Point(76, 75);
            this.checkBox_UseSumFact.Name = "checkBox_UseSumFact";
            this.checkBox_UseSumFact.Size = new System.Drawing.Size(102, 17);
            this.checkBox_UseSumFact.TabIndex = 12;
            this.checkBox_UseSumFact.Text = "Use Sum Factor";
            this.checkBox_UseSumFact.UseVisualStyleBackColor = true;
            // 
            // checkBox_UseSwitchKey
            // 
            this.checkBox_UseSwitchKey.AutoSize = true;
            this.checkBox_UseSwitchKey.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_UseSwitchKey.Location = new System.Drawing.Point(184, 75);
            this.checkBox_UseSwitchKey.Name = "checkBox_UseSwitchKey";
            this.checkBox_UseSwitchKey.Size = new System.Drawing.Size(101, 17);
            this.checkBox_UseSwitchKey.TabIndex = 13;
            this.checkBox_UseSwitchKey.Text = "Use Switch Key";
            this.checkBox_UseSwitchKey.UseVisualStyleBackColor = true;
            // 
            // radioButton_FE_NO
            // 
            this.radioButton_FE_NO.AutoSize = true;
            this.radioButton_FE_NO.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton_FE_NO.Location = new System.Drawing.Point(80, -2);
            this.radioButton_FE_NO.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.radioButton_FE_NO.Name = "radioButton_FE_NO";
            this.radioButton_FE_NO.Size = new System.Drawing.Size(51, 17);
            this.radioButton_FE_NO.TabIndex = 14;
            this.radioButton_FE_NO.Text = "None";
            this.radioButton_FE_NO.UseVisualStyleBackColor = true;
            // 
            // radioButton_FN_RN
            // 
            this.radioButton_FN_RN.AutoSize = true;
            this.radioButton_FN_RN.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton_FN_RN.Location = new System.Drawing.Point(78, -2);
            this.radioButton_FN_RN.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.radioButton_FN_RN.Name = "radioButton_FN_RN";
            this.radioButton_FN_RN.Size = new System.Drawing.Size(65, 17);
            this.radioButton_FN_RN.TabIndex = 19;
            this.radioButton_FN_RN.Text = "Random";
            this.radioButton_FN_RN.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "File Name  : ";
            // 
            // radioButton_FN_DT
            // 
            this.radioButton_FN_DT.AutoSize = true;
            this.radioButton_FN_DT.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton_FN_DT.Location = new System.Drawing.Point(249, -2);
            this.radioButton_FN_DT.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.radioButton_FN_DT.Name = "radioButton_FN_DT";
            this.radioButton_FN_DT.Size = new System.Drawing.Size(96, 17);
            this.radioButton_FN_DT.TabIndex = 16;
            this.radioButton_FN_DT.Text = "Date And Time";
            this.radioButton_FN_DT.UseVisualStyleBackColor = true;
            // 
            // radioButton_FN_OR
            // 
            this.radioButton_FN_OR.AutoSize = true;
            this.radioButton_FN_OR.Checked = true;
            this.radioButton_FN_OR.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton_FN_OR.Location = new System.Drawing.Point(155, -2);
            this.radioButton_FN_OR.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.radioButton_FN_OR.Name = "radioButton_FN_OR";
            this.radioButton_FN_OR.Size = new System.Drawing.Size(82, 17);
            this.radioButton_FN_OR.TabIndex = 15;
            this.radioButton_FN_OR.TabStop = true;
            this.radioButton_FN_OR.Text = "Use Original";
            this.radioButton_FN_OR.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton_FN_RN);
            this.panel1.Controls.Add(this.radioButton_FN_OR);
            this.panel1.Controls.Add(this.radioButton_FN_DT);
            this.panel1.Location = new System.Drawing.Point(9, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 14);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox_FE_AddReplace);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radioButton_FE_OR);
            this.panel2.Controls.Add(this.radioButton_FE_NO);
            this.panel2.Controls.Add(this.radioButton_FE_SH);
            this.panel2.Controls.Add(this.radioButton_FE_DE);
            this.panel2.Location = new System.Drawing.Point(9, 126);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 14);
            this.panel2.TabIndex = 21;
            // 
            // checkBox_FE_AddReplace
            // 
            this.checkBox_FE_AddReplace.AutoSize = true;
            this.checkBox_FE_AddReplace.Checked = true;
            this.checkBox_FE_AddReplace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FE_AddReplace.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_FE_AddReplace.Location = new System.Drawing.Point(422, -1);
            this.checkBox_FE_AddReplace.Name = "checkBox_FE_AddReplace";
            this.checkBox_FE_AddReplace.Size = new System.Drawing.Size(66, 17);
            this.checkBox_FE_AddReplace.TabIndex = 15;
            this.checkBox_FE_AddReplace.Text = "Replace";
            this.checkBox_FE_AddReplace.UseVisualStyleBackColor = true;
            this.checkBox_FE_AddReplace.CheckedChanged += new System.EventHandler(this.checkBox_FE_AddReplace_CheckedChanged);
            // 
            // button_SelectFileForKey
            // 
            this.button_SelectFileForKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SelectFileForKey.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_SelectFileForKey.Location = new System.Drawing.Point(556, 38);
            this.button_SelectFileForKey.Margin = new System.Windows.Forms.Padding(0, 0, 12, 6);
            this.button_SelectFileForKey.Name = "button_SelectFileForKey";
            this.button_SelectFileForKey.Size = new System.Drawing.Size(75, 23);
            this.button_SelectFileForKey.TabIndex = 22;
            this.button_SelectFileForKey.Text = "Select File";
            this.button_SelectFileForKey.UseVisualStyleBackColor = true;
            this.button_SelectFileForKey.Click += new System.EventHandler(this.button_SelectFileForKey_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.button_SelectFileForKey);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox_UseSwitchKey);
            this.Controls.Add(this.checkBox_UseSumFact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_SelectFile);
            this.Controls.Add(this.button_OriginalLeft);
            this.Controls.Add(this.button_OriginalRight);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.textBox_out);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(420, 244);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MutaCrypt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_out;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Button button_OriginalRight;
        private System.Windows.Forms.Button button_OriginalLeft;
        private System.Windows.Forms.Button button_SelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.RadioButton radioButton_FE_OR;
        private System.Windows.Forms.RadioButton radioButton_FE_SH;
        private System.Windows.Forms.RadioButton radioButton_FE_DE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_UseSumFact;
        private System.Windows.Forms.CheckBox checkBox_UseSwitchKey;
        private System.Windows.Forms.RadioButton radioButton_FE_NO;
        private System.Windows.Forms.RadioButton radioButton_FN_RN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_FN_DT;
        private System.Windows.Forms.RadioButton radioButton_FN_OR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox_FE_AddReplace;
        private System.Windows.Forms.Button button_SelectFileForKey;
    }
}


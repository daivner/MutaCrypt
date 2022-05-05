using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MutaCrypt {
    public partial class FormMain : Form {

        string file = "";
        string fileForKey = "";
        string fileName = "";
        string fileExt = "";

        public FormMain() {
            InitializeComponent();
        }

        private void PrintMessage(Color color, string text) {
            textBox_out.Text += DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + " -> " + text;
            textBox_out.AppendText(Environment.NewLine);
            textBox_out.ForeColor = color;
        }

        private byte[] FileToBytes(string file) {
             byte[] _result;

            using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open))) {
                int length = (int)reader.BaseStream.Length;
                _result = new byte[length];
                for (int i = 0; i < length; i++) {
                    _result[i] = reader.ReadByte();
                }
            }

            return _result;
        }

        private void button_OriginalRight_Click(object sender, EventArgs e) {
            if (File.Exists(file)) {
                string ext = "MCry_OR(";
                ext += checkBox_UseSumFact.Checked ? "_SF" : "";
                ext += checkBox_UseSwitchKey.Checked ? "_SK" : "";
                ext += ")";
                using (BinaryWriter writer = new BinaryWriter(File.Open(extractFilePath() + "\\" + genFileName(extractFileName()) + genFileExt(ext, extractFileExt()), FileMode.Create))) {
                MutaCrypt mutaCrypt = new MutaCrypt((textBox_key.Enabled ? MutaCrypt.StringToByteArray(textBox_key.Text) : FileToBytes(fileForKey)), checkBox_UseSwitchKey.Checked, checkBox_UseSumFact.Checked);
                    using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open))) {
                        UInt64 length = (UInt64)reader.BaseStream.Length;
                        for (UInt64 i = 0; i < length; i++) {
                            writer.Write(mutaCrypt.OriginalRight(reader.ReadByte()));
                        }
                    }
                }
                PrintMessage(Color.LawnGreen, "File '" + extractFilePath() + "\\" + genFileName(extractFileName()) + genFileExt(ext, extractFileExt()) + "' : has been created!");
            } else
                PrintMessage(Color.OrangeRed, "File '" + file + "' : does not exist.");
        }

        private void button_OriginalLeft_Click(object sender, EventArgs e) {
            if (File.Exists(file)) {
                string ext = "MCry_OR(";
                ext += checkBox_UseSumFact.Checked ? "_SF" : "";
                ext += checkBox_UseSwitchKey.Checked ? "_SK" : "";
                ext += ")";
                using (BinaryWriter writer = new BinaryWriter(File.Open(extractFilePath() + "\\" + genFileName(extractFileName()) + "." + genFileExt(ext, extractFileExt()), FileMode.Create))) {
                    MutaCrypt mutaCrypt = new MutaCrypt((textBox_key.Enabled ? MutaCrypt.StringToByteArray(textBox_key.Text) : FileToBytes(fileForKey)), checkBox_UseSwitchKey.Checked, checkBox_UseSumFact.Checked);
                    using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open))) {
                        UInt64 length = (UInt64)reader.BaseStream.Length;
                        for (UInt64 i = 0; i < length; i++) {
                            writer.Write(mutaCrypt.OriginalLeft(reader.ReadByte()));
                        }
                    }
                }
                PrintMessage(Color.LawnGreen, "File '" + extractFilePath() + "\\" + genFileName(extractFileName()) + genFileExt(ext, extractFileExt()) + "' : has been created!");
            } else
                PrintMessage(Color.OrangeRed, "File '" + file + "' : does not exist.");
        }

        private void textBox_out_Enter(object sender, EventArgs e) {
            if (textBox_out.Text == "Texto destino..." && textBox_out.ForeColor == Color.DarkGray) {
                textBox_out.Text = "";
                textBox_out.ForeColor = Color.DeepSkyBlue;
            }
        }

        private void textBox_out_Leave(object sender, EventArgs e) {
            if (textBox_out.Text == "" && textBox_out.ForeColor == Color.DeepSkyBlue) {
                textBox_out.Text = "Texto destino...";
                textBox_out.ForeColor = Color.DarkGray;
            }
        }

        private void textBox_key_Enter(object sender, EventArgs e) {
            if (textBox_key.Text == "Key" && textBox_key.ForeColor == Color.DarkGray) {
                textBox_key.Text = "";
                textBox_key.ForeColor = Color.DeepSkyBlue;
            }
        }

        private void textBox_key_Leave(object sender, EventArgs e) {
            if (textBox_key.Text == "" && textBox_key.ForeColor == Color.DeepSkyBlue) {
                textBox_key.Text = "Key";
                textBox_key.ForeColor = Color.DarkGray;
            }
        }

        private void button_SelectFile_Click(object sender, EventArgs e) {
            if(button_SelectFile.ForeColor == Color.DodgerBlue && button_SelectFile.Text == "Select File") {
                DialogResult dialogResult = openFileDialog1.ShowDialog();
                if (dialogResult == DialogResult.OK) {
                    button_SelectFile.Text = "Discard file";
                    button_SelectFile.ForeColor = Color.DarkRed;
                    file = openFileDialog1.FileName;
                    PrintMessage(Color.DeepSkyBlue, "File To Crypt '" + file + "' Ok!");
                }
            }
            else if(button_SelectFile.Text == "Discard file" && button_SelectFile.ForeColor == Color.DarkRed) {
                button_SelectFile.ForeColor = Color.DodgerBlue;
                button_SelectFile.Text = "Select File";
                PrintMessage(Color.DarkGray, "No File Selected.");
                file = "";
            }
        }

        private void button_SelectFileForKey_Click(object sender, EventArgs e) {
            if (button_SelectFileForKey.ForeColor == Color.DodgerBlue && button_SelectFileForKey.Text == "Select File") {
                DialogResult dialogResult = openFileDialog1.ShowDialog();
                if (dialogResult == DialogResult.OK) {
                    button_SelectFileForKey.Text = "Discard file";
                    button_SelectFileForKey.ForeColor = Color.DarkRed;
                    fileForKey = openFileDialog1.FileName;
                    PrintMessage(Color.DeepSkyBlue, "File For Key '" + fileForKey + "' Ok!");
                    textBox_key.Text = "File For Key Selected";
                    textBox_key.ForeColor = Color.DarkGray;
                    textBox_key.Enabled = false;
                }
            } else if (button_SelectFileForKey.Text == "Discard file" && button_SelectFileForKey.ForeColor == Color.DarkRed) {
                button_SelectFileForKey.ForeColor = Color.DodgerBlue;
                button_SelectFileForKey.Text = "Select File";
                PrintMessage(Color.DarkGray, "No File For Key Selected.");
                fileForKey = "";
                textBox_key.Text = "Key";
                textBox_key.ForeColor = Color.DarkGray;
                textBox_key.Enabled = true;
            }
        }

        private void button_Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void checkBox_FE_AddReplace_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_FE_AddReplace.Checked) {
                if (checkBox_FE_AddReplace.Text == "Add")
                    checkBox_FE_AddReplace.Text = "Replace";
                else if (checkBox_FE_AddReplace.Text == "Replace")
                    checkBox_FE_AddReplace.Text = "Add";
            }
            checkBox_FE_AddReplace.Checked = true;
        }

        /// <summary>
        /// Generate a random string for using it as a file name
        /// </summary>
        /// <returns>Return a string lengt(4-64) with raandom chars, with a filter to be used as name in Windows file system</returns>
        private string genRandomName() {
            Random r1 = new Random();
            Random r2 = new Random();
            string reslut = "";
            int length = (r1.Next(4, 64));
            
            for (int i = 0; i < length; i++) {
                int j = r2.Next(32, 126);
                while(
                    j == 34 // "
                    || j == 42 // *
                    || j == 47  // / 
                    || j == 58 // :
                    || j == 60 // <
                    || j == 62 // >
                    || j == 63 // ?
                    || j == 92 // \ 
                    || j == 124) // |
                    
                    j = r2.Next(32, 126);
                reslut += (char)j;
            }
            return reslut;
        }

        /// <summary>
        /// Gets the date and time from now in a constant for log and naming
        /// </summary>
        /// <returns>Return the DateTime from now in format yy-MM-dd--HH-mm-ss</returns>
        private string genDateTimeName() {
            return DateTime.Now.ToString("yy-MM-dd--HH-mm-ss");
        }

        private string extractFilePath() {
            string[] result;
            result = file.Split('\\');
            for (int i = 1; i < result.Length - 1; i++) {
                result[0] += "\\" + result[i];
            }
            return result[0];
        }

        private string extractFileName() {
            string[] result;
            result = file.Split('\\');
            if (result[result.Length - 1].Contains(".")) {
                result = result[result.Length - 1].Split('.');
                for (int i = 1; i < result.Length - 1; i++) {
                    result[0] += "." + result[i];
                }
                return result[0];

            } else
                return result[result.Length - 1];
        }

        private string extractFileExt() {
            string[] result;
            result = file.Split('\\');
            if (result[result.Length - 1].Contains(".")) {
                result = result[result.Length - 1].Split('.');
                return result[result.Length - 1];
            } else
                return "";
        }

        private string genFileName(string original) {
            if (radioButton_FN_RN.Checked)
                fileName = genRandomName();
            else if (radioButton_FN_DT.Checked)
                fileName = genDateTimeName();
            else if (radioButton_FN_OR.Checked)
                fileName = original;
            return fileName;
        }

        private string genFileExt(string detailed, string original) {
            if (radioButton_FE_NO.Checked)
                fileExt = "";
            else if (radioButton_FE_OR.Checked)
                fileExt = original;
            else if (radioButton_FE_SH.Checked)
                fileExt = (original != "" ? "." + original : "") + ".MCry";
            else if (radioButton_FE_DE.Checked)
                fileExt = (original != "" ? "." + original : "") + "." + detailed;
            
            return fileExt;
        }

        
    }
}

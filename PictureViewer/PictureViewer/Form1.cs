using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e){
            // Close the form.
            Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e){
        }

        private void ShowButton_Click(object sender, EventArgs e){
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void BackgroundButton_Click(object sender, EventArgs e){
            // Show the color dialog box. If the user clicks OK, chnge the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK){
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e){
            // Clear the picture
            pictureBox1.Image = null;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e){
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e){
            // If the user selects the Stretch check box, change
            // the PictureBox's SizeMode property to "Stretch". If the user
            // clears the check box, change it to "Normal".
            if (checkBox1.Checked){
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else{
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
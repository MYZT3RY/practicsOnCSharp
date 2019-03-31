using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        private void StartSoundPlayer(){
            new System.Media.SoundPlayer("C:\\Windows\\Media\\chord.wav").Play();
        }

        private void FinishSoundPlayer(){
            new System.Media.SoundPlayer("C:\\Windows\\Media\\tada.wav").Play();
        }

        public Form1(){
            InitializeComponent();
            MoveToStart();
        }

        private void label1_Click(object sender, EventArgs e){

        }

        private void FinishLabel_MouseEnter(object sender, EventArgs e){
            // Show a congratulatory MessageBox, then close the form.
            MessageBox.Show("Поздравляем!\nВы прошли лабиринт!");
            Close();
        }

        private void MoveToStart(){
            StartSoundPlayer();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void Wall_MouseEnter(object sender, EventArgs e){
            // When the mouse pointer hits a wall or enters the panel,
            // call the MoveToStart() method.
            FinishSoundPlayer();
            MoveToStart();
        }
    }
}

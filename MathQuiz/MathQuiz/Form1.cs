using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        Random ran = new Random();

        private int AddEnd1;
        private int AddEnd2;
        private int minuend;
        private int subtrahend;
        private int multiplicand;
        private int multiplier;
        private int dividend;
        private int divisor;
        private int timeLeft;

        public void StartTheQuiz(){
            AddEnd1 = ran.Next(51);
            AddEnd2 = ran.Next(51);
            PlusLeftLabel.Text = AddEnd1.ToString();
            PlusRigthLabel.Text = AddEnd2.ToString();
            Sum.Value = 0;

            minuend = ran.Next(1,101);
            subtrahend = ran.Next(1, minuend);
            MinusLeftLabel.Text = minuend.ToString();
            MinusRigthLabel.Text = subtrahend.ToString();
            Difference.Value = 0;

            multiplicand = ran.Next(1, 11);
            multiplier = ran.Next(1, 11);
            TimesLeftLabel.Text = multiplicand.ToString();
            TimesRigthLabel.Text = multiplier.ToString();
            Product.Value = 0;

            divisor = ran.Next(2, 11);
            int temporaryQuotient = ran.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            DividedLeftLabel.Text = dividend.ToString();
            DividedRigthLabel.Text = divisor.ToString();
            Quotient.Value = 0;

            timeLeft = 30;
            TimeLabel.Text = "30 секунд";
            Timer1.Start();
        }

        public bool CheckTheAnswer(){
            if (((AddEnd1 + AddEnd2) == Sum.Value) && ((minuend - subtrahend) == Difference.Value) && ((multiplicand * multiplier) == Product.Value && ((dividend / divisor) == Quotient.Value))){
                return true;
            }

            else{
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Sum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e){
            StartTheQuiz();
            StartButton.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            if (CheckTheAnswer()){
                Timer1.Stop();
                MessageBox.Show("Все ответы правильные!","Ох");
                StartButton.Enabled = true;
            }
            else if(timeLeft > 0){
                timeLeft -= 1;
                TimeLabel.Text = timeLeft + " секунд";
                if(timeLeft == 5){
                    TimeLabel.BackColor = Color.Red;
                }
            }
            else{
                Timer1.Stop();
                TimeLabel.Text = "Время вышло";
                MessageBox.Show("Вы не уложились по времени","Ох");
                Sum.Value = AddEnd1 + AddEnd2;
                Difference.Value = minuend - subtrahend;
                Product.Value = multiplicand * multiplier;
                Quotient.Value = dividend / divisor;
                TimeLabel.BackColor = Color.Empty;
                StartButton.Enabled = true;
            }
        }

        private void Answer_Enter(object sender, EventArgs e){
            if (sender is NumericUpDown answerBox){
                var lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}

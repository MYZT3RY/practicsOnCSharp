namespace MathQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlusLeftLabel = new System.Windows.Forms.Label();
            this.PlusLabel = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.NumericUpDown();
            this.PlusRigthLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinusRigthLabel = new System.Windows.Forms.Label();
            this.Difference = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.MinusLeftLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimesRigthLabel = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.TimesLeftLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DividedRigthLabel = new System.Windows.Forms.Label();
            this.Quotient = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.DividedLeftLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TimeLabel.Location = new System.Drawing.Point(322, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(200, 30);
            this.TimeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(114, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оставшееся время";
            // 
            // PlusLeftLabel
            // 
            this.PlusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PlusLeftLabel.Location = new System.Drawing.Point(75, 75);
            this.PlusLeftLabel.Name = "PlusLeftLabel";
            this.PlusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusLeftLabel.TabIndex = 2;
            this.PlusLeftLabel.Text = "?";
            this.PlusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusLabel
            // 
            this.PlusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PlusLabel.Location = new System.Drawing.Point(141, 75);
            this.PlusLabel.Name = "PlusLabel";
            this.PlusLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusLabel.TabIndex = 3;
            this.PlusLabel.Text = "+";
            this.PlusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Sum.Location = new System.Drawing.Point(339, 84);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 35);
            this.Sum.TabIndex = 2;
            this.Sum.ValueChanged += new System.EventHandler(this.Sum_ValueChanged);
            this.Sum.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // PlusRigthLabel
            // 
            this.PlusRigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PlusRigthLabel.Location = new System.Drawing.Point(207, 75);
            this.PlusRigthLabel.Name = "PlusRigthLabel";
            this.PlusRigthLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusRigthLabel.TabIndex = 5;
            this.PlusRigthLabel.Text = "?";
            this.PlusRigthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(273, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(273, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinusRigthLabel
            // 
            this.MinusRigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.MinusRigthLabel.Location = new System.Drawing.Point(207, 125);
            this.MinusRigthLabel.Name = "MinusRigthLabel";
            this.MinusRigthLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusRigthLabel.TabIndex = 10;
            this.MinusRigthLabel.Text = "?";
            this.MinusRigthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Difference
            // 
            this.Difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Difference.Location = new System.Drawing.Point(339, 134);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(100, 35);
            this.Difference.TabIndex = 3;
            this.Difference.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(141, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinusLeftLabel
            // 
            this.MinusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.MinusLeftLabel.Location = new System.Drawing.Point(75, 125);
            this.MinusLeftLabel.Name = "MinusLeftLabel";
            this.MinusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusLeftLabel.TabIndex = 7;
            this.MinusLeftLabel.Text = "?";
            this.MinusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(273, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 16;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimesRigthLabel
            // 
            this.TimesRigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TimesRigthLabel.Location = new System.Drawing.Point(207, 175);
            this.TimesRigthLabel.Name = "TimesRigthLabel";
            this.TimesRigthLabel.Size = new System.Drawing.Size(60, 50);
            this.TimesRigthLabel.TabIndex = 15;
            this.TimesRigthLabel.Text = "?";
            this.TimesRigthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Product.Location = new System.Drawing.Point(339, 184);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(100, 35);
            this.Product.TabIndex = 4;
            this.Product.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(141, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 13;
            this.label7.Text = "×";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimesLeftLabel
            // 
            this.TimesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TimesLeftLabel.Location = new System.Drawing.Point(75, 175);
            this.TimesLeftLabel.Name = "TimesLeftLabel";
            this.TimesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.TimesLeftLabel.TabIndex = 12;
            this.TimesLeftLabel.Text = "?";
            this.TimesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.Location = new System.Drawing.Point(273, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 21;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DividedRigthLabel
            // 
            this.DividedRigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.DividedRigthLabel.Location = new System.Drawing.Point(207, 225);
            this.DividedRigthLabel.Name = "DividedRigthLabel";
            this.DividedRigthLabel.Size = new System.Drawing.Size(60, 50);
            this.DividedRigthLabel.TabIndex = 20;
            this.DividedRigthLabel.Text = "?";
            this.DividedRigthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quotient
            // 
            this.Quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Quotient.Location = new System.Drawing.Point(339, 234);
            this.Quotient.Name = "Quotient";
            this.Quotient.Size = new System.Drawing.Size(100, 35);
            this.Quotient.TabIndex = 5;
            this.Quotient.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label11.Location = new System.Drawing.Point(141, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 18;
            this.label11.Text = "÷";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DividedLeftLabel
            // 
            this.DividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.DividedLeftLabel.Location = new System.Drawing.Point(75, 225);
            this.DividedLeftLabel.Name = "DividedLeftLabel";
            this.DividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.DividedLeftLabel.TabIndex = 17;
            this.DividedLeftLabel.Text = "?";
            this.DividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.StartButton.Location = new System.Drawing.Point(168, 465);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(204, 34);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Запуск головоломки";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DividedRigthLabel);
            this.Controls.Add(this.Quotient);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DividedLeftLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimesRigthLabel);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TimesLeftLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinusRigthLabel);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MinusLeftLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlusRigthLabel);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.PlusLabel);
            this.Controls.Add(this.PlusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Математическая головоломка";
            this.Enter += new System.EventHandler(this.Answer_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlusLeftLabel;
        private System.Windows.Forms.Label PlusLabel;
        private System.Windows.Forms.NumericUpDown Sum;
        private System.Windows.Forms.Label PlusRigthLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MinusRigthLabel;
        private System.Windows.Forms.NumericUpDown Difference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MinusLeftLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TimesRigthLabel;
        private System.Windows.Forms.NumericUpDown Product;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TimesLeftLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DividedRigthLabel;
        private System.Windows.Forms.NumericUpDown Quotient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DividedLeftLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer Timer1;
    }
}


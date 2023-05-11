namespace WinFormsApp1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBox = new TextBox();
            ButtonPanel = new Panel();
            ButtonPoint = new Button();
            ButtonZero = new Button();
            ButtonNine = new Button();
            ButtonEight = new Button();
            ButtonSeven = new Button();
            ButtonSix = new Button();
            ButtonFive = new Button();
            ButtonFour = new Button();
            ButtonThree = new Button();
            ButtonTwo = new Button();
            ButtonOne = new Button();
            ButtonClear = new Button();
            ButtonClearE = new Button();
            ButtonProcent = new Button();
            ButtonDevide = new Button();
            ButtonMultiply = new Button();
            ButtonMinus = new Button();
            ButtonPlus = new Button();
            ButtonEqually = new Button();
            plusminus = new Button();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Dock = DockStyle.Top;
            TextBox.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox.Location = new Point(0, 0);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(384, 65);
            TextBox.TabIndex = 0;
            TextBox.Text = "0";
            TextBox.TextAlign = HorizontalAlignment.Right;
            TextBox.KeyPress += TextBox_KeyPress;
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = SystemColors.AppWorkspace;
            ButtonPanel.Controls.Add(plusminus);
            ButtonPanel.Controls.Add(ButtonPoint);
            ButtonPanel.Controls.Add(ButtonZero);
            ButtonPanel.Controls.Add(ButtonNine);
            ButtonPanel.Controls.Add(ButtonEight);
            ButtonPanel.Controls.Add(ButtonSeven);
            ButtonPanel.Controls.Add(ButtonSix);
            ButtonPanel.Controls.Add(ButtonFive);
            ButtonPanel.Controls.Add(ButtonFour);
            ButtonPanel.Controls.Add(ButtonThree);
            ButtonPanel.Controls.Add(ButtonTwo);
            ButtonPanel.Controls.Add(ButtonOne);
            ButtonPanel.Controls.Add(ButtonClear);
            ButtonPanel.Controls.Add(ButtonClearE);
            ButtonPanel.Controls.Add(ButtonProcent);
            ButtonPanel.Controls.Add(ButtonDevide);
            ButtonPanel.Controls.Add(ButtonMultiply);
            ButtonPanel.Controls.Add(ButtonMinus);
            ButtonPanel.Controls.Add(ButtonPlus);
            ButtonPanel.Controls.Add(ButtonEqually);
            ButtonPanel.Dock = DockStyle.Top;
            ButtonPanel.Location = new Point(0, 65);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(384, 497);
            ButtonPanel.TabIndex = 1;
            // 
            // ButtonPoint
            // 
            ButtonPoint.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPoint.Location = new Point(175, 383);
            ButtonPoint.Name = "ButtonPoint";
            ButtonPoint.Size = new Size(85, 85);
            ButtonPoint.TabIndex = 30;
            ButtonPoint.Text = ",";
            ButtonPoint.UseVisualStyleBackColor = true;
            ButtonPoint.Click += ButtonPoint_Click_1;
            // 
            // ButtonZero
            // 
            ButtonZero.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonZero.Location = new Point(12, 383);
            ButtonZero.Name = "ButtonZero";
            ButtonZero.Size = new Size(85, 85);
            ButtonZero.TabIndex = 28;
            ButtonZero.Text = "0";
            ButtonZero.UseVisualStyleBackColor = true;
            ButtonZero.Click += ButtonPoint_Click;
            // 
            // ButtonNine
            // 
            ButtonNine.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNine.Location = new Point(175, 128);
            ButtonNine.Name = "ButtonNine";
            ButtonNine.Size = new Size(85, 85);
            ButtonNine.TabIndex = 27;
            ButtonNine.Text = "9";
            ButtonNine.UseVisualStyleBackColor = true;
            ButtonNine.Click += ButtonPoint_Click;
            // 
            // ButtonEight
            // 
            ButtonEight.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEight.Location = new Point(94, 128);
            ButtonEight.Name = "ButtonEight";
            ButtonEight.Size = new Size(85, 85);
            ButtonEight.TabIndex = 26;
            ButtonEight.Text = "8";
            ButtonEight.UseVisualStyleBackColor = true;
            ButtonEight.Click += ButtonPoint_Click;
            // 
            // ButtonSeven
            // 
            ButtonSeven.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSeven.Location = new Point(12, 128);
            ButtonSeven.Name = "ButtonSeven";
            ButtonSeven.Size = new Size(85, 85);
            ButtonSeven.TabIndex = 25;
            ButtonSeven.Text = "7";
            ButtonSeven.UseVisualStyleBackColor = true;
            ButtonSeven.Click += ButtonPoint_Click;
            // 
            // ButtonSix
            // 
            ButtonSix.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSix.Location = new Point(175, 210);
            ButtonSix.Name = "ButtonSix";
            ButtonSix.Size = new Size(85, 85);
            ButtonSix.TabIndex = 24;
            ButtonSix.Text = "6";
            ButtonSix.UseVisualStyleBackColor = true;
            ButtonSix.Click += ButtonPoint_Click;
            // 
            // ButtonFive
            // 
            ButtonFive.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonFive.Location = new Point(94, 210);
            ButtonFive.Name = "ButtonFive";
            ButtonFive.Size = new Size(85, 85);
            ButtonFive.TabIndex = 23;
            ButtonFive.Text = "5";
            ButtonFive.UseVisualStyleBackColor = true;
            ButtonFive.Click += ButtonPoint_Click;
            // 
            // ButtonFour
            // 
            ButtonFour.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonFour.Location = new Point(12, 210);
            ButtonFour.Name = "ButtonFour";
            ButtonFour.Size = new Size(85, 85);
            ButtonFour.TabIndex = 22;
            ButtonFour.Text = "4";
            ButtonFour.UseVisualStyleBackColor = true;
            ButtonFour.Click += ButtonPoint_Click;
            // 
            // ButtonThree
            // 
            ButtonThree.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonThree.Location = new Point(175, 292);
            ButtonThree.Name = "ButtonThree";
            ButtonThree.Size = new Size(85, 85);
            ButtonThree.TabIndex = 21;
            ButtonThree.Text = "3";
            ButtonThree.UseVisualStyleBackColor = true;
            ButtonThree.Click += ButtonPoint_Click;
            // 
            // ButtonTwo
            // 
            ButtonTwo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonTwo.Location = new Point(94, 292);
            ButtonTwo.Name = "ButtonTwo";
            ButtonTwo.Size = new Size(85, 85);
            ButtonTwo.TabIndex = 20;
            ButtonTwo.Text = "2";
            ButtonTwo.UseVisualStyleBackColor = true;
            ButtonTwo.Click += ButtonPoint_Click;
            // 
            // ButtonOne
            // 
            ButtonOne.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonOne.Location = new Point(12, 292);
            ButtonOne.Name = "ButtonOne";
            ButtonOne.Size = new Size(85, 85);
            ButtonOne.TabIndex = 19;
            ButtonOne.Text = "1";
            ButtonOne.UseVisualStyleBackColor = true;
            ButtonOne.Click += ButtonPoint_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClear.Location = new Point(12, 37);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(85, 85);
            ButtonClear.TabIndex = 18;
            ButtonClear.Text = "C";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // ButtonClearE
            // 
            ButtonClearE.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClearE.Location = new Point(94, 37);
            ButtonClearE.Name = "ButtonClearE";
            ButtonClearE.Size = new Size(85, 85);
            ButtonClearE.TabIndex = 17;
            ButtonClearE.Text = "CE";
            ButtonClearE.UseVisualStyleBackColor = true;
            ButtonClearE.Click += ButtonClearE_Click;
            // 
            // ButtonProcent
            // 
            ButtonProcent.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonProcent.Location = new Point(175, 37);
            ButtonProcent.Name = "ButtonProcent";
            ButtonProcent.Size = new Size(85, 85);
            ButtonProcent.TabIndex = 16;
            ButtonProcent.Text = "%";
            ButtonProcent.UseVisualStyleBackColor = true;
            ButtonProcent.Click += ButtonProcent_Click;
            // 
            // ButtonDevide
            // 
            ButtonDevide.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDevide.Location = new Point(287, 37);
            ButtonDevide.Name = "ButtonDevide";
            ButtonDevide.Size = new Size(85, 85);
            ButtonDevide.TabIndex = 15;
            ButtonDevide.Text = "/";
            ButtonDevide.UseVisualStyleBackColor = true;
            ButtonDevide.Click += ButtonProcent_Click;
            // 
            // ButtonMultiply
            // 
            ButtonMultiply.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMultiply.Location = new Point(287, 128);
            ButtonMultiply.Name = "ButtonMultiply";
            ButtonMultiply.Size = new Size(85, 85);
            ButtonMultiply.TabIndex = 14;
            ButtonMultiply.Text = "*";
            ButtonMultiply.UseVisualStyleBackColor = true;
            ButtonMultiply.Click += ButtonProcent_Click;
            // 
            // ButtonMinus
            // 
            ButtonMinus.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMinus.Location = new Point(287, 210);
            ButtonMinus.Name = "ButtonMinus";
            ButtonMinus.Size = new Size(85, 85);
            ButtonMinus.TabIndex = 13;
            ButtonMinus.Text = "-";
            ButtonMinus.UseVisualStyleBackColor = true;
            ButtonMinus.Click += ButtonProcent_Click;
            // 
            // ButtonPlus
            // 
            ButtonPlus.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPlus.Location = new Point(287, 292);
            ButtonPlus.Name = "ButtonPlus";
            ButtonPlus.Size = new Size(85, 85);
            ButtonPlus.TabIndex = 12;
            ButtonPlus.Text = "+";
            ButtonPlus.UseVisualStyleBackColor = true;
            ButtonPlus.Click += ButtonProcent_Click;
            // 
            // ButtonEqually
            // 
            ButtonEqually.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEqually.Location = new Point(287, 383);
            ButtonEqually.Name = "ButtonEqually";
            ButtonEqually.Size = new Size(85, 85);
            ButtonEqually.TabIndex = 11;
            ButtonEqually.Text = "=";
            ButtonEqually.UseVisualStyleBackColor = true;
            ButtonEqually.Click += ButtonEqually_Click;
            // 
            // plusminus
            // 
            plusminus.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            plusminus.Location = new Point(94, 383);
            plusminus.Name = "plusminus";
            plusminus.Size = new Size(85, 85);
            plusminus.TabIndex = 31;
            plusminus.Text = "+/-";
            plusminus.UseVisualStyleBackColor = true;
            plusminus.Click += plusminus_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(ButtonPanel);
            Controls.Add(TextBox);
            MaximizeBox = false;
            Name = "Main";
            Text = "Калькулятор";
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox;
        private Panel ButtonPanel;
        private Button ButtonClear;
        private Button ButtonClearE;
        private Button ButtonProcent;
        private Button ButtonDevide;
        private Button ButtonMultiply;
        private Button ButtonMinus;
        private Button ButtonPlus;
        private Button ButtonEqually;
        private Button ButtonZero;
        private Button ButtonNine;
        private Button ButtonEight;
        private Button ButtonSeven;
        private Button ButtonSix;
        private Button ButtonFive;
        private Button ButtonFour;
        private Button ButtonThree;
        private Button ButtonTwo;
        private Button ButtonOne;
        private Button ButtonPoint;
        private Button plusminus;
    }
}
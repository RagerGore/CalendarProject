namespace CalendarApp
{
    partial class Form1
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
            DayContainer = new FlowLayoutPanel();
            DayLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            PreviousButton = new Button();
            NextButton = new Button();
            YearAndMonthLabel = new Label();
            SuspendLayout();
            // 
            // DayContainer
            // 
            DayContainer.Location = new Point(12, 87);
            DayContainer.Name = "DayContainer";
            DayContainer.Size = new Size(1294, 623);
            DayContainer.TabIndex = 0;
            // 
            // DayLabel
            // 
            DayLabel.AutoSize = true;
            DayLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayLabel.Location = new Point(12, 61);
            DayLabel.Name = "DayLabel";
            DayLabel.Size = new Size(87, 23);
            DayLabel.TabIndex = 0;
            DayLabel.Text = "Monday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 61);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 1;
            label1.Text = "Tuesday";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(383, 61);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 2;
            label2.Text = "Wesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(567, 61);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 3;
            label3.Text = "Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(751, 61);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 4;
            label4.Text = "Friday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(935, 61);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 5;
            label5.Text = "Saturday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1119, 61);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 6;
            label6.Text = "Sunday";
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new Point(12, 725);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(94, 29);
            PreviousButton.TabIndex = 7;
            PreviousButton.Text = "Previous";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(1212, 725);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(94, 29);
            NextButton.TabIndex = 8;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // YearAndMonthLabel
            // 
            YearAndMonthLabel.AutoSize = true;
            YearAndMonthLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
            YearAndMonthLabel.Location = new Point(544, 9);
            YearAndMonthLabel.Name = "YearAndMonthLabel";
            YearAndMonthLabel.Size = new Size(168, 35);
            YearAndMonthLabel.TabIndex = 10;
            YearAndMonthLabel.Text = "YearMonth";
            YearAndMonthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1318, 766);
            Controls.Add(YearAndMonthLabel);
            Controls.Add(NextButton);
            Controls.Add(PreviousButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DayLabel);
            Controls.Add(DayContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel DayContainer;
        private Label DayLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button PreviousButton;
        private Button NextButton;
        private Label YearAndMonthLabel;
    }
}

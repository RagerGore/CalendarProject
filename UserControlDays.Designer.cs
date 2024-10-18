namespace CalendarApp
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TemporaryText = new Label();
            DayNumber = new Label();
            SuspendLayout();
            // 
            // TemporaryText
            // 
            TemporaryText.AutoSize = true;
            TemporaryText.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TemporaryText.Location = new Point(64, 41);
            TemporaryText.Name = "TemporaryText";
            TemporaryText.Size = new Size(51, 17);
            TemporaryText.TabIndex = 1;
            TemporaryText.Text = "Empty";
            // 
            // DayNumber
            // 
            DayNumber.AutoSize = true;
            DayNumber.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayNumber.Location = new Point(0, 0);
            DayNumber.Name = "DayNumber";
            DayNumber.Size = new Size(21, 21);
            DayNumber.TabIndex = 2;
            DayNumber.Text = "0";
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(DayNumber);
            Controls.Add(TemporaryText);
            Name = "UserControlDays";
            Size = new Size(178, 98);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TemporaryText;
        private Label DayNumber;
    }
}

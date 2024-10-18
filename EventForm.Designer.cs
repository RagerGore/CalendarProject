namespace CalendarApp
{
    partial class EventForm
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
            txevent = new TextBox();
            label1 = new Label();
            SaveButton = new Button();
            label2 = new Label();
            txdate = new TextBox();
            SuspendLayout();
            // 
            // txevent
            // 
            txevent.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txevent.Location = new Point(66, 296);
            txevent.Name = "txevent";
            txevent.Size = new Size(674, 30);
            txevent.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 258);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "Event";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(646, 385);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 39);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 4;
            label2.Text = "Date";
            // 
            // txdate
            // 
            txdate.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txdate.Location = new Point(66, 77);
            txdate.Name = "txdate";
            txdate.ReadOnly = true;
            txdate.Size = new Size(674, 30);
            txdate.TabIndex = 3;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txdate);
            Controls.Add(SaveButton);
            Controls.Add(label1);
            Controls.Add(txevent);
            Name = "EventForm";
            Text = "EventForm";
            Load += EventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txevent;
        private Label label1;
        private Button SaveButton;
        private Label label2;
        private TextBox txdate;
    }
}
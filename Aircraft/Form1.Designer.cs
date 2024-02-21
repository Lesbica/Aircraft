namespace Aircraft
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
            btnAddWing = new Button();
            btnAddEngine = new Button();
            btnAddAirframe = new Button();
            SuspendLayout();
            // 
            // btnAddWing
            // 
            btnAddWing.Location = new Point(602, 12);
            btnAddWing.Name = "btnAddWing";
            btnAddWing.Size = new Size(139, 51);
            btnAddWing.TabIndex = 0;
            btnAddWing.Text = "AddWing";
            btnAddWing.UseVisualStyleBackColor = true;
            btnAddWing.Click += btnAddWing_Click;
            // 
            // btnAddEngine
            // 
            btnAddEngine.Location = new Point(602, 85);
            btnAddEngine.Name = "btnAddEngine";
            btnAddEngine.Size = new Size(139, 51);
            btnAddEngine.TabIndex = 1;
            btnAddEngine.Text = "AddEngine";
            btnAddEngine.UseVisualStyleBackColor = true;
            btnAddEngine.Click += btnAddEngine_Click;
            // 
            // btnAddAirframe
            // 
            btnAddAirframe.Location = new Point(602, 159);
            btnAddAirframe.Name = "btnAddAirframe";
            btnAddAirframe.Size = new Size(139, 51);
            btnAddAirframe.TabIndex = 2;
            btnAddAirframe.Text = "AddAirframe";
            btnAddAirframe.UseVisualStyleBackColor = true;
            btnAddAirframe.Click += btnAddAirframe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddAirframe);
            Controls.Add(btnAddEngine);
            Controls.Add(btnAddWing);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddWing;
        private Button btnAddEngine;
        private Button btnAddAirframe;
    }
}

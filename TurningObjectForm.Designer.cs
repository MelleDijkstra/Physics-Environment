namespace Physics_Environment
{
    partial class TurningObjectForm
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
            this.components = new System.ComponentModel.Container();
            this.theLoop = new System.Windows.Forms.Timer(this.components);
            this.timerStateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // theLoop
            // 
            this.theLoop.Enabled = true;
            this.theLoop.Interval = 10;
            this.theLoop.Tick += new System.EventHandler(this.theLoop_Tick);
            // 
            // timerStateLabel
            // 
            this.timerStateLabel.AutoSize = true;
            this.timerStateLabel.BackColor = System.Drawing.Color.Black;
            this.timerStateLabel.ForeColor = System.Drawing.Color.Red;
            this.timerStateLabel.Location = new System.Drawing.Point(5, 31);
            this.timerStateLabel.Name = "timerStateLabel";
            this.timerStateLabel.Padding = new System.Windows.Forms.Padding(5);
            this.timerStateLabel.Size = new System.Drawing.Size(57, 23);
            this.timerStateLabel.TabIndex = 0;
            this.timerStateLabel.Text = "Running";
            // 
            // TurningObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 537);
            this.Controls.Add(this.timerStateLabel);
            this.DoubleBuffered = true;
            this.Name = "TurningObjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurningObjectForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhysicsForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer theLoop;
        private System.Windows.Forms.Label timerStateLabel;
    }
}
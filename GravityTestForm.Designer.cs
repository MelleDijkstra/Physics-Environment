namespace Physics_Environment
{
    partial class GravityTestForm
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
            this.SuspendLayout();
            // 
            // theLoop
            // 
            this.theLoop.Enabled = true;
            this.theLoop.Interval = 10;
            this.theLoop.Tick += new System.EventHandler(this.theLoop_Tick);
            // 
            // GravityTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 491);
            this.DoubleBuffered = true;
            this.Name = "GravityTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GravityTestForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GravityTestForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GravityTestForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer theLoop;
    }
}
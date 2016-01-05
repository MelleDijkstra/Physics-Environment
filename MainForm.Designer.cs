namespace Physics_Environment
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.startTurnBallBtn = new System.Windows.Forms.Button();
            this.startGravityTest = new System.Windows.Forms.Button();
            this.startBorderBouncingForm = new System.Windows.Forms.Button();
            this.startJumpingForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physics Environment";
            // 
            // startTurnBallBtn
            // 
            this.startTurnBallBtn.Location = new System.Drawing.Point(23, 107);
            this.startTurnBallBtn.Name = "startTurnBallBtn";
            this.startTurnBallBtn.Size = new System.Drawing.Size(147, 45);
            this.startTurnBallBtn.TabIndex = 1;
            this.startTurnBallBtn.Text = "Trigonometric Turning\r\n(Turning of an object)";
            this.startTurnBallBtn.UseVisualStyleBackColor = true;
            this.startTurnBallBtn.Click += new System.EventHandler(this.startTurningFormBtn_Click);
            // 
            // startGravityTest
            // 
            this.startGravityTest.Location = new System.Drawing.Point(193, 107);
            this.startGravityTest.Name = "startGravityTest";
            this.startGravityTest.Size = new System.Drawing.Size(147, 45);
            this.startGravityTest.TabIndex = 2;
            this.startGravityTest.Text = "Gravity\r\n(FallingState of object)";
            this.startGravityTest.UseVisualStyleBackColor = true;
            this.startGravityTest.Click += new System.EventHandler(this.startGravityTest_Click);
            // 
            // startBorderBouncingForm
            // 
            this.startBorderBouncingForm.Location = new System.Drawing.Point(363, 107);
            this.startBorderBouncingForm.Name = "startBorderBouncingForm";
            this.startBorderBouncingForm.Size = new System.Drawing.Size(147, 45);
            this.startBorderBouncingForm.TabIndex = 3;
            this.startBorderBouncingForm.Text = "Border Bouncing (Collision detection)";
            this.startBorderBouncingForm.UseVisualStyleBackColor = true;
            this.startBorderBouncingForm.Click += new System.EventHandler(this.startBorderBouncingForm_Click);
            // 
            // startJumpingForm
            // 
            this.startJumpingForm.Location = new System.Drawing.Point(23, 177);
            this.startJumpingForm.Name = "startJumpingForm";
            this.startJumpingForm.Size = new System.Drawing.Size(147, 45);
            this.startJumpingForm.TabIndex = 4;
            this.startJumpingForm.Text = "Jumping";
            this.startJumpingForm.UseVisualStyleBackColor = true;
            this.startJumpingForm.Click += new System.EventHandler(this.startJumpingForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 252);
            this.Controls.Add(this.startJumpingForm);
            this.Controls.Add(this.startBorderBouncingForm);
            this.Controls.Add(this.startGravityTest);
            this.Controls.Add(this.startTurnBallBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startTurnBallBtn;
        private System.Windows.Forms.Button startGravityTest;
        private System.Windows.Forms.Button startBorderBouncingForm;
        private System.Windows.Forms.Button startJumpingForm;
    }
}
namespace GADE6112_Task_1___19011648_Sean_Martin
{
    partial class Form1
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
            this.lblRound = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Button();
            this.gpbxMap = new System.Windows.Forms.GroupBox();
            this.lblMap = new System.Windows.Forms.Label();
            this.tmrRounds = new System.Windows.Forms.Timer(this.components);
            this.txtOut = new System.Windows.Forms.TextBox();
            this.gpbxMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(726, 35);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(54, 17);
            this.lblRound.TabIndex = 0;
            this.lblRound.Text = "Round:";
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(689, 75);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(250, 47);
            this.btnControl.TabIndex = 1;
            this.btnControl.Text = "Start Sim";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.BtnControl_Click);
            // 
            // gpbxMap
            // 
            this.gpbxMap.Controls.Add(this.lblMap);
            this.gpbxMap.Location = new System.Drawing.Point(12, 12);
            this.gpbxMap.Name = "gpbxMap";
            this.gpbxMap.Size = new System.Drawing.Size(668, 426);
            this.gpbxMap.TabIndex = 2;
            this.gpbxMap.TabStop = false;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(68, 63);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(0, 17);
            this.lblMap.TabIndex = 0;
            // 
            // tmrRounds
            // 
            this.tmrRounds.Tick += new System.EventHandler(this.TmrRounds_Tick);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(689, 128);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(250, 310);
            this.txtOut.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.gpbxMap);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.lblRound);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbxMap.ResumeLayout(false);
            this.gpbxMap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.GroupBox gpbxMap;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Timer tmrRounds;
        private System.Windows.Forms.TextBox txtOut;
    }
}


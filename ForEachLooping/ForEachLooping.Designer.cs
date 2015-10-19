namespace ForEachLooping
{
    partial class frmForEachLooping
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
            this.btnTouchMe = new System.Windows.Forms.Button();
            this.lblDontPress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTouchMe
            // 
            this.btnTouchMe.Location = new System.Drawing.Point(33, 64);
            this.btnTouchMe.Name = "btnTouchMe";
            this.btnTouchMe.Size = new System.Drawing.Size(75, 23);
            this.btnTouchMe.TabIndex = 0;
            this.btnTouchMe.Text = "touch me";
            this.btnTouchMe.UseVisualStyleBackColor = true;
            this.btnTouchMe.Click += new System.EventHandler(this.btnTouchMe_Click);
            // 
            // lblDontPress
            // 
            this.lblDontPress.AutoSize = true;
            this.lblDontPress.Location = new System.Drawing.Point(12, 9);
            this.lblDontPress.Name = "lblDontPress";
            this.lblDontPress.Size = new System.Drawing.Size(114, 52);
            this.lblDontPress.TabIndex = 1;
            this.lblDontPress.Text = "Dont touch that button\r\n                  |\r\n                  |\r\n               " +
    "  \\/";
            // 
            // frmForEachLooping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 91);
            this.Controls.Add(this.lblDontPress);
            this.Controls.Add(this.btnTouchMe);
            this.Name = "frmForEachLooping";
            this.Text = "For Each Loop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTouchMe;
        private System.Windows.Forms.Label lblDontPress;
    }
}


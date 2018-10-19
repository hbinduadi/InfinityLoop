namespace InfinityLoopNum
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
            this.btnStrtProc = new System.Windows.Forms.Button();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbsqr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStrtProc
            // 
            this.btnStrtProc.Location = new System.Drawing.Point(246, 35);
            this.btnStrtProc.Name = "btnStrtProc";
            this.btnStrtProc.Size = new System.Drawing.Size(164, 23);
            this.btnStrtProc.TabIndex = 0;
            this.btnStrtProc.Text = "Start Process";
            this.btnStrtProc.UseVisualStyleBackColor = true;
            this.btnStrtProc.Click += new System.EventHandler(this.btnStrtProc_Click);
            // 
            // tbnum
            // 
            this.tbnum.Location = new System.Drawing.Point(321, 106);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(196, 22);
            this.tbnum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number Square";
            // 
            // tbsqr
            // 
            this.tbsqr.Location = new System.Drawing.Point(321, 156);
            this.tbsqr.Name = "tbsqr";
            this.tbsqr.Size = new System.Drawing.Size(199, 22);
            this.tbsqr.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbsqr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.btnStrtProc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStrtProc;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbsqr;
    }
}


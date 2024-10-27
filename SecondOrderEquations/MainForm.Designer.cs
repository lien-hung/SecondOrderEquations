namespace SecondOrderEquations
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
            this.lblValueA = new System.Windows.Forms.Label();
            this.lblValueB = new System.Windows.Forms.Label();
            this.lblValueC = new System.Windows.Forms.Label();
            this.txtValueA = new System.Windows.Forms.TextBox();
            this.txtValueC = new System.Windows.Forms.TextBox();
            this.txtValueB = new System.Windows.Forms.TextBox();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValueA
            // 
            this.lblValueA.AutoSize = true;
            this.lblValueA.Location = new System.Drawing.Point(30, 24);
            this.lblValueA.Name = "lblValueA";
            this.lblValueA.Size = new System.Drawing.Size(22, 13);
            this.lblValueA.TabIndex = 0;
            this.lblValueA.Text = "a =";
            // 
            // lblValueB
            // 
            this.lblValueB.AutoSize = true;
            this.lblValueB.Location = new System.Drawing.Point(30, 59);
            this.lblValueB.Name = "lblValueB";
            this.lblValueB.Size = new System.Drawing.Size(22, 13);
            this.lblValueB.TabIndex = 1;
            this.lblValueB.Text = "b =";
            // 
            // lblValueC
            // 
            this.lblValueC.AutoSize = true;
            this.lblValueC.Location = new System.Drawing.Point(30, 94);
            this.lblValueC.Name = "lblValueC";
            this.lblValueC.Size = new System.Drawing.Size(22, 13);
            this.lblValueC.TabIndex = 2;
            this.lblValueC.Text = "c =";
            // 
            // txtValueA
            // 
            this.txtValueA.Location = new System.Drawing.Point(58, 21);
            this.txtValueA.Name = "txtValueA";
            this.txtValueA.Size = new System.Drawing.Size(100, 20);
            this.txtValueA.TabIndex = 3;
            // 
            // txtValueC
            // 
            this.txtValueC.Location = new System.Drawing.Point(58, 91);
            this.txtValueC.Name = "txtValueC";
            this.txtValueC.Size = new System.Drawing.Size(100, 20);
            this.txtValueC.TabIndex = 4;
            // 
            // txtValueB
            // 
            this.txtValueB.Location = new System.Drawing.Point(58, 56);
            this.txtValueB.Name = "txtValueB";
            this.txtValueB.Size = new System.Drawing.Size(100, 20);
            this.txtValueB.TabIndex = 5;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblResult);
            this.grpResult.Location = new System.Drawing.Point(195, 21);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(200, 90);
            this.grpResult.TabIndex = 6;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Kết quả";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(58, 126);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 7;
            this.btnSolve.Text = "Giải";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(7, 20);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(187, 66);
            this.lblResult.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 161);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.txtValueB);
            this.Controls.Add(this.txtValueC);
            this.Controls.Add(this.txtValueA);
            this.Controls.Add(this.lblValueC);
            this.Controls.Add(this.lblValueB);
            this.Controls.Add(this.lblValueA);
            this.Name = "MainForm";
            this.Text = "Phương trình bậc hai";
            this.grpResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValueA;
        private System.Windows.Forms.Label lblValueB;
        private System.Windows.Forms.Label lblValueC;
        private System.Windows.Forms.TextBox txtValueA;
        private System.Windows.Forms.TextBox txtValueC;
        private System.Windows.Forms.TextBox txtValueB;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblResult;
    }
}


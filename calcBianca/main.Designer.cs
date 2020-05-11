namespace calcBianca
{
    partial class main
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(361, 12);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(150, 173);
            this.lstOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 79);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(343, 20);
            this.txtInput.TabIndex = 2;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getKeyPress);
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.getKeyUp);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 110);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(166, 75);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Adicionar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 22);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(343, 51);
            this.txtOutput.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(184, 110);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 75);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Resetar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(12, 6);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(35, 13);
            this.lblHelp.TabIndex = 6;
            this.lblHelp.Text = "label1";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 195);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lstOutput);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora para uma Deusa Grega";
            this.Load += new System.EventHandler(this.main_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getKeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblHelp;
    }
}


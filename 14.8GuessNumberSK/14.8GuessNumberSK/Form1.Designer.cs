namespace _14._8GuessNumberSK
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.txt_Guess = new System.Windows.Forms.TextBox();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.lbl_hint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(130, 109);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(28, 15);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(71, 15);
            this.Label.TabIndex = 4;
            this.Label.Text = "Enter Guess:";
            // 
            // txt_Guess
            // 
            this.txt_Guess.Location = new System.Drawing.Point(105, 12);
            this.txt_Guess.Name = "txt_Guess";
            this.txt_Guess.Size = new System.Drawing.Size(100, 23);
            this.txt_Guess.TabIndex = 5;
            // 
            // btn_Guess
            // 
            this.btn_Guess.Location = new System.Drawing.Point(130, 61);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(75, 23);
            this.btn_Guess.TabIndex = 6;
            this.btn_Guess.Text = "Guess";
            this.btn_Guess.UseVisualStyleBackColor = true;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // lbl_hint
            // 
            this.lbl_hint.AutoSize = true;
            this.lbl_hint.Location = new System.Drawing.Point(12, 90);
            this.lbl_hint.Name = "lbl_hint";
            this.lbl_hint.Size = new System.Drawing.Size(10, 15);
            this.lbl_hint.TabIndex = 7;
            this.lbl_hint.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 154);
            this.Controls.Add(this.lbl_hint);
            this.Controls.Add(this.btn_Guess);
            this.Controls.Add(this.txt_Guess);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.btn_Reset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Reset;
        private Label Label;
        private TextBox txt_Guess;
        private Button btn_Guess;
        private Label lbl_hint;
    }
}
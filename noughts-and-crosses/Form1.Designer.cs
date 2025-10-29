
namespace noughts_and_crosses
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_AI = new System.Windows.Forms.Button();
            this.btn_2Player = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(325, 81);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(144, 17);
            this.lbl_title.TabIndex = 11;
            this.lbl_title.Text = "Noughts and Crosses";
            // 
            // btn_AI
            // 
            this.btn_AI.Location = new System.Drawing.Point(451, 186);
            this.btn_AI.Name = "btn_AI";
            this.btn_AI.Size = new System.Drawing.Size(141, 72);
            this.btn_AI.TabIndex = 12;
            this.btn_AI.Text = "Play Computer";
            this.btn_AI.UseVisualStyleBackColor = true;
            this.btn_AI.Click += new System.EventHandler(this.btn_AI_Click);
            // 
            // btn_2Player
            // 
            this.btn_2Player.Location = new System.Drawing.Point(202, 183);
            this.btn_2Player.Name = "btn_2Player";
            this.btn_2Player.Size = new System.Drawing.Size(141, 75);
            this.btn_2Player.TabIndex = 13;
            this.btn_2Player.Text = "2 Player";
            this.btn_2Player.UseVisualStyleBackColor = true;
            this.btn_2Player.Click += new System.EventHandler(this.btn_2Player_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_2Player);
            this.Controls.Add(this.btn_AI);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_AI;
        private System.Windows.Forms.Button btn_2Player;
    }
}


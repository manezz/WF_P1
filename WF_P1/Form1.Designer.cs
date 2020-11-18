
namespace WF_P1
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
            this.BtnKlikHer = new System.Windows.Forms.Button();
            this.LbAdvarselsBesked = new System.Windows.Forms.Label();
            this.TbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnKlikHer
            // 
            this.BtnKlikHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKlikHer.Location = new System.Drawing.Point(123, 280);
            this.BtnKlikHer.Name = "BtnKlikHer";
            this.BtnKlikHer.Size = new System.Drawing.Size(193, 39);
            this.BtnKlikHer.TabIndex = 0;
            this.BtnKlikHer.Text = "!! Vis Advarsel !!";
            this.BtnKlikHer.UseVisualStyleBackColor = true;
            this.BtnKlikHer.Click += new System.EventHandler(this.BtnKlikHer_Click);
            // 
            // LbAdvarselsBesked
            // 
            this.LbAdvarselsBesked.AutoSize = true;
            this.LbAdvarselsBesked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAdvarselsBesked.Location = new System.Drawing.Point(139, 147);
            this.LbAdvarselsBesked.Name = "LbAdvarselsBesked";
            this.LbAdvarselsBesked.Size = new System.Drawing.Size(160, 24);
            this.LbAdvarselsBesked.TabIndex = 1;
            this.LbAdvarselsBesked.Text = "Advarsels Besked";
            this.LbAdvarselsBesked.Click += new System.EventHandler(this.LbAdvarselsBesked_Click);
            // 
            // TbInput
            // 
            this.TbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbInput.Location = new System.Drawing.Point(123, 183);
            this.TbInput.Name = "TbInput";
            this.TbInput.Size = new System.Drawing.Size(193, 26);
            this.TbInput.TabIndex = 2;
            this.TbInput.TextChanged += new System.EventHandler(this.TbInput_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnKlikHer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.TbInput);
            this.Controls.Add(this.LbAdvarselsBesked);
            this.Controls.Add(this.BtnKlikHer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKlikHer;
        private System.Windows.Forms.Label LbAdvarselsBesked;
        private System.Windows.Forms.TextBox TbInput;
    }
}


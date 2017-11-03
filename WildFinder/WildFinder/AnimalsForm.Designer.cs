namespace WildFinder
{
    partial class AnimalsForm
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
            this.btnConsult = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbConsult = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbInferencias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConsult
            // 
            this.btnConsult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConsult.Location = new System.Drawing.Point(22, 372);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(109, 36);
            this.btnConsult.TabIndex = 55;
            this.btnConsult.Text = "Consult";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(23, 129);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(196, 20);
            this.tbInput.TabIndex = 54;
            // 
            // lbConsult
            // 
            this.lbConsult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConsult.FormattingEnabled = true;
            this.lbConsult.Location = new System.Drawing.Point(22, 167);
            this.lbConsult.Name = "lbConsult";
            this.lbConsult.Size = new System.Drawing.Size(515, 199);
            this.lbConsult.TabIndex = 53;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(181, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 32);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "WILD FINDER";
            // 
            // cbInferencias
            // 
            this.cbInferencias.FormattingEnabled = true;
            this.cbInferencias.Items.AddRange(new object[] {
            "Animals according to habitat",
            "Biomes according to habitas"});
            this.cbInferencias.Location = new System.Drawing.Point(22, 102);
            this.cbInferencias.Name = "cbInferencias";
            this.cbInferencias.Size = new System.Drawing.Size(197, 21);
            this.cbInferencias.TabIndex = 56;
            // 
            // AnimalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 418);
            this.Controls.Add(this.cbInferencias);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbConsult);
            this.Controls.Add(this.lblTitle);
            this.Name = "AnimalsForm";
            this.Text = "Wild Finder";
            this.Load += new System.EventHandler(this.AnimalsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ListBox lbConsult;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbInferencias;
    }
}


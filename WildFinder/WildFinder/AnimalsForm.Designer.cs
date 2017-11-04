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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalsForm));
            this.btnConsult = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbConsult = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbInferencias = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFinder = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblObjective = new System.Windows.Forms.Label();
            this.lblAux = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabFinder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsult
            // 
            this.btnConsult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.Image = ((System.Drawing.Image)(resources.GetObject("btnConsult.Image")));
            this.btnConsult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsult.Location = new System.Drawing.Point(6, 355);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(109, 36);
            this.btnConsult.TabIndex = 55;
            this.btnConsult.Text = "Consult";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(152, 47);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(178, 20);
            this.tbInput.TabIndex = 54;
            // 
            // lbConsult
            // 
            this.lbConsult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConsult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbConsult.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsult.FormattingEnabled = true;
            this.lbConsult.ItemHeight = 18;
            this.lbConsult.Location = new System.Drawing.Point(6, 73);
            this.lbConsult.Name = "lbConsult";
            this.lbConsult.Size = new System.Drawing.Size(746, 256);
            this.lbConsult.TabIndex = 53;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(297, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 32);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "WILD FINDER";
            // 
            // cbInferencias
            // 
            this.cbInferencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInferencias.FormattingEnabled = true;
            this.cbInferencias.Items.AddRange(new object[] {
            "Animals according to habitat",
            "Biomes according to habitat",
            "Biomes of animal",
            "Enemy of animal",
            "Possible cohabitants of"});
            this.cbInferencias.Location = new System.Drawing.Point(152, 20);
            this.cbInferencias.Name = "cbInferencias";
            this.cbInferencias.Size = new System.Drawing.Size(178, 21);
            this.cbInferencias.TabIndex = 56;
            this.cbInferencias.SelectedIndexChanged += new System.EventHandler(this.cbInferencias_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabFinder);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 423);
            this.tabControl1.TabIndex = 57;
            // 
            // tabFinder
            // 
            this.tabFinder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabFinder.Controls.Add(this.lblAux);
            this.tabFinder.Controls.Add(this.lblObjective);
            this.tabFinder.Controls.Add(this.cbInferencias);
            this.tabFinder.Controls.Add(this.btnConsult);
            this.tabFinder.Controls.Add(this.tbInput);
            this.tabFinder.Controls.Add(this.lbConsult);
            this.tabFinder.Location = new System.Drawing.Point(4, 22);
            this.tabFinder.Name = "tabFinder";
            this.tabFinder.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinder.Size = new System.Drawing.Size(758, 397);
            this.tabFinder.TabIndex = 0;
            this.tabFinder.Text = "Finder";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblObjective
            // 
            this.lblObjective.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObjective.AutoSize = true;
            this.lblObjective.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjective.Location = new System.Drawing.Point(6, 23);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(140, 14);
            this.lblObjective.TabIndex = 58;
            this.lblObjective.Text = "Select an objetive:";
            this.lblObjective.Click += new System.EventHandler(this.lblObjective_Click);
            // 
            // lblAux
            // 
            this.lblAux.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAux.AutoSize = true;
            this.lblAux.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAux.Location = new System.Drawing.Point(6, 47);
            this.lblAux.Name = "lblAux";
            this.lblAux.Size = new System.Drawing.Size(28, 14);
            this.lblAux.TabIndex = 59;
            this.lblAux.Text = "Aux";
            // 
            // AnimalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(781, 474);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "AnimalsForm";
            this.Text = "Wild Finder";
            this.Load += new System.EventHandler(this.AnimalsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFinder.ResumeLayout(false);
            this.tabFinder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ListBox lbConsult;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbInferencias;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFinder;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblAux;
        private System.Windows.Forms.Label lblObjective;
    }
}


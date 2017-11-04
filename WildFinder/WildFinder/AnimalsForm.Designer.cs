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
            this.tabPageFinder = new System.Windows.Forms.TabPage();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.lblObjective = new System.Windows.Forms.Label();
            this.lblAux = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.txtBiome = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtHabitat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExistingAnimal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewEnemy = new System.Windows.Forms.TextBox();
            this.btnAddEnemy = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageFinder.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsult
            // 
            this.btnConsult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsult.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.Image = ((System.Drawing.Image)(resources.GetObject("btnConsult.Image")));
            this.btnConsult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsult.Location = new System.Drawing.Point(571, 327);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(109, 36);
            this.btnConsult.TabIndex = 3;
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
            this.tbInput.Size = new System.Drawing.Size(200, 20);
            this.tbInput.TabIndex = 1;
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
            this.lbConsult.Size = new System.Drawing.Size(674, 238);
            this.lbConsult.TabIndex = 2;
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
            this.lblTitle.Location = new System.Drawing.Point(237, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 32);
            this.lblTitle.TabIndex = 50;
            this.lblTitle.Text = "WILD FINDER";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.cbInferencias.Size = new System.Drawing.Size(200, 21);
            this.cbInferencias.TabIndex = 0;
            this.cbInferencias.SelectedIndexChanged += new System.EventHandler(this.cbInferencias_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageFinder);
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFinder
            // 
            this.tabPageFinder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageFinder.Controls.Add(this.lblAux);
            this.tabPageFinder.Controls.Add(this.lblObjective);
            this.tabPageFinder.Controls.Add(this.cbInferencias);
            this.tabPageFinder.Controls.Add(this.btnConsult);
            this.tabPageFinder.Controls.Add(this.tbInput);
            this.tabPageFinder.Controls.Add(this.lbConsult);
            this.tabPageFinder.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageFinder.Location = new System.Drawing.Point(4, 22);
            this.tabPageFinder.Name = "tabPageFinder";
            this.tabPageFinder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinder.Size = new System.Drawing.Size(686, 369);
            this.tabPageFinder.TabIndex = 0;
            this.tabPageFinder.Text = "Finder";
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageAdd.Controls.Add(this.splitContainer1);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(686, 369);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Tasks";
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAddAnimal);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtHabitat);
            this.splitContainer1.Panel1.Controls.Add(this.txtClass);
            this.splitContainer1.Panel1.Controls.Add(this.txtBiome);
            this.splitContainer1.Panel1.Controls.Add(this.txtAnimalName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAddEnemy);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txtNewEnemy);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtExistingAnimal);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(680, 363);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 59;
            this.label1.Text = "Add an animal";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 14);
            this.label2.TabIndex = 60;
            this.label2.Text = "Add an enemy to an existing animal";
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnimalName.Location = new System.Drawing.Point(156, 46);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(137, 20);
            this.txtAnimalName.TabIndex = 0;
            // 
            // txtBiome
            // 
            this.txtBiome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBiome.Location = new System.Drawing.Point(394, 91);
            this.txtBiome.Name = "txtBiome";
            this.txtBiome.Size = new System.Drawing.Size(147, 20);
            this.txtBiome.TabIndex = 3;
            // 
            // txtClass
            // 
            this.txtClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClass.Location = new System.Drawing.Point(393, 46);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(148, 20);
            this.txtClass.TabIndex = 1;
            // 
            // txtHabitat
            // 
            this.txtHabitat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHabitat.Location = new System.Drawing.Point(156, 91);
            this.txtHabitat.Name = "txtHabitat";
            this.txtHabitat.Size = new System.Drawing.Size(137, 20);
            this.txtHabitat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 63;
            this.label3.Text = "Animal:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 64;
            this.label4.Text = "Class:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 65;
            this.label5.Text = "Habitat:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 66;
            this.label6.Text = "Biome:";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAnimal.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAnimal.Image")));
            this.btnAddAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAnimal.Location = new System.Drawing.Point(568, 149);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(109, 36);
            this.btnAddAnimal.TabIndex = 4;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 14);
            this.label7.TabIndex = 65;
            this.label7.Text = "Existing Animal:";
            // 
            // txtExistingAnimal
            // 
            this.txtExistingAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExistingAnimal.Location = new System.Drawing.Point(212, 58);
            this.txtExistingAnimal.Name = "txtExistingAnimal";
            this.txtExistingAnimal.Size = new System.Drawing.Size(146, 20);
            this.txtExistingAnimal.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 67;
            this.label8.Text = "New Enemy:";
            // 
            // txtNewEnemy
            // 
            this.txtNewEnemy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewEnemy.Location = new System.Drawing.Point(212, 100);
            this.txtNewEnemy.Name = "txtNewEnemy";
            this.txtNewEnemy.Size = new System.Drawing.Size(146, 20);
            this.txtNewEnemy.TabIndex = 1;
            // 
            // btnAddEnemy
            // 
            this.btnAddEnemy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddEnemy.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEnemy.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEnemy.Image")));
            this.btnAddEnemy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEnemy.Location = new System.Drawing.Point(568, 132);
            this.btnAddEnemy.Name = "btnAddEnemy";
            this.btnAddEnemy.Size = new System.Drawing.Size(109, 36);
            this.btnAddEnemy.TabIndex = 2;
            this.btnAddEnemy.Text = "Add";
            this.btnAddEnemy.UseVisualStyleBackColor = true;
            this.btnAddEnemy.Click += new System.EventHandler(this.btnAddEnemy_Click);
            // 
            // AnimalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(709, 446);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AnimalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wild Finder";
            this.Load += new System.EventHandler(this.AnimalsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFinder.ResumeLayout(false);
            this.tabPageFinder.PerformLayout();
            this.tabPageAdd.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPageFinder;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Label lblAux;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHabitat;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtBiome;
        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewEnemy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExistingAnimal;
        private System.Windows.Forms.Button btnAddEnemy;
    }
}


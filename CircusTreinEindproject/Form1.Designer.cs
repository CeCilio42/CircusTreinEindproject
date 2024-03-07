namespace CircusTreinEindproject
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
            this.buttonS_H = new System.Windows.Forms.Button();
            this.buttonS_C = new System.Windows.Forms.Button();
            this.buttonM_H = new System.Windows.Forms.Button();
            this.buttonM_C = new System.Windows.Forms.Button();
            this.buttonL_H = new System.Windows.Forms.Button();
            this.buttonL_C = new System.Windows.Forms.Button();
            this.labelHerbivore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.listBoxWagons = new System.Windows.Forms.ListBox();
            this.Distribute = new System.Windows.Forms.Button();
            this.labelWagonCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonS_H
            // 
            this.buttonS_H.Location = new System.Drawing.Point(36, 65);
            this.buttonS_H.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonS_H.Name = "buttonS_H";
            this.buttonS_H.Size = new System.Drawing.Size(113, 46);
            this.buttonS_H.TabIndex = 0;
            this.buttonS_H.Text = "Small";
            this.buttonS_H.UseVisualStyleBackColor = true;
            this.buttonS_H.Click += new System.EventHandler(this.buttonS_H_Click);
            // 
            // buttonS_C
            // 
            this.buttonS_C.Location = new System.Drawing.Point(185, 65);
            this.buttonS_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonS_C.Name = "buttonS_C";
            this.buttonS_C.Size = new System.Drawing.Size(113, 46);
            this.buttonS_C.TabIndex = 1;
            this.buttonS_C.Text = "Small";
            this.buttonS_C.UseVisualStyleBackColor = true;
            this.buttonS_C.Click += new System.EventHandler(this.buttonS_C_Click);
            // 
            // buttonM_H
            // 
            this.buttonM_H.Location = new System.Drawing.Point(36, 117);
            this.buttonM_H.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonM_H.Name = "buttonM_H";
            this.buttonM_H.Size = new System.Drawing.Size(113, 46);
            this.buttonM_H.TabIndex = 2;
            this.buttonM_H.Text = "Medium";
            this.buttonM_H.UseVisualStyleBackColor = true;
            this.buttonM_H.Click += new System.EventHandler(this.buttonM_H_Click);
            // 
            // buttonM_C
            // 
            this.buttonM_C.Location = new System.Drawing.Point(185, 117);
            this.buttonM_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonM_C.Name = "buttonM_C";
            this.buttonM_C.Size = new System.Drawing.Size(113, 46);
            this.buttonM_C.TabIndex = 3;
            this.buttonM_C.Text = "Medium";
            this.buttonM_C.UseVisualStyleBackColor = true;
            this.buttonM_C.Click += new System.EventHandler(this.buttonM_C_Click);
            // 
            // buttonL_H
            // 
            this.buttonL_H.Location = new System.Drawing.Point(36, 169);
            this.buttonL_H.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonL_H.Name = "buttonL_H";
            this.buttonL_H.Size = new System.Drawing.Size(113, 46);
            this.buttonL_H.TabIndex = 4;
            this.buttonL_H.Text = "Large";
            this.buttonL_H.UseVisualStyleBackColor = true;
            this.buttonL_H.Click += new System.EventHandler(this.buttonL_H_Click);
            // 
            // buttonL_C
            // 
            this.buttonL_C.Location = new System.Drawing.Point(185, 169);
            this.buttonL_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonL_C.Name = "buttonL_C";
            this.buttonL_C.Size = new System.Drawing.Size(113, 46);
            this.buttonL_C.TabIndex = 5;
            this.buttonL_C.Text = "Large";
            this.buttonL_C.UseVisualStyleBackColor = true;
            this.buttonL_C.Click += new System.EventHandler(this.buttonL_C_Click);
            // 
            // labelHerbivore
            // 
            this.labelHerbivore.AutoSize = true;
            this.labelHerbivore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHerbivore.Location = new System.Drawing.Point(31, 37);
            this.labelHerbivore.Name = "labelHerbivore";
            this.labelHerbivore.Size = new System.Drawing.Size(96, 25);
            this.labelHerbivore.TabIndex = 6;
            this.labelHerbivore.Text = "Herbivore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Carnivore";
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.ItemHeight = 16;
            this.listBoxAnimals.Location = new System.Drawing.Point(304, 37);
            this.listBoxAnimals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(185, 308);
            this.listBoxAnimals.TabIndex = 8;
            // 
            // listBoxWagons
            // 
            this.listBoxWagons.FormattingEnabled = true;
            this.listBoxWagons.ItemHeight = 16;
            this.listBoxWagons.Location = new System.Drawing.Point(495, 37);
            this.listBoxWagons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxWagons.Name = "listBoxWagons";
            this.listBoxWagons.Size = new System.Drawing.Size(208, 308);
            this.listBoxWagons.TabIndex = 9;
            // 
            // Distribute
            // 
            this.Distribute.Location = new System.Drawing.Point(36, 219);
            this.Distribute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Distribute.Name = "Distribute";
            this.Distribute.Size = new System.Drawing.Size(263, 53);
            this.Distribute.TabIndex = 11;
            this.Distribute.Text = "Distribute";
            this.Distribute.UseVisualStyleBackColor = true;
            this.Distribute.Click += new System.EventHandler(this.Distribute_Click);
            // 
            // labelWagonCount
            // 
            this.labelWagonCount.AutoSize = true;
            this.labelWagonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWagonCount.Location = new System.Drawing.Point(516, 362);
            this.labelWagonCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWagonCount.Name = "labelWagonCount";
            this.labelWagonCount.Size = new System.Drawing.Size(80, 20);
            this.labelWagonCount.TabIndex = 12;
            this.labelWagonCount.Text = "Wagons: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWagonCount);
            this.Controls.Add(this.Distribute);
            this.Controls.Add(this.listBoxWagons);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHerbivore);
            this.Controls.Add(this.buttonL_C);
            this.Controls.Add(this.buttonL_H);
            this.Controls.Add(this.buttonM_C);
            this.Controls.Add(this.buttonM_H);
            this.Controls.Add(this.buttonS_C);
            this.Controls.Add(this.buttonS_H);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonS_H;
        private System.Windows.Forms.Button buttonS_C;
        private System.Windows.Forms.Button buttonM_H;
        private System.Windows.Forms.Button buttonM_C;
        private System.Windows.Forms.Button buttonL_H;
        private System.Windows.Forms.Button buttonL_C;
        private System.Windows.Forms.Label labelHerbivore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.ListBox listBoxWagons;
        private System.Windows.Forms.Button Distribute;
        private System.Windows.Forms.Label labelWagonCount;
    }
}


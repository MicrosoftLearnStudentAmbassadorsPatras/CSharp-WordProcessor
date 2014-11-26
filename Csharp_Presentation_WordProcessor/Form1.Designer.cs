namespace Csharp_Presentation_WordProcessor
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
            this.s1 = new System.Windows.Forms.TextBox();
            this.s2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Compare = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.Split = new System.Windows.Forms.Button();
            this.StartsWith = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.IndexOf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ToLower = new System.Windows.Forms.Button();
            this.ToUpper = new System.Windows.Forms.Button();
            this.Length = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.s3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(44, 122);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(172, 20);
            this.s1.TabIndex = 0;
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(44, 184);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(172, 20);
            this.s2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert the desired strings below:";
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(342, 180);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(81, 23);
            this.Compare.TabIndex = 3;
            this.Compare.Text = "Compare";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(254, 180);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(81, 23);
            this.Replace.TabIndex = 4;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // Split
            // 
            this.Split.Location = new System.Drawing.Point(255, 210);
            this.Split.Name = "Split";
            this.Split.Size = new System.Drawing.Size(81, 23);
            this.Split.TabIndex = 5;
            this.Split.Text = "Split";
            this.Split.UseVisualStyleBackColor = true;
            this.Split.Click += new System.EventHandler(this.Split_Click);
            // 
            // StartsWith
            // 
            this.StartsWith.Location = new System.Drawing.Point(254, 239);
            this.StartsWith.Name = "StartsWith";
            this.StartsWith.Size = new System.Drawing.Size(81, 23);
            this.StartsWith.TabIndex = 6;
            this.StartsWith.Text = "StartsWith";
            this.StartsWith.UseVisualStyleBackColor = true;
            this.StartsWith.Click += new System.EventHandler(this.StartsWith_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(342, 210);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(81, 23);
            this.Insert.TabIndex = 7;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // IndexOf
            // 
            this.IndexOf.Location = new System.Drawing.Point(254, 151);
            this.IndexOf.Name = "IndexOf";
            this.IndexOf.Size = new System.Drawing.Size(81, 23);
            this.IndexOf.TabIndex = 8;
            this.IndexOf.Text = "IndexOf";
            this.IndexOf.UseVisualStyleBackColor = true;
            this.IndexOf.Click += new System.EventHandler(this.IndexOf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "String 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "String 2:";
            // 
            // ToLower
            // 
            this.ToLower.Location = new System.Drawing.Point(342, 122);
            this.ToLower.Name = "ToLower";
            this.ToLower.Size = new System.Drawing.Size(81, 23);
            this.ToLower.TabIndex = 12;
            this.ToLower.Text = "ToLower";
            this.ToLower.UseVisualStyleBackColor = true;
            this.ToLower.Click += new System.EventHandler(this.ToLower_Click);
            // 
            // ToUpper
            // 
            this.ToUpper.Location = new System.Drawing.Point(254, 122);
            this.ToUpper.Name = "ToUpper";
            this.ToUpper.Size = new System.Drawing.Size(81, 23);
            this.ToUpper.TabIndex = 13;
            this.ToUpper.Text = "ToUpper";
            this.ToUpper.UseVisualStyleBackColor = true;
            this.ToUpper.Click += new System.EventHandler(this.ToUpper_Click);
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(342, 151);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(81, 23);
            this.Length.TabIndex = 14;
            this.Length.Text = "Length";
            this.Length.UseVisualStyleBackColor = true;
            this.Length.Click += new System.EventHandler(this.Length_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(342, 239);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(81, 23);
            this.Remove.TabIndex = 15;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // s3
            // 
            this.s3.Location = new System.Drawing.Point(44, 249);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(172, 20);
            this.s3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "String 3:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.ToUpper);
            this.Controls.Add(this.ToLower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IndexOf);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.StartsWith);
            this.Controls.Add(this.Split);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.Button Split;
        private System.Windows.Forms.Button StartsWith;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button IndexOf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ToLower;
        private System.Windows.Forms.Button ToUpper;
        private System.Windows.Forms.Button Length;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox s3;
        private System.Windows.Forms.Label label4;
    }
}


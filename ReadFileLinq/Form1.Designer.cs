namespace ReadFileLinq
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
            this.btnStart = new System.Windows.Forms.Button();
            this.ltbOutput = new System.Windows.Forms.ListBox();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnCity = new System.Windows.Forms.Button();
            this.ttbCity = new System.Windows.Forms.TextBox();
            this.ttbbalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(56, 298);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Filter";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ltbOutput
            // 
            this.ltbOutput.FormattingEnabled = true;
            this.ltbOutput.Location = new System.Drawing.Point(12, 12);
            this.ltbOutput.Name = "ltbOutput";
            this.ltbOutput.Size = new System.Drawing.Size(322, 264);
            this.ltbOutput.TabIndex = 1;
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(181, 298);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(75, 23);
            this.btnGroup.TabIndex = 2;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(56, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "AND";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(181, 461);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(75, 23);
            this.btnOr.TabIndex = 5;
            this.btnOr.Text = "OR";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnCity
            // 
            this.btnCity.Location = new System.Drawing.Point(26, 461);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(75, 23);
            this.btnCity.TabIndex = 6;
            this.btnCity.Text = "City";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // ttbCity
            // 
            this.ttbCity.Location = new System.Drawing.Point(12, 519);
            this.ttbCity.Name = "ttbCity";
            this.ttbCity.Size = new System.Drawing.Size(100, 20);
            this.ttbCity.TabIndex = 7;
            // 
            // ttbbalance
            // 
            this.ttbbalance.Location = new System.Drawing.Point(181, 519);
            this.ttbbalance.Name = "ttbbalance";
            this.ttbbalance.Size = new System.Drawing.Size(100, 20);
            this.ttbbalance.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 582);
            this.Controls.Add(this.ttbbalance);
            this.Controls.Add(this.ttbCity);
            this.Controls.Add(this.btnCity);
            this.Controls.Add(this.btnOr);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.ltbOutput);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "LINQ Play";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox ltbOutput;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.TextBox ttbCity;
        private System.Windows.Forms.TextBox ttbbalance;
    }
}


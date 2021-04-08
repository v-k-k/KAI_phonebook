namespace KAI_phonebook
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bdateLabel;
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label mnameLabel;
            this.bdateTextBox = new System.Windows.Forms.TextBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.mnameTextBox = new System.Windows.Forms.TextBox();
            this.fiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            bdateLabel = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            mnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fiosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdateLabel
            // 
            bdateLabel.AutoSize = true;
            bdateLabel.Location = new System.Drawing.Point(33, 62);
            bdateLabel.Name = "bdateLabel";
            bdateLabel.Size = new System.Drawing.Size(38, 13);
            bdateLabel.TabIndex = 1;
            bdateLabel.Text = "Bdate:";
            // 
            // bdateTextBox
            // 
            this.bdateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiosBindingSource, "Bdate", true));
            this.bdateTextBox.Location = new System.Drawing.Point(84, 59);
            this.bdateTextBox.Name = "bdateTextBox";
            this.bdateTextBox.Size = new System.Drawing.Size(236, 20);
            this.bdateTextBox.TabIndex = 2;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new System.Drawing.Point(33, 88);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(42, 13);
            fnameLabel.TabIndex = 3;
            fnameLabel.Text = "Fname:";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiosBindingSource, "Fname", true));
            this.fnameTextBox.Location = new System.Drawing.Point(84, 85);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(236, 20);
            this.fnameTextBox.TabIndex = 4;
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new System.Drawing.Point(33, 114);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(42, 13);
            lnameLabel.TabIndex = 5;
            lnameLabel.Text = "Lname:";
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiosBindingSource, "Lname", true));
            this.lnameTextBox.Location = new System.Drawing.Point(84, 111);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(236, 20);
            this.lnameTextBox.TabIndex = 6;
            // 
            // mnameLabel
            // 
            mnameLabel.AutoSize = true;
            mnameLabel.Location = new System.Drawing.Point(33, 140);
            mnameLabel.Name = "mnameLabel";
            mnameLabel.Size = new System.Drawing.Size(45, 13);
            mnameLabel.TabIndex = 7;
            mnameLabel.Text = "Mname:";
            // 
            // mnameTextBox
            // 
            this.mnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiosBindingSource, "Mname", true));
            this.mnameTextBox.Location = new System.Drawing.Point(84, 137);
            this.mnameTextBox.Name = "mnameTextBox";
            this.mnameTextBox.Size = new System.Drawing.Size(236, 20);
            this.mnameTextBox.TabIndex = 8;
            // 
            // fiosBindingSource
            // 
            this.fiosBindingSource.DataSource = typeof(KAI_phonebook.Human);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(36, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 59);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(bdateLabel);
            this.Controls.Add(this.bdateTextBox);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(mnameLabel);
            this.Controls.Add(this.mnameTextBox);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.fiosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fiosBindingSource;
        private System.Windows.Forms.TextBox bdateTextBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox mnameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
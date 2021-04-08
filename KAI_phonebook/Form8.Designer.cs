namespace KAI_phonebook
{
    partial class Form8
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
            System.Windows.Forms.Label flatLabel;
            System.Windows.Forms.Label houseLabel;
            System.Windows.Forms.Label streetLabel;
            this.flatTextBox = new System.Windows.Forms.TextBox();
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            flatLabel = new System.Windows.Forms.Label();
            houseLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flatLabel
            // 
            flatLabel.AutoSize = true;
            flatLabel.Location = new System.Drawing.Point(30, 45);
            flatLabel.Name = "flatLabel";
            flatLabel.Size = new System.Drawing.Size(27, 13);
            flatLabel.TabIndex = 1;
            flatLabel.Text = "Flat:";
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.Location = new System.Drawing.Point(30, 71);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new System.Drawing.Size(41, 13);
            houseLabel.TabIndex = 3;
            houseLabel.Text = "House:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(30, 97);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 5;
            streetLabel.Text = "Street:";
            // 
            // flatTextBox
            // 
            this.flatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placesBindingSource, "Flat", true));
            this.flatTextBox.Location = new System.Drawing.Point(77, 42);
            this.flatTextBox.Name = "flatTextBox";
            this.flatTextBox.Size = new System.Drawing.Size(100, 20);
            this.flatTextBox.TabIndex = 2;
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataSource = typeof(KAI_phonebook.Address);
            // 
            // houseTextBox
            // 
            this.houseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placesBindingSource, "House", true));
            this.houseTextBox.Location = new System.Drawing.Point(77, 68);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(100, 20);
            this.houseTextBox.TabIndex = 4;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placesBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(77, 94);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetTextBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(flatLabel);
            this.Controls.Add(this.flatTextBox);
            this.Controls.Add(houseLabel);
            this.Controls.Add(this.houseTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource placesBindingSource;
        private System.Windows.Forms.TextBox flatTextBox;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
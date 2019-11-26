namespace MyContactsApp
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.DAddress = new System.Windows.Forms.Label();
            this.DEmailAddress = new System.Windows.Forms.Label();
            this.DPhoneNumber = new System.Windows.Forms.Label();
            this.DLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.DFirstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(210, 147);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 63);
            this.txtAddress.TabIndex = 23;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(210, 121);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(134, 20);
            this.txtEmailAddress.TabIndex = 22;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(210, 95);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(134, 20);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(210, 67);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(134, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // DAddress
            // 
            this.DAddress.AutoSize = true;
            this.DAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DAddress.Location = new System.Drawing.Point(49, 147);
            this.DAddress.Name = "DAddress";
            this.DAddress.Size = new System.Drawing.Size(75, 20);
            this.DAddress.TabIndex = 19;
            this.DAddress.Text = "Address";
            // 
            // DEmailAddress
            // 
            this.DEmailAddress.AutoSize = true;
            this.DEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DEmailAddress.Location = new System.Drawing.Point(49, 121);
            this.DEmailAddress.Name = "DEmailAddress";
            this.DEmailAddress.Size = new System.Drawing.Size(124, 20);
            this.DEmailAddress.TabIndex = 18;
            this.DEmailAddress.Text = "Email Address";
            // 
            // DPhoneNumber
            // 
            this.DPhoneNumber.AutoSize = true;
            this.DPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DPhoneNumber.Location = new System.Drawing.Point(49, 95);
            this.DPhoneNumber.Name = "DPhoneNumber";
            this.DPhoneNumber.Size = new System.Drawing.Size(127, 20);
            this.DPhoneNumber.TabIndex = 17;
            this.DPhoneNumber.Text = "Phone Number";
            // 
            // DLastName
            // 
            this.DLastName.AutoSize = true;
            this.DLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DLastName.Location = new System.Drawing.Point(49, 68);
            this.DLastName.Name = "DLastName";
            this.DLastName.Size = new System.Drawing.Size(95, 20);
            this.DLastName.TabIndex = 16;
            this.DLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(210, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(134, 20);
            this.txtFirstName.TabIndex = 15;
            // 
            // DFirstName
            // 
            this.DFirstName.AutoSize = true;
            this.DFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DFirstName.Location = new System.Drawing.Point(49, 40);
            this.DFirstName.Name = "DFirstName";
            this.DFirstName.Size = new System.Drawing.Size(96, 20);
            this.DFirstName.TabIndex = 14;
            this.DFirstName.Text = "First Name";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(242, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 63);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.DAddress);
            this.Controls.Add(this.DEmailAddress);
            this.Controls.Add(this.DPhoneNumber);
            this.Controls.Add(this.DLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.DFirstName);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label DAddress;
        private System.Windows.Forms.Label DEmailAddress;
        private System.Windows.Forms.Label DPhoneNumber;
        private System.Windows.Forms.Label DLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label DFirstName;
        private System.Windows.Forms.Button button1;
    }
}
namespace AITLibrary
{
    partial class UserForm
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
            this.dataGridViewListUsers = new System.Windows.Forms.DataGridView();
            this.buttonListUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListUsers
            // 
            this.dataGridViewListUsers.AllowUserToAddRows = false;
            this.dataGridViewListUsers.AllowUserToDeleteRows = false;
            this.dataGridViewListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListUsers.Location = new System.Drawing.Point(13, 50);
            this.dataGridViewListUsers.Name = "dataGridViewListUsers";
            this.dataGridViewListUsers.ReadOnly = true;
            this.dataGridViewListUsers.Size = new System.Drawing.Size(704, 171);
            this.dataGridViewListUsers.TabIndex = 0;
            // 
            // buttonListUsers
            // 
            this.buttonListUsers.Location = new System.Drawing.Point(558, 247);
            this.buttonListUsers.Name = "buttonListUsers";
            this.buttonListUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonListUsers.TabIndex = 1;
            this.buttonListUsers.Text = "List Users";
            this.buttonListUsers.UseVisualStyleBackColor = true;
            this.buttonListUsers.Click += new System.EventHandler(this.buttonListUsers_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 433);
            this.Controls.Add(this.buttonListUsers);
            this.Controls.Add(this.dataGridViewListUsers);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListUsers;
        private System.Windows.Forms.Button buttonListUsers;
    }
}
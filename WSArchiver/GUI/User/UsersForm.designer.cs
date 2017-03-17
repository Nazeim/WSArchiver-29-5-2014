namespace WSArchiver.GUI
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.label2 = new System.Windows.Forms.Label();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveAsStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.InsertUserButton = new System.Windows.Forms.Button();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.RemovUserButton = new System.Windows.Forms.Button();
            this.UserSPrivilegesButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Size = new System.Drawing.Size(742, 64);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 15);
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.Text = "المستخدمون";
            // 
            // exitB
            // 
            this.exitB.BackgroundImage = global::WSArchiver.Properties.Resources.exit;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitB.Location = new System.Drawing.Point(17, 345);
            this.exitB.Size = new System.Drawing.Size(77, 38);
            this.exitB.TabIndex = 8;
            this.exitB.Text = "";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(127, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "يتم في هذه الشاشة التعامل مع حسابات مستخدمي البرنامج من حيث تكوين حسابات لهم  ومن" +
    "حهم الصلاحيات اللازمة لأداء عملهم ";
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(281, 70);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(267, 20);
            this.UserNametextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "اسم المستخدم";
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            this.UsersDataGridView.AutoGenerateColumns = false;
            this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.isActiveAsStringDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.UsersDataGridView.DataSource = this.bindingSource1;
            this.UsersDataGridView.Location = new System.Drawing.Point(105, 130);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowHeadersVisible = false;
            this.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGridView.Size = new System.Drawing.Size(625, 262);
            this.UsersDataGridView.TabIndex = 7;
            this.UsersDataGridView.TabStop = false;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 60F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "اسم المستخدم";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.FillWeight = 40F;
            this.passwordDataGridViewTextBoxColumn.HeaderText = "كلمة السر";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // isActiveAsStringDataGridViewTextBoxColumn
            // 
            this.isActiveAsStringDataGridViewTextBoxColumn.DataPropertyName = "IsActiveAsString";
            this.isActiveAsStringDataGridViewTextBoxColumn.FillWeight = 40F;
            this.isActiveAsStringDataGridViewTextBoxColumn.HeaderText = "الحساب مفعل";
            this.isActiveAsStringDataGridViewTextBoxColumn.Name = "isActiveAsStringDataGridViewTextBoxColumn";
            this.isActiveAsStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Library.Common.UserVO);
            // 
            // InsertUserButton
            // 
            this.InsertUserButton.BackgroundImage = global::WSArchiver.Properties.Resources.plus_64;
            this.InsertUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InsertUserButton.Location = new System.Drawing.Point(17, 144);
            this.InsertUserButton.Name = "InsertUserButton";
            this.InsertUserButton.Size = new System.Drawing.Size(77, 38);
            this.InsertUserButton.TabIndex = 3;
            this.InsertUserButton.UseVisualStyleBackColor = true;
            this.InsertUserButton.Click += new System.EventHandler(this.InsertUserButton_Click);
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.BackgroundImage = global::WSArchiver.Properties.Resources.Edit2;
            this.UpdateUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateUserButton.Location = new System.Drawing.Point(17, 188);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(77, 38);
            this.UpdateUserButton.TabIndex = 4;
            this.UpdateUserButton.UseVisualStyleBackColor = true;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // RemovUserButton
            // 
            this.RemovUserButton.BackgroundImage = global::WSArchiver.Properties.Resources.delete_64;
            this.RemovUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemovUserButton.Location = new System.Drawing.Point(16, 232);
            this.RemovUserButton.Name = "RemovUserButton";
            this.RemovUserButton.Size = new System.Drawing.Size(77, 38);
            this.RemovUserButton.TabIndex = 5;
            this.RemovUserButton.UseVisualStyleBackColor = true;
            this.RemovUserButton.Click += new System.EventHandler(this.RemovUserButton_Click);
            // 
            // UserSPrivilegesButton
            // 
            this.UserSPrivilegesButton.BackgroundImage = global::WSArchiver.Properties.Resources.key_48;
            this.UserSPrivilegesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserSPrivilegesButton.Location = new System.Drawing.Point(17, 276);
            this.UserSPrivilegesButton.Name = "UserSPrivilegesButton";
            this.UserSPrivilegesButton.Size = new System.Drawing.Size(77, 36);
            this.UserSPrivilegesButton.TabIndex = 6;
            this.toolTip2.SetToolTip(this.UserSPrivilegesButton, "صلاحيات المستخدم المحدد");
            this.UserSPrivilegesButton.UseVisualStyleBackColor = true;
            this.UserSPrivilegesButton.Click += new System.EventHandler(this.UserSPrivilegesButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "كلمة المرور";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(281, 104);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(267, 20);
            this.passwordTB.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WSArchiver.Properties.Resources.users_black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitB;
            this.ClientSize = new System.Drawing.Size(742, 434);
            this.Controls.Add(this.UserSPrivilegesButton);
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.InsertUserButton);
            this.Controls.Add(this.UpdateUserButton);
            this.Controls.Add(this.RemovUserButton);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserNametextBox);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersForm";
            this.Text = "المستخدمون";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.Controls.SetChildIndex(this.exitB, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.UserNametextBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.passwordTB, 0);
            this.Controls.SetChildIndex(this.RemovUserButton, 0);
            this.Controls.SetChildIndex(this.UpdateUserButton, 0);
            this.Controls.SetChildIndex(this.InsertUserButton, 0);
            this.Controls.SetChildIndex(this.UsersDataGridView, 0);
            this.Controls.SetChildIndex(this.UserSPrivilegesButton, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.Button InsertUserButton;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Button RemovUserButton;
        private System.Windows.Forms.Button UserSPrivilegesButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveAsStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}
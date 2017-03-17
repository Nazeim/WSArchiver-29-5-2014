namespace WSArchiver.GUI.UserControls
{
    partial class MultipleItemsSearchControl
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addB = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBox1, "إيجاد الوثائق التي تنتمي إلى أيّ من التصنيفات المختارة");
            // 
            // addB
            // 
            this.addB.Enabled = false;
            this.addB.Location = new System.Drawing.Point(0, -1);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 23);
            this.addB.TabIndex = 1;
            this.addB.Text = "إضافة";
            this.toolTip1.SetToolTip(this.addB, "إيجاد الوثائق التي تنتمي إلى أيّ من التصنيفات المختارة");
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(81, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 56);
            this.listBox1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listBox1, "إيجاد الوثائق التي تنتمي إلى أيّ من التصنيفات المختارة");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // deleteB
            // 
            this.deleteB.Enabled = false;
            this.deleteB.Location = new System.Drawing.Point(0, 41);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(75, 23);
            this.deleteB.TabIndex = 3;
            this.deleteB.Text = "حذف المحدد";
            this.toolTip1.SetToolTip(this.deleteB, "إيجاد الوثائق التي تنتمي إلى أيّ من التصنيفات المختارة");
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "جميع التصنيفات:";
            this.toolTip1.SetToolTip(this.label1, "إيجاد الوثائق التي تنتمي إلى أيّ من التصنيفات المختارة");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "التصنيفات المختارة:";
            this.toolTip1.SetToolTip(this.label2, "إيجاد الوثائق التي تنتمي إلى أيّ من التصنيفات المختارة");
            // 
            // MultipleItemsSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.comboBox1);
            this.Name = "MultipleItemsSearchControl";
            this.Size = new System.Drawing.Size(373, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.ComboBox comboBox1;
        protected System.Windows.Forms.Button addB;
        protected System.Windows.Forms.ListBox listBox1;
        protected System.Windows.Forms.Button deleteB;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
    }
}

namespace Messenger.GUI.Messenger
{
    partial class MessengerForm
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
            this.MessengerL = new System.Windows.Forms.FlowLayoutPanel();
            this.TypingTB = new System.Windows.Forms.TextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.ConversationRTB = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessengerL
            // 
            this.MessengerL.AutoScroll = true;
            this.MessengerL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MessengerL.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MessengerL.Location = new System.Drawing.Point(12, 12);
            this.MessengerL.Name = "MessengerL";
            this.MessengerL.Size = new System.Drawing.Size(168, 458);
            this.MessengerL.TabIndex = 0;
            this.MessengerL.WrapContents = false;
            // 
            // TypingTB
            // 
            this.TypingTB.Enabled = false;
            this.TypingTB.ForeColor = System.Drawing.Color.SteelBlue;
            this.TypingTB.Location = new System.Drawing.Point(186, 401);
            this.TypingTB.Multiline = true;
            this.TypingTB.Name = "TypingTB";
            this.TypingTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TypingTB.Size = new System.Drawing.Size(257, 69);
            this.TypingTB.TabIndex = 6;
            this.TypingTB.TextChanged += new System.EventHandler(this.TypingTB_TextChanged);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Enabled = false;
            this.ButtonSend.Location = new System.Drawing.Point(449, 417);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 28);
            this.ButtonSend.TabIndex = 5;
            this.ButtonSend.Text = "send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click_1);
            // 
            // ConversationRTB
            // 
            this.ConversationRTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConversationRTB.Location = new System.Drawing.Point(186, 37);
            this.ConversationRTB.Name = "ConversationRTB";
            this.ConversationRTB.ReadOnly = true;
            this.ConversationRTB.Size = new System.Drawing.Size(338, 358);
            this.ConversationRTB.TabIndex = 4;
            this.ConversationRTB.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(190, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // MessengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypingTB);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.ConversationRTB);
            this.Controls.Add(this.MessengerL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessengerForm";
            this.Text = "MessengerForm";
            this.Load += new System.EventHandler(this.MessengerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MessengerL;
        private System.Windows.Forms.TextBox TypingTB;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.RichTextBox ConversationRTB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}
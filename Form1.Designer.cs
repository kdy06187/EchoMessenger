namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_title = new Label();
            txt_input = new TextBox();
            lst_messages = new ListBox();
            btn_send = new Button();
            lbl_msgCount = new Label();
            btn_deleteItem = new Button();
            btn_deleteAll = new Button();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("맑은 고딕", 35F, FontStyle.Bold);
            lbl_title.ForeColor = Color.Blue;
            lbl_title.Location = new Point(26, 24);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(784, 125);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Echo Messenger";
            // 
            // txt_input
            // 
            txt_input.Font = new Font("맑은 고딕", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txt_input.Location = new Point(44, 613);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(685, 78);
            txt_input.TabIndex = 1;
            txt_input.KeyDown += txt_input_KeyDown;
            // 
            // lst_messages
            // 
            lst_messages.Font = new Font("맑은 고딕", 15F);
            lst_messages.FormattingEnabled = true;
            lst_messages.Location = new Point(44, 170);
            lst_messages.Name = "lst_messages";
            lst_messages.Size = new Size(1222, 382);
            lst_messages.TabIndex = 2;
            // 
            // btn_send
            // 
            btn_send.BackColor = Color.FromArgb(128, 255, 128);
            btn_send.Font = new Font("맑은 고딕", 20F);
            btn_send.ForeColor = SystemColors.ControlText;
            btn_send.Location = new Point(751, 613);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(181, 82);
            btn_send.TabIndex = 3;
            btn_send.Text = "전송";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += btn_send_Click;
            // 
            // lbl_msgCount
            // 
            lbl_msgCount.AutoSize = true;
            lbl_msgCount.BackColor = Color.FromArgb(192, 255, 255);
            lbl_msgCount.Location = new Point(53, 564);
            lbl_msgCount.Name = "lbl_msgCount";
            lbl_msgCount.Size = new Size(176, 32);
            lbl_msgCount.TabIndex = 4;
            lbl_msgCount.Text = "현재 대화 : 0개";
            // 
            // btn_deleteItem
            // 
            btn_deleteItem.BackColor = Color.FromArgb(255, 128, 128);
            btn_deleteItem.Font = new Font("맑은 고딕", 10F);
            btn_deleteItem.Location = new Point(963, 119);
            btn_deleteItem.Name = "btn_deleteItem";
            btn_deleteItem.Size = new Size(284, 45);
            btn_deleteItem.TabIndex = 5;
            btn_deleteItem.Text = "선택한 대화 삭제";
            btn_deleteItem.UseVisualStyleBackColor = false;
            btn_deleteItem.Click += btn_deleteItem_Click;
            // 
            // btn_deleteAll
            // 
            btn_deleteAll.BackColor = Color.FromArgb(255, 192, 128);
            btn_deleteAll.Font = new Font("맑은 고딕", 15F);
            btn_deleteAll.Location = new Point(941, 613);
            btn_deleteAll.Name = "btn_deleteAll";
            btn_deleteAll.Size = new Size(325, 82);
            btn_deleteAll.TabIndex = 6;
            btn_deleteAll.Text = "대화 기록 삭제";
            btn_deleteAll.UseVisualStyleBackColor = false;
            btn_deleteAll.Click += btn_deleteAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 846);
            Controls.Add(btn_deleteAll);
            Controls.Add(btn_deleteItem);
            Controls.Add(lbl_msgCount);
            Controls.Add(btn_send);
            Controls.Add(lst_messages);
            Controls.Add(txt_input);
            Controls.Add(lbl_title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private TextBox txt_input;
        private ListBox lst_messages;
        private Button btn_send;
        private Label lbl_msgCount;
        private Button btn_deleteItem;
        private Button btn_deleteAll;
    }
}

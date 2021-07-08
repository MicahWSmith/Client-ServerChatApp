namespace ChatForm
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
            this.placeHolderLabel = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.convoLabel = new System.Windows.Forms.Label();
            this.convoTextBox = new System.Windows.Forms.TextBox();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formStrip = new System.Windows.Forms.MenuStrip();
            this.formStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeHolderLabel
            // 
            this.placeHolderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.placeHolderLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.placeHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeHolderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.placeHolderLabel.Location = new System.Drawing.Point(0, 32);
            this.placeHolderLabel.Name = "placeHolderLabel";
            this.placeHolderLabel.Size = new System.Drawing.Size(800, 264);
            this.placeHolderLabel.TabIndex = 0;
            this.placeHolderLabel.Text = "Game Goes Here";
            this.placeHolderLabel.Click += new System.EventHandler(this.placeHolderLabel_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(40, 300);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(128, 13);
            this.msgLabel.TabIndex = 2;
            this.msgLabel.Text = "Type your messages here";
            // 
            // msgTextBox
            // 
            this.msgTextBox.Location = new System.Drawing.Point(43, 316);
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(649, 20);
            this.msgTextBox.TabIndex = 3;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(713, 314);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // convoLabel
            // 
            this.convoLabel.AutoSize = true;
            this.convoLabel.Location = new System.Drawing.Point(43, 343);
            this.convoLabel.Name = "convoLabel";
            this.convoLabel.Size = new System.Drawing.Size(69, 13);
            this.convoLabel.TabIndex = 5;
            this.convoLabel.Text = "Conversation";
            // 
            // convoTextBox
            // 
            this.convoTextBox.Location = new System.Drawing.Point(46, 360);
            this.convoTextBox.Multiline = true;
            this.convoTextBox.Name = "convoTextBox";
            this.convoTextBox.ReadOnly = true;
            this.convoTextBox.Size = new System.Drawing.Size(699, 195);
            this.convoTextBox.TabIndex = 6;
            this.convoTextBox.TextChanged += new System.EventHandler(this.ConvoTextBox_TextChanged);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.networkToolStripMenuItem.Text = "Network";
            this.networkToolStripMenuItem.Click += new System.EventHandler(this.networkToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // formStrip
            // 
            this.formStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.formStrip.Location = new System.Drawing.Point(0, 0);
            this.formStrip.Name = "formStrip";
            this.formStrip.Size = new System.Drawing.Size(800, 24);
            this.formStrip.TabIndex = 1;
            this.formStrip.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.convoTextBox);
            this.Controls.Add(this.convoLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.msgTextBox);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.placeHolderLabel);
            this.Controls.Add(this.formStrip);
            this.MainMenuStrip = this.formStrip;
            this.Name = "Form1";
            this.Text = "Network Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formStrip.ResumeLayout(false);
            this.formStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placeHolderLabel;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.TextBox msgTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label convoLabel;
        private System.Windows.Forms.TextBox convoTextBox;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.MenuStrip formStrip;
    }
}


namespace NCVFirstComment
{
    partial class MainForm
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.HistoryTab = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchBotton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.HistorySearchTextBox = new System.Windows.Forms.TextBox();
            this.HistoryView = new System.Windows.Forms.DataGridView();
            this.SettingTab = new System.Windows.Forms.TabPage();
            this.No2AsNo1Comment = new System.Windows.Forms.CheckBox();
            this.excludeOwnerComment = new System.Windows.Forms.CheckBox();
            this.ReplyCommentToggle = new System.Windows.Forms.CheckBox();
            this.ReplyCommentTextBox = new System.Windows.Forms.TextBox();
            this.SettingLabel1 = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.HistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryView)).BeginInit();
            this.SettingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.HistoryTab);
            this.MainTabControl.Controls.Add(this.SettingTab);
            this.MainTabControl.Location = new System.Drawing.Point(13, 13);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(758, 535);
            this.MainTabControl.TabIndex = 0;
            // 
            // HistoryTab
            // 
            this.HistoryTab.Controls.Add(this.DeleteButton);
            this.HistoryTab.Controls.Add(this.SearchBotton);
            this.HistoryTab.Controls.Add(this.searchLabel);
            this.HistoryTab.Controls.Add(this.HistorySearchTextBox);
            this.HistoryTab.Controls.Add(this.HistoryView);
            this.HistoryTab.Location = new System.Drawing.Point(4, 24);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryTab.Size = new System.Drawing.Size(750, 507);
            this.HistoryTab.TabIndex = 0;
            this.HistoryTab.Text = "履歴";
            this.HistoryTab.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(668, 477);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchBotton
            // 
            this.SearchBotton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBotton.Location = new System.Drawing.Point(204, 477);
            this.SearchBotton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBotton.Name = "SearchBotton";
            this.SearchBotton.Size = new System.Drawing.Size(75, 23);
            this.SearchBotton.TabIndex = 3;
            this.SearchBotton.Text = "検索";
            this.SearchBotton.UseVisualStyleBackColor = true;
            this.SearchBotton.Click += new System.EventHandler(this.SearchBotton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(7, 480);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(31, 15);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "名前";
            // 
            // HistorySearchTextBox
            // 
            this.HistorySearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HistorySearchTextBox.Location = new System.Drawing.Point(46, 477);
            this.HistorySearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HistorySearchTextBox.MaxLength = 100;
            this.HistorySearchTextBox.Name = "HistorySearchTextBox";
            this.HistorySearchTextBox.Size = new System.Drawing.Size(150, 23);
            this.HistorySearchTextBox.TabIndex = 1;
            // 
            // HistoryView
            // 
            this.HistoryView.AllowUserToAddRows = false;
            this.HistoryView.AllowUserToDeleteRows = false;
            this.HistoryView.AllowUserToResizeRows = false;
            this.HistoryView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryView.Location = new System.Drawing.Point(7, 7);
            this.HistoryView.Margin = new System.Windows.Forms.Padding(4);
            this.HistoryView.MultiSelect = false;
            this.HistoryView.Name = "HistoryView";
            this.HistoryView.ReadOnly = true;
            this.HistoryView.RowHeadersVisible = false;
            this.HistoryView.RowTemplate.Height = 21;
            this.HistoryView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.HistoryView.Size = new System.Drawing.Size(736, 462);
            this.HistoryView.TabIndex = 0;
            this.HistoryView.VirtualMode = true;
            // 
            // SettingTab
            // 
            this.SettingTab.Controls.Add(this.No2AsNo1Comment);
            this.SettingTab.Controls.Add(this.excludeOwnerComment);
            this.SettingTab.Controls.Add(this.ReplyCommentToggle);
            this.SettingTab.Controls.Add(this.ReplyCommentTextBox);
            this.SettingTab.Controls.Add(this.SettingLabel1);
            this.SettingTab.Location = new System.Drawing.Point(4, 24);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Padding = new System.Windows.Forms.Padding(4, 16, 4, 4);
            this.SettingTab.Size = new System.Drawing.Size(750, 507);
            this.SettingTab.TabIndex = 1;
            this.SettingTab.Text = "設定";
            this.SettingTab.UseVisualStyleBackColor = true;
            // 
            // No2AsNo1Comment
            // 
            this.No2AsNo1Comment.AutoSize = true;
            this.No2AsNo1Comment.Checked = true;
            this.No2AsNo1Comment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.No2AsNo1Comment.Location = new System.Drawing.Point(133, 20);
            this.No2AsNo1Comment.Margin = new System.Windows.Forms.Padding(4);
            this.No2AsNo1Comment.Name = "No2AsNo1Comment";
            this.No2AsNo1Comment.Size = new System.Drawing.Size(277, 19);
            this.No2AsNo1Comment.TabIndex = 5;
            this.No2AsNo1Comment.Text = "No1が運営コメントだった場合、No2を1Get処理する";
            this.No2AsNo1Comment.UseVisualStyleBackColor = true;
            // 
            // excludeOwnerComment
            // 
            this.excludeOwnerComment.AutoSize = true;
            this.excludeOwnerComment.Checked = true;
            this.excludeOwnerComment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.excludeOwnerComment.Location = new System.Drawing.Point(8, 20);
            this.excludeOwnerComment.Margin = new System.Windows.Forms.Padding(4);
            this.excludeOwnerComment.Name = "excludeOwnerComment";
            this.excludeOwnerComment.Size = new System.Drawing.Size(117, 19);
            this.excludeOwnerComment.TabIndex = 4;
            this.excludeOwnerComment.Text = "運営コメントは除外";
            this.excludeOwnerComment.UseVisualStyleBackColor = true;
            // 
            // ReplyCommentToggle
            // 
            this.ReplyCommentToggle.AutoSize = true;
            this.ReplyCommentToggle.Checked = true;
            this.ReplyCommentToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplyCommentToggle.Location = new System.Drawing.Point(8, 47);
            this.ReplyCommentToggle.Margin = new System.Windows.Forms.Padding(4);
            this.ReplyCommentToggle.Name = "ReplyCommentToggle";
            this.ReplyCommentToggle.Size = new System.Drawing.Size(111, 19);
            this.ReplyCommentToggle.TabIndex = 2;
            this.ReplyCommentToggle.Text = "返信コメントをする";
            this.ReplyCommentToggle.UseVisualStyleBackColor = true;
            this.ReplyCommentToggle.CheckedChanged += new System.EventHandler(this.ReplyCommentToggle_CheckedChanged);
            // 
            // ReplyCommentTextBox
            // 
            this.ReplyCommentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplyCommentTextBox.Location = new System.Drawing.Point(80, 74);
            this.ReplyCommentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReplyCommentTextBox.MaxLength = 500;
            this.ReplyCommentTextBox.Name = "ReplyCommentTextBox";
            this.ReplyCommentTextBox.Size = new System.Drawing.Size(662, 23);
            this.ReplyCommentTextBox.TabIndex = 1;
            this.ReplyCommentTextBox.Text = ">>{Nickname}さん {Count}回目の1Getです";
            // 
            // SettingLabel1
            // 
            this.SettingLabel1.AutoSize = true;
            this.SettingLabel1.Location = new System.Drawing.Point(8, 77);
            this.SettingLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SettingLabel1.Name = "SettingLabel1";
            this.SettingLabel1.Size = new System.Drawing.Size(64, 15);
            this.SettingLabel1.TabIndex = 0;
            this.SettingLabel1.Text = "返信コメント";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "NFC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainTabControl.ResumeLayout(false);
            this.HistoryTab.ResumeLayout(false);
            this.HistoryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryView)).EndInit();
            this.SettingTab.ResumeLayout(false);
            this.SettingTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage HistoryTab;
        private System.Windows.Forms.TabPage SettingTab;
        private System.Windows.Forms.DataGridView HistoryView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchBotton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox HistorySearchTextBox;
        private System.Windows.Forms.TextBox ReplyCommentTextBox;
        private System.Windows.Forms.Label SettingLabel1;
        private System.Windows.Forms.CheckBox ReplyCommentToggle;
        private System.Windows.Forms.CheckBox No2AsNo1Comment;
        private System.Windows.Forms.CheckBox excludeOwnerComment;
    }
}
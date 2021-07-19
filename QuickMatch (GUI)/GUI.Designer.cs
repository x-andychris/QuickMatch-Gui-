namespace QuickMatch__GUI_
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.pickOrDiscardCardStatus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cardDeckPanel = new System.Windows.Forms.Panel();
            this.discardedCardPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlayerOrAiTurn = new System.Windows.Forms.Button();
            this.loadDeckBtn = new System.Windows.Forms.Button();
            this.playerCard1Panel = new System.Windows.Forms.Panel();
            this.playerCard4Panel = new System.Windows.Forms.Panel();
            this.playerCard3Panel = new System.Windows.Forms.Panel();
            this.aiCard6Panel = new System.Windows.Forms.Panel();
            this.playerCard6Panel = new System.Windows.Forms.Panel();
            this.aiCard5Panel = new System.Windows.Forms.Panel();
            this.playerCard5Panel = new System.Windows.Forms.Panel();
            this.aiCard4Panel = new System.Windows.Forms.Panel();
            this.aiCard3Panel = new System.Windows.Forms.Panel();
            this.aiCard2Panel = new System.Windows.Forms.Panel();
            this.playerCard2Panel = new System.Windows.Forms.Panel();
            this.aiCard1Panel = new System.Windows.Forms.Panel();
            this.btn_replay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.infoTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.pickOrDiscardCardStatus);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.cardDeckPanel);
            this.splitContainer1.Panel1.Controls.Add(this.discardedCardPanel);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel2.BackgroundImage = global::QuickMatch__GUI_.Properties.Resources.IMG_20190917_102234;
            this.splitContainer1.Panel2.Controls.Add(this.btn_replay);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.btnPlayerOrAiTurn);
            this.splitContainer1.Panel2.Controls.Add(this.loadDeckBtn);
            this.splitContainer1.Panel2.Controls.Add(this.playerCard1Panel);
            this.splitContainer1.Panel2.Controls.Add(this.playerCard4Panel);
            this.splitContainer1.Panel2.Controls.Add(this.playerCard3Panel);
            this.splitContainer1.Panel2.Controls.Add(this.aiCard6Panel);
            this.splitContainer1.Panel2.Controls.Add(this.playerCard6Panel);
            this.splitContainer1.Panel2.Controls.Add(this.aiCard5Panel);
            this.splitContainer1.Panel2.Controls.Add(this.playerCard5Panel);
            this.splitContainer1.Panel2.Controls.Add(this.aiCard4Panel);
            this.splitContainer1.Panel2.Controls.Add(this.aiCard3Panel);
            this.splitContainer1.Panel2.Controls.Add(this.aiCard2Panel);
            this.splitContainer1.Panel2.Controls.Add(this.playerCard2Panel);
            this.splitContainer1.Panel2.Controls.Add(this.aiCard1Panel);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 653);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 0;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTextBox.ForeColor = System.Drawing.Color.Blue;
            this.infoTextBox.Location = new System.Drawing.Point(13, 306);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.infoTextBox.Size = new System.Drawing.Size(282, 94);
            this.infoTextBox.TabIndex = 20;
            this.infoTextBox.Text = "To select a card, You can click on the discarded card above\r\nOr you can select a " +
    "random card from the Card Deck below";
            this.infoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.infoTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pickOrDiscardCardStatus
            // 
            this.pickOrDiscardCardStatus.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickOrDiscardCardStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pickOrDiscardCardStatus.Image = global::QuickMatch__GUI_.Properties.Resources._031;
            this.pickOrDiscardCardStatus.Location = new System.Drawing.Point(27, 257);
            this.pickOrDiscardCardStatus.Name = "pickOrDiscardCardStatus";
            this.pickOrDiscardCardStatus.Size = new System.Drawing.Size(268, 40);
            this.pickOrDiscardCardStatus.TabIndex = 19;
            this.pickOrDiscardCardStatus.Text = "Pick A Card";
            this.pickOrDiscardCardStatus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(92, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Discarded Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(119, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Card Deck";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cardDeckPanel
            // 
            this.cardDeckPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cardDeckPanel.BackgroundImage = global::QuickMatch__GUI_.Properties.Resources.Cards;
            this.cardDeckPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardDeckPanel.Location = new System.Drawing.Point(59, 424);
            this.cardDeckPanel.Name = "cardDeckPanel";
            this.cardDeckPanel.Size = new System.Drawing.Size(236, 223);
            this.cardDeckPanel.TabIndex = 7;
            this.cardDeckPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cardDeckPanel_Paint);
            this.cardDeckPanel.DoubleClick += new System.EventHandler(this.onCardDeckClicked);
            // 
            // discardedCardPanel
            // 
            this.discardedCardPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.discardedCardPanel.BackgroundImage = global::QuickMatch__GUI_.Properties.Resources.Card;
            this.discardedCardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discardedCardPanel.Location = new System.Drawing.Point(84, 34);
            this.discardedCardPanel.Name = "discardedCardPanel";
            this.discardedCardPanel.Size = new System.Drawing.Size(163, 217);
            this.discardedCardPanel.TabIndex = 6;
            this.discardedCardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.discardedCardPanel_Paint);
            this.discardedCardPanel.DoubleClick += new System.EventHandler(this.onDiscardCardClick);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(426, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "AI\'s Cards";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(292, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Player\'s Cards";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPlayerOrAiTurn
            // 
            this.btnPlayerOrAiTurn.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerOrAiTurn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlayerOrAiTurn.Image = global::QuickMatch__GUI_.Properties.Resources._031;
            this.btnPlayerOrAiTurn.Location = new System.Drawing.Point(352, 303);
            this.btnPlayerOrAiTurn.Name = "btnPlayerOrAiTurn";
            this.btnPlayerOrAiTurn.Size = new System.Drawing.Size(213, 49);
            this.btnPlayerOrAiTurn.TabIndex = 18;
            this.btnPlayerOrAiTurn.Text = "AI\'s Turn";
            this.btnPlayerOrAiTurn.UseVisualStyleBackColor = true;
            // 
            // loadDeckBtn
            // 
            this.loadDeckBtn.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDeckBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadDeckBtn.Image = global::QuickMatch__GUI_.Properties.Resources._031;
            this.loadDeckBtn.Location = new System.Drawing.Point(380, 300);
            this.loadDeckBtn.Name = "loadDeckBtn";
            this.loadDeckBtn.Size = new System.Drawing.Size(159, 59);
            this.loadDeckBtn.TabIndex = 15;
            this.loadDeckBtn.Text = "Load Deck";
            this.loadDeckBtn.UseVisualStyleBackColor = true;
            this.loadDeckBtn.Click += new System.EventHandler(this.loadDeckBtn_Click);
            // 
            // playerCard1Panel
            // 
            this.playerCard1Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerCard1Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerCard1Panel.BackgroundImage")));
            this.playerCard1Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard1Panel.Location = new System.Drawing.Point(12, 424);
            this.playerCard1Panel.Name = "playerCard1Panel";
            this.playerCard1Panel.Size = new System.Drawing.Size(126, 217);
            this.playerCard1Panel.TabIndex = 1;
            this.playerCard1Panel.DoubleClick += new System.EventHandler(this.onPlayerCard1Click);
            // 
            // playerCard4Panel
            // 
            this.playerCard4Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerCard4Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerCard4Panel.BackgroundImage")));
            this.playerCard4Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard4Panel.Location = new System.Drawing.Point(439, 385);
            this.playerCard4Panel.Name = "playerCard4Panel";
            this.playerCard4Panel.Size = new System.Drawing.Size(126, 217);
            this.playerCard4Panel.TabIndex = 4;
            this.playerCard4Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.playerCard4Panel_Paint);
            this.playerCard4Panel.DoubleClick += new System.EventHandler(this.onPlayerCard4Click);
            // 
            // playerCard3Panel
            // 
            this.playerCard3Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerCard3Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerCard3Panel.BackgroundImage")));
            this.playerCard3Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard3Panel.Location = new System.Drawing.Point(294, 433);
            this.playerCard3Panel.Name = "playerCard3Panel";
            this.playerCard3Panel.Size = new System.Drawing.Size(126, 217);
            this.playerCard3Panel.TabIndex = 3;
            this.playerCard3Panel.DoubleClick += new System.EventHandler(this.onPlayerCard3Click);
            // 
            // aiCard6Panel
            // 
            this.aiCard6Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aiCard6Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aiCard6Panel.BackgroundImage")));
            this.aiCard6Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aiCard6Panel.Location = new System.Drawing.Point(732, 24);
            this.aiCard6Panel.Name = "aiCard6Panel";
            this.aiCard6Panel.Size = new System.Drawing.Size(126, 217);
            this.aiCard6Panel.TabIndex = 12;
            // 
            // playerCard6Panel
            // 
            this.playerCard6Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerCard6Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerCard6Panel.BackgroundImage")));
            this.playerCard6Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard6Panel.Location = new System.Drawing.Point(732, 314);
            this.playerCard6Panel.Name = "playerCard6Panel";
            this.playerCard6Panel.Size = new System.Drawing.Size(126, 217);
            this.playerCard6Panel.TabIndex = 6;
            this.playerCard6Panel.DoubleClick += new System.EventHandler(this.onPlayerCard6Click);
            // 
            // aiCard5Panel
            // 
            this.aiCard5Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aiCard5Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aiCard5Panel.BackgroundImage")));
            this.aiCard5Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aiCard5Panel.Location = new System.Drawing.Point(585, 60);
            this.aiCard5Panel.Name = "aiCard5Panel";
            this.aiCard5Panel.Size = new System.Drawing.Size(126, 217);
            this.aiCard5Panel.TabIndex = 11;
            // 
            // playerCard5Panel
            // 
            this.playerCard5Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerCard5Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerCard5Panel.BackgroundImage")));
            this.playerCard5Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard5Panel.Location = new System.Drawing.Point(585, 424);
            this.playerCard5Panel.Name = "playerCard5Panel";
            this.playerCard5Panel.Size = new System.Drawing.Size(126, 217);
            this.playerCard5Panel.TabIndex = 5;
            this.playerCard5Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            this.playerCard5Panel.DoubleClick += new System.EventHandler(this.onPlayerCard5Click);
            // 
            // aiCard4Panel
            // 
            this.aiCard4Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aiCard4Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aiCard4Panel.BackgroundImage")));
            this.aiCard4Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aiCard4Panel.Location = new System.Drawing.Point(439, 12);
            this.aiCard4Panel.Name = "aiCard4Panel";
            this.aiCard4Panel.Size = new System.Drawing.Size(126, 217);
            this.aiCard4Panel.TabIndex = 10;
            // 
            // aiCard3Panel
            // 
            this.aiCard3Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aiCard3Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aiCard3Panel.BackgroundImage")));
            this.aiCard3Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aiCard3Panel.Location = new System.Drawing.Point(294, 60);
            this.aiCard3Panel.Name = "aiCard3Panel";
            this.aiCard3Panel.Size = new System.Drawing.Size(126, 217);
            this.aiCard3Panel.TabIndex = 9;
            // 
            // aiCard2Panel
            // 
            this.aiCard2Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aiCard2Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aiCard2Panel.BackgroundImage")));
            this.aiCard2Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aiCard2Panel.Location = new System.Drawing.Point(153, 24);
            this.aiCard2Panel.Name = "aiCard2Panel";
            this.aiCard2Panel.Size = new System.Drawing.Size(126, 217);
            this.aiCard2Panel.TabIndex = 8;
            this.aiCard2Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // playerCard2Panel
            // 
            this.playerCard2Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerCard2Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerCard2Panel.BackgroundImage")));
            this.playerCard2Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard2Panel.Location = new System.Drawing.Point(153, 385);
            this.playerCard2Panel.Name = "playerCard2Panel";
            this.playerCard2Panel.Size = new System.Drawing.Size(126, 217);
            this.playerCard2Panel.TabIndex = 2;
            this.playerCard2Panel.DoubleClick += new System.EventHandler(this.onPlayerCard2Click);
            // 
            // aiCard1Panel
            // 
            this.aiCard1Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aiCard1Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aiCard1Panel.BackgroundImage")));
            this.aiCard1Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aiCard1Panel.Location = new System.Drawing.Point(12, 94);
            this.aiCard1Panel.Name = "aiCard1Panel";
            this.aiCard1Panel.Size = new System.Drawing.Size(126, 217);
            this.aiCard1Panel.TabIndex = 7;
            // 
            // btn_replay
            // 
            this.btn_replay.BackgroundImage = global::QuickMatch__GUI_.Properties.Resources._031;
            this.btn_replay.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_replay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_replay.Location = new System.Drawing.Point(571, 303);
            this.btn_replay.Name = "btn_replay";
            this.btn_replay.Size = new System.Drawing.Size(94, 49);
            this.btn_replay.TabIndex = 21;
            this.btn_replay.Text = "Replay";
            this.btn_replay.UseVisualStyleBackColor = true;
            this.btn_replay.Click += new System.EventHandler(this.btn_replay_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "GUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Match";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel discardedCardPanel;
        private System.Windows.Forms.Panel playerCard1Panel;
        private System.Windows.Forms.Panel playerCard4Panel;
        private System.Windows.Forms.Panel playerCard3Panel;
        private System.Windows.Forms.Panel aiCard6Panel;
        private System.Windows.Forms.Panel playerCard6Panel;
        private System.Windows.Forms.Panel aiCard5Panel;
        private System.Windows.Forms.Panel playerCard5Panel;
        private System.Windows.Forms.Panel aiCard4Panel;
        private System.Windows.Forms.Panel aiCard3Panel;
        private System.Windows.Forms.Panel aiCard2Panel;
        private System.Windows.Forms.Panel playerCard2Panel;
        private System.Windows.Forms.Panel cardDeckPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadDeckBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlayerOrAiTurn;
        private System.Windows.Forms.Button pickOrDiscardCardStatus;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Panel aiCard1Panel;
        private System.Windows.Forms.Button btn_replay;
    }
}


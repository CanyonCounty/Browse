﻿namespace Browse
{
  partial class frmMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.btnOpen = new System.Windows.Forms.Button();
      this.cboBrowsers = new System.Windows.Forms.ComboBox();
      this.lblChoose = new System.Windows.Forms.Label();
      this.lblRoot = new System.Windows.Forms.Label();
      this.txtRoot = new System.Windows.Forms.TextBox();
      this.cbPause = new System.Windows.Forms.CheckBox();
      this.lblPages = new System.Windows.Forms.Label();
      this.txtPages = new System.Windows.Forms.TextBox();
      this.udPause = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.pnlMsg = new System.Windows.Forms.Panel();
      this.pnlMsgText = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
      this.btnAccept = new System.Windows.Forms.Button();
            this.udRepeat = new System.Windows.Forms.NumericUpDown();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.udPause)).BeginInit();
      this.pnlMsg.SuspendLayout();
      this.pnlMsgText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRepeat)).BeginInit();
      this.SuspendLayout();
      // 
      // btnOpen
      // 
      this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOpen.Location = new System.Drawing.Point(239, 12);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(48, 48);
      this.btnOpen.TabIndex = 1;
      this.btnOpen.Text = "Open";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // cboBrowsers
      // 
      this.cboBrowsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cboBrowsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboBrowsers.FormattingEnabled = true;
      this.cboBrowsers.Location = new System.Drawing.Point(12, 29);
      this.cboBrowsers.Name = "cboBrowsers";
      this.cboBrowsers.Size = new System.Drawing.Size(212, 21);
      this.cboBrowsers.TabIndex = 0;
      this.cboBrowsers.SelectedIndexChanged += new System.EventHandler(this.cboBrowsers_SelectedIndexChanged);
      // 
      // lblChoose
      // 
      this.lblChoose.AutoSize = true;
      this.lblChoose.Location = new System.Drawing.Point(9, 13);
      this.lblChoose.Name = "lblChoose";
      this.lblChoose.Size = new System.Drawing.Size(109, 13);
      this.lblChoose.TabIndex = 2;
      this.lblChoose.Text = "Choose Your Browser";
      // 
      // lblRoot
      // 
      this.lblRoot.AutoSize = true;
      this.lblRoot.Location = new System.Drawing.Point(10, 72);
      this.lblRoot.Name = "lblRoot";
      this.lblRoot.Size = new System.Drawing.Size(55, 13);
      this.lblRoot.TabIndex = 3;
      this.lblRoot.Text = "Root URL";
      // 
      // txtRoot
      // 
      this.txtRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRoot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
      this.txtRoot.Location = new System.Drawing.Point(13, 88);
      this.txtRoot.Name = "txtRoot";
      this.txtRoot.Size = new System.Drawing.Size(274, 20);
      this.txtRoot.TabIndex = 4;
      this.txtRoot.Text = "www.canyonco.org";
      // 
      // cbPause
      // 
      this.cbPause.AutoSize = true;
      this.cbPause.Checked = true;
      this.cbPause.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbPause.Location = new System.Drawing.Point(13, 115);
      this.cbPause.Name = "cbPause";
      this.cbPause.Size = new System.Drawing.Size(184, 17);
      this.cbPause.TabIndex = 5;
      this.cbPause.Text = "Pause after first page (allow login)";
      this.cbPause.UseVisualStyleBackColor = true;
      // 
      // lblPages
      // 
      this.lblPages.AutoSize = true;
      this.lblPages.Location = new System.Drawing.Point(10, 163);
      this.lblPages.Name = "lblPages";
      this.lblPages.Size = new System.Drawing.Size(37, 13);
      this.lblPages.TabIndex = 6;
      this.lblPages.Text = "Pages";
      // 
      // txtPages
      // 
      this.txtPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPages.Location = new System.Drawing.Point(13, 179);
      this.txtPages.Multiline = true;
      this.txtPages.Name = "txtPages";
      this.txtPages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPages.Size = new System.Drawing.Size(274, 111);
      this.txtPages.TabIndex = 8;
      this.txtPages.Text = resources.GetString("txtPages.Text");
      this.txtPages.WordWrap = false;
      // 
      // udPause
      // 
      this.udPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.udPause.Location = new System.Drawing.Point(159, 138);
      this.udPause.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
      this.udPause.Name = "udPause";
      this.udPause.Size = new System.Drawing.Size(128, 20);
      this.udPause.TabIndex = 7;
      this.udPause.ThousandsSeparator = true;
      this.udPause.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 140);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(143, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Delay (in ms) between pages";
      // 
      // pnlMsg
      // 
      this.pnlMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlMsg.BackColor = System.Drawing.SystemColors.Highlight;
      this.pnlMsg.Controls.Add(this.pnlMsgText);
      this.pnlMsg.Location = new System.Drawing.Point(13, 114);
      this.pnlMsg.Name = "pnlMsg";
      this.pnlMsg.Size = new System.Drawing.Size(274, 200);
      this.pnlMsg.TabIndex = 10;
      this.pnlMsg.Visible = false;
      // 
      // pnlMsgText
      // 
      this.pnlMsgText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlMsgText.BackColor = System.Drawing.SystemColors.Control;
      this.pnlMsgText.Controls.Add(this.lblMessage);
      this.pnlMsgText.Controls.Add(this.btnAccept);
      this.pnlMsgText.Location = new System.Drawing.Point(3, 3);
      this.pnlMsgText.Name = "pnlMsgText";
      this.pnlMsgText.Size = new System.Drawing.Size(268, 194);
      this.pnlMsgText.TabIndex = 0;
      // 
      // lblMessage
      // 
      this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblMessage.Location = new System.Drawing.Point(15, 18);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(241, 123);
      this.lblMessage.TabIndex = 1;
      this.lblMessage.Text = "There was an error, or something";
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAccept.Location = new System.Drawing.Point(95, 144);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // udRepeat
            // 
            this.udRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.udRepeat.Location = new System.Drawing.Point(159, 294);
            this.udRepeat.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.udRepeat.Name = "udRepeat";
            this.udRepeat.Size = new System.Drawing.Size(128, 20);
            this.udRepeat.TabIndex = 11;
            this.udRepeat.ThousandsSeparator = true;
            this.udRepeat.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.Location = new System.Drawing.Point(51, 295);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(102, 17);
            this.cbRepeat.TabIndex = 12;
            this.cbRepeat.Text = "Repeat (x times)";
            this.cbRepeat.UseVisualStyleBackColor = true;
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(299, 326);
      this.Controls.Add(this.pnlMsg);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.udPause);
      this.Controls.Add(this.txtPages);
      this.Controls.Add(this.lblPages);
      this.Controls.Add(this.cbPause);
      this.Controls.Add(this.txtRoot);
      this.Controls.Add(this.lblRoot);
      this.Controls.Add(this.lblChoose);
      this.Controls.Add(this.cboBrowsers);
      this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cbRepeat);
            this.Controls.Add(this.udRepeat);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "frmMain";
      this.Opacity = 0.95D;
      this.Text = "Launcher";
      this.TopMost = true;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
      this.Load += new System.EventHandler(this.frmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.udPause)).EndInit();
      this.pnlMsg.ResumeLayout(false);
      this.pnlMsgText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udRepeat)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.ComboBox cboBrowsers;
    private System.Windows.Forms.Label lblChoose;
    private System.Windows.Forms.Label lblRoot;
    private System.Windows.Forms.TextBox txtRoot;
    private System.Windows.Forms.CheckBox cbPause;
    private System.Windows.Forms.Label lblPages;
    private System.Windows.Forms.TextBox txtPages;
    private System.Windows.Forms.NumericUpDown udPause;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel pnlMsg;
    private System.Windows.Forms.Panel pnlMsgText;
    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.Button btnAccept;
    private System.Windows.Forms.NumericUpDown udRepeat;
    private System.Windows.Forms.CheckBox cbRepeat;
  }
}


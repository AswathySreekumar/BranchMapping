namespace Settings_Replication
{
    partial class txtDatabase
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
            this.sptCMapping = new System.Windows.Forms.SplitContainer();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtbranchName = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lstBranch = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sptCMapping)).BeginInit();
            this.sptCMapping.Panel1.SuspendLayout();
            this.sptCMapping.Panel2.SuspendLayout();
            this.sptCMapping.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // sptCMapping
            // 
            this.sptCMapping.IsSplitterFixed = true;
            this.sptCMapping.Location = new System.Drawing.Point(6, 6);
            this.sptCMapping.Name = "sptCMapping";
            this.sptCMapping.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptCMapping.Panel1
            // 
            this.sptCMapping.Panel1.Controls.Add(this.grpDetails);
            this.sptCMapping.Panel1.Controls.Add(this.lstBranch);
            // 
            // sptCMapping.Panel2
            // 
            this.sptCMapping.Panel2.Controls.Add(this.btnBack);
            this.sptCMapping.Panel2.Controls.Add(this.lblUpdate);
            this.sptCMapping.Size = new System.Drawing.Size(411, 233);
            this.sptCMapping.SplitterDistance = 195;
            this.sptCMapping.TabIndex = 22;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtbranchName);
            this.grpDetails.Controls.Add(this.txtServer);
            this.grpDetails.Controls.Add(this.txtPort);
            this.grpDetails.Controls.Add(this.lblPort);
            this.grpDetails.Controls.Add(this.txtDb);
            this.grpDetails.Controls.Add(this.lblDatabase);
            this.grpDetails.Controls.Add(this.lblServer);
            this.grpDetails.Location = new System.Drawing.Point(117, 7);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(287, 183);
            this.grpDetails.TabIndex = 11;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Branch Details";
            // 
            // txtbranchName
            // 
            this.txtbranchName.Location = new System.Drawing.Point(25, 38);
            this.txtbranchName.Multiline = true;
            this.txtbranchName.Name = "txtbranchName";
            this.txtbranchName.ReadOnly = true;
            this.txtbranchName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbranchName.ShortcutsEnabled = false;
            this.txtbranchName.Size = new System.Drawing.Size(237, 20);
            this.txtbranchName.TabIndex = 8;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(131, 83);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 12;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(131, 147);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 18;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(52, 150);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 16;
            this.lblPort.Text = "Port";
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(131, 114);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(100, 20);
            this.txtDb.TabIndex = 15;
            this.txtDb.TextChanged += new System.EventHandler(this.txtDb_TextChanged_1);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(52, 117);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 13;
            this.lblDatabase.Text = "Database";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(52, 86);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 10;
            this.lblServer.Text = "Server";
            // 
            // lstBranch
            // 
            this.lstBranch.FormattingEnabled = true;
            this.lstBranch.Location = new System.Drawing.Point(6, 38);
            this.lstBranch.Name = "lstBranch";
            this.lstBranch.Size = new System.Drawing.Size(96, 121);
            this.lstBranch.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(237, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoEllipsis = true;
            this.lblUpdate.Location = new System.Drawing.Point(324, 6);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(77, 23);
            this.lblUpdate.TabIndex = 23;
            this.lblUpdate.Text = "Update";
            this.lblUpdate.UseVisualStyleBackColor = true;
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // txtDatabase
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 244);
            this.Controls.Add(this.sptCMapping);
            this.MaximizeBox = false;
            this.Name = "txtDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.sptCMapping.Panel1.ResumeLayout(false);
            this.sptCMapping.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptCMapping)).EndInit();
            this.sptCMapping.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer sptCMapping;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtbranchName;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ListBox lstBranch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button lblUpdate;
    }
}


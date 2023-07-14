namespace OPCTestApp
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
         components = new System.ComponentModel.Container();
         grpConnStr = new GroupBox();
         btnConnect2 = new Button();
         btnConnect1 = new Button();
         label3 = new Label();
         label2 = new Label();
         label1 = new Label();
         tbPassword = new TextBox();
         tbUser = new TextBox();
         tbServer = new TextBox();
         btnAllTags = new Button();
         grpAllTags = new GroupBox();
         listTags = new ListBox();
         grpTagValues = new GroupBox();
         btnClearValues = new Button();
         listTagValues = new ListBox();
         dgTagValues = new DataGridView();
         label5 = new Label();
         btnTagValues = new Button();
         grpSubscribe = new GroupBox();
         listSubscribed = new ListBox();
         label4 = new Label();
         rtbSubscriptionUpdate = new RichTextBox();
         btnUnSubscribe = new Button();
         grpTagUpdates = new GroupBox();
         label9 = new Label();
         tbTagName = new TextBox();
         label8 = new Label();
         tbValueUpdate = new TextBox();
         rtbUpdateInfo = new RichTextBox();
         cbDataType = new ComboBox();
         label7 = new Label();
         label6 = new Label();
         tbTagId = new TextBox();
         btnTagUpdate = new Button();
         cmTreeView = new ContextMenuStrip(components);
         toolStripMenuItem1 = new ToolStripMenuItem();
         toolStripMenuItem2 = new ToolStripMenuItem();
         toolStripMenuItem3 = new ToolStripMenuItem();
         dgDebug = new DataGridView();
         btnSimulation = new Button();
         grpConnStr.SuspendLayout();
         grpAllTags.SuspendLayout();
         grpTagValues.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)dgTagValues).BeginInit();
         grpSubscribe.SuspendLayout();
         grpTagUpdates.SuspendLayout();
         cmTreeView.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)dgDebug).BeginInit();
         SuspendLayout();
         // 
         // grpConnStr
         // 
         grpConnStr.Controls.Add(btnConnect2);
         grpConnStr.Controls.Add(btnConnect1);
         grpConnStr.Controls.Add(label3);
         grpConnStr.Controls.Add(label2);
         grpConnStr.Controls.Add(label1);
         grpConnStr.Controls.Add(tbPassword);
         grpConnStr.Controls.Add(tbUser);
         grpConnStr.Controls.Add(tbServer);
         grpConnStr.Location = new Point(12, 12);
         grpConnStr.Name = "grpConnStr";
         grpConnStr.Size = new Size(966, 75);
         grpConnStr.TabIndex = 0;
         grpConnStr.TabStop = false;
         grpConnStr.Text = "Connection String";
         // 
         // btnConnect2
         // 
         btnConnect2.Enabled = false;
         btnConnect2.Location = new Point(819, 35);
         btnConnect2.Name = "btnConnect2";
         btnConnect2.Size = new Size(125, 23);
         btnConnect2.TabIndex = 6;
         btnConnect2.Text = "Connect [Traeger]";
         btnConnect2.UseVisualStyleBackColor = true;
         btnConnect2.Click += btnConnectTraeger_Click;
         // 
         // btnConnect1
         // 
         btnConnect1.Location = new Point(687, 35);
         btnConnect1.Name = "btnConnect1";
         btnConnect1.Size = new Size(125, 23);
         btnConnect1.TabIndex = 5;
         btnConnect1.Text = "Connect [OPC Labs]";
         btnConnect1.UseVisualStyleBackColor = true;
         btnConnect1.Click += btnConnectOPCLabs_Click;
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(515, 17);
         label3.Name = "label3";
         label3.Size = new Size(57, 15);
         label3.TabIndex = 4;
         label3.Text = "Password";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(335, 17);
         label2.Name = "label2";
         label2.Size = new Size(60, 15);
         label2.TabIndex = 4;
         label2.Text = "Username";
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(17, 19);
         label1.Name = "label1";
         label1.Size = new Size(63, 15);
         label1.TabIndex = 3;
         label1.Text = "Server URL";
         // 
         // tbPassword
         // 
         tbPassword.Location = new Point(511, 35);
         tbPassword.Name = "tbPassword";
         tbPassword.Size = new Size(165, 23);
         tbPassword.TabIndex = 2;
         // 
         // tbUser
         // 
         tbUser.Location = new Point(335, 35);
         tbUser.Name = "tbUser";
         tbUser.Size = new Size(170, 23);
         tbUser.TabIndex = 1;
         // 
         // tbServer
         // 
         tbServer.Location = new Point(17, 34);
         tbServer.Name = "tbServer";
         tbServer.Size = new Size(312, 23);
         tbServer.TabIndex = 0;
         // 
         // btnAllTags
         // 
         btnAllTags.Location = new Point(6, 34);
         btnAllTags.Name = "btnAllTags";
         btnAllTags.Size = new Size(225, 23);
         btnAllTags.TabIndex = 1;
         btnAllTags.Text = "Get All Tags";
         btnAllTags.UseVisualStyleBackColor = true;
         btnAllTags.Click += btnAllTags_Click;
         // 
         // grpAllTags
         // 
         grpAllTags.Controls.Add(listTags);
         grpAllTags.Controls.Add(btnAllTags);
         grpAllTags.Location = new Point(12, 107);
         grpAllTags.Name = "grpAllTags";
         grpAllTags.Size = new Size(237, 372);
         grpAllTags.TabIndex = 2;
         grpAllTags.TabStop = false;
         grpAllTags.Text = "List All Tags";
         // 
         // listTags
         // 
         listTags.FormattingEnabled = true;
         listTags.ItemHeight = 15;
         listTags.Location = new Point(7, 61);
         listTags.Name = "listTags";
         listTags.Size = new Size(224, 304);
         listTags.TabIndex = 2;
         // 
         // grpTagValues
         // 
         grpTagValues.Controls.Add(btnClearValues);
         grpTagValues.Controls.Add(listTagValues);
         grpTagValues.Controls.Add(dgTagValues);
         grpTagValues.Controls.Add(label5);
         grpTagValues.Controls.Add(btnTagValues);
         grpTagValues.Location = new Point(255, 107);
         grpTagValues.Name = "grpTagValues";
         grpTagValues.Size = new Size(237, 372);
         grpTagValues.TabIndex = 3;
         grpTagValues.TabStop = false;
         grpTagValues.Text = "Get values for list of Tags";
         // 
         // btnClearValues
         // 
         btnClearValues.Location = new Point(122, 169);
         btnClearValues.Name = "btnClearValues";
         btnClearValues.Size = new Size(109, 23);
         btnClearValues.TabIndex = 9;
         btnClearValues.Text = "Clear";
         btnClearValues.UseVisualStyleBackColor = true;
         btnClearValues.Click += btnClearValues_Click;
         // 
         // listTagValues
         // 
         listTagValues.FormattingEnabled = true;
         listTagValues.ItemHeight = 15;
         listTagValues.Location = new Point(6, 39);
         listTagValues.Name = "listTagValues";
         listTagValues.Size = new Size(225, 124);
         listTagValues.TabIndex = 8;
         // 
         // dgTagValues
         // 
         dgTagValues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgTagValues.Location = new Point(6, 198);
         dgTagValues.Name = "dgTagValues";
         dgTagValues.RowTemplate.Height = 25;
         dgTagValues.Size = new Size(225, 159);
         dgTagValues.TabIndex = 7;
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Location = new Point(6, 19);
         label5.Name = "label5";
         label5.Size = new Size(95, 15);
         label5.TabIndex = 6;
         label5.Text = "Enter List of Tags";
         // 
         // btnTagValues
         // 
         btnTagValues.Location = new Point(6, 169);
         btnTagValues.Name = "btnTagValues";
         btnTagValues.Size = new Size(115, 23);
         btnTagValues.TabIndex = 1;
         btnTagValues.Text = "Get Tag Values";
         btnTagValues.UseVisualStyleBackColor = true;
         btnTagValues.Click += btnTagValues_Click;
         // 
         // grpSubscribe
         // 
         grpSubscribe.Controls.Add(listSubscribed);
         grpSubscribe.Controls.Add(label4);
         grpSubscribe.Controls.Add(rtbSubscriptionUpdate);
         grpSubscribe.Controls.Add(btnUnSubscribe);
         grpSubscribe.Location = new Point(498, 107);
         grpSubscribe.Name = "grpSubscribe";
         grpSubscribe.Size = new Size(237, 372);
         grpSubscribe.TabIndex = 4;
         grpSubscribe.TabStop = false;
         grpSubscribe.Text = "Subscription, Value Change Event";
         // 
         // listSubscribed
         // 
         listSubscribed.FormattingEnabled = true;
         listSubscribed.ItemHeight = 15;
         listSubscribed.Location = new Point(6, 39);
         listSubscribed.Name = "listSubscribed";
         listSubscribed.Size = new Size(225, 124);
         listSubscribed.TabIndex = 9;
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(6, 19);
         label4.Name = "label4";
         label4.Size = new Size(142, 15);
         label4.TabIndex = 5;
         label4.Text = "Add new Tag to subscribe";
         // 
         // rtbSubscriptionUpdate
         // 
         rtbSubscriptionUpdate.Location = new Point(6, 207);
         rtbSubscriptionUpdate.Name = "rtbSubscriptionUpdate";
         rtbSubscriptionUpdate.Size = new Size(223, 150);
         rtbSubscriptionUpdate.TabIndex = 3;
         rtbSubscriptionUpdate.Text = "";
         // 
         // btnUnSubscribe
         // 
         btnUnSubscribe.Location = new Point(6, 169);
         btnUnSubscribe.Name = "btnUnSubscribe";
         btnUnSubscribe.Size = new Size(225, 23);
         btnUnSubscribe.TabIndex = 1;
         btnUnSubscribe.Text = "UnSubscribe All";
         btnUnSubscribe.UseVisualStyleBackColor = true;
         btnUnSubscribe.Click += btnUnSubscribe_Click;
         // 
         // grpTagUpdates
         // 
         grpTagUpdates.Controls.Add(label9);
         grpTagUpdates.Controls.Add(tbTagName);
         grpTagUpdates.Controls.Add(label8);
         grpTagUpdates.Controls.Add(tbValueUpdate);
         grpTagUpdates.Controls.Add(rtbUpdateInfo);
         grpTagUpdates.Controls.Add(cbDataType);
         grpTagUpdates.Controls.Add(label7);
         grpTagUpdates.Controls.Add(label6);
         grpTagUpdates.Controls.Add(tbTagId);
         grpTagUpdates.Controls.Add(btnTagUpdate);
         grpTagUpdates.Location = new Point(741, 107);
         grpTagUpdates.Name = "grpTagUpdates";
         grpTagUpdates.Size = new Size(237, 372);
         grpTagUpdates.TabIndex = 5;
         grpTagUpdates.TabStop = false;
         grpTagUpdates.Text = "Tag Value Update";
         // 
         // label9
         // 
         label9.AutoSize = true;
         label9.Location = new Point(6, 76);
         label9.Name = "label9";
         label9.Size = new Size(61, 15);
         label9.TabIndex = 12;
         label9.Text = "Tag name ";
         // 
         // tbTagName
         // 
         tbTagName.Location = new Point(6, 95);
         tbTagName.Name = "tbTagName";
         tbTagName.Size = new Size(219, 23);
         tbTagName.TabIndex = 11;
         // 
         // label8
         // 
         label8.AutoSize = true;
         label8.Location = new Point(8, 170);
         label8.Name = "label8";
         label8.Size = new Size(35, 15);
         label8.TabIndex = 10;
         label8.Text = "Value";
         // 
         // tbValueUpdate
         // 
         tbValueUpdate.Location = new Point(8, 189);
         tbValueUpdate.Name = "tbValueUpdate";
         tbValueUpdate.Size = new Size(219, 23);
         tbValueUpdate.TabIndex = 9;
         // 
         // rtbUpdateInfo
         // 
         rtbUpdateInfo.Location = new Point(8, 246);
         rtbUpdateInfo.Name = "rtbUpdateInfo";
         rtbUpdateInfo.Size = new Size(217, 111);
         rtbUpdateInfo.TabIndex = 8;
         rtbUpdateInfo.Text = "";
         // 
         // cbDataType
         // 
         cbDataType.FormattingEnabled = true;
         cbDataType.Location = new Point(8, 144);
         cbDataType.Name = "cbDataType";
         cbDataType.Size = new Size(217, 23);
         cbDataType.TabIndex = 7;
         // 
         // label7
         // 
         label7.AutoSize = true;
         label7.Location = new Point(6, 125);
         label7.Name = "label7";
         label7.Size = new Size(58, 15);
         label7.TabIndex = 6;
         label7.Text = "Data Type";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.Location = new Point(6, 31);
         label6.Name = "label6";
         label6.Size = new Size(38, 15);
         label6.TabIndex = 5;
         label6.Text = "Tag Id";
         // 
         // tbTagId
         // 
         tbTagId.Location = new Point(6, 50);
         tbTagId.Name = "tbTagId";
         tbTagId.Size = new Size(219, 23);
         tbTagId.TabIndex = 4;
         // 
         // btnTagUpdate
         // 
         btnTagUpdate.Location = new Point(8, 217);
         btnTagUpdate.Name = "btnTagUpdate";
         btnTagUpdate.Size = new Size(219, 23);
         btnTagUpdate.TabIndex = 1;
         btnTagUpdate.Text = "Update";
         btnTagUpdate.UseVisualStyleBackColor = true;
         btnTagUpdate.Click += btnTagUpdate_Click;
         // 
         // cmTreeView
         // 
         cmTreeView.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
         cmTreeView.Name = "cmTreeView";
         cmTreeView.Size = new Size(245, 70);
         cmTreeView.ItemClicked += cmTreeView_ItemClicked;
         // 
         // toolStripMenuItem1
         // 
         toolStripMenuItem1.Name = "toolStripMenuItem1";
         toolStripMenuItem1.Size = new Size(244, 22);
         toolStripMenuItem1.Text = "Get TagValue(s)";
         // 
         // toolStripMenuItem2
         // 
         toolStripMenuItem2.Name = "toolStripMenuItem2";
         toolStripMenuItem2.Size = new Size(244, 22);
         toolStripMenuItem2.Text = "Subscribe TagValue(s) Change(s)";
         // 
         // toolStripMenuItem3
         // 
         toolStripMenuItem3.Name = "toolStripMenuItem3";
         toolStripMenuItem3.Size = new Size(244, 22);
         toolStripMenuItem3.Text = "Update TagValue(s)";
         // 
         // dgDebug
         // 
         dgDebug.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgDebug.Location = new Point(16, 500);
         dgDebug.Name = "dgDebug";
         dgDebug.RowTemplate.Height = 25;
         dgDebug.Size = new Size(962, 199);
         dgDebug.TabIndex = 6;
         // 
         // btnSimulation
         // 
         btnSimulation.Location = new Point(20, 709);
         btnSimulation.Name = "btnSimulation";
         btnSimulation.Size = new Size(163, 23);
         btnSimulation.TabIndex = 7;
         btnSimulation.Text = "Launch Simulation";
         btnSimulation.UseVisualStyleBackColor = true;
         btnSimulation.Click += btnSimulation_Click;
         // 
         // MainForm
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(994, 736);
         Controls.Add(btnSimulation);
         Controls.Add(dgDebug);
         Controls.Add(grpTagUpdates);
         Controls.Add(grpSubscribe);
         Controls.Add(grpTagValues);
         Controls.Add(grpAllTags);
         Controls.Add(grpConnStr);
         Name = "MainForm";
         Text = "OPC Client Test";
         Load += MainForm_Load;
         grpConnStr.ResumeLayout(false);
         grpConnStr.PerformLayout();
         grpAllTags.ResumeLayout(false);
         grpTagValues.ResumeLayout(false);
         grpTagValues.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)dgTagValues).EndInit();
         grpSubscribe.ResumeLayout(false);
         grpSubscribe.PerformLayout();
         grpTagUpdates.ResumeLayout(false);
         grpTagUpdates.PerformLayout();
         cmTreeView.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)dgDebug).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private GroupBox grpConnStr;
      private Button btnConnect1;
      private Label label3;
      private Label label2;
      private Label label1;
      private TextBox tbPassword;
      private TextBox tbUser;
      private TextBox tbServer;
      private Button btnAllTags;
      private GroupBox grpAllTags;
      private GroupBox grpTagValues;
      private Button btnTagValues;
      private GroupBox grpSubscribe;
      private RichTextBox rtbSubscriptionUpdate;
      private Button btnUnSubscribe;
      private Label label5;
      private Label label4;
      private Button btnConnect2;
      private GroupBox grpTagUpdates;
      private Label label6;
      private TextBox tbTagId;
      private Button btnTagUpdate;
      private ComboBox cbDataType;
      private Label label7;
      private RichTextBox rtbUpdateInfo;
      private DataGridView dgTagValues;
      private ContextMenuStrip cmTreeView;
      private ToolStripMenuItem toolStripMenuItem1;
      private ToolStripMenuItem toolStripMenuItem2;
      private ToolStripMenuItem toolStripMenuItem3;
      private ListBox listTags;
      private ListBox listTagValues;
      private ListBox listSubscribed;
      private Label label8;
      private TextBox tbValueUpdate;
      private Button btnClearValues;
      private Label label9;
      private TextBox tbTagName;
      private DataGridView dgDebug;
      private Button btnSimulation;
   }
}
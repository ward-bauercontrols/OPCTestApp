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
         groupBox1 = new GroupBox();
         btnConnect2 = new Button();
         btnConnect1 = new Button();
         label3 = new Label();
         label2 = new Label();
         label1 = new Label();
         tbPassword = new TextBox();
         tbUser = new TextBox();
         tbServer = new TextBox();
         btnAllTags = new Button();
         groupBox2 = new GroupBox();
         tvAllTags = new TreeView();
         groupBox3 = new GroupBox();
         label5 = new Label();
         rtbTagNameList = new RichTextBox();
         btnTagValues = new Button();
         groupBox4 = new GroupBox();
         label4 = new Label();
         tbSubscriveTag = new TextBox();
         rtbSubscriptionUpdate = new RichTextBox();
         btnSubscribe = new Button();
         groupBox5 = new GroupBox();
         rtbUpdateInfo = new RichTextBox();
         cbDataType = new ComboBox();
         label7 = new Label();
         label6 = new Label();
         tbTagname = new TextBox();
         btnTagUpdate = new Button();
         lblStatus = new Label();
         dgTagValues = new DataGridView();
         groupBox1.SuspendLayout();
         groupBox2.SuspendLayout();
         groupBox3.SuspendLayout();
         groupBox4.SuspendLayout();
         groupBox5.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)dgTagValues).BeginInit();
         SuspendLayout();
         // 
         // groupBox1
         // 
         groupBox1.Controls.Add(btnConnect2);
         groupBox1.Controls.Add(btnConnect1);
         groupBox1.Controls.Add(label3);
         groupBox1.Controls.Add(label2);
         groupBox1.Controls.Add(label1);
         groupBox1.Controls.Add(tbPassword);
         groupBox1.Controls.Add(tbUser);
         groupBox1.Controls.Add(tbServer);
         groupBox1.Location = new Point(12, 12);
         groupBox1.Name = "groupBox1";
         groupBox1.Size = new Size(966, 75);
         groupBox1.TabIndex = 0;
         groupBox1.TabStop = false;
         groupBox1.Text = "Connection String";
         // 
         // btnConnect2
         // 
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
         // groupBox2
         // 
         groupBox2.Controls.Add(tvAllTags);
         groupBox2.Controls.Add(btnAllTags);
         groupBox2.Location = new Point(12, 107);
         groupBox2.Name = "groupBox2";
         groupBox2.Size = new Size(237, 372);
         groupBox2.TabIndex = 2;
         groupBox2.TabStop = false;
         groupBox2.Text = "List All Tags";
         // 
         // tvAllTags
         // 
         tvAllTags.Location = new Point(6, 63);
         tvAllTags.Name = "tvAllTags";
         tvAllTags.Size = new Size(225, 294);
         tvAllTags.TabIndex = 2;
         // 
         // groupBox3
         // 
         groupBox3.Controls.Add(dgTagValues);
         groupBox3.Controls.Add(label5);
         groupBox3.Controls.Add(rtbTagNameList);
         groupBox3.Controls.Add(btnTagValues);
         groupBox3.Location = new Point(255, 107);
         groupBox3.Name = "groupBox3";
         groupBox3.Size = new Size(237, 372);
         groupBox3.TabIndex = 3;
         groupBox3.TabStop = false;
         groupBox3.Text = "Get values for list of Tags";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Location = new Point(6, 31);
         label5.Name = "label5";
         label5.Size = new Size(95, 15);
         label5.TabIndex = 6;
         label5.Text = "Enter List of Tags";
         // 
         // rtbTagNameList
         // 
         rtbTagNameList.Location = new Point(6, 50);
         rtbTagNameList.Name = "rtbTagNameList";
         rtbTagNameList.Size = new Size(223, 126);
         rtbTagNameList.TabIndex = 2;
         rtbTagNameList.Text = "";
         // 
         // btnTagValues
         // 
         btnTagValues.Location = new Point(6, 182);
         btnTagValues.Name = "btnTagValues";
         btnTagValues.Size = new Size(225, 23);
         btnTagValues.TabIndex = 1;
         btnTagValues.Text = "Get Tag Values";
         btnTagValues.UseVisualStyleBackColor = true;
         btnTagValues.Click += btnTagValues_Click;
         // 
         // groupBox4
         // 
         groupBox4.Controls.Add(label4);
         groupBox4.Controls.Add(tbSubscriveTag);
         groupBox4.Controls.Add(rtbSubscriptionUpdate);
         groupBox4.Controls.Add(btnSubscribe);
         groupBox4.Location = new Point(498, 107);
         groupBox4.Name = "groupBox4";
         groupBox4.Size = new Size(237, 372);
         groupBox4.TabIndex = 4;
         groupBox4.TabStop = false;
         groupBox4.Text = "Subscription, Value Change Event";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(6, 31);
         label4.Name = "label4";
         label4.Size = new Size(142, 15);
         label4.TabIndex = 5;
         label4.Text = "Add new Tag to subscribe";
         // 
         // tbSubscriveTag
         // 
         tbSubscriveTag.Location = new Point(6, 50);
         tbSubscriveTag.Name = "tbSubscriveTag";
         tbSubscriveTag.Size = new Size(219, 23);
         tbSubscriveTag.TabIndex = 4;
         // 
         // rtbSubscriptionUpdate
         // 
         rtbSubscriptionUpdate.Location = new Point(6, 108);
         rtbSubscriptionUpdate.Name = "rtbSubscriptionUpdate";
         rtbSubscriptionUpdate.Size = new Size(223, 249);
         rtbSubscriptionUpdate.TabIndex = 3;
         rtbSubscriptionUpdate.Text = "";
         // 
         // btnSubscribe
         // 
         btnSubscribe.Location = new Point(6, 79);
         btnSubscribe.Name = "btnSubscribe";
         btnSubscribe.Size = new Size(225, 23);
         btnSubscribe.TabIndex = 1;
         btnSubscribe.Text = "Subscribe";
         btnSubscribe.UseVisualStyleBackColor = true;
         btnSubscribe.Click += btnSubscribe_Click;
         // 
         // groupBox5
         // 
         groupBox5.Controls.Add(rtbUpdateInfo);
         groupBox5.Controls.Add(cbDataType);
         groupBox5.Controls.Add(label7);
         groupBox5.Controls.Add(label6);
         groupBox5.Controls.Add(tbTagname);
         groupBox5.Controls.Add(btnTagUpdate);
         groupBox5.Location = new Point(741, 107);
         groupBox5.Name = "groupBox5";
         groupBox5.Size = new Size(237, 372);
         groupBox5.TabIndex = 5;
         groupBox5.TabStop = false;
         groupBox5.Text = "Tag Value Update";
         // 
         // rtbUpdateInfo
         // 
         rtbUpdateInfo.Location = new Point(8, 161);
         rtbUpdateInfo.Name = "rtbUpdateInfo";
         rtbUpdateInfo.Size = new Size(223, 196);
         rtbUpdateInfo.TabIndex = 8;
         rtbUpdateInfo.Text = "";
         // 
         // cbDataType
         // 
         cbDataType.FormattingEnabled = true;
         cbDataType.Items.AddRange(new object[] { "String", "Integer", "Boolean", "Float" });
         cbDataType.Location = new Point(8, 95);
         cbDataType.Name = "cbDataType";
         cbDataType.Size = new Size(217, 23);
         cbDataType.TabIndex = 7;
         // 
         // label7
         // 
         label7.AutoSize = true;
         label7.Location = new Point(6, 76);
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
         label6.Size = new Size(61, 15);
         label6.TabIndex = 5;
         label6.Text = "Tag name ";
         // 
         // tbTagname
         // 
         tbTagname.Location = new Point(6, 50);
         tbTagname.Name = "tbTagname";
         tbTagname.Size = new Size(219, 23);
         tbTagname.TabIndex = 4;
         // 
         // btnTagUpdate
         // 
         btnTagUpdate.Location = new Point(6, 132);
         btnTagUpdate.Name = "btnTagUpdate";
         btnTagUpdate.Size = new Size(225, 23);
         btnTagUpdate.TabIndex = 1;
         btnTagUpdate.Text = "Update";
         btnTagUpdate.UseVisualStyleBackColor = true;
         // 
         // lblStatus
         // 
         lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
         lblStatus.Location = new Point(12, 497);
         lblStatus.Name = "lblStatus";
         lblStatus.Size = new Size(968, 23);
         lblStatus.TabIndex = 6;
         lblStatus.Text = "## Status ##";
         lblStatus.TextAlign = ContentAlignment.MiddleCenter;
         // 
         // dgTagValues
         // 
         dgTagValues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgTagValues.Location = new Point(6, 207);
         dgTagValues.Name = "dgTagValues";
         dgTagValues.RowTemplate.Height = 25;
         dgTagValues.Size = new Size(225, 150);
         dgTagValues.TabIndex = 7;
         // 
         // MainForm
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(994, 536);
         Controls.Add(lblStatus);
         Controls.Add(groupBox5);
         Controls.Add(groupBox4);
         Controls.Add(groupBox3);
         Controls.Add(groupBox2);
         Controls.Add(groupBox1);
         Name = "MainForm";
         Text = "MainForm";
         groupBox1.ResumeLayout(false);
         groupBox1.PerformLayout();
         groupBox2.ResumeLayout(false);
         groupBox3.ResumeLayout(false);
         groupBox3.PerformLayout();
         groupBox4.ResumeLayout(false);
         groupBox4.PerformLayout();
         groupBox5.ResumeLayout(false);
         groupBox5.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)dgTagValues).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private GroupBox groupBox1;
      private Button btnConnect1;
      private Label label3;
      private Label label2;
      private Label label1;
      private TextBox tbPassword;
      private TextBox tbUser;
      private TextBox tbServer;
      private Button btnAllTags;
      private GroupBox groupBox2;
      private TreeView tvAllTags;
      private GroupBox groupBox3;
      private RichTextBox rtbTagNameList;
      private Button btnTagValues;
      private GroupBox groupBox4;
      private TextBox tbSubscriveTag;
      private RichTextBox rtbSubscriptionUpdate;
      private Button btnSubscribe;
      private Label label5;
      private Label label4;
      private Button btnConnect2;
      private GroupBox groupBox5;
      private Label label6;
      private TextBox tbTagname;
      private Button btnTagUpdate;
      private ComboBox cbDataType;
      private Label label7;
      private RichTextBox rtbUpdateInfo;
      private Label lblStatus;
      private DataGridView dgTagValues;
   }
}
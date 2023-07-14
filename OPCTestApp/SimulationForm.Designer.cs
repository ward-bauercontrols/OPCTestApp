namespace OPCTestApp
{
   partial class SimulationForm
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
         flowLayout1 = new FlowLayoutPanel();
         flowLayout2 = new FlowLayoutPanel();
         listTags = new ComboBox();
         btnAddChart = new Button();
         ntbDuration = new NumericUpDown();
         cbWrite = new CheckBox();
         label1 = new Label();
         btnUpdate = new Button();
         timer1 = new System.Windows.Forms.Timer(components);
         ((System.ComponentModel.ISupportInitialize)ntbDuration).BeginInit();
         SuspendLayout();
         // 
         // flowLayout1
         // 
         flowLayout1.AutoScroll = true;
         flowLayout1.Location = new Point(12, 39);
         flowLayout1.Name = "flowLayout1";
         flowLayout1.Size = new Size(348, 534);
         flowLayout1.TabIndex = 0;
         // 
         // flowLayout2
         // 
         flowLayout2.AutoScroll = true;
         flowLayout2.Location = new Point(379, 39);
         flowLayout2.Name = "flowLayout2";
         flowLayout2.Size = new Size(772, 534);
         flowLayout2.TabIndex = 1;
         // 
         // listTags
         // 
         listTags.FormattingEnabled = true;
         listTags.Location = new Point(380, 11);
         listTags.Name = "listTags";
         listTags.Size = new Size(245, 23);
         listTags.TabIndex = 2;
         // 
         // btnAddChart
         // 
         btnAddChart.Location = new Point(631, 12);
         btnAddChart.Name = "btnAddChart";
         btnAddChart.Size = new Size(96, 23);
         btnAddChart.TabIndex = 3;
         btnAddChart.Text = "Add Chart";
         btnAddChart.UseVisualStyleBackColor = true;
         btnAddChart.Click += btnAddChart_Click;
         // 
         // ntbDuration
         // 
         ntbDuration.Location = new Point(161, 11);
         ntbDuration.Name = "ntbDuration";
         ntbDuration.Size = new Size(81, 23);
         ntbDuration.TabIndex = 4;
         ntbDuration.Value = new decimal(new int[] { 100, 0, 0, 0 });
         // 
         // cbWrite
         // 
         cbWrite.AutoSize = true;
         cbWrite.Checked = true;
         cbWrite.CheckState = CheckState.Checked;
         cbWrite.Location = new Point(12, 12);
         cbWrite.Name = "cbWrite";
         cbWrite.Size = new Size(143, 19);
         cbWrite.TabIndex = 5;
         cbWrite.Text = "Write Randomize Data";
         cbWrite.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(248, 16);
         label1.Name = "label1";
         label1.Size = new Size(36, 15);
         label1.TabIndex = 6;
         label1.Text = "mSec";
         // 
         // btnUpdate
         // 
         btnUpdate.Location = new Point(290, 12);
         btnUpdate.Name = "btnUpdate";
         btnUpdate.Size = new Size(70, 23);
         btnUpdate.TabIndex = 7;
         btnUpdate.Text = "Update";
         btnUpdate.UseVisualStyleBackColor = true;
         btnUpdate.Click += btnUpdate_Click;
         // 
         // SimulationForm
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1293, 625);
         Controls.Add(btnUpdate);
         Controls.Add(label1);
         Controls.Add(cbWrite);
         Controls.Add(ntbDuration);
         Controls.Add(btnAddChart);
         Controls.Add(listTags);
         Controls.Add(flowLayout2);
         Controls.Add(flowLayout1);
         Name = "SimulationForm";
         Text = "SimulationForm";
         Load += SimulationForm_Load;
         ((System.ComponentModel.ISupportInitialize)ntbDuration).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private FlowLayoutPanel flowLayout1;
      private FlowLayoutPanel flowLayout2;
      private ComboBox listTags;
      private Button btnAddChart;
      private NumericUpDown ntbDuration;
      private CheckBox cbWrite;
      private Label label1;
      private Button btnUpdate;
      private System.Windows.Forms.Timer timer1;
   }
}
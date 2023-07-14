namespace OPCTestApp
{
   partial class ChartControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         panel1 = new Panel();
         lblModified = new Label();
         label2 = new Label();
         plotView1 = new OxyPlot.WindowsForms.PlotView();
         lblTagValue = new Label();
         lblTag = new Label();
         panel1.SuspendLayout();
         SuspendLayout();
         // 
         // panel1
         // 
         panel1.Controls.Add(lblModified);
         panel1.Controls.Add(label2);
         panel1.Controls.Add(plotView1);
         panel1.Controls.Add(lblTagValue);
         panel1.Controls.Add(lblTag);
         panel1.Dock = DockStyle.Fill;
         panel1.Location = new Point(0, 0);
         panel1.Name = "panel1";
         panel1.Size = new Size(434, 275);
         panel1.TabIndex = 0;
         panel1.Paint += panel1_Paint;
         // 
         // lblModified
         // 
         lblModified.Anchor = AnchorStyles.Top | AnchorStyles.Right;
         lblModified.AutoSize = true;
         lblModified.Location = new Point(397, 249);
         lblModified.Name = "lblModified";
         lblModified.Size = new Size(33, 15);
         lblModified.TabIndex = 4;
         lblModified.Text = "Time";
         lblModified.TextAlign = ContentAlignment.MiddleRight;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(0, 249);
         label2.Name = "label2";
         label2.Size = new Size(79, 15);
         label2.TabIndex = 3;
         label2.Text = "Last Modified";
         label2.TextAlign = ContentAlignment.MiddleLeft;
         // 
         // plotView1
         // 
         plotView1.Location = new Point(13, 33);
         plotView1.Name = "plotView1";
         plotView1.PanCursor = Cursors.Hand;
         plotView1.Size = new Size(372, 213);
         plotView1.TabIndex = 2;
         plotView1.Text = "plotView1";
         plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
         plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
         plotView1.ZoomVerticalCursor = Cursors.SizeNS;
         // 
         // lblTagValue
         // 
         lblTagValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
         lblTagValue.AutoSize = true;
         lblTagValue.Location = new Point(374, 0);
         lblTagValue.Name = "lblTagValue";
         lblTagValue.Size = new Size(56, 15);
         lblTagValue.TabIndex = 1;
         lblTagValue.Text = "Tag Value";
         lblTagValue.TextAlign = ContentAlignment.MiddleLeft;
         // 
         // lblTag
         // 
         lblTag.AutoSize = true;
         lblTag.Location = new Point(3, 0);
         lblTag.Name = "lblTag";
         lblTag.Size = new Size(60, 15);
         lblTag.TabIndex = 0;
         lblTag.Text = "Tag Name";
         lblTag.TextAlign = ContentAlignment.MiddleLeft;
         // 
         // ChartControl
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         Controls.Add(panel1);
         Name = "ChartControl";
         Size = new Size(434, 275);
         panel1.ResumeLayout(false);
         panel1.PerformLayout();
         ResumeLayout(false);
      }

      #endregion

      private Panel panel1;
      private Label lblTag;
      private Label lblTagValue;
      private OxyPlot.WindowsForms.PlotView plotView1;
      private Label lblModified;
      private Label label2;
   }
}

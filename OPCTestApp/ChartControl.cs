using OPCLib.Service;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCLib.Models;
using OxyPlot.Axes;
using MathNet.Numerics;
using Newtonsoft.Json.Linq;

namespace OPCTestApp
{
   public partial class ChartControl : UserControl
   {
      private readonly IOPCClient _client;
      private readonly OPCTag _tag;
      PlotModel model;
      LineSeries lineSeries;
      DateTime? first;
      public ChartControl(IOPCClient client, OPCTag tag)
      {
         InitializeComponent();
         _client = client;
         _tag = tag;
         lblTag.Text = tag.Name;
         _client.TagValueChanged += _client_TagValueChanged;
         model = new PlotModel { Title = _tag.Name,  };
         model.Axes.Add(new LinearAxis()
         {
             Position = AxisPosition.Bottom,
         });
         model.Axes.Add(new LinearAxis()
         {
            Maximum = 256,
            Position = AxisPosition.Left,
         });
         lineSeries = new LineSeries();
         model.Series.Add(lineSeries);
         this.plotView1.Model = model;
      }

      private void _client_TagValueChanged(object sender, OPCLib.Models.TagValueChangedArgument e)
      {
         if (e.NodeId == _tag.Id)
         {
            lblTagValue.Text = e.NewValue.ToString();
            lblModified.Text = DateTime.Now.ToString();
            _timeX += frequency;
            addLineData(double.Parse(e.NewValue.ToString()));
         }
      }

      int frequency = 256;
      int _timeX = 0;
      private void panel1_Paint(object sender, PaintEventArgs e)
      {
         addLineData(0);
      }

      private void addLineData(double val)
      {
         DateTime now = DateTime.Now;
         if(first.HasValue)
         {
            lineSeries.Points.Add(new DataPoint((now - first.Value).TotalMilliseconds, val));
         }
         else
         {
            lineSeries.Points.Add(new DataPoint(0, val));
            first = now;
         }
         model.InvalidatePlot(true);
      }
   }
}

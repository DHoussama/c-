using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signals
{
    public partial class GraphicsSignalView : UserControl, IView
    {
        private SignalDocument signalDocument;

        private int viewNumber;
        const float pixelPerSec = 0.5f;
        const int pixelPerValue = 5;
        float Factor = 1;
        // here we will use the green color
        Pen greenpen = new Pen(Color.Green, 2);
        Pen bp = new Pen(Color.Black, 1);
        SolidBrush bB = new SolidBrush(Color.Black);

        public GraphicsSignalView(SignalDocument signalDocument)
        {

            InitializeComponent();
            this.signalDocument = signalDocument;
        }




        public Document GetDocument()
        {
            return signalDocument;
        }
        public int ViewNumber
        {
            get { return viewNumber; }
            set { viewNumber = value; }
        }
        private void GraphicsSignalView_Load(object sender, EventArgs e)
        {

        }



        void drawthegraph(float h, float a, float b, float signalValue, float Drawvalue, PaintEventArgs e)
        {
            float TimeSpanDraw;
            float c, d;
            int i = 1;
           
            while (i < signalDocument.SignalValues.Count)
            {
                signalValue = (float)(signalDocument.SignalValues[i].Value);
                Drawvalue = (h - signalValue * pixelPerValue);
                TimeSpanDraw = (signalDocument.SignalValues[i].TimeStamp.Ticks - signalDocument.SignalValues[0].TimeStamp.Ticks) * pixelPerSec / 100000;
                c = TimeSpanDraw * Factor;
                d = Drawvalue * Factor;
                e.Graphics.FillRectangle(bB, c, d, 3, 3);
                e.Graphics.DrawLine(bp, a, b, c, d);
                a = c;
                b = d;
                i++;
            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {

            // at the begigning we will draw the two axes
            float h = ClientSize.Height / 2;


            base.OnPaint(e);


            e.Graphics.DrawLine(greenpen, 0, h, ClientSize.Width, h);
            e.Graphics.DrawLine(greenpen, 0, 0, 0, ClientSize.Height);
            float signalValue = (float)signalDocument.SignalValues[0].Value;

            float Drawvalue = (h - signalValue * pixelPerValue);
            e.Graphics.FillRectangle(bB, 0, Drawvalue * Factor, 3, 3);
            float a = 0;
            float b = Drawvalue * Factor;

            //we will now draw the graph here
            drawthegraph(h, a, b, signalValue, Drawvalue, e);


        }

        private void zoomo_Click(object sender, EventArgs e)
        {

            Factor = Factor * 1.2f;
            Invalidate();
        }

        private void zoomI_Click(object sender, EventArgs e)
        {


            Factor = Factor / 1.2f;
            Invalidate();
        }
    }
}
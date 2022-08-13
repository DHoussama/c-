using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework4
{

    delegate void BikeAction(Button bike);
    public partial class Form1 : Form
    {

        private long odo = 0;
        private object Root = new object();
        private ManualResetEvent M = new ManualResetEvent(false);
        private AutoResetEvent A = new AutoResetEvent(false);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartBike(bBike1);
            StartBike(bBike2);              // start the 3 bikes
            StartBike(bBike3);
        }
      
        public void BikeThreadFunction(object param)
        {
            Button bike = (Button)param;
            bike.Tag = Thread.CurrentThread;
            try
            {
                while (bike.Left < panel1.Left)
                {
                    MoveBike(bike);
                    Thread.Sleep(100);
                }
               
                M.WaitOne();    // wait in the de start panel
                
                    while (bike.Left >= panel1.Left  && bike.Left < panel2.Left)
                {
                    MoveBike(bike);
                    Thread.Sleep(100);
                }
                A.WaitOne();  // wait in the second panel
                while (bike.Left >= panel2.Left && bike.Left < pTarget.Left)
                {
                    MoveBike(bike);
                    Thread.Sleep(100);
                }
            }
            catch (ThreadInterruptedException)  // thread interrupt exception
            {

            }
        }
        public void MoveBike(Button bike)
        {
            if (InvokeRequired)
            {
                Invoke(new BikeAction(MoveBike), bike);
            }
            else
            {
                lock (Root)
                {
                    int y = new Random().Next(10);
                    bike.Left += y;   // move bike button 
                    odo += y;  // update odometer
                }
            }
        }

       
        private void StartBike(Button bBike)
        {
            Thread t = new Thread(BikeThreadFunction);
            bBike.Tag = t;
            t.IsBackground = true; // The thread wont prevent closing the process.
            t.Start(bBike);
        }

        private void step1_Click(object sender, EventArgs e)
        {
            M.Set();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            A.Set();
        }

        private void bBike1_Click(object sender, EventArgs e)
        {
        }
        // I tried to do only one button function implementation for all the 3 bikes because it is the same thing for the 3 buttons but it didn't 
        // work so I just made each button separately.
        private void bBike1_Click_1(object sender, EventArgs e)
        {

            Button bike = (Button)sender;
            Thread thread = (Thread)bike.Tag;

            if (thread == null)
                return;
            thread.Interrupt();
            thread.Join();
            bike.Left = 30;  // initital position 
            StartBike(bike); // restart 
        }

        private void bBike2_Click(object sender, EventArgs e)
        {

            Button bike = (Button)sender;
            Thread thread = (Thread)bike.Tag;

            if (thread == null)
                return;
            thread.Interrupt();
            thread.Join();
            bike.Left = 30;  // initital position 
            StartBike(bike); // restart 
        }

        private void bBike3_Click(object sender, EventArgs e)
        {

            Button bike = (Button)sender;
            Thread thread = (Thread)bike.Tag;

            if (thread == null)
                return;
            thread.Interrupt();
            thread.Join();
            bike.Left = 30;  // initital position 
            StartBike(bike); // restart 
        }

        // I used this button to display the pixels at each time
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = odo.ToString();
        }
    }
}

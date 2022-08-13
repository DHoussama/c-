using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        FileInfo loadedFile = null;
        int countdown = 100;
        DirectoryInfo pdi;
        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            InputDialog dlg = new InputDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string r = dlg.InputText;
                //MessageBox.Show(result);
                // TODO: additional steps...
                 pdi = new DirectoryInfo(r);
                try
                {
                    foreach (FileInfo f in pdi.GetFiles())

                        listView1.Items.Add(new ListViewItem(new string[]
                       { f.Name, f.Length.ToString()}));

                }
                catch { }
            }

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

         string s;
        InputDialog d = new InputDialog();

        // we will use a string s where we will store the path of  our selected file.
        // we will need the inputdialog to read the entered path from it

        //Here
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            try
            {
                foreach (FileInfo f in pdi.GetFiles()) { 


                if (listView1.SelectedItems[0].Text == f.Name)
                    {
                        s = d.InputText + f.FullName;
                    }
                                                            }
            }
            catch { }
        }

    

        private void label1_DoubleClick(object sender, EventArgs e)
        {}

        // if listView1.SelectedItems.Count > 0 this means that we select something we use the texbox to display the information in the file and the two labels to display the name
        // and when it is created.
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                name.Text = new DirectoryInfo(s).Name; 
                create.Text = File.GetCreationTime(s).ToString();
                textBox1.Text = File.ReadAllText(s);
                
                reloadTimer.Start();
                countdown = 100;
                loadedFile = new FileInfo(s);

            }
        }

        // here the same code for miRun as in double click to diplay the needed information asked in the exercise
        private void miRun_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {


                name.Text = new DirectoryInfo(s).Name;

                create.Text = File.GetCreationTime(s).ToString();

                textBox1.Text = File.ReadAllText(s);

            }
        }
        
       // I implemented the code as it is in the description but there is no outpout of the color

        private void reloadTimer_Tick_1(object sender, EventArgs e)
        {
            countdown--;
            panel1.Invalidate();
            if (countdown <= 0)
            {
                countdown = 100;
                textBox1.Text = File.ReadAllText(loadedFile.FullName);
            }
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            if (loadedFile != null)
                e.Graphics.FillRectangle(Brushes.Blue, 0, 0, countdown, 10);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Maxwell_IA
{
    public struct Particles
    {
        public float vel;
        public int chanceOfHit;
        public bool doesCollide;
    }
    public struct WallParticles
    {
        public float vel;
    }
    public struct Probabilities
    {
        public float prob;
        public int vel;
    }
    public partial class Maxwell : System.Windows.Forms.Form
    {
        Random rnd = new Random();
        static int aop = 0;
        static float massG = ((float)2.1801714 * (float)Math.Pow(10, -25));
        static float massW = ((float)3.1588432 * (float)Math.Pow(10, -25));
        static float temp = 0;
        static float avgVel = 0;
        static int maxVel = 0;
        static int amountOfCollide = 0;
        Particles[] gasp = new Particles[aop];
        WallParticles[] wallp = new WallParticles[aop];
        Probabilities[] probs = new Probabilities[0];

        public Maxwell()
        {
            InitializeComponent();
            allText.View = View.Details;
            allText.Columns.Add("Particle Number", -2);
            allText.Columns.Add("Particle Speed in m/s", -2);
            allText.Columns.Add("Particle Hit Chance", -2);
            allText.Columns.Add("Does Particle Hit", -2);
        }

        public float VelocityProbability(float m, float t)
        {
            //Boltzmann Constant r= Gas Constant
            float k = ((float)Math.Pow(10, -23) * (float)1.3807);
            //Distribution Function
            float dist = (m / (2 * k * t));
            return dist;
        }
        
        public void Calculate()
        {
            int vTest = 0;
            float fTest = 0;
            while (vTest<250 || fTest>(float)0.0001)
            {
                fTest = FrequencyCalculate(vTest, massG, temp);
                vTest++;
            }
            maxVel = vTest;
            Program.maxwell.maxVelt.Text = maxVel.ToString();
            vTest = 1;
            float totalProb = 0;
            while(vTest <= maxVel)
            {
                totalProb += (FrequencyCalculate(vTest, massG, temp));
                vTest++;
            }
            vTest = 1;
            Array.Resize(ref probs, (int)maxVel);
            while(vTest <= maxVel)
            {
                float prob = ((FrequencyCalculate(vTest, massG, temp)/totalProb)*100);
                probs[vTest-1].prob = prob;
                probs[vTest-1].vel = vTest;
                vTest++;
            }
            Random rn = new Random();
            for (int i = 0; i < aop; i++)
            {
                float rand = rn.Next(0, 1000000000);
                float proc = (rand /  10000000);
                float num = 0;
                int test = 0;
                while (num < proc)
                {
                    num += probs[test].prob;
                    test++;
                }
                gasp[i].vel = (test);
            }
            Array.Sort(gasp, delegate (Particles gasp1, Particles gasp2)
            {
                return gasp1.vel.CompareTo(gasp2.vel);
            });
            ListViewItem init = new ListViewItem(new[] { "INITIAL VELOCITIES" });
            Program.maxwell.allText.Items.Add(init);
            for (int i = 0; i < aop; i++)
            {               
                ListViewItem item = new ListViewItem(new[] { (i + 1).ToString(), gasp[i].vel.ToString(), gasp[i].chanceOfHit.ToString(), gasp[i].doesCollide.ToString() });
                Program.maxwell.allText.Items.Add(item);
            }
            chart1.ChartAreas[0].AxisX.Maximum = maxVel;
            chart1.ChartAreas[0].Axes[0].Title = "Velocity(m/s)";
            chart1.ChartAreas[0].Axes[1].Title = "Frequency(s/m)";
            for (int i = 1; i <= maxVel; i++)
            {
                chart1.Series[0].Points.AddXY(xValue:i, yValue:(float)(FrequencyCalculate(i, massG, temp)));
            }
            for (int i = 1; i <= maxVel; i++)
            {
                chart1.Series[1].Points.AddXY(xValue: i, yValue: (float)(FrequencyCalculate(i, massW, temp)));
            }
            this.aopn.Enabled = false;
        }

        public float FrequencyCalculate(float v, float m, float t)
        {
            //float velFreq = (((float)Math.Pow(VelocityProbability(mass, gasConst), ((float)(3/2))))*((((float)Math.Exp((((-1*(((VelocityProbability(mass, gasConst))))))*(float)Math.Pow(v,2)*(float)Math.PI))))));
            float velFreq = (((float)Math.Pow((2/Math.PI),0.5f)*(float)Math.Pow((2*(VelocityProbability(m, t))),1.5f)*(float)Math.Pow(v,2)*(float)Math.Exp((-1*(VelocityProbability(m, t))*(float)Math.Pow(v,2)))));
            return velFreq;
        }
        
        public void Collide()
        {
            for (int i = 0; i < aop; i++)
            {
                wallp[i].vel = 100;
            }
            avgVel = 100;
            int aoi = 0;
            float oldAvg = 1000;
            while (avgVel != oldAvg)
            {
                Array.Sort(gasp, delegate (Particles gasp1, Particles gasp2)
                {
                    return gasp1.vel.CompareTo(gasp2.vel);
                });
                //maxVel = (int)gasp[aop - 1].vel;
                aoi++;
                oldAvg = avgVel;
                amountOfCollide++;
                ListViewItem trial = new ListViewItem(new[] { "TRIAL " + amountOfCollide, "TRIAL " + amountOfCollide, "TRIAL " + amountOfCollide, "TRIAL " + amountOfCollide });
                Program.maxwell.allText.Items.Add(trial);               
                for (int i = 0; i < aop; i++)
                {             
                    float probability = ((float)gasp[i].vel / (float)maxVel);
                    gasp[i].chanceOfHit = (int)(probability * (float)100);
                    int rand = rnd.Next(1, 101);
                    if (rand <= gasp[i].chanceOfHit)
                    {
                        gasp[i].doesCollide = true;
                    }
                    else
                    {
                        gasp[i].doesCollide = false;
                    }
                    if (gasp[i].doesCollide == true)
                    {
                        float storeVel = gasp[i].vel;
                        wallp[i].vel = storeVel;
                        gasp[i].vel = avgVel;
                    }
                }
                float totalVel = 0;
                for (int i = 0; i < aop; i++)
                {
                    totalVel += wallp[i].vel;
                }
                avgVel = (float)totalVel / (float)aop;
                for (int i = 0; i < aop; i++)
                {
                    wallp[i].vel = avgVel;
                }
                Program.maxwell.aopn.Enabled = false;
                Program.maxwell.tempn.Enabled = false;
                Program.maxwell.AvgVelt.Text = avgVel.ToString();
                for (int i = 0; i < aop; i++)
                {
                    ListViewItem item = new ListViewItem(new[] { (i + 1).ToString(), gasp[i].vel.ToString(), gasp[i].chanceOfHit.ToString(), gasp[i].doesCollide.ToString() });
                    Program.maxwell.allText.Items.Add(item);
                }
            }
            Program.maxwell.aoi.Text = aoi.ToString();
            this.button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void temp_ValueChanged(object sender, EventArgs e)
        {
            temp = (int)Program.maxwell.tempn.Value;
        }

        private void startMaxwell_Click(object sender, EventArgs e)
        {
            Collide();
        }

        private void aopn_ValueChanged(object sender, EventArgs e)
        {
            aop = (int)Program.maxwell.aopn.Value;
            Array.Resize(ref gasp, aop);
            Array.Resize(ref wallp, aop);
        }

        private void allText_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = allText.Columns[e.ColumnIndex].Width;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (aop == 0 ||temp == 0)
            {
                Program.maxwell.debug.Text = "No numbers can be 0!";
            }
            else
            {
                Calculate();
                Program.maxwell.calc.Enabled = false;
                Program.maxwell.startMaxwell.Enabled = true;
                Program.maxwell.tempn.Enabled = false;
            }
        }

        private void allText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ExcelApp = new Excel.Application();

            ExcelApp.Visible = true;
            var wb = ExcelApp.Workbooks.Add(1); 
            var ws = wb.Worksheets[1]; 
            int Columns = 1;
            int Rows = 1;
            foreach (ListViewItem lvi in allText.Items)
            {
                Columns = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[Rows, Columns] = lvs.Text;
                    Columns++; 
                }
                Rows++; 
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs493jli100
{
    public partial class Form1 : Form
    {
        int memCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button wwr = (Button)sender;
            wwr.Text = "Who we are?";
        }

        private void teamClick(object sender, EventArgs e)
        {
            Button wwr = (Button)sender;

            Random randonGen = new Random();
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
            randonGen.Next(255));
            wwr.ForeColor = randomColor;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button member = (Button)sender;
            String[] team_member = { "Diego Deveras", "Jiaming Li", "Muqi Zou", "Kelsey Yuen","Our Team" };
            Random randonGen = new Random();
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
            randonGen.Next(255));
            member.Text = team_member[memCount%5];
            member.ForeColor = randomColor;
            memCount++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 .Develop an understanding of HIPAA compliant patient medication data – data structure\n"
                + "2. Design a relational database table structure for both the client and server with focus on medication.\n"
                + "3. Create a stub based Prescription Server\n"
                + "4. Create a stub based client EMR proxy tool\n"
                + "5. Develop Simple Exception Report based on mismatching medications\n"
                + "6. Import / Export to clinical data architecture(CDA) / FHIR data format\n"
                + "7. Reconcile 100 test patients\n"
                + "8. Develop a sophisticated server communication mechanism – that mirrors medication ePrescribe\n"
                + "9. Message Protoco\n"
                + "10. Service\n"
                + "11. Error Handling\n"
                + "12. Develop client to reconcile medication data against real world provider\n"
                + "13. Develop “production ready” Exception Reports”\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("·         By the end of the second semester, students are expected to deliver a functional data interface between medication ePrescribe and IMO’s EMR “Face Sheet\n"
                    +"·         A functional version of the demonstration application should include the ability to have Medication content for 300 frequently prescribed drugs\n"
                    +"·         Create an API that can handle one or many patient population medication reconciliations");
        }
    }
}

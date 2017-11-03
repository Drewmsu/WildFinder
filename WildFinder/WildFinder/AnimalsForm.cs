using System;
using System.Diagnostics;
using System.Windows.Forms;
using SbsSW.SwiPlCs;

namespace WildFinder
{
    public partial class AnimalsForm : Form
    {
        public AnimalsForm()
        {
            InitializeComponent();
        }

        private void AnimalsForm_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
            String[] p = { "-q", "-f", @"Animals.pl" };
            PlEngine.Initialize(p);
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            var value = tbInput.Text;
            lbConsult.Items.Clear();
            var load = new PlQuery("load('animals.bd')");
            try
            {
                load.NextSolution();

            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.StackTrace);
            }

            if (cbHabitat.Checked)
            {
                var consulta1 = new PlQuery("lives_in(" + value + ",Animal)");
                foreach (var z in consulta1.SolutionVariables)
                    lbConsult.Items.Add(z["Animal"].ToString());
            }
        }
    }
}

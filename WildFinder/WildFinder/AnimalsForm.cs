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
            cbInferencias.SelectedIndex = 0;
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
            String[] p = { "-q", "-f", @"Animals.pl" };
            PlEngine.Initialize(p);
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            PlQuery query;
            var value = tbInput.Text.ToLower();
            lbConsult.Items.Clear();
            var load = new PlQuery("load('Animals.bd')");
            try
            {
                load.NextSolution();

            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.StackTrace);
            }

            switch (cbInferencias.SelectedIndex)
            {
                case 0:
                    query = new PlQuery("lives_in(" + value + ",Animal)");
                    foreach (var q in query.SolutionVariables)
                        lbConsult.Items.Add(q["Animal"].ToString());
                    break;
                case 1:
                    query = new PlQuery("habitat_type(" + value + ",Biome)");
                    foreach (var q in query.SolutionVariables)
                        lbConsult.Items.Add(q["Biome"].ToString());
                    break;
                case 2:
                    query = new PlQuery("biomes_of_animal(" + value + ",Biome)");
                    foreach (var q in query.SolutionVariables)
                        lbConsult.Items.Add(q["Biome"].ToString());
                    break;
                case 3:
                    query = new PlQuery("major_enemies(" + value + ",Enemy)");
                    foreach (var q in query.SolutionVariables)
                        lbConsult.Items.Add(q["Enemy"].ToString());
                    break;
                case 4:
                    query = new PlQuery("live_together(" + value + ",AnimalB)");
                    foreach (var q in query.SolutionVariables)
                        lbConsult.Items.Add(q["AnimalB"].ToString());
                    break;
            }
            
        }

        private void cbInferencias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
            cmb_habitat_finder2.SelectedIndex = 0;
            cmb_foodtype_finder2.SelectedIndex = 0;
            cmb_development_finder2.SelectedIndex = 0;
            cmb_class_finder2.SelectedIndex = 0;
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
            String[] p = { "-q", "-f", @"Animals.pl" };
            PlEngine.Initialize(p);
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
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
            if (tbInput.Text.Length != 0)
            {
                PlQuery query;
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

        }

        private void cbInferencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbInferencias.SelectedIndex)
            {
                case 0:
                    lblAux.Text = @"Enter a habitat:";
                    break;
                case 1:
                    lblAux.Text = @"Enter a habitat:";
                    break;
                case 2:
                    lblAux.Text = @"Enter an animal:";
                    break;
                case 3:
                    lblAux.Text = @"Enter an animal:";
                    break;
                case 4:
                    lblAux.Text = @"Enter an animal:";
                    break;
            }
        }

        private void lblObjective_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            var animal = txtAnimalName.Text.ToLower();
            var animalClass = txtClass.Text.ToLower();
            var habitat = txtHabitat.Text.ToLower();
            var biome = txtBiome.Text.ToLower();
            var load = new PlQuery("load('Animals.bd')");

            try
            {
                load.NextSolution();

            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.StackTrace);
            }

            if (txtAnimalName.Text.Length != 0 &&
                txtClass.Text.Length != 0 &&
                txtHabitat.Text.Length != 0 &&
                txtBiome.Text.Length != 0)
            {
                try
                {
                    PlQuery.PlCall("assert(animal_habitat(" + animal + "," + habitat + "))");
                    PlQuery.PlCall("assert(animal_biome(" + animal + "," + biome + "))");
                    PlQuery.PlCall("assert(animal_class(" + animal + "," + animalClass + "))");
                    MessageBox.Show(@"Successfully Added");
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.StackTrace);
                }
            }
        }

        private void btnAddEnemy_Click(object sender, EventArgs e)
        {
            var animal = txtExistingAnimal.Text.ToLower();
            var enemy = txtNewEnemy.Text.ToLower();
            var load = new PlQuery("load('Animals.bd')");

            try
            {
                load.NextSolution();

            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.StackTrace);
            }

            if (txtExistingAnimal.Text.Length != 0 &&
                txtNewEnemy.Text.Length != 0)
            {
                try
                {
                    PlQuery.PlCall("assert(major_enemies(" + animal + "," + enemy + "))");
                    MessageBox.Show(@"Successfully Added");
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.StackTrace);
                }
            }
        }

        private void btn_consult_finder2_Click(object sender, EventArgs e)
        {
            var animalClass = cmb_class_finder2.Text.ToLower();
            var habitat = cmb_habitat_finder2.Text.ToLower();
            var foodtype = cmb_foodtype_finder2.Text.ToLower();
            var development = cmb_development_finder2.Text.ToLower(); 
            var load = new PlQuery("load('Animals.bd')");

            try
            {
                load.NextSolution();

            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.StackTrace);
            }

            PlQuery query = new PlQuery("search_animal(" + animalClass + "," + habitat + "," + foodtype + "," + development + ",Animal)");
            foreach (var q in query.SolutionVariables)
                lst_finder2.Items.Add(q["Animal"].ToString());
        }
    }
}

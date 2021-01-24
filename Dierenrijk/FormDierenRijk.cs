using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdvancedC_Chapter1
{
    public partial class FormDierenRijk : Form
    {
        private List<Animal> dierenrijk = new List<Animal>();

        public FormDierenRijk()
        {
            InitializeComponent();
            dierenrijk.Add(new Rabbit() { CarrotsEaten = 5, HairColour = "White", IsPregnant = false, Name = "El Rabbito" });
            dierenrijk.Add(new Cow() { Name = "CowMoo", HairColour = "Brown", HasBell = true, IsPregnant = true, Spots = "Black & White" });
            dierenrijk.Add(new Dog() { Name = "Doggo", HairColour = "Black", IsPregnant = false, BonesBurried = 100 });
            dierenrijk.Add(new Snake() { Name = "Snakeo", ScaleType = "Green", ScaleAmount = 1000, IsVenomous = true });
            dierenrijk.Add(new Iguana() { Name = "Iguano", ScaleType = "Green/Yellow", ScaleAmount = 2000, TongueLength = 20 });
            dierenrijk.Add(new Snake() { Name = "Snak", ScaleType = "Red", ScaleAmount = 5200, IsVenomous = true });
            dierenrijk.Add(new Snake() { Name = "SnakeTheGame", ScaleType = "Black", ScaleAmount = 3, IsVenomous = false });
            dierenrijk.Add(new Dog() { Name = "Dug", HairColour = "White", IsPregnant = true, BonesBurried = 5 });
        }

        private void FormDierenRijk_Load(object sender, EventArgs e)
        {
            foreach (Animal animal in dierenrijk)
            {
                listBox1.Items.Add(animal.ShowInfo());
                listBox1.Items.Add(animal.MakeSound());
                listBox1.Items.Add("");
            }
        }
    }
}
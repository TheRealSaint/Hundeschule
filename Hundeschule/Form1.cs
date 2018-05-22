using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hundeschule
{
    public partial class Form1 : Form
    {
        public List <Hund> myDogList = new List<Hund>();
        
        public Form1()
        {
            InitializeComponent();
            //string dog = myDog.HundBeschreibung(myDog);
            
            
            //listBox1.Items.Add(dog);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_dog_Click(object sender, EventArgs e)
        {
            int index = myDogList.Count();
            Hund newDog = new Hund();
            newDog.setAktuellerZustand("sitzt"); 
            myDogList.Add(newDog);
            string dog = index + " " + newDog.HundBeschreibung(newDog);
            listBox1.Items.Add(dog);
        }

        private void btn_status_anzeigen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //listBox1.Items.Remove();
            listBox1.Refresh();
            foreach (Hund hund in myDogList)
            {
                listBox1.Items.Add(hund.name + " " + hund.aktuellerZustand);
            }
        }
    }
}

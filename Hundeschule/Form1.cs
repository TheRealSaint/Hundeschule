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
        //public List <Hund> myDogList = new List<Hund>();
        List<StateContext> myDogList = new List<StateContext>();
        //StateContext myDog = new StateContext();

        public Form1()
        {
            InitializeComponent();
            //foreach (StateContext objekt in myDogList) { objekt.State = new Liegen(); }
            //myDog.State = new Liegen();
            //myDog.Change();
            //string dog = myDog.HundBeschreibung(myDog);


            //listBox1.Items.Add(dog);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kann weg
        }

        private void btn_add_dog_Click(object sender, EventArgs e)
        {
            int index = myDogList.Count();
            Hund newDog = new Hund();
            newDog.SetAktuellerZustand("sitzt");                     

            newDog.State = new Liegen();
            
            //Zufaelligen Status des Hundes einstellen
            Random rnd = new Random();
            int Zufallszahl = rnd.Next(0, 3);

            for (int i = Zufallszahl; i < myDogList.Count; i++)
            {
                newDog.Change();
            }

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
                //listBox1.Items.Add(hund.name + " " + hund.aktuellerZustand);
                listBox1.Items.Add(hund.name + " " + hund.State);
            }
        }

        private void btn_kommando_Click(object sender, EventArgs e)
        {
            foreach (StateContext objekt in myDogList)
            {                
                objekt.Change();
                listBox1.Items.Clear();

                foreach (Hund hund in myDogList)
                {
                    listBox1.Items.Add(hund.name + " " + hund.State);
                }
            }
            listBox1.Refresh();
        }        
    }
}

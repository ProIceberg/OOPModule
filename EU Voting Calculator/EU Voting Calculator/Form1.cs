using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EU_Voting_Calculator
{
    public partial class Form1 : Form
    {
        Loader loader;
        public Form1(ref Loader _loader)
        {
            InitializeComponent();
            loader = _loader;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AUSTRIA YES
            loader.countryList[0].setVote(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AUSTRIA NO
            loader.countryList[0].setVote(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //AUSTRIA ABS
            loader.countryList[0].setVote(2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

//<<<<<<< HEAD
        private void button4_Click(object sender, EventArgs e) =>
            //BELGIUM YES
            loader.countryList[1].setVote(0);

        private void button5_Click(object sender, EventArgs e)
        {
            //BELGIUM NO
            loader.countryList[1].setVote(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //BELGIUM ABSTAIN
            loader.countryList[2].setVote(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //BULGARIA YES
            loader.countryList[3].setVote(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //BULGARIA NO
            loader.countryList[3].setVote(1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //BULGARIA ABSTAIN
            loader.countryList[3].setVote(2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //CROATIA YES
            loader.countryList[4].setVote(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //CROATIA NO
            loader.countryList[4].setVote(1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //CROATIA ABSTAIN
            loader.countryList[4].setVote(2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //CYPRUS YES
            loader.countryList[5].setVote(0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //CYPRUS NO
            loader.countryList[5].setVote(1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //CYPRUS ABSTAIN
            loader.countryList[5].setVote(2);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //CZECH YES
            loader.countryList[6].setVote(0);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //CZECH NO
            loader.countryList[6].setVote(1);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //CHECK ABSTAIN
            loader.countryList[6].setVote(2);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            //MALTA YES
            loader.countryList[7].setVote(0);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            //MALTA NO
            loader.countryList[7].setVote(1);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            //MALTA ABSTAIN
            loader.countryList[7].setVote(2);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            //PORTUGAL YES
            loader.countryList[8].setVote(0);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            //PORTUGAL NO
            loader.countryList[8].setVote(1);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            //PORTUGAL ABSTAIN
            loader.countryList[8].setVote(2);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            //SLOVENIA YES
            loader.countryList[9].setVote(0);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            //SLOVENIA NO
            loader.countryList[9].setVote(1);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            //SLOVENIA ABSTAIN
            loader.countryList[9].setVote(2);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //DENMARK YES
            loader.countryList[10].setVote(0);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //DENMARK NO
            loader.countryList[10].setVote(1);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //DENMARK ABSTAIN
            loader.countryList[10].setVote(2);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //ESTONIA YES
            loader.countryList[11].setVote(0);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //ESTONIA NO
            loader.countryList[11].setVote(1);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //ESTONIA ABSTAIN
            loader.countryList[11].setVote(2);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //FINLAND YES
            loader.countryList[12].setVote(0);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //FINLAND NO
            loader.countryList[12].setVote(1);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //FINLAND ABSTAIN
            loader.countryList[12].setVote(2);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //FRANCE YES
            loader.countryList[13].setVote(0);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //FRANCE NO
            loader.countryList[13].setVote(1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //FRANCE ABSTAIN
            loader.countryList[13].setVote(2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //GERMANY YES
            loader.countryList[14].setVote(0);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //GERMANY NO
            loader.countryList[14].setVote(1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //GERMANY ABSTAIN
            loader.countryList[14].setVote(2);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //GREECE YES
            loader.countryList[15].setVote(0);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //GREECE NO
            loader.countryList[15].setVote(1);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //GREECE ABSTAIN
            loader.countryList[15].setVote(2);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            //NETHERLANDS YES
            loader.countryList[16].setVote(0);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            //NETHERLANDS NO
            loader.countryList[16].setVote(1);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            //NETHERLANDS ABSTAIN
            loader.countryList[16].setVote(2);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            //ROMAINIA YES
            loader.countryList[17].setVote(0);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            //ROMANIA NO
            loader.countryList[17].setVote(1);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            //ROMANIA ABSTAIN
            loader.countryList[17].setVote(2);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            //SPAIN YES
            loader.countryList[18].setVote(0);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            //SPAIN NO
            loader.countryList[18].setVote(1);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            //SPAIN ABSTAIN
            loader.countryList[18].setVote(2);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            //HUNGARY YES
            loader.countryList[19].setVote(0);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            //HUNGARY NO
            loader.countryList[19].setVote(1);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            //HUNGARY ABSTAIN
            loader.countryList[19].setVote(2);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            //IRELAND YES
            loader.countryList[20].setVote(0);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            //IRELAND NO
            loader.countryList[20].setVote(1);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            //IRELAND ABSTAIN
            loader.countryList[20].setVote(2);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //ITALY YES
            loader.countryList[21].setVote(0);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            //ITALY NO
            loader.countryList[21].setVote(1);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            //ITALY ABSTAIN
            loader.countryList[21].setVote(2);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //LATVIA YES
            loader.countryList[22].setVote(0);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //LATVIA NO
            loader.countryList[22].setVote(1);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            //LATVIA ABSTAIN
            loader.countryList[22].setVote(2);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //LITHUANIA YES
            loader.countryList[23].setVote(0);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            //LITHUNIA NO
            loader.countryList[23].setVote(1);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //LITHUANIA ABSTAIN
            loader.countryList[23].setVote(2);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //LUXEMBOURG YES
            loader.countryList[24].setVote(0);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //LUXEMBOURG NO
            loader.countryList[24].setVote(1);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //LUXEMBOURG ABSTAIN
            loader.countryList[24].setVote(2);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            //POLAND YES
            loader.countryList[25].setVote(0);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            //POLAND NO
            loader.countryList[25].setVote(1);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            //POLAND ABSTAIN
            loader.countryList[25].setVote(2);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            //SLOVAKIA YES
            loader.countryList[26].setVote(0);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            //SLOVAKIA NO
            loader.countryList[26].setVote(1);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            //SLOVAKIA ABSTAIN
            loader.countryList[26].setVote(2);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            //SWEDEN YES
            loader.countryList[27].setVote(0);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            //SWEDEN NO
            loader.countryList[27].setVote(1);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            //SWEDEN ABSTAIN
            loader.countryList[27].setVote(2);
        }

    }
}

namespace FoerachOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int[] sayilar = { 44, 21, 36, 124, 16, 160, 41, 33, 121, 92 };
        int toplam = 0;
        int toplam2 = 0;
        int adet1 = 0;
        int adet2 = 0;


        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add("4'e tam bölünen sayýlar: ");
            listBox2.Items.Add("4'e tam bölünemeyen sayýlar");




            foreach (int i in sayilar)
            {


                if (i % 4 == 0)
                {
                    listBox1.Items.Add(i);
                    adet1++;
                    toplam = toplam + i;
                }


            }
            label3.Text = ("4'e Bölünebilen sayýlarýn adedi: " + adet1.ToString());
            label5.Text = ("4'e Bölünebilen sayýlarýn toplamý: " + toplam);


            foreach (int i in sayilar)
            {
                if (i % 4 != 0)
                {
                    listBox2.Items.Add(i);
                    adet2++;
                    toplam2 = toplam2 + i;
                }
                ;

            }
            label4.Text = ("4'e Bölünemeyen sayýlarýn adedi: " + adet2.ToString());
            label6.Text = ("4'e Bölünemeyen sayýlarýn toplamý: " + toplam2);

        }
    }
}
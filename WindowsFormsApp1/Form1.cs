using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ozlusozler = new string[]{ "Daima elinden gelenin en iyisini yap, sonuç için asla endişelenme","Dünden öğren, bugün için yaşa, yarın için umut et","Zenginlik, bir bilgenin kölesi, bir aptalın efendisidir", "Tek bildiğim şey, hiçbir şey bilmediğimdir", "Zaman asla geri gelmez", "Arı yok, bal yok; iş yok, para yok", "Bugün yap ya da yarın pişman ol","Bu alemde söylediğine itiraz etmeden uyan adamdan korkacaksın çünkü onun başı aşahıda gözü yükselerde"};

            Random rnd = new Random();
            int no = rnd.Next(0,ozlusozler.Length);


            string s= Convert.ToString(textBox1.Text); 
            
            if (s=="merhaba"||s=="naber"||s=="nasılsın"||s=="iyimisin"||s=="MERHABA"||s=="NABER"|| s == "NASILSIN" || s == "İYİMİSİN" || s == "Merhaba" || s == "Naber" || s == "Nasılsın" || s == "İyimsin"||s=="slm")
            {
                label3.Text="İYİYM SEN".ToString();

            }
            if (s == "")
            {
                label3.Text = "BİŞEY YAZMADIN".ToString();

            }
            if (s=="özlü bir söz söle")
            {
                
                label3.Text =ozlusozler[no].ToString();

            }
            else if (s== "cyber")
            {
                label3.Text = "Efendim".ToString();


            }
            
        }
    }
}

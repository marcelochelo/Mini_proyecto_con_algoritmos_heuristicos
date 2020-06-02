using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuatro_y_gana__minimax_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int jugador1 = 1;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button43.BackColor != Color.Orange && button43.BackColor != Color.Red)
            {
                button43.BackColor = Color.Orange;
                if (button43.BackColor == Color.Orange && button44.BackColor == Color.Orange && button45.BackColor == Color.Orange && button46.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador17");
                }
                if(button36.BackColor == Color.Orange && button37.BackColor == Color.Orange && button38.BackColor == Color.Orange && button39.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador16");
                }
                if (button43.BackColor == Color.Orange)
                {
                    Random aleatorio = new Random();
                    int num;
                    num = aleatorio.Next(1, 3);
                    if (num == 1)
                    {
                        button44.BackColor = Color.Red;
                    }
                    else
                    button36.BackColor = Color.Red;
                     
                }
            }
            else if (button36.BackColor != Color.Orange && button36.BackColor != Color.Red)
            {
                button36.BackColor = Color.Orange;
            }
            else if (button29.BackColor != Color.Orange && button29.BackColor != Color.Red)
            {
                button29.BackColor = Color.Orange;
            }
            else if (button22.BackColor != Color.Orange && button22.BackColor != Color.Red)
            {
                button22.BackColor = Color.Orange;
                 if (button43.BackColor == Color.Orange && button36.BackColor == Color.Orange && button29.BackColor == Color.Orange && button22.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador1");
                }
            }
            else if (button15.BackColor != Color.Orange && button15.BackColor != Color.Red)
            {
                button15.BackColor = Color.Orange;
            }
            else if (button8.BackColor != Color.Orange && button8.BackColor != Color.Red)
            {
                button8.BackColor = Color.Orange;
            }
            else if (button1.BackColor != Color.Orange && button1.BackColor != Color.Red)
            {
                button1.BackColor = Color.Orange;
            }
            
        }



        private void uno_Click(object sender, EventArgs e)
        {

            do{
                uno.BackColor=Color.Orange;

            }
            while (uno.CausesValidation != true);
            
          
           
        }

 

        private void button22_Click(object sender, EventArgs e)
        {
            if (button43.BackColor != Color.Orange && button43.BackColor != Color.Red)
            {
                button43.BackColor = Color.Orange;
                if (button43.BackColor == Color.Orange && button44.BackColor == Color.Orange && button45.BackColor == Color.Orange && button46.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador2");
                }
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (button44.BackColor != Color.Orange && button44.BackColor != Color.Red)
            {
                button44.BackColor = Color.Orange;
                if (button44.BackColor == Color.Orange && button45.BackColor == Color.Orange && button46.BackColor == Color.Orange && button47.BackColor == Color.Orange)
                {
                    
                    MessageBox.Show("ganador27");  
                }
                if (button44.BackColor == Color.Orange && button45.BackColor == Color.Orange && button46.BackColor == Color.Orange && button43.BackColor == Color.Orange)
                {

                    MessageBox.Show("ganador27.");
                }
                if (button44.BackColor == Color.Orange)
                {
                    Random aleatorio = new Random();
                    int num;
                    num = aleatorio.Next(1, 4);
                    if (num == 1)
                    {
                        button43.BackColor = Color.Red;
                    }
                    else if(num==2)
                        button37.BackColor = Color.Red;
                    else
                        button45.BackColor = Color.Red;

                }
                
            }

            else if (button37.BackColor != Color.Orange && button37.BackColor != Color.Red)
            {
                button37.BackColor = Color.Orange;
            }
            else if (button30.BackColor != Color.Orange && button30.BackColor != Color.Red)
            {
                button30.BackColor = Color.Orange;
            }
            else if (button23.BackColor != Color.Orange && button23.BackColor != Color.Red)
            {
                button23.BackColor = Color.Orange;
                if (button44.BackColor == Color.Orange && button37.BackColor == Color.Orange && button30.BackColor == Color.Orange && button23.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador1");
                }
            }
            else if (button16.BackColor != Color.Orange && button16.BackColor != Color.Red)
            {
                button16.BackColor = Color.Orange;
            }
            else if (button9.BackColor != Color.Orange && button9.BackColor != Color.Red)
            {
                button9.BackColor = Color.Orange;
            }
            else if (button2.BackColor != Color.Orange && button2.BackColor != Color.Red)
            {
                button2.BackColor = Color.Orange;
            }
        }

    

        private void button23_Click(object sender, EventArgs e)
        {
            if (button44.BackColor != Color.Orange)
            {
                button44.BackColor = Color.Orange;
                if (button44.BackColor == Color.Orange && button45.BackColor == Color.Orange && button46.BackColor == Color.Orange && button47.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador2");
                }
            }
            
            
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            if (button45.BackColor != Color.Orange && button45.BackColor != Color.Red)
            {
                button45.BackColor = Color.Orange;
                if (button45.BackColor == Color.Orange && button46.BackColor == Color.Orange && button47.BackColor == Color.Orange && button48.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador37");
                }
                if (button43.BackColor == Color.Orange && button44.BackColor == Color.Orange && button45.BackColor == Color.Orange && button46.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador37");
                }
                if (button44.BackColor == Color.Orange && button45.BackColor == Color.Orange && button46.BackColor == Color.Orange && button47.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador37");
                }
                if (button45.BackColor == Color.Orange)
                {
                    Random aleatorio = new Random();
                    int num;
                    num = aleatorio.Next(1, 4);
                    if (num == 1)
                    {
                        button44.BackColor = Color.Red;
                    }
                    else if (num == 2)
                        button38.BackColor = Color.Red;
                    else
                        button46.BackColor = Color.Red;

                }
               
            }
            else if (button38.BackColor != Color.Orange && button38.BackColor != Color.Red)
            {
                button38.BackColor = Color.Orange;
            }
            else if (button31.BackColor != Color.Orange && button31.BackColor != Color.Red)
            {
                button31.BackColor = Color.Orange;
            }
            else if (button24.BackColor != Color.Orange && button24.BackColor != Color.Red)
            {
                button24.BackColor = Color.Orange;
                if (button45.BackColor == Color.Orange && button38.BackColor == Color.Orange && button31.BackColor == Color.Orange && button24.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador1");
                }
            }
            else if (button17.BackColor != Color.Orange && button17.BackColor != Color.Red)
            {
                button17.BackColor = Color.Orange;
            }
            else if (button10.BackColor != Color.Orange && button10.BackColor != Color.Red)
            {
                button10.BackColor = Color.Orange;
            }
            else if (button3.BackColor != Color.Orange && button3.BackColor != Color.Red)
            {
                button3.BackColor = Color.Orange;
            }
        }

    

        private void button24_Click(object sender, EventArgs e)
        {
            if (button45.BackColor != Color.Orange)
            {
                button45.BackColor = Color.Orange;
                if (button45.BackColor == Color.Orange && button46.BackColor == Color.Orange && button47.BackColor == Color.Orange && button48.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador2");
                }
            }
            
            
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            if (button46.BackColor != Color.Orange)
            {
                button46.BackColor = Color.Orange;
                if (button46.BackColor == Color.Orange && button47.BackColor == Color.Orange && button48.BackColor == Color.Orange && button49.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador2");
                }
                if (button43.BackColor == Color.Orange && button44.BackColor == Color.Orange && button45.BackColor == Color.Orange && button46.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador47");
                }
                if (button44.BackColor == Color.Orange && button45.BackColor == Color.Orange && button46.BackColor == Color.Orange && button47.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador47");
                }
                if (button45.BackColor == Color.Orange && button46.BackColor == Color.Orange && button47.BackColor == Color.Orange && button48.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador47");
                }
                if (button46.BackColor == Color.Orange)
                {
                    Random aleatorio = new Random();
                    int num;
                    num = aleatorio.Next(1, 4);
                    if (num == 1)
                    {
                        button45.BackColor = Color.Red;
                    }
                    else if (num == 2)
                        button39.BackColor = Color.Red;
                    else
                        button47.BackColor = Color.Red;

                }
            }
            else if (button39.BackColor != Color.Orange && button39.BackColor != Color.Red)
            {
                button39.BackColor = Color.Orange;
            }
            else if (button32.BackColor != Color.Orange && button32.BackColor != Color.Red)
            {
                button32.BackColor = Color.Orange;
            }
            else if (button25.BackColor != Color.Orange && button25.BackColor != Color.Red)
            {
                button25.BackColor = Color.Orange;
                if (button46.BackColor == Color.Orange && button39.BackColor == Color.Orange && button32.BackColor == Color.Orange && button25.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador1");
                }
            }
            else if (button18.BackColor != Color.Orange && button18.BackColor != Color.Red)
            {
                button18.BackColor = Color.Orange;
            }
            else if (button11.BackColor != Color.Orange && button11.BackColor != Color.Red)
            {
                button11.BackColor = Color.Orange;
            }
            else if (button4.BackColor != Color.Orange && button4.BackColor != Color.Red)
            {
                button4.BackColor = Color.Orange;
            }
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            if (button47.BackColor != Color.Orange)
            {
                button47.BackColor = Color.Orange;
                if (button47.BackColor == Color.Orange && button46.BackColor == Color.Orange && button45.BackColor == Color.Orange && button44.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador2");
                }
                if (button46.BackColor == Color.Orange && button47.BackColor == Color.Orange && button48.BackColor == Color.Orange && button49.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador2");
                }
                if (button47.BackColor == Color.Orange)
                {
                    Random aleatorio = new Random();
                    int num;
                    num = aleatorio.Next(1, 4);
                    if (num == 1)
                    {
                        button46.BackColor = Color.Red;
                    }
                    else if (num == 2)
                        button40.BackColor = Color.Red;
                    else
                        button48.BackColor = Color.Red;

                }
            }
            else if (button40.BackColor != Color.Orange && button40.BackColor != Color.Red)
            {
                button40.BackColor = Color.Orange;
            }
            else if (button33.BackColor != Color.Orange && button33.BackColor != Color.Red)
            {
                button33.BackColor = Color.Orange;
            }
            else if (button26.BackColor != Color.Orange && button26.BackColor != Color.Red)
            {
                button26.BackColor = Color.Orange;
                if (button47.BackColor == Color.Orange && button40.BackColor == Color.Orange && button33.BackColor == Color.Orange && button26.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador1");
                }
            }
            else if (button19.BackColor != Color.Orange && button19.BackColor != Color.Red)
            {
                button19.BackColor = Color.Orange;
            }
            else if (button12.BackColor != Color.Orange && button12.BackColor != Color.Red)
            {
                button12.BackColor = Color.Orange;
            }
            else if (button5.BackColor != Color.Orange && button5.BackColor != Color.Red)
            {
                button5.BackColor = Color.Orange;
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (button48.BackColor != Color.Orange)
            {
                button48.BackColor = Color.Orange;
                if (button48.BackColor == Color.Orange && button47.BackColor == Color.Orange && button46.BackColor == Color.Orange && button45.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador2");
                }
                if (button46.BackColor == Color.Orange && button47.BackColor == Color.Orange && button48.BackColor == Color.Orange && button49.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador2");
                }
                if (button48.BackColor == Color.Orange)
                {
                    Random aleatorio = new Random();
                    int num;
                    num = aleatorio.Next(1, 4);
                    if (num == 1)
                    {
                        button47.BackColor = Color.Red;
                    }
                    else if (num == 2)
                        button41.BackColor = Color.Red;
                    else
                        button49.BackColor = Color.Red;

                }
            }
            else if (button41.BackColor != Color.Orange && button41.BackColor != Color.Red)
            {
                button41.BackColor = Color.Orange;
            }
            else if (button34.BackColor != Color.Orange && button34.BackColor != Color.Red)
            {
                button34.BackColor = Color.Orange;
            }
            else if (button27.BackColor != Color.Orange && button27.BackColor != Color.Red)
            {
                button27.BackColor = Color.Orange;
                if (button48.BackColor == Color.Orange && button41.BackColor == Color.Orange && button34.BackColor == Color.Orange && button27.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador1");
                }
            }
            else if (button20.BackColor != Color.Orange && button20.BackColor != Color.Red)
            {
                button20.BackColor = Color.Orange;
            }
            else if (button13.BackColor != Color.Orange && button13.BackColor != Color.Red)
            {
                button13.BackColor = Color.Orange;
            }
            else if (button6.BackColor != Color.Orange && button6.BackColor != Color.Red)
            {
                button6.BackColor = Color.Orange;
            }
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            if (button49.BackColor != Color.Orange)
            {
                button49.BackColor = Color.Orange;
                if (button49.BackColor == Color.Orange && button48.BackColor == Color.Orange && button47.BackColor == Color.Orange && button46.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador2");
                }
                if (button49.BackColor == Color.Orange)
                {
                    Random aleatorio = new Random();
                    int num;
                    num = aleatorio.Next(1, 3);
                    if (num == 1)
                    {
                        button48.BackColor = Color.Red;
                    }
                    else if (num == 2)
                        button42.BackColor = Color.Red;
                    

                }
            }
            else if (button42.BackColor != Color.Orange && button42.BackColor != Color.Red)
            {
                button42.BackColor = Color.Orange;
            }
            else if (button35.BackColor != Color.Orange && button35.BackColor != Color.Red)
            {
                button35.BackColor = Color.Orange;
            }
            else if (button28.BackColor != Color.Orange && button28.BackColor != Color.Red)
            {
                button28.BackColor = Color.Orange;
                if (button49.BackColor == Color.Orange && button42.BackColor == Color.Orange && button35.BackColor == Color.Orange && button28.BackColor == Color.Orange)
                {
                    MessageBox.Show("ganador1");
                }
            }
            else if (button21.BackColor != Color.Orange && button21.BackColor != Color.Red)
            {
                button21.BackColor = Color.Orange;
            }
            else if (button14.BackColor != Color.Orange && button14.BackColor != Color.Red)
            {
                button14.BackColor = Color.Orange;
            }
            else if (button7.BackColor != Color.Orange && button7.BackColor != Color.Red)
            {
                button7.BackColor = Color.Orange;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

 
    }
}

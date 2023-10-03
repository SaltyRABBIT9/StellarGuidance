using System;
using System.Linq;
using System.Windows.Forms;

namespace StellarGuidance
{
    public enum zodiacsigns
    {
        Taurs, Aries, Libra, Leo, Gemini, Pieces, Capricorn, Sagittarius, Virgo, Cancer, Aquaries, Scorpio
    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            { 


                if (month.Text.All(char.IsDigit))
                {
                    MessageBox.Show("You forgot to specify which month you were born in.");
                }
                else if (date.Text.All(char.IsDigit))
                {
                }

                if (double.Parse(date.Text) > 31)
                {
                    MessageBox.Show("Please Enter a Valid Date");
                }
                else
                {
                    if (month.Text == "december")
                    {
                        if (double.Parse(date.Text) < 22)
                        {
                            zod.Text= " " + zodiacsigns.Capricorn;
                            des.Text = "Capricorn individuals are known for their discipline, ambition, and practicality. They are often responsible, reliable, and have a strong desire for success.";
                            image.BackgroundImage = zodiac.Images[0];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Sagittarius;
                            des.Text = "Sagittarius individuals are known for their adventurous spirit, optimism, and love for freedom. They are often open-minded, philosophical, and enjoy exploring new horizons.";
                            image.BackgroundImage = zodiac.Images[11];
                        }
                    }



                    if (month.Text == "january")
                    {
                        if (double.Parse(date.Text) < 20)
                        {
                            zod.Text = " " + zodiacsigns.Capricorn;
                            des.Text = "Capricorn individuals are known for their discipline, ambition, and practicality. They are often responsible, reliable, and have a strong desire for success.";
                            image.BackgroundImage = zodiac.Images[0];
                        }
                        else
                        {
                            zod.Text = " " + zodiacsigns.Aquaries;
                            des.Text = "Aquarius individuals are known for their independence, intellectualism, and humanitarian nature. They are often visionary, progressive, and value equality.";
                            image.BackgroundImage = zodiac.Images[1];

                        }
                    }

                    if (month.Text == "feburary")
                    {
                        if (double.Parse(date.Text) < 19)
                        {
                            zod.Text = " " + zodiacsigns.Aquaries;
                            des.Text = "Aquarius individuals are known for their independence, intellectualism, and humanitarian nature. They are often visionary, progressive, and value equality.";
                            image.BackgroundImage = zodiac.Images[1];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Pieces;
                            des.Text = "Pisces individuals are known for their empathy, creativity, and dreamy nature. They are often compassionate, intuitive, and have a deep connection to their emotions.";
                            image.BackgroundImage = zodiac.Images[2];
                        }
                    }

                    if (month.Text == "march")
                    {
                        if (double.Parse(date.Text) < 21)
                        {

                            zod.Text = " " + zodiacsigns.Pieces;
                            des.Text = "Pisces individuals are known for their empathy, creativity, and dreamy nature. They are often compassionate, intuitive, and have a deep connection to their emotions.";
                            image.BackgroundImage = zodiac.Images[2];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Aries;
                            des.Text = "Aries individuals are known for their confidence, courage, and assertiveness. They are natural leaders, energetic, and often have a competitive streak.";
                            image.BackgroundImage = zodiac.Images[3];
                        }
                    }
                    if (month.Text == "april")
                    {
                        if (double.Parse(date.Text) < 20)
                        {

                            zod.Text = " " + zodiacsigns.Aries;
                            des.Text = "Aries individuals are known for their confidence, courage, and assertiveness. They are natural leaders, energetic, and often have a competitive streak.";
                            image.BackgroundImage = zodiac.Images[3];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Taurs;
                            des.Text = "Taurus individuals are known for their stability, patience, and practicality. They are often reliable, determined, and have a strong sense of loyalty.";
                            image.BackgroundImage = zodiac.Images[4];
                        }
                    }
                    if (month.Text == "may")
                    {
                        if (double.Parse(date.Text) < 21)
                        {

                            zod.Text = " " + zodiacsigns.Taurs;
                            des.Text = "Taurus individuals are known for their stability,\n patience, and practicality. They are often reliable, determined, and have a strong sense of loyalty.";
                            image.BackgroundImage = zodiac.Images[4];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Gemini;
                            des.Text = "Gemini individuals are known for their versatility, adaptability, and wit. They are often curious, expressive, and enjoy intellectual conversations.";
                            image.BackgroundImage = zodiac.Images[5];
                        }
                    }
                    if (month.Text == "june")
                    {
                        if (double.Parse(date.Text) < 21)
                        {

                            zod.Text = " " + zodiacsigns.Gemini;
                            des.Text = "Gemini individuals are known for their versatility, adaptability, and wit. They are often curious, expressive, and enjoy intellectual conversations.";
                            image.BackgroundImage = zodiac.Images[5];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Cancer;
                            des.Text = "Cancer individuals are known for their sensitivity, empathy, and nurturing nature. They are often deeply intuitive, family-oriented, and value emotional connections.";
                            image.BackgroundImage = zodiac.Images[6];

                        }
                    }
                    if (month.Text == "july")
                    {
                        if (double.Parse(date.Text) < 22)
                        {

                            zod.Text = " " + zodiacsigns.Cancer;
                            des.Text = "Cancer individuals are known for their sensitivity, empathy, and nurturing nature. They are often deeply intuitive, family-oriented, and value emotional connections.";
                            image.BackgroundImage = zodiac.Images[6];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Leo;
                            des.Text = "Leo individuals are known for their confidence, charisma, and leadership qualities. They are often generous, ambitious, and enjoy being the center of attention.";
                            image.BackgroundImage = zodiac.Images[7];
                        }
                    }
                    if (month.Text == "august")
                    {
                        if (double.Parse(date.Text) < 23)
                        {

                            zod.Text = " " + zodiacsigns.Leo;
                            des.Text = "Leo individuals are known for their confidence, charisma, and leadership qualities. They are often generous, ambitious, and enjoy being the center of attention.";
                            image.BackgroundImage = zodiac.Images[7];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Virgo;
                            des.Text = "Virgo individuals are known for their practicality, attention to detail, and analytical nature. They are often hardworking, reliable, and have a strong sense of responsibility.";
                            image.BackgroundImage = zodiac.Images[8];
                        }
                    }
                    if (month.Text == "september")
                    {
                        if (double.Parse(date.Text) < 23)
                        {

                            zod.Text = " " + zodiacsigns.Virgo;
                            des.Text = "Virgo individuals are known for their practicality, attention to detail, and analytical nature. They are often hardworking, reliable, and have a strong sense of responsibility.";
                            image.BackgroundImage = zodiac.Images[8];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Libra;
                            des.Text = "Libra individuals are known for their diplomacy, harmony-seeking nature, and love for beauty. They are often social, fair-minded, and value peaceful relationships.";
                            image.BackgroundImage = zodiac.Images[9];

                        }
                    }
                    if (month.Text == "october")
                    {
                        if (double.Parse(date.Text) < 23)
                        {

                            zod.Text = " " + zodiacsigns.Libra;
                            des.Text = "Libra individuals are known for their diplomacy, harmony-seeking nature, and love for beauty. They are often social, fair-minded, and value peaceful relationships.";
                            image.BackgroundImage = zodiac.Images[9];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Scorpio;
                            des.Text = "Scorpio individuals are known for their intensity, passion, and deep emotional nature. They are often resourceful, determined, and have a keen ability to uncover secrets.";
                            image.BackgroundImage = zodiac.Images[10];
                        }
                    }
                    if (month.Text == "november")
                    {
                        if (double.Parse(date.Text) < 22)
                        {

                            zod.Text = " " + zodiacsigns.Scorpio;
                            des.Text = "Scorpio individuals are known for their intensity, passion, and deep emotional nature. They are often resourceful, determined, and have a keen ability to uncover secrets.";
                            image.BackgroundImage = zodiac.Images[10];
                        }
                        else
                        {

                            zod.Text = " " + zodiacsigns.Sagittarius;
                            des.Text = "Sagittarius individuals are known for their adventurous spirit, optimism, and love for freedom. They are often open-minded, philosophical, and enjoy exploring new horizons.";
                            image.BackgroundImage = zodiac.Images[11];
                        }
                    }

                }

            }
            catch
            {
                MessageBox.Show("please enter number for the day");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
       // {

       // }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void month_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            date.ResetText();
            month.ResetText();
            des.ResetText();
            zod.ResetText();

            image.BackgroundImage = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void image_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

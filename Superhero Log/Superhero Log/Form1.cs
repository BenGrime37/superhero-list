using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Superhero_Log
{
    public partial class SuperheroLog : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public SuperheroLog()
        {
            InitializeComponent();

            MyGlobals.TxtToSpeech = 1;//on

            //player.SoundLocation = "C:\\Users\\ben-grime\\OneDrive - York College\\45_avengers_movie_theme_music_mp3_ringtone_ringtone_mp3.wav";//location of file location


            player.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static class MyGlobals
        {
            public static int TxtToSpeech = 1;//define global variable
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            textChar.AutoCompleteSource = AutoCompleteSource.CustomSource;//define source 
            textChar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;//say weather it should suggest it and add it when its clicked

            textReal.AutoCompleteSource = AutoCompleteSource.CustomSource;//define source 
            textReal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;//say weather it should suggest it and add it when its clicked

            bool Found = false; // set found to false


            List<Tuple<string, string, string, string, string, string, string>> mylist = new List<Tuple<string, string, string, string, string, string, string>>();
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Spiderman", "Peter Parker", "Strong, climbs stuff, amazing senses, smart", "Marvel", "Alive", "", "Tom Holland"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Iron Man", "Tony Stark", "Genius, Billionaire, Playboy, Philanthropist, Advanced suit", "Marvel", "Dead", "Avengers: Endgame", "Robert Downey Jr"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Deadpool", "Wade Wilson", "Regenerates, immortal", "X-Men", "Alive", "", "Ryan Reynolds"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Wolverine", "logan", "Regenerates", "X-Men", "Dead", "Logan", "Hugh Jackman"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Black Widow", "Natasha Romanoff", "Fighting Skills, amazing hand to hand combat", "Marvel", "Dead", "Avengers: Infinity War", "Scarlett Johansson"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Batman", "Bruce Wayne", "Fighting Skills, Rich", "DC", "Alive", "", "Christian Bale"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Thor", "Thor Odinson", "God of Thunder", "Marvel", "Alive", "", "Chris Hemsworth"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Flash", "Barry Allen", "Extremely fast", "DC", "Alive", "", "Ezra Miller"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Scarlett Witch", "Wanda Maximoff", "Magic", "Marvel", "Alive", "", "Elizabeth Olsen"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Black Panther", "King T'Challa", "Athletic, Vibranium suit", "Marvel", "Alive", "", "Chadwick Boseman (dead)"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Quicksilver", "Pietro Maximoff", "Fast", "Marvel", "Dead", "Avengers: Age of Ultron", "Aaron Taylor-Johnson"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Loki", "Loki Odinson", "God of Mischief", "Marvel", "Dead", "Avengers: Infinity War", "Tom Hiddlestone"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Wonder Woman", "Princess Diana of Themyscira", "Strength, Speed, Agility", "DC", "Alive", "", "Gal Gadot"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Doctor Strange", "Dr Steven Strange", "Magic", "Marvel", "Alive", "", "Benedict Cumberbatch"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Odin", "Odin", "God of War and Wisdom", "Marvel", "Dead", "Thor: Ragnarok", "Anthony Hopkins"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Yondu", "Yondu", "Expert Archer, Empathic relations with life forms", "Marvel", "Dead", "Guardians of the Galaxy: Vol 2", "James Arnold Taylor"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Vision", "Vision", "Energy Beam from forehead, Talk to Machines", "Marvel", "Dead", "Avengers: Infinity War", "Paul Bettany"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Mystique", "Raven Darkhölme", "Shapeshifter", "X-Men", "Dead", "X-Men: Dark Phoenix", "Jeniffer Lawrence"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Gamora", "Gamora Zen Whoberi Ben Titan", "Superhuman Strength, Agility, Quickly Heals", "Marvel", "Dead", "Avengers: Infinity War", "Zoe Saldana"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Captain Marvel", "Carol Danvers", "Superhuman Strength, Disharge Energy", "Marvel", "Alive", "", "Brie Larson"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Captain America", "Steve Rogers", "Super Soldier, Vibranium Shield", "Marvel", "Dead", "Inbetween Avengers: Endgame and Falcon and the Winter Soldier", "Chris Evans"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Winter Soldier", "James 'Bucky' Barnes", "Super Soldier, Vibranium Arm", "Marvel", "Alive", "", "Sebastian Stan"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Falcon", "Sam Wilson", "Vibranium Wing Suit", "Marvel", "Alive", "", "Anthony Mackie"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Hawkeye", "Clint Barton", "Excellent with Bow and Arrow", "Marvel", "Alive", "", "Jeremy Renner"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("War Machine", "James Rupert 'Rhodey' Rhodes", "Advanced Suit like Iron Man", "Marvel", "Alive", "", "Don Cheadle"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Hulk", "Bruce Banner", "Superhuman Strength, Bulletproof, Angry", "Marvel", "Alive", "", "Mark Ruffalo"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Wasp", "Hope Van Dyne", "Suit that can change size and fly", "Marvel", "Alive", "", "Evangeline Lilly"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Antman", "Scott Lang", "Suit that can chnage size", "Marvel", "Alive", "", "Paul Rudd"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Human Torch", "Johnny Storm", "Fly, Sets himself on fire", "Fantasic 4", "Alive", "", "Chris Evans"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Mr Fantastic", "Reed Richards", "Stretching", "Fantastic 4", "Alive", "", "Ioan Gruffudd"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Professor X", "Charles Xavier", "Read and Control minds", "X-Men", "Dead", "X-Men: The Last Stand", "Patrick Stewart/James McAvoy"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Storm", "Ororo Monroe", "Controls the weather", "X-Men", "Alive", "", "Halle Berry"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Aquaman", "Arthur Curry", "Superhuman Strength, Talk to Sea Creatures", "DC", "Alive", "", "Jason Momoa"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Green Lantern", "Alan Scott", "Power Ring", "DC", "Alive", "", "Ryan Reynolds"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("New Captain America", "John Walker", "vibranium sheild, good fighting skills", "Marvel", "Alive", "", "Wyatt Russell"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Rocket", "Rocket", "Marksman, Smart, great hand to hand combat, master tactician", "Marvel", "Alive", "", "Bradley Cooper"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Groot", "Groot", "invulnerable to projectiles, can grow very quickly can regrow", "Marvel", "Alive", "", "Vin Diesal"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Star Lord", "Peter Quill", "Superhuman Strength, Universal Laguage Translation", "Marvel", "Alive", "", "Chris Pratt"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Nebula", "Nebula", "Superhuman Strength, great hand to hand combat", "Marvel", "Alive", "", "Karen Gillan"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Drax", "Drax the Destroyer", "Superhuman Strength, amazing fighter", "Marvel", "Alive", "", "Dave Bautista"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Mantis", "Mantis", "Sense feelings and alter them", "Marvel", "Alive", "", "Pom Klementieff"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Superman", "Clark Kent", "X-ray vision, Super Strong, Fly, Very fast, Heals quickly", "DC", "Alive", "", "Henry Cavill"));
            mylist.Add(new Tuple<string, string, string, string, string, string, string>("Shang Chi", "Shang Chi", "Amazing Fighting Skills", "Marvel", "Alive", "", "Simu Lui"));


            if (textChar.Text != "")//look for the superhero name and fill the rest in
            {
                foreach (var element in mylist) //chech every element in list
                {
                    if (element.Item1.ToLower() == textChar.Text.ToLower())//ToLower = not case sensitive
                    {
                        textChar.Text = element.Item1;
                        textReal.Text = element.Item2;
                        textSpecial.Text = element.Item3;
                        textUni.Text = element.Item4;
                        textAlive.Text = element.Item5;
                        textDiedFilm.Text = element.Item6;
                        textActor.Text = element.Item7;
                        Found = true;
                    }
                }
                if (MyGlobals.TxtToSpeech == 1) //if its on
                {

                    SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                    synthesizer.Volume = 100;  // 0...100
                    synthesizer.Rate = -2;     // -10...10

                    synthesizer.Speak(textChar.Text); //speak whats in the text box
                }
            }

            if (textReal.Text != "")//look for the characters real name and have the rest filled in
            {
                foreach (var element in mylist) //chech every element in list
                {
                    if (element.Item2.ToLower() == textReal.Text.ToLower())//ToLower = not case sensitive
                    {
                        textChar.Text = element.Item1;
                        textReal.Text = element.Item2;
                        textSpecial.Text = element.Item3;
                        textUni.Text = element.Item4;
                        textAlive.Text = element.Item5;
                        textDiedFilm.Text = element.Item6;
                        textActor.Text = element.Item7;
                        Found = true;
                    }
                }
                if (MyGlobals.TxtToSpeech == 1) //if its on
                {

                    SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                    synthesizer.Volume = 100;  // 0...100
                    synthesizer.Rate = -2;     // -10...10

                    synthesizer.Speak(textReal.Text); //speak whats in the text box
                }
            }

            if (Found == false) // if it hasnt been found
            {
                MessageBox.Show("Sorry that hasn't been found", "Nice Message"); //show message them set the text boxes to empty
                textChar.Text = "";
                textReal.Text = "";
                textSpecial.Text = "";
                textUni.Text = "";
                textAlive.Text = "";
                textDiedFilm.Text = "";
                textActor.Text = "";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your time", "Goodbye"); //show message box with his message
            Application.Exit(); //exit
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textChar.Text = ""; //set all the text boxes to empty
            textReal.Text = "";
            textSpecial.Text = "";
            textUni.Text = "";
            textAlive.Text = "";
            textDiedFilm.Text = "";
            textActor.Text = "";
        }

        private void MusicOn_CheckedChanged(object sender, EventArgs e)
        {
            if (musicOn.Checked)
            {
                //player.PlayLooping();
            }
            else
            {
                player.Stop();
            }
        }

        private void SpeechOn_CheckedChanged(object sender, EventArgs e)
        {
            if (speechOn.Checked)
            {
                MyGlobals.TxtToSpeech = 1; //turn it on
            }
            else
            {
                MyGlobals.TxtToSpeech = 0; //turn it off
            }
        }
    }
}

using System.Media;
namespace Cat_Game
{
    public partial class Form1 : Form
    {
        PictureBox[] boxes;
        Random random = new Random();

        int bombIndex;
        int score = 0;
        SoundPlayer sp = new SoundPlayer(@"C:\Users\mahmu\Downloads\explosion.wav");
        bool gameOver = false;
        bool[] opened = new bool[6];

        public Form1()
        {
            InitializeComponent();
            boxes = new PictureBox[]
   {
        pic1, pic2, pic3,
        pic4, pic5, pic6
   };

            foreach (PictureBox box in boxes)
            {
                box.SizeMode = PictureBoxSizeMode.Zoom;
                box.Image = Properties.Resources.question;
                box.Click += PictureBox_Click;
            }

            btnNewGame.Click += btnNewGame_Click;
            btnExit.Click += btnExit_Click;

            NewGame();
        }
        private void NewGame()
        {
            score = 0;
            gameOver = false;
            opened = new bool[6];

            lblScore.Text = "Xal: 0";

            bombIndex = random.Next(0, 6);

            foreach (PictureBox box in boxes)
            {
                box.Image = Properties.Resources.question;
                box.Enabled = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
{
    DialogResult result = MessageBox.Show(
        "Oyundan çıxmaq istəyirsiniz?",
        "Bildiriş",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

    if (result == DialogResult.Yes)
    {
        Application.Exit();
    }
}
        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (gameOver)
                return;

            PictureBox clickedBox = sender as PictureBox;

            int index = Array.IndexOf(boxes, clickedBox);

            if (opened[index])
                return;

            opened[index] = true;
            if (index == bombIndex)
            {
                sp.Play();
                clickedBox.Image = Properties.Resources.boom;

                System.Media.SystemSounds.Exclamation.Play();

                gameOver = true;

                foreach (PictureBox box in boxes)
                {
                    box.Enabled = false;
                }

                MessageBox.Show("Oyun bitdi!", "Bildiriş");
            }
            else
            {
                clickedBox.Image = Properties.Resources.cat;

                score++;

                lblScore.Text = "Xal: " + score;
            }
            if (score == 5)
            {
                gameOver = true;

                foreach (PictureBox box in boxes)
                {
                    box.Enabled = false;
                }

                MessageBox.Show(
                    "Oyunu qazandınız, Yeni oyun üçün OK düyməsinə basın",
                    "Təbriklər"
                );

                NewGame();
            }
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

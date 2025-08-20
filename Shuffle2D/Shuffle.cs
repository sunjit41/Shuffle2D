using Microsoft.Win32;

namespace Shuffle2D
{
    public partial class FormShuffle : Form
    {
        private Shuffle2D.GameBoard game = new Shuffle2D.GameBoard();
        private int MoveSuccess = 0;
        private bool GameWin = false;
        private int[] ShuffledGame = new int[15];
        int BestScore = 0;


        public FormShuffle()
        {
            InitializeComponent();
        }

        private void ShowAbout()
        {
            string msg = "Programmer: Sunjit S. Nair \r\n" +
            "Microsoft Certification ID: 3778888, \r\n" +
            "Certification: Microsoft Certified Application Developer \r\n \r\n" +
            "Title of this program: Shuffle 2D \r\n" +
            "Category: Low resource Game.\r\n" +
            "Development tool used: Microsoft Visual Studio 2022 \r\n" +
            "Programming Language used for coding: C# .Net \r\n" +
            "Developed: Jan-2023 \r\n" +
            "Total Development time: 1 Day \r\n \r\n" +
            "About: I have 22 years experience in programming. This game was a New Year Surpise (2023) for my followers.\r\n\r\n" +
            "Website: \r\n" +
            "         sunjit41.com \r\n";
            MessageBox.Show(msg, "About Shuffle 2D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TryPosition(object sender, EventArgs e)
        {
            if(!GameWin)
            {
                int CurrentPlay = 0;
                Button clickedButton = (Button)sender;
                if (clickedButton.Tag is not null)
                {
                    string tmp = (string)clickedButton.Tag;
                    CurrentPlay = int.Parse(tmp);
                }
                MoveSuccess = game.CheckMove(CurrentPlay);
                if (MoveSuccess > 0)
                {
                    switch (MoveSuccess)
                    {
                        case 1:
                            Button1.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 2:
                            Button2.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 3:
                            Button3.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 4:
                            Button4.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 5:
                            Button5.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 6:
                            Button6.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 7:
                            Button7.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 8:
                            Button8.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 9:
                            Button9.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 10:
                            Button10.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 11:
                            Button11.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 12:
                            Button12.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 13:
                            Button13.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 14:
                            Button14.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 15:
                            Button15.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                        case 16:
                            Button16.Text = clickedButton.Text;
                            clickedButton.Text = string.Empty;
                            break;
                    }
                }
                GameWin = game.CheckForWin();
                if (GameWin)
                {
                    if((game.GameMoves < BestScore) || BestScore == 0)
                    {
                        BestScore = game.GameMoves;
                        SaveAppSettings(BestScore);
                        LabelBestScore.Text = "Best Score: " + BestScore;
                    }
                    LabelMoves.Text = "You won in " + game.GameMoves + " moves.";
                    MessageBox.Show("You have won the game in " + game.GameMoves + " moves", "Congratulations !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    UpdateScores();
                }
            }
            else
            {
                MessageBox.Show("You have already won the game. Please start a new game by clicking on Shuffle.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void UpdateScores()
        {
            LabelMoves.Text = "Moves : " + game.GameMoves;
        }

        private void NewGame()
        {
            game.StartGame();
            GameWin = false;
            ShuffledGame = game.Shuffle();
            Button1.Text = ShuffledGame[0] == 16 ? string.Empty : ShuffledGame[0].ToString();
            Button2.Text = ShuffledGame[1] == 16 ? string.Empty : ShuffledGame[1].ToString();
            Button3.Text = ShuffledGame[2] == 16 ? string.Empty : ShuffledGame[2].ToString();
            Button4.Text = ShuffledGame[3] == 16 ? string.Empty : ShuffledGame[3].ToString();
            Button5.Text = ShuffledGame[4] == 16 ? string.Empty : ShuffledGame[4].ToString();
            Button6.Text = ShuffledGame[5] == 16 ? string.Empty : ShuffledGame[5].ToString();
            Button7.Text = ShuffledGame[6] == 16 ? string.Empty : ShuffledGame[6].ToString();
            Button8.Text = ShuffledGame[7] == 16 ? string.Empty : ShuffledGame[7].ToString();
            Button9.Text = ShuffledGame[8] == 16 ? string.Empty : ShuffledGame[8].ToString();
            Button10.Text = ShuffledGame[9] == 16 ? string.Empty : ShuffledGame[9].ToString();
            Button11.Text = ShuffledGame[10] == 16 ? string.Empty : ShuffledGame[10].ToString();
            Button12.Text = ShuffledGame[11] == 16 ? string.Empty : ShuffledGame[11].ToString();
            Button13.Text = ShuffledGame[12] == 16 ? string.Empty : ShuffledGame[12].ToString();
            Button14.Text = ShuffledGame[13] == 16 ? string.Empty : ShuffledGame[13].ToString();
            Button15.Text = ShuffledGame[14] == 16 ? string.Empty : ShuffledGame[14].ToString();
            Button16.Text = ShuffledGame[15] == 16 ? string.Empty : ShuffledGame[15].ToString();
            UpdateScores();
        }

        private void LinkShuffle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewGame();
        }

        private void FormShuffle_Load(object sender, EventArgs e)
        {
            NewGame();
            LoadAppSettings();
        }

        private void LoadAppSettings()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Sunjit41\Shuffle2D");
                if (key != null)
                {
                    BestScore = (int)key.GetValue("BestScore", 0);
                    LabelBestScore.Text = "Best Score: " + BestScore;
                    key.Close();
                }
                else
                {
                    BestScore = 0;
                    LabelBestScore.Text = "Best Score: " + BestScore;
                }
            }
            catch (Exception ex)
            {
                BestScore = 0;
                LabelBestScore.Text = "Best Score: " + BestScore;
                MessageBox.Show("Could not load your best score", "Error in loading score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAppSettings(int BestScore)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Sunjit41\Shuffle2D");
                key.SetValue("BestScore", BestScore);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save your best score", "Error in saving score", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void LinkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowAbout();
        }
    }
}

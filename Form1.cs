using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public const string PLAYER = "X";
        public const string COM = "O";
        public Color WIN = Color.Green;
        public Color LOSE = Color.Red;
        public bool playerWin;
        public bool tieGame = false;
        public bool gameOver = false;
        public bool comTurn = false;
        public int turnCount = 0;

        public Random rng = new Random();

        public Label[] squares = new Label[9];
        public List<Label> playerSquares = new List<Label>();
        public List<Label> comSquares = new List<Label>();
        public List<Label> winSquares = new List<Label>();
        public Form1()
        {
            InitializeComponent();

            squares[0] = square0;
            squares[1] = square1;
            squares[2] = square2;
            squares[3] = square3;
            squares[4] = square4;
            squares[5] = square5;
            squares[6] = square6;
            squares[7] = square7;
            squares[8] = square8;

            NewGame();
        }

        private async void Square_Click(object sender, EventArgs e)
        {
            Label square = sender as Label;

            if (square.Text == " ")
            {
                if (square == squares[0])
                    squares[0].Text = PLAYER;

                if (square == squares[1])
                    squares[1].Text = PLAYER;

                if (square == squares[2])
                    squares[2].Text = PLAYER;

                if (square == squares[3])
                    squares[3].Text = PLAYER;

                if (square == squares[4])
                    squares[4].Text = PLAYER;

                if (square == squares[5])
                    squares[5].Text = PLAYER;

                if (square == squares[6])
                    squares[6].Text = PLAYER;

                if (square == squares[7])
                    squares[7].Text = PLAYER;

                if (square == squares[8])
                    squares[8].Text = PLAYER;
            }
            else
            {
                return;
            }

            playerSquares.Add(square);

            CheckWin();
            await Task.Delay(250);
            turnCount++;
            ComputerTurn();
        }

        private void NewGame()
        {
            foreach (Label label in squares)
            {
                label.Text = " ";
                label.BackColor = SystemColors.Control;
                label.Enabled = true;
            }

            winLabel.Text = "";
            winLabel.BackColor = SystemColors.Control;
            playerSquares.Clear();
            comSquares.Clear();
            winSquares.Clear();
            turnCount = 0;
            tieGame = false;
            gameOver = false;
        }

        private void ComputerTurn()
        {
            CheckWin();
            comTurn = true;
            if (!gameOver)
            {
                ComOwnsTwo();
                PlayerOwnsTwo();
                ComOwnsOne();
                ComOwnsNone();
                turnCount++;
                CheckWin();
            }
            
        }

        private void CheckWin()
        {
            // Player Win Conditions
            if (playerSquares.Contains(square0) && playerSquares.Contains(square1) && playerSquares.Contains(square2))
            {
                playerWin = true;
                winSquares.Add(square0);
                winSquares.Add(square1);
                winSquares.Add(square2);
            }
            else if (playerSquares.Contains(square3) && playerSquares.Contains(square4) && playerSquares.Contains(square5))
            {
                playerWin = true;
                winSquares.Add(square3);
                winSquares.Add(square4);
                winSquares.Add(square5);
            }
            else if (playerSquares.Contains(square6) && playerSquares.Contains(square7) && playerSquares.Contains(square8))
            {
                playerWin = true;
                winSquares.Add(square6);
                winSquares.Add(square7);
                winSquares.Add(square8);
            }
            else if (playerSquares.Contains(square0) && playerSquares.Contains(square3) && playerSquares.Contains(square6))
            {
                playerWin = true;
                winSquares.Add(square0);
                winSquares.Add(square3);
                winSquares.Add(square6);
            }
            else if (playerSquares.Contains(square1) && playerSquares.Contains(square4) && playerSquares.Contains(square7))
            {
                playerWin = true;
                winSquares.Add(square1);
                winSquares.Add(square4);
                winSquares.Add(square7);
            }
            else if (playerSquares.Contains(square2) && playerSquares.Contains(square5) && playerSquares.Contains(square8))
            {
                playerWin = true;
                winSquares.Add(square2);
                winSquares.Add(square5);
                winSquares.Add(square8);
            }
            else if (playerSquares.Contains(square0) && playerSquares.Contains(square4) && playerSquares.Contains(square8))
            {
                playerWin = true;
                winSquares.Add(square0);
                winSquares.Add(square4);
                winSquares.Add(square8);
            }
            else if (playerSquares.Contains(square2) && playerSquares.Contains(square4) && playerSquares.Contains(square6))
            {
                playerWin = true;
                winSquares.Add(square2);
                winSquares.Add(square4);
                winSquares.Add(square6);
            }

            // Computer Win Conditions
            else if (comSquares.Contains(square0) && comSquares.Contains(square1) && comSquares.Contains(square2))
            {
                playerWin = false;
                winSquares.Add(square0);
                winSquares.Add(square1);
                winSquares.Add(square2);
            }
            else if (comSquares.Contains(square3) && comSquares.Contains(square4) && comSquares.Contains(square5))
            {
                playerWin = false;
                winSquares.Add(square3);
                winSquares.Add(square4);
                winSquares.Add(square5);
            }
            else if (comSquares.Contains(square6) && comSquares.Contains(square7) && comSquares.Contains(square8))
            {
                playerWin = false;
                winSquares.Add(square6);
                winSquares.Add(square7);
                winSquares.Add(square8);
            }
            else if (comSquares.Contains(square0) && comSquares.Contains(square3) && comSquares.Contains(square6))
            {
                playerWin = false;
                winSquares.Add(square0);
                winSquares.Add(square3);
                winSquares.Add(square6);
            }
            else if (comSquares.Contains(square1) && comSquares.Contains(square4) && comSquares.Contains(square7))
            {
                playerWin = false;
                winSquares.Add(square1);
                winSquares.Add(square4);
                winSquares.Add(square7);
            }
            else if (comSquares.Contains(square2) && comSquares.Contains(square5) && comSquares.Contains(square8))
            {
                playerWin = false;
                winSquares.Add(square2);
                winSquares.Add(square5);
                winSquares.Add(square8);
            }
            else if (comSquares.Contains(square0) && comSquares.Contains(square4) && comSquares.Contains(square8))
            {
                playerWin = false;
                winSquares.Add(square0);
                winSquares.Add(square4);
                winSquares.Add(square8);
            }
            else if (comSquares.Contains(square2) && comSquares.Contains(square4) && comSquares.Contains(square6))
            {
                playerWin = false;
                winSquares.Add(square2);
                winSquares.Add(square4);
                winSquares.Add(square6);
            }
            else if (turnCount >= 9)
            {
                tieGame = true;
            }
            else { return; }

            gameOver = true;

            if (playerWin)
            {
                foreach (Label square in winSquares)
                {
                    square.BackColor = WIN;
                }
                winLabel.ForeColor = WIN;
                winLabel.Text = "Player Wins!";
            }
            else if (!playerWin)
            {
                foreach (Label square in winSquares)
                {
                    square.BackColor = LOSE;
                }
                winLabel.ForeColor = LOSE;
                winLabel.Text = "Computer Wins!";
            }
            else { return; }

            if (tieGame)
            {
                winLabel.ForeColor = Color.Black;
                winLabel.Text = "Tie Game!";
            }  

            foreach (Label square in squares)
            {
                square.Enabled = false;
            }
        }

        private void ComOwnsTwo()
        {
            if (comSquares.Contains(square0) && comSquares.Contains(square1) && square2.Text == " ")
            {
                square2.Text = COM;
                comSquares.Add(square2);
            }
            else if (comSquares.Contains(square1) && comSquares.Contains(square2) && square0.Text == " ")
            {
                square0.Text = COM;
                comSquares.Add(square0);
            }
            else if (comSquares.Contains(square0) && comSquares.Contains(square2) && square1.Text == " ")
            {
                square1.Text = COM;
                comSquares.Add(square1);
            }

            else if (comSquares.Contains(square3) && comSquares.Contains(square4) && square5.Text == " ")
            {
                square5.Text = COM;
                comSquares.Add(square5);
            }
            else if (comSquares.Contains(square4) && comSquares.Contains(square5) && square3.Text == " ")
            {
                square3.Text = COM;
                comSquares.Add(square3);
            }
            else if (comSquares.Contains(square3) && comSquares.Contains(square5) && square4.Text == " ")
            {
                square4.Text = COM;
                comSquares.Add(square4);
            }

            else if (comSquares.Contains(square6) && comSquares.Contains(square7) && square8.Text == " ")
            {
                square8.Text = COM;
                comSquares.Add(square8);
            }
            else if (comSquares.Contains(square7) && comSquares.Contains(square8) && square6.Text == " ")
            {
                square6.Text = COM;
                comSquares.Add(square6);
            }
            else if (comSquares.Contains(square6) && comSquares.Contains(square8) && square7.Text == " ")
            {
                square7.Text = COM;
                comSquares.Add(square7);
            }

            else if (comSquares.Contains(square0) && comSquares.Contains(square3) && square6.Text == " ")
            {
                square6.Text = COM;
                comSquares.Add(square6);
            }
            else if (comSquares.Contains(square3) && comSquares.Contains(square6) && square0.Text == " ")
            {
                square0.Text = COM;
                comSquares.Add(square0);
            }
            else if (comSquares.Contains(square0) && comSquares.Contains(square6) && square3.Text == " ")
            {
                square3.Text = COM;
                comSquares.Add(square3);
            }

            else if (comSquares.Contains(square1) && comSquares.Contains(square4) && square7.Text == " ")
            {
                square7.Text = COM;
                comSquares.Add(square7);
            }
            else if (comSquares.Contains(square4) && comSquares.Contains(square7) && square1.Text == " ")
            {
                square1.Text = COM;
                comSquares.Add(square1);
            }
            else if (comSquares.Contains(square1) && comSquares.Contains(square7) && square4.Text == " ")
            {
                square4.Text = COM;
                comSquares.Add(square4);
            }

            else if (comSquares.Contains(square2) && comSquares.Contains(square5) && square8.Text == " ")
            {
                square8.Text = COM;
                comSquares.Add(square8);
            }
            else if (comSquares.Contains(square5) && comSquares.Contains(square8) && square2.Text == " ")
            {
                square2.Text = COM;
                comSquares.Add(square2);
            }
            else if (comSquares.Contains(square2) && comSquares.Contains(square8) && square5.Text == " ")
            {
                square5.Text = COM;
                comSquares.Add(square5);
            }

            else if (comSquares.Contains(square0) && comSquares.Contains(square4) && square8.Text == " ")
            {
                square8.Text = COM;
                comSquares.Add(square8);
            }
            else if (comSquares.Contains(square4) && comSquares.Contains(square8) && square0.Text == " ")
            {
                square0.Text = COM;
                comSquares.Add(square0);
            }
            else if (comSquares.Contains(square0) && comSquares.Contains(square8) && square4.Text == " ")
            {
                square4.Text = COM;
                comSquares.Add(square4);
            }

            else if (comSquares.Contains(square2) && comSquares.Contains(square4) && square6.Text == " ")
            {
                square6.Text = COM;
                comSquares.Add(square6);
            }
            else if (comSquares.Contains(square4) && comSquares.Contains(square6) && square2.Text == " ")
            {
                square2.Text = COM;
                comSquares.Add(square2);
            }
            else if (comSquares.Contains(square2) && comSquares.Contains(square6) && square4.Text == " ")
            {
                square4.Text = COM;
                comSquares.Add(square4);
            }
            else { return; }

            comTurn = false;
            CheckWin();
        }

        private void PlayerOwnsTwo()
        {
            if (gameOver) { return; }
            if (playerSquares.Contains(square0) && playerSquares.Contains(square1) && square2.Text == " ")
            {
                square2.Text = COM;
                comSquares.Add(square2);
            }
            else if (playerSquares.Contains(square1) && playerSquares.Contains(square2) && square0.Text == " ")
            {
                square0.Text = COM;
                comSquares.Add(square0);
            }
            else if (playerSquares.Contains(square0) && playerSquares.Contains(square2) && square1.Text == " ")
            {
                square1.Text = COM;
                comSquares.Add(square1);
            }

            else if (playerSquares.Contains(square3) && playerSquares.Contains(square4) && square5.Text == " ")
            {
                square5.Text = COM;
                comSquares.Add(square5);
            }
            else if (playerSquares.Contains(square4) && playerSquares.Contains(square5) && square3.Text == " ")
            {
                square3.Text = COM;
                comSquares.Add(square3);
            }
            else if (playerSquares.Contains(square3) && playerSquares.Contains(square5) && square4.Text == " ")
            {
                square4.Text = COM;
                comSquares.Add(square4);
            }

            else if (playerSquares.Contains(square6) && playerSquares.Contains(square7) && square8.Text == " ")
            {
                square8.Text = COM;
                comSquares.Add(square8);
            }
            else if (playerSquares.Contains(square7) && playerSquares.Contains(square8) && square6.Text == " ")
            {
                square6.Text = COM;
                comSquares.Add(square6);
            }
            else if (playerSquares.Contains(square6) && playerSquares.Contains(square8) && square7.Text == " ")
            {
                square7.Text = COM;
                comSquares.Add(square7);
            }

            else if (playerSquares.Contains(square0) && playerSquares.Contains(square3) && square6.Text == " ")
            {
                square6.Text = COM;
                comSquares.Add(square6);
            }
            else if (playerSquares.Contains(square3) && playerSquares.Contains(square6) && square0.Text == " ")
            {
                square0.Text = COM;
                comSquares.Add(square0);
            }
            else if (playerSquares.Contains(square0) && playerSquares.Contains(square6) && square3.Text == " ")
            {
                square3.Text = COM;
                comSquares.Add(square3);
            }

            else if (playerSquares.Contains(square1) && playerSquares.Contains(square4) && square7.Text == " ")
            {
                square7.Text = COM;
                comSquares.Add(square7);
            }
            else if (playerSquares.Contains(square4) && playerSquares.Contains(square7) && square1.Text == " ")
            {
                square1.Text = COM;
                comSquares.Add(square1);
            }
            else if (playerSquares.Contains(square1) && playerSquares.Contains(square7) && square4.Text == " ")
            {
                square4.Text = COM;
                comSquares.Add(square4);
            }

            else if (playerSquares.Contains(square2) && playerSquares.Contains(square5) && square8.Text == " ")
            {
                square8.Text = COM;
                comSquares.Add(square8);
            }
            else if (playerSquares.Contains(square5) && playerSquares.Contains(square8) && square2.Text == " ")
            {
                square2.Text = COM;
                comSquares.Add(square2);
            }
            else if (playerSquares.Contains(square2) && playerSquares.Contains(square8) && square5.Text == " ")
            {
                square5.Text = COM;
                comSquares.Add(square5);
            }

            else if (playerSquares.Contains(square0) && playerSquares.Contains(square4) && square8.Text == " ")
            {
                square8.Text = COM;
                comSquares.Add(square8);
            }
            else if (playerSquares.Contains(square4) && playerSquares.Contains(square8) && square0.Text == " ")
            {
                square0.Text = COM;
                comSquares.Add(square0);
            }
            else if (playerSquares.Contains(square0) && playerSquares.Contains(square8) && square4.Text == " ")
            {
                square4.Text = COM;
                comSquares.Add(square4);
            }
            else if (playerSquares.Contains(square2) && playerSquares.Contains(square4) && square6.Text == " ")
            {
                square6.Text = COM;
                comSquares.Add(square6);
            }
            else if (playerSquares.Contains(square4) && playerSquares.Contains(square6) && square2.Text == " ")
            {
                square2.Text = COM;
                comSquares.Add(square2);
            }
            else if (playerSquares.Contains(square2) && playerSquares.Contains(square6) && square4.Text == " ")
            {
                square4.Text = COM;
                comSquares.Add(square4);
            }
            else { return; }

            comTurn = false;
            CheckWin();
        }

        private void ComOwnsOne()
        {
            int pick;
            List<Label> choiceList = new List<Label>();
            if (comTurn == true && gameOver != true)
            {
                try {
                    if (comSquares.Contains(square0))
                    {
                        foreach (Label square in squares)
                        {
                            if ((square == square1 || square == square2 || square == square3
                                || square == square4 || square == square6 || square == square8) && square.Text == " ")
                            {
                                choiceList.Add(square);
                            }
                        }
                        pick = rng.Next(0, choiceList.Count);
                        choiceList[pick].Text = COM;
                        comSquares.Add(choiceList[pick]);
                    }
                    else if (comSquares.Contains(square1))
                    {
                        foreach (Label square in squares)
                        {
                            if ((square == square0 || square == square2
                                || square == square4 || square == square7) && square.Text == " ")
                            {
                                choiceList.Add(square);
                            }
                        }
                        pick = rng.Next(0, choiceList.Count);
                        choiceList[pick].Text = COM;
                        comSquares.Add(choiceList[pick]);
                    }
                    else if (comSquares.Contains(square2))
                    {
                        foreach (Label square in squares)
                        {
                            if ((square == square0 || square == square1 || square == square4
                                || square == square5 || square == square6 || square == square8) && square.Text == " ")
                            {
                                choiceList.Add(square);
                            }
                        }
                        pick = rng.Next(0, choiceList.Count);
                        choiceList[pick].Text = COM;
                        comSquares.Add(choiceList[pick]);
                    }
                    else if (comSquares.Contains(square3))
                    {
                        foreach (Label square in squares)
                        {
                            if ((square == square0 || square == square6
                                || square == square4 || square == square5) && square.Text == " ")
                            {
                                choiceList.Add(square);
                            }
                        }
                        pick = rng.Next(0, choiceList.Count);
                        choiceList[pick].Text = COM;
                        comSquares.Add(choiceList[pick]);
                    }
                    else if (comSquares.Contains(square4))
                    {
                        foreach (Label square in squares)
                        {
                            if (square.Text == " ")
                            {
                                choiceList.Add(square);
                            }
                        }
                        pick = rng.Next(0, choiceList.Count);
                        choiceList[pick].Text = COM;
                        comSquares.Add(choiceList[pick]);
                    }
                    else if (comSquares.Contains(square5))
                    {
                        foreach (Label square in squares)
                        {
                            if ((square == square2 || square == square8
                                || square == square3 || square == square4) && square.Text == " ")
                            {
                                choiceList.Add(square);
                            }
                        }
                        pick = rng.Next(0, choiceList.Count);
                        choiceList[pick].Text = COM;
                        comSquares.Add(choiceList[pick]);
                    }
                    else if (comSquares.Contains(square6))
                    {
                        foreach (Label square in squares)
                        {
                            if ((square == square0 || square == square3 || square == square4
                                || square == square2 || square == square7 || square == square8) && square.Text == " ")
                            {
                                choiceList.Add(square);
                            }
                        }
                        pick = rng.Next(0, choiceList.Count);
                        choiceList[pick].Text = COM;
                        comSquares.Add(choiceList[pick]);
                    }
                    else if (comSquares.Contains(square7))
                    {
                        foreach (Label square in squares)
                        {
                            if ((square == square1 || square == square4
                                || square == square6 || square == square8) && square.Text == " ")
                            {
                                choiceList.Add(square);
                            }
                        }
                        pick = rng.Next(0, choiceList.Count);
                        choiceList[pick].Text = COM;
                        comSquares.Add(choiceList[pick]);
                    }
                    else if (comSquares.Contains(square8))
                    {
                        foreach (Label square in squares)
                        {
                            if ((square == square2 || square == square5 || square == square4
                                || square == square0 || square == square6 || square == square7) && square.Text == " ")
                            {
                                choiceList.Add(square);
                            }
                        }
                        pick = rng.Next(0, choiceList.Count);
                        choiceList[pick].Text = COM;
                        comSquares.Add(choiceList[pick]);
                    }
                    else { return; }
                }
                catch
                {
                    foreach (Label square in squares)
                    {
                        if (square.Text == " ")
                        {
                            choiceList.Add(square);
                        }
                    }
                    pick = rng.Next(0, choiceList.Count);
                    choiceList[pick].Text = COM;
                    comSquares.Add(choiceList[pick]);
                }
            }
        }

        private void ComOwnsNone()
        {
            while (comSquares.Count == 0)
            {
                int pick = rng.Next(0,8);
                if (squares[pick].Text == " ")
                {
                    squares[pick].Text = COM;
                    comSquares.Add(squares[pick]);
                }
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}

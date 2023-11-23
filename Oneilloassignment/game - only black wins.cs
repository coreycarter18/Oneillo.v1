using Oneilloassignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oneilloassignment
{
    public partial class Oneillogame : Form
    {
        private const int boardSize = 8; // set the number of cells on the board, or the number represented in the array
        private const int cellSize = 50; // set the size of the cells in pixels
        private int[,] board = new int[boardSize, boardSize]; // create new 2D array representing the size of the board x the size of the board (8x8)
        private int currentPlayer = 1; // start with player 2 (black)
        private int blackCount = 0; // initialise black counter count
        private int whiteCount = 0;// initialise white counter count
        private SpeechSynthesizer synthesizer;
        


        public Oneillogame()
        {
            InitializeComponent();
            FormComponents();
            InitialiseBoard();
            SetBoard();
            synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // Set the volume (0 to 100)
            synthesizer.Rate = 0;     // Set the speed (-10 to 10)
        }

        private void FormComponents() // set the characteristics of the form
        {
            int width = (boardSize * cellSize) + 20; // declare the form's width
            int height = boardSize * cellSize + cellSize * 4; // declare the form's height

            this.Text = "ONeillo Game V2"; // set the name of the form
            this.BackColor = Color.Pink; // sets the background of the form to pink
            this.Size = new Size(width, height); // create a new size for the form taking in the width and height as parameters

            /*
            TabControl tabControl = new TabControl(); // initialise a new instance of the TabControl class that will manage the tab and its contents
            tabControl.Dock = DockStyle.Top; // setting the tab to the top of the form

            TabPage gameTab = new TabPage("Game"); // creating a tab on the form to handle the new game and save game buttons
            tabControl.TabPages.Add(gameTab);

            Button newGameBtn = new Button();
            newGameBtn.Text = "New Game";
            newGameBtn.Size = new Size(100, 30);
            newGameBtn.Location = new Point((boardSize * cellSize - newGameBtn.Width) / 2, boardSize * cellSize);
            newGameBtn.Click += new EventHandler(newGameBtn_Click);
           
            gameTab.Controls.Add(newGameBtn);
           
            // Add the tab control to the form.
            this.Controls.Add(tabControl);
           

            MenuStrip menuStrip = new MenuStrip();
            this.MainMenuStrip = menuStrip;

            // Create a "Game" menu.
            ToolStripMenuItem gameMenu = new ToolStripMenuItem("Game");
            menuStrip.Items.Add(gameMenu);

            // Create a "New Game" option inside the "Game" menu.
            ToolStripMenuItem newGameOption = new ToolStripMenuItem("New Game");
            newGameOption.Click += new EventHandler(newGameOption_Click);
            gameMenu.DropDownItems.Add(newGameOption);

            */



        }
        private void InitialiseBoard() // set initial board counter placements
        {
            board[3, 3] = board[4, 4] = 1; // set beginning black pieces
            board[3, 4] = board[4, 3] = 2; // set beginning white pieces

            UpdateInterface(); // update the board to display the starting counters
        }

        private void SetBoard() // create button controls representing black, white, and empty counters
        {
            for (int row = 0; row < boardSize; row++) // iterate over each row on the board
            {
                for (int col = 0; col < boardSize; col++) // iterate over each column on the board
                {
                    Button button = new Button(); // create new button control for every cell on the board
                    button.Size = new Size(cellSize, cellSize); // set a standard for each cell's size, so that they are all the same size
                    button.Location = new Point(col * cellSize, row * cellSize + 30); // set the location for the board on the app. the board has to be lowered due to the menu strip being implemented
                    button.Click += new EventHandler(CellClicked); // set an event for when the cell is clicked by the user, this will handle logic etc moves
                    button.Name = "btn_" + row + "_" + col; // set the name of the specific cell for its' unique position on the board

                    if (board[row, col] == 1) // check if the current cell is occupied by a black counter
                    {
                        button.BackColor = Color.Black; // if it is then set set the colour of the button to black to indicate that a black counter is currently in that position
                        button.Enabled = false; // disable the button as we know that it is now not empty
                    }
                    else if (board[row, col] == 2) // check if the current cell is occupied by a white counter
                    {
                        button.BackColor = Color.White; // if it is then set set the colour of the button to white to indicate that a white counter is currently in that position
                        button.Enabled = false; // disable the button as we know that it is now not empty
                    }
                    else
                    {
                        button.BackColor = Color.Pink; // set unoccupied cells to pink
                    }

                    Controls.Add(button); // add the button control to the form manually
                }
            }
        }
        private void CellClicked(object sender, EventArgs e) // event handler for when a cell is clicked
        {
            Button button = (Button)sender; // create an instance of the button that was clicked
            int row = button.Location.Y / cellSize; // calculate which row the button was clicked on
            int col = button.Location.X / cellSize; // calculate which column the button was clicked on

            if (ValidMove(row, col)) // check if the clicked cell allows for a valid move
            {
                MakeMove(row, col); // if it does, make the move
                SetBoard(); // then update the appearance of the board

                if (GameOver()) // if the game is over,
                {
                    GameOverMessage(); // display the message to display that it is
                }
                else
                {
                    SwitchPlayer(); // if the game isn't over, then switch to the other player
                }
            }
        }

        private void UpdateInterface() // updates score after every move
        {
            // Update blackCount and whiteCount variables
            blackCount = 0;
            whiteCount = 0;
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (board[row, col] == 1)
                    {
                        blackCount++;
                    }
                    else if (board[row, col] == 2)
                    {
                        whiteCount++;
                    }
                }
            }


            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    Button button = (Button)Controls.Find("btn_" + row + "_" + col, true).FirstOrDefault();

                    if (button != null)
                    {
                        if (board[row, col] == 1)
                        {
                            button.BackColor = Color.Black;
                            button.Enabled = false;
                        }
                        else if (board[row, col] == 2)
                        {
                            button.BackColor = Color.White;
                            button.Enabled = false;
                        }
                        else
                        {
                            button.BackColor = Color.Pink; // set empty counters to pink to match form background 
                            button.Enabled = ValidMove(row, col); // enable buttons for valid moves
                        }
                    }
                }
            }

            playerCountWhite.Text = whiteCount.ToString();
            playerCountBlack.Text = blackCount.ToString();
        }


        private bool ValidMove(int row, int col) // checks for valid move 
        {
            if (board[row, col] != 0)
            {
                return false; // return false if invalid
            }

            int[] directionRow = { -1, -1, -1, 0, 1, 1, 1, 0 }; // checks for the 8 directions a move can make
            int[] directionCol = { -1, 0, 1, 1, 1, 0, -1, -1 };
            bool isValidMove = false; // move is false, unless it is proven true

            for (int i = 0; i < 8; i++)
            {
                int r = row + directionRow[i];
                int c = col + directionCol[i];
                bool foundOpponent = false;

                if (r < 0 || r >= boardSize || c < 0 || c >= boardSize || board[r, c] != OtherPlayer())
                {
                    continue;
                }

                while (true)
                {
                    r += directionRow[i];
                    c += directionCol[i];

                    if (r < 0 || r >= boardSize || c < 0 || c >= boardSize)
                    {
                        break;
                    }

                    if (board[r, c] == 0)
                    {
                        break;
                    }

                    if (board[r, c] == currentPlayer)
                    {
                        isValidMove = true;
                        break;
                    }
                }
            }

            return isValidMove;
        }

        private void MakeMove(int row, int col)
        {
            int[] directionRow = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] directionCol = { -1, 0, 1, 1, 1, 0, -1, -1 };

            board[row, col] = currentPlayer;

            int flippedCounters = 0; // keeps count

            for (int i = 0; i < 8; i++)
            {
                int r = row + directionRow[i];
                int c = col + directionCol[i];
                bool foundOpponent = false;

                if (r < 0 || r >= boardSize || c < 0 || c >= boardSize || board[r, c] != OtherPlayer())
                {
                    continue;
                }

                while (true)
                {
                    r += directionRow[i];
                    c += directionCol[i];

                    if (r < 0 || r >= boardSize || c < 0 || c >= boardSize)
                    {
                        break;
                    }

                    if (board[r, c] == 0)
                    {
                        break;
                    }

                    if (board[r, c] == currentPlayer)
                    {
                        while (r != row || c != col)
                        {
                            r -= directionRow[i];
                            c -= directionCol[i];
                            board[r, c] = currentPlayer;
                            flippedCounters++; // adds up after moves

                        }
                        break;
                    }
                }
            }



            UpdateInterface();  // to update counters
            if (synthesizer != null && synthesizer.State == SynthesizerState.Ready && speakToolStripMenuItem.Checked) // Add this if condition
            {
                string player = currentPlayer == 1 ? "Black" : "White";
                string move = $"Player {player} made a move at row {row} column {col}";

                synthesizer.SpeakAsync(move);
            }
            UpdateCounterValues(flippedCounters);
            UpdateCounterControls(); // Updates counter value
        }

        private void UpdateCounterValues(int flippedCounters)
        {
            if (currentPlayer == 1)
            {
                blackCount += flippedCounters + 1; // increases black score by new value
                whiteCount -= flippedCounters; // decreases whites score
            }
            else
            {
                whiteCount += flippedCounters + 1; // increases white score by new value
                blackCount -= flippedCounters; // decreases blacks score
            }
        }

        private void UpdateCounterControls()
        {

        } // needed for private void

        private bool GameOver()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (ValidMove(row, col))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        private void GameOverMessage() // public to access black + white counter amounts
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (board[row, col] == 1)
                    {
                        blackCount++;
                    }
                    else if (board[row, col] == 2)
                    {
                        whiteCount++;
                    }
                }
            }


            if (blackCount > whiteCount)
            {
                MessageBox.Show("black wins!"); // black is player 2, they will win if their black count is greater than the white count 

            }
            else if (whiteCount > blackCount)
            {
                MessageBox.Show("white wins!"); // disaplys if white count is greater than black

            }
            else
            {
                MessageBox.Show("Draw!"); // draw if both counters are equal at end of the game
            }
        }

        private void SwitchPlayer()
        {
            currentPlayer = OtherPlayer();
            // statusLabel.Text = "Current player: " + (currentPlayer == 1 ? "Black" : "White");
        }

        private int OtherPlayer()
        {
            return currentPlayer == 1 ? 2 : 1;
        }

        private void InformationPanel_Enter(object sender, EventArgs e)
        {

        }

        private void Oneillogame_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void informationPanelToolStripMenuItem_Click(object sender, EventArgs e)  // remove information panel from view
        {
            if (informationPanelToolStripMenuItem.Checked)
            {
                InformationPanel.Visible = true;
            }
            else
            {
                InformationPanel.Visible = false;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)  // start new game
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) // about page information
        {
            using (Aboutpage aboutpage = new Aboutpage())
            {
                aboutpage.ShowDialog();
            }
        }

        private void speakToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        //  private void playerCountBlack_Click(object sender, EventArgs e)

        private void playerCountBlack_Click(object sender, EventArgs e)
        {

        }

        private void playerCountWhite_Click(object sender, EventArgs e)
        {

        }

        private void speakToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (speakToolStripMenuItem.Checked)  //allows to enable Speak
            {
                speakToolStripMenuItem.Checked = false;
            }
            else
            {
                speakToolStripMenuItem.Checked = true;
            }
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (Aboutpage aboutpage = new Aboutpage())
            {
                aboutpage.ShowDialog();  // will show my About page when clicked 
            }

        }


        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe
{
    public partial class Default : BaseClass
    {
        /// <summary>
        /// 
        /// </summary>
        public int Player
        {
            get
            {
                object o = ViewState["Player"];
                if (o != null)
                {
                    return (int)o;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["Player"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void PlayerMove(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if(Player == 0)
            {
                if (button.Text == "O")
                {
                    button.Text = "O";
                } else
                {
                    button.Text = "X";
                    Player = 1;
                }
                //button.Enabled = false;
                
            } else
            {
                if (button.Text == "X")
                {
                    button.Text = "X";
                }
                else
                {
                    button.Text = "O";
                    Player = 0;
                }
            }

            if(WonGame())
            {
                Game.Enabled = false;
                //Row1Column1.Enabled = false;
                //Row1Column2.Enabled = false;
                //Row1Column3.Enabled = false;
                //Row2Column1.Enabled = false;
                //Row2Column2.Enabled = false;
                //Row2Column3.Enabled = false;
                //Row3Column1.Enabled = false;
                //Row3Column2.Enabled = false;
                //Row3Column3.Enabled = false;
            }

            if(Tie())
            {
                Game.Enabled = false;
                //Row1Column1.Enabled = false;
                //Row1Column2.Enabled = false;
                //Row1Column3.Enabled = false;
                //Row2Column1.Enabled = false;
                //Row2Column2.Enabled = false;
                //Row2Column3.Enabled = false;
                //Row3Column1.Enabled = false;
                //Row3Column2.Enabled = false;
                //Row3Column3.Enabled = false;
            }
            
        }

        protected void ResetGame(object sender, EventArgs e)
        {
            Player = 0;

            Winner.Text = "";

            //Game.GroupingText = "";
            Row1Column1.Text = "";
            Row1Column2.Text = "";
            Row1Column3.Text = "";
            Row2Column1.Text = "";
            Row2Column2.Text = "";
            Row2Column3.Text = "";
            Row3Column1.Text = "";
            Row3Column2.Text = "";
            Row3Column3.Text = "";

            Game.Enabled = true;
            //Row1Column1.Enabled = true;
            //Row1Column2.Enabled = true;
            //Row1Column3.Enabled = true;
            //Row2Column1.Enabled = true;
            //Row2Column2.Enabled = true;
            //Row2Column3.Enabled = true;
            //Row3Column1.Enabled = true;
            //Row3Column2.Enabled = true;
            //Row3Column3.Enabled = true;
        }

        private bool WonGame()
        {
            if (Row1Column1.Text == Row1Column2.Text && Row1Column1.Text == Row1Column3.Text && !string.IsNullOrEmpty(Row1Column1.Text))
            {
                if (Row1Column1.Text == "X")
                {
                    Winner.Text = "PLAYER 1 HAS WONNERED";
                } else
                {
                    Winner.Text = "PLAYER 2 HAS WONNERED";
                }
                return true;
            }
            else if (Row1Column1.Text == Row2Column1.Text && Row1Column1.Text == Row3Column1.Text && !string.IsNullOrEmpty(Row1Column1.Text))
            {
                if (Row1Column1.Text == "X")
                {
                    Winner.Text = "PLAYER 1 HAS WONNERED";
                } else
                {
                    Winner.Text = "PLAYER 2 HAS WONNERED";
                }
                return true;
            }
            else if (Row1Column1.Text == Row2Column2.Text && Row1Column1.Text == Row3Column3.Text && !string.IsNullOrEmpty(Row1Column1.Text))
            {
                if (Row1Column1.Text == "X")
                {
                    Winner.Text = "PLAYER 1 HAS WONNERED";
                }
                else
                {
                    Winner.Text = "PLAYER 2 HAS WONNERED";
                }
                return true;
            }
            else if (Row1Column2.Text == Row2Column2.Text && Row1Column2.Text == Row3Column2.Text && !string.IsNullOrEmpty(Row1Column2.Text)) 
                {
                if (Row1Column2.Text == "X")
                {
                    Winner.Text = "PLAYER 1 HAS WONNERED";
                }
                else
                {
                    Winner.Text = "PLAYER 2 HAS WONNERED";
                }
                return true;
            }
            else if (Row1Column3.Text == Row2Column3.Text && Row1Column3.Text == Row3Column3.Text && !string.IsNullOrEmpty(Row1Column3.Text))
            {
                if (Row1Column3.Text == "X")
                {
                    Winner.Text = "PLAYER 1 HAS WONNERED";
                }
                else
                {
                    Winner.Text = "PLAYER 2 HAS WONNERED";
                }
                return true;
            } else if(Row1Column3.Text == Row2Column2.Text && Row1Column3.Text == Row3Column1.Text && !string.IsNullOrEmpty(Row1Column3.Text))
            {
                if (Row1Column3.Text == "X")
                {
                    Winner.Text = "PLAYER 1 HAS WONNERED";
                }
                else
                {
                    Winner.Text = "PLAYER 2 HAS WONNERED";
                }
                return true;
            }
            else if (Row2Column1.Text == Row2Column2.Text && Row2Column1.Text == Row2Column3.Text && !string.IsNullOrEmpty(Row2Column1.Text))
            {
                if (Row2Column1.Text == "X")
                {
                    Winner.Text = "PLAYER 1 HAS WONNERED";
                }
                else
                {
                    Winner.Text = "PLAYER 2 HAS WONNERED";
                }
                return true;
            }
            else if (Row3Column1.Text == Row3Column2.Text && Row3Column1.Text == Row3Column3.Text && !string.IsNullOrEmpty(Row3Column1.Text))
            {
                if (Row3Column1.Text == "X")
                {
                    Winner.Text = "PLAYER 1 HAS WONNERED";
                }
                else
                {
                    Winner.Text = "PLAYER 2 HAS WONNERED";
                }
                return true;
            }
            return false;
            
        }

        private bool Tie()
        {
            if(!WonGame() && 
                !string.IsNullOrEmpty(Row1Column1.Text) && !string.IsNullOrEmpty(Row1Column2.Text) && !string.IsNullOrEmpty(Row1Column3.Text) &&
                !string.IsNullOrEmpty(Row2Column1.Text) && !string.IsNullOrEmpty(Row2Column1.Text) && !string.IsNullOrEmpty(Row2Column3.Text) &&
                !string.IsNullOrEmpty(Row3Column1.Text) && !string.IsNullOrEmpty(Row3Column1.Text) && !string.IsNullOrEmpty(Row3Column3.Text))
            {
                Winner.Text = "ISSA TIE";
                return true;
            }
            return false;
        }
    }
}

//else if (Row2Column1.Text == Row2Column2.Text && Row2Column1.Text == Row2Column3.Text)
//                {
//                    if (Row2Column1.Text == "X")
//                    {
//                        Winner.Text = "PLAYER 1 HAS WONNERED";
//                    }
//                    else
//                    {
//                        Winner.Text = "PLAYER 2 HAS WONNERED";
//                    }
//                }
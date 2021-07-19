using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickMatch__GUI_
{
    public partial class GUI : Form
    {
        //----------------------------------------------Game Logic Starting Here------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------
        private static Random getRand = new Random();
        static string[] CardClubs = new string[13] { "The Two Of Clubs", "The Three Of Clubs", "The Four Of Clubs", "The Five Of Clubs", "The Six Of Clubs", "The Seven Of Clubs", "The Eight Of Clubs", "The Nine Of Clubs", "The Ten Of Clubs", "The King Of Clubs", "The Queen Of Clubs", "The Jack Of Clubs", "The Ace Of Clubs"};
        static string[] CardHearts = new string[13] { "The Two Of Hearts", "The Three Of Hearts", "The Four Of Hearts", "The Five Of Hearts", "The Six Of Hearts", "The Seven Of Hearts", "The Eight Of Hearts", "The Nine Of Hearts", "The Ten Of Hearts", "The King Of Hearts", "The Queen Of Hearts", "The Jack Of Hearts", "The Ace Of Hearts"};
        static string[] CardSpades = new string[13] { "The Two Of Spades", "The Three Of Spades", "The Four Of Spades", "The Five Of Spades", "The Six Of Spades", "The Seven Of Spades", "The Eight Of Spades", "The Nine Of Spades", "The Ten Of Spades", "The King Of Spades", "The Queen Of Spades", "The Jack Of Spades", "The Ace Of Spades"};
        static string[] CardDiamonds = new string[13] { "The Two Of Diamonds", "The Three Of Diamonds", "The Four Of Diamonds", "The Five Of Diamonds", "The Six Of Diamonds", "The Seven Of Diamonds", "The Eight Of Diamonds", "The Nine Of Diamonds", "The Ten Of Diamonds", "The King Of Diamonds", "The Queen Of Diamonds", "The Jack Of Diamonds", "The Ace Of Diamonds"};
        static string[] CardName = new string[4] { "Diamonds", "Clubs", "Hearts", "Spades" };/*xandy*/
        static string[] CardRank = new string[13] { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "King", "Queen", "Jack","Ace"};
        static string[] p1Cards = new string[6] { " ", " ", " ", " ", " ", " " };
        static string[] p2Cards = new string[6] { " ", " ", " ", " ", " ", " " };
        static string[] AICards = new string[6] { " ", " ", " ", " ", " ", " " };
        static string[] Names = new string[] { "Zira", "Mark", "Lucy", "Carlos", "Andy", "Amaka" };
        static string Player1, Player2, Player3, Player4, AI;
        static string drawn, discarded;
        static string gameMode = "none";
        static int noOfPlayers, cP;
        static int game = 1;
        static int ret = 0;
        static int toBeDiscarded;
        static int cR = 0, cN = 0;
        static int[] toCount = new int[4];
        static int[] temp = new int[4];
        static string[] mA = new string[1];
        static int tC, tC2 = 0;
        static int returnd;
        //for the game pauses
        private System.Windows.Forms.Timer timerT;
        private int counterT = 1;
        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------

        public GUI()
        {
            
            InitializeComponent();
            //-------------inner game logic--------------------
            btnPlayerOrAiTurn.Hide();
            btn_replay.Hide();
            //populateCards();
            //updateCardImages();
            //discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds;
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playerCard4Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        //----------------------------------------------Game Logic Continuing Here------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------
        public void populateCards()
        {
            int num;
            string val;
                num = getRand.Next(0, 12);
                p1Cards[0] = CardClubs[num];
                num = getRand.Next(0, 12);
                p2Cards[0] = CardClubs[num];

                num = getRand.Next(0, 12);
                p1Cards[1] = CardHearts[num];
                num = getRand.Next(0, 12);
                p2Cards[1] = CardHearts[num];

                num = getRand.Next(0, 12);
                p1Cards[2] = CardSpades[num];
                num = getRand.Next(0, 12);
                p2Cards[2] = CardSpades[num];

                num = getRand.Next(0, 12);
                p1Cards[3] = CardDiamonds[num];
                num = getRand.Next(0, 12);
                p2Cards[3] = CardDiamonds[num];

                val = getCard();
                p1Cards[4] = val;
                val = getCard();
                p2Cards[4] = val;
        }
        public void updateCardImages() {
            updateP1CardImages();
            updateP2CardImages();
        }
        public void updateP1CardImages() {

            for (int i = 0; i < p1Cards.Length; i++) {
                //if the card is from the Hearts Deck
                if (p1Cards[i].Contains("Hearts")) {
                    switch (i)
                    {
                        case 0:
                            if (p1Cards[i].Contains("Ace")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p1Cards[i].Contains("Two")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p1Cards[i].Contains("Three")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p1Cards[i].Contains("Four")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p1Cards[i].Contains("Five")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p1Cards[i].Contains("Six")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p1Cards[i].Contains("King")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        case 1:
                            if (p1Cards[i].Contains("Ace")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p1Cards[i].Contains("Two")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p1Cards[i].Contains("Three")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p1Cards[i].Contains("Four")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p1Cards[i].Contains("Five")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p1Cards[i].Contains("Six")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p1Cards[i].Contains("King")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        case 2:
                            if (p1Cards[i].Contains("Ace")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p1Cards[i].Contains("Two")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p1Cards[i].Contains("Three")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p1Cards[i].Contains("Four")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p1Cards[i].Contains("Five")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p1Cards[i].Contains("Six")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p1Cards[i].Contains("King")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        case 3:
                            if (p1Cards[i].Contains("Ace")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p1Cards[i].Contains("Two")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p1Cards[i].Contains("Three")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p1Cards[i].Contains("Four")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p1Cards[i].Contains("Five")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p1Cards[i].Contains("Six")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p1Cards[i].Contains("King")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        case 4:
                            if (p1Cards[i].Contains("Ace")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p1Cards[i].Contains("Two")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p1Cards[i].Contains("Three")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p1Cards[i].Contains("Four")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p1Cards[i].Contains("Five")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p1Cards[i].Contains("Six")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p1Cards[i].Contains("King")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        case 5:
                            if (p1Cards[i].Contains("Ace")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p1Cards[i].Contains("Two")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p1Cards[i].Contains("Three")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p1Cards[i].Contains("Four")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p1Cards[i].Contains("Five")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p1Cards[i].Contains("Six")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p1Cards[i].Contains("King")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        default:
                            break;
                    }
                }//if the card is from the Diamonds Deck
                else if (p1Cards[i].Contains("Diamonds"))
                {
                    switch (i)
                    {
                        case 0:
                            if (p1Cards[i].Contains("Ace")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p1Cards[i].Contains("Two")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p1Cards[i].Contains("Three")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p1Cards[i].Contains("Four")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p1Cards[i].Contains("Five")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p1Cards[i].Contains("Six")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p1Cards[i].Contains("King")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        case 1:
                            if (p1Cards[i].Contains("Ace")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p1Cards[i].Contains("Two")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p1Cards[i].Contains("Three")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p1Cards[i].Contains("Four")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p1Cards[i].Contains("Five")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p1Cards[i].Contains("Six")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p1Cards[i].Contains("King")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        case 2:
                            if (p1Cards[i].Contains("Ace")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p1Cards[i].Contains("Two")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p1Cards[i].Contains("Three")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p1Cards[i].Contains("Four")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p1Cards[i].Contains("Five")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p1Cards[i].Contains("Six")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p1Cards[i].Contains("King")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        case 3:
                            if (p1Cards[i].Contains("Ace")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p1Cards[i].Contains("Two")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p1Cards[i].Contains("Three")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p1Cards[i].Contains("Four")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p1Cards[i].Contains("Five")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p1Cards[i].Contains("Six")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p1Cards[i].Contains("King")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        case 4:
                            if (p1Cards[i].Contains("Ace")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p1Cards[i].Contains("Two")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p1Cards[i].Contains("Three")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p1Cards[i].Contains("Four")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p1Cards[i].Contains("Five")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p1Cards[i].Contains("Six")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p1Cards[i].Contains("King")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        case 5:
                            if (p1Cards[i].Contains("Ace")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p1Cards[i].Contains("Two")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p1Cards[i].Contains("Three")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p1Cards[i].Contains("Four")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p1Cards[i].Contains("Five")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p1Cards[i].Contains("Six")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p1Cards[i].Contains("King")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        default:
                            break;
                    }
                }//if the card is from the Clubs Deck
                else if (p1Cards[i].Contains("Clubs"))
                {
                    switch (i)
                    {
                        case 0:
                            if (p1Cards[i].Contains("Ace")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p1Cards[i].Contains("Two")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p1Cards[i].Contains("Three")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p1Cards[i].Contains("Four")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p1Cards[i].Contains("Five")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p1Cards[i].Contains("Six")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p1Cards[i].Contains("King")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        case 1:
                            if (p1Cards[i].Contains("Ace")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p1Cards[i].Contains("Two")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p1Cards[i].Contains("Three")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p1Cards[i].Contains("Four")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p1Cards[i].Contains("Five")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p1Cards[i].Contains("Six")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p1Cards[i].Contains("King")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        case 2:
                            if (p1Cards[i].Contains("Ace")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p1Cards[i].Contains("Two")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p1Cards[i].Contains("Three")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p1Cards[i].Contains("Four")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p1Cards[i].Contains("Five")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p1Cards[i].Contains("Six")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p1Cards[i].Contains("King")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        case 3:
                            if (p1Cards[i].Contains("Ace")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p1Cards[i].Contains("Two")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p1Cards[i].Contains("Three")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p1Cards[i].Contains("Four")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p1Cards[i].Contains("Five")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p1Cards[i].Contains("Six")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p1Cards[i].Contains("King")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        case 4:
                            if (p1Cards[i].Contains("Ace")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p1Cards[i].Contains("Two")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p1Cards[i].Contains("Three")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p1Cards[i].Contains("Four")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p1Cards[i].Contains("Five")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p1Cards[i].Contains("Six")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p1Cards[i].Contains("King")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        case 5:
                            if (p1Cards[i].Contains("Ace")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p1Cards[i].Contains("Two")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p1Cards[i].Contains("Three")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p1Cards[i].Contains("Four")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p1Cards[i].Contains("Five")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p1Cards[i].Contains("Six")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p1Cards[i].Contains("King")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        default:
                            break;
                    }
                }//if the card is from the Spades Deck
                else if (p1Cards[i].Contains("Spades"))
                {
                    switch (i)
                    {
                        case 0:
                            if (p1Cards[i].Contains("Ace")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p1Cards[i].Contains("Two")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p1Cards[i].Contains("Three")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p1Cards[i].Contains("Four")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades;}
                            else if (p1Cards[i].Contains("Five")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades;}
                            else if (p1Cards[i].Contains("Six")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades;}
                            else if (p1Cards[i].Contains("Seven")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades;}
                            else if (p1Cards[i].Contains("Eight")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades;}
                            else if (p1Cards[i].Contains("Nine")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades;}
                            else if (p1Cards[i].Contains("Ten")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades;}
                            else if (p1Cards[i].Contains("Jack")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades;}
                            else if (p1Cards[i].Contains("Queen")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades;}
                            else if (p1Cards[i].Contains("King")) { aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        case 1:
                            if (p1Cards[i].Contains("Ace")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p1Cards[i].Contains("Two")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p1Cards[i].Contains("Three")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p1Cards[i].Contains("Four")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p1Cards[i].Contains("Five")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p1Cards[i].Contains("Six")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p1Cards[i].Contains("King")) { aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        case 2:
                            if (p1Cards[i].Contains("Ace")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p1Cards[i].Contains("Two")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p1Cards[i].Contains("Three")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p1Cards[i].Contains("Four")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p1Cards[i].Contains("Five")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p1Cards[i].Contains("Six")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p1Cards[i].Contains("King")) { aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        case 3:
                            if (p1Cards[i].Contains("Ace")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p1Cards[i].Contains("Two")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p1Cards[i].Contains("Three")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p1Cards[i].Contains("Four")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p1Cards[i].Contains("Five")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p1Cards[i].Contains("Six")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p1Cards[i].Contains("King")) { aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        case 4:
                            if (p1Cards[i].Contains("Ace")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p1Cards[i].Contains("Two")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p1Cards[i].Contains("Three")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p1Cards[i].Contains("Four")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p1Cards[i].Contains("Five")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p1Cards[i].Contains("Six")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p1Cards[i].Contains("King")) { aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        case 5:
                            if (p1Cards[i].Contains("Ace")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p1Cards[i].Contains("Two")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p1Cards[i].Contains("Three")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p1Cards[i].Contains("Four")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p1Cards[i].Contains("Five")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p1Cards[i].Contains("Six")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p1Cards[i].Contains("Seven")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p1Cards[i].Contains("Eight")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p1Cards[i].Contains("Nine")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p1Cards[i].Contains("Ten")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p1Cards[i].Contains("Jack")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p1Cards[i].Contains("Queen")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p1Cards[i].Contains("King")) { aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        default:
                            break;
                    }
                }//if there is no card present
                else if (p1Cards[i] == " ")
                {
                    switch (i) { 
                        case 0:
                            aiCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        case 1:
                            aiCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        case 2:
                            aiCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        case 3:
                            aiCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        case 4:
                            aiCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        case 5:
                            aiCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void updateP2CardImages()
        {

            for (int i = 0; i < p2Cards.Length; i++)
            {
                //if the card is from the Hearts Deck
                if (p2Cards[i].Contains("Hearts"))
                {
                    switch (i)
                    {
                        case 0:
                            if (p2Cards[i].Contains("Ace")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p2Cards[i].Contains("Two")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p2Cards[i].Contains("Three")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p2Cards[i].Contains("Four")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p2Cards[i].Contains("Five")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p2Cards[i].Contains("Six")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p2Cards[i].Contains("King")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        case 1:
                            if (p2Cards[i].Contains("Ace")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p2Cards[i].Contains("Two")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p2Cards[i].Contains("Three")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p2Cards[i].Contains("Four")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p2Cards[i].Contains("Five")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p2Cards[i].Contains("Six")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p2Cards[i].Contains("King")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        case 2:
                            if (p2Cards[i].Contains("Ace")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p2Cards[i].Contains("Two")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p2Cards[i].Contains("Three")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p2Cards[i].Contains("Four")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p2Cards[i].Contains("Five")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p2Cards[i].Contains("Six")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p2Cards[i].Contains("King")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        case 3:
                            if (p2Cards[i].Contains("Ace")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p2Cards[i].Contains("Two")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p2Cards[i].Contains("Three")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p2Cards[i].Contains("Four")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p2Cards[i].Contains("Five")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p2Cards[i].Contains("Six")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p2Cards[i].Contains("King")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        case 4:
                            if (p2Cards[i].Contains("Ace")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p2Cards[i].Contains("Two")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p2Cards[i].Contains("Three")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p2Cards[i].Contains("Four")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p2Cards[i].Contains("Five")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p2Cards[i].Contains("Six")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p2Cards[i].Contains("King")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        case 5:
                            if (p2Cards[i].Contains("Ace")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                            else if (p2Cards[i].Contains("Two")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                            else if (p2Cards[i].Contains("Three")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                            else if (p2Cards[i].Contains("Four")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                            else if (p2Cards[i].Contains("Five")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                            else if (p2Cards[i].Contains("Six")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                            else if (p2Cards[i].Contains("King")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
                            break;
                        default:
                            break;
                    }
                }//if the card is from the Diamonds Deck
                else if (p2Cards[i].Contains("Diamonds"))
                {
                    switch (i)
                    {
                        case 0:
                            if (p2Cards[i].Contains("Ace")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p2Cards[i].Contains("Two")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p2Cards[i].Contains("Three")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p2Cards[i].Contains("Four")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p2Cards[i].Contains("Five")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p2Cards[i].Contains("Six")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p2Cards[i].Contains("King")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        case 1:
                            if (p2Cards[i].Contains("Ace")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p2Cards[i].Contains("Two")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p2Cards[i].Contains("Three")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p2Cards[i].Contains("Four")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p2Cards[i].Contains("Five")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p2Cards[i].Contains("Six")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p2Cards[i].Contains("King")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        case 2:
                            if (p2Cards[i].Contains("Ace")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p2Cards[i].Contains("Two")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p2Cards[i].Contains("Three")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p2Cards[i].Contains("Four")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p2Cards[i].Contains("Five")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p2Cards[i].Contains("Six")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p2Cards[i].Contains("King")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        case 3:
                            if (p2Cards[i].Contains("Ace")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p2Cards[i].Contains("Two")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p2Cards[i].Contains("Three")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p2Cards[i].Contains("Four")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p2Cards[i].Contains("Five")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p2Cards[i].Contains("Six")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p2Cards[i].Contains("King")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        case 4:
                            if (p2Cards[i].Contains("Ace")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p2Cards[i].Contains("Two")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p2Cards[i].Contains("Three")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p2Cards[i].Contains("Four")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p2Cards[i].Contains("Five")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p2Cards[i].Contains("Six")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p2Cards[i].Contains("King")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        case 5:
                            if (p2Cards[i].Contains("Ace")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                            else if (p2Cards[i].Contains("Two")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                            else if (p2Cards[i].Contains("Three")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                            else if (p2Cards[i].Contains("Four")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                            else if (p2Cards[i].Contains("Five")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                            else if (p2Cards[i].Contains("Six")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                            else if (p2Cards[i].Contains("King")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
                            break;
                        default:
                            break;
                    }
                }//if the card is from the Clubs Deck
                else if (p2Cards[i].Contains("Clubs"))
                {
                    switch (i)
                    {
                        case 0:
                            if (p2Cards[i].Contains("Ace")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p2Cards[i].Contains("Two")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p2Cards[i].Contains("Three")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p2Cards[i].Contains("Four")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p2Cards[i].Contains("Five")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p2Cards[i].Contains("Six")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p2Cards[i].Contains("King")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        case 1:
                            if (p2Cards[i].Contains("Ace")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p2Cards[i].Contains("Two")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p2Cards[i].Contains("Three")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p2Cards[i].Contains("Four")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p2Cards[i].Contains("Five")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p2Cards[i].Contains("Six")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p2Cards[i].Contains("King")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        case 2:
                            if (p2Cards[i].Contains("Ace")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p2Cards[i].Contains("Two")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p2Cards[i].Contains("Three")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p2Cards[i].Contains("Four")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p2Cards[i].Contains("Five")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p2Cards[i].Contains("Six")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p2Cards[i].Contains("King")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        case 3:
                            if (p2Cards[i].Contains("Ace")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p2Cards[i].Contains("Two")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p2Cards[i].Contains("Three")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p2Cards[i].Contains("Four")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p2Cards[i].Contains("Five")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p2Cards[i].Contains("Six")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p2Cards[i].Contains("King")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        case 4:
                            if (p2Cards[i].Contains("Ace")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p2Cards[i].Contains("Two")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p2Cards[i].Contains("Three")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p2Cards[i].Contains("Four")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p2Cards[i].Contains("Five")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p2Cards[i].Contains("Six")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p2Cards[i].Contains("King")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        case 5:
                            if (p2Cards[i].Contains("Ace")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                            else if (p2Cards[i].Contains("Two")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                            else if (p2Cards[i].Contains("Three")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                            else if (p2Cards[i].Contains("Four")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                            else if (p2Cards[i].Contains("Five")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                            else if (p2Cards[i].Contains("Six")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                            else if (p2Cards[i].Contains("King")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
                            break;
                        default:
                            break;
                    }
                }//if the card is from the Spades Deck
                else if (p2Cards[i].Contains("Spades"))
                {
                    switch (i)
                    {
                        case 0:
                            if (p2Cards[i].Contains("Ace")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p2Cards[i].Contains("Two")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p2Cards[i].Contains("Three")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p2Cards[i].Contains("Four")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p2Cards[i].Contains("Five")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p2Cards[i].Contains("Six")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p2Cards[i].Contains("King")) { playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        case 1:
                            if (p2Cards[i].Contains("Ace")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p2Cards[i].Contains("Two")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p2Cards[i].Contains("Three")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p2Cards[i].Contains("Four")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p2Cards[i].Contains("Five")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p2Cards[i].Contains("Six")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p2Cards[i].Contains("King")) { playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        case 2:
                            if (p2Cards[i].Contains("Ace")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p2Cards[i].Contains("Two")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p2Cards[i].Contains("Three")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p2Cards[i].Contains("Four")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p2Cards[i].Contains("Five")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p2Cards[i].Contains("Six")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p2Cards[i].Contains("King")) { playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        case 3:
                            if (p2Cards[i].Contains("Ace")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p2Cards[i].Contains("Two")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p2Cards[i].Contains("Three")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p2Cards[i].Contains("Four")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p2Cards[i].Contains("Five")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p2Cards[i].Contains("Six")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p2Cards[i].Contains("King")) { playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        case 4:
                            if (p2Cards[i].Contains("Ace")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p2Cards[i].Contains("Two")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p2Cards[i].Contains("Three")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p2Cards[i].Contains("Four")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p2Cards[i].Contains("Five")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p2Cards[i].Contains("Six")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p2Cards[i].Contains("King")) { playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        case 5:
                            if (p2Cards[i].Contains("Ace")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                            else if (p2Cards[i].Contains("Two")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                            else if (p2Cards[i].Contains("Three")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                            else if (p2Cards[i].Contains("Four")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                            else if (p2Cards[i].Contains("Five")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                            else if (p2Cards[i].Contains("Six")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                            else if (p2Cards[i].Contains("Seven")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                            else if (p2Cards[i].Contains("Eight")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                            else if (p2Cards[i].Contains("Nine")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                            else if (p2Cards[i].Contains("Ten")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                            else if (p2Cards[i].Contains("Jack")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                            else if (p2Cards[i].Contains("Queen")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                            else if (p2Cards[i].Contains("King")) { playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
                            break;
                        default:
                            break;
                    }
                }//if there is no card present
                else if (p2Cards[i] == " ")
                {
                    switch (i)
                    {
                        case 0:
                            playerCard1Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        case 1:
                            playerCard2Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        case 2:
                            playerCard3Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        case 3:
                            playerCard4Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        case 4:
                            playerCard5Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        case 5:
                            playerCard6Panel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void updateDiscardedCardImage() {
            if (discarded.Contains("Hearts")) {
                if (discarded.Contains("Ace")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Hearts; }
                else if (discarded.Contains("Two")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Hearts; }
                else if (discarded.Contains("Three")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Hearts; }
                else if (discarded.Contains("Four")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Hearts; }
                else if (discarded.Contains("Five")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Hearts; }
                else if (discarded.Contains("Six")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Hearts; }
                else if (discarded.Contains("Seven")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Hearts; }
                else if (discarded.Contains("Eight")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Hearts; }
                else if (discarded.Contains("Nine")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Hearts; }
                else if (discarded.Contains("Ten")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Hearts; }
                else if (discarded.Contains("Jack")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Hearts; }
                else if (discarded.Contains("Queen")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Hearts; }
                else if (discarded.Contains("King")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K____Hearts; }
            }
            else if (discarded.Contains("Spades"))
            {
                if (discarded.Contains("Ace")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Spades; }
                else if (discarded.Contains("Two")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Spades; }
                else if (discarded.Contains("Three")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Spades; }
                else if (discarded.Contains("Four")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Spades; }
                else if (discarded.Contains("Five")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Spades; }
                else if (discarded.Contains("Six")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Spades; }
                else if (discarded.Contains("Seven")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Spades; }
                else if (discarded.Contains("Eight")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Spades; }
                else if (discarded.Contains("Nine")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Spades; }
                else if (discarded.Contains("Ten")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Spades; }
                else if (discarded.Contains("Jack")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Spades; }
                else if (discarded.Contains("Queen")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Spades; }
                else if (discarded.Contains("King")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Spades; }
            }
            else if (discarded.Contains("Clubs"))
            {
                if (discarded.Contains("Ace")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Clubs; }
                else if (discarded.Contains("Two")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Clubs; }
                else if (discarded.Contains("Three")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Clubs; }
                else if (discarded.Contains("Four")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Clubs; }
                else if (discarded.Contains("Five")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Clubs; }
                else if (discarded.Contains("Six")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Clubs; }
                else if (discarded.Contains("Seven")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Clubs; }
                else if (discarded.Contains("Eight")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Clubs; }
                else if (discarded.Contains("Nine")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Clubs; }
                else if (discarded.Contains("Ten")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Clubs; }
                else if (discarded.Contains("Jack")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Clubs; }
                else if (discarded.Contains("Queen")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Clubs; }
                else if (discarded.Contains("King")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Clubs; }
            }
            else if (discarded.Contains("Diamonds"))
            {
                if (discarded.Contains("Ace")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.A___Diamonds; }
                else if (discarded.Contains("Two")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._2___Diamonds; }
                else if (discarded.Contains("Three")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._3___Diamonds; }
                else if (discarded.Contains("Four")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._4___Diamonds; }
                else if (discarded.Contains("Five")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._5___Diamonds; }
                else if (discarded.Contains("Six")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._6___Diamonds; }
                else if (discarded.Contains("Seven")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._7___Diamonds; }
                else if (discarded.Contains("Eight")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._8___Diamonds; }
                else if (discarded.Contains("Nine")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._9___Diamonds; }
                else if (discarded.Contains("Ten")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources._10___Diamonds; }
                else if (discarded.Contains("Jack")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.J___Diamonds; }
                else if (discarded.Contains("Queen")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Q___Diamonds; }
                else if (discarded.Contains("King")) { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.K___Diamonds; }
            }
            else if (discarded == "") { discardedCardPanel.BackgroundImage = QuickMatch__GUI_.Properties.Resources.Card; }
        }

        public string getCard()
        {
            int name = getRand.Next(0, 3);
            int rank = getRand.Next(0, 12);
            string card = "The " + CardRank[rank] + " of " + CardName[name] + "";
            return card;
        }

        //Player game section starts here
        public void drawCard() {
            if (gameMode != "ended")
            {
                pickOrDiscardCardStatus.Text = "Pick A Card";
                infoTextBox.Text = "To draw a card, You can either select the discarded card above\nOr you can Click on the Card Deck below to draw a random card";
                gameMode = "pick";
                btnPlayerOrAiTurn.Text = "Your Turn";
            }
        }
        public void afterCardDraw() {
            gameMode = "discard";
            pickOrDiscardCardStatus.Text = "Discard A Card";
            infoTextBox.Text = "Double click on a selected card in your card pile, to discard the card from your pile";
        }

        public void onCardDiscard(int role)
        {
            discarded = p2Cards[role];//setting the discarded card into a temporary variable
            p2Cards[role] = " ";//removing the discarded card from the player deck
            updateP2CardImages(); //updating the card image
            updateDiscardedCardImage();
            //checking card
            gameMode = "AI"; //maing sure a user cant click on a card while its the AI's Turn
            btnPlayerOrAiTurn.Text = "AI's Turn";
            cP = 22; checkCard(); game = 2;
            addGamePause();
            //aiGameStart(); //time for next player to start
        }
        //adding game pause
        private void addGamePause() {
            timerT = new System.Windows.Forms.Timer();
            timerT.Tick += new EventHandler(addGamePauseCount);
            timerT.Interval = 1000;
            timerT.Start();
        }
        private void addGamePauseCount(object sender, EventArgs e)
        {
            counterT--;
            if (counterT == 0)
                timerT.Stop(); aiGameStart();
        }
        //AI game section starts here
        public void aiGameStart() {
            if (gameMode == "AI")
            {
                btnPlayerOrAiTurn.Text = "AI's Turn";

                aiDrawCard();
                for (int i = 0; i < p1Cards.Length; i++)
                {
                    if (p1Cards[i] == " ") { p1Cards[i] = drawn; }
                }
                Console.WriteLine("Ai card drawn is: " + drawn);
                updateP1CardImages(); //updating ai card images after card draw
                //Thread.Sleep(3000);
                //------------discarding AI card
                int x = aiDiscardCard();
                discarded = p1Cards[returnd];
                p1Cards[returnd] = " ";
                Console.WriteLine("Ai card discarded is: " + discarded);
                updateDiscardedCardImage(); //updating discarded card image
                updateP1CardImages(); //updating ai card images after discarding card
                Console.WriteLine("\n\nCard discarded is {0}.\n", discarded);
                cP = 21; checkCard(); //checking to see if the AI has won
                drawCard();//starting the player round
            }
        }

        public void aiDrawCard()
        {
            int cH = 0, cC = 0, cD = 0, cS = 0;
            string[] disc = new string[1]; disc[0] = discarded;
            //Console.Write("Press [T] to take the card discarded or [D] to draw a card from the pile :  ");
            Console.WriteLine("Players discarded card: "+discarded);
            for (int i = 0; i <= 5; i++)
            {
                if (p1Cards[i].Contains("Hearts")) { cH++; }
                else if (p1Cards[i].Contains("Clubs")) { cC++; }
                else if (p1Cards[i].Contains("Diamonds")) { cD++; }
                else if (p1Cards[i].Contains("Spades")) { cS++; }
                else { }
            }
            if (cH >= 2 && (cC >= 2 || cD >= 2 || cS >= 2))
            {
                if (cH >= 2 && cC >= 2)
                {
                    if (cH > cC)
                    {
                        if (disc[0].Contains("Hearts")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cC > cH)
                    {
                        if (disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Hearts") || disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
                else if (cH >= 2 && cD >= 2)
                {
                    if (cH > cD)
                    {
                        if (disc[0].Contains("Hearts")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cD > cH)
                    {
                        if (disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Hearts") || disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
                else if (cH >= 2 && cS >= 2)
                {
                    if (cH > cS)
                    {
                        if (disc[0].Contains("Hearts")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cS > cH)
                    {
                        if (disc[0].Contains("Spades")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Hearts") || disc[0].Contains("Spades")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
            }
            else if (cC >= 2 && (cH >= 2 || cD >= 2 || cS >= 2))
            {
                if (cC >= 2 && cH >= 2)
                {
                    if (cH > cC)
                    {
                        if (disc[0].Contains("Hearts")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cC > cH)
                    {
                        if (disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Hearts") || disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
                else if (cC >= 2 && cD >= 2)
                {
                    if (cC > cD)
                    {
                        if (disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cD > cC)
                    {
                        if (disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Diamonds") || disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
                else if (cC >= 2 && cS >= 2)
                {
                    if (cC > cS)
                    {
                        if (disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cS > cC)
                    {
                        if (disc[0].Contains("Spades")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Spades") || disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
            }
            else if (cD >= 2 && (cC >= 2 || cH >= 2 || cS >= 2))
            {
                if (cD >= 2 && cH >= 2)
                {
                    if (cH > cD)
                    {
                        if (disc[0].Contains("Hearts")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cD > cH)
                    {
                        if (disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Hearts") || disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
                else if (cD >= 2 && cC >= 2)
                {
                    if (cC > cD)
                    {
                        if (disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cD > cC)
                    {
                        if (disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Diamonds") || disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
                else if (cD >= 2 && cS >= 2)
                {
                    if (cD > cS)
                    {
                        if (disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cS > cD)
                    {
                        if (disc[0].Contains("Spades")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Spades") || disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
            }
            else if (cS >= 2 && (cC >= 2 || cD >= 2 || cH >= 2))
            {
                if (cS >= 2 && cH >= 2)
                {
                    if (cH > cS)
                    {
                        if (disc[0].Contains("Hearts")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cS > cH)
                    {
                        if (disc[0].Contains("Spades")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Hearts") || disc[0].Contains("Spades")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
                else if (cS >= 2 && cC >= 2)
                {
                    if (cC > cS)
                    {
                        if (disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cS > cC)
                    {
                        if (disc[0].Contains("Spades")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Spades") || disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
                else if (cD >= 2 && cS >= 2)
                {
                    if (cD > cS)
                    {
                        if (disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else if (cS > cD)
                    {
                        if (disc[0].Contains("Spades")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                    else
                    {
                        if (disc[0].Contains("Spades") || disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                        else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
                    }
                }
            }
            else if (cH >= 2)
            {
                if (disc[0].Contains("Hearts")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
            }
            else if (cC >= 2)
            {
                if (disc[0].Contains("Clubs")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
            }
            else if (cD >= 2)
            {
                if (disc[0].Contains("Diamonds")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
            }
            else if (cS >= 2)
            {
                if (disc[0].Contains("Spades")) { Thread.Sleep(2000); Console.Write("T"); drawn = discarded; Thread.Sleep(1000); }
                else { Thread.Sleep(2000); Console.Write("D"); drawn = getCard(); Thread.Sleep(1000); }
            }
            else { }
        }
        public int aiDiscardCard()
        {
            returnd = 0;
            int cH = 0, cC = 0, cD = 0, cS = 0;
            mA[0] = "";
            string strl = "";
            //int returnd = 0;
            //Console.Write("\nEnter the card number to be discarded <1-6> : ");
            for (int i = 0; i <= 5; i++)
            {
                if (p1Cards[i].Contains("Hearts")) { cH++; }
                else if (p1Cards[i].Contains("Clubs")) { cC++; }
                else if (p1Cards[i].Contains("Diamonds")) { cD++; }
                else if (p1Cards[i].Contains("Spades")) { cS++; }
                else { }
            }
            //the error here is sometimes a card isnt included in the deck and it registers as zero which is the min -- find a way to exclude zero values
            toCount[0] = cH; toCount[1] = cC; toCount[2] = cD; toCount[3] = cS;

            //experimental block of code to exclude zero values
            //Console.WriteLine("To Count Length: "+toCount.Length);
            for (int i = 0; i < toCount.Length; i++)
            {
                if (toCount[i] == 0) { toCount[i] = 10; }
            }
            //experimental block of code ends here

            tC = toCount.Min();
            for (int i = 0; i <= 3; i++)
            {
                if (toCount[i] == tC)
                {
                    if (i == 0) { strl = "Hearts"; }
                    else if (i == 1) { strl = "Clubs"; }
                    else if (i == 2) { strl = "Diamonds"; }
                    else if (i == 3) { strl = "Spades"; }
                    //mA[tC2] = i.ToString(); tC2 = tC2 + 1; 
                    mA[0] = mA[0] + strl;
                }
            }
            //Console.WriteLine(mA[0]);
            int count = 0;
            if (mA[0].Contains("Hearts")) { count = count + 1; }
            if (mA[0].Contains("Clubs")) { count = count + 1; }
            if (mA[0].Contains("Diamonds")) { count = count + 1; }
            if (mA[0].Contains("Spades")) { count = count + 1; }
            //Console.WriteLine("--------" + mA[0] + "-------");
            if (count == 1)
            {
                if (mA[0].Contains("Hearts"))
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        if (p1Cards[i].Contains("Hearts")) { returnd = i; break; }
                    }
                }
                else if (mA[0].Contains("Clubs"))
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        if (p1Cards[i].Contains("Clubs")) { returnd = i; break; }
                    }
                }
                else if (mA[0].Contains("Diamonds"))
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        if (p1Cards[i].Contains("Diamonds")) { returnd = i; break; }
                    }
                }
                else if (mA[0].Contains("Spades"))
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        if (p1Cards[i].Contains("Spades")) { returnd = i; break; }
                    }
                }
            }
            else if (count == 2)
            {
                if (mA[0].Contains("Hearts") && mA[0].Contains("Clubs"))
                {
                    int q = getRand.Next(1, 2);
                    if (q == 1)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Hearts")) { returnd = i; break; }
                        }
                    }
                    else if (q == 2)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Clubs")) { returnd = i; break; }
                        }
                    }
                }
                else if (mA[0].Contains("Hearts") && mA[0].Contains("Diamonds"))
                {
                    int q = getRand.Next(1, 2);
                    if (q == 1)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Hearts")) { returnd = i; break; }
                        }
                    }
                    else if (q == 2)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Diamonds")) { returnd = i; break; }
                        }
                    }
                }
                else if (mA[0].Contains("Hearts") && mA[0].Contains("Spades"))
                {
                    int q = getRand.Next(1, 2);
                    if (q == 1)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Hearts")) { returnd = i; break; }
                        }
                    }
                    else if (q == 2)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Spade")) { returnd = i; break; }
                        }
                    }
                }
                else if (mA[0].Contains("Clubs") && mA[0].Contains("Diamonds"))
                {
                    int q = getRand.Next(1, 2);
                    if (q == 1)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Diamonds")) { returnd = i; break; }
                        }
                    }
                    else if (q == 2)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Clubs")) { returnd = i; break; }
                        }
                    }
                }
                else if (mA[0].Contains("Clubs") && mA[0].Contains("Spades"))
                {
                    int q = getRand.Next(1, 2);
                    if (q == 1)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Spades")) { returnd = i; break; }
                        }
                    }
                    else if (q == 2)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Clubs")) { returnd = i; break; }
                        }
                    }
                }
                else if (mA[0].Contains("Diamonds") && mA[0].Contains("Spades"))
                {
                    int q = getRand.Next(1, 2);
                    if (q == 1)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Diamonds")) { returnd = i; break; }
                        }
                    }
                    else if (q == 2)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Spades")) { returnd = i; break; }
                        }
                    }
                }
            }//     Hearts  Clubs   Diamonds    Spades
            //      0       1       2           3`
            else if (count == 3)
            {
                if (mA[0].Contains("Hearts") && mA[0].Contains("Clubs") && mA[0].Contains("Diamonds"))
                {
                    int q = getRand.Next(1, 3);
                    if (q == 1)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Hearts")) { returnd = i; break; }
                        }
                    }
                    else if (q == 2)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Clubs")) { returnd = i; break; }
                        }
                    }
                    else if (q == 3)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Diamonds")) { returnd = i; break; }
                        }
                    }
                }
                else if (mA[0].Contains("Hearts") && mA[0].Contains("Clubs") && mA[0].Contains("Spades"))
                {
                    int q = getRand.Next(1, 3);
                    if (q == 1)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Hearts")) { returnd = i; break; }
                        }
                    }
                    else if (q == 2)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Clubs")) { returnd = i; break; }
                        }
                    }
                    else if (q == 3)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Spades")) { returnd = i; break; }
                        }
                    }
                }
                else if (mA[0].Contains("Hearts") && mA[0].Contains("Diamonds") && mA[0].Contains("Spades"))
                {
                    int q = getRand.Next(1, 3);
                    if (q == 1)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Hearts")) { returnd = i; break; }
                        }
                    }
                    else if (q == 2)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Diamonds")) { returnd = i; break; }
                        }
                    }
                    else if (q == 3)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Spades")) { returnd = i; break; }
                        }
                    }
                }
                else if (mA[0].Contains("Clubs") && mA[0].Contains("Diamonds") && mA[0].Contains("Spades"))
                {
                    int q = getRand.Next(1, 3);
                    if (q == 1)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Clubs")) { returnd = i; break; }
                        }
                    }
                    else if (q == 2)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Diamonds")) { returnd = i; break; }
                        }
                    }
                    else if (q == 3)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (p1Cards[i].Contains("Spades")) { returnd = i; break; }
                        }
                    }
                }
            }
            else if (count == 4) { Console.WriteLine("Null"); }
            Thread.Sleep(2000);
            Console.WriteLine(returnd);
            return returnd;
        }

        public void checkCard()
        {
            int cardCountH = 0, cardCountS = 0, cardCountC = 0, cardCountD = 0;
            if (cP == 21)
            {
                if (p1Cards[0].Contains("Hearts")) { cardCountH++; }
                if (p1Cards[1].Contains("Hearts")) { cardCountH++; }
                if (p1Cards[2].Contains("Hearts")) { cardCountH++; }
                if (p1Cards[3].Contains("Hearts")) { cardCountH++; }
                if (p1Cards[4].Contains("Hearts")) { cardCountH++; }
                if (p1Cards[5].Contains("Hearts")) { cardCountH++; }

                if (p1Cards[0].Contains("Spades")) { cardCountS++; }
                if (p1Cards[1].Contains("Spades")) { cardCountS++; }
                if (p1Cards[2].Contains("Spades")) { cardCountS++; }
                if (p1Cards[3].Contains("Spades")) { cardCountS++; }
                if (p1Cards[4].Contains("Spades")) { cardCountS++; }
                if (p1Cards[5].Contains("Spades")) { cardCountS++; }

                if (p1Cards[0].Contains("Clubs")) { cardCountC++; }
                if (p1Cards[1].Contains("Clubs")) { cardCountC++; }
                if (p1Cards[2].Contains("Clubs")) { cardCountC++; }
                if (p1Cards[3].Contains("Clubs")) { cardCountC++; }
                if (p1Cards[4].Contains("Clubs")) { cardCountC++; }
                if (p1Cards[5].Contains("Clubs")) { cardCountC++; }

                if (p1Cards[0].Contains("Diamonds")) { cardCountD++; }
                if (p1Cards[1].Contains("Diamonds")) { cardCountD++; }
                if (p1Cards[2].Contains("Diamonds")) { cardCountD++; }
                if (p1Cards[3].Contains("Diamonds")) { cardCountD++; }
                if (p1Cards[4].Contains("Diamonds")) { cardCountD++; }
                if (p1Cards[5].Contains("Diamonds")) { cardCountD++; }

                if (cardCountH == 5) { Console.WriteLine("You Lost!! Player 1: [{0}] won!!", AI); Exit(); btnPlayerOrAiTurn.Text = "You Lost!!"; }
                else if (cardCountS == 5) { Console.WriteLine("You Lost!! Player 1: [{0}] won!!", AI); Exit(); btnPlayerOrAiTurn.Text = "You Lost!!"; }
                else if (cardCountC == 5) { Console.WriteLine("You Lost!! Player 1: [{0}] won!!", AI); Exit(); btnPlayerOrAiTurn.Text = "You Lost!!"; }
                else if (cardCountD == 5) { Console.WriteLine("You Lost!! Player 1: [{0}] won!!", AI); Exit(); btnPlayerOrAiTurn.Text = "You Lost!!"; }
            }
            else if (cP == 22)
            {
                if (p2Cards[0].Contains("Hearts")) { cardCountH++; }
                if (p2Cards[1].Contains("Hearts")) { cardCountH++; }
                if (p2Cards[2].Contains("Hearts")) { cardCountH++; }
                if (p2Cards[3].Contains("Hearts")) { cardCountH++; }
                if (p2Cards[4].Contains("Hearts")) { cardCountH++; }
                if (p2Cards[5].Contains("Hearts")) { cardCountH++; }

                if (p2Cards[0].Contains("Spades")) { cardCountS++; }
                if (p2Cards[1].Contains("Spades")) { cardCountS++; }
                if (p2Cards[2].Contains("Spades")) { cardCountS++; }
                if (p2Cards[3].Contains("Spades")) { cardCountS++; }
                if (p2Cards[4].Contains("Spades")) { cardCountS++; }
                if (p2Cards[5].Contains("Spades")) { cardCountS++; }

                if (p2Cards[0].Contains("Clubs")) { cardCountC++; }
                if (p2Cards[1].Contains("Clubs")) { cardCountC++; }
                if (p2Cards[2].Contains("Clubs")) { cardCountC++; }
                if (p2Cards[3].Contains("Clubs")) { cardCountC++; }
                if (p2Cards[4].Contains("Clubs")) { cardCountC++; }
                if (p2Cards[5].Contains("Clubs")) { cardCountC++; }

                if (p2Cards[0].Contains("Diamonds")) { cardCountD++; }
                if (p2Cards[1].Contains("Diamonds")) { cardCountD++; }
                if (p2Cards[2].Contains("Diamonds")) { cardCountD++; }
                if (p2Cards[3].Contains("Diamonds")) { cardCountD++; }
                if (p2Cards[4].Contains("Diamonds")) { cardCountD++; }
                if (p2Cards[5].Contains("Diamonds")) { cardCountD++; }

                if (cardCountH == 5) { Console.WriteLine("Player 2: [{0}] won!!"); Exit(); btnPlayerOrAiTurn.Text = "You Won!!"; }
                else if (cardCountS == 5) { Console.WriteLine("Player 2: [{0}] won!!"); Exit(); btnPlayerOrAiTurn.Text = "You Won!!"; }
                else if (cardCountC == 5) { Console.WriteLine("Player 2: [{0}] won!!"); Exit(); btnPlayerOrAiTurn.Text = "You Won!!"; }
                else if (cardCountD == 5) { Console.WriteLine("Player 2: [{0}] won!!"); Exit(); btnPlayerOrAiTurn.Text = "You Won!!"; }
            }

        }
        public void Exit()
        {
            btnPlayerOrAiTurn.ForeColor = Color.OrangeRed;
            gameMode = "ended";
            //btn_replay.Show();
        }
        //------------------------------------------------Game Logic Ending Here----------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------

        private void loadDeckBtn_Click(object sender, EventArgs e)
        {
            int ftp = getRand.Next(0, 5); 
            AI = Names[ftp];
            populateCards(); updateCardImages(); loadDeckBtn.Hide();
            btnPlayerOrAiTurn.Show(); btnPlayerOrAiTurn.Text = "Your Turn";
            infoTextBox.Text = "\nClick on the Card Deck below to draw a random card"; gameMode = "pick";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void discardedCardPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //-------------------------Method to be called once the Card Deck is clicked------------------------------
        private void onCardDeckClicked(object sender, EventArgs e)
        {
            if (gameMode == "pick")
            {
                drawn = getCard(); //getting a random card out of the deck
                for (int i = 0; i < p2Cards.Length; i++)
                {
                    if (p2Cards[i] == " ") { p2Cards[i] = drawn; }
                }
                updateP2CardImages(); //updating the card image
                afterCardDraw();
                //note: the Ai is Player 1 and the User is Player 2
            }
        }

        //-------------------------Method to be called once the Discarded Card Deck is clicked------------------------------
        private void onDiscardCardClick(object sender, EventArgs e)
        {
            if (gameMode == "pick" && game != 1)
            {
                drawn = discarded;
                for (int i = 0; i < p2Cards.Length; i++)
                {
                    if (p2Cards[i] == " ") { p2Cards[i] = drawn; }
                }
                updateP2CardImages(); //updating the card image
                discarded = ""; updateDiscardedCardImage();
                afterCardDraw();
            }
        }

        //-------------------------Methods to be called once any card from the player Card Deck is clicked------------------------------
        private void onPlayerCard1Click(object sender, EventArgs e) { if (gameMode == "discard") { onCardDiscard(0); } }
        private void onPlayerCard2Click(object sender, EventArgs e) { if (gameMode == "discard") { onCardDiscard(1); } }
        private void onPlayerCard3Click(object sender, EventArgs e) { if (gameMode == "discard") { onCardDiscard(2); } }
        private void onPlayerCard4Click(object sender, EventArgs e) { if (gameMode == "discard") { onCardDiscard(3); } }
        private void onPlayerCard5Click(object sender, EventArgs e) { if (gameMode == "discard") { onCardDiscard(4); } }
        private void onPlayerCard6Click(object sender, EventArgs e) { if (gameMode == "discard") { onCardDiscard(5); } }

        private void btn_replay_Click(object sender, EventArgs e)
        {
            populateCards();
            clearCards();
            loadDeckBtn.Show();
            btnPlayerOrAiTurn.Hide();
            discarded = "";
        }

        public void clearCards() {
            for (int i = 0; i < p1Cards.Length; i++) {
                p1Cards[i] = " ";
            }
            for (int i = 0; i < p2Cards.Length; i++)
            {
                p2Cards[i] = " ";
            }
            updateCardImages();
        }

        private void cardDeckPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        


        
    }
}

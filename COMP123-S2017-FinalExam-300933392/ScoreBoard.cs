﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name - Gurmanpreet Kaur
 * Student ID - 300933392 
 * Date - 17 aug , 2017
 * Description - This is my Scoreboard class 
 * Version 0.1 - Created the ScoreBoard class and added properties and methods to it */
namespace COMP123_S2017_FinalExam_300933392
{
   public class ScoreBoard
    {
        //private instance variables-----------------------
        private TextBox _finalScoreTextBox;

        private int _score;

        private TextBox _scoreTextBox;

        private int _time;

        private TextBox _timeTextBox;

    


        //public properties
        


        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }

        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = Convert.ToInt16(this.ScoreTextBox.Text);
                this._score = Convert.ToInt16(this.FinalScoreTextBox.Text);
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = Convert.ToInt16(this.TimeTextBox);

            }
        }

        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        //Constructor--------------------------------
        /// <summary>
        /// This is the main constructor of the ScoreBoard class 
        /// It takes three parameters - scoreTextBox (TextBox), timeTextBox (TextBox) , finalScore(TextBox)
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextbox"></param>
        public ScoreBoard(TextBox scoreTextBox,TextBox timeTextBox,TextBox finalScoreTextbox)
        {

        }
        public void UpdateTime()
        {
            this.Time = ((Convert.ToInt32(this.TimeTextBox.Text)) - 1);
            this.TimeTextBox.Text = Convert.ToString(this.Time);
        }

    }
}

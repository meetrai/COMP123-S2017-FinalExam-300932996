using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Manmeet Singh
 * Date:8/17/2017
 * StudentID:300932996
 * Description:The ScoreBoard class
 * Version:0.1
 */
namespace COMP123_S2017_FinalExam_300932996
{
  public  class ScoreBoard
    {
        private int  _score;
        private int _time;
        private TextBox _fianlScoreTextBox;
        private TextBox _scoreTextBox;
        private TextBox _timeTextBox;


        public TextBox FinalScoreTextbox
        {
            get {
                return this._fianlScoreTextBox;
            }
            set {
               this._fianlScoreTextBox = value;
            }
        }
        public TextBox Score
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
        
    }


    }


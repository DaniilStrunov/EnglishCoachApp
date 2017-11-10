using System;
using System.Linq;
using System.Windows.Forms;
using EnglishCoach;
using System.Threading;
using System.Collections.Generic;

namespace EnglishCoachApp
{
    public partial class Form1 : Form
    {
        string Path;
        User user;
        TheWord CurrentWord;
        bool CurrenAnswer;
        public Form1()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                user = EnglishCouch.LogInUser(UserData.Text, Path);
            }
            catch
            {
                MessageBox.Show("Пользователя с таким именем нет");
            }
            UserData.Text.DefaultIfEmpty();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            user = EnglishCouch.AddNewUser(UserData.Text, Path);
            UserData.Text.DefaultIfEmpty();
        }

        private void True_Click(object sender, EventArgs e)
        {
            CurrenAnswer = EnglishCouch.CheckTrueTheAnswer(CurrentWord, user);
            Answer.Text = CurrenAnswer.ToString();
        }

        private void False_Click(object sender, EventArgs e)
        {
            CurrenAnswer = EnglishCouch.CheckFalseTheAnswer(CurrentWord, user);
            Answer.Text = CurrenAnswer.ToString();
        }

        private void UserData_TextChanged(object sender, EventArgs e)
        {
        }

        private void EnglishWord_Click(object sender, EventArgs e)
        { 
        }

        private void RussianWord_Click(object sender, EventArgs e)
        {
        }

        private void Answer_Click(object sender, EventArgs e)
        {
        }

        private void GetWord_Click(object sender, EventArgs e)
        {
            CurrentWord = EnglishCouch.GetAWordForTraining(user);
            if(CurrentWord!=null)
            {
                EnglishWord.Text = CurrentWord.English;
                RussianWord.Text = CurrentWord.Russian;
            }
            else
            {
                MessageBox.Show("Все слова выучены");
                Application.Exit();
            }
            
        }

        private void ShowAllWords_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            List<TheWord> list = new List<TheWord>(EnglishCouch.ShowAllWords(user));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            foreach (TheWord w in list)
            {

                System.Windows.Forms.ListViewItem item = new ListViewItem(new string[] { w.Russian, w.English, w.NumberOfCorrectAnswers.ToString() }, 0);
                this.listView1.Items.Add(item);
            }
            this.listView1.View = System.Windows.Forms.View.Details;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void ShowLearnedWords_Click(object sender, EventArgs e)
        {
            this.listView2.Items.Clear();
            List<TheWord> list = new List<TheWord>(EnglishCouch.ShowLearnedWords(user));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            foreach (TheWord w in list)
            {

                System.Windows.Forms.ListViewItem item = new ListViewItem(new string[] { w.Russian, w.English, w.NumberOfCorrectAnswers.ToString() }, 0);
                this.listView2.Items.Add(item);
            }
            this.listView2.View = System.Windows.Forms.View.Details;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddPath_Click(object sender, EventArgs e)
        {
            Path = PathText.Text+@"\";
        }

        private void PathText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

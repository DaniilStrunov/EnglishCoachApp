namespace EnglishCoachApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogIn = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.UserData = new System.Windows.Forms.TextBox();
            this.EnglishWord = new System.Windows.Forms.Label();
            this.RussianWord = new System.Windows.Forms.Label();
            this.True = new System.Windows.Forms.Button();
            this.False = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.GetWord = new System.Windows.Forms.Button();
            this.ShowAllWords = new System.Windows.Forms.Button();
            this.ShowLearnedWords = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Russian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.English = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathText = new System.Windows.Forms.TextBox();
            this.AddPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(396, 12);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(219, 92);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "LogIn";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(396, 123);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(219, 92);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // UserData
            // 
            this.UserData.Location = new System.Drawing.Point(56, 31);
            this.UserData.Multiline = true;
            this.UserData.Name = "UserData";
            this.UserData.Size = new System.Drawing.Size(209, 85);
            this.UserData.TabIndex = 2;
            this.UserData.TextChanged += new System.EventHandler(this.UserData_TextChanged);
            // 
            // EnglishWord
            // 
            this.EnglishWord.AutoSize = true;
            this.EnglishWord.Location = new System.Drawing.Point(325, 258);
            this.EnglishWord.Name = "EnglishWord";
            this.EnglishWord.Size = new System.Drawing.Size(88, 17);
            this.EnglishWord.TabIndex = 3;
            this.EnglishWord.Text = "EnglishWord";
            this.EnglishWord.Click += new System.EventHandler(this.EnglishWord_Click);
            // 
            // RussianWord
            // 
            this.RussianWord.AutoSize = true;
            this.RussianWord.Location = new System.Drawing.Point(325, 300);
            this.RussianWord.Name = "RussianWord";
            this.RussianWord.Size = new System.Drawing.Size(93, 17);
            this.RussianWord.TabIndex = 4;
            this.RussianWord.Text = "RussianWord";
            this.RussianWord.Click += new System.EventHandler(this.RussianWord_Click);
            // 
            // True
            // 
            this.True.Location = new System.Drawing.Point(294, 341);
            this.True.Name = "True";
            this.True.Size = new System.Drawing.Size(165, 61);
            this.True.TabIndex = 5;
            this.True.Text = "True";
            this.True.UseVisualStyleBackColor = true;
            this.True.Click += new System.EventHandler(this.True_Click);
            // 
            // False
            // 
            this.False.Location = new System.Drawing.Point(294, 433);
            this.False.Name = "False";
            this.False.Size = new System.Drawing.Size(165, 61);
            this.False.TabIndex = 6;
            this.False.Text = "False";
            this.False.UseVisualStyleBackColor = true;
            this.False.Click += new System.EventHandler(this.False_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(561, 404);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(54, 17);
            this.Answer.TabIndex = 7;
            this.Answer.Text = "Answer";
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // GetWord
            // 
            this.GetWord.Location = new System.Drawing.Point(56, 379);
            this.GetWord.Name = "GetWord";
            this.GetWord.Size = new System.Drawing.Size(156, 67);
            this.GetWord.TabIndex = 8;
            this.GetWord.Text = "Get a word";
            this.GetWord.UseVisualStyleBackColor = true;
            this.GetWord.Click += new System.EventHandler(this.GetWord_Click);
            // 
            // ShowAllWords
            // 
            this.ShowAllWords.Location = new System.Drawing.Point(107, 527);
            this.ShowAllWords.Name = "ShowAllWords";
            this.ShowAllWords.Size = new System.Drawing.Size(169, 49);
            this.ShowAllWords.TabIndex = 9;
            this.ShowAllWords.Text = "Show All Words";
            this.ShowAllWords.UseVisualStyleBackColor = true;
            this.ShowAllWords.Click += new System.EventHandler(this.ShowAllWords_Click);
            // 
            // ShowLearnedWords
            // 
            this.ShowLearnedWords.Location = new System.Drawing.Point(462, 527);
            this.ShowLearnedWords.Name = "ShowLearnedWords";
            this.ShowLearnedWords.Size = new System.Drawing.Size(169, 49);
            this.ShowLearnedWords.TabIndex = 10;
            this.ShowLearnedWords.Text = "Show Learned Words";
            this.ShowLearnedWords.UseVisualStyleBackColor = true;
            this.ShowLearnedWords.Click += new System.EventHandler(this.ShowLearnedWords_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Russian,
            this.English,
            this.Number});
            this.listView1.Location = new System.Drawing.Point(87, 582);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(219, 195);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.Location = new System.Drawing.Point(431, 582);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(226, 195);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(753, 123);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(196, 22);
            this.PathText.TabIndex = 13;
            this.PathText.TextChanged += new System.EventHandler(this.PathText_TextChanged);
            // 
            // AddPath
            // 
            this.AddPath.Location = new System.Drawing.Point(753, 31);
            this.AddPath.Name = "AddPath";
            this.AddPath.Size = new System.Drawing.Size(196, 40);
            this.AddPath.TabIndex = 14;
            this.AddPath.Text = "Add The Path Ti The File";
            this.AddPath.UseVisualStyleBackColor = true;
            this.AddPath.Click += new System.EventHandler(this.AddPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 775);
            this.Controls.Add(this.AddPath);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ShowLearnedWords);
            this.Controls.Add(this.ShowAllWords);
            this.Controls.Add(this.GetWord);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.False);
            this.Controls.Add(this.True);
            this.Controls.Add(this.RussianWord);
            this.Controls.Add(this.EnglishWord);
            this.Controls.Add(this.UserData);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.LogIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox UserData;
        private System.Windows.Forms.Label EnglishWord;
        private System.Windows.Forms.Label RussianWord;
        private System.Windows.Forms.Button True;
        private System.Windows.Forms.Button False;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button GetWord;
        private System.Windows.Forms.Button ShowAllWords;
        private System.Windows.Forms.Button ShowLearnedWords;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Russian;
        private System.Windows.Forms.ColumnHeader English;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button AddPath;
    }
}


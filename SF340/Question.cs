using System;
using System.Data.SQLite;
using System.Linq;

namespace QuizApp
{
    public class Question
    {
        private SQLiteConnection con;
        private Random rand = new Random();
        private string DB_PATH = @"data source=.\vocab\Vocab.db";

        private int countVocab;
        private string question;
        private string answer;
        private string meaning;
        private string[] choices;
        private int[] idWords;


        public Question()
        {
            this.choices = new string[4];
            this.idWords = new int[4];

            openConnection();
            setCountVocab();
            randomIDWords();
            setQuestion();
            setChoices();
            closeConnection();
        }

        private void setCountVocab()
        {
            //Execute
            string query = "SELECT count(*) FROM synonyms";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            //Set count of vocab
            this.countVocab = Convert.ToInt32(cmd.ExecuteScalar());

            //Destroy
            cmd.Dispose();
        }

        private void setQuestion()
        {
            //Execute
            string query = "SELECT word1,word2,meaning FROM synonyms WHERE id=" + idWords[0];
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            //Set question and answer
            dr.Read();
            this.question = dr.GetString(0);
            this.answer = dr.GetString(1);
            this.meaning = dr.GetString(2);

            choices[0] = this.answer;

            //Destroy
            cmd.Dispose();
            dr.Close();
        }

        private void setChoices()
        {
            //Execute
            string query = "SELECT word2 FROM synonyms WHERE id IN ('" +
                idWords[1] + "', '" +
                idWords[2] + "', '" +
                idWords[3] + "')";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            //Set multi choices
            for (int i = 1; i <= 3; i++)
            {
                dr.Read();
                choices[i] = dr.GetString(0);
            }

            this.choices = this.choices.OrderBy(x => this.rand.Next()).ToArray();

            //Destroy
            cmd.Dispose();
            dr.Close();
        }

        private void randomIDWords()
        {
            int i = 0;
            int r;

            while (i < 4)
            {
                r = this.rand.Next(1, this.countVocab + 1); //Random integers that range from minValue to maxValue - 1

                if (!this.idWords.Contains(r))
                {
                    this.idWords[i] = r;
                    i++;
                }
            }
        }

        private void openConnection()
        {
            if (con == null)
            {
                con = new SQLiteConnection(DB_PATH);
                con.Open();
            }
        }

        private void closeConnection()
        {
            con.Close();
        }

        public string getQuestion()
        {
            return this.question;
        }

        public string[] getChoices()
        {
            return this.choices;
        }

        public string getAnswer()
        {
            return this.answer;
        }
        public string getMeaning()
        {
            return this.meaning;
        }
    }
}

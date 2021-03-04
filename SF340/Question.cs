using System;
using System.Data.SQLite;
using System.Linq;

namespace SF340
{
    public class Question
    {
        private static SQLiteConnection con;
        private static int TABLE_ROW_COUNT = 30;
        private static string DB_PATH = @"data source=D:\SF340\SF340\SF340\Vocab.db";

        private int[] randomNumbers;
        private string question, answer;
        private string[] choice;

        public Question()
        {
            checkConnection();
            choice = new string[4];
            this.randomNumbers = get4RandomNumbers(TABLE_ROW_COUNT);
            selectQuestion(randomNumbers[0]);
            selectChoice();
        }

        private void selectQuestion(int i)
        {
            string query = "SELECT word1,word2 FROM synonyms WHERE id=" + i;
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            question = rdr.GetString(0);
            answer = rdr.GetString(1);
            choice[0] = answer;
        }

        private void selectChoice()
        {
            string query = "SELECT word2 FROM synonyms WHERE id IN ('" +
                randomNumbers[1] + "', '" +
                randomNumbers[2] + "', '" +
                randomNumbers[3] + "')";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            for (int i = 1; i < 4; i++)
            {
                rdr.Read();
                choice[i] = rdr.GetString(0);
            }

            Random rnd = new Random();
            choice = choice.OrderBy(x => rnd.Next()).ToArray();
        }

        private int[] get4RandomNumbers(int max)
        {
            Random rand = new Random();
            int[] nums = new int[4];
            nums[0] = rand.Next(1, max);
            int r;
            for (int i = 1; i < 4; i++)
            {
                do
                {
                    r = rand.Next(1, max);
                }
                while (nums.Contains(r));
                nums[i] = r;
            }
            return nums;
        }

        private void checkConnection()
        {
            if (con == null)
            {
                con = new SQLiteConnection(DB_PATH);
                con.Open();
            }
        }

        public string getQuestion()
        {
            return question;
        }

        public string[] getChoice()
        {
            return choice;
        }

        public string getAnswer()
        {
            return answer;
        }

    }
}

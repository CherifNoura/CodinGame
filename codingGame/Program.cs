using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //-------------------------------------------------------Parantheses Brackets----------------------------------------------------------------------------------
            //Dictionary<int, string> sentences = new Dictionary<int, string>
            //{
            //    {0,"[()]"}, {1,"(()[])"}, {2, "([)]"}, { 3,"(("}, {4, "[(()])"}, {5, "([(([[(([]))]]))])"}, {6, "[] (()()[[]])()[] ([])"},
            //    {7,"([((([(([]))])))))"}, {8,"[](()()[[]])[] [[([])"}
            //};
            //string s = "";
            //var allowedChars = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' } };

            //foreach (var str in sentences)
            //{
            //    bool wellFormated = true;
            //    var stack = new Stack<char>();
            //    foreach (var chr in str.Value)
            //    {
            //        if (allowedChars.ContainsKey(chr))
            //        {
            //            stack.Push(chr);
            //        }
            //        else if (allowedChars.ContainsValue(chr))
            //        {
            //            wellFormated = stack.Any();
            //            if (wellFormated)
            //            {
            //                var startingChar = stack.Pop();
            //                wellFormated = allowedChars.Contains(new KeyValuePair<char, char>(startingChar, chr));
            //            }
            //            if (!wellFormated)
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    s += (wellFormated && !stack.Any()).ToString() + '\n';
            //}
            //MessageBox.Show(s);


            //---------------------------------------------------DANSE--------------------------------------------------------
            //int positionToshow = 0;
            //int n = 2147483647;
            //int stepscurrMiusOne = -2;
            //int stepscurrMiusTwo = 1;
            //int position = -1;
            //if (n == 0) positionToshow = 0;
            //if (n == 1) positionToshow = 1;
            //if (n == 2) positionToshow = -1;

            //for (var i = int.Parse(eSkype.Text); i >= 3 ; i--)
            //{
            //    int steps = stepscurrMiusOne - stepscurrMiusTwo;
            //    position = position + steps;
            //    stepscurrMiusTwo = stepscurrMiusOne;
            //    stepscurrMiusOne = steps;
            //    positionToshow = position;
            //}
            //MessageBox.Show(positionToshow.ToString());

            //-------------------------------------------------LEVENSTEIN DISTANCE-------------------------------------------------------------
            //var b = "ISLEM";
            //var a = "IS";
            //var distance = 0;
            //if (string.IsNullOrEmpty(a))
            //{
            //    if (!string.IsNullOrEmpty(b))
            //    {
            //        distance = b.Length;
            //    }
            //    distance = 0;
            //}

            //if (string.IsNullOrEmpty(b))
            //{
            //    if (!string.IsNullOrEmpty(a))
            //    {
            //        distance = a.Length;
            //    }
            //    distance = 0;
            //}

            //Int32 cost;
            //Int32[,] d = new int[a.Length + 1, b.Length + 1];
            //Int32 min1;
            //Int32 min2;
            //Int32 min3;

            //for (Int32 i = 0; i <= d.GetUpperBound(0); i += 1)
            //{
            //    var x = d.GetUpperBound(0);
            //    d[i, 0] = i;
            //}

            //for (Int32 i = 0; i <= d.GetUpperBound(1); i += 1)
            //{
            //    var x = d.GetUpperBound(1);
            //    d[0, i] = i;
            //}
            //bind(d, dataGridView1);
            //this.Update();
            //for (Int32 i = 1; i <= d.GetUpperBound(0); i += 1)
            //{
            //    for (Int32 j = 1; j <= d.GetUpperBound(1); j += 1)
            //    {
            //        cost = Convert.ToInt32(a[i - 1] != b[j - 1]);
            //        this.Update();
            //        min1 = d[i - 1, j] + 1;
            //        min2 = d[i, j - 1] + 1;
            //        min3 = d[i - 1, j - 1] + cost;
            //        d[i, j] = Math.Min(Math.Min(min1, min2), min3);
            //        bind(d, dataGridView1);
            //        this.Update();
            //    }
            //}

            //distance = d[d.GetUpperBound(0), d.GetUpperBound(1)];
            //// Step 7
            //MessageBox.Show(distance.ToString());
            //-----------------------------------------------Combinaison-------------------------------------------- -
            //int n = 1000;
            //int count = 0;
            //for (int i = n; i > 1; i--)
            //{
            //    count = count + i - 1;
            //}
            Int32 i = levenshtein("sam","samantha");
        }

        public static Int32 levenshtein(String s, String t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2 sam
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }
            //samantha
            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }
            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }
}

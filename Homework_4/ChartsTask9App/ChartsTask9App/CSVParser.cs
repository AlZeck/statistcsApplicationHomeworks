using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace ChartsTask9App
{
    public class CSVParser
    {
        public List<HeaderContainer> Header { get; private set; }
        public List<List<Object>> Elements { get; private set; }

        private bool CSVHasHeader;
        private CSVReaderGui Gui;
        private string FilePath;

        public CSVParser(string filePath, CSVReaderGui gui, bool hasHeader)
        {
            Gui = gui;
            CSVHasHeader = hasHeader;
            FilePath = filePath;

            Elements = new List<List<object>>();
            Header = new List<HeaderContainer>();
            // read first line
            readFile();

            if (CSVHasHeader) //read names 
            {
                List<object> headers = Elements[0];
                Elements.RemoveAt(0);
                foreach (string h in headers)
                {
                    Header.Add(new HeaderContainer(h, typeof(string)));
                }
            }
            else // create names by counter Column 1
            {
                int lenght = Elements[0].Count;
                for (int i = 0; i < lenght; i++)
                {
                    Header.Add(new HeaderContainer(String.Format("Column_{0}", i + 1), typeof(string)));
                }
            }

            GuessTypes();

            foreach (HeaderContainer h in Header)
            {
                gui.writeLine(h.ToString());
            }
        }

        private void readFile()
        {
            using (TextFieldParser parser = new TextFieldParser(FilePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(Gui.Delimiter);
                int r = 0;
                while (!parser.EndOfData)
                {
                    Elements.Add(new List<object>());
                    int c = 0;
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        Elements[r].Add(new String(field.ToCharArray()));
                        c++;
                    }
                    r++;
                }
            }

            int first_count = Elements[0].Count;
            for (int i = 1; i < Elements.Count; i++)
            {
                if (Elements[i].Count != first_count)
                {
                    throw new Exception(String.Format("number of elements miss match line {0}", i + 1));
                }
            }
        }

        private Type ParseTypeOfString(string str, Type currentGuess, int i)
        {

            int intValue;
            double doubleValue;
            bool boolValue;
            DateTime dateValue;

            // Place checks higher in if-else statement to give higher priority to type.
            if (bool.TryParse(str, out boolValue) && currentGuess == typeof(bool))
                return typeof(bool);
            else if (int.TryParse(str, out intValue) && (currentGuess == typeof(int) || i == 0))
                return typeof(int);
            else if (double.TryParse(str, out doubleValue) && (currentGuess == typeof(int) || currentGuess == typeof(double) || i == 0))
                return typeof(double);
            else if (DateTime.TryParse(str, out dateValue) && (currentGuess == typeof(DateTime) || i == 0))
                return typeof(DateTime);
            else return typeof(string);
        }

        private void GuessTypes()
        {
            for (int j = 0; j < Elements[0].Count; j++)
            {
                Type currentGuess = typeof(bool);
                // only check the first 5 elements if they exist 
                for (int i = 0; (i < Elements.Count && i < 5); i++)
                {
                    currentGuess = ParseTypeOfString(Elements[i][j].ToString(), currentGuess, i);
                }
                Header[j].Type = currentGuess;
            }
        }

        public void ParseElements()
        {
            int j = 0, i = 0;
            try
            {
                for (; i < Elements.Count; i++)
                {
                    for (j = 0; j < Elements[0].Count; j++)
                    {
                        // convert the Value to the correct 
                        if(Elements[i][j].Equals(""))
                        {
                            Elements[i][j] = "0";
                        }
                        Elements[i][j] = TypeDescriptor.GetConverter(Header[j].Type).ConvertFrom(Elements[i][j].ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show(String.Format("Cant parse line {0},{1}", i, j));
                throw new Exception();
            }
        }
    }
}

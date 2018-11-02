using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace InfiniteCampusAutoInput
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        
        static Dictionary<char, byte> Conversions = new Dictionary<char, byte>()
        {
            {'0', 0x30},
            {'1', 0x31},
            {'2', 0x32},
            {'3', 0x33},
            {'4', 0x34},
            {'5', 0x35},
            {'6', 0x36},
            {'7', 0x37},
            {'8', 0x38},
            {'9', 0x39},
            {'.', 0xBE},
        };

        static uint KEY_DOWN_EVENT = 0x0001; //Key down flag
        static uint KEY_UP_EVENT = 0x0002; //Key up flag
        static byte DOWN_KEY = 0x28;
        static byte UP_KEY = 0x26;
        static byte RIGHT_KEY = 0x27;

        static void Main(string[] args)
        {
            //G = 6 = assignments
            //H = 7 = formative assessments
            //F = 5 = projects/assessments
            //Will have to update the above when I add final project
            List<List<string>> result = SplitListInto2DStructure(LoadCsvFile(AppDomain.CurrentDomain.BaseDirectory + GetNameOfFileFromUser() + ".csv"));
            List<string> assignmentsGrades = ConvertColumnToFloatValue(result, 6);
            List<string> formativeAssessmentGrades = ConvertColumnToFloatValue(result, 7);
            List<string> projectAndAssessmentGrades = ConvertColumnToFloatValue(result, 5);
            Console.WriteLine("You have three seconds...");
            Thread.Sleep(3000);
            CustomizedLogic(assignmentsGrades, formativeAssessmentGrades, projectAndAssessmentGrades);
        }

        static void CustomizedLogic(List<string> assignment, List<string> formative, List<string> project)
        {
            InputColumn(assignment);
            PressKey(RIGHT_KEY);
            for(int i = 0; i < 20; i++)
            {
                PressKey(UP_KEY);
            }
            PressKey(RIGHT_KEY);
            InputColumn(formative);
            PressKey(RIGHT_KEY);
            for (int i = 0; i < 20; i++)
            {
                PressKey(UP_KEY);
            }
            InputColumn(project);
        }

        static List<string> ConvertColumnToFloatValue(List<List<string>> input, int columnNum)
        {
            List<string> result = new List<string>();
            foreach (List<string> person in input)
            {
                float r = 0;
                if (float.TryParse(person[columnNum], out r))
                {
                    result.Add(person[columnNum]);
                }
            }
            return result;
        }

        static string GetNameOfFileFromUser()
        {
            Console.Write("What is the name of the CSV file you want to load: ");
            return Console.ReadLine();
        }

        static List<string> LoadCsvFile(string filePath)
        {
            List<string> result = new List<string>();
            using (StreamReader sr = new StreamReader(File.OpenRead(filePath)))
            {
                while (!sr.EndOfStream)
                {
                    result.Add(sr.ReadLine());
                }
            }
            return result;
        }

        static List<List<string>> SplitListInto2DStructure(List<string> input)
        {
            List<List<string>> result = new List<List<string>>();
            foreach (string s in input)
            {
                result.Add(new List<string>());
                foreach (string split in s.Split(','))
                {
                    result[result.Count - 1].Add(split);
                }
            }
            return result;
        }

        static void InputColumn(List<string> vals)
        {
            foreach (string s in vals)
            {
                InputStringValueToInfiniteCampus(s);
                PressKey(DOWN_KEY);
            }
        }

        static void InputStringValueToInfiniteCampus(string floatVal)
        {
            foreach (char c in floatVal)
            {
                PressKey(Conversions[c]);
            }
        }

        static void PressKey(byte key)
        {
            keybd_event(key, 0, KEY_DOWN_EVENT, 0);
            Thread.Sleep(5);
            keybd_event(key, 0, KEY_UP_EVENT, 0);
            Thread.Sleep(5);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analisador_Loteria.Lotofacil
{
    public static class Lotofacil
    {
        //public static int MyProperty { get; set; }
        public static string[] allValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };
        public static int length { get; } = allValues.Length;

        public static string QuantityAnalysis(string[] allLines)
        {
            var quantityList = new List<Tuple<string, int>>();

            foreach (var line in allLines)
            {
                var balls = line.Split(new[] { ' ', '\t' }, StringSplitOptions.None);

                foreach (var ball in balls)
                {
                    if (!string.IsNullOrEmpty(ball))
                    {
                        //Quantity
                        var oldQuantity = quantityList.Where(x => x.Item1.Equals(ball)).FirstOrDefault();
                        if (oldQuantity != null)
                        {
                            var newLine = new Tuple<string, int>(oldQuantity.Item1, oldQuantity.Item2 + 1);
                            quantityList.Remove(oldQuantity);
                            quantityList.Add(newLine);
                        }
                        else
                        {
                            quantityList.Add(new Tuple<string, int>(ball, 1));
                        }
                    }
                }
            }

            string summary = $"***** Quantidade *****{Environment.NewLine}";

            foreach (var line in quantityList.OrderByDescending(x => x.Item1).ToList())
            {
                summary = $"{summary}Número {line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string LineAnalysis(string[] allLines)
        {
            var lineList = new List<Tuple<string, int>>();

            foreach (var line in allLines)
            {
                var balls = line.Split(new[] { ' ', '\t' }, StringSplitOptions.None);

                int lineOne = 0;
                int lineTwo = 0;
                int lineThree = 0;
                int lineFour = 0;
                int lineFive = 0;

                foreach (var ball in balls)
                {
                    if (!string.IsNullOrEmpty(ball))
                    {
                        switch (ball)
                        {
                            case "01":
                            case "02":
                            case "03":
                            case "04":
                            case "05":
                                lineOne++;
                                break;

                            case "06":
                            case "07":
                            case "08":
                            case "09":
                            case "10":
                                lineTwo++;
                                break;

                            case "11":
                            case "12":
                            case "13":
                            case "14":
                            case "15":
                                lineThree++;
                                break;

                            case "16":
                            case "17":
                            case "18":
                            case "19":
                            case "20":
                                lineFour++;
                                break;

                            case "21":
                            case "22":
                            case "23":
                            case "24":
                            case "25":
                                lineFive++;
                                break;
                        }
                    }
                }

                //Linhas
                string lineDescription = $"{lineOne}{lineTwo}{lineThree}{lineFour}{lineFive}";
                var oldLine = lineList.Where(x => x.Item1.Equals(lineDescription)).FirstOrDefault();
                if (oldLine != null)
                {
                    var newLine = new Tuple<string, int>(oldLine.Item1, oldLine.Item2 + 1);
                    lineList.Remove(oldLine);
                    lineList.Add(newLine);
                }
                else
                {
                    lineList.Add(new Tuple<string, int>(lineDescription, 1));
                }
            }

            string summary = $"***** LINHAS *****{Environment.NewLine}";

            foreach (var line in lineList.OrderByDescending(x => x.Item2).ToList())
            {
                summary = $"{summary}Linha {line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string ColumnAnalysis(string[] allLines)
        {
            var columnList = new List<Tuple<string, int>>();

            foreach (var line in allLines)
            {
                var balls = line.Split(new[] { ' ', '\t' }, StringSplitOptions.None);

                int columnOne = 0;
                int columnTwo = 0;
                int columnThree = 0;
                int columnFour = 0;
                int columnFive = 0;

                foreach (var ball in balls)
                {
                    if (!string.IsNullOrEmpty(ball))
                    {
                        //Coluna
                        switch (ball)
                        {
                            case "01":
                            case "06":
                            case "11":
                            case "16":
                            case "21":
                                columnOne++;
                                break;

                            case "02":
                            case "07":
                            case "12":
                            case "17":
                            case "22":
                                columnTwo++;
                                break;

                            case "03":
                            case "08":
                            case "13":
                            case "18":
                            case "23":
                                columnThree++;
                                break;

                            case "04":
                            case "09":
                            case "14":
                            case "19":
                            case "24":
                                columnFour++;
                                break;

                            case "05":
                            case "10":
                            case "15":
                            case "20":
                            case "25":
                                columnFive++;
                                break;
                        }
                    }
                }

                //Colunas
                string colunDescription = $"{columnOne}{columnTwo}{columnThree}{columnFour}{columnFive}";
                var oldColumn = columnList.Where(x => x.Item1.Equals(colunDescription)).FirstOrDefault();
                if (oldColumn != null)
                {
                    var newLine = new Tuple<string, int>(oldColumn.Item1, oldColumn.Item2 + 1);
                    columnList.Remove(oldColumn);
                    columnList.Add(newLine);
                }
                else
                {
                    columnList.Add(new Tuple<string, int>(colunDescription, 1));
                }
            }

            string summary = $"***** COLUNAS *****{Environment.NewLine}";

            foreach (var line in columnList.OrderByDescending(x => x.Item2).ToList())
            {
                summary = $"{summary}Coluna {line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string SumAnalysis(string[] allLines)
        {
            var sumList = new List<Tuple<string, int>>();

            foreach (var line in allLines)
            {
                var balls = line.Split(new[] { ' ', '\t' }, StringSplitOptions.None);
                int sumAll = 0;

                foreach (var ball in balls)
                {
                    if (!string.IsNullOrEmpty(ball))
                    {
                        //Sum
                        sumAll += int.Parse(ball);
                    }
                }

                //Sum
                var oldSum = sumList.Where(x => x.Item1.Equals(sumAll.ToString())).FirstOrDefault();
                if (oldSum != null)
                {
                    var newLine = new Tuple<string, int>(oldSum.Item1, oldSum.Item2 + 1);
                    sumList.Remove(oldSum);
                    sumList.Add(newLine);
                }
                else
                {
                    sumList.Add(new Tuple<string, int>(sumAll.ToString(), 1));
                }
            }

            string summary = $"***** SOMAS *****{Environment.NewLine}";

            foreach (var line in sumList.OrderByDescending(x => x.Item1).ToList())
            {
                summary = $"{summary}Soma {line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string PositionAnalysis(string[] allLines)
        {
            var positionList = new List<Tuple<int, string, int>>();
            var numberPositions = new Dictionary<int, List<string>>();

            foreach (var line in allLines)
            {
                var balls = line.Split(new[] { ' ', '\t' }, StringSplitOptions.None).OrderBy(x => x);

                int counter = 1;
                foreach (var ball in balls)
                {
                    var has = numberPositions.ContainsKey(counter);
                    if (has)
                    {
                        var old = numberPositions[counter];
                        numberPositions.Remove(counter);
                        old.Add(ball);
                        numberPositions.Add(counter, old);
                    }
                    else
                    {
                        numberPositions.Add(counter, new List<string> { ball });
                    }

                    counter++;
                }
            }

            foreach (var positions in numberPositions)
            {
                foreach (var position in positions.Value.Distinct())
                {
                    positionList.Add(new Tuple<int, string, int>(positions.Key, position, positions.Value.Count(x => x == position)));
                }
            }

            string summary = $"***** POSIÇÔES *****{Environment.NewLine}";

            foreach (var line in positionList.OrderByDescending(x => x.Item1).ThenBy(c => c.Item2).ToList())
            {
                summary = $"{summary}Posição {line.Item1} - Número {line.Item2} = {line.Item3}{Environment.NewLine}";
            }

            return summary;
        }

        public static string PrimeNumberAnalysis(string[] allLines)
        {
            var primeNumberList = new List<Tuple<string, int>>();
            primeNumberList.Add(new Tuple<string, int>("0", 0));
            primeNumberList.Add(new Tuple<string, int>("1", 0));
            primeNumberList.Add(new Tuple<string, int>("2", 0));
            primeNumberList.Add(new Tuple<string, int>("3", 0));
            primeNumberList.Add(new Tuple<string, int>("4", 0));
            primeNumberList.Add(new Tuple<string, int>("5", 0));
            primeNumberList.Add(new Tuple<string, int>("6", 0));
            primeNumberList.Add(new Tuple<string, int>("7", 0));
            primeNumberList.Add(new Tuple<string, int>("8", 0));
            primeNumberList.Add(new Tuple<string, int>("9", 0));
            var primeNumberArray = new List<string> { "02", "03", "05", "07", "11", "13", "17", "19", "23" };

            foreach (var line in allLines)
            {
                var balls = line.Split(new[] { ' ', '\t' }, StringSplitOptions.None);
                int primeCount = 0;

                foreach (var ball in balls)
                {
                    if (!string.IsNullOrEmpty(ball) && primeNumberArray.Contains(ball))
                        primeCount++;
                }

                //Sum
                var oldPrime = primeNumberList.Where(x => x.Item1.Equals(primeCount.ToString())).FirstOrDefault();
                if (oldPrime != null)
                {
                    var newLine = new Tuple<string, int>(oldPrime.Item1, oldPrime.Item2 + 1);
                    primeNumberList.Remove(oldPrime);
                    primeNumberList.Add(newLine);
                }
                else
                {
                    primeNumberList.Add(new Tuple<string, int>(primeCount.ToString(), 1));
                }
            }

            string summary = $"***** PRIMOS *****{Environment.NewLine}";

            foreach (var line in primeNumberList.OrderByDescending(x => x.Item1).ToList())
            {
                summary = $"{summary}{line.Item1} Primos = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string OddEvenAnalysis(string[] allLines)
        {
            var oddEvenList = new List<Tuple<string, int>>();

            foreach (var line in allLines)
            {
                var balls = line.Split(new[] { ' ', '\t' }, StringSplitOptions.None);
                int odd = 0;
                int even = 0;

                foreach (var ball in balls)
                {
                    if (!string.IsNullOrEmpty(ball))
                    {
                        int.TryParse(ball, out int result);
                        if (result % 2 == 0)
                        {
                            odd++;
                        }
                        else
                        {
                            even++;
                        }
                    }
                }

                //Odd and Even
                var oldOddEven = oddEvenList.Where(x => x.Item1.Equals($"{odd}/{even}")).FirstOrDefault();
                if (oldOddEven != null)
                {
                    var newLine = new Tuple<string, int>(oldOddEven.Item1, oldOddEven.Item2 + 1);
                    oddEvenList.Remove(oldOddEven);
                    oddEvenList.Add(newLine);
                }
                else
                {
                    oddEvenList.Add(new Tuple<string, int>($"{odd}/{even}", 1));
                }
            }

            string summary = $"***** IMPAR/PAR *****{Environment.NewLine}";

            foreach (var line in oddEvenList.OrderByDescending(x => x.Item2).ToList())
            {
                summary = $"{summary}Impar/Par {line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string GroupOf2Analysis(string[] allLines)
        {
            var groupList = new List<Tuple<string, int>>();

            var groupOf2 = GenerateGroupOfTwo();

            Parallel.ForEach(groupOf2, group =>
            {
                var list = allLines.Where(line => line.Contains(group[0]));
                list = list.Where(line => line.Contains(group[1]));
                int quantity = list.Count();
                string key = $"{group[0]} {group[1]}";
                groupList.Add(new Tuple<string, int>(key, quantity));
            });

            string summary = $"***** Grupo de 2 *****{Environment.NewLine}";

            foreach (var line in groupList.OrderByDescending(x => x.Item2).ToList())
            {
                summary = $"{summary}{line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string GroupOf3Analysis(string[] allLines)
        {
            var groupList = new List<Tuple<string, int>>();

            var groupOf3 = GenerateGroupOfThree();

            Parallel.ForEach(groupOf3, group =>
            {
                var list = allLines.Where(line => line.Contains(group[0]));
                list = list.Where(line => line.Contains(group[1]));
                list = list.Where(line => line.Contains(group[2]));
                int quantity = list.Count();
                string key = $"{group[0]} {group[1]} {group[2]}";
                groupList.Add(new Tuple<string, int>(key, quantity));
            });

            string summary = $"***** Grupo de 3 *****{Environment.NewLine}";

            foreach (var line in groupList.OrderByDescending(x => x.Item2).ToList())
            {
                summary = $"{summary}{line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string GroupOf4Analysis(string[] allLines)
        {
            var groupList = new List<Tuple<string, int>>();

            var groupOf4 = GenerateGroupOfFour();

            Parallel.ForEach(groupOf4, group =>
            {
                var list = allLines.Where(line => line.Contains(group[0]));
                list = list.Where(line => line.Contains(group[1]));
                list = list.Where(line => line.Contains(group[2]));
                list = list.Where(line => line.Contains(group[3]));
                int quantity = list.Count();
                string key = $"{group[0]} {group[1]} {group[2]} {group[3]}";
                groupList.Add(new Tuple<string, int>(key, quantity));
            });

            string summary = $"***** Grupo de 4 *****{Environment.NewLine}";

            foreach (var line in groupList.OrderByDescending(x => x.Item2).ToList())
            {
                summary = $"{summary}{line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string GroupOf5Analysis(string[] allLines)
        {
            var groupList = new List<Tuple<string, int>>();

            var groupOf5 = GenerateGroupOfFive();

            Parallel.ForEach(groupOf5, group =>
            {
                var list = allLines.Where(line => line.Contains(group[0]));
                list = list.Where(line => line.Contains(group[1]));
                list = list.Where(line => line.Contains(group[2]));
                list = list.Where(line => line.Contains(group[3]));
                list = list.Where(line => line.Contains(group[4]));
                int quantity = list.Count();
                string key = $"{group[0]} {group[1]} {group[2]} {group[3]} {group[4]}";
                groupList.Add(new Tuple<string, int>(key, quantity));
            });

            string summary = $"***** Grupo de 5 *****{Environment.NewLine}";

            foreach (var line in groupList.OrderByDescending(x => x.Item2).ToList())
            {
                summary = $"{summary}{line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string GroupOf6Analysis(string[] allLines)
        {
            var groupList = new List<Tuple<string, int>>();

            var groupOf6 = GenerateGroupOfSix();

            Parallel.ForEach(groupOf6, group =>
            {
                var list = allLines.Where(line => line.Contains(group[0]));
                list = list.Where(line => line.Contains(group[1]));
                list = list.Where(line => line.Contains(group[2]));
                list = list.Where(line => line.Contains(group[3]));
                list = list.Where(line => line.Contains(group[4]));
                list = list.Where(line => line.Contains(group[5]));
                int quantity = list.Count();
                string key = $"{group[0]} {group[1]} {group[2]} {group[3]} {group[4]} {group[5]}";
                groupList.Add(new Tuple<string, int>(key, quantity));
            });

            string summary = $"***** Grupo de 6 *****{Environment.NewLine}";

            foreach (var line in groupList.OrderByDescending(x => x.Item2).ToList())
            {
                summary = $"{summary}{line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string GroupOf7Analysis(string[] allLines)
        {
            var groupList = new List<Tuple<string, int>>();

            var groupOf7 = GenerateGroupOfSeven();

            Parallel.ForEach(groupOf7, group =>
            {
                var list = allLines.Where(line => line.Contains(group[0]));
                list = list.Where(line => line.Contains(group[1]));
                list = list.Where(line => line.Contains(group[2]));
                list = list.Where(line => line.Contains(group[3]));
                list = list.Where(line => line.Contains(group[4]));
                list = list.Where(line => line.Contains(group[5]));
                list = list.Where(line => line.Contains(group[6]));
                int quantity = list.Count();
                string key = $"{group[0]} {group[1]} {group[2]} {group[3]} {group[4]} {group[5]} {group[6]}";
                groupList.Add(new Tuple<string, int>(key, quantity));
            });

            string summary = $"***** Grupo de 7 *****{Environment.NewLine}";

            foreach (var line in groupList.OrderByDescending(x => x.Item2).ToList())
            {
                summary = $"{summary}Grupo {line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        private static List<string[]> GenerateGroupOfTwo()
        {
            var result = new List<string[]>();
            for (int a = 0; a < length; a++)
            {
                for (int b = a + 1; b < length; b++)
                {
                    result.Add(new string[] { allValues[a], allValues[b] });
                }
            }
            return result;
        }

        private static List<string[]> GenerateGroupOfThree()
        {
            var result = new List<string[]>();
            for (int a = 0; a < length; a++)
            {
                for (int b = a + 1; b < length; b++)
                {
                    for (int c = b + 1; c < length; c++)
                    {
                        result.Add(new string[] { allValues[a], allValues[b], allValues[c] });
                    }
                }
            }
            return result;
        }

        private static List<string[]> GenerateGroupOfFour()
        {
            var result = new List<string[]>();
            for (int a = 0; a < length; a++)
            {
                for (int b = a + 1; b < length; b++)
                {
                    for (int c = b + 1; c < length; c++)
                    {
                        for (int d = c + 1; d < length; d++)
                        {
                            result.Add(new string[] { allValues[a], allValues[b], allValues[c], allValues[d] });
                        }
                    }
                }
            }
            return result;
        }

        private static List<string[]> GenerateGroupOfFive()
        {
            var result = new List<string[]>();
            for (int a = 0; a < length; a++)
            {
                for (int b = a + 1; b < length; b++)
                {
                    for (int c = b + 1; c < length; c++)
                    {
                        for (int d = c + 1; d < length; d++)
                        {
                            for (int e = d + 1; e < length; e++)
                            {
                                result.Add(new string[] { allValues[a], allValues[b], allValues[c], allValues[d], allValues[e] });
                            }
                        }
                    }
                }
            }
            return result;
        }

        private static List<string[]> GenerateGroupOfSix()
        {
            var result = new List<string[]>();
            for (int a = 0; a < length; a++)
            {
                for (int b = a + 1; b < length; b++)
                {
                    for (int c = b + 1; c < length; c++)
                    {
                        for (int d = c + 1; d < length; d++)
                        {
                            for (int e = d + 1; e < length; e++)
                            {
                                for (int f = e + 1; f < length; f++)
                                {
                                    result.Add(new string[] { allValues[a], allValues[b], allValues[c], allValues[d], allValues[e], allValues[f] });
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        private static List<string[]> GenerateGroupOfSeven()
        {
            var result = new List<string[]>();
            for (int a = 0; a < length; a++)
            {
                for (int b = a + 1; b < length; b++)
                {
                    for (int c = b + 1; c < length; c++)
                    {
                        for (int d = c + 1; d < length; d++)
                        {
                            for (int e = d + 1; e < length; e++)
                            {
                                for (int f = e + 1; f < length; f++)
                                {
                                    for (int g = f + 1; g < length; g++)
                                    {
                                        result.Add(new string[] { allValues[a], allValues[b], allValues[c], allValues[d], allValues[e], allValues[f], allValues[g] });
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}

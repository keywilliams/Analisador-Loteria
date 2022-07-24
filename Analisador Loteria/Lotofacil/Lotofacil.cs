using System;
using System.Collections.Generic;
using System.Linq;

namespace Analisador_Loteria.Lotofacil
{
    public static class Lotofacil
    {
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

            foreach (var line in sumList.OrderByDescending(x => x.Item2).ToList())
            {
                summary = $"{summary}Soma {line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }

        public static string PositionAnalysis(string[] allLines)
        {
            var positionList = new List<Tuple<string, int, int>>();
            var numberPositions = new Dictionary<string, List<int>>();

            foreach (var line in allLines)
            {
                var balls = line.Split(new[] { ' ', '\t' }, StringSplitOptions.None).OrderBy(x => x);

                int counter = 1;
                foreach (var ball in balls)
                {
                    var has = numberPositions.ContainsKey(ball);
                    if (has)
                    {
                        var old = numberPositions[ball];
                        numberPositions.Remove(ball);
                        old.Add(counter);
                        numberPositions.Add(ball, old);
                    }
                    else
                    {
                        numberPositions.Add(ball, new List<int> { counter });
                    }

                    counter++;
                }
            }

            foreach (var positions in numberPositions)
            {
                foreach (var position in positions.Value.Distinct())
                {
                    positionList.Add(new Tuple<string, int, int>(positions.Key, position, positions.Value.Count(x => x == position)));
                }
            }

            string summary = $"***** POSIÇÔES *****{Environment.NewLine}";

            foreach (var line in positionList.OrderByDescending(x => x.Item1).ThenBy(c => c.Item2).ToList())
            {
                summary = $"{summary}Número {line.Item1} - Posição {line.Item2} = {line.Item3}{Environment.NewLine}";
            }

            return summary;
        }

        public static string PrimeNumberAnalysis(string[] allLines)
        {
            var primeNumberList = new List<Tuple<string, int>>();
            primeNumberList.Add(new Tuple<string, int>("1", 0));
            primeNumberList.Add(new Tuple<string, int>("2", 0));
            primeNumberList.Add(new Tuple<string, int>("3", 0));
            primeNumberList.Add(new Tuple<string, int>("4", 0));
            primeNumberList.Add(new Tuple<string, int>("5", 0));
            primeNumberList.Add(new Tuple<string, int>("6", 0));
            primeNumberList.Add(new Tuple<string, int>("7", 0));
            primeNumberList.Add(new Tuple<string, int>("8", 0));
            primeNumberList.Add(new Tuple<string, int>("9", 0));
            var primeNumberArray = new List<string> { "2", "3", "5", "7", "11", "13", "17", "19", "23" };

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
                summary = $"{summary}Total {line.Item1} = {line.Item2}{Environment.NewLine}";
            }

            return summary;
        }
    }
}

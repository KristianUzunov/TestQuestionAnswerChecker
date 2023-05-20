using System;

namespace TestAnswerChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
                bool isInt = true;
                bool letPass = false;
                int numberToTestCuzImTooStupidToThinkOfAnotherWayToDoThis = 0;
                string continueQuestion = "1";
                while (continueQuestion != "STOP")
                {
                    Console.WriteLine("Input number of questions on the test.");
                    string numberOfQuestions = Console.ReadLine();
                    numberToTestCuzImTooStupidToThinkOfAnotherWayToDoThis = 0;
                    letPass = false;
                    while (letPass == false)
                    {
                        isInt = true;
                        foreach (var thing in numberOfQuestions)
                        {
                            if (char.IsLetter(thing) || thing == '.' || thing == ' ')
                            {
                                isInt = false;
                                Console.WriteLine("Please use a whole digit.");
                                numberOfQuestions = Console.ReadLine();
                                break;
                            }
                            if (isInt == true && numberToTestCuzImTooStupidToThinkOfAnotherWayToDoThis == numberOfQuestions.Length)
                            {
                                letPass = true;
                            }
                            numberToTestCuzImTooStupidToThinkOfAnotherWayToDoThis++;
                        }
                    }
                string[] givenAnswers = new string[int.Parse(numberOfQuestions)];
                string[] actualAnswers = new string[int.Parse(numberOfQuestions)];
                    for (int i = 1; i <= int.Parse(numberOfQuestions); i++)
                    {
                    Console.WriteLine($"Input your answer to question {i}");
                    givenAnswers[i - 1] = Console.ReadLine();
                    }
                for (int i = 1; i <= int.Parse(numberOfQuestions); i++)
                {
                    Console.WriteLine($"Input the correct answer to question {i}");
                    actualAnswers[i - 1] = Console.ReadLine();
                }
                Console.WriteLine($"Time to check your answers:");
                for (int i = 1; i <= int.Parse(numberOfQuestions); i++)
                {
                    if (givenAnswers[i - 1] == actualAnswers[i - 1])
                    {
                        Console.WriteLine($"{givenAnswers[i - 1]} - {actualAnswers[i - 1]} - Correct.");
                    }
                    else
                    {
                        Console.WriteLine($"{givenAnswers[i - 1]} - {actualAnswers[i - 1]} - Wrong.");
                    }
                }
                Console.WriteLine("Type anything to continue or type STOP to exit the application.");
                    continueQuestion = Console.ReadLine();
                }
            }
        }
    }

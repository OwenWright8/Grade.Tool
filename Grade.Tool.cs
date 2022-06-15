using System;
using Grade.Tool;
using Spectre.Console;

namespace Grade_Tools
{
    public class Grade_Tools
    {
        public static double lowestCalc { get; set; } = 0;
        public static void SemesterGradeTool()

        {
            Console.Clear();
            Console.WriteLine("What class is this for?");
            string class_ = Console.ReadLine();
            {
                Console.WriteLine("What is your grade for Quarter One?");
                int quarterOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your grade for Quarter Two?");
                int quarterTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What did you get on your final?");
                int final = Convert.ToInt32(Console.ReadLine());

                double gradeOne = (quarterOne + quarterTwo) / 2;
                gradeOne = gradeOne * .8;
                double gradeTwo = final * .2;
                int semesterGrade = Convert.ToInt32(gradeOne + gradeTwo);

                if (semesterGrade >= 90)
                {
                    Console.Clear();
                    Console.WriteLine($"Congratulations, your semester grade in {class_} is {semesterGrade}%");
                    Console.ReadKey();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine($"Sorry, your semester grade in {class_} is {semesterGrade}%");
                    Console.ReadKey();
                }

            }
        }

        public static void LowestScoreGradeTool()
        {
            Console.Clear();

            double scoreWanted = AnsiConsole.Ask<double>("[grey100]What is the lowest score you're willing to get on your Semester Grade?[/]");
            lowestCalc = scoreWanted - .5;

            Console.Clear();

            var classList = new List<ClassInformation>();
            var numberOfClassList = new List<string> { "First Class", "Second Class", "Third Class", "Fourth Class", "Fith Class", "Sixth Class", "Seventh Class"};

            foreach (var classNumber in numberOfClassList)
            {
                var rule = new Rule($"[bold darkgoldenrod]{classNumber}[/]");
                rule.Alignment = Justify.Left;
                AnsiConsole.Write(rule);

                var className = AnsiConsole.Ask<string>($"[grey100]What is your {classNumber}? (Enter \"None\" if done) [/]");
                if (className.Equals("None", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.Clear();
                    break;
                }
                
                var Q1Grade = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter One in {className}? [/]");
                var Q2Grade = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter Two in {className}? [/]");
                classList.Add(new ClassInformation { ClassName = className, Q1Grade = Q1Grade, Q2Grade = Q2Grade });

                Console.Clear();
            }

            AnsiConsole.Status()
    .Start("Calculating semester grades", ctx =>
    {
        // Simulate some work
        AnsiConsole.MarkupLine("Calculating lowest scores...");
        Thread.Sleep(1000);

        // Update the status and spinner
        ctx.Status("Setting Variables...");
        ctx.Spinner(Spinner.Known.Star);
        ctx.SpinnerStyle(Style.Parse("red"));

        // Simulate some work
        AnsiConsole.MarkupLine("Getting ready to present...");
        Thread.Sleep(2000);
    });

            Console.Clear();

            //Table
            var table = new Table().Centered();
            table.Border = TableBorder.MinimalHeavyHead;

            AnsiConsole.Live(table)
                .AutoClear(false)
                .Overflow(VerticalOverflow.Ellipsis)
                .Cropping(VerticalOverflowCropping.Top)
                .Start(ctx =>
                {
                    table.Title("[red]Lowest Score Calculator[/]");
                    ctx.Refresh();
                    Thread.Sleep(10);

                    table.AddColumn(new TableColumn("Classes").Centered());
                    ctx.Refresh();
                    Thread.Sleep(250);

                    table.AddColumn(new TableColumn("[blue]Q1 Grade[/]").Centered());
                    ctx.Refresh();
                    Thread.Sleep(250);

                    table.AddColumn(new TableColumn("[blue]Q2 Grade[/]").Centered());
                    ctx.Refresh();
                    Thread.Sleep(250);

                    table.AddColumn(new TableColumn("[green]Minimum Score[/]").Centered());
                    ctx.Refresh();
                    Thread.Sleep(250);

                    classList.ForEach(thisClass => {
                        var neededScore = Calculations(thisClass);
                        table.AddRow(thisClass.ClassName, thisClass.Q1Grade.ToString(), thisClass.Q2Grade.ToString(), neededScore.ToString());
                        ctx.Refresh();
                        Thread.Sleep(500);
                    });
                    Thread.Sleep(-1);
                });
        }
        static double Calculations(ClassInformation classInformation)
        {
            var semesterGradeCalc = (((classInformation.Q1Grade + classInformation.Q2Grade) / 2) * .8);
            return Convert.ToInt32((lowestCalc - semesterGradeCalc) / .2);
        }
    }
}
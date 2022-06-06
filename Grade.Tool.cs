using System;
using Spectre.Console;

namespace Grade_Tools
{
    public class Grade_Tools
    {
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
            double lowestCalc = scoreWanted - .5;

            Console.Clear();

            //Class one
            var rule = new Rule("[bold darkgoldenrod]Class One[/]");
            rule.Alignment = Justify.Left;
            AnsiConsole.Write(rule);

            var classOne = AnsiConsole.Ask<string>("[grey100]What is your first class? [/]");

            var classOneQ1 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter One in {classOne}? [/]");
            var classOneQ2 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter Two in {classOne}? [/]");

            Console.Clear();

            //Class Two
            var rule2 = new Rule("[bold darkgoldenrod]Class Two[/]");
            rule2.Alignment = Justify.Left;
            AnsiConsole.Write(rule2);

            var classTwo = AnsiConsole.Ask<string>("[grey100]What is your second class? [/]");

            var classTwoQ1 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter One in {classTwo}? [/]");
            var classTwoQ2 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter Two in {classTwo}? [/]");

            Console.Clear();

            //Class Three
            var rule3 = new Rule("[bold darkgoldenrod]Class Three[/]");
            rule3.Alignment = Justify.Left;
            AnsiConsole.Write(rule3);

            var classThree = AnsiConsole.Ask<string>("[grey100]What is your third class? [/]");

            var classThreeQ1 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter One in {classThree}? [/]");
            var classThreeQ2 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter Two in {classThree}? [/]");

            Console.Clear();

            //Class Four
            var rule4 = new Rule("[bold darkgoldenrod]Class Four[/]");
            rule4.Alignment = Justify.Left;
            AnsiConsole.Write(rule4);

            var classFour = AnsiConsole.Ask<string>("[grey100]What is your forth class? [/]");

            var classFourQ1 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter One in {classFour}? [/]");
            var classFourQ2 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter Two in {classFour}? [/]");

            Console.Clear();

            //Class Five
            var rule5 = new Rule("[bold darkgoldenrod]Class Five[/]");
            rule5.Alignment = Justify.Left;
            AnsiConsole.Write(rule5);

            var classFive = AnsiConsole.Ask<string>("[grey100]What is your fith class? [/]");

            var classFiveQ1 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter One in {classFive}? [/]");
            var classFiveQ2 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter Two in {classFive}? [/]");

            Console.Clear();

            //Class Six
            var rule6 = new Rule("[bold darkgoldenrod]Class Six[/]");
            rule6.Alignment = Justify.Left;
            AnsiConsole.Write(rule6);

            var classSix = AnsiConsole.Ask<string>("[grey100]What is your sixth class? [/]");

            var classSixQ1 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter One in {classSix}? [/]");
            var classSixQ2 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter Two in {classSix}? [/]");

            Console.Clear();

            //Class Seven
            var rule7 = new Rule("[bold darkgoldenrod]Class Seven[/]");
            rule7.Alignment = Justify.Left;
            AnsiConsole.Write(rule7);

            var classSeven = AnsiConsole.Ask<string>("[grey100]What is your seventh class? [/]");

            var classSevenQ1 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter One in {classSeven}? [/]");
            var classSevenQ2 = AnsiConsole.Ask<int>($"[grey100]What is your score for Quarter Two in {classSeven}? [/]");

            Console.Clear();

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

            //Class One
            double semesterGradeCalcOne = (((classOneQ1 + classOneQ2) / 2) * .8);
            double neededScoreOne = Convert.ToInt32((lowestCalc - semesterGradeCalcOne) / .2);

            //Class Two
            double semesterGradeCalcTwo = (((classTwoQ1 + classTwoQ2) / 2) * .8);
            double neededScoreTwo = Convert.ToInt32((lowestCalc - semesterGradeCalcTwo) / .2);

            //Class Three
            double semesterGradeCalcThree = (((classThreeQ1 + classThreeQ2) / 2) * .8);
            double neededScoreThree = Convert.ToInt32((lowestCalc - semesterGradeCalcThree) / .2);

            //Class Four
            double semesterGradeCalcFour = (((classFourQ1 + classFourQ2) / 2) * .8);
            double neededScoreFour = Convert.ToInt32((lowestCalc - semesterGradeCalcFour) / .2);

            //Class Five
            double semesterGradeCalcFive = (((classFiveQ1 + classFiveQ2) / 2) * .8);
            double neededScoreFive = Convert.ToInt32((lowestCalc - semesterGradeCalcFive) / .2);

            //Class Six
            double semesterGradeCalcSix = (((classSixQ1 + classSixQ2) / 2) * .8);
            double neededScoreSix = Convert.ToInt32((lowestCalc - semesterGradeCalcSix) / .2);

            //Class Seven
            double semesterGradeCalcSeven = (((classSevenQ1 + classSevenQ2) / 2) * .8);
            double neededScoreSeven = Convert.ToInt32((lowestCalc - semesterGradeCalcSeven) / .2);

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


                    table.AddRow(classOne, Convert.ToString(classOneQ1), Convert.ToString(classOneQ2), Convert.ToString(neededScoreOne));
                    ctx.Refresh();
                    Thread.Sleep(500);

                    table.AddRow(classTwo, Convert.ToString(classTwoQ1), Convert.ToString(classTwoQ2), Convert.ToString(neededScoreTwo));
                    ctx.Refresh();
                    Thread.Sleep(500);

                    table.AddRow(classThree, Convert.ToString(classThreeQ1), Convert.ToString(classThreeQ2), Convert.ToString(neededScoreThree));
                    ctx.Refresh();
                    Thread.Sleep(500);

                    table.AddRow(classFour, Convert.ToString(classFourQ1), Convert.ToString(classFourQ2), Convert.ToString(neededScoreFour));
                    ctx.Refresh();
                    Thread.Sleep(500);

                    table.AddRow(classFive, Convert.ToString(classFiveQ1), Convert.ToString(classFiveQ2), Convert.ToString(neededScoreFive));
                    ctx.Refresh();
                    Thread.Sleep(500);

                    table.AddRow(classSix, Convert.ToString(classSixQ1), Convert.ToString(classFiveQ2), Convert.ToString(neededScoreSix));
                    ctx.Refresh();
                    Thread.Sleep(500);

                    table.AddRow(classSeven, Convert.ToString(classSevenQ1), Convert.ToString(classSevenQ2), Convert.ToString(neededScoreSeven));
                    ctx.Refresh();
                    Thread.Sleep(-1);
                });
        }
    }
}
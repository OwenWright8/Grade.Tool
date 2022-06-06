using static Grade_Tools.Grade_Tools;
using Spectre.Console;

namespace Grade_Tools;

internal class Grade_Checker
{
    public static void Main(string[] args)
    {

        AnsiConsole.Write(
    new FigletText("Grade Tool")
        .Centered()
        .Color(Color.Red));

        var choice = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("[red]Please select an option[/]")
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to reveal more choices)[/]")
        .AddChoices(new[] {
            "1) Semester Grade Check", "2) Lowest Score Calculator", "3) Exit"
        }));

        switch (choice)
        {
            case "1) Semester Grade Check":
                SemesterGradeTool();
                break;

            case "2) Lowest Score Calculator":
                LowestScoreGradeTool();
                break;

            default:
                break;
        }
    }
}

using CollectionsTypes.Queue;

Queue<PrintingJob> printingJobs = new Queue<PrintingJob>();

printingJobs.Enqueue(new PrintingJob("documentation.docx", 4));
printingJobs.Enqueue(new PrintingJob("stories.pdf",1));
printingJobs.Enqueue(new PrintingJob("report.xlsx",6));
printingJobs.Enqueue(new PrintingJob("payroll.ppt",2));
printingJobs.Enqueue(new PrintingJob("budget.xlsx",9));
Console.WriteLine($"Current Queue Count = {printingJobs.Count}");

Random rnd = new Random();
while(printingJobs.Count > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    var job = printingJobs.Dequeue();
    Console.WriteLine($"printing... [{job}]");
    System.Threading.Thread.Sleep(rnd.Next(1,5)*1000);
}

Console.ResetColor();
Console.WriteLine($"Current Queue Count = {printingJobs.Count}");

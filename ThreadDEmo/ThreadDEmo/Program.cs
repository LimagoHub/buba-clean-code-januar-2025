// See https://aka.ms/new-console-template for more information

/*Task task = Task.Run(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Task iteration{i}");
        Thread.Sleep(200);
    }
});

Task task2 = Task.Run(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Task2 iteration{i}");
        Thread.Sleep(200);
    }
});
task.Wait();
task2.Wait();
*/
/*TaskFactory factory = new TaskFactory();
Task task = factory.StartNew(() => { });
Task task2 = factory.StartNew(() => { });
Task.WaitAll(task, task2);
*/

List<Task> tasks = new List<Task>();
int numberOfThreads = 10;

for (int i = 0; i < numberOfThreads; i++)
{
    int taskNumber = i; // Wichtig Closure damit jeder Thread seine eigene Nummer bekommt
    Task task = Task.Run(() =>
    {
        Console.WriteLine($"Task {taskNumber} startet.");
        // Simuliere Arbeit
        Thread.Sleep(1000 * taskNumber);
        Console.WriteLine($"Task {taskNumber} beendet.");
    });
    tasks.Add(task);
    
}
Console.WriteLine("Alle Task gestartet");
Task.WaitAll(tasks.ToArray());
Console.WriteLine("Hello, World!");

using Collections.LinkedListApp;

var lesson1 = new YTVideo { Id = "YTV1", Title = "Variable", Duration = new TimeSpan(00, 30, 00) };
var lesson2 = new YTVideo { Id = "YTV2", Title = "Classes and Structs", Duration = new TimeSpan(00, 08, 00) };
var lesson3 = new YTVideo { Id = "YTV3", Title = "Expressions", Duration = new TimeSpan(01, 15, 00) };
var lesson4 = new YTVideo { Id = "YTV4", Title = "Iterations", Duration = new TimeSpan(00, 34, 00) };
var lesson5 = new YTVideo { Id = "YTV5", Title = "Generics", Duration = new TimeSpan(00, 26, 00) };

LinkedList<YTVideo> list = new LinkedList<YTVideo>(new YTVideo[]
{
    lesson1 , lesson2 , lesson3 , lesson4 , lesson5
});

LinkedList<YTVideo> list2 = new LinkedList<YTVideo>();
list2.AddFirst(lesson1);
list2.AddAfter(list2.First, lesson2);
list2.AddAfter(list2.First.Next, lesson3);
list2.AddAfter(list2.Last, lesson4);
list2.AddLast(lesson5);

print("C# from zero to hero 'LIST1'", list);
print("C# from zero to hero 'LIST2'", list);




static void print(string title,LinkedList<YTVideo> playlist)
{
    Console.WriteLine($"┌{title}");
    foreach (var item in playlist)
	{
        Console.WriteLine(item);
    }
    Console.WriteLine("└");
    // └ (alt +192)
    // ┌ (alt + 218)
}
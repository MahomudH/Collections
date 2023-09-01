using Collections.HashSetAndSortedSetApp;
Console.WriteLine("----------");
Console.WriteLine("HashSet");
Customer[] customers = new Customer[] 
{
    new Customer { Name = "Mahmoud", Phone = "+972 059 1546 824" }, 
    new Customer { Name = "Ahmed", Phone = "+972 059 1546 823" }, 
    new Customer { Name = "Mahmoud", Phone = "+972 059 1546 821" }, 
    new Customer { Name = "Shatha", Phone = "+972 059 1546 824" }, // this will not added to hashset because she has the same mahmouds' phone number 
    new Customer { Name = "Alaa", Phone = "+972 059 1546 829" }, 
};

HashSet<Customer> customerSet = new HashSet<Customer>(customers);

foreach (Customer customer in customerSet) Console.WriteLine(customer);

Console.WriteLine("----------");
Console.WriteLine("SortedSet");

// the sortedset will sort the customer by their name because I make the "CompareTo" function compare by "Name"  
SortedSet<Customer> customerSortedSet = new SortedSet<Customer>(customers);

foreach (Customer customer in customerSortedSet) Console.WriteLine(customer);

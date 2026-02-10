class Program
{
  static void Main()
  {
    // GarbageCollectionDemo();
    // ResourceDemo();
    // RecordDemo();
    // GenericsDemo();
    // AdvancedDictionaryDemo();
    // DictionaryDemo();
    // CollectionClassesDemo();
    ArrayCollectionDemo();

  }

  public static void AdvancedDictionaryDemo()
  {
    Dictionary<string, int> studentAge = new Dictionary<string, int>();
    Dictionary<string, List<int>> studentMarks = new Dictionary<string, List<int>>();

    studentMarks["Alice"] = new List<int> { 88, 90, 92 };
    studentMarks["Bob"] = new List<int> { 10, 20, 30 };

    foreach (var kvp in studentMarks)
    {
      Console.WriteLine($"{kvp.Key}: {kvp.Value.Average()}");
    }

    studentMarks["Alice"].Add(95);
    Console.WriteLine($"Alice's marks after adding a new mark: {string.Join(", ", studentMarks["Alice"])}");
  }

  public static void DictionaryDemo()
  {
    Dictionary<string, int> dict = new Dictionary<string, int>();
    dict["Alice"] = 30;
    dict["Bob"] = 25;
    dict["Charlie"] = 35;
    dict["Alice"] = 40;

    foreach (var kvp in dict)
    {
      Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }

    dict.Add("Zia", 28);

    if (dict.TryGetValue("Zia", out int age))
    {
      Console.WriteLine($"Zia's age: {age}");
    }
  }

  public static void CollectionClassesDemo()
  {
    List<int> marks = new List<int>(10);

    marks.AddRange(new int[] { 1, 2, 3 });
    Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");

    marks.AddRange(new List<int> { 4, 5, 6 });
    Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");

    marks.AddRange(new List<int> { 7, 8, 9, 10 });
    Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");

    Console.WriteLine($"Marks Avg: {marks.Average()}");
  }

  public static void ArrayCollectionDemo()
  {
    ArrayList list = new ArrayList();
    list.Add(1);
    list.Add(2);
    list.Add(3);
    list.Add("Hello");
    list.Add(3.14);


    foreach (var item in list)
    {
      // Console.WriteLine(item);
    }

    int sum = 0;
    foreach (var item in list)
    {
      Console.WriteLine($"item: {item}, type: {item.GetType()}");
      sum += (int)item;
      Console.WriteLine($"Sum: {sum}");
    }
  }
  private static void GarbageCollectionDemo()
  {
    using (Room room = new Room())
    {
      Console.WriteLine("Using the room");
    }
  }

  private static void ResourceDemo()
  {
    var res1 = new Resource("Res1"); // allocated on heap
    var res2 = new Resource("Res2");
    res1 = null; // res1 now eligible for collection
    res2 = res2; // res2 still referenced
    GC.Collect(); // Force collection (normally automatic)
    GC.WaitForPendingFinalizers();
    // GC demonstration
    Console.WriteLine("GC completed");
  }
  private static void RecordDemo()
  {
    var temp1 = new Temp { Id = 1, Name = "Temp1" };
    var temp2 = new Temp { Id = 1, Name = "Temp1" };

    Console.WriteLine(temp1);
    Console.WriteLine(temp2);
    Console.WriteLine(temp1 == temp2);

    // temp1.Id = 3;

    var temp3 = temp1 with { Id = 2 };
    Console.WriteLine(temp3);
  }

  private static void GenericsDemo()
  {
    DataStore<int> intStore = new DataStore<int>();
    intStore.Set(100);
    Console.WriteLine(intStore.Get());

    DataStore<string> stringStore = new DataStore<string>();
    stringStore.Set("Hello Generics");
    Console.WriteLine(stringStore.Get());
  }
}


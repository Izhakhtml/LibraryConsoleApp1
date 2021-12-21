using LibraryConsoleApp1;

//// exe 1 /////

string[] arrayNames = new string[] { "izhak", "shimon", "haim", "Eiv", "noam", "jacob", "eden" };
var listNames = from item in arrayNames
                where item.ToLower()[0] == 'e'
                select item;
//foreach(var item in listNames)
//{
//    Console.WriteLine(item);
//}

//// exe 2 /////

int[] arrayRandomNumbers = new int[10];
Random random = new Random();
int i = 0;
while (i < 10)
{
    arrayRandomNumbers[i] = random.Next(0, 40);
    i++;
}
var listRandom = from item in arrayRandomNumbers
                 where item > 20
                 select item;
//foreach (var item in listRandom)
//{
//    Console.WriteLine(item);
//}

//// exe 3+4 /////

Book[] arryaBook = new Book[]
{
    new Book("limited life","ahron",random.Next(0,500)),
    new Book("black sky","moti",random.Next(0,500)),
    new Book("fast car","eliav",random.Next(0,500)),
    new Book("new hood","moti",random.Next(0,500)),
    new Book("when grow up","adva",random.Next(0,500)),
    new Book("after day","moti",random.Next(0,500)),
};
List<Book> listBooks = new List<Book>();
listBooks.AddRange(arryaBook);
//// exe 5 /////

var listBook = (from item in arryaBook
               where item.numbersPages > 200
               select item).ToList();
//foreach (var item in listBook)
//{
//    Console.WriteLine(item.writer);
//}

//// exe 6 ////

var listWriterLonger = from item in listBook
                       where item.writer.Length > 4
                       select item;
//foreach (var item in listWriterLonger)
//{
//    Console.WriteLine(item.writer);
//}

//// exe 7 /////

//Book finfNum = listBooks.Find(item => item.numbersPages < 150);
//Console.WriteLine(finfNum.numbersPages);

//// exe 8 /////

var listFinishWithY = from item in arryaBook
                      where item.writer.ToUpper()[item.writer.Length - 1] == 'Y'
                      select item;
//foreach (var item in listFinishWithY)
//{
//    Console.WriteLine(item.writer);
//}

//// exe 9 ////
var group = from item in arryaBook
            group item by item.writer;
//foreach (var item in group)
//{
//    Console.WriteLine($"name group:{item.Key}");
//    foreach (var groupItem in item)
//    {
//        Console.WriteLine(groupItem.writer);
//        Console.WriteLine(groupItem.bookName);
//        Console.WriteLine(groupItem.numbersPages);
//    }
//}

//// exe 10 ////

foreach (var item in group)
{
    Console.WriteLine($"name group:{item.Key}");
    foreach (var groupItem in item)
    {
        Console.WriteLine(groupItem.bookName);
    }
}
// See https://aka.ms/new-console-template for more information


using Queue;

QueueArray x = new(3);

//x.Enqueue(1);
//x.Enqueue(2);
//x.Enqueue(3);

//x.PrintMembers();

//Console.WriteLine("-------");
//Console.WriteLine("poped item :" + x.Dequeue()); // 2 , 3
//Console.WriteLine("poped item :" + x.Dequeue()); // 2 , 3


//x.PrintMembers();


//Console.WriteLine("after adding:");
//x.Enqueue(5);
//x.PrintMembers();




x.Enqueue(1);
x.Enqueue(2);
x.Enqueue(3);
x.PrintMembers();
Console.WriteLine(":: " + x.Dequeue());
x.PrintMembers();

x.Enqueue(5);
Console.WriteLine(":: " + x.Dequeue());
x.Enqueue(6);
x.PrintMembers();













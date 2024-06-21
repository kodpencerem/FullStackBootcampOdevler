

using Odev3_ListYapilar;

ArrayExample arrayExample = new ArrayExample();
arrayExample.Example();
Console.WriteLine();

// ArrayList example
ArrayListExample arrayListExample = new ArrayListExample();
arrayListExample.Example();
Console.WriteLine();

// Hashtable example
HashtableExample hashtableExample = new HashtableExample();
hashtableExample.Example();
Console.WriteLine();

// Queue example
QueueExample queueExample = new QueueExample();
queueExample.Example();
Console.WriteLine();

// Stack example
StackExample stackExample = new StackExample();
stackExample.Example();
Console.WriteLine();

// List<T> example
ListExample<int> listExample = new ListExample<int>();
listExample.Example(10);
listExample.Example(12);

Console.WriteLine();

// Dictionary<TKey, TValue> example
DictionaryExample<string, int> dictionaryExample = new DictionaryExample<string, int>();
dictionaryExample.Example("Anahtar",123);
Console.WriteLine();

// SortedList<TKey, TValue> example
SortedListExample<int, string> sortedListExample = new SortedListExample<int, string>();
sortedListExample.Example(3, "Üç");
sortedListExample.Example(1, "Bir");
sortedListExample.Example(2, "İki");
Console.WriteLine();

// Queue<T> example
QueueGenericExample<double> queueGenericExample = new QueueGenericExample<double>();
queueGenericExample.Example(1,2,3);
Console.WriteLine();

// Stack<T> example
StackGenericExample<int> stackGenericExample = new StackGenericExample<int>();
stackGenericExample.Example(1, 2, 3);
Console.WriteLine();

// HashSet<T> example
HashSetExample<string> hashSetExample = new HashSetExample<string>();
hashSetExample.Example("Elma", "Portakal", "Muz");
Console.WriteLine();

// LinkedList<T> example
LinkedListExample<double> linkedListExample = new LinkedListExample<double>();
linkedListExample.Example(1.5, 2.5, 3.5);

Console.ReadLine();
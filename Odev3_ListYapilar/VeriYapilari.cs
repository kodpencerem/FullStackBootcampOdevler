using System.Collections;

namespace Odev3_ListYapilar;


public class ArrayExample
{
    public void Example()
    {
        int[] array = new int[5];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        // array içindeki verileri yazdırma
        foreach (int item in array)
        {
            Console.WriteLine("ArrayExample: "+item);
        }
    }
}


public class ArrayListExample
{
    public void Example()
    {
        ArrayList arrayList = new();
        if (arrayList == null)
        {
            throw new ArgumentNullException(nameof(arrayList));
        }

        arrayList.Add(1);
        arrayList.Add("2");
        arrayList.Add(3.0);

        foreach (var item in arrayList)
        {
            Console.WriteLine("arrayList: "+item);
        }
    }
}

public class HashtableExample
{
    public void Example()
    {


        Hashtable hashtable = new();

        hashtable.Add(1, "1");
        hashtable.Add(2, "2");
        hashtable.Add(3, "3");
        hashtable.Add(4, "4");
        hashtable.Add(5, "5");
        if (hashtable == null)
        {
            throw new ArgumentNullException(nameof(hashtable));
        }

        foreach (var item in hashtable)
        {
            Console.WriteLine("hashtable: "+item);
        }
    }
}

public class QueueExample
{
    public void Example()
    {
        Queue queue = new();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        // Queue'daki öğeleri sırayla çıkararak ekrana yazdırma
        Console.WriteLine("Queue içeriği:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}

public class StackExample
{
    public void Example()
    {
        Stack stack = new();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Stack'teki öğeleri sırayla çıkararak ekrana yazdırma
        Console.WriteLine("Stack içeriği:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}

public class ListExample<T>
{
    public void Example(T value)
    {
        List<T> list = new();

        // Parametre olarak alınan değeri listeye ekleme
        list.Add(value);

        // Ekleme işleminden sonra listenin eleman sayısını ve eklenen değeri yazdıralım
        Console.WriteLine($"Listede {list.Count} eleman var.");
        Console.WriteLine($"Eklenen değer: {value}");
    }
}


public class DictionaryExample<TKey, TValue> where TKey : notnull
{
    public void Example(TKey key, TValue value)
    {
        Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

        // Örnek olarak birkaç öğe ekleyelim
        dictionary.Add(key, value); // Verilen anahtar ve değeri ekleme

        // Ekleme işleminden sonra sözlükteki eleman sayısını ve eklenen değerleri yazdıralım
        Console.WriteLine($"Sözlükte {dictionary.Count} eleman var.");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"Anahtar: {kvp.Key}, Değer: {kvp.Value}");
        }
    }
}

public class SortedListExample<TKey, TValue> where TKey : notnull
{
    public void Example(TKey key, TValue value)
    {
        SortedList<TKey, TValue> sortedList = new SortedList<TKey, TValue>();

        // Örnek olarak birkaç öğe ekleyelim
        sortedList.Add(key, value); // Verilen anahtar ve değeri ekleme

        // Ekleme işleminden sonra sıralı liste içindeki eleman sayısını ve eklenen öğeleri yazdıralım
        Console.WriteLine($"Sıralı listede {sortedList.Count} eleman var.");
        foreach (var kvp in sortedList)
        {
            Console.WriteLine($"Anahtar: {kvp.Key}, Değer: {kvp.Value}");
        }
    }
}

public class QueueGenericExample<T>
{
    public void Example(params T[] elements)
    {
        Queue<T> queue = new Queue<T>();

        // Örnek olarak verilen öğeleri kuyruğa ekleyelim
        foreach (T element in elements)
        {
            queue.Enqueue(element);
        }

        // Ekleme işleminden sonra kuyruktaki eleman sayısını ve eklenen öğeleri yazdıralım
        Console.WriteLine($"Kuyrukta {queue.Count} eleman var.");
        foreach (T element in queue)
        {
            Console.WriteLine(element);
        }
    }
}

public class StackGenericExample<T>
{
    public void Example(params T[] elements)
    {
        Stack<T> stack = new Stack<T>();

        // Örnek olarak verilen öğeleri yığına ekleyelim
        foreach (T element in elements)
        {
            stack.Push(element);
        }

        // Ekleme işleminden sonra yığındaki eleman sayısını ve eklenen öğeleri yazdıralım
        Console.WriteLine($"Yığında {stack.Count} eleman var.");
        foreach (T element in stack)
        {
            Console.WriteLine(element);
        }
    }
}

public class HashSetExample<T>
{
    public void Example(params T[] elements)
    {
        HashSet<T> hashSet = new HashSet<T>();

        // Örnek olarak verilen öğeleri küme olarak ekleyelim
        foreach (T element in elements)
        {
            hashSet.Add(element);
        }

        // Ekleme işleminden sonra kümedeki eleman sayısını ve eklenen öğeleri yazdıralım
        Console.WriteLine($"Kümede {hashSet.Count} eleman var.");
        foreach (T element in hashSet)
        {
            Console.WriteLine(element);
        }
    }
}

public class LinkedListExample<T>
{
    public void Example(params T[] elements)
    {
        LinkedList<T> linkedList = new LinkedList<T>();

        // Örnek olarak verilen öğeleri bağlı liste olarak ekleyelim
        foreach (T element in elements)
        {
            linkedList.AddLast(element);
        }

        // Ekleme işleminden sonra bağlı listedeki elemanları yazdıralım
        Console.WriteLine("Bağlı listedeki elemanlar:");
        foreach (T element in linkedList)
        {
            Console.WriteLine(element);
        }
    }
}

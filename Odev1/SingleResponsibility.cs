namespace Odev1;

public class BookManager
{
    public string Title { get; set; } = default!;
    public string Author { get; set; } = default!;
    public int Quantity { get; set; }

    public void AddBook(string title, string author)
    {
        
    }

    public void UpdateInventory(int quantity)
    {
       
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

public class InventoryManager
{
    private Dictionary<Book, int> _inventory = new Dictionary<Book, int>();

    public void AddBook(Book book, int quantity)
    {
        if (_inventory.ContainsKey(book))
        {
            _inventory[book] += quantity;
        }
        else
        {
            _inventory[book] = quantity;
        }
    }

    public void UpdateInventory(Book book, int quantity)
    {
        if (_inventory.ContainsKey(book))
        {
            _inventory[book] = quantity;
        }
        else
        {
            throw new KeyNotFoundException("Book not found in inventory.");
        }
    }

    public int GetQuantity(Book book)
    {
        return _inventory.ContainsKey(book) ? _inventory[book] : 0;
    }
}
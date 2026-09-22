
// Book book1 = new Book();
// book1.Title = "The Hobbit";
// book1.Author = "J.R.R. Tolkien";
// Console.WriteLine(book1.Title);
Book book2 = new Book("The Hobbit", "J.R.R. Tolkien");
Console.WriteLine(book2.Title);

Book book3 = new Book("Dune", "Frank Herbert");
book2.Title = "The Hobbit - Updated";
book3.PrintSummary();

book2.Pages = 310;
book2.PrintSummary();

class Book
{
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public int Pages { get; set; } = 0;
    //if constructor is not defined, will create default constructor(see book 1 above)
    public Book(string title, string author, int pages = 100)
    {
        this.Title = title;
        this.Author = author;
        this.Pages = pages;
    }
    public void PrintSummary()
    {
        Console.WriteLine($"{Title} by {Author} - length: {Pages} pages");
    }
}

internal class Book:Product
{

    public string genre;

	public Book(string name, int no, int price, string genre) : base(name, no, price)
	{
		this.genre = genre;
	}
}
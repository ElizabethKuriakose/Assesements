
namespace Assessment;

internal class Cloath
{
    public string Stock { get; set; }
    public int Price { get; set; }
    public string Category { get; set; }
	private string _sale;

	public string Sale
	{
		get { return _sale; }
		set { 
			if(Stock == "Old")
				_sale = "Discount";
			else
				_sale = "Normal"; 
		}
	}

	public void Calculate()
	{
		if(Sale == "Discount")
		{
			Price = Price - ((Price * 20) / 100);
		}
		Console.WriteLine();
		Console.WriteLine($"Stock : {Stock}");
		Console.WriteLine($"Price : {Price}");
		Console.WriteLine($"Category: {Category}");
		Console.WriteLine($"Sale    : {Sale}");
	}
}

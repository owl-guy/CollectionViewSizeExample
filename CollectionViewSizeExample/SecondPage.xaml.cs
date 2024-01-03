using System.Diagnostics;

namespace CollectionViewSizeExample;

public partial class SecondPage : ContentPage
{
	public List<string> Items { get; set; }
	public SecondPage()
	{
		InitializeComponent();
		Items = new List<string>();
		for (int i = 0; i < 20; i++)
		{
			Items.Add(i.ToString());	
		}
		BindingContext = this;
	}
}
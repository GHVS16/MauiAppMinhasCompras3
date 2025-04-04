using MauiAppMinhasCompras3.Models;
using System.Threading.Tasks;

namespace MauiAppMinhasCompras3.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_Quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)
			};

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Registro Inserido", "OK");

		} catch(Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "Ok");
		}
    }

  
}
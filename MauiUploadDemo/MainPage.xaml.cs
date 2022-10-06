using SharedBetweenWebApiAndMaui;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace MauiUploadDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var hc = new HttpClient();
		var c = new MultipartFormDataContent();

        var ms = new MemoryStream();
		c.Add(new StreamContent(ms), "filex", "zl.file");

		var metaData = new XXMediaMetaData() { CustomerId = 1, Description = "test"};
        c.Add(new StringContent(JsonSerializer.Serialize(metaData)), "metaData");

		try
		{
			hc.PostAsync("https://localhost:7021/api/FileUpload", c);

		}
		catch (Exception)
		{
		}




	}
}


using Plugin.Maui.Audio;

namespace _001___myFirstMauiAPP;

public partial class MainPage : ContentPage
{
	private readonly IAudioManager audioManager;

	public MainPage(IAudioManager audioManager)
	{
		InitializeComponent();
		this.audioManager = audioManager;
	}

	private async void OnButtonClickedNote1(object sender, EventArgs e)
	{
		var player1 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("key10.wav"));

		player1.Play();
	}

    private async void OnButtonClickedNote2(object sender, EventArgs e)
    {
        var player2 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("key16.wav"));

        player2.Play();
    }

    private async void OnButtonClickedNote3(object sender, EventArgs e)
    {
        var player3 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("key22.wav"));

        player3.Play();
    }
}


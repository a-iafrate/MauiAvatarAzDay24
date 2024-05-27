namespace MauiAvatarAzDay24
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object? sender, EventArgs e)
        {
#if ANDROID
        var androidWebview = webViewAvatar.Handler.PlatformView as Android.Webkit.WebView;
        //androidWebview.Settings.UseWideViewPort = true;
            androidWebview.Settings.MediaPlaybackRequiresUserGesture = false;
            //androidWebview.Settings.LoadWithOverviewMode = true;
#endif
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

           
        }

        private void buttonSpeak_Clicked(object sender, EventArgs e)
        {
            webViewAvatar.EvaluateJavaScriptAsync($"speakMaui('{entrySentence.Text}');");
        }
    }

}

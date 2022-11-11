namespace Maui_test;


public partial class MainPage : ContentPage
{
    private Random rnd = new Random();
    public MainPage()
    {
        InitializeComponent();
    }
    private void ClrChange(object sender, EventArgs e)
    {
        Color randomColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        Color randomColor2 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        Color randomColor3 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        Color randomColor4 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        ClrChangerButton.Background = randomColor;
        textbutton.Background = randomColor;
        Imgbutton.Background = randomColor2;
        Imgbutton2.Background = randomColor3;
    }
    private void Hide(object sender, EventArgs e)
    {
        Imagebot.Opacity = 0;
    }
    private void Show(object sender, EventArgs e)
    {
        Imagebot.Opacity = 1;
    }
    private void Text(object sender, EventArgs e)
    {
        string text = Entry.Text;
        label1.Text = text;
    }
}
    


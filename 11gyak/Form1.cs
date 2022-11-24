using Newtonsoft.Json;

namespace _11gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ////MessageBox.Show("ablak"); ctr+k, cstrl+c    vissza ctrl+k, ctrl+u
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.randomuser.me");
                    var response = await client.GetAsync("https://api.randomuser.me");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawData = JsonConvert.DeserializeObject<Rootobject>(stringResult);
                    nameLabel.Text = String.Join(" ", "Name: ", rawData.results[0].name.title, rawData.results[0].name.first, rawData.results[0].name.last);
                    emailLabel.Text = String.Join(" ", "Email: ", rawData.results[0].email);
                    pictureBox1.Load(rawData.results[0].picture.large.ToString());
                    pictureBox2.Load("https://robohash.org/" + rawData.results[0].name.first);
                    if (rawData.results[0].gender == "female")
                        fRadioButton.Checked = true;
                    else
                        mRadioButton.Checked = true;
                    progressBar1.Value = rawData.results[0].dob.age;
                    
                }

                catch (Exception ex)
                {
                    nameLabel.Text = "wrong name";
                    emailLabel.Text = "";   
                 }
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
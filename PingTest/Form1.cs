using System.Drawing.Imaging;
using System.Net.NetworkInformation;


namespace PingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyVariables.IsStopes = true;
            MyVariables.status = 0;
            MyVariables.Prestatus = 0;
            MyVariables.firsttime = 1;
            btnRun.Text = "Run";
            //lbl_success.Visible=false;
            //lbl_Unsucess.Visible = false;
            lbl_Unsucess.ForeColor = System.Drawing.Color.AntiqueWhite;
            lbl_success.ForeColor = System.Drawing.Color.AntiqueWhite;



        }

        private async void btnRun_Click(object? sender, EventArgs e)
        {


            
                if (MyVariables.IsStopes)
                {
                    MyVariables.IsStopes = false;
                    btnRun.Text = "Stop";

                }
                else
                {
                    MyVariables.IsStopes = true;
                    btnRun.Text = "Run";
                }



                await Task.Run(async () =>
                {
                    while (MyVariables.IsStopes == false)

                    {
                        if (MyVariables.firsttime == 1)
                        {
                            MyVariables.firsttime = 0;
                            
                        }
                        PlayPing();
                        await Task.Delay(10000);

                    }
                    });

            
            
        }

        public async Task PlayPing()
        {
            Ping p = new Ping();
            PingReply r;
            string s;
            //TextBox txtIP = new TextBox();
            s = txtIP.Text;
            r = p.Send(s);
            //Label lblResult= new Label();


            if (r.Status == IPStatus.Success)
            {
                // lbl_success.ForeColor = System.Drawing.Color.Green;
                //await Task.Delay(200);
                //lbl_success.Visible = true;
                //lbl_Unsucess.Visible = false;
                lbl_Unsucess.ForeColor = System.Drawing.Color.AntiqueWhite;
                lbl_success.ForeColor = System.Drawing.Color.Green;


                // lbl_success.Text = "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + "  Successful";
                //lblResult.Text = "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                //                + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"F:\Music\Hatef - Allah Allah To Panahi.mp3");
                //player.Play();
                //await Task.Delay(2000);
            }
            else
           
            {
                
                //lbl_Unsucess.ForeColor = System.Drawing.Color.Red;
                //lbl_success.Visible = false;
                //lbl_Unsucess.Visible = true;
                lbl_Unsucess.ForeColor = System.Drawing.Color.Red;
                lbl_success.ForeColor = System.Drawing.Color.AntiqueWhite;
                //await Task.Delay(200);

                //lbl_Unsucess.Text = "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Failure";
                //await Task.Delay(2000);

            }
        }

        public static class MyVariables
        {
            public static bool IsStopes { get; set; } = false;
            public static int counter { get; set; }
            public static int status { get; set; }
            public static int Prestatus { get; set; }
            public static int firsttime { get; set; }

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
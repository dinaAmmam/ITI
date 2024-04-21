using APPUIConsummer;

namespace lap_consumer
{
    public partial class Form1 : Form
    {
        HttpClient client;

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5019/api/");


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpResponseMessage resp = client.GetAsync("student").Result;
            if (resp.IsSuccessStatusCode)
            {
                List<studentdata> sts = resp.Content.ReadAsAsync<List<studentdata>>().Result;
                dgv_student.DataSource = sts;
            }

            HttpResponseMessage mess = client.GetAsync("departments").Result;
            if (mess.IsSuccessStatusCode)
            {
                List<department> dept = mess.Content.ReadAsAsync<List<department>>().Result;

                cb_depts.DisplayMember = "name";
                cb_depts.ValueMember = "did";
                cb_depts.DataSource = dept;

            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            student s = new student()
            {
                name = txt_name.Text,
                age = int.Parse(txt_age.Text),
                //supervisorName = txt_super.Text,
                deptid = (int)cb_depts.SelectedValue
            };
            HttpResponseMessage mess = client.PostAsJsonAsync("api/student", s).Result;
            if (mess.IsSuccessStatusCode)
            {
                MessageBox.Show("done");
                Form1_Load(null, null);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

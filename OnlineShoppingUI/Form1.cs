namespace OnlineShoppingUI
{
    public partial class Form1 : Form
    {
        private UserHistory userHistory = new UserHistory(); // Global deðiþken

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Uygulama baþladýðýnda veritabanýndan geçmiþi yükle
            UpdateHistoryList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string action = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(action))
            {
                userHistory.AddAction(action);
                UpdateHistoryList();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen bir iþlem girin!");
            }
        }
        private void UpdateHistoryList()
        {
            listBox1.Items.Clear();
            var records = userHistory.GetAllActions();
            foreach (var record in records)
            {
                listBox1.Items.Add(record);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

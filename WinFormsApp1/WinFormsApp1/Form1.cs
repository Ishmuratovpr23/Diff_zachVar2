namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbGrouping.Items.AddRange(new string[] { "���������� ���������� � �����������", "�����������", "������� ����� ���������" });

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                
                var data1 = txtData1.Text.Split(',').Select(int.Parse).ToList();
                var data2 = txtData2.Text.Split(',').Select(int.Parse).ToList();

                // ��������� ���������� �������� �� ComboBox
                string selectedGrouping = cmbGrouping.SelectedItem.ToString();

                // ���������� ����������� ���������� � �����������
                IEnumerable<dynamic> result;

                switch (selectedGrouping)
                {
                    case "���������� ���������� � �����������":
                        result = data1.Join(data2, x => x, y => y, (x, y) => new { Item = x, OtherItem = y })
                                     .GroupBy(item => item.OtherItem).Cast<dynamic>();
                        break;
                    case "�����������":
                        result = data1.Union(data2).Cast<dynamic>();

                        break;
                    case "������� ����� ���������":
                        result = data1.Intersect(data2).Cast<dynamic>();
                        break;
                    default:
                        throw new InvalidOperationException($"����������� �����������: {selectedGrouping}");
                }

                // ����������� ���������� � DataGridView
                dgvResult.DataSource = result.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ������� �����������");
            }

          



        }
    }
}
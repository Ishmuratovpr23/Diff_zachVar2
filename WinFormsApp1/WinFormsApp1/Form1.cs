namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbGrouping.Items.AddRange(new string[] { "Внутреннее соединение и группировка", "Объединение", "Выборка общих элементов" });

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

                // Получение выбранного значения из ComboBox
                string selectedGrouping = cmbGrouping.SelectedItem.ToString();

                // Выполнение внутреннего соединения и группировки
                IEnumerable<dynamic> result;

                switch (selectedGrouping)
                {
                    case "Внутреннее соединение и группировка":
                        result = data1.Join(data2, x => x, y => y, (x, y) => new { Item = x, OtherItem = y })
                                     .GroupBy(item => item.OtherItem).Cast<dynamic>();
                        break;
                    case "Объединение":
                        result = data1.Union(data2).Cast<dynamic>();

                        break;
                    case "Выборка общих элементов":
                        result = data1.Intersect(data2).Cast<dynamic>();
                        break;
                    default:
                        throw new InvalidOperationException($"Неизвестная группировка: {selectedGrouping}");
                }

                // Отображение результата в DataGridView
                dgvResult.DataSource = result.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Данные введены некорректно");
            }

          



        }
    }
}
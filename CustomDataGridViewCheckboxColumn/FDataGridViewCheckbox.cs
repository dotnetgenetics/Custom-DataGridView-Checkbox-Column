using CustomDataGridViewCheckboxColumn.Models;

namespace CustomDataGridViewCheckboxColumn
{
    public partial class FDataGridViewCheckbox : Form
    {
        public FDataGridViewCheckbox()
        {
            InitializeComponent();
        }

        private void FDataGridViewCheckbox_Load(object sender, EventArgs e)
        {
            NorthwindContext context = new NorthwindContext();
            dgData.DataSource = context.Products.Select(x => new
                                {
                                    x.ProductId,
                                    x.ProductName,
                                    x.UnitPrice,
                                    x.Discontinued
                                }).Take(6).ToList();
            }
    }
}

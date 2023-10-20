using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class FormAddProduct : Form
    {
        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        private int _Quantity;
        private double _SellPrice;
        List<object> showProductList;
        public FormAddProduct()
        {
            showProductList = new List<object>();
            InitializeComponent();
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            String[] ListOfProductCategory =
                {
                "Beverages", "Bread/Bakery", "Canned/Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other"
                };

            foreach (var item in ListOfProductCategory)
            {
                cbCategory.Items.Add(item);
            }
        }
        public string Product_Name(string name)
        {
            try
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    throw new StringFormatException("Please Enter a Valid Product Name");
                }
            }
            catch (StringFormatException sfe)
            {
                MessageBox.Show("Strong Format Input in Product Name.");
            }
            finally
            {
                Console.WriteLine("Input string only in product name.");
            }
            return name;
        }
        public int Quantity(string qty)
        {
            try
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                {
                    throw new NumberFormatException("Please Enter a Valid Quantity");
                }
            }
            catch (NumberFormatException nfe)
            {
                MessageBox.Show("Number format input in Quantity!");
            }
            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            try
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                {
                    throw new CurrencyFormatException("Please Enter a Valid Price");
                }
            }
            catch (CurrencyFormatException cfe)
            {
                MessageBox.Show("Currency format input only!");
            }
            return Convert.ToDouble(price);
        }

        class NumberFormatException : Exception
        {
            public NumberFormatException(string varName) : base(varName) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string varName) : base(varName) { }
        }
        class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string varName) : base(varName) { }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _Description = richTextDescription.Text;
            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSsellPrice.Text);
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _Description, _Quantity, _SellPrice));
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;
        }
    }
}
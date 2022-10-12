using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        List<Groceries> groceries = new List<Groceries>();

        public Form1()
        {
            InitializeComponent();
            dataGridView2.ColumnCount = 8;
            dataGridView2.Columns[0].Name = "Name";
            dataGridView2.Columns[1].Name = "Price";
            dataGridView2.Columns[2].Name = "Country of origin";
            dataGridView2.Columns[3].Name = "Packing date";
            dataGridView2.Columns[4].Name = "Details";
            dataGridView2.Columns[5].Name = "Expiration Date";
            dataGridView2.Columns[6].Name = "Quantity";
            dataGridView2.Columns[7].Name = "Unit";

            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Price";
            dataGridView1.Columns[2].Name = "Country of origin";
            dataGridView1.Columns[3].Name = "Packing Date";
            dataGridView1.Columns[4].Name = "Details";
            dataGridView1.Columns[5].Name = "Number of pages";
            dataGridView1.Columns[6].Name = "Publishing house";
            dataGridView1.Columns[7].Name = "Authors";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addData1(toolStripTextBox1.Text);
        }

        private void addData1(string name)
        {
            decimal price = 0;
            string country = "";
            DateTime dataPackage = new DateTime();
            string details = "";
            int quantityPages = 0;
            string publishingHouse = "";
            string authors = "";
            Book book = new Book(name, price, country, dataPackage, details, quantityPages, publishingHouse, authors);
            books.Add(book);
            dataGridView1.Rows.Add(book.Name, book.Price, book.CountryOfOrigin, book.DatePackage, book.Details, book.NumberOfPages, book.PublishingHouse, book.Authors);

        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addData2(toolStripTextBox1.Text);
        }
        private void addData2(string name)
        {
            decimal price = 0;
            string country = "";
            DateTime dataPackage = new DateTime();
            string details = "";
            DateTime expiration = new DateTime();
            int quantity = 0;
            string unit = "";
            Groceries goods = new Groceries(name, price, country, dataPackage, details, expiration, quantity, unit);
            groceries.Add(goods);            
            dataGridView2.Rows.Add(goods.Name, goods.Price, goods.CountryOfOrigin, goods.DatePackage, goods. Details, goods.ExpirationDate, goods.Quantity, goods.Unit);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 || dataGridView2.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                    int i = row.Index + 1;
                    books.Remove(books[i]);
                }
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    dataGridView2.Rows.Remove(row);
                    int i = row.Index + 1;
                    groceries.Remove(groceries[i]);
                }
            }
            else
            {  
                MessageBox.Show("Please select a row");
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs val)
        {
            int column = val.ColumnIndex;
            int row = val.RowIndex;
            if (dataGridView1.Rows[row].Cells[column].IsInEditMode == false) { return; }
            try
            {   switch (column)
                { 

                 case 0: 
                        books[row].Name = val.FormattedValue.ToString();
                        break;
                 case 1: 
                        books[row].Price = Convert.ToDecimal(val.FormattedValue);
                        break;
                 case 2: 
                        books[row].CountryOfOrigin = val.FormattedValue.ToString();
                        break;
                 case 3: 
                        books[row].DatePackage = Convert.ToDateTime(val.FormattedValue);
                        break;
                 case 4: 
                        books[row].Details = val.FormattedValue.ToString();
                        break;
                 case 5: 
                        books[row].NumberOfPages = Convert.ToInt32(val.FormattedValue);
                        break;
                 case 6: 
                        books[row].PublishingHouse = val.FormattedValue.ToString();
                        break;
                 case 7: 
                        books[row].Authors = val.FormattedValue.ToString();
                        break;
                }
            }
            catch (FormatException)
            {
                dataGridView1.CancelEdit();
                MessageBox.Show("Not right format");
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs val)
        {
            
        }

        private void dataGridView2_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs val)
        {
            int col = val.ColumnIndex;
            int row = val.RowIndex;
            if (dataGridView2.Rows[row].Cells[col].IsInEditMode == false) { return; }
            try
            {
                if (col == 0) { groceries[row].Name = val.FormattedValue.ToString(); }
                else if (col == 1) { groceries[row].Price = Convert.ToDecimal(val.FormattedValue); }
                else if (col == 2) { groceries[row].CountryOfOrigin = val.FormattedValue.ToString(); }
                else if (col == 3) { groceries[row].DatePackage = Convert.ToDateTime(val.FormattedValue); }
                else if (col == 4) { groceries[row].Details = val.FormattedValue.ToString(); }
                else if (col == 5) { groceries[row].ExpirationDate = Convert.ToDateTime(val.FormattedValue); }
                else if (col == 6) { groceries[row].Quantity = Convert.ToInt32(val.FormattedValue); }
                else if (col == 7) { groceries[row].Unit = val.FormattedValue.ToString(); }
            }
            catch (FormatException)
            {
                dataGridView2.CancelEdit();
                MessageBox.Show("Not right format");
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

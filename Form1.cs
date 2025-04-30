
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Windows.Forms;

namespace WebScrapingSelenium
{
    public partial class Form1 : Form
    {
        IWebDriver driver;

        // Create a list to store the item details
        List<string[]> items = new List<string[]>();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                driver = new ChromeDriver();

                // Create a list to store the item details
                List<string[]> items = new List<string[]>();

                driver.Navigate().GoToUrl("https://www.ebay.com/");
                var searchBar = driver.FindElement(By.XPath("//*[@id=\"gh-ac\"]"));

                // search item following the text user type in the textbox
                string searchTerm = txtSearch.Text;
                searchBar.SendKeys(searchTerm);
                searchBar.Submit();

                //driver.FindElement(By.XPath("//*[text()='Get started free']"));                
                driver.FindElement(By.XPath("//*[@id=\"gh-search-btn\"]")).Click();


                // Find elements that contain the product details
                IReadOnlyCollection<IWebElement> productElements = driver.FindElements(By.ClassName("srp-items-carousel__list"));


                // Loop through the product elements and extract the desired information
                foreach (IWebElement productElement in productElements)
                {

                    // Extract the name and price of the product
                    string name = productElement.FindElement(By.ClassName("s-item__title")).Text;
                    string price = productElement.FindElement(By.ClassName("s-item__price")).Text;

                    // Add the item details to the list
                    items.Add(new string[] { name, price });

                }

                // show how many item founded
                txtNumOfItem.Text = items.Count.ToString();

                // put data into listview
                PopulateListView(items);

            }
            catch (Exception)
            {
                MessageBox.Show("can not add item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            driver.Quit();
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text) && driver != null)
            {
                driver.Quit();
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset all search recently, empty all textbox
            driver.Quit();
            txtNumOfItem.Clear();
            txtSearch.Clear();
            txtSearch.Focus();

            // Clear existing items
            listView1.Items.Clear();

        }

        // Method to populate ListView
        private void PopulateListView(List<string[]> items)
        {
            // Assuming you have a ListView named listView1 in your form
            // Clear existing items
            listView1.Items.Clear();

            // Configure ListView
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Add columns if not already added
            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("Item Name", 400);
                listView1.Columns.Add("Price", 100);
            }

            // Loop through items and add to ListView
            foreach (string[] item in items)
            {
                ListViewItem listViewItem = new ListViewItem(item[0]); // Name
                listViewItem.SubItems.Add(item[1]); // Price
                listView1.Items.Add(listViewItem);
            }
        }
    }
}


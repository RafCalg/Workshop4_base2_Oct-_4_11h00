using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            packageDataGridView.DataSource = dbContext.Packages;
            packageDataGridView.Sort(packageDataGridView.Columns[0], ListSortDirection.Ascending);
        }

        //Method to trigger the display of the addEditpackage form in add mode
        private void addPackageButton_Click(object sender, EventArgs e)
        {
            AddEditPackageForm addEditForm = new AddEditPackageForm();
            addEditForm.mainForm = this;

            //Shows the Add form
            DialogResult result = addEditForm.ShowDialog();


            if (result == DialogResult.OK) // Save
            {
                //Refresh the Grid View
                //dbContext.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
                //                    dbContext.Products);
                dbContext = new TravelExpertsLINQDataContext();

                packageDataGridView.DataSource = dbContext.Packages;
                
                //Sorts the Package Gridview by package ID
                packageDataGridView.Sort(packageDataGridView.Columns[0], ListSortDirection.Ascending);
                

            }
        }

        //method used to refresh the packages gridview
        private void RefreshGridView()
        {
            TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext();
            packageDataGridView.DataSource = dbContext.Packages;
        }

        //Method used to trigger the display of the addEditpackage form in edit mode
        private void modifyPackageButton_Click(object sender, EventArgs e)
        {

            // get the key of the current package in the data grid view

            // index of the current row
            int rowNum = packageDataGridView.CurrentCell.RowIndex;

            // Column for Package ID
            string packageId = packageDataGridView["dataGridViewTextBoxColumn1", rowNum].Value.ToString();

            // Package details
            Package currentPackage;

            // ProductSupplierId list for current package
            List<Packages_Products_Supplier> currentProdSuppIds = new List<Packages_Products_Supplier>();

            // Product Id and Supplier Id list for current package
            List<Products_Supplier> currentProdAndSupp = new List<Products_Supplier>();

            // Product name (Key) Supplier name (Value)
            List<string> prodList = new List<string>();
            List<string> suppList = new List<string>();




            using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
            {
                // Package table for package details
                currentPackage = (from p in dbContext.Packages
                                  where p.PackageId == int.Parse(packageId)
                                  select p).Single();

                // Packages_Products_Suppliers table for list of ProdSuppId in current package
                currentProdSuppIds = (from ps in dbContext.Packages_Products_Suppliers
                                      where ps.PackageId == int.Parse(packageId)
                                      select ps).ToList();

                // Products_Suppliers table for list of ProductId and SuppId in current package 
                foreach (Packages_Products_Supplier ps in currentProdSuppIds)
                {
                    currentProdAndSupp.Add((from psd in dbContext.Products_Suppliers
                                            where psd.ProductSupplierId == ps.ProductSupplierId
                                            select psd).Single());
                }

                // Products table and Supplier table for product name and supplier name
                foreach (Products_Supplier pas in currentProdAndSupp)
                {
                    prodList.Add((from p in dbContext.Products
                                  where p.ProductId == pas.ProductId
                                  select p.ProdName).Single());

                    suppList.Add((from s in dbContext.Suppliers
                                  where s.SupplierId == pas.SupplierId
                                  select s.SupName).Single());
                }

            }

            AddEditPackageForm modForm = new AddEditPackageForm();
            modForm.isAddMode = false;                  // Modify mode
            modForm.currentPackage = currentPackage;
            modForm.currentProdSuppIds = currentProdSuppIds;
            modForm.currentProdAndSupp = currentProdAndSupp;
            modForm.prodList = prodList;
            modForm.suppList = suppList;

            DialogResult result = modForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
            {
                RefreshGridView();
            }
        }

        //Method to Exit the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Method used to trigger the deletion of a package
        private void deletePackageButton_Click(object sender, EventArgs e)
        {
            bool flag = packageDataGridView.CurrentRow.Selected;
            if (flag)
            {
                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    // index of the current row
                    int row = packageDataGridView.CurrentCell.RowIndex;
                    // Column for Package ID
                    string packageId = packageDataGridView["dataGridViewTextBoxColumn1", row].Value.ToString();
                    string packageName = packageDataGridView["dataGridViewTextBoxColumn2", row].Value.ToString();
                    // Delete from child table


                    DialogResult dr = MessageBox.Show("Are you sure you want to delete the "+ packageName + "package",
                      "Delete Confirmation", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            var pkgProdSupToDelete = dbContext.Packages_Products_Suppliers.Where(r => r.PackageId == int.Parse(packageId));
                            dbContext.Packages_Products_Suppliers.DeleteAllOnSubmit(pkgProdSupToDelete);
                            dbContext.SubmitChanges();
                            // delete from Parent table
                            Package packageToDelete = dbContext.Packages.SingleOrDefault(r => r.PackageId == int.Parse(packageId));
                            dbContext.Packages.DeleteOnSubmit(packageToDelete);
                            dbContext.SubmitChanges();
                            RefreshGridView();
                            break;
                        case DialogResult.No:
                            break;
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        //Method used to trigger the display of the product and suppliers maintenance form
        private void prodSuppMaintButton_Click(object sender, EventArgs e)
        {
            ProdSuppMaintenance maintenanceForm = new ProdSuppMaintenance();
            //maintenanceForm.mainForm = this;

            //Shows the Add form
            DialogResult result = maintenanceForm.ShowDialog();


            if (result == DialogResult.OK) // Refresh
            {
                //Refresh the Grid View
                //dbContext.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
                //                    dbContext.Products);
                dbContext = new TravelExpertsLINQDataContext();

                packageDataGridView.DataSource = dbContext.Packages;

            }
        }
    }
}

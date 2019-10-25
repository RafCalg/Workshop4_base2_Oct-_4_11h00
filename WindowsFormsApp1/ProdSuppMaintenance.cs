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
    public partial class ProdSuppMaintenance : Form
    {
        
        //public string supToEdit;
        //public bool supEditMode = false;
        //public bool supAddMode = false;

        public ProdSuppMaintenance()
        {
            InitializeComponent();
        }


        //Initial setup of the form at load
        private void ProdSuppMaintenance_Load(object sender, EventArgs e)
        {
            prodComboBox.SelectedIndex = -1;
            LoadMaintenanceCombos();

        }

        //Method used to set up the product and supplier combbox at form loading
        public void LoadMaintenanceCombos()
        {
            using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
            {
                var listProducts = (from x in dbContext.Products select x).ToList();

                //Populate the Product List ComboBox
                prodComboBox.DataSource = listProducts;
                prodComboBox.ValueMember = "ProductID";
                prodComboBox.DisplayMember = "ProdName";

                //Populate the Supplier List Combo Box
                int selectedId = prodComboBox.SelectedIndex + 1;

                var listSuppliers = (from x in dbContext.Suppliers select x).ToList();

                supComboSelection(dbContext, selectedId);
            }

        }

        //Method to used to change combobox suppliers based on the selected product
        private void prodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
            {

                //int selectedId = (int)(prodComboBox.SelectedValue);
                //MessageBox.Show("Selected ID" + selectedId);
                //supComboSelection(dbContext, selectedId);
                int selectedID;
                if (prodComboBox.SelectedIndex > 0)
                {
                    string selectedProd = prodComboBox.Text;

                    var ProdId = (from prod in dbContext.Products
                                  where (prod.ProdName == selectedProd)
                                  select new
                                  {
                                      productId = prod.ProductId
                                  }).Take(1);


                    //Transforms the pkg 
                    selectedID = ProdId.FirstOrDefault().productId;
                }
                else if (prodComboBox.SelectedIndex == 0)
                {
                    selectedID = 1;
                }
                else
                {
                    return;
                }

                    supComboSelection(dbContext, selectedID);
            }   
        }

        //Method used to select the suppliers
        private void supComboSelection(TravelExpertsLINQDataContext dbContext, int selectedId)
        {
                var productSuppliers = (from prod in dbContext.Products
                                        join prodSup in dbContext.Products_Suppliers
                                        on prod.ProductId equals prodSup.ProductId
                                        join sup in dbContext.Suppliers
                                        on prodSup.SupplierId equals sup.SupplierId
                                        where prod.ProductId == selectedId
                                        orderby sup.SupName
                                        select new
                                        {
                                            supplierId = sup.SupplierId,
                                            supName = sup.SupName
                                        }).ToList();

                supComboBox.DataSource = productSuppliers;
                supComboBox.DisplayMember = "SupName";
                supComboBox.ValueMember = "SupplierId";
        }

        //Method used to display the add edit supplier form in supplier add mode
        private void suppAddButton_Click(object sender, EventArgs e)
        {
            AddEditSupplier aesForm = new AddEditSupplier();
            aesForm.supAddMode = true;
            aesForm.prodValue = (int)prodComboBox.SelectedValue;


            //Shows the AddEditSupplier form
            DialogResult result = aesForm.ShowDialog();


            if (result == DialogResult.OK) // Save
            {
                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    supComboBox.DataSource = dbContext.Suppliers;
                    prodComboBox.DataSource = dbContext.Products;
                    prodComboBox.SelectedIndex = 0;
                }
                                
            }
        }

        //Method used to display the add edit supplier form in supplier edit mode
        private void suppEditButton_Click(object sender, EventArgs e)
        {
            AddEditSupplier aesForm = new AddEditSupplier();
            aesForm.supToEdit = supComboBox.Text;
            aesForm.supEditMode = true;

            //supToEdit = supComboBox.Text;

            DialogResult result = aesForm.ShowDialog();

            if (result == DialogResult.OK) // Save
            {
                //Refresh the Grid View
                //dbContext.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
                //                    dbContext.Products);
                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    supComboBox.DataSource = dbContext.Suppliers;
                    prodComboBox.SelectedIndex = 0;
                }
            }
        }

        //Method used to display the add edit supplier form in product add mode
        private void prodAddButton_Click(object sender, EventArgs e)
        {
            AddEditSupplier aesForm = new AddEditSupplier();
            //Sets the Add mode to true
            aesForm.prodAddMode = true;
            

            //Shows the AddEditSupplier form
            DialogResult result = aesForm.ShowDialog();


            if (result == DialogResult.OK) // Save
            {
                //Refresh the Grid View
                //dbContext.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
                //                    dbContext.Products);
                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    prodComboBox.DataSource = dbContext.Products;
                }

            }
        }

        //Method used to display the add edit supplier form in product edit mode
        private void prodEditButton_Click(object sender, EventArgs e)
        {
            AddEditSupplier aesForm = new AddEditSupplier();
            //Sets the Add mode to true
            aesForm.prodEditMode = true;
            aesForm.prodToEdit = prodComboBox.Text;

            //Shows the AddEditSupplier form
            DialogResult result = aesForm.ShowDialog();


            if (result == DialogResult.OK) // Save
            {
                //Refresh the Grid View
                //dbContext.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,
                //                    dbContext.Products);
                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    prodComboBox.DataSource = dbContext.Products;
                }

            }
        }

        //Okay button to close the dialog
        private void oKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

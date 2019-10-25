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
    public partial class AddEditSupplier : Form
    {
        //Supplier public variables
        public bool supEditMode; //True if we are in Edit Supplier Mode
        public bool supAddMode; // True if we are in Add Supplier Mode

        public int prodValue;     //Product corresponding to supplier to add 
        public string supToEdit;  //supplier name to Edit
        
        //Product public +variables
        public bool prodEditMode; //True if we are in Edit Supplier Mode
        public bool prodAddMode; // True if we are in Add Supplier Mode

        public string prodToEdit;//The value of the current product

        public AddEditSupplier()
        {
            InitializeComponent();
        }

        //Set up of the form based on Edit or Add mode for products and suppliers
        private void AddEditSupplier_Load(object sender, EventArgs e)
        {
            
            if (supEditMode)
            {
                newSuppIDLabel.Visible = false;
                newSuppIDTextBox.Visible = false;
                newSuppTextBox.Text = supToEdit;
                addSuppLierButton.Text = "Edit Supplier";
            }
            else if (supAddMode)
            {
                newSuppIDLabel.Text = "New Supplier ID";
                addSuppLierButton.Text = "Add Supplier";
            }
            else if(prodEditMode)
            {
                newSuppIDLabel.Visible = false;
                newSuppIDTextBox.Visible = false;
                newSuppTextBox.Text = prodToEdit;
                newSuppLabel.Text = "Product";
                addSuppLierButton.Text = "Edit Product";
            }
            else if (prodAddMode)
            {
                newSuppIDLabel.Visible = false;
                newSuppIDTextBox.Visible = false;
                newSuppLabel.Text = "Product";
                addSuppLierButton.Text = "Add Product";
            }
        }
        //Method to add / Edit supplier or product based on the mode 
        private void addSuppLierButton_Click(object sender, EventArgs e)
        {
            if (supEditMode)
            {
                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    Supplier supEdit = (from sup in dbContext.Suppliers
                                        where (sup.SupName == supToEdit)
                                        select sup).SingleOrDefault();

                    string suppName = newSuppTextBox.Text;

                    if(suppName != "" && suppName != supEdit.SupName)
                    {
                        supEdit.SupName = newSuppTextBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("Supplier name cannot be empty and needs to be updated for edit");
                        return;
                    }
                    

                    try
                    {
                        dbContext.SubmitChanges();
                        MessageBox.Show("Edited supplier saved to the List of of Suppliers");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);

                    }

                }
            }
            else if(supAddMode)
            {
                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    Supplier supp = new Supplier();

                    string suppID = newSuppIDTextBox.Text;
                    string suppName = newSuppTextBox.Text;
                    //Attempt to validate 
                    if (suppID != "" && suppName != "")
                    {
                        int suppIDValue = Convert.ToInt32(newSuppIDTextBox.Text);
                        supp.SupplierId = suppIDValue;
                        supp.SupName = suppName;
                        
                    }
                    else
                    {
                        MessageBox.Show("You need to enter a Supplier Name and ID");
                        return;
                    }
                    dbContext.Suppliers.InsertOnSubmit(supp);

                    try
                    {
                        dbContext.SubmitChanges();
                        MessageBox.Show("Supplier Succesfuly Added to the List of of Suppliers");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                        return;
                    }

                    //Altering the Product_Supplier Database

                    Products_Supplier prodSup = new Products_Supplier();
                    String prodSupID = newSuppIDTextBox.Text;
                    int prodSuppIDValue = Convert.ToInt32(newSuppIDTextBox.Text);

                    //Attempt to validate 
                    if (prodSupID != "")
                    {
                        prodSup.SupplierId = supp.SupplierId;
                        prodSup.ProductId = prodValue;
                    }
                    else
                    {
                        MessageBox.Show("You need to enter a valid Product Id");
                        return;
                    }

                    dbContext.Products_Suppliers.InsertOnSubmit(prodSup);

                    try
                    {
                        
                        dbContext.SubmitChanges();
                        MessageBox.Show("Succesfuly updated the Product Suppliers Table");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
            }
            else if (prodEditMode)
            {
                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    Product prodEdit = (from prod in dbContext.Products
                                        where (prod.ProdName == prodToEdit)
                                        select prod).SingleOrDefault();

                    string prodEditName = newSuppTextBox.Text;

                    if(prodEditName != "" && prodEditName != prodEdit.ProdName)
                    {
                        prodEdit.ProdName = prodEditName;
                    }
                    else
                    {
                        MessageBox.Show("Product name cannot be empty and needs to be updated for edit");
                        return;
                    }
                    
                    try
                    {
                        dbContext.SubmitChanges();
                        MessageBox.Show("Product Succesfuly Edited");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                        return;
                    }

                }
            }
            else if (prodAddMode)
            {
                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    Product prod = new Product();
                    string prodName = newSuppTextBox.Text;
                    
                    //Attempt to validate 
                    if (prodName != "")
                    {
                        prod.ProdName = prodName;
                    }
                    else
                    {
                        MessageBox.Show("You need to enter a valid Product Name");
                        return;
                    }
                    dbContext.Products.InsertOnSubmit(prod);
                    try
                    {
                        dbContext.SubmitChanges();
                        MessageBox.Show("Product Succesfuly Added to the List of of Products");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);

                    }
                }
            }
        }

        private void newSuppIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Okay button
        private void oKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

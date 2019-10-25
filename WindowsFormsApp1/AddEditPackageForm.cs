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
    public partial class AddEditPackageForm : Form
    {

        /* for modify*/
        public Package currentPackage;                              // current package table,set in main form
        public bool isAddMode = true;                               // 0 - modify, 1 - add, set in main form
        public bool isAddProSupp = true;                            // 0 - delete product-supply, 1 - add product-supply
        public int delProSupNum = -1;                               // selected product-supply to be deleted

        // current product&supplier list, set in main form
        public List<Packages_Products_Supplier> currentProdSuppIds = new List<Packages_Products_Supplier>();
        public List<Products_Supplier> currentProdAndSupp = new List<Products_Supplier>();
        public List<string> prodList = new List<string>();              // product list in the database
        public List<string> suppList = new List<string>();              // supplier list in the database
        public List<string> pkgProdSuppList = new List<string>();       // 
        public List<string> addProdList = new List<string>();           // product list in the memory
        public List<string> addSuppList = new List<string>();           // supplier list in the memory
        public List<int> addPkgProdSuppList = new List<int>();          // 

        // pruduct list and supplier list
        Dictionary<int, string> productDict = new Dictionary<int, string>();
        Dictionary<int, string> supplierDict = new Dictionary<int, string>();


        // for add
        public MainForm mainForm; //Declares the Mainform as a public object
        private List<int> prdList = new List<int>(); // Used to store the list of selected products Id's
        private List<int> suplList = new List<int>(); // Used to store the list of selected suppliers Id's


        public AddEditPackageForm()
        {
            InitializeComponent();
        }

        //Set up of the form at load
        private void AddEditPackageForm_Load(object sender, EventArgs e)
        {
            // load combobox
            LoadCombos();

            if (isAddMode) // Add mode
            {
                pkgNameTextBox.Focus(); // focus of the first text box

            }
            else // Modify mode
            {
                // display current packages
                DisplayCurrentPackage();

                // display current products and suppliers related to current package
                DisplayCurrentProdSupp();
            }
        }

        //Method used to load the combo boxes 
        private void LoadCombos()
        {
            if (isAddMode) // Add mode
            {
                TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext();
                var listProducts = (from x in dbContext.Products select x).ToList();

                                                                   
                                     

                //Populate the Product List ComboBox
                prodNameComboBox.DataSource = listProducts;
                prodNameComboBox.ValueMember = "ProductID";
                prodNameComboBox.DisplayMember = "ProdName";
                prodNameComboBox.SelectedIndex = -1;

                //Populate the Supplier List Combo Box
                var listSuppliers = (from x in dbContext.Suppliers select x).ToList();
                supNameComboBox.DataSource = listSuppliers;
                supNameComboBox.ValueMember = "SupplierId";
                supNameComboBox.DisplayMember = "SupName";
                supNameComboBox.SelectedIndex = -1;
            }
            else
            {
                loadProductsCombo();
                loadSuppliersCombo();
            }
        }

        //Method to load the suppliers combos
        private void loadSuppliersCombo()
        {
            List<int> ids = new List<int>();
            List<string> names = new List<string>();

            // create product dictionary
            using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
            {
                // get 
                ids = (from prod in dbContext.Products select prod.ProductId).ToList();
                names = (from prod in dbContext.Products select prod.ProdName).ToList();
            }

            // create dictionary
            for (int i = 0; i < ids.Count; i++)
            {
                productDict.Add(ids[i], names[i]);
                prodNameComboBox.Items.Add(names[i]);
            }

        }

        // Method  used to load the products Combo Box
        private void loadProductsCombo()
        {

            List<int> ids = new List<int>();
            List<string> names = new List<string>();

            // create supplier dictionary
            using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
            {

                ids = (from supp in dbContext.Suppliers select supp.SupplierId).ToList();
                names = (from supp in dbContext.Suppliers select supp.SupName).ToList();
            }

            // create dictionary
            for (int i = 0; i < ids.Count; i++)
            {
                supplierDict.Add(ids[i], names[i]);
                supNameComboBox.Items.Add(names[i]);
            }
        }

        //Method used to display the the current products
        private void DisplayCurrentProdSupp()
        {

            for (int i = 0; i < prodList.Count; i++)
            {
                prodSuppListBox.Items.Add(prodList[i]
                                        + " " + suppList[i]);
            }
        }

        //Method to display the current package in the Edit Mode
        private void DisplayCurrentPackage()
        {
            // display current package items
            pkgNameTextBox.Text = currentPackage.PkgName;
            pkgStartDateDateTimePicker.Value = (DateTime)currentPackage.PkgStartDate;
            pkgEndDateDateTimePicker.Value = (DateTime)currentPackage.PkgEndDate;
            pkgBasePriceTextBox.Text = currentPackage.PkgBasePrice.ToString("0.00");
            decimal commission = (decimal)currentPackage.PkgAgencyCommission;
            pkgAgencyCommissionTextBox.Text = commission.ToString("0.00");
            pkgDescTextBox.Text = currentPackage.PkgDesc;
        }

        //Method used to handle the change of product in the combobox
        private void prodNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // clear all the preloaded suppliers list
            // it will be assigned new values based on which product the 
            // client selected

            if (isAddMode) // Add mode
            {
                int selectedId;

                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    if (prodNameComboBox.SelectedIndex > 0)
                    {
                        string selectedProd = prodNameComboBox.Text;

                        var ProdId = (from prod in dbContext.Products
                                      where (prod.ProdName == selectedProd)
                                      select new
                                      {
                                          productId = prod.ProductId
                                      }).Take(1);


                        //Transforms the pkg 
                        selectedId = ProdId.FirstOrDefault().productId;

                     }
                    else if(prodNameComboBox.SelectedIndex == 0)
                    {
                        selectedId = 1;
                    }
                    else
                    {
                        return;
                    }
                    var listSuppliers = (from x in dbContext.Suppliers select x).ToList();


                    var productSuppliers = (from prod in dbContext.Products
                                            join prodSup in dbContext.Products_Suppliers
                                            on prod.ProductId equals prodSup.ProductId
                                            join sup in dbContext.Suppliers
                                            on prodSup.SupplierId equals sup.SupplierId
                                            where prod.ProductId == selectedId
                                            select new
                                            {
                                                supplierId = sup.SupplierId,
                                                supName = sup.SupName
                                            }).ToList();

                    supNameComboBox.DataSource = productSuppliers;
                    supNameComboBox.DisplayMember = "SupName";
                    supNameComboBox.ValueMember = "SupplierId";
                }
            }
            else
            {
                string selectedProduct = prodNameComboBox.SelectedItem.ToString();
                int productId; // local variable to store the selected product's id

                // retrieve the selected product's id
                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    productId = dbContext.Products.Single(product => product.ProdName == selectedProduct).ProductId;


                    var productSuppliers = (from prod in dbContext.Products
                                            join prodSup in dbContext.Products_Suppliers
                                            on prod.ProductId equals prodSup.ProductId
                                            join sup in dbContext.Suppliers
                                            on prodSup.SupplierId equals sup.SupplierId
                                            where prod.ProductId == productId
                                            select new
                                            {
                                                supplierId = sup.SupplierId,
                                                supName = sup.SupName
                                            }).ToList();

                    supNameComboBox.Items.Clear();
                    for (int i = 0; i < productSuppliers.Count; i++)
                    {
                        supNameComboBox.Items.Add(productSuppliers[i].supName);
                    }
                }
            }
        }

        //Method used to clear all the text boxes and listbox of the form
        private void clearButton_Click(object sender, EventArgs e)
        {

            // clear package information - We have to discuss this one there must be a difference between add and Edit.
            pkgNameTextBox.Text = "";
            pkgStartDateDateTimePicker.ResetText();
            pkgEndDateDateTimePicker.ResetText();
            pkgBasePriceTextBox.Text = "";
            pkgAgencyCommissionTextBox.Text = "";
            pkgDescTextBox.Text = "";

            // clear list box information
            prodSuppListBox.Items.Clear();

        }

        //Method used to add a product and supplier in the list box
        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (prodNameComboBox.SelectedItem == null || supNameComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select one product and supplier");
                return;
            }

            if (isAddMode) // Add mode
            {
                TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext();
                int prd = (int)prodNameComboBox.SelectedValue;

                prdList.Add(prd); // Stores the selected product in a list

                var prodNameList = (from prod in dbContext.Products
                                    where prod.ProductId == prd
                                    select new
                                    {
                                        name = prod.ProdName
                                    }).ToList();
                string prodName = prodNameList[0].name;


                int supl = (int)supNameComboBox.SelectedValue;
                suplList.Add(supl);

                var suppNameList = (from sup in dbContext.Suppliers
                                    where sup.SupplierId == supl
                                    select new
                                    {
                                        name = sup.SupName
                                    }).ToList();

                string suppName = suppNameList[0].name;

                string item = prodName + " | " + suppName;
                prodSuppListBox.Items.Add(item);
            }
            else
            {
                // get product ame and supplier ID by product name and supplier name
                addProdList.Add(prodNameComboBox.SelectedItem.ToString());
                addSuppList.Add(supNameComboBox.SelectedItem.ToString());

                // add to list box 
                prodSuppListBox.Items.Add(prodNameComboBox.SelectedItem.ToString()
                                            + " " + supNameComboBox.SelectedItem.ToString());
            }
        }

        //Method used to save the new package in the dabase depending on whether
        // the package is new or just edited
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            // clear error text
            clearErrorText();

            // validations
            if (!validations())
                return;

            if (isAddMode) //replace true with data validation
            {
                //Create new Package with data from texctboxes
                Package newPackage = new Package
                {
                    PkgName = pkgNameTextBox.Text,
                    PkgStartDate = Convert.ToDateTime(pkgStartDateDateTimePicker.Text),
                    PkgEndDate = Convert.ToDateTime(pkgEndDateDateTimePicker.Text),
                    PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text),
                    PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text),
                    PkgDesc = pkgDescTextBox.Text
                };

                //used dbContext from the main form to insert new product
                mainForm.dbContext.Packages.InsertOnSubmit(newPackage);
                mainForm.dbContext.SubmitChanges();
                
                List<int> prodSuppIdList = new List<int>();

                using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                {
                    int i = 0;
                    foreach (int item in prdList)
                    {
                        ////Adds a new Product_Supplier object in the Product_Supplier Table
                        //Products_Supplier newProdSuppliers = new Products_Supplier();
                        //newProdSuppliers.ProductId = prdList[i];
                        //newProdSuppliers.SupplierId = suplList[i];
                        int productID = prdList[i];
                        int supplierID = suplList[i];

                        var pkgProdSuppId = (from prodSup in dbContext.Products_Suppliers
                                             where (prodSup.ProductId == prdList[i]
                                                     && prodSup.SupplierId == suplList[i])
                                             select new
                                             {
                                                 productSupplierId = prodSup.ProductSupplierId
                                             }).Take(1);


                        //Transforms the pkg 
                        int Id = pkgProdSuppId.FirstOrDefault().productSupplierId;

                        //Gets the Product Supplier Id that was just created after the Insertion
                        //prodSuplList.Add(newProdSuppliers.ProductSupplierId);

                        //Adds a new Product_Supplier object in the Product_Supplier Table
                        Packages_Products_Supplier newPkgProdSupplier = new Packages_Products_Supplier();
                        newPkgProdSupplier.PackageId = newPackage.PackageId;
                        newPkgProdSupplier.ProductSupplierId = Id;

                        mainForm.dbContext.Packages_Products_Suppliers.InsertOnSubmit(newPkgProdSupplier);
                        mainForm.dbContext.SubmitChanges();
                        i++;
                    }
                    MessageBox.Show("Package Successuly Added to the List");
                }

                DialogResult = DialogResult.OK;
            }

            else
            {
                // check it is add or delete product/supply
                if (isAddProSupp)
                {
                    try
                    {
                        // write to Products_Suppliers table and get last number
                        for (int cnt = 0; cnt < addProdList.Count; cnt++)
                        {
                            string selProdName =addProdList[cnt];
                            string selSuppName = addSuppList[cnt];

                            using  (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                            {
                                var productId = (from prod in dbContext.Products
                                                 where prod.ProdName == selProdName
                                                 select new
                                                 {
                                                     prodId = prod.ProductId
                                                 }).Take(1);

                                //selected Product Id
                                int selProdId = productId.FirstOrDefault().prodId;

                                //Search for the supplier ID
                                var supplierId = (from sup in dbContext.Suppliers
                                                 where sup.SupName == selSuppName
                                                 select new
                                                 {
                                                     suppId = sup.SupplierId
                                                 }).Take(1);
                                int selSuppId = supplierId.FirstOrDefault().suppId;

                            

                            //Products_Supplier modProdSup = new Products_Supplier // create product using provided data
                            //{

                            //    ProductId = productDict.FirstOrDefault(x => x.Value == addProdList[cnt]).Key,
                            //    SupplierId = supplierDict.FirstOrDefault(x => x.Value == addSuppList[cnt]).Key,
                            //};


                                // find ProductSupplierId in Products_Suppliers table
                                var pkgProdSuppId = (from prodSup in dbContext.Products_Suppliers
                                                     where (prodSup.ProductId == selProdId
                                                             && prodSup.SupplierId == selSuppId)
                                                     select new
                                                     {
                                                         productSupplierId = prodSup.ProductSupplierId
                                                     }).Take(1);

                                //Transforms the pkg 
                                addPkgProdSuppList.Add(pkgProdSuppId.FirstOrDefault().productSupplierId); //get Products_Supplier table index

                            }
                        }

                        // copy addProdList and addSuppList to prodList and suppList, 
                        // then clear addProdList and addSuppList for next add
                        prodList.AddRange(addProdList);
                        suppList.AddRange(addSuppList);

                        // update package table
                        using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                        {
                            Package modPackage = dbContext.Packages.Single(u => u.PackageId == currentPackage.PackageId);


                            modPackage.PkgName = pkgNameTextBox.Text;
                            modPackage.PkgDesc = pkgDescTextBox.Text;
                            modPackage.PkgStartDate = pkgStartDateDateTimePicker.Value;
                            modPackage.PkgEndDate = pkgEndDateDateTimePicker.Value;
                            modPackage.PkgBasePrice = decimal.Parse(pkgBasePriceTextBox.Text);
                            modPackage.PkgAgencyCommission = decimal.Parse(pkgAgencyCommissionTextBox.Text);

                            dbContext.SubmitChanges(); // submit to the database
                        }

                        // write to Packages_Products_Suppliers table
                        // get the package id 

                        for (int cnt = 0; cnt < addPkgProdSuppList.Count; cnt++)
                        {
                            Packages_Products_Supplier modPkgProdSup = new Packages_Products_Supplier // create product using provided data
                            {

                                PackageId = currentPackage.PackageId,
                                ProductSupplierId = addPkgProdSuppList[cnt],
                            };
                            using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                            {
                                // insert through data context object from the main form
                                dbContext.Packages_Products_Suppliers.InsertOnSubmit(modPkgProdSup);
                                dbContext.SubmitChanges(); // submit to the database
                            }
                        }
                        // write to Packages table
                    }
                    catch (Exception excp)
                    {
                        MessageBox.Show($"saving error when add product-supply. {excp.Message}");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        // create delete 
                        // write to Products_Suppliers table and get last number

                        int test = delProSupNum;
                        string selProdName = prodList[delProSupNum];
                        string selSuppName = suppList[delProSupNum];



                        using (TravelExpertsLINQDataContext dbContext = new TravelExpertsLINQDataContext())
                        {
                            var productId = (from prod in dbContext.Products
                                             where prod.ProdName == selProdName
                                             select new
                                             {
                                                 prodId = prod.ProductId
                                             }).Take(1);

                            //selected Product Id
                            int selProdId = productId.FirstOrDefault().prodId;

                            //Search for the supplier ID
                            var supplierId = (from sup in dbContext.Suppliers
                                              where sup.SupName == selSuppName
                                              select new
                                              {
                                                  suppId = sup.SupplierId
                                              }).Take(1);
                            int selSuppId = supplierId.FirstOrDefault().suppId;

                            // get ProductSupplierId in Product_Supply table

                            Products_Supplier modProdSup = new Products_Supplier // create product using provided data
                            {

                                ProductId = selProdId,
                                SupplierId = selSuppId,
                            };



                            var id = (from pps in dbContext.Packages_Products_Suppliers
                                      join i in (from ps in dbContext.Products_Suppliers
                                                 where ps.ProductId == selProdId && ps.SupplierId == selSuppId
                                                 select ps)
                                      on pps.ProductSupplierId equals i.ProductSupplierId
                                      where pps.PackageId == currentPackage.PackageId
                                      select pps).Single();


                            // delete data in Packages_Products_Suppliers table
                            dbContext.Packages_Products_Suppliers.DeleteOnSubmit(id);

                            // delete data in Products_Suppliers table
                            //dbContext.Products_Suppliers.DeleteOnSubmit(modProdSup);

                            dbContext.SubmitChanges(); // submit to the database
                            addPkgProdSuppList.Add(modProdSup.ProductSupplierId); //get Products_Supplier table index
                        }

                        // remove from original list
                        prodList.RemoveAt(delProSupNum);
                        suppList.RemoveAt(delProSupNum);
                    }
                    catch (Exception excp)
                    {
                        MessageBox.Show($"saving error when remove product-supply. {excp.Message}");
                        return;
                    }
                }

                // comfirmation box
                if (DialogResult.OK == MessageBox.Show($"The Package has been successfully modified, Thank you!",
                                                        "Confirmation",
                                                        MessageBoxButtons.OK))
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        //Method used to clear the error messages
        private void clearErrorText()
        {
            pkgErrorMessage.Text = "";
            pkgStartDateErrorMessage.Text = "";
            pkgEndDateErrorMessage.Text = "";
            pkgBasePriceErrorMessage.Text = "";
            pkgCommissionErrorMessage.Text = "";
            pkgDescripErrorMessage.Text = "";
            prodSuppListErrorMessage.Text = "";
        }

        //Method used to validate the package entries
        private bool validations()
        {
            // instance of Validation class
            ValdationClass vc = new ValdationClass();
            decimal basePrice;
            decimal commission;

            bool bitValid = true;

            // Form validations
            // package name validation, not null
            if (pkgNameTextBox.Text == "")
            {
                pkgErrorMessage.Text = "Package Name is required";
                bitValid = false;
                return bitValid;
            }

            // start date validation, not null
            if (pkgStartDateDateTimePicker.Value == null)
            {
                pkgStartDateErrorMessage.Text = "Start date is required";
                bitValid = false;
                return bitValid;
            }

            // end date validation, not null
            if (pkgEndDateDateTimePicker.Value == null)
            {
                pkgEndDateErrorMessage.Text = "End date is required";
                bitValid = false;
                return bitValid;
            }

            // package end date > package start date
            if (!vc.isValidEndDate(pkgStartDateDateTimePicker.Value, pkgEndDateDateTimePicker.Value))
            {
                pkgEndDateErrorMessage.Text = "Package end date must be greater than package start date";
                bitValid = false;
                return bitValid;
            }

            // base price validation, not null and is number
            if (pkgBasePriceTextBox.Text == "")
            {
                pkgBasePriceErrorMessage.Text = "Base price is required";
                bitValid = false;
                return bitValid;
            }
            else
            {
                basePrice = decimal.Parse(pkgBasePriceTextBox.Text.ToString());
                try
                {
                    decimal.TryParse(pkgBasePriceTextBox.Text.Trim(), out basePrice);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            // base price validation , greater than 0
            if (!vc.isValidBasePrice(basePrice))
            {
                pkgBasePriceErrorMessage.Text = "Base price should be greater than 0";
                bitValid = false;
                return bitValid;
            }

            // commission validation, not null and is number
            if (pkgAgencyCommissionTextBox.Text == "")
            {
                pkgCommissionErrorMessage.Text = "Commission is required";
                bitValid = false;
                return bitValid;
            }
            else
            {
                commission = decimal.Parse(pkgAgencyCommissionTextBox.Text.ToString());
                try
                {
                    decimal.TryParse(pkgAgencyCommissionTextBox.Text.Trim(), out commission);
                }
                catch (Exception ex)
                {
                    //throw new Exception(ex.Message);
                    pkgAgencyCommissionTextBox.Text = ex.Message;
                }
            }

            // agency commission  >  base price validation
            if (!vc.isValidAgencyCommission(basePrice, commission))
            {
                pkgCommissionErrorMessage.Text = "Agency Commission cannot be greater than the Base price";
                bitValid = false;
                return bitValid;
            }

            // package description validation, not null
            if (pkgDescTextBox.Text == "")
            {
                pkgDescripErrorMessage.Text = "Description is required";
                bitValid = false;
                return bitValid;
            }

            // prodSuppListBox validation, at least one item
            if (prodSuppListBox.Items.Count == 0)
            {
                prodSuppListErrorMessage.Text = "At least one product and supplier have to be selected";
                bitValid = false;
                return bitValid;
            }

            return bitValid;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void delectProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int itemNum;

            if (isAddMode) // Add mode
            {


            }
            else // Modify mode
            {
                // get the selected item number
                itemNum = (int)prodSuppListBox.SelectedIndex;
                if (itemNum < 0)
                {
                    MessageBox.Show("Pease select one item!");
                    return;
                }

                // get the number total number in database
                int len = prodList.Count;

                // check if it is new added or exist in database
                if (itemNum > (len-1))
                {
                    isAddProSupp = true;
                    // remove from addlist
                    addProdList.RemoveAt(itemNum-len);
                    addSuppList.RemoveAt(itemNum-len);
                }
                else
                {
                    isAddProSupp = false;
                    delProSupNum = itemNum;
                }

                // remove from list box 
                prodSuppListBox.Items.Remove(prodSuppListBox.SelectedItem);
            }
        }


    }
}

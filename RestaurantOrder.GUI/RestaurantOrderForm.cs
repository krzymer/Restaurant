using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestaurantOrder.Data;
using RestaurantOrder.Model;
using System.Reflection;
using System.Net.Mail;

namespace RestaurantOrder.GUI
{
    public partial class RestaurantOrderForm : Form
    {
        private ApplicationUnitOfWork _unit;
        private IEnumerable<RestaurantOrder.Model.Menu> _menuItemsRepository;
        private MealAbstract _mealAbstract;
        private List<Model.Menu> _menuMeals;
        private List<Model.Menu> _menuMealsOrder;
        private List<Model.Menu> _menuMealsTmp;
        private bool _firstLoad; 


        public RestaurantOrderForm()
        {
            InitializeComponent();

            PopulateDefaultVariables();
            PopulateDefaoultControlsStates();
            PopulateDefaultData();
        }


        /// <summary>
        /// Metoda tworzy domyślne instancje zmiennych
        /// </summary>
        private void PopulateDefaultVariables()
        {
            this._unit = new ApplicationUnitOfWork();
            this._menuMeals = new List<Model.Menu>();
            this._menuMealsOrder = new List<Model.Menu>();
            this._menuMealsTmp = new List<Model.Menu>();
            this._menuItemsRepository = this._unit.Menus.GetAll();
            this._firstLoad = true;

            this._mealAbstract = new BaseMeal();
        }


        /// <summary>
        /// Metoda inicjalizuje danymi kontrolki po uruchomieniu aplikacji
        /// </summary>
        private void PopulateDefaultData()
        {
            FillCombobox(new TypeOfMeal(), ref cBoxMealCategory);
            PopulateControlMealsList();
            this._firstLoad = false;
        }

        /// <summary>
        /// Metoda ustawia właściwości kontrolek po uruchomieniu aplikacji
        /// </summary>

        private void PopulateDefaoultControlsStates()
        {
            cBoxAddition.Enabled = false;
            btnAddAddition.Enabled = false;
            btnClear.Enabled = false;
            btnAddToOrder.Enabled = false;
            var cost = 0;
            txtBoxCost.Text = cost.ToString("C2");
            btnClearOrder.Enabled = false;
            btnSendOrder.Enabled = false;
            txtBoxComments.Enabled = false;
        }


        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Resource.DoYouWantToClearOrder, 
                Resource.ClearOrder, 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                txtBoxTotalCost.Clear();
                txtOrder.Clear();
                this._menuMealsOrder.Clear();

                btnSendOrder.Enabled = false;
                btnClearOrder.Enabled = false;
                txtBoxComments.Enabled = false;          
            }
        }


        /// <summary>
        /// Zdarzenie przycisku Send Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(string.Format(Resource.DoYouWantToSenOrder, Configuration.EmailUserNameTo), 
                Resource.SendOrder, 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    new MailAddress(Configuration.EmailUserNameTo);
                }
                catch (FormatException) //walidacja adresu email
                {
                    MessageBox.Show(Resource.OrderFaild, 
                        Resource.SendOrder, 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    return;
                }

                Order order = new Order
                {
                    Comments = txtBoxComments.Text,
                    Cost = Convert.ToDouble(this._menuMealsOrder.Sum(x => x.Price).ToString()),
                    MenuItems = this._menuMealsOrder,
                    CustomerEmail = Configuration.EmailUserNameTo
                };


                try //zapis encji zamowienia
                {
                    this._unit.Orders.Add(order);
                    this._unit.SaveChanges();
                }
                catch
                {
                    MessageBox.Show(Resource.SaveOrderError,
                        Resource.SaveOrder,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                

                try //wyslanie emaila
                {
                    //zakomentowane
                    //SendEmail();
                }
                catch
                {
                    MessageBox.Show(Resource.EmailSendFaild,
                        Resource.EmailSend,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(Resource.OrderSuccess, 
                    Resource.SendOrder, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                txtBoxTotalCost.Clear();
                txtOrder.Clear();

                btnSendOrder.Enabled = false;
                btnClearOrder.Enabled = false;
                txtBoxComments.Enabled = false;
            }
        }

        /// <summary>
        /// Zdarzenie przycisku Show history, wyswietla formatke z historia zamowien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowHistoryOrder_Click(object sender, EventArgs e)
        {
            RestaurantOrderHistoryForm orderHistory = new RestaurantOrderHistoryForm();

            orderHistory.ShowDialog();
        }


        /// <summary>
        /// Metoda wypełnia kontrolkę typu combobox elementami z typu wyliczeniowego
        /// </summary>
        private void FillCombobox(Enum enumType, ref ComboBox combobox, bool selectedChanged = true)
        {
            combobox.DataSource = Enum.GetValues(enumType.GetType()) 
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();

            combobox.DisplayMember = "Description";
            combobox.ValueMember = "value";

            if (selectedChanged)
            {
                combobox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Metoda obsluguje logike po wcisnieciu przycisku AddMeal. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tnAdd_Click(object sender, EventArgs e)
        {
            if (cBoxMeal.Text != string.Empty)
            {

                var meal = this._menuMeals.Where(m => m.Name == cBoxMeal.Text).FirstOrDefault();

                if (meal != null)
                {
                    var index = dGridViewListOfMeals.Rows.Add();

                    dGridViewListOfMeals.Rows[index].Cells["ID"].Value = meal.Id;
                    dGridViewListOfMeals.Rows[index].Cells["Name"].Value = meal.Name;
                    dGridViewListOfMeals.Rows[index].Cells["Price"].Value = meal.Price.ToString("C2");

                    this._menuMealsTmp.Add(meal);

                    this._mealAbstract = new MealDecorator<Model.Menu>(this._mealAbstract, meal);

                    txtBoxCost.Text = this._mealAbstract.CalculateCost().ToString("C2");
                    this._mealAbstract.GetOrderDescription();


                    PopulateAdditions();

                }
            }
        }

        /// <summary>
        /// Metoda odpoiwada za uzupelnianie comboboxa z dodatkami do zamowien
        /// </summary>
        private void PopulateAdditions()
        {
            var additions = _menuItemsRepository.Select(m => new RestaurantOrder.Model.Menu
            {
                Id = m.Id,
                Name = m.Name,
                Price = m.Price,
                Type = m.Type,
                IsAddition = m.IsAddition,
                AdditionType = m.AdditionType,
                AdditionTo = m.AdditionTo,
                ModifiedOn = m.ModifiedOn
            })
            .Where(m => m.AdditionTo == (TypeOfMeal)cBoxMealCategory.SelectedValue)
            .ToList();

            btnClear.Enabled = true;
            btnAddToOrder.Enabled = true;
            cBoxMealCategory.Enabled = false;

            if (additions.Count > 0)
            {
                cBoxMeal.Enabled = false;
                cBoxMealCategory.Enabled = false;
                btnAddAddition.Enabled = true;
                cBoxAddition.Enabled = true;

                this._menuMeals = additions;

                if (this._menuMeals.Count > 0)
                {
                    foreach (var addition in this._menuMeals)
                    {
                        cBoxAddition.Items.Add(addition.Name);
                    }

                    if (cBoxAddition.Items.Count > 0)
                    {
                        cBoxAddition.SelectedIndex = 1;
                    }
                }
                else
                {
                    cBoxAddition.Enabled = false;
                    btnAddAddition.Enabled = false;
                    cBoxMeal.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Metoda odpowiada za zdarzenie po wcisnieciu przycisku AddAddition. Dodaje wybrana pozycje do listy zamowienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAddition_Click(object sender, EventArgs e)
        {
            var meal = this._menuMeals.Where(m => m.Name == cBoxAddition.Text).FirstOrDefault();


            if (meal != null)
            {
                var index = dGridViewListOfMeals.Rows.Add();

                dGridViewListOfMeals.Rows[index].Cells["ID"].Value = meal.Id;
                dGridViewListOfMeals.Rows[index].Cells["Name"].Value = meal.Name;
                dGridViewListOfMeals.Rows[index].Cells["Price"].Value = meal.Price.ToString("C2");

                this._menuMealsTmp.Add(meal);

                this._mealAbstract = new MealDecorator<Model.Menu>(this._mealAbstract, meal);

                txtBoxCost.Text = this._mealAbstract.CalculateCost().ToString("C2");
                this._mealAbstract.GetOrderDescription();
            }
        }

        /// <summary>
        /// Zdarzeni przycisku Clear pozycji menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMealSection();
        }

        private void ClearMealSection()
        {
            PopulateControlsStatusAfterClean();

            this._menuMealsTmp.Clear();

            this._mealAbstract = null;
            this._mealAbstract = new BaseMeal();

            FillCombobox(new TypeOfMeal(), ref cBoxMealCategory, false);
        }

        /// <summary>
        /// Metoda odpowiada za ustawienia kontrolek interfejsu po wcisneiciu przycisku Clear
        /// </summary>
        private void PopulateControlsStatusAfterClean()
        {
            cBoxMealCategory.Enabled = true;
            cBoxMeal.Enabled = true;
            cBoxAddition.Enabled = false;
            btnAddAddition.Enabled = false;
            btnAddMeal.Enabled = true;
            dGridViewListOfMeals.Rows.Clear();
            cBoxAddition.Text = string.Empty;
            cBoxAddition.Items.Clear();
            cBoxMeal.Text = string.Empty;
            cBoxMeal.Items.Clear();
            btnClear.Enabled = false;
            btnAddToOrder.Enabled = false;
            var cost = 0;
            txtBoxCost.Text = cost.ToString("C2");
        }


        /// <summary>
        /// Zdarzenie zmiany wartosci Category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBoxMealCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_firstLoad)
            {
                cBoxMeal.Items.Clear();
                PopulateControlMealsList();               
            }
        }

        /// <summary>
        /// Metoda dodaje wybrane pozycje menu do listy zamowien ustawiajac wlasciwosci kontrolek interfejsu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            this._menuMealsOrder.AddRange(this._menuMealsTmp);

            txtOrder.Text = string.Format("{0}{1}__________________________{2}", 
                txtOrder.Text,
                this._mealAbstract.GetOrderDescription(), 
                Environment.NewLine);

            txtBoxTotalCost.Text = string.Format("{0}",
                this._menuMealsOrder.Sum(x => x.Price).ToString("C2"));

            btnClearOrder.Enabled = true;
            btnSendOrder.Enabled = true;
            txtBoxComments.Enabled = true;
           

            ClearMealSection();
        }


        /// <summary>
        /// Metoda wypełnia kontrolke combobox wartosciami menu na podstawie wybranej kategorii
        /// </summary>
        private void PopulateControlMealsList()
        {
            this._menuMeals.Clear();

            this._menuMeals = _menuItemsRepository.Select(m => new RestaurantOrder.Model.Menu
            {
                Id = m.Id,
                Name = m.Name,
                Price = m.Price,
                Type = m.Type,
                IsAddition = m.IsAddition,
                AdditionType = m.AdditionType,
                AdditionTo = m.AdditionTo,
                ModifiedOn = m.ModifiedOn
            })
                .Where(m => m.Type == (TypeOfMeal)cBoxMealCategory.SelectedValue)
                .ToList();

            foreach (var addition in this._menuMeals)
            {
                cBoxMeal.Items.Add(addition.Name);
            }


            cBoxMeal.SelectedIndex = 1;

        }


        /// <summary>
        /// Metoda wysyła emaila względem danych zdefiniowanych w plku konfiguracyjnym projektu App.config
        /// </summary>
        private void SendEmail()
        {

            string userName = Configuration.EmailUserName;
            string userNameTo = Configuration.EmailUserNameTo;
            string password = Configuration.EmailPassword;
            string host = Configuration.EmailHost;
            int port = Configuration.EmailPort;
            int timeout = Configuration.EmailPort;

            string subject = string.Format("Order {0}", Configuration.EmailUserNameTo);
            string body = GetEmailBody();
            SmtpClient client = new SmtpClient
            {
                Host = host,
                Port = port,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential(userName, password),
                Timeout = timeout,
            };
            MailMessage mailMessage = new MailMessage(userName, userNameTo, subject, body);
            client.Send(mailMessage);
        }

        /// <summary>
        /// Metoda tworzy ciało waidomości email
        /// </summary>
        /// <returns></returns>
        private string GetEmailBody()
        {
            return String.Format("Order: {0}{1}{2}Total cost: {3}", 
                Environment.NewLine, 
                txtOrder.Text, 
                Environment.NewLine, 
                txtBoxTotalCost.Text);
        }


    }




}

using RestaurantOrder.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantOrder.GUI
{
    public partial class RestaurantOrderHistoryForm : Form
    {

        private ApplicationUnitOfWork _unit;
        private IEnumerable<RestaurantOrder.Model.Order> _orderItemsRepository;

        public RestaurantOrderHistoryForm()
        {
            InitializeComponent();

            PopulateDefaultData();

            PopulateDataGid();

        }

        private void PopulateDefaultData()
        {
            this._unit = new ApplicationUnitOfWork();
            this._orderItemsRepository = this._unit.Orders.GetAll();
        }

        /// <summary>
        /// Metoda pobiera wskazany obiekt zamównia z kontrolki DataGridView i wyświetla informacje ze szczegółami zamówienia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistoryOrderDetails_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGridViewOrder.SelectedRows)
            {
                int id;
                if (int.TryParse(row.Cells[0].Value.ToString(), out id))
                {
                    var order = this._orderItemsRepository.Where(m => m.Id == id).FirstOrDefault();

                    if (order != null)
                    {
                        var orderMenuItems = PopulateOrderMenuItems(order);

                        var itemDetails = string.Format("ID: {0}{1}Cost: {2:C2}{3}Order items:{4}{5}{6} Reciver: {7}{8} Order date: {9}",
                        order.Id, Environment.NewLine,
                        order.Cost, Environment.NewLine, Environment.NewLine,
                        orderMenuItems, Environment.NewLine,
                        order.CustomerEmail, Environment.NewLine,
                        order.ModifiedOn);

                        MessageBox.Show(itemDetails.ToString(), Resource.OrderDetails, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }     
                    else
                    {
                        MessageBox.Show(Resource.OrderDetailsFaild, Resource.OrderDetails, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Metoda uzupełnia kontrolke DataGridView listą złożonych zamównień
        /// </summary>
        private void PopulateDataGid()
        {
            foreach(var order in _orderItemsRepository)
            {
                var index = dGridViewOrder.Rows.Add();

                dGridViewOrder.Rows[index].Cells["ID"].Value = order.Id;
                dGridViewOrder.Rows[index].Cells["Cost"].Value = order.Cost.ToString("C2");
                dGridViewOrder.Rows[index].Cells["Comments"].Value = order.Comments;
                dGridViewOrder.Rows[index].Cells["Date"].Value = order.ModifiedOn;

            }
        }


        /// <summary>
        /// Metoda pobiera pozycje z menu dla wybranego zamównienia.
        /// </summary>
        /// <param name="order">Obiekt wybranego zamownia</param>
        /// <returns>Lista pozycji z menu danego zamowneia</returns>
        private string PopulateOrderMenuItems(Model.Order order)
        {
            var orderMenuItems = string.Empty;

            StringBuilder sb = new StringBuilder();

            foreach(var item in order.MenuItems)
            {
                sb.Append(string.Format("ID {0}: {1} {2:C2} {3}", item.Id, item.Name, item.Price, Environment.NewLine));
            }

            return sb.ToString();
        }
    }
}

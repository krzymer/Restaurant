namespace RestaurantOrder.GUI
{
    partial class RestaurantOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            this.btnShowHistoryOrder = new System.Windows.Forms.Button();
            this.gBoxOrder = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.gBoxComments = new System.Windows.Forms.GroupBox();
            this.txtBoxComments = new System.Windows.Forms.TextBox();
            this.cBoxMealCategory = new System.Windows.Forms.ComboBox();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.cBoxAddition = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dGridViewListOfMeals = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAddition = new System.Windows.Forms.Button();
            this.cBoxMeal = new System.Windows.Forms.ComboBox();
            this.lblMeal = new System.Windows.Forms.Label();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAdditions = new System.Windows.Forms.Label();
            this.gBoxOrder.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gBoxComments.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewListOfMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOrder.Location = new System.Drawing.Point(8, 40);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrder.Size = new System.Drawing.Size(468, 183);
            this.txtOrder.TabIndex = 0;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.Location = new System.Drawing.Point(8, 353);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(75, 23);
            this.btnClearOrder.TabIndex = 14;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOrder.Location = new System.Drawing.Point(89, 353);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(112, 23);
            this.btnSendOrder.TabIndex = 10;
            this.btnSendOrder.Text = "Send Order";
            this.btnSendOrder.UseVisualStyleBackColor = true;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxCost.Location = new System.Drawing.Point(274, 349);
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.ReadOnly = true;
            this.txtBoxCost.Size = new System.Drawing.Size(100, 21);
            this.txtBoxCost.TabIndex = 8;
            // 
            // btnShowHistoryOrder
            // 
            this.btnShowHistoryOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHistoryOrder.Location = new System.Drawing.Point(358, 353);
            this.btnShowHistoryOrder.Name = "btnShowHistoryOrder";
            this.btnShowHistoryOrder.Size = new System.Drawing.Size(112, 23);
            this.btnShowHistoryOrder.TabIndex = 7;
            this.btnShowHistoryOrder.Text = "Show history";
            this.btnShowHistoryOrder.UseVisualStyleBackColor = true;
            this.btnShowHistoryOrder.Click += new System.EventHandler(this.btnShowHistoryOrder_Click);
            // 
            // gBoxOrder
            // 
            this.gBoxOrder.Controls.Add(this.panel2);
            this.gBoxOrder.Location = new System.Drawing.Point(422, 12);
            this.gBoxOrder.Name = "gBoxOrder";
            this.gBoxOrder.Size = new System.Drawing.Size(506, 420);
            this.gBoxOrder.TabIndex = 15;
            this.gBoxOrder.TabStop = false;
            this.gBoxOrder.Text = "Order";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtBoxTotalCost);
            this.panel2.Controls.Add(this.btnShowHistoryOrder);
            this.panel2.Controls.Add(this.lblTotalCost);
            this.panel2.Controls.Add(this.btnClearOrder);
            this.panel2.Controls.Add(this.btnSendOrder);
            this.panel2.Controls.Add(this.gBoxComments);
            this.panel2.Controls.Add(this.txtOrder);
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 388);
            this.panel2.TabIndex = 22;
            // 
            // txtBoxTotalCost
            // 
            this.txtBoxTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxTotalCost.Location = new System.Drawing.Point(376, 3);
            this.txtBoxTotalCost.Name = "txtBoxTotalCost";
            this.txtBoxTotalCost.ReadOnly = true;
            this.txtBoxTotalCost.Size = new System.Drawing.Size(100, 21);
            this.txtBoxTotalCost.TabIndex = 28;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalCost.Location = new System.Drawing.Point(308, 9);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(62, 15);
            this.lblTotalCost.TabIndex = 28;
            this.lblTotalCost.Text = "Total cost:";
            // 
            // gBoxComments
            // 
            this.gBoxComments.Controls.Add(this.txtBoxComments);
            this.gBoxComments.Location = new System.Drawing.Point(8, 229);
            this.gBoxComments.Name = "gBoxComments";
            this.gBoxComments.Size = new System.Drawing.Size(468, 109);
            this.gBoxComments.TabIndex = 15;
            this.gBoxComments.TabStop = false;
            this.gBoxComments.Text = "Comments";
            // 
            // txtBoxComments
            // 
            this.txtBoxComments.Location = new System.Drawing.Point(6, 15);
            this.txtBoxComments.Multiline = true;
            this.txtBoxComments.Name = "txtBoxComments";
            this.txtBoxComments.Size = new System.Drawing.Size(456, 88);
            this.txtBoxComments.TabIndex = 15;
            // 
            // cBoxMealCategory
            // 
            this.cBoxMealCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMealCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxMealCategory.FormattingEnabled = true;
            this.cBoxMealCategory.Location = new System.Drawing.Point(5, 26);
            this.cBoxMealCategory.Name = "cBoxMealCategory";
            this.cBoxMealCategory.Size = new System.Drawing.Size(208, 21);
            this.cBoxMealCategory.TabIndex = 16;
            this.cBoxMealCategory.SelectedIndexChanged += new System.EventHandler(this.cBoxMealCategory_SelectedIndexChanged);
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.panel1);
            this.gbMenu.Location = new System.Drawing.Point(12, 13);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(404, 419);
            this.gbMenu.TabIndex = 21;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCost);
            this.panel1.Controls.Add(this.txtBoxCost);
            this.panel1.Controls.Add(this.btnAddToOrder);
            this.panel1.Controls.Add(this.cBoxAddition);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.dGridViewListOfMeals);
            this.panel1.Controls.Add(this.cBoxMealCategory);
            this.panel1.Controls.Add(this.btnAddAddition);
            this.panel1.Controls.Add(this.cBoxMeal);
            this.panel1.Controls.Add(this.lblMeal);
            this.panel1.Controls.Add(this.btnAddMeal);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblAdditions);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 387);
            this.panel1.TabIndex = 22;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCost.Location = new System.Drawing.Point(234, 352);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(34, 15);
            this.lblCost.TabIndex = 27;
            this.lblCost.Text = "Cost:";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Location = new System.Drawing.Point(87, 349);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(106, 23);
            this.btnAddToOrder.TabIndex = 26;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // cBoxAddition
            // 
            this.cBoxAddition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxAddition.FormattingEnabled = true;
            this.cBoxAddition.Location = new System.Drawing.Point(5, 142);
            this.cBoxAddition.Name = "cBoxAddition";
            this.cBoxAddition.Size = new System.Drawing.Size(208, 21);
            this.cBoxAddition.TabIndex = 20;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategory.Location = new System.Drawing.Point(3, 8);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 22;
            this.lblCategory.Text = "Category:";
            // 
            // dGridViewListOfMeals
            // 
            this.dGridViewListOfMeals.AllowUserToAddRows = false;
            this.dGridViewListOfMeals.AllowUserToDeleteRows = false;
            this.dGridViewListOfMeals.AllowUserToResizeColumns = false;
            this.dGridViewListOfMeals.AllowUserToResizeRows = false;
            this.dGridViewListOfMeals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridViewListOfMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewListOfMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Price});
            this.dGridViewListOfMeals.Location = new System.Drawing.Point(5, 193);
            this.dGridViewListOfMeals.Name = "dGridViewListOfMeals";
            this.dGridViewListOfMeals.ReadOnly = true;
            this.dGridViewListOfMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewListOfMeals.Size = new System.Drawing.Size(369, 150);
            this.dGridViewListOfMeals.TabIndex = 25;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // btnAddAddition
            // 
            this.btnAddAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAddition.Location = new System.Drawing.Point(238, 145);
            this.btnAddAddition.Name = "btnAddAddition";
            this.btnAddAddition.Size = new System.Drawing.Size(90, 23);
            this.btnAddAddition.TabIndex = 24;
            this.btnAddAddition.Text = "Add addition";
            this.btnAddAddition.UseVisualStyleBackColor = true;
            this.btnAddAddition.Click += new System.EventHandler(this.btnAddAddition_Click);
            // 
            // cBoxMeal
            // 
            this.cBoxMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxMeal.FormattingEnabled = true;
            this.cBoxMeal.Location = new System.Drawing.Point(5, 81);
            this.cBoxMeal.Name = "cBoxMeal";
            this.cBoxMeal.Size = new System.Drawing.Size(208, 21);
            this.cBoxMeal.TabIndex = 17;
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMeal.Location = new System.Drawing.Point(2, 63);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(38, 15);
            this.lblMeal.TabIndex = 23;
            this.lblMeal.Text = "Meal:";
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeal.Location = new System.Drawing.Point(238, 81);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(90, 23);
            this.btnAddMeal.TabIndex = 18;
            this.btnAddMeal.Text = "Add meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.tnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(6, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAdditions
            // 
            this.lblAdditions.AutoSize = true;
            this.lblAdditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdditions.Location = new System.Drawing.Point(3, 124);
            this.lblAdditions.Name = "lblAdditions";
            this.lblAdditions.Size = new System.Drawing.Size(60, 15);
            this.lblAdditions.TabIndex = 21;
            this.lblAdditions.Text = "Additions:";
            // 
            // RestaurantOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 445);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.gBoxOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(950, 479);
            this.MinimumSize = new System.Drawing.Size(950, 479);
            this.Text = "RestauratOrder";
            this.gBoxOrder.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gBoxComments.ResumeLayout(false);
            this.gBoxComments.PerformLayout();
            this.gbMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewListOfMeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCost;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnShowHistoryOrder;
        private System.Windows.Forms.GroupBox gBoxOrder;
        private System.Windows.Forms.GroupBox gBoxComments;
        private System.Windows.Forms.TextBox txtBoxComments;
        private System.Windows.Forms.ComboBox cBoxMealCategory;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.ComboBox cBoxMeal;
        private System.Windows.Forms.Button btnAddAddition;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAdditions;
        private System.Windows.Forms.ComboBox cBoxAddition;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.DataGridView dGridViewListOfMeals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtBoxTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
    }
}


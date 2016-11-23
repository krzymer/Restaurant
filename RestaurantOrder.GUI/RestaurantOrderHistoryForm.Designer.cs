namespace RestaurantOrder.GUI
{
    partial class RestaurantOrderHistoryForm
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
            this.gBoxHistory = new System.Windows.Forms.GroupBox();
            this.dGridViewOrder = new System.Windows.Forms.DataGridView();
            this.btnHistoryOrderDetails = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxHistory
            // 
            this.gBoxHistory.Controls.Add(this.dGridViewOrder);
            this.gBoxHistory.Location = new System.Drawing.Point(5, 12);
            this.gBoxHistory.Name = "gBoxHistory";
            this.gBoxHistory.Size = new System.Drawing.Size(583, 320);
            this.gBoxHistory.TabIndex = 0;
            this.gBoxHistory.TabStop = false;
            this.gBoxHistory.Text = "Hostory";
            // 
            // dGridViewOrder
            // 
            this.dGridViewOrder.AllowUserToAddRows = false;
            this.dGridViewOrder.AllowUserToDeleteRows = false;
            this.dGridViewOrder.AllowUserToResizeColumns = false;
            this.dGridViewOrder.AllowUserToResizeRows = false;
            this.dGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cost,
            this.Comments,
            this.Receiver,
            this.Date});
            this.dGridViewOrder.Location = new System.Drawing.Point(6, 19);
            this.dGridViewOrder.MultiSelect = false;
            this.dGridViewOrder.Name = "dGridViewOrder";
            this.dGridViewOrder.ReadOnly = true;
            this.dGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewOrder.Size = new System.Drawing.Size(570, 295);
            this.dGridViewOrder.TabIndex = 0;
            // 
            // btnHistoryOrderDetails
            // 
            this.btnHistoryOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryOrderDetails.Location = new System.Drawing.Point(486, 338);
            this.btnHistoryOrderDetails.Name = "btnHistoryOrderDetails";
            this.btnHistoryOrderDetails.Size = new System.Drawing.Size(102, 23);
            this.btnHistoryOrderDetails.TabIndex = 1;
            this.btnHistoryOrderDetails.Text = "Show details";
            this.btnHistoryOrderDetails.UseVisualStyleBackColor = true;
            this.btnHistoryOrderDetails.Click += new System.EventHandler(this.btnHistoryOrderDetails_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            // 
            // Receiver
            // 
            this.Receiver.HeaderText = "Receiver";
            this.Receiver.Name = "Receiver";
            this.Receiver.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // RestaurantOrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 378);
            this.Controls.Add(this.btnHistoryOrderDetails);
            this.Controls.Add(this.gBoxHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(618, 412);
            this.MinimumSize = new System.Drawing.Size(618, 412);
            this.Name = "RestaurantOrderHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RestaurantOrder History";
            this.gBoxHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxHistory;
        private System.Windows.Forms.DataGridView dGridViewOrder;
        private System.Windows.Forms.Button btnHistoryOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}
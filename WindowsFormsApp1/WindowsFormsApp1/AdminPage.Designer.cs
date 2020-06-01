namespace WindowsFormsApp1
{
    partial class AdminPage
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xanutDataSet = new WindowsFormsApp1.XanutDataSet();
            this.tblfromXanutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblfromXanutTableAdapter = new WindowsFormsApp1.XanutDataSetTableAdapters.TblfromXanutTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.անունDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.քանակDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.գնվածԳինDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.վաճառքիԳինDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.SalePriceTb = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.itogBtn = new System.Windows.Forms.Button();
            this.serchBtn = new System.Windows.Forms.Button();
            this.serarchTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xanutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfromXanutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.անունDataGridViewTextBoxColumn,
            this.քանակDataGridViewTextBoxColumn,
            this.գնվածԳինDataGridViewTextBoxColumn,
            this.վաճառքիԳինDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblfromXanutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // xanutDataSet
            // 
            this.xanutDataSet.DataSetName = "XanutDataSet";
            this.xanutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblfromXanutBindingSource
            // 
            this.tblfromXanutBindingSource.DataMember = "TblfromXanut";
            this.tblfromXanutBindingSource.DataSource = this.xanutDataSet;
            // 
            // tblfromXanutTableAdapter
            // 
            this.tblfromXanutTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // անունDataGridViewTextBoxColumn
            // 
            this.անունDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.անունDataGridViewTextBoxColumn.DataPropertyName = "Անուն";
            this.անունDataGridViewTextBoxColumn.HeaderText = "Անուն";
            this.անունDataGridViewTextBoxColumn.Name = "անունDataGridViewTextBoxColumn";
            // 
            // քանակDataGridViewTextBoxColumn
            // 
            this.քանակDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.քանակDataGridViewTextBoxColumn.DataPropertyName = "Քանակ";
            this.քանակDataGridViewTextBoxColumn.HeaderText = "Քանակ";
            this.քանակDataGridViewTextBoxColumn.Name = "քանակDataGridViewTextBoxColumn";
            // 
            // գնվածԳինDataGridViewTextBoxColumn
            // 
            this.գնվածԳինDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.գնվածԳինDataGridViewTextBoxColumn.DataPropertyName = "ԳնվածԳին";
            this.գնվածԳինDataGridViewTextBoxColumn.HeaderText = "ԳնվածԳին";
            this.գնվածԳինDataGridViewTextBoxColumn.Name = "գնվածԳինDataGridViewTextBoxColumn";
            // 
            // վաճառքիԳինDataGridViewTextBoxColumn
            // 
            this.վաճառքիԳինDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.վաճառքիԳինDataGridViewTextBoxColumn.DataPropertyName = "ՎաճառքիԳին";
            this.վաճառքիԳինDataGridViewTextBoxColumn.HeaderText = "ՎաճառքիԳին";
            this.վաճառքիԳինDataGridViewTextBoxColumn.Name = "վաճառքիԳինDataGridViewTextBoxColumn";
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(257, 19);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(289, 20);
            this.IdTB.TabIndex = 1;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(257, 45);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(289, 20);
            this.NameTB.TabIndex = 2;
            // 
            // quantityTB
            // 
            this.quantityTB.Location = new System.Drawing.Point(257, 71);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(289, 20);
            this.quantityTB.TabIndex = 3;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(257, 97);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(289, 20);
            this.PriceTB.TabIndex = 4;
            // 
            // SalePriceTb
            // 
            this.SalePriceTb.Location = new System.Drawing.Point(257, 123);
            this.SalePriceTb.Name = "SalePriceTb";
            this.SalePriceTb.Size = new System.Drawing.Size(289, 20);
            this.SalePriceTb.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(12, 17);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(106, 38);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Ավելացնել";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(12, 109);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(106, 35);
            this.viewBtn.TabIndex = 7;
            this.viewBtn.Text = "Տեսնել";
            this.viewBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(124, 17);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(109, 38);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Ջնջել";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(124, 109);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(109, 35);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Թարմացնել";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // itogBtn
            // 
            this.itogBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itogBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.itogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.itogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itogBtn.Location = new System.Drawing.Point(579, 19);
            this.itogBtn.Name = "itogBtn";
            this.itogBtn.Size = new System.Drawing.Size(106, 38);
            this.itogBtn.TabIndex = 10;
            this.itogBtn.Text = "Հաշվել";
            this.itogBtn.UseVisualStyleBackColor = false;
            // 
            // serchBtn
            // 
            this.serchBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.serchBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.serchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.serchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serchBtn.Location = new System.Drawing.Point(579, 97);
            this.serchBtn.Name = "serchBtn";
            this.serchBtn.Size = new System.Drawing.Size(106, 38);
            this.serchBtn.TabIndex = 11;
            this.serchBtn.Text = "Փնտրել";
            this.serchBtn.UseVisualStyleBackColor = false;
            // 
            // serarchTb
            // 
            this.serarchTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serarchTb.Location = new System.Drawing.Point(691, 107);
            this.serarchTb.Name = "serarchTb";
            this.serarchTb.Size = new System.Drawing.Size(260, 20);
            this.serarchTb.TabIndex = 12;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.serarchTb);
            this.Controls.Add(this.serchBtn);
            this.Controls.Add(this.itogBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.SalePriceTb);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xanutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfromXanutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private XanutDataSet xanutDataSet;
        private System.Windows.Forms.BindingSource tblfromXanutBindingSource;
        private XanutDataSetTableAdapters.TblfromXanutTableAdapter tblfromXanutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn անունDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn քանակDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn գնվածԳինDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn վաճառքիԳինDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox SalePriceTb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button itogBtn;
        private System.Windows.Forms.Button serchBtn;
        private System.Windows.Forms.TextBox serarchTb;
    }
}
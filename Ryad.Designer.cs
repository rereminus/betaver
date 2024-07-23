
namespace betaver
{
    partial class Ryad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ryad));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodbronDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodklientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datakonechDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvovzrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvodetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bronirovaniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new betaver.hotelDataSet();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.bronirovaniaTableAdapter = new betaver.hotelDataSetTableAdapters.bronirovaniaTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kodbronDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koduslugiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bronuslugiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bron_uslugiTableAdapter = new betaver.hotelDataSetTableAdapters.bron_uslugiTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.koduslugiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugiTableAdapter = new betaver.hotelDataSetTableAdapters.uslugiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronirovaniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronuslugiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodbronDataGridViewTextBoxColumn,
            this.kodklientDataGridViewTextBoxColumn,
            this.nomerDataGridViewTextBoxColumn,
            this.datanachDataGridViewTextBoxColumn,
            this.datakonechDataGridViewTextBoxColumn,
            this.kolvovzrosDataGridViewTextBoxColumn,
            this.kolvodetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bronirovaniaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 458);
            this.dataGridView1.TabIndex = 0;
            // 
            // kodbronDataGridViewTextBoxColumn
            // 
            this.kodbronDataGridViewTextBoxColumn.DataPropertyName = "kod_bron";
            this.kodbronDataGridViewTextBoxColumn.HeaderText = "Бронирование №";
            this.kodbronDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodbronDataGridViewTextBoxColumn.Name = "kodbronDataGridViewTextBoxColumn";
            this.kodbronDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodklientDataGridViewTextBoxColumn
            // 
            this.kodklientDataGridViewTextBoxColumn.DataPropertyName = "kod_klient";
            this.kodklientDataGridViewTextBoxColumn.HeaderText = "kod_klient";
            this.kodklientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodklientDataGridViewTextBoxColumn.Name = "kodklientDataGridViewTextBoxColumn";
            this.kodklientDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodklientDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "nomer";
            this.nomerDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.nomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
            this.nomerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datanachDataGridViewTextBoxColumn
            // 
            this.datanachDataGridViewTextBoxColumn.DataPropertyName = "data_nach";
            this.datanachDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.datanachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datanachDataGridViewTextBoxColumn.Name = "datanachDataGridViewTextBoxColumn";
            this.datanachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datakonechDataGridViewTextBoxColumn
            // 
            this.datakonechDataGridViewTextBoxColumn.DataPropertyName = "data_konech";
            this.datakonechDataGridViewTextBoxColumn.HeaderText = "Конец";
            this.datakonechDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datakonechDataGridViewTextBoxColumn.Name = "datakonechDataGridViewTextBoxColumn";
            this.datakonechDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolvovzrosDataGridViewTextBoxColumn
            // 
            this.kolvovzrosDataGridViewTextBoxColumn.DataPropertyName = "kolvo_vzros";
            this.kolvovzrosDataGridViewTextBoxColumn.HeaderText = "Кол-во взрослых";
            this.kolvovzrosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolvovzrosDataGridViewTextBoxColumn.Name = "kolvovzrosDataGridViewTextBoxColumn";
            this.kolvovzrosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolvodetDataGridViewTextBoxColumn
            // 
            this.kolvodetDataGridViewTextBoxColumn.DataPropertyName = "kolvo_det";
            this.kolvodetDataGridViewTextBoxColumn.HeaderText = "Кол-во детей";
            this.kolvodetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolvodetDataGridViewTextBoxColumn.Name = "kolvodetDataGridViewTextBoxColumn";
            this.kolvodetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bronirovaniaBindingSource
            // 
            this.bronirovaniaBindingSource.DataMember = "bronirovania";
            this.bronirovaniaBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDb;Initial Catalog=hotel;Integrated Security=True" +
    "";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // bronirovaniaTableAdapter
            // 
            this.bronirovaniaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodbronDataGridViewTextBoxColumn1,
            this.koduslugiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bronuslugiBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(920, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(578, 458);
            this.dataGridView2.TabIndex = 1;
            // 
            // kodbronDataGridViewTextBoxColumn1
            // 
            this.kodbronDataGridViewTextBoxColumn1.DataPropertyName = "kod_bron";
            this.kodbronDataGridViewTextBoxColumn1.HeaderText = "Бронирование №";
            this.kodbronDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kodbronDataGridViewTextBoxColumn1.Name = "kodbronDataGridViewTextBoxColumn1";
            this.kodbronDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // koduslugiDataGridViewTextBoxColumn
            // 
            this.koduslugiDataGridViewTextBoxColumn.DataPropertyName = "kod_uslugi";
            this.koduslugiDataGridViewTextBoxColumn.HeaderText = "Код услуги";
            this.koduslugiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.koduslugiDataGridViewTextBoxColumn.Name = "koduslugiDataGridViewTextBoxColumn";
            this.koduslugiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bronuslugiBindingSource
            // 
            this.bronuslugiBindingSource.DataMember = "bron_uslugi";
            this.bronuslugiBindingSource.DataSource = this.hotelDataSet;
            // 
            // bron_uslugiTableAdapter
            // 
            this.bron_uslugiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.koduslugiDataGridViewTextBoxColumn1,
            this.naimenDataGridViewTextBoxColumn,
            this.stoimostDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.uslugiBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.Location = new System.Drawing.Point(284, 250);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(868, 393);
            this.dataGridView3.TabIndex = 2;
            // 
            // koduslugiDataGridViewTextBoxColumn1
            // 
            this.koduslugiDataGridViewTextBoxColumn1.DataPropertyName = "kod_uslugi";
            this.koduslugiDataGridViewTextBoxColumn1.HeaderText = "Код услуги";
            this.koduslugiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.koduslugiDataGridViewTextBoxColumn1.Name = "koduslugiDataGridViewTextBoxColumn1";
            this.koduslugiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // naimenDataGridViewTextBoxColumn
            // 
            this.naimenDataGridViewTextBoxColumn.DataPropertyName = "naimen";
            this.naimenDataGridViewTextBoxColumn.HeaderText = "Название";
            this.naimenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.naimenDataGridViewTextBoxColumn.Name = "naimenDataGridViewTextBoxColumn";
            this.naimenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stoimostDataGridViewTextBoxColumn
            // 
            this.stoimostDataGridViewTextBoxColumn.DataPropertyName = "stoimost";
            this.stoimostDataGridViewTextBoxColumn.HeaderText = "stoimost";
            this.stoimostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stoimostDataGridViewTextBoxColumn.Name = "stoimostDataGridViewTextBoxColumn";
            this.stoimostDataGridViewTextBoxColumn.ReadOnly = true;
            this.stoimostDataGridViewTextBoxColumn.Visible = false;
            // 
            // uslugiBindingSource
            // 
            this.uslugiBindingSource.DataMember = "uslugi";
            this.uslugiBindingSource.DataSource = this.hotelDataSet;
            // 
            // uslugiTableAdapter
            // 
            this.uslugiTableAdapter.ClearBeforeFill = true;
            // 
            // Ryad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 684);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ryad";
            this.Text = "Мастер Отель";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ryad_FormClosing);
            this.Load += new System.EventHandler(this.Ryad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronirovaniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronuslugiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource bronirovaniaBindingSource;
        private hotelDataSetTableAdapters.bronirovaniaTableAdapter bronirovaniaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bronuslugiBindingSource;
        private hotelDataSetTableAdapters.bron_uslugiTableAdapter bron_uslugiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodbronDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodklientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datakonechDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvovzrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvodetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodbronDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn koduslugiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource uslugiBindingSource;
        private hotelDataSetTableAdapters.uslugiTableAdapter uslugiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn koduslugiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
    }
}
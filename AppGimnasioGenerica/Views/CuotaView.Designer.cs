namespace DesktopAppGimnasio.Views
{
    partial class CuotaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuotaView));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabPageDebtorsVisualizer = new TabPage();
            buttonSearchDebt = new Button();
            textBoxSearchDebt = new TextBox();
            dataGridViewCuotasVencidas = new DataGridView();
            tabPageCuotasVisualizer = new TabPage();
            buttonEditCuota = new Button();
            buttonDeleteCuota = new Button();
            buttonSearchCuota = new Button();
            textBoxSearchCuota = new TextBox();
            dataGridViewCuotas = new DataGridView();
            tabPageAddOrEditCuota = new TabPage();
            labelNombreCompletoSocio = new Label();
            textBoxNombreCompleto = new TextBox();
            comboBoxCantidad = new ComboBox();
            labelCantidad = new Label();
            labelPesos = new Label();
            labelCodigoCuota = new Label();
            textBoxCodigoCuota = new TextBox();
            labelTipoCuota = new Label();
            comboBoxTipoCuota = new ComboBox();
            labelFechaPago = new Label();
            monthCalendarFechaPago = new MonthCalendar();
            labelCodigoSocio = new Label();
            textBoxCodigoSocio = new TextBox();
            buttonCancelOperation = new Button();
            buttonSaveCuota = new Button();
            buttonAddCuota = new Button();
            labelOperation = new Label();
            labelMonto = new Label();
            textBoxMonto = new TextBox();
            buttonClose = new Button();
            tabControl.SuspendLayout();
            tabPageDebtorsVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotasVencidas).BeginInit();
            tabPageCuotasVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotas).BeginInit();
            tabPageAddOrEditCuota.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageDebtorsVisualizer);
            tabControl.Controls.Add(tabPageCuotasVisualizer);
            tabControl.Controls.Add(tabPageAddOrEditCuota);
            tabControl.Font = new Font("Arial Rounded MT Bold", 12F);
            tabControl.Location = new Point(0, 12);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(10, 8);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(855, 548);
            tabControl.TabIndex = 0;
            tabControl.TabStop = false;
            // 
            // tabPageDebtorsVisualizer
            // 
            tabPageDebtorsVisualizer.Controls.Add(buttonSearchDebt);
            tabPageDebtorsVisualizer.Controls.Add(textBoxSearchDebt);
            tabPageDebtorsVisualizer.Controls.Add(dataGridViewCuotasVencidas);
            tabPageDebtorsVisualizer.Location = new Point(4, 37);
            tabPageDebtorsVisualizer.Name = "tabPageDebtorsVisualizer";
            tabPageDebtorsVisualizer.Padding = new Padding(3);
            tabPageDebtorsVisualizer.Size = new Size(847, 507);
            tabPageDebtorsVisualizer.TabIndex = 2;
            tabPageDebtorsVisualizer.Text = "Administración de deudas";
            // 
            // buttonSearchDebt
            // 
            buttonSearchDebt.BackColor = Color.FromArgb(128, 128, 255);
            buttonSearchDebt.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonSearchDebt.FlatAppearance.BorderSize = 2;
            buttonSearchDebt.FlatStyle = FlatStyle.Flat;
            buttonSearchDebt.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonSearchDebt.ForeColor = Color.White;
            buttonSearchDebt.Image = (Image)resources.GetObject("buttonSearchDebt.Image");
            buttonSearchDebt.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearchDebt.Location = new Point(409, 20);
            buttonSearchDebt.Name = "buttonSearchDebt";
            buttonSearchDebt.Size = new Size(100, 32);
            buttonSearchDebt.TabIndex = 1;
            buttonSearchDebt.Text = "Buscar";
            buttonSearchDebt.TextAlign = ContentAlignment.MiddleLeft;
            buttonSearchDebt.UseVisualStyleBackColor = false;
            buttonSearchDebt.MouseClick += buttonSearchDebt_MouseClick;
            // 
            // textBoxSearchDebt
            // 
            textBoxSearchDebt.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchDebt.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            textBoxSearchDebt.ForeColor = Color.Black;
            textBoxSearchDebt.HideSelection = false;
            textBoxSearchDebt.Location = new Point(6, 21);
            textBoxSearchDebt.Name = "textBoxSearchDebt";
            textBoxSearchDebt.Size = new Size(397, 29);
            textBoxSearchDebt.TabIndex = 0;
            textBoxSearchDebt.KeyDown += textBoxSearchDebt_KeyDown;
            // 
            // dataGridViewCuotasVencidas
            // 
            dataGridViewCuotasVencidas.AllowUserToAddRows = false;
            dataGridViewCuotasVencidas.AllowUserToDeleteRows = false;
            dataGridViewCuotasVencidas.AllowUserToResizeColumns = false;
            dataGridViewCuotasVencidas.AllowUserToResizeRows = false;
            dataGridViewCuotasVencidas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCuotasVencidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCuotasVencidas.BackgroundColor = SystemColors.Control;
            dataGridViewCuotasVencidas.BorderStyle = BorderStyle.None;
            dataGridViewCuotasVencidas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Arial Rounded MT Bold", 14.25F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewCuotasVencidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCuotasVencidas.ColumnHeadersHeight = 70;
            dataGridViewCuotasVencidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCuotasVencidas.EnableHeadersVisualStyles = false;
            dataGridViewCuotasVencidas.GridColor = Color.Black;
            dataGridViewCuotasVencidas.Location = new Point(6, 62);
            dataGridViewCuotasVencidas.MultiSelect = false;
            dataGridViewCuotasVencidas.Name = "dataGridViewCuotasVencidas";
            dataGridViewCuotasVencidas.ReadOnly = true;
            dataGridViewCuotasVencidas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Arial Rounded MT Bold", 13F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewCuotasVencidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCuotasVencidas.RowHeadersVisible = false;
            dataGridViewCuotasVencidas.RowHeadersWidth = 20;
            dataGridViewCuotasVencidas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Arial Rounded MT Bold", 12F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCuotasVencidas.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCuotasVencidas.RowTemplate.Height = 30;
            dataGridViewCuotasVencidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCuotasVencidas.Size = new Size(835, 438);
            dataGridViewCuotasVencidas.TabIndex = 1;
            dataGridViewCuotasVencidas.TabStop = false;
            dataGridViewCuotasVencidas.CellFormatting += dataGridViewCuotasVencidas_CellFormatting;
            // 
            // tabPageCuotasVisualizer
            // 
            tabPageCuotasVisualizer.Controls.Add(buttonEditCuota);
            tabPageCuotasVisualizer.Controls.Add(buttonDeleteCuota);
            tabPageCuotasVisualizer.Controls.Add(buttonSearchCuota);
            tabPageCuotasVisualizer.Controls.Add(textBoxSearchCuota);
            tabPageCuotasVisualizer.Controls.Add(dataGridViewCuotas);
            tabPageCuotasVisualizer.ForeColor = Color.Black;
            tabPageCuotasVisualizer.Location = new Point(4, 37);
            tabPageCuotasVisualizer.Name = "tabPageCuotasVisualizer";
            tabPageCuotasVisualizer.Padding = new Padding(3);
            tabPageCuotasVisualizer.Size = new Size(847, 507);
            tabPageCuotasVisualizer.TabIndex = 0;
            tabPageCuotasVisualizer.Text = "Administración de cuotas";
            // 
            // buttonEditCuota
            // 
            buttonEditCuota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditCuota.BackColor = Color.FromArgb(128, 128, 255);
            buttonEditCuota.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonEditCuota.FlatAppearance.BorderSize = 2;
            buttonEditCuota.FlatStyle = FlatStyle.Flat;
            buttonEditCuota.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonEditCuota.ForeColor = Color.White;
            buttonEditCuota.Image = (Image)resources.GetObject("buttonEditCuota.Image");
            buttonEditCuota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditCuota.Location = new Point(583, 14);
            buttonEditCuota.Name = "buttonEditCuota";
            buttonEditCuota.Size = new Size(125, 39);
            buttonEditCuota.TabIndex = 2;
            buttonEditCuota.Text = "  Editar";
            buttonEditCuota.UseVisualStyleBackColor = false;
            buttonEditCuota.MouseClick += buttonEditCuota_MouseClick;
            // 
            // buttonDeleteCuota
            // 
            buttonDeleteCuota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteCuota.BackColor = Color.FromArgb(128, 128, 255);
            buttonDeleteCuota.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonDeleteCuota.FlatAppearance.BorderSize = 2;
            buttonDeleteCuota.FlatStyle = FlatStyle.Flat;
            buttonDeleteCuota.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonDeleteCuota.ForeColor = Color.White;
            buttonDeleteCuota.Image = (Image)resources.GetObject("buttonDeleteCuota.Image");
            buttonDeleteCuota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteCuota.Location = new Point(714, 14);
            buttonDeleteCuota.Name = "buttonDeleteCuota";
            buttonDeleteCuota.Size = new Size(125, 39);
            buttonDeleteCuota.TabIndex = 3;
            buttonDeleteCuota.Text = "   Eliminar";
            buttonDeleteCuota.UseVisualStyleBackColor = false;
            buttonDeleteCuota.MouseClick += buttonDeleteCuota_MouseClick;
            // 
            // buttonSearchCuota
            // 
            buttonSearchCuota.BackColor = Color.FromArgb(128, 128, 255);
            buttonSearchCuota.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonSearchCuota.FlatAppearance.BorderSize = 2;
            buttonSearchCuota.FlatStyle = FlatStyle.Flat;
            buttonSearchCuota.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonSearchCuota.ForeColor = Color.White;
            buttonSearchCuota.Image = (Image)resources.GetObject("buttonSearchCuota.Image");
            buttonSearchCuota.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearchCuota.Location = new Point(409, 20);
            buttonSearchCuota.Name = "buttonSearchCuota";
            buttonSearchCuota.Size = new Size(100, 32);
            buttonSearchCuota.TabIndex = 1;
            buttonSearchCuota.Text = "Buscar";
            buttonSearchCuota.TextAlign = ContentAlignment.MiddleLeft;
            buttonSearchCuota.UseVisualStyleBackColor = false;
            buttonSearchCuota.MouseClick += buttonSearchCuota_MouseClick;
            // 
            // textBoxSearchCuota
            // 
            textBoxSearchCuota.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchCuota.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            textBoxSearchCuota.ForeColor = Color.Black;
            textBoxSearchCuota.Location = new Point(6, 21);
            textBoxSearchCuota.Name = "textBoxSearchCuota";
            textBoxSearchCuota.Size = new Size(397, 29);
            textBoxSearchCuota.TabIndex = 0;
            textBoxSearchCuota.KeyDown += textBoxSearchCuota_KeyDown;
            // 
            // dataGridViewCuotas
            // 
            dataGridViewCuotas.AllowUserToAddRows = false;
            dataGridViewCuotas.AllowUserToDeleteRows = false;
            dataGridViewCuotas.AllowUserToResizeColumns = false;
            dataGridViewCuotas.AllowUserToResizeRows = false;
            dataGridViewCuotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCuotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCuotas.BackgroundColor = SystemColors.Control;
            dataGridViewCuotas.BorderStyle = BorderStyle.None;
            dataGridViewCuotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Arial Rounded MT Bold", 14.25F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCuotas.ColumnHeadersHeight = 30;
            dataGridViewCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCuotas.EnableHeadersVisualStyles = false;
            dataGridViewCuotas.GridColor = Color.Black;
            dataGridViewCuotas.Location = new Point(6, 62);
            dataGridViewCuotas.MultiSelect = false;
            dataGridViewCuotas.Name = "dataGridViewCuotas";
            dataGridViewCuotas.ReadOnly = true;
            dataGridViewCuotas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Arial Rounded MT Bold", 12F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewCuotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCuotas.RowHeadersVisible = false;
            dataGridViewCuotas.RowHeadersWidth = 20;
            dataGridViewCuotas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Arial Rounded MT Bold", 12F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCuotas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCuotas.RowTemplate.Height = 30;
            dataGridViewCuotas.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewCuotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCuotas.Size = new Size(835, 438);
            dataGridViewCuotas.TabIndex = 0;
            dataGridViewCuotas.TabStop = false;
            // 
            // tabPageAddOrEditCuota
            // 
            tabPageAddOrEditCuota.Controls.Add(labelNombreCompletoSocio);
            tabPageAddOrEditCuota.Controls.Add(textBoxNombreCompleto);
            tabPageAddOrEditCuota.Controls.Add(comboBoxCantidad);
            tabPageAddOrEditCuota.Controls.Add(labelCantidad);
            tabPageAddOrEditCuota.Controls.Add(labelPesos);
            tabPageAddOrEditCuota.Controls.Add(labelCodigoCuota);
            tabPageAddOrEditCuota.Controls.Add(textBoxCodigoCuota);
            tabPageAddOrEditCuota.Controls.Add(labelTipoCuota);
            tabPageAddOrEditCuota.Controls.Add(comboBoxTipoCuota);
            tabPageAddOrEditCuota.Controls.Add(labelFechaPago);
            tabPageAddOrEditCuota.Controls.Add(monthCalendarFechaPago);
            tabPageAddOrEditCuota.Controls.Add(labelCodigoSocio);
            tabPageAddOrEditCuota.Controls.Add(textBoxCodigoSocio);
            tabPageAddOrEditCuota.Controls.Add(buttonCancelOperation);
            tabPageAddOrEditCuota.Controls.Add(buttonSaveCuota);
            tabPageAddOrEditCuota.Controls.Add(buttonAddCuota);
            tabPageAddOrEditCuota.Controls.Add(labelOperation);
            tabPageAddOrEditCuota.Controls.Add(labelMonto);
            tabPageAddOrEditCuota.Controls.Add(textBoxMonto);
            tabPageAddOrEditCuota.Location = new Point(4, 37);
            tabPageAddOrEditCuota.Name = "tabPageAddOrEditCuota";
            tabPageAddOrEditCuota.Padding = new Padding(3);
            tabPageAddOrEditCuota.Size = new Size(847, 507);
            tabPageAddOrEditCuota.TabIndex = 1;
            tabPageAddOrEditCuota.Text = "Registrar/Editar cuota";
            // 
            // labelNombreCompletoSocio
            // 
            labelNombreCompletoSocio.AutoSize = true;
            labelNombreCompletoSocio.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            labelNombreCompletoSocio.ForeColor = SystemColors.ControlText;
            labelNombreCompletoSocio.Location = new Point(22, 220);
            labelNombreCompletoSocio.Name = "labelNombreCompletoSocio";
            labelNombreCompletoSocio.Size = new Size(243, 23);
            labelNombreCompletoSocio.TabIndex = 37;
            labelNombreCompletoSocio.Text = "Nombre y apellido socio:";
            // 
            // textBoxNombreCompleto
            // 
            textBoxNombreCompleto.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombreCompleto.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxNombreCompleto.ForeColor = SystemColors.ControlText;
            textBoxNombreCompleto.Location = new Point(22, 247);
            textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            textBoxNombreCompleto.ReadOnly = true;
            textBoxNombreCompleto.Size = new Size(238, 27);
            textBoxNombreCompleto.TabIndex = 36;
            textBoxNombreCompleto.TabStop = false;
            // 
            // comboBoxCantidad
            // 
            comboBoxCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCantidad.Enabled = false;
            comboBoxCantidad.FlatStyle = FlatStyle.Flat;
            comboBoxCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            comboBoxCantidad.ForeColor = SystemColors.ControlText;
            comboBoxCantidad.FormattingEnabled = true;
            comboBoxCantidad.Location = new Point(579, 179);
            comboBoxCantidad.Name = "comboBoxCantidad";
            comboBoxCantidad.Size = new Size(238, 27);
            comboBoxCantidad.TabIndex = 3;
            comboBoxCantidad.SelectedIndexChanged += comboBoxCantidad_SelectedIndexChanged;
            // 
            // labelCantidad
            // 
            labelCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            labelCantidad.ForeColor = SystemColors.ControlText;
            labelCantidad.Location = new Point(579, 152);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(139, 23);
            labelCantidad.TabIndex = 35;
            labelCantidad.Text = "Cantidad de :";
            // 
            // labelPesos
            // 
            labelPesos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPesos.AutoSize = true;
            labelPesos.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            labelPesos.ForeColor = SystemColors.ControlText;
            labelPesos.Location = new Point(796, 249);
            labelPesos.Name = "labelPesos";
            labelPesos.Size = new Size(21, 23);
            labelPesos.TabIndex = 33;
            labelPesos.Text = "$";
            // 
            // labelCodigoCuota
            // 
            labelCodigoCuota.AutoSize = true;
            labelCodigoCuota.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            labelCodigoCuota.ForeColor = SystemColors.ControlText;
            labelCodigoCuota.Location = new Point(22, 84);
            labelCodigoCuota.Name = "labelCodigoCuota";
            labelCodigoCuota.Size = new Size(174, 23);
            labelCodigoCuota.TabIndex = 32;
            labelCodigoCuota.Text = "Código de cuota:";
            // 
            // textBoxCodigoCuota
            // 
            textBoxCodigoCuota.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigoCuota.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxCodigoCuota.ForeColor = SystemColors.ControlText;
            textBoxCodigoCuota.Location = new Point(22, 111);
            textBoxCodigoCuota.Name = "textBoxCodigoCuota";
            textBoxCodigoCuota.ReadOnly = true;
            textBoxCodigoCuota.Size = new Size(238, 27);
            textBoxCodigoCuota.TabIndex = 31;
            textBoxCodigoCuota.TabStop = false;
            // 
            // labelTipoCuota
            // 
            labelTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTipoCuota.AutoSize = true;
            labelTipoCuota.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            labelTipoCuota.ForeColor = SystemColors.ControlText;
            labelTipoCuota.Location = new Point(579, 84);
            labelTipoCuota.Name = "labelTipoCuota";
            labelTipoCuota.Size = new Size(142, 23);
            labelTipoCuota.TabIndex = 30;
            labelTipoCuota.Text = "Tipo de cuota:";
            // 
            // comboBoxTipoCuota
            // 
            comboBoxTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxTipoCuota.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoCuota.FlatStyle = FlatStyle.Flat;
            comboBoxTipoCuota.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            comboBoxTipoCuota.ForeColor = SystemColors.ControlText;
            comboBoxTipoCuota.FormattingEnabled = true;
            comboBoxTipoCuota.Items.AddRange(new object[] { "Seleccione una opción", "Mensual", "Semanal", "Diaria" });
            comboBoxTipoCuota.Location = new Point(579, 110);
            comboBoxTipoCuota.Name = "comboBoxTipoCuota";
            comboBoxTipoCuota.Size = new Size(238, 27);
            comboBoxTipoCuota.TabIndex = 2;
            comboBoxTipoCuota.SelectedIndexChanged += comboBoxTipoCuota_SelectedIndexChanged;
            // 
            // labelFechaPago
            // 
            labelFechaPago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelFechaPago.AutoSize = true;
            labelFechaPago.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            labelFechaPago.ForeColor = SystemColors.ControlText;
            labelFechaPago.Location = new Point(296, 84);
            labelFechaPago.Name = "labelFechaPago";
            labelFechaPago.Size = new Size(158, 23);
            labelFechaPago.TabIndex = 25;
            labelFechaPago.Text = "Fecha de pago:";
            // 
            // monthCalendarFechaPago
            // 
            monthCalendarFechaPago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            monthCalendarFechaPago.BackColor = Color.FromArgb(168, 178, 179);
            monthCalendarFechaPago.ForeColor = Color.Black;
            monthCalendarFechaPago.Location = new Point(296, 111);
            monthCalendarFechaPago.MaxSelectionCount = 1;
            monthCalendarFechaPago.Name = "monthCalendarFechaPago";
            monthCalendarFechaPago.TabIndex = 3;
            monthCalendarFechaPago.TabStop = false;
            // 
            // labelCodigoSocio
            // 
            labelCodigoSocio.AutoSize = true;
            labelCodigoSocio.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            labelCodigoSocio.ForeColor = SystemColors.ControlText;
            labelCodigoSocio.Location = new Point(22, 152);
            labelCodigoSocio.Name = "labelCodigoSocio";
            labelCodigoSocio.Size = new Size(172, 23);
            labelCodigoSocio.TabIndex = 22;
            labelCodigoSocio.Text = "Número de socio:";
            // 
            // textBoxCodigoSocio
            // 
            textBoxCodigoSocio.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigoSocio.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxCodigoSocio.ForeColor = SystemColors.ControlText;
            textBoxCodigoSocio.Location = new Point(22, 179);
            textBoxCodigoSocio.Name = "textBoxCodigoSocio";
            textBoxCodigoSocio.Size = new Size(238, 27);
            textBoxCodigoSocio.TabIndex = 0;
            textBoxCodigoSocio.TextChanged += textBoxCodigoSocio_TextChanged;
            // 
            // buttonCancelOperation
            // 
            buttonCancelOperation.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonCancelOperation.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancelOperation.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonCancelOperation.FlatAppearance.BorderSize = 2;
            buttonCancelOperation.FlatStyle = FlatStyle.Flat;
            buttonCancelOperation.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonCancelOperation.ForeColor = Color.White;
            buttonCancelOperation.Image = (Image)resources.GetObject("buttonCancelOperation.Image");
            buttonCancelOperation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelOperation.Location = new Point(303, 446);
            buttonCancelOperation.Name = "buttonCancelOperation";
            buttonCancelOperation.Size = new Size(240, 38);
            buttonCancelOperation.TabIndex = 7;
            buttonCancelOperation.Text = "Cancelar";
            buttonCancelOperation.UseVisualStyleBackColor = false;
            buttonCancelOperation.MouseClick += buttonCancelOperation_MouseClick;
            // 
            // buttonSaveCuota
            // 
            buttonSaveCuota.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSaveCuota.BackColor = Color.FromArgb(128, 128, 255);
            buttonSaveCuota.Enabled = false;
            buttonSaveCuota.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonSaveCuota.FlatAppearance.BorderSize = 2;
            buttonSaveCuota.FlatStyle = FlatStyle.Flat;
            buttonSaveCuota.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonSaveCuota.ForeColor = Color.White;
            buttonSaveCuota.Image = (Image)resources.GetObject("buttonSaveCuota.Image");
            buttonSaveCuota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveCuota.Location = new Point(303, 402);
            buttonSaveCuota.Name = "buttonSaveCuota";
            buttonSaveCuota.Size = new Size(240, 38);
            buttonSaveCuota.TabIndex = 6;
            buttonSaveCuota.Text = "Guardar";
            buttonSaveCuota.UseVisualStyleBackColor = false;
            buttonSaveCuota.MouseClick += buttonSaveCuota_MouseClick;
            // 
            // buttonAddCuota
            // 
            buttonAddCuota.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonAddCuota.BackColor = Color.FromArgb(128, 128, 255);
            buttonAddCuota.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonAddCuota.FlatAppearance.BorderSize = 2;
            buttonAddCuota.FlatStyle = FlatStyle.Flat;
            buttonAddCuota.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonAddCuota.ForeColor = Color.White;
            buttonAddCuota.Image = (Image)resources.GetObject("buttonAddCuota.Image");
            buttonAddCuota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCuota.Location = new Point(303, 358);
            buttonAddCuota.Name = "buttonAddCuota";
            buttonAddCuota.Size = new Size(240, 38);
            buttonAddCuota.TabIndex = 5;
            buttonAddCuota.Text = "Añadir";
            buttonAddCuota.UseVisualStyleBackColor = false;
            buttonAddCuota.EnabledChanged += buttonAddCuota_EnabledChanged;
            buttonAddCuota.MouseClick += buttonAddCuota_MouseClick;
            // 
            // labelOperation
            // 
            labelOperation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelOperation.AutoSize = true;
            labelOperation.BackColor = Color.Transparent;
            labelOperation.BorderStyle = BorderStyle.FixedSingle;
            labelOperation.FlatStyle = FlatStyle.Flat;
            labelOperation.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            labelOperation.ForeColor = SystemColors.ControlText;
            labelOperation.Location = new Point(227, 26);
            labelOperation.Name = "labelOperation";
            labelOperation.Padding = new Padding(5);
            labelOperation.Size = new Size(220, 38);
            labelOperation.TabIndex = 19;
            labelOperation.Text = "Operación actual:";
            // 
            // labelMonto
            // 
            labelMonto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            labelMonto.ForeColor = SystemColors.ControlText;
            labelMonto.Location = new Point(579, 220);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(164, 23);
            labelMonto.TabIndex = 12;
            labelMonto.Text = "Monto a abonar:";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxMonto.BorderStyle = BorderStyle.FixedSingle;
            textBoxMonto.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxMonto.ForeColor = SystemColors.ControlText;
            textBoxMonto.Location = new Point(578, 247);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(212, 27);
            textBoxMonto.TabIndex = 4;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.IndianRed;
            buttonClose.FlatAppearance.BorderColor = Color.Firebrick;
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial Rounded MT Bold", 14.25F);
            buttonClose.ForeColor = Color.Firebrick;
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(774, 5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(76, 39);
            buttonClose.TabIndex = 8;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.MouseClick += buttonClose_MouseClick;
            // 
            // CuotaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 560);
            Controls.Add(buttonClose);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CuotaView";
            Text = "CuotaView";
            tabControl.ResumeLayout(false);
            tabPageDebtorsVisualizer.ResumeLayout(false);
            tabPageDebtorsVisualizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotasVencidas).EndInit();
            tabPageCuotasVisualizer.ResumeLayout(false);
            tabPageCuotasVisualizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotas).EndInit();
            tabPageAddOrEditCuota.ResumeLayout(false);
            tabPageAddOrEditCuota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageCuotasVisualizer;
        private TabPage tabPageAddOrEditCuota;
        private DataGridView dataGridViewCuotas;
        private Button buttonEditCuota;
        private Button buttonSearchCuota;
        private Button buttonDeleteCuota;
        private TextBox textBoxSearchCuota;
        private Label labelCodigoSocio;
        private TextBox textBoxCodigoSocio;
        private Button buttonCancelOperation;
        private Button buttonSaveCuota;
        private Button buttonAddCuota;
        private Label labelOperation;
        private Label labelMonto;
        private TextBox textBoxMonto;
        private MonthCalendar monthCalendarFechaPago;
        private Label labelFechaPago;
        private ComboBox comboBoxTipoCuota;
        private Label labelTipoCuota;
        private Button buttonClose;
        private TabPage tabPageDebtorsVisualizer;
        private DataGridView dataGridViewCuotasVencidas;
        private Label labelCodigoCuota;
        private TextBox textBoxCodigoCuota;
        private Button buttonSearchDebt;
        private TextBox textBoxSearchDebt;
        private Label labelPesos;
        private ComboBox comboBoxCantidad;
        private Label labelCantidad;
        private Label labelNombreCompletoSocio;
        private TextBox textBoxNombreCompleto;
    }
}
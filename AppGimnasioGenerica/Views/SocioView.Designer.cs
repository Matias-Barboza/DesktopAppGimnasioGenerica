namespace DesktopAppGimnasio.Views
{
    partial class SocioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocioView));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabPageSociosVisualizer = new TabPage();
            buttonEdit = new Button();
            buttonSearchSocio = new Button();
            buttonDelete = new Button();
            textBoxSearchSocio = new TextBox();
            dataGridViewSocios = new DataGridView();
            tabPageAddOrEditSocio = new TabPage();
            checkBoxEstado = new CheckBox();
            labelEstadoActividad = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            labelCodigoSocio = new Label();
            buttonAdd = new Button();
            textBoxName = new TextBox();
            labelOperation = new Label();
            labelLastName = new Label();
            textBoxCodigoSocio = new TextBox();
            labelName = new Label();
            textBoxLastName = new TextBox();
            labelDNI = new Label();
            textBoxDNI = new TextBox();
            buttonClose = new Button();
            tabControl.SuspendLayout();
            tabPageSociosVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
            tabPageAddOrEditSocio.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageSociosVisualizer);
            tabControl.Controls.Add(tabPageAddOrEditSocio);
            tabControl.Font = new Font("Arial Rounded MT Bold", 12F);
            tabControl.Location = new Point(0, 12);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(10, 8);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(855, 548);
            tabControl.TabIndex = 1;
            tabControl.TabStop = false;
            // 
            // tabPageSociosVisualizer
            // 
            tabPageSociosVisualizer.Controls.Add(buttonEdit);
            tabPageSociosVisualizer.Controls.Add(buttonSearchSocio);
            tabPageSociosVisualizer.Controls.Add(buttonDelete);
            tabPageSociosVisualizer.Controls.Add(textBoxSearchSocio);
            tabPageSociosVisualizer.Controls.Add(dataGridViewSocios);
            tabPageSociosVisualizer.Location = new Point(4, 37);
            tabPageSociosVisualizer.Name = "tabPageSociosVisualizer";
            tabPageSociosVisualizer.Padding = new Padding(3);
            tabPageSociosVisualizer.Size = new Size(847, 507);
            tabPageSociosVisualizer.TabIndex = 3;
            tabPageSociosVisualizer.Text = "Administración de socios";
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.BackColor = Color.FromArgb(128, 128, 255);
            buttonEdit.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonEdit.FlatAppearance.BorderSize = 2;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(717, 62);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 39);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "  Editar";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.MouseClick += buttonEdit_MouseClick;
            // 
            // buttonSearchSocio
            // 
            buttonSearchSocio.BackColor = Color.FromArgb(128, 128, 255);
            buttonSearchSocio.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonSearchSocio.FlatAppearance.BorderSize = 2;
            buttonSearchSocio.FlatStyle = FlatStyle.Flat;
            buttonSearchSocio.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            buttonSearchSocio.ForeColor = Color.White;
            buttonSearchSocio.Image = (Image)resources.GetObject("buttonSearchSocio.Image");
            buttonSearchSocio.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearchSocio.Location = new Point(409, 20);
            buttonSearchSocio.Name = "buttonSearchSocio";
            buttonSearchSocio.Size = new Size(100, 32);
            buttonSearchSocio.TabIndex = 1;
            buttonSearchSocio.Text = "Buscar";
            buttonSearchSocio.TextAlign = ContentAlignment.MiddleLeft;
            buttonSearchSocio.UseVisualStyleBackColor = false;
            buttonSearchSocio.MouseClick += buttonSearchSocio_MouseClick;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.BackColor = Color.FromArgb(128, 128, 255);
            buttonDelete.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonDelete.FlatAppearance.BorderSize = 2;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(717, 107);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(125, 39);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "    Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.MouseClick += buttonDelete_MouseClick;
            // 
            // textBoxSearchSocio
            // 
            textBoxSearchSocio.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchSocio.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            textBoxSearchSocio.ForeColor = SystemColors.ControlText;
            textBoxSearchSocio.Location = new Point(6, 21);
            textBoxSearchSocio.Name = "textBoxSearchSocio";
            textBoxSearchSocio.Size = new Size(397, 29);
            textBoxSearchSocio.TabIndex = 0;
            textBoxSearchSocio.KeyDown += textBoxSearchSocio_KeyDown;
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.AllowUserToAddRows = false;
            dataGridViewSocios.AllowUserToDeleteRows = false;
            dataGridViewSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSocios.BackgroundColor = SystemColors.Control;
            dataGridViewSocios.BorderStyle = BorderStyle.None;
            dataGridViewSocios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 14.25F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewSocios.ColumnHeadersHeight = 50;
            dataGridViewSocios.EnableHeadersVisualStyles = false;
            dataGridViewSocios.GridColor = Color.Black;
            dataGridViewSocios.Location = new Point(6, 62);
            dataGridViewSocios.MultiSelect = false;
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.ReadOnly = true;
            dataGridViewSocios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Arial Rounded MT Bold", 12F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewSocios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewSocios.RowHeadersVisible = false;
            dataGridViewSocios.RowHeadersWidth = 20;
            dataGridViewSocios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Arial Rounded MT Bold", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewSocios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewSocios.RowTemplate.Height = 30;
            dataGridViewSocios.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSocios.Size = new Size(705, 437);
            dataGridViewSocios.TabIndex = 4;
            dataGridViewSocios.TabStop = false;
            // 
            // tabPageAddOrEditSocio
            // 
            tabPageAddOrEditSocio.BackColor = SystemColors.Control;
            tabPageAddOrEditSocio.Controls.Add(checkBoxEstado);
            tabPageAddOrEditSocio.Controls.Add(labelEstadoActividad);
            tabPageAddOrEditSocio.Controls.Add(buttonCancel);
            tabPageAddOrEditSocio.Controls.Add(buttonSave);
            tabPageAddOrEditSocio.Controls.Add(labelCodigoSocio);
            tabPageAddOrEditSocio.Controls.Add(buttonAdd);
            tabPageAddOrEditSocio.Controls.Add(textBoxName);
            tabPageAddOrEditSocio.Controls.Add(labelOperation);
            tabPageAddOrEditSocio.Controls.Add(labelLastName);
            tabPageAddOrEditSocio.Controls.Add(textBoxCodigoSocio);
            tabPageAddOrEditSocio.Controls.Add(labelName);
            tabPageAddOrEditSocio.Controls.Add(textBoxLastName);
            tabPageAddOrEditSocio.Controls.Add(labelDNI);
            tabPageAddOrEditSocio.Controls.Add(textBoxDNI);
            tabPageAddOrEditSocio.Font = new Font("Arial Rounded MT Bold", 12F);
            tabPageAddOrEditSocio.Location = new Point(4, 37);
            tabPageAddOrEditSocio.Name = "tabPageAddOrEditSocio";
            tabPageAddOrEditSocio.Padding = new Padding(3);
            tabPageAddOrEditSocio.Size = new Size(847, 507);
            tabPageAddOrEditSocio.TabIndex = 1;
            tabPageAddOrEditSocio.Text = "Añadir/Editar Socio";
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.FlatAppearance.BorderColor = Color.Black;
            checkBoxEstado.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 192);
            checkBoxEstado.FlatStyle = FlatStyle.Flat;
            checkBoxEstado.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            checkBoxEstado.ForeColor = SystemColors.ControlText;
            checkBoxEstado.Location = new Point(303, 111);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Padding = new Padding(5, 3, 120, 2);
            checkBoxEstado.Size = new Size(199, 28);
            checkBoxEstado.TabIndex = 3;
            checkBoxEstado.Text = "Activo";
            checkBoxEstado.UseVisualStyleBackColor = false;
            checkBoxEstado.Visible = false;
            // 
            // labelEstadoActividad
            // 
            labelEstadoActividad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEstadoActividad.AutoSize = true;
            labelEstadoActividad.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            labelEstadoActividad.ForeColor = SystemColors.ControlText;
            labelEstadoActividad.Location = new Point(303, 84);
            labelEstadoActividad.Name = "labelEstadoActividad";
            labelEstadoActividad.Size = new Size(203, 23);
            labelEstadoActividad.TabIndex = 12;
            labelEstadoActividad.Text = "Estado de actividad:";
            labelEstadoActividad.Visible = false;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancel.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(303, 446);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(240, 38);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.MouseClick += buttonCancel_MouseClick;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave.Enabled = false;
            buttonSave.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonSave.FlatAppearance.BorderSize = 2;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(303, 402);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(240, 38);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.MouseClick += buttonSave_MouseClick;
            // 
            // labelCodigoSocio
            // 
            labelCodigoSocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCodigoSocio.AutoSize = true;
            labelCodigoSocio.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            labelCodigoSocio.ForeColor = SystemColors.ControlText;
            labelCodigoSocio.Location = new Point(22, 84);
            labelCodigoSocio.Name = "labelCodigoSocio";
            labelCodigoSocio.Size = new Size(172, 23);
            labelCodigoSocio.TabIndex = 10;
            labelCodigoSocio.Text = "Número de socio:";
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.BackColor = Color.FromArgb(128, 128, 255);
            buttonAdd.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(303, 358);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(240, 38);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Añadir";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.EnabledChanged += buttonAdd_EnabledChanged;
            buttonAdd.MouseClick += buttonAdd_MouseClick;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BackColor = SystemColors.Control;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxName.ForeColor = SystemColors.ControlText;
            textBoxName.Location = new Point(22, 241);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(238, 27);
            textBoxName.TabIndex = 1;
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
            labelOperation.TabIndex = 6;
            labelOperation.Text = "Operación actual:";
            // 
            // labelLastName
            // 
            labelLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            labelLastName.ForeColor = SystemColors.ControlText;
            labelLastName.Location = new Point(22, 283);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(94, 23);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Apellido:";
            // 
            // textBoxCodigoSocio
            // 
            textBoxCodigoSocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCodigoSocio.BackColor = SystemColors.Control;
            textBoxCodigoSocio.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigoSocio.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxCodigoSocio.ForeColor = SystemColors.ControlText;
            textBoxCodigoSocio.Location = new Point(22, 111);
            textBoxCodigoSocio.Name = "textBoxCodigoSocio";
            textBoxCodigoSocio.ReadOnly = true;
            textBoxCodigoSocio.Size = new Size(238, 27);
            textBoxCodigoSocio.TabIndex = 11;
            textBoxCodigoSocio.TabStop = false;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            labelName.ForeColor = SystemColors.ControlText;
            labelName.Location = new Point(22, 217);
            labelName.Name = "labelName";
            labelName.Size = new Size(90, 23);
            labelName.TabIndex = 2;
            labelName.Text = "Nombre:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLastName.BackColor = SystemColors.Control;
            textBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxLastName.ForeColor = SystemColors.ControlText;
            textBoxLastName.Location = new Point(22, 309);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(238, 27);
            textBoxLastName.TabIndex = 2;
            // 
            // labelDNI
            // 
            labelDNI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            labelDNI.ForeColor = SystemColors.ControlText;
            labelDNI.Location = new Point(22, 152);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(47, 23);
            labelDNI.TabIndex = 0;
            labelDNI.Text = "DNI:";
            // 
            // textBoxDNI
            // 
            textBoxDNI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDNI.BackColor = SystemColors.Control;
            textBoxDNI.BorderStyle = BorderStyle.FixedSingle;
            textBoxDNI.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxDNI.ForeColor = SystemColors.ControlText;
            textBoxDNI.Location = new Point(22, 179);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(238, 27);
            textBoxDNI.TabIndex = 0;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.IndianRed;
            buttonClose.FlatAppearance.BorderColor = Color.Firebrick;
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial Rounded MT Bold", 15.75F);
            buttonClose.ForeColor = Color.Firebrick;
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(774, 5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(76, 39);
            buttonClose.TabIndex = 7;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.MouseClick += buttonClose_MouseClick;
            // 
            // SocioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 560);
            Controls.Add(buttonClose);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SocioView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel de administración de socios";
            tabControl.ResumeLayout(false);
            tabPageSociosVisualizer.ResumeLayout(false);
            tabPageSociosVisualizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).EndInit();
            tabPageAddOrEditSocio.ResumeLayout(false);
            tabPageAddOrEditSocio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl;
        private TabPage tabPageAddOrEditSocio;
        private TabPage tabPageSociosVisualizer;
        private DataGridView dataGridViewSocios;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxDNI;
        private Label labelDNI;
        private Label labelOperation;
        private Button buttonSearchSocio;
        private TextBox textBoxSearchSocio;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonClose;
        private Button buttonEdit;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelCodigoSocio;
        private TextBox textBoxCodigoSocio;
        private CheckBox checkBoxEstado;
        private Label labelEstadoActividad;
    }
}
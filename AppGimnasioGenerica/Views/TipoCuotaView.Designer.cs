namespace DesktopAppGimnasio.Views
{
    partial class TipoCuotaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoCuotaView));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            buttonClose = new Button();
            tabControl = new TabControl();
            tabPageTiposCuotasVisualizer = new TabPage();
            buttonEditTipoCuota = new Button();
            dataGridViewTiposCuotas = new DataGridView();
            tabPageEditCuota = new TabPage();
            buttonSaveTipoCuota = new Button();
            buttonCancelOperation = new Button();
            labelIDTipoCuota = new Label();
            textBoxValorActual = new TextBox();
            labelOperation = new Label();
            textBoxIDTipoCuota = new TextBox();
            labelValorActual = new Label();
            labelDescripcion = new Label();
            textBoxDescripcion = new TextBox();
            tabControl.SuspendLayout();
            tabPageTiposCuotasVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposCuotas).BeginInit();
            tabPageEditCuota.SuspendLayout();
            SuspendLayout();
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
            buttonClose.TabIndex = 3;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.MouseClick += buttonClose_MouseClick;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageTiposCuotasVisualizer);
            tabControl.Controls.Add(tabPageEditCuota);
            tabControl.Font = new Font("Arial Rounded MT Bold", 12F);
            tabControl.Location = new Point(0, 12);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(10, 8);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(855, 548);
            tabControl.TabIndex = 8;
            tabControl.TabStop = false;
            // 
            // tabPageTiposCuotasVisualizer
            // 
            tabPageTiposCuotasVisualizer.Controls.Add(buttonEditTipoCuota);
            tabPageTiposCuotasVisualizer.Controls.Add(dataGridViewTiposCuotas);
            tabPageTiposCuotasVisualizer.Location = new Point(4, 37);
            tabPageTiposCuotasVisualizer.Name = "tabPageTiposCuotasVisualizer";
            tabPageTiposCuotasVisualizer.Size = new Size(847, 507);
            tabPageTiposCuotasVisualizer.TabIndex = 2;
            tabPageTiposCuotasVisualizer.Text = "Administración de valores de cuotas";
            // 
            // buttonEditTipoCuota
            // 
            buttonEditTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditTipoCuota.BackColor = Color.FromArgb(128, 128, 255);
            buttonEditTipoCuota.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonEditTipoCuota.FlatAppearance.BorderSize = 2;
            buttonEditTipoCuota.FlatStyle = FlatStyle.Flat;
            buttonEditTipoCuota.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonEditTipoCuota.ForeColor = Color.White;
            buttonEditTipoCuota.Image = (Image)resources.GetObject("buttonEditTipoCuota.Image");
            buttonEditTipoCuota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditTipoCuota.Location = new Point(714, 14);
            buttonEditTipoCuota.Name = "buttonEditTipoCuota";
            buttonEditTipoCuota.Size = new Size(125, 39);
            buttonEditTipoCuota.TabIndex = 0;
            buttonEditTipoCuota.Text = "  Editar";
            buttonEditTipoCuota.UseVisualStyleBackColor = false;
            buttonEditTipoCuota.MouseClick += buttonEditTipoCuota_MouseClick;
            // 
            // dataGridViewTiposCuotas
            // 
            dataGridViewTiposCuotas.AllowUserToAddRows = false;
            dataGridViewTiposCuotas.AllowUserToDeleteRows = false;
            dataGridViewTiposCuotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTiposCuotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTiposCuotas.BackgroundColor = SystemColors.Control;
            dataGridViewTiposCuotas.BorderStyle = BorderStyle.None;
            dataGridViewTiposCuotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 14.25F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTiposCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTiposCuotas.ColumnHeadersHeight = 50;
            dataGridViewTiposCuotas.EnableHeadersVisualStyles = false;
            dataGridViewTiposCuotas.GridColor = Color.Black;
            dataGridViewTiposCuotas.Location = new Point(6, 62);
            dataGridViewTiposCuotas.MultiSelect = false;
            dataGridViewTiposCuotas.Name = "dataGridViewTiposCuotas";
            dataGridViewTiposCuotas.ReadOnly = true;
            dataGridViewTiposCuotas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewTiposCuotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTiposCuotas.RowHeadersVisible = false;
            dataGridViewTiposCuotas.RowHeadersWidth = 20;
            dataGridViewTiposCuotas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewTiposCuotas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTiposCuotas.RowTemplate.Height = 30;
            dataGridViewTiposCuotas.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewTiposCuotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTiposCuotas.Size = new Size(835, 438);
            dataGridViewTiposCuotas.TabIndex = 6;
            dataGridViewTiposCuotas.TabStop = false;
            // 
            // tabPageEditCuota
            // 
            tabPageEditCuota.Controls.Add(buttonSaveTipoCuota);
            tabPageEditCuota.Controls.Add(buttonCancelOperation);
            tabPageEditCuota.Controls.Add(labelIDTipoCuota);
            tabPageEditCuota.Controls.Add(textBoxValorActual);
            tabPageEditCuota.Controls.Add(labelOperation);
            tabPageEditCuota.Controls.Add(textBoxIDTipoCuota);
            tabPageEditCuota.Controls.Add(labelValorActual);
            tabPageEditCuota.Controls.Add(labelDescripcion);
            tabPageEditCuota.Controls.Add(textBoxDescripcion);
            tabPageEditCuota.Font = new Font("Arial Rounded MT Bold", 12F);
            tabPageEditCuota.Location = new Point(4, 37);
            tabPageEditCuota.Name = "tabPageEditCuota";
            tabPageEditCuota.Padding = new Padding(3);
            tabPageEditCuota.Size = new Size(847, 507);
            tabPageEditCuota.TabIndex = 1;
            tabPageEditCuota.Text = "Editar valores de cuotas";
            // 
            // buttonSaveTipoCuota
            // 
            buttonSaveTipoCuota.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSaveTipoCuota.BackColor = Color.FromArgb(128, 128, 255);
            buttonSaveTipoCuota.Enabled = false;
            buttonSaveTipoCuota.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonSaveTipoCuota.FlatAppearance.BorderSize = 2;
            buttonSaveTipoCuota.FlatStyle = FlatStyle.Flat;
            buttonSaveTipoCuota.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            buttonSaveTipoCuota.ForeColor = Color.White;
            buttonSaveTipoCuota.Image = (Image)resources.GetObject("buttonSaveTipoCuota.Image");
            buttonSaveTipoCuota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveTipoCuota.Location = new Point(303, 358);
            buttonSaveTipoCuota.Name = "buttonSaveTipoCuota";
            buttonSaveTipoCuota.Size = new Size(240, 38);
            buttonSaveTipoCuota.TabIndex = 1;
            buttonSaveTipoCuota.Text = "Guardar";
            buttonSaveTipoCuota.UseVisualStyleBackColor = false;
            buttonSaveTipoCuota.MouseClick += buttonSaveTipoCuota_MouseClick;
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
            buttonCancelOperation.Location = new Point(303, 402);
            buttonCancelOperation.Name = "buttonCancelOperation";
            buttonCancelOperation.Size = new Size(240, 38);
            buttonCancelOperation.TabIndex = 2;
            buttonCancelOperation.Text = "Cancelar";
            buttonCancelOperation.UseVisualStyleBackColor = false;
            buttonCancelOperation.MouseClick += buttonCancelOperation_MouseClick;
            // 
            // labelIDTipoCuota
            // 
            labelIDTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelIDTipoCuota.AutoSize = true;
            labelIDTipoCuota.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            labelIDTipoCuota.ForeColor = SystemColors.ControlText;
            labelIDTipoCuota.Location = new Point(22, 84);
            labelIDTipoCuota.Name = "labelIDTipoCuota";
            labelIDTipoCuota.Size = new Size(163, 23);
            labelIDTipoCuota.TabIndex = 19;
            labelIDTipoCuota.Text = "ID tipo de cuota:";
            // 
            // textBoxValorActual
            // 
            textBoxValorActual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxValorActual.BackColor = SystemColors.Control;
            textBoxValorActual.BorderStyle = BorderStyle.FixedSingle;
            textBoxValorActual.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxValorActual.ForeColor = SystemColors.ControlText;
            textBoxValorActual.Location = new Point(22, 241);
            textBoxValorActual.Name = "textBoxValorActual";
            textBoxValorActual.Size = new Size(238, 27);
            textBoxValorActual.TabIndex = 0;
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
            labelOperation.TabIndex = 18;
            labelOperation.Text = "Operación actual:";
            // 
            // textBoxIDTipoCuota
            // 
            textBoxIDTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIDTipoCuota.BackColor = SystemColors.Control;
            textBoxIDTipoCuota.BorderStyle = BorderStyle.FixedSingle;
            textBoxIDTipoCuota.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxIDTipoCuota.ForeColor = SystemColors.ControlText;
            textBoxIDTipoCuota.Location = new Point(22, 111);
            textBoxIDTipoCuota.Name = "textBoxIDTipoCuota";
            textBoxIDTipoCuota.ReadOnly = true;
            textBoxIDTipoCuota.Size = new Size(238, 27);
            textBoxIDTipoCuota.TabIndex = 20;
            textBoxIDTipoCuota.TabStop = false;
            // 
            // labelValorActual
            // 
            labelValorActual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelValorActual.AutoSize = true;
            labelValorActual.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            labelValorActual.ForeColor = SystemColors.ControlText;
            labelValorActual.Location = new Point(22, 217);
            labelValorActual.Name = "labelValorActual";
            labelValorActual.Size = new Size(129, 23);
            labelValorActual.TabIndex = 15;
            labelValorActual.Text = "Valor actual:";
            // 
            // labelDescripcion
            // 
            labelDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            labelDescripcion.ForeColor = SystemColors.ControlText;
            labelDescripcion.Location = new Point(22, 152);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(124, 23);
            labelDescripcion.TabIndex = 12;
            labelDescripcion.Text = "Descripción:";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescripcion.BackColor = SystemColors.Control;
            textBoxDescripcion.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            textBoxDescripcion.ForeColor = SystemColors.ControlText;
            textBoxDescripcion.Location = new Point(22, 179);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.ReadOnly = true;
            textBoxDescripcion.Size = new Size(238, 27);
            textBoxDescripcion.TabIndex = 0;
            textBoxDescripcion.TabStop = false;
            // 
            // TipoCuotaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(855, 560);
            Controls.Add(buttonClose);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TipoCuotaView";
            Text = "TipoCuotaView";
            tabControl.ResumeLayout(false);
            tabPageTiposCuotasVisualizer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposCuotas).EndInit();
            tabPageEditCuota.ResumeLayout(false);
            tabPageEditCuota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClose;
        private TabControl tabControl;
        private TabPage tabPageSociosVisualizer;
        private TabPage tabPageEditCuota;
        private Button buttonCancelOperation;
        private Button buttonSaveTipoCuota;
        private Button buttonEditTipoCuota;
        private Label labelIDTipoCuota;
        private TextBox textBoxValorActual;
        private Label labelOperation;
        private TextBox textBoxIDTipoCuota;
        private Label labelValorActual;
        private Label labelDescripcion;
        private TextBox textBoxDescripcion;
        private TabPage tabPageTiposCuotasVisualizer;
        private DataGridView dataGridViewTiposCuotas;
    }
}
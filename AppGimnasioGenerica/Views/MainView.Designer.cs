namespace DesktopAppGimnasio.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            buttonSocios = new Button();
            buttonCuotas = new Button();
            panelLeft = new Panel();
            buttonInfo = new Button();
            buttonTiposCuotas = new Button();
            pictureBoxLogo = new PictureBox();
            labelSections = new Label();
            buttonClose = new Button();
            panelTop = new Panel();
            panelToolBarContainer = new Panel();
            panelMove = new Panel();
            buttonMinimize = new Button();
            buttonMaximize = new Button();
            buttonCloseTB = new Button();
            panelYellowLine = new Panel();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelToolBarContainer.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSocios
            // 
            buttonSocios.BackColor = Color.Transparent;
            buttonSocios.Cursor = Cursors.Hand;
            buttonSocios.FlatAppearance.BorderColor = Color.Black;
            buttonSocios.FlatAppearance.BorderSize = 2;
            buttonSocios.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonSocios.FlatStyle = FlatStyle.Flat;
            buttonSocios.Font = new Font("Arial Rounded MT Bold", 13F);
            buttonSocios.ForeColor = SystemColors.ControlText;
            buttonSocios.Image = (Image)resources.GetObject("buttonSocios.Image");
            buttonSocios.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSocios.Location = new Point(5, 150);
            buttonSocios.Name = "buttonSocios";
            buttonSocios.Size = new Size(292, 40);
            buttonSocios.TabIndex = 0;
            buttonSocios.Text = "Socios";
            buttonSocios.UseVisualStyleBackColor = false;
            buttonSocios.KeyDown += buttonSocios_KeyDown;
            buttonSocios.MouseClick += buttonSocios_MouseClick;
            // 
            // buttonCuotas
            // 
            buttonCuotas.BackColor = Color.Transparent;
            buttonCuotas.Cursor = Cursors.Hand;
            buttonCuotas.FlatAppearance.BorderColor = Color.Black;
            buttonCuotas.FlatAppearance.BorderSize = 2;
            buttonCuotas.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonCuotas.FlatStyle = FlatStyle.Flat;
            buttonCuotas.Font = new Font("Arial Rounded MT Bold", 13F);
            buttonCuotas.ForeColor = SystemColors.ControlText;
            buttonCuotas.Image = (Image)resources.GetObject("buttonCuotas.Image");
            buttonCuotas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCuotas.Location = new Point(5, 196);
            buttonCuotas.Name = "buttonCuotas";
            buttonCuotas.Size = new Size(292, 40);
            buttonCuotas.TabIndex = 1;
            buttonCuotas.Text = "Cuotas";
            buttonCuotas.UseVisualStyleBackColor = false;
            buttonCuotas.KeyDown += buttonCuotas_KeyDown;
            buttonCuotas.MouseClick += buttonCuotas_MouseClick;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.Control;
            panelLeft.BackgroundImageLayout = ImageLayout.Stretch;
            panelLeft.Controls.Add(buttonInfo);
            panelLeft.Controls.Add(buttonTiposCuotas);
            panelLeft.Controls.Add(pictureBoxLogo);
            panelLeft.Controls.Add(labelSections);
            panelLeft.Controls.Add(buttonClose);
            panelLeft.Controls.Add(buttonSocios);
            panelLeft.Controls.Add(buttonCuotas);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(300, 710);
            panelLeft.TabIndex = 3;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.Transparent;
            buttonInfo.Cursor = Cursors.Hand;
            buttonInfo.FlatAppearance.BorderColor = Color.Black;
            buttonInfo.FlatAppearance.BorderSize = 2;
            buttonInfo.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Font = new Font("Arial Rounded MT Bold", 13F);
            buttonInfo.ForeColor = SystemColors.ControlText;
            buttonInfo.Image = (Image)resources.GetObject("buttonInfo.Image");
            buttonInfo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInfo.Location = new Point(5, 288);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(292, 40);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Acerca de";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.MouseClick += buttonInfo_MouseClick;
            // 
            // buttonTiposCuotas
            // 
            buttonTiposCuotas.BackColor = Color.Transparent;
            buttonTiposCuotas.Cursor = Cursors.Hand;
            buttonTiposCuotas.FlatAppearance.BorderColor = Color.Black;
            buttonTiposCuotas.FlatAppearance.BorderSize = 2;
            buttonTiposCuotas.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonTiposCuotas.FlatStyle = FlatStyle.Flat;
            buttonTiposCuotas.Font = new Font("Arial Rounded MT Bold", 13F);
            buttonTiposCuotas.ForeColor = SystemColors.ControlText;
            buttonTiposCuotas.Image = (Image)resources.GetObject("buttonTiposCuotas.Image");
            buttonTiposCuotas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTiposCuotas.Location = new Point(5, 242);
            buttonTiposCuotas.Name = "buttonTiposCuotas";
            buttonTiposCuotas.Size = new Size(292, 40);
            buttonTiposCuotas.TabIndex = 2;
            buttonTiposCuotas.Text = "     Modificar valor de cuota";
            buttonTiposCuotas.UseVisualStyleBackColor = false;
            buttonTiposCuotas.KeyDown += buttonTiposCuotas_KeyDown;
            buttonTiposCuotas.MouseClick += buttonTiposCuotas_MouseClick;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Location = new Point(0, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(300, 110);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelSections
            // 
            labelSections.AutoSize = true;
            labelSections.BackColor = Color.Black;
            labelSections.BorderStyle = BorderStyle.FixedSingle;
            labelSections.Font = new Font("Arial Rounded MT Bold", 12F);
            labelSections.ForeColor = Color.White;
            labelSections.Location = new Point(0, 121);
            labelSections.Name = "labelSections";
            labelSections.Padding = new Padding(0, 3, 210, 3);
            labelSections.Size = new Size(304, 26);
            labelSections.TabIndex = 0;
            labelSections.Text = "Secciones";
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonClose.BackColor = Color.Transparent;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderColor = Color.Black;
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            buttonClose.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial Rounded MT Bold", 13F);
            buttonClose.ForeColor = SystemColors.ControlText;
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClose.Location = new Point(3, 658);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(294, 40);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Salir";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.MouseClick += buttonClose_MouseClick;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.Control;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(300, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(855, 110);
            panelTop.TabIndex = 4;
            // 
            // panelToolBarContainer
            // 
            panelToolBarContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelToolBarContainer.BackColor = SystemColors.Control;
            panelToolBarContainer.Controls.Add(panelMove);
            panelToolBarContainer.Controls.Add(buttonMinimize);
            panelToolBarContainer.Controls.Add(buttonMaximize);
            panelToolBarContainer.Controls.Add(buttonCloseTB);
            panelToolBarContainer.Location = new Point(300, 0);
            panelToolBarContainer.Name = "panelToolBarContainer";
            panelToolBarContainer.Size = new Size(855, 40);
            panelToolBarContainer.TabIndex = 5;
            // 
            // panelMove
            // 
            panelMove.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMove.BackColor = SystemColors.Control;
            panelMove.Location = new Point(3, 2);
            panelMove.Name = "panelMove";
            panelMove.Size = new Size(710, 36);
            panelMove.TabIndex = 3;
            panelMove.MouseDown += panelMove_MouseDown;
            panelMove.MouseMove += panelMove_MouseMove;
            panelMove.MouseUp += panelMove_MouseUp;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimize.BackColor = SystemColors.Control;
            buttonMinimize.FlatAppearance.BorderColor = Color.Black;
            buttonMinimize.FlatAppearance.BorderSize = 2;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.ForeColor = SystemColors.ControlText;
            buttonMinimize.Image = (Image)resources.GetObject("buttonMinimize.Image");
            buttonMinimize.Location = new Point(715, 2);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Padding = new Padding(0, 0, 1, 7);
            buttonMinimize.Size = new Size(42, 34);
            buttonMinimize.TabIndex = 5;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.MouseClick += buttonMinimize_MouseClick;
            // 
            // buttonMaximize
            // 
            buttonMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximize.BackColor = SystemColors.Control;
            buttonMaximize.FlatAppearance.BorderColor = Color.Black;
            buttonMaximize.FlatAppearance.BorderSize = 2;
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.ForeColor = SystemColors.ControlText;
            buttonMaximize.Image = (Image)resources.GetObject("buttonMaximize.Image");
            buttonMaximize.Location = new Point(763, 2);
            buttonMaximize.Name = "buttonMaximize";
            buttonMaximize.Padding = new Padding(0, 0, 1, 3);
            buttonMaximize.Size = new Size(42, 34);
            buttonMaximize.TabIndex = 6;
            buttonMaximize.UseVisualStyleBackColor = false;
            buttonMaximize.MouseClick += buttonMaximize_MouseClick;
            // 
            // buttonCloseTB
            // 
            buttonCloseTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCloseTB.BackColor = SystemColors.Control;
            buttonCloseTB.FlatAppearance.BorderColor = Color.Black;
            buttonCloseTB.FlatAppearance.BorderSize = 2;
            buttonCloseTB.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            buttonCloseTB.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            buttonCloseTB.FlatStyle = FlatStyle.Flat;
            buttonCloseTB.ForeColor = SystemColors.ControlText;
            buttonCloseTB.Image = (Image)resources.GetObject("buttonCloseTB.Image");
            buttonCloseTB.Location = new Point(811, 2);
            buttonCloseTB.Name = "buttonCloseTB";
            buttonCloseTB.Padding = new Padding(0, 0, 0, 1);
            buttonCloseTB.Size = new Size(42, 34);
            buttonCloseTB.TabIndex = 7;
            buttonCloseTB.UseVisualStyleBackColor = false;
            buttonCloseTB.MouseClick += buttonCloseTB_MouseClick;
            // 
            // panelYellowLine
            // 
            panelYellowLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelYellowLine.BackColor = Color.Black;
            panelYellowLine.Location = new Point(302, 40);
            panelYellowLine.Name = "panelYellowLine";
            panelYellowLine.Size = new Size(853, 10);
            panelYellowLine.TabIndex = 7;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1155, 710);
            ControlBox = false;
            Controls.Add(panelYellowLine);
            Controls.Add(panelToolBarContainer);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainView";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainView";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelToolBarContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSocios;
        private Button buttonCuotas;
        private Panel panelLeft;
        private Panel panelTop;
        private Button buttonClose;
        private Label labelSections;
        private PictureBox pictureBoxLogo;
        private Button buttonTiposCuotas;
        private Button buttonInfo;
        private Panel panelToolBarContainer;
        private Button buttonMinimize;
        private Button buttonMaximize;
        private Button buttonCloseTB;
        private Panel panelYellowLine;
        private Panel panelMove;
    }
}
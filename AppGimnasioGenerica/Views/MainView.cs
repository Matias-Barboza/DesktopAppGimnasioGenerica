﻿namespace DesktopAppGimnasio.Views
{
    public partial class MainView : Form, IMainView
    {
        private bool dragging;
        private Point startPoint;

        public MainView()
        {
            InitializeComponent();
        }

        public string InactiveSocios { get => buttonSociosInactivos.Text; set => buttonSociosInactivos.Text = value; }
        public string Debts { get => buttonCuotasImpagas.Text; set => buttonCuotasImpagas.Text = value; }
        public string UpcomingDebts { get => buttonProximasCuotasImpagas.Text; set => buttonProximasCuotasImpagas.Text = value; }

        //public event EventHandler ShowPresentationView;
        public event EventHandler ShowSociosView;
        public event EventHandler ShowInactiveSociosView;
        public event EventHandler ShowCuotasView;
        public event EventHandler ShowCuotasVencidasView;
        public event EventHandler ShowCuotasAVencerseView;
        public event EventHandler ShowTiposCuotasView;
        public event EventHandler ShowAboutView;

        public event EventHandler RefreshSociosQuickNotification;
        public event EventHandler RefreshCuotasQuickNotification;
        public event EventHandler RefreshCuotasAVencerseQuickNotification;
        public event EventHandler RefreshAllQuickNotifications;

        //private void MainView_Load(object sender, EventArgs e)
        //{
        //    ShowPresentationView?.Invoke(this, EventArgs.Empty);
        //}

        private void buttonSocios_MouseClick(object sender, MouseEventArgs e)
        {
            ShowSociosView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonSociosInactivos_MouseClick(object sender, MouseEventArgs e)
        {
            ShowInactiveSociosView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonCuotas_MouseClick(object sender, MouseEventArgs e)
        {
            ShowCuotasView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonCuotasImpagas_MouseClick(object sender, MouseEventArgs e)
        {
            ShowCuotasVencidasView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonProximasCuotasImpagas_MouseClick(object sender, MouseEventArgs e)
        {
            ShowCuotasAVencerseView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonTiposCuotas_MouseClick(object sender, MouseEventArgs e)
        {
            ShowTiposCuotasView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void buttonSocios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                ShowSociosView?.Invoke(this, EventArgs.Empty);
            }
        }

        private void buttonCuotas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D2)
            {
                ShowCuotasView?.Invoke(this, EventArgs.Empty);
            }
        }

        private void buttonTiposCuotas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D3)
            {
                ShowTiposCuotasView?.Invoke(this, EventArgs.Empty);
            }
        }

        private void buttonInfo_MouseClick(object sender, MouseEventArgs e)
        {
            ShowAboutView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonCloseTB_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void buttonMaximize_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }

            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = PointToScreen(e.Location);
                Location = new Point(newPoint.X - this.startPoint.X, newPoint.Y - this.startPoint.Y);
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            RefreshAllQuickNotifications?.Invoke(this, EventArgs.Empty);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RefreshAmountCuotasAVencerseQuickNotification();

            timer.Start();
        }

        public void RefreshQuickNotifications()
        {
            RefreshAllQuickNotifications?.Invoke(this, EventArgs.Empty);
        }

        public void RefreshAmountSociosQuickNotification()
        {
            RefreshSociosQuickNotification?.Invoke(this, EventArgs.Empty);
        }
        public void RefreshAmountCuotasQuickNotification()
        {
            RefreshCuotasQuickNotification?.Invoke(this, EventArgs.Empty);
        }

        public void RefreshAmountCuotasAVencerseQuickNotification()
        {
            RefreshCuotasAVencerseQuickNotification?.Invoke(this, EventArgs.Empty);
        }
    }
}

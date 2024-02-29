namespace DesktopAppGimnasio.Views
{
    public partial class PresentationView : Form, IPresentationView
    {
        public PresentationView()
        {
            InitializeComponent();
        }

        private static PresentationView instance;
        public static PresentationView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new PresentationView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {

                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }

            return instance;
        }
    }
}

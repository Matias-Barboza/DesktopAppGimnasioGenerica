namespace DesktopAppGimnasio.Views
{
    public interface IMainView
    {
        String InactiveSocios { get; set; }
        String Debts { get; set; }

        //event EventHandler ShowPresentationView;
        event EventHandler ShowSociosView;
        event EventHandler ShowCuotasView;
        event EventHandler ShowTiposCuotasView;
        event EventHandler ShowAboutView;

        event EventHandler RefreshSociosQuickNotification;
        event EventHandler RefreshCuotasQuickNotification;
        event EventHandler RefreshAllQuickNotifications;

        void RefreshQuickNotifications();
        void RefreshAmountSociosQuickNotification();
        void RefreshAmountCuotasQuickNotification();
    }
}

namespace DesktopAppGimnasio.Views
{
    public interface IMainView
    {
        String InactiveSocios { get; set; }
        String Debts { get; set; }
        String UpcomingDebts { get; set; }

        //event EventHandler ShowPresentationView;
        event EventHandler ShowSociosView;
        event EventHandler ShowInactiveSociosView;
        event EventHandler ShowCuotasView;
        event EventHandler ShowCuotasVencidasView;
        event EventHandler ShowCuotasAVencerseView;
        event EventHandler ShowTiposCuotasView;
        event EventHandler ShowAboutView;

        event EventHandler RefreshSociosQuickNotification;
        event EventHandler RefreshCuotasQuickNotification;
        event EventHandler RefreshCuotasAVencerseQuickNotification;
        event EventHandler RefreshAllQuickNotifications;

        void RefreshQuickNotifications();

        void RefreshAmountSociosQuickNotification();

        void RefreshAmountCuotasQuickNotification();

        void RefreshAmountCuotasAVencerseQuickNotification();
    }
}

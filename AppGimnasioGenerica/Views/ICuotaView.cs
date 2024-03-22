namespace DesktopAppGimnasio.Views
{
    public interface ICuotaView
    {
        // Properties - Fields
        int CodigoCuota { get; set; }
        int CodigoSocio { get; set; }
        String NombreYApellidoSocio { get; set; }
        DateTime FechaDePago { get; set; }
        DateTime FechaDeVencimiento { get; set; }
        String MesQueAbona { get; set; }
        float MontoAbonado { get; set; }
        int IdTipoCuota { get; set; }

        int Cantidad { get; set; }
        IEnumerable<float> Amounts { get; set; }
        string SearchValue { get; set; }
        string SearchDebtValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        String Message { get; set; }
        String Caption {  get; set; }
        bool MustEnter { get; set; }
        bool MustShowDebtsMessage {  get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler SearchDebtsEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        event EventHandler GetAmountsEvent;
        event EventHandler RefreshDataGridView;
        event EventHandler RefreshDebtsDataGridView;

        event EventHandler RefreshCuotasQuickNotification;

        event EventHandler SearchCoincidence;

        void SetCuotasBindingSource(BindingSource cuotasList);

        void SetCuotasVencidasBindingSource(BindingSource cuotasVencidasList);

        void SetStartTab(int index);

        Form GetMdiContainer();

        void HideColumn(int index);

        void HideDebtsDataGridColumn(int index);

        void ShowDebtsMessage(int count);

        void Show();
    }
}

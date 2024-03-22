using DesktopAppGimnasio._Repositories;
using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Views;

namespace DesktopAppGimnasio.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string SqlConnectionString;

        public MainPresenter(IMainView mainView, string SqlConnectionString)
        {
            this.mainView = mainView;
            this.SqlConnectionString = SqlConnectionString;
            //this.mainView.ShowPresentationView += ShowPresentationView;
            this.mainView.ShowSociosView += ShowSociosView;
            this.mainView.ShowInactiveSociosView += ShowInactiveSociosView;
            this.mainView.ShowCuotasView += ShowCuotasView;
            this.mainView.ShowCuotasVencidasView += ShowCuotasVencidasView;
            this.mainView.ShowCuotasAVencerseView += ShowCuotasAVencerseView;
            this.mainView.ShowTiposCuotasView += ShowTiposCuotasView;
            this.mainView.ShowAboutView += ShowAboutView;

            this.mainView.RefreshSociosQuickNotification += RefreshSociosQuickNotification;
            this.mainView.RefreshCuotasQuickNotification += RefreshCuotasQuickNotification;
            this.mainView.RefreshCuotasAVencerseQuickNotification += RefreshCuotasAVencerseQuickNotification;
            this.mainView.RefreshAllQuickNotifications += RefreshAllQuickNotifications;
        }

        //private void ShowPresentationView(object? sender, EventArgs e)
        //{
        //    IPresentationView presentationView = PresentationView.GetInstance((Form) mainView);
        //    PresentationPresenter presentationPresenter = new PresentationPresenter(presentationView);
        //}

        private void ShowSociosView(object? sender, EventArgs e)
        {
            ISocioView socioView = SocioView.GetInstance((Form) mainView);
            ISocioRepository socioRepository = new SocioRepository(SqlConnectionString);
            ICuotaRepository cuotaRepository = new CuotaRepository(SqlConnectionString);
            SocioPresenter socioPresenter = new SocioPresenter(socioView, socioRepository, cuotaRepository);
        }

        private void ShowInactiveSociosView(object? sender, EventArgs e)
        {
            ISocioView socioView = SocioView.GetInstance((Form)mainView);
            ISocioRepository socioRepository = new SocioRepository(SqlConnectionString);
            ICuotaRepository cuotaRepository = new CuotaRepository(SqlConnectionString);
            SocioPresenter socioPresenter = new SocioPresenter(socioView, socioRepository, cuotaRepository, 0);
        }

        private void ShowCuotasView(object? sender, EventArgs e)
        {
            ICuotaView cuotaView = CuotaView.GetInstance((Form) mainView);
            ICuotaRepository cuotaRepository = new CuotaRepository(SqlConnectionString);
            ISocioRepository socioRepository = new SocioRepository(SqlConnectionString);
            ITipoCuotaRepository tipoCuotaRepository = new TipoCuotaRepository(SqlConnectionString);
            CuotaPresenter cuotaPresenter = new CuotaPresenter(cuotaView, cuotaRepository, socioRepository, tipoCuotaRepository);
        }

        private void ShowCuotasVencidasView(object? sender, EventArgs e)
        {
            ICuotaView cuotaView = CuotaView.GetInstance((Form)mainView);
            ICuotaRepository cuotaRepository = new CuotaRepository(SqlConnectionString);
            ISocioRepository socioRepository = new SocioRepository(SqlConnectionString);
            ITipoCuotaRepository tipoCuotaRepository = new TipoCuotaRepository(SqlConnectionString);
            CuotaPresenter cuotaPresenter = new CuotaPresenter(cuotaView, cuotaRepository, socioRepository, tipoCuotaRepository, 0);
        }

        private void ShowCuotasAVencerseView(object? sender, EventArgs e)
        {
            ICuotaView cuotaView = CuotaView.GetInstance((Form)mainView);
            ICuotaRepository cuotaRepository = new CuotaRepository(SqlConnectionString);
            ISocioRepository socioRepository = new SocioRepository(SqlConnectionString);
            ITipoCuotaRepository tipoCuotaRepository = new TipoCuotaRepository(SqlConnectionString);
            CuotaPresenter cuotaPresenter = new CuotaPresenter(cuotaView, cuotaRepository, socioRepository, tipoCuotaRepository, 1);
        }

        private void ShowTiposCuotasView(object? sender, EventArgs e)
        {
            ITipoCuotaView tipoCuotaView = TipoCuotaView.GetInstance((Form) mainView);
            ITipoCuotaRepository tipoCuotaRepository = new TipoCuotaRepository(SqlConnectionString);
            TipoCuotaPresenter tipoCuotaPresenter = new TipoCuotaPresenter(tipoCuotaView, tipoCuotaRepository);
        }

        private void ShowAboutView(object? sender, EventArgs e)
        {
            IAcercaDeView acercaDeView = AcercaDeView.GetInstance((Form) mainView);
            AcercaDePresenter acercaDePresenter = new AcercaDePresenter(acercaDeView);
        }

        private void RefreshSociosQuickNotification(object? sender, EventArgs e) 
        {
            ISocioRepository socioRepository = new SocioRepository(SqlConnectionString);

            int inactiveSocios = socioRepository.GetAmountInactiveSocios();

            mainView.InactiveSocios = inactiveSocios.ToString();
        }

        private void RefreshCuotasQuickNotification(object? sender, EventArgs e) 
        {
            ICuotaRepository cuotaRepository = new CuotaRepository(SqlConnectionString);

            int amountDebts = cuotaRepository.GetAmountDebts();

            mainView.Debts = amountDebts.ToString();
        }

        private void RefreshCuotasAVencerseQuickNotification(object? sender, EventArgs e)
        {
            ICuotaRepository cuotaRepository = new CuotaRepository(SqlConnectionString);

            int upcomingDebts = cuotaRepository.GetAmountUpcomingDebts();

            mainView.UpcomingDebts = upcomingDebts.ToString();
        }

        private void RefreshAllQuickNotifications(object? sender, EventArgs e)
        {
            RefreshSociosQuickNotification(this, EventArgs.Empty);
            RefreshCuotasQuickNotification(this, EventArgs.Empty);
            RefreshCuotasAVencerseQuickNotification(this, EventArgs.Empty);
        }
    }
}

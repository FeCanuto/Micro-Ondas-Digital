using MicroOndasDigital.Presenters;
using MicroOndasDigital.Views;

namespace MicroOndasDigital
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Start();
        }
        public static void Start()
        {
            IMicroOndasView view = new MicroOndasView();
            IAdicionarProgramaView adicionar = new AdicionarProgramaView();
            new MicroOndasPresenter(view, adicionar);
            Application.Run((Form)view);
            //Application.Run((Form)adicionar);
        }
    }
}
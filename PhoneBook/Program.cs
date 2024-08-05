using Microsoft.Extensions.Configuration;

namespace PhoneBook
{
    internal static class Program
    {
        public static MainForm MainFormInstance { get; private set; }
        public static IConfiguration Configuration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",
                optional: true, // dosya yoksai devam et. hata verme
                reloadOnChange: true);

            Configuration = builder.Build();
            ApplicationConfiguration.Initialize();
            MainFormInstance = new MainForm();
            Application.Run(MainFormInstance);
        }
    }
}
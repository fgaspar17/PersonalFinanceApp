using Microsoft.Extensions.DependencyInjection;

namespace PersonalFinanceApp.WinForms;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        ServiceCollection services = new ();
        ServicesConfiguration servicesConfiguration = new();
        servicesConfiguration.ConfigureServices (services);

        using (var serviceProvider = services.BuildServiceProvider())
        {
            var form = serviceProvider.GetService<CategoryForm>()!;
            Application.Run(form);
        }
    }
}
namespace Tussentijdsexamen
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DetailsDocentPage), typeof(DetailsDocentPage));
            Routing.RegisterRoute(nameof(DetailsStudentPage), typeof(DetailsStudentPage));
        }
    }
}

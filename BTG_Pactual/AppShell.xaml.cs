using BTG_Pactual.View;

namespace BTG_Pactual
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(FirstView), typeof(FirstView));
            Routing.RegisterRoute(nameof(AddClientView), typeof(AddClientView));
            Routing.RegisterRoute(nameof(EditClientView), typeof(EditClientView));

        }
    }
}

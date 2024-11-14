using BTG_Pactual.ViewModel;

namespace BTG_Pactual.View;

public partial class AddClientView : ContentPage
{
	public AddClientView(AddClientViewModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}
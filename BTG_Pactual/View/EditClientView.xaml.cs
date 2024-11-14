using BTG_Pactual.ViewModel;

namespace BTG_Pactual.View;

public partial class EditClientView : ContentPage
{
	public EditClientView(EditClientViewModel model)
	{
		InitializeComponent();

		BindingContext = model;

    }
}
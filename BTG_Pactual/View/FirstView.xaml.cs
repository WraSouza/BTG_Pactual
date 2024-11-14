using BTG_Pactual.ViewModel;

namespace BTG_Pactual.View;

public partial class FirstView : ContentPage
{
	public FirstView(FirstViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}
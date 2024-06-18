using NoteApp.viewModel;

namespace NoteApp;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailviewModel vmm)
	{
        InitializeComponent();
        BindingContext = vmm;
	}

  
}
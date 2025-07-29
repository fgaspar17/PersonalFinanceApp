using PersonalFinanceApp.Services.DTOs;
using PersonalFinanceApp.Services.Services;

namespace PersonalFinanceApp.WinForms;

public partial class PaymentMethodForm : Form
{
    private readonly IPaymentMethodService _service;
    private CancellationTokenSource _cts;

    public PaymentMethodForm(IPaymentMethodService service)
    {
        InitializeComponent();
        _service = service;
        _cts = new CancellationTokenSource();
    }

    private async void PaymentMethodForm_Load(object sender, EventArgs e)
    {
        SetupBindings();
        List<PaymentMethodDto> paymentMethodDtos = await _service.GetAllPaymentMethodsAsync(_cts.Token);
        paymentMethodDtoBindingSource.DataSource = paymentMethodDtos;
    }

    private void paymentMethodCreateButton_Click(object sender, EventArgs e)
    {

    }

    private void SetupBindings()
    {
        this.paymentMethodNameTextBox.DataBindings.Add("Text", paymentMethodDtoBindingSource, "Name", true, DataSourceUpdateMode.Never);
    }
}

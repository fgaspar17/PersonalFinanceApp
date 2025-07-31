using System.Threading.Tasks;
using PersonalFinanceApp.Services.DTOs;
using PersonalFinanceApp.Services.Services;

namespace PersonalFinanceApp.WinForms;

public partial class PaymentMethodForm : Form
{
    private readonly IPaymentMethodService _service;
    private CancellationTokenSource _cts;
    private PaymentMethodDto? Current { get => paymentMethodDtoBindingSource.Current as PaymentMethodDto; }

    public PaymentMethodForm(IPaymentMethodService service)
    {
        InitializeComponent();
        _service = service;
        _cts = new CancellationTokenSource();
    }

    private async void PaymentMethodForm_Load(object sender, EventArgs e)
    {
        SetupBindings();
        await LoadPaymentMethods();
    }

    private async void paymentMethodCreateButton_Click(object sender, EventArgs e)
    {
        PaymentMethodDto newPaymentMethod = new PaymentMethodDto
        {
            Name = paymentMethodNameTextBox.Text
        };

        await _service.CreatePaymentMethodAsync(newPaymentMethod, _cts.Token);
        await LoadPaymentMethods();
    }

    private void SetupBindings()
    {
        this.paymentMethodNameTextBox.DataBindings.Add("Text", paymentMethodDtoBindingSource, "Name", true, DataSourceUpdateMode.Never);
    }

    private async void paymentMethodUpdateButton_Click(object sender, EventArgs e)
    {
        if (Current == null)
        {
            MessageBox.Show("No payment method selected for update.");
            return;
        }

        Current.Name = paymentMethodNameTextBox.Text;

        await _service.UpdatePaymentMethodAsync(Current.PaymentMethodId, Current, _cts.Token);
        await LoadPaymentMethods();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && _cts != null)
        {
            if (!_cts.IsCancellationRequested)
            {
                _cts?.Cancel();
            }

            _cts?.Dispose();
            _cts = null;
        }

        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private async void paymentMethodDeleteButton_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Are you sure you want to delete this record?", 
            "Delete", 
            MessageBoxButtons.YesNo, 
            MessageBoxIcon.Warning);

        if (result == DialogResult.Yes)
        {
            await _service.DeletePaymentMethodAsync(Current.PaymentMethodId, _cts.Token);
            await LoadPaymentMethods();
        }
    }

    private async Task LoadPaymentMethods()
    {
        List<PaymentMethodDto> paymentMethodDtos = await _service.GetAllPaymentMethodsAsync(_cts.Token);
        paymentMethodDtoBindingSource.DataSource = paymentMethodDtos;
    }
}

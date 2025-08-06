using PersonalFinanceApp.Services.DTOs;
using PersonalFinanceApp.Services.Services;

namespace PersonalFinanceApp.WinForms;

public partial class CategoryForm : Form
{
    private readonly ICategoryService _service;
    private CancellationTokenSource _cts;
    private CategoryDto? Current { get => categoryDtoBindingSource.Current as CategoryDto; }
    public CategoryForm(ICategoryService service)
    {
        InitializeComponent();
        _service = service;
        _cts = new CancellationTokenSource();
    }

    private async void CategoryForm_Load(object sender, EventArgs e)
    {
        SetupBindings();
        await LoadCategories();
    }

    private void SetupBindings()
    {
        this.categoryNameTextBox.DataBindings.Add("Text", categoryDtoBindingSource, "Name", true, DataSourceUpdateMode.Never);
    }

    private async Task LoadCategories()
    {
        List<CategoryDto> categoriesDto = await _service.GetAllCategoriesAsync(_cts.Token);
        categoryDtoBindingSource.DataSource = categoriesDto;
    }

    private async void categoryCreateButton_Click(object sender, EventArgs e)
    {
        CategoryDto newCategory = new CategoryDto
        {
            Name = categoryNameTextBox.Text
        };

        await _service.CreateCategoryAsync(newCategory, _cts.Token);
        await LoadCategories();
    }

    private async void categoryUpdateButton_Click(object sender, EventArgs e)
    {
        if (Current == null)
        {
            MessageBox.Show("No category selected for update.");
            return;
        }

        Current.Name = categoryNameTextBox.Text;

        await _service.UpdateCategoryAsync(Current.CategoryId, Current, _cts.Token);
        await LoadCategories();
    }

    private async void categoryDeleteButton_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Are you sure you want to delete this record?",
            "Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result == DialogResult.Yes)
        {
            await _service.DeleteCategoryAsync(Current.CategoryId, _cts.Token);
            await LoadCategories();
        }
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
}

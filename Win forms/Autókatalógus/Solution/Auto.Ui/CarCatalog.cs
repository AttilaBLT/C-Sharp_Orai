using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using Vehicle.Data;
using Vehicle.Data.Entities;
using Vehicle.Ui.Extensions;
using Vehicle.Ui.ViewModels;
using static Vehicle.Ui.Extensions.ObjectExtensions;

namespace Vehicle.Ui;

public partial class CarCatalog : Form
{
    private BindingSource adapter = new BindingSource();
    
    private delegate void Action();
    private Action action;

    public CarCatalog()
    {
        InitializeComponent();
        FormatDGVHeaders();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        PopulateVehicleTypeComboBox();
        PopulateFuelComboBox();
        PopulateDataGridView();
    }


    #region Helper Methods
    private void PopulateFuelComboBox()
    {
        using AppDbContext context = new AppDbContext();
        List<Fuel> fuels = context.Fuels.ToList();
        fuels.Insert(0, new Fuel { Id = 0, Name = "Please select a fuel type!" });

        comboBoxFuel.DataSource = fuels;
        comboBoxFuel.DisplayMember = "Name";
        comboBoxFuel.ValueMember = "Id";        
    }

    private void PopulateVehicleTypeComboBox()
    {
        using AppDbContext context = new AppDbContext();
        List<VehicleType> vehicleTypes = context.VehicleTypes.ToList();
        vehicleTypes.Insert(0, new VehicleType { Id = 0, Name = "Please select a vehicle type!" });

        comboBoxVehicleType.DataSource = vehicleTypes;
        comboBoxVehicleType.DisplayMember = "Name";
        comboBoxVehicleType.ValueMember = "Id";
    }
    private void PopulateDataGridView()
    {
        using AppDbContext context = new AppDbContext();

        adapter.DataSource = context.Cars.Include(x => x.Fuel)
                                         .Include(x => x.VehicleType)
                                         .Select(x => new CarViewModel(x))
                                         .ToList();
        dataGridView.DataSource = adapter;
    }

    private void FormatDGVHeaders()
    {
        dataGridView.AutoGenerateColumns = false;
        dataGridView.ColumnCount = 9;

        dataGridView.Columns[0].HeaderText = "Id";
        dataGridView.Columns[0].DataPropertyName = "Id";
        dataGridView.Columns[0].Visible = false;

        dataGridView.Columns[1].HeaderText = "Manufacturer";
        dataGridView.Columns[1].DataPropertyName = "Manufacturer";

        dataGridView.Columns[2].HeaderText = "Model";
        dataGridView.Columns[2].DataPropertyName = "Model";

        dataGridView.Columns[3].HeaderText = "Production Year";
        dataGridView.Columns[3].DataPropertyName = "ProductionYear";

        dataGridView.Columns[4].HeaderText = "Cubic Capacity";
        dataGridView.Columns[4].DataPropertyName = "CubicCapacity";

        dataGridView.Columns[5].HeaderText = "FuelId";
        dataGridView.Columns[5].DataPropertyName = "FuelId";
        dataGridView.Columns[5].Visible = false;

        dataGridView.Columns[6].HeaderText = "Fuel";
        dataGridView.Columns[6].DataPropertyName = "FuelName";

        dataGridView.Columns[7].HeaderText = "VehicleTypeId";
        dataGridView.Columns[7].DataPropertyName = "VehicleTypeId";
        dataGridView.Columns[7].Visible = false;

        dataGridView.Columns[8].HeaderText = "Vehicle Type";
        dataGridView.Columns[8].DataPropertyName = "VehicleTypeName";
    }

    private void PopulateForm(CarViewModel model)
    {
        textBoxManufacturer.Text = model.Manufacturer;
        textBoxModel.Text = model.Model;
        numericBoxProductionYear.IntValue = model.ProductionYear;
        numericBoxCubicCapacity.IntValue = model.CubicCapacity;
        comboBoxFuel.SelectedValue = model.FuelId;
        comboBoxVehicleType.SelectedValue = model.VehicleTypeId;
    }

    private void ClearForm()
    {
        textBoxManufacturer.Text = string.Empty;
        textBoxModel.Text = string.Empty;
        numericBoxProductionYear.IntValue = null;
        numericBoxCubicCapacity.IntValue = null;
        comboBoxFuel.SelectedIndex = 0;
        comboBoxVehicleType.SelectedIndex = 0;
    }

    private void ClearErrorMessages(Control control)
    {
        IEnumerable<Label> labelControls = control.Controls.OfType<Label>();

        foreach (var label in labelControls)
        {
            if (label.Name.ToLower().Contains("error"))
            {
                label.Text = string.Empty;
            }
        }
    }

    private CarViewModel CollectData()
    {
        return new CarViewModel
        {
            Manufacturer = textBoxManufacturer.Text.Trim(),
            Model = textBoxModel.Text.Trim(),
            ProductionYear = numericBoxProductionYear.IntValue,
            CubicCapacity = numericBoxCubicCapacity.IntValue,
            FuelId = (int)comboBoxFuel.SelectedValue,
            FuelName = comboBoxFuel.Text.Trim(),
            VehicleTypeId = (int)comboBoxVehicleType.SelectedValue,
            VehicleTypeName = comboBoxVehicleType.Text.Trim(),
        };
    }

    private void ShowErrors(Dictionary<string, string> errors)
    {
        labelErrorManufacturer.Text = errors.GetValueOrDefault("Manufacturer");
        labelErrorModel.Text = errors.GetValueOrDefault("Model");
        labelErrorCubicCapacity.Text = errors.GetValueOrDefault("CubicCapacity");
        labelErrorFuel.Text = errors.GetValueOrDefault("FuelId");
        labelErrorVehicleType.Text = errors.GetValueOrDefault("VehicleTypeId");
    }

    private void AddNewCar()
    {
        CarViewModel model = CollectData();

        ModelValidationResult validationResult = model.Validate();
        ShowErrors(validationResult.Errors);
        if (!validationResult.isValid)
        {
            return;
        }

        using AppDbContext context = new AppDbContext();
        bool isTheSameModelExists = context.Cars.Any(x => x.Model.ToLower() == model.Model.ToLower());
        if (isTheSameModelExists)
        {
            MessageBox.Show($"{model.Model} model is already exists.", "Attention!", MessageBoxButtons.OK);

            textBoxModel.Focus();

            return;
        }

        Car car = model.ToDbEntity();

        context.Cars.Add(car);
        context.SaveChanges();

        model.Id = car.Id;

        adapter.Add(model);

        ClearForm();
        formGroup.Enabled = true;
        toolStrip1.Enabled = true;
    }

    private void UpdateCar()
    {
        CarViewModel model = (CarViewModel)adapter.Current;

        int index = adapter.IndexOf(model);

        using AppDbContext context = new AppDbContext();
        Car car = context.Cars.Find(model.Id);

        model = CollectData();

        ModelValidationResult validationResult = model.Validate();
        ShowErrors(validationResult.Errors);
        if (!validationResult.isValid)
        {
            return;
        }

        model.ToDbEntity(car);
        context.SaveChanges();

        adapter.RemoveAt(index);
        adapter.Insert(index, model);

        ClearForm();
    }
#endregion

    #region Events

    private void OnAddClick(object sender, EventArgs e)
    {
        ClearForm();
        action = AddNewCar;
        formGroup.Enabled = true;
        toolStrip1.Enabled = false;
        dataGridView.Enabled = false;
    }

    private void OnEditClick(object sender, EventArgs e)
    {
        CarViewModel model = (CarViewModel)adapter.Current;
        
        if(model is null)
        {
            MessageBox.Show("Please select a car to edit.", "Attention!", MessageBoxButtons.OK);
            return;
        }
        PopulateForm(model);

        action = UpdateCar;
        ClearForm();
        formGroup.Enabled = true;
        toolStrip1.Enabled = false;
    }

    private void OnDeleteClick(object sender, EventArgs e)
    {
        CarViewModel model = (CarViewModel)adapter.Current;

        if (model is null)
        {
            MessageBox.Show("Please select a car to delete.", "Attention!", MessageBoxButtons.OK);
            return;
        }

        DialogResult dialog = MessageBox.Show($"Are you sure you want to delete {model.Manufacturer} {model.Model}?", "Attention!", MessageBoxButtons.YesNo);

        if (dialog == DialogResult.No)
        {
            return;
        }

        int index = adapter.IndexOf(model);
        using AppDbContext context = new AppDbContext();
        Car car = context.Cars.Find(model.Id);
        context.Cars.Remove(car);
        context.SaveChanges();

        adapter.RemoveAt(index);
    }

    private void OnSubmitClick(object sender, EventArgs e)
    {
        action();
    }
    
    private void OnCancelClick(object sender, EventArgs e)
    {
        ClearForm();

        toolStrip1.Enabled = true;
        formGroup.Enabled = false;

        ClearErrorMessages(formGroup);
    }

    private void OnLostFocus(object sender, EventArgs e)
    {
        CarViewModel model = CollectData();

        ModelValidationResult validationResult = model.Validate();
        ShowErrors(validationResult.Errors);
    }

    private void OnDataGridViewSelectionChanged(object sender, EventArgs e)
    {
        CarViewModel model = (CarViewModel)adapter.Current;

        if (model is null)
        {
            return;
        }

        PopulateForm(model);
    } 



    #endregion

    private void OnSearchKeyUp(object sender, KeyEventArgs e)
    {
            if (SearchBox.Text.Length < 3)
            {
                PopulateDataGridView();
                return;
            }

            using AppDbContext context = new AppDbContext();
            adapter.DataSource = context.Cars.Include(x => x.Fuel)
                                             .Include(x => x.VehicleType)
                                             .Where(x => x.Manufacturer.ToLower().Contains(SearchBox.Text.ToLower()))
                                             .Select(x => new CarViewModel(x))
                                             .ToList();
    }
}
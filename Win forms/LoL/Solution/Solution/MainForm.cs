using LoL.Data.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Solution;
public partial class MainForm : Form
{
    private BindingSource adapter = new BindingSource();


    /*
    Olyan mutató amely értéke csak olyan függvény lehet, melynek nincs paramétere és a visszatérési értéke void.
    void AddNewChampion();
    void UpdateChampion(),
    */
    private delegate void Action();

    //A mutató (function pointer) példánya.
    private Action action;

    public MainForm()
    {
        InitializeComponent();
        FormatDGVHeaders();

        dateTimePickerDateOfRelease.MinDate = new DateTime(2009, 10, 27);
        dateTimePickerDateOfRelease.MaxDate =  DateTime.Now.Date;
        dateTimePickerDateOfRelease.CustomFormat = "yyyy MMMM dd";
        dateTimePickerDateOfRelease.Value = DateTime.Now.Date;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        PopulateRoleComboBox();
        PopulateDataGridView();
    }

    #region helper functions
    private void PopulateDataGridView()
    {
        using AppDbContext context = new AppDbContext();
        adapter.DataSource = context.Champions.Include(x => x.Role)
                                              .Select(x => new ChampionViewModel(x))
                                              .ToList();
        dataGridView.DataSource = adapter;
    }

    private void FormatDGVHeaders()
    {
        dataGridView.AutoGenerateColumns = false;
        dataGridView.ColumnCount = 7;

        dataGridView.Columns[0].HeaderText = "Id";
        dataGridView.Columns[0].DataPropertyName= "Id";
        dataGridView.Columns[0].Visible = false;

        dataGridView.Columns[1].HeaderText = "Name";
        dataGridView.Columns[1].DataPropertyName = "Name";

        dataGridView.Columns[2].HeaderText = "Hp";
        dataGridView.Columns[2].DataPropertyName = "Hp";

        dataGridView.Columns[3].HeaderText = "Mana";
        dataGridView.Columns[3].DataPropertyName = "Mana";

        dataGridView.Columns[4].HeaderText = "Date Of Release";
        dataGridView.Columns[4].DataPropertyName = "DateOfRelease";

        dataGridView.Columns[5].HeaderText = "RoleId";
        dataGridView.Columns[5].DataPropertyName = "RoleId";
        dataGridView.Columns[5].Visible= false;

        dataGridView.Columns[6].HeaderText= "Role";
        dataGridView.Columns[6].DataPropertyName = "RoleName";
    }

    private void PopulateRoleComboBox()
    {
        using AppDbContext context = new AppDbContext();
        comboBoxRole.DataSource = context.Roles.ToList();
        comboBoxRole.DisplayMember = "Name";
        comboBoxRole.ValueMember = "Id";
    }

    private void PopulateForm(ChampionViewModel model)
    {
        textBoxName.Text = model.Name;
        textBoxHp.Text = model.Hp.ToString();
        textBoxMana.Text = model.Mana.ToString();
        dateTimePickerDateOfRelease.Value = model.DateOfRelease;
        comboBoxRole.SelectedValue = model.RoleId;
    }

    private void ClearForm()
    {
        textBoxName.Text = string.Empty;
        textBoxHp.Text = string.Empty;
        textBoxMana.Text = string.Empty;
        dateTimePickerDateOfRelease.Value = DateTime.Now;
        comboBoxRole.SelectedValue = 0;
    }

    private ChampionViewModel CollectData()
    {
        return new ChampionViewModel
        {
            Name = textBoxName.Text.Trim(),
            Hp = int.Parse(textBoxHp.Text.Trim()),
            Mana = int.Parse(textBoxMana.Text.Trim()),
            DateOfRelease = dateTimePickerDateOfRelease.Value,
            RoleId = (int)comboBoxRole.SelectedValue,
            RoleName = comboBoxRole.Text.Trim(),
        };
    }

    private void AddNewChampion()
    {
        ChampionViewModel model = CollectData();

        Champion champion = model.ToDbEntity();

        using AppDbContext context = new AppDbContext();
        context.Champions.Add(champion);
        context.SaveChanges();      

        model.Id= champion.Id;
        adapter.Add(model);
        ClearForm();
    }

    private void UpdateChampion()
    {
        ChampionViewModel model = (ChampionViewModel)adapter.Current;
        int index = adapter.IndexOf(model);

        using AppDbContext context = new AppDbContext();
        Champion champion = context.Champions.Find(model.Id);

        model = CollectData();

        model.ToDbEntity(champion);
        context.SaveChanges();

        adapter.RemoveAt(index);
        adapter.Insert(index, model);

        ClearForm();
    }
    #endregion

    #region event handlers

    private void OnAddClick(object sender, EventArgs e)
    {
        action = AddNewChampion;//Az action function pointer megkapja az AddNewChampion memoriacímet, de nem hajtja végre (nincs a végén a ()-el csak ';' kell)
        formGroup.Enabled = true;
        toolStrip.Enabled = true;
    }

    private void onUpdateClick(object sender, EventArgs e)
    {
        ChampionViewModel model = (ChampionViewModel)adapter.Current;
        if (model is null)
        {
            MessageBox.Show("Nem jelölt ki egy hõst!", " Figyelem!", MessageBoxButtons.OK);
            return;
        }
        PopulateForm(model);



        action = UpdateChampion;//Az action function pointer megkapja az UpdateChampion memoriacímet, de nem hajtja végre (nincs a végén a ()-el csak ';' kell)
        formGroup.Enabled = true;
        toolStrip.Enabled = true;
    }

    private void OnDeleteClick(object sender, EventArgs e)
    {
        ChampionViewModel model = (ChampionViewModel)adapter.Current;

        if (model is null)
        {
            MessageBox.Show("Nem jelölt ki egy hõst!", " Figyelem!", MessageBoxButtons.OK);
            return;
        }

        DialogResult dialog = MessageBox.Show($"Biztos ki akarja törölni a {model.Name} hõst?", "Figyelem!", MessageBoxButtons.YesNo);

        if (dialog == DialogResult.No)
        {
            return;
        }

        int index = adapter.IndexOf(model);
        using AppDbContext context = new AppDbContext();
        Champion champion = context.Champions.Find(model.Id);
        context.Champions.Remove(champion);
        context.SaveChanges();

        adapter.RemoveAt(index);
    }

    private void OnSubmitClick(object sender, EventArgs e)
    {
        //Végrehajtjuk a függvényt amelyre az action pointer mutat.
        //Ezeket a függvényeket(memóriacímeket) az OnAddClick vagy az OnUpdateClick függvényekben definiáltuk.
        action();
    }


    private void OnCancelClick(object sender, EventArgs e)
    {
        ClearForm();

        toolStrip.Enabled = true;
        formGroup.Enabled = false;
    }

    #endregion
}
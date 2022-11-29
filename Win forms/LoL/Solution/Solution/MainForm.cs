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

    private void AddNewChampion()
    {
        ChampionViewModel model = new ChampionViewModel
        {
            Name = textBoxName.Text.Trim(),
            Hp = int.Parse(textBoxHp.Text.Trim()),
            Mana = int.Parse(textBoxMana.Text.Trim()),
            DateOfRelease = dateTimePickerDateOfRelease.Value,
            RoleId = (int)comboBoxRole.SelectedValue 
        };

        Champion champion = model.ToDbEntity();

        using AppDbContext context = new AppDbContext();
        context.Champions.Add(champion);
        context.SaveChanges();

        

        adapter.Add(new ChampionViewModel(champion));
        ClearForm();
    }

    private void UpdateChampion()
    {
        ChampionViewModel model = (ChampionViewModel)adapter.Current;
        using AppDbContext context = new AppDbContext();
        Champion champion = context.Champions.Find(model.Id);

        model.Name = textBoxName.Text;
        model.Hp = int.Parse(textBoxHp.Text.Trim());
        model.Mana = int.Parse(textBoxMana.Text.Trim());
        model.DateOfRelease = dateTimePickerDateOfRelease.Value;
        model.RoleId = (int)comboBoxRole.SelectedValue;


        model.ToDbEntity(champion);
        context.SaveChanges();

        int index = adapter.IndexOf(model);
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
    }

    private void onUpdateClick(object sender, EventArgs e)
    {
        ChampionViewModel model = (ChampionViewModel)adapter.Current;
        if (model is null)
        {
            MessageBox.Show("Figyelem!", "Nem jelölt ki egy hõst!", MessageBoxButtons.OK);
            return;
        }
        PopulateForm(model);



        action = UpdateChampion;//Az action function pointer megkapja az UpdateChampion memoriacímet, de nem hajtja végre (nincs a végén a ()-el csak ';' kell)
        formGroup.Enabled = true;
    }

    private void OnDeleteClick(object sender, EventArgs e)
    {
    }

    private void OnSubmitClick(object sender, EventArgs e)
    {
        //Végrehajtjuk a függvényt amelyre az action pointer mutat.
        //Ezeket a függvényeket(memóriacímeket) az OnAddClick vagy az OnUpdateClick függvényekben definiáltuk.
        action();
        formGroup.Enabled = false;
    }

    #endregion
}
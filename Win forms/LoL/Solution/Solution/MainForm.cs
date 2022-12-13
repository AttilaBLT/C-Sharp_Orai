namespace Solution;
public partial class MainForm : Form
{
    private BindingSource adapter = new BindingSource();


    /*
    Olyan mutat� amely �rt�ke csak olyan f�ggv�ny lehet, melynek nincs param�tere �s a visszat�r�si �rt�ke void.
    void AddNewChampion();
    void UpdateChampion(),
    */
    private delegate void Action();

    //A mutat� (function pointer) p�ld�nya.
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

        List<Role> roles = context.Roles.ToList();
        roles.Insert(0, new Role { Id = 0, Name = "Please select a role!" });


        comboBoxRole.DataSource = roles;
        comboBoxRole.DisplayMember = "Name";
        comboBoxRole.ValueMember = "Id";
    }

    private void PopulateForm(ChampionViewModel model)
    {
        textBoxName.Text = model.Name;
        numericBoxHp.IntValue = model.Hp;
        numericBoxMana.IntValue = model.Mana;
        dateTimePickerDateOfRelease.Value = model.DateOfRelease;
        comboBoxRole.SelectedValue = model.RoleId;
    }

    private void ClearForm()
    {
        textBoxName.Text = string.Empty;
        numericBoxHp.IntValue = null;
        //numericBoxHp.Text = string.Empty;
        numericBoxMana.IntValue = null;
        //numericBoxMana.Text = string.Empty;
        dateTimePickerDateOfRelease.Value = DateTime.Now.Date;
        comboBoxRole.SelectedIndex = 0;


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

    private ChampionViewModel CollectData()
    {
        return new ChampionViewModel
        {
            Name = textBoxName.Text.Trim(),
            Hp = numericBoxHp.IntValue,
            Mana = numericBoxMana.IntValue,
            DateOfRelease = dateTimePickerDateOfRelease.Value,
            RoleId = (int)comboBoxRole.SelectedValue,
            RoleName = comboBoxRole.Text.Trim(),
        };
    }

    private void ShowErrors(Dictionary<string, string> errors)
    {
        labelNameError.Text = errors.GetValueOrDefault("Name");
        labelHpError.Text = errors.GetValueOrDefault("Hp");
        labelManaError.Text = errors.GetValueOrDefault("Mana");
        labelRoleError.Text = errors.GetValueOrDefault("RoleId");
    }

    private void AddNewChampion()
    {
        //Adatok begy�jt�se az �rlapb�l
        ChampionViewModel model = CollectData();


        //Begy�jt�tt adat modell valid�l�sa
        ModelValidationResult ValidationResult = model.Validate();
        ShowErrors(ValidationResult.Errors);
        if (!ValidationResult.isValid)
        {
            return;
        }

        using AppDbContext context = new AppDbContext();
        bool isChampionWithTheSameNameExists = context.Champions.Any(x => x.Name.ToLower() == model.Name.ToLower());
        if (isChampionWithTheSameNameExists)
        {
            MessageBox.Show($"{model.Name} nev� h�s m�r l�tezik.", "Figyelem", MessageBoxButtons.OK);

            textBoxName.Focus();

            return;
        }

        //ment�s
        Champion champion = model.ToDbEntity();

        
        context.Champions.Add(champion);
        context.SaveChanges();      

        model.Id= champion.Id;

        //megjelen�t� t�bl�ba helyez�s
        adapter.Add(model);

        //elemek alaphelyzetbe �ll�t�sa
        ClearForm();
        formGroup.Enabled = true;
        toolStrip.Enabled = true;
    }

    private void UpdateChampion()
    {
        ChampionViewModel model = (ChampionViewModel)adapter.Current;
        int index = adapter.IndexOf(model);

        using AppDbContext context = new AppDbContext();
        Champion champion = context.Champions.Find(model.Id);

        model = CollectData();

        ModelValidationResult ValidationResult = model.Validate();
        ShowErrors(ValidationResult.Errors);
        if (!ValidationResult.isValid)
        {
            return;
        }

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
        ClearForm();
        action = AddNewChampion;//Az action function pointer megkapja az AddNewChampion memoriac�met, de nem hajtja v�gre (nincs a v�g�n a ()-el csak ';' kell)
        formGroup.Enabled = true;
        toolStrip.Enabled = false;
        dataGridView.Enabled = false;
    }

    private void onUpdateClick(object sender, EventArgs e)
    {
        ChampionViewModel model = (ChampionViewModel)adapter.Current;
        if (model is null)
        {
            MessageBox.Show("Nem jel�lt ki egy h�st!", " Figyelem!", MessageBoxButtons.OK);
            return;
        }
        PopulateForm(model);

        action = UpdateChampion;//Az action function pointer megkapja az UpdateChampion memoriac�met, de nem hajtja v�gre (nincs a v�g�n a ()-el csak ';' kell)
        ClearForm();
        formGroup.Enabled = true;
        toolStrip.Enabled = false;
    }

    private void OnDeleteClick(object sender, EventArgs e)
    {
        ChampionViewModel model = (ChampionViewModel)adapter.Current;

        if (model is null)
        {
            MessageBox.Show("Nem jel�lt ki egy h�st!", " Figyelem!", MessageBoxButtons.OK);
            return;
        }

        DialogResult dialog = MessageBox.Show($"Biztos ki akarja t�r�lni a {model.Name} h�st?", "Figyelem!", MessageBoxButtons.YesNo);

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
        //V�grehajtjuk a f�ggv�nyt amelyre az action pointer mutat.
        //Ezeket a f�ggv�nyeket(mem�riac�meket) az OnAddClick vagy az OnUpdateClick f�ggv�nyekben defini�ltuk.
        action();
    }


    private void OnCancelClick(object sender, EventArgs e)
    {
        ClearForm();

        toolStrip.Enabled = true;
        formGroup.Enabled = false;

        ClearErrorMessages(formGroup);
    }

    private void OnLostFocus(object sender, EventArgs e)
    {
        ChampionViewModel model = CollectData();

        ModelValidationResult validationResult = model.Validate();
        ShowErrors(validationResult.Errors);
    }

    private void OnDataGridViewSelectionChanged(object sender, EventArgs e)
    {
        ChampionViewModel model = (ChampionViewModel)adapter.Current;

        if (model is null)
        {
            return;
        }

        PopulateForm(model);
    }

    private void OnSearchKeyUp(object sender, KeyEventArgs e)
    {

        if (searchBox.Text.Length < 3)
        {
            PopulateDataGridView();
            return;
        }


        using AppDbContext context = new AppDbContext();
        adapter.DataSource = context.Champions.Include(x => x.Role)
                                              .Where(x => x.Name.ToLower().Contains(searchBox.Text.ToLower()))
                                              .Select(x => new ChampionViewModel(x))
                                              .ToList();
    }

    #endregion
}
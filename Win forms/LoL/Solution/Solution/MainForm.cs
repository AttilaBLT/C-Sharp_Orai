namespace Solution;
public partial class MainForm : Form
{
    private BindingSource adapter = new BindingSource();

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

    private void PopulateDataGridView()
    {
        using AppDbContext context = new AppDbContext();
        adapter.DataSource = context.Champions.Select(x => new ChampionViewModel(x))
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
}
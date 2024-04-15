using PhoneBookMonolit.Services;

namespace PhoneBookMonolit
{
    public partial class MainForm : Form
    {
        private readonly Services.EntryService _entryService;
        private readonly PhoneBookSearchService _phoneBookSearchService;
        public MainForm()
        {
            InitializeComponent();
            _entryService = new Services.EntryService();
            _phoneBookSearchService = new PhoneBookSearchService();

            if (Login())
            {
                var allEntries = _entryService.GetAllEntries();
                SetDataSource(allEntries);
            }
        }

        private void tb_searchinput_TextChanged(object sender, EventArgs e)
        {
            SearchPhoneBook();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                var allEntries = _entryService.GetAllEntries();
                SetDataSource(allEntries);
            }
        }

        private bool Login()
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Login Failed");
                return false;
            }
            else
            {
                btn_login.Visible = false;
                tb_searchinput.Select();
                return true;
            }

        }
        private void SearchPhoneBook()
        {
            var searchString = tb_searchinput.Text;
            var searchResult = string.IsNullOrEmpty(searchString) ?
                                _entryService.GetAllEntries() :
                                _phoneBookSearchService.SearchForEntry(searchString);

            SetDataSource(searchResult);
        }
        private void SetDataSource(List<Models.PhoneBookEntry> entries)
        {
            dataGridView1.DataSource = entries;
        }

        
    }
}
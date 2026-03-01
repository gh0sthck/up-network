namespace up_network
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ShowLoginScreen();
        }


        public void ShowScreen(UserControl screen)
        {
            PanelMain.Controls.Clear();
            // код на то, чтобы сделать fill
            PanelMain.Controls.Add(screen);
        }

        public void ShowLoginScreen()
        {
            LoginPage lp = new LoginPage();

            lp.onAuth += user =>
            {
                ShowMainScreen(user);
            };

            ShowScreen(lp);
        }

        public void ShowMainScreen(User loggedUser)
        {
            MainPage mp = new MainPage();
            mp.loggedUser = loggedUser;

            mp.onExit += () =>
            {
                ShowLoginScreen();
            };
            mp.onTableClick += () =>
            {
                ShowTablePage(mp.loggedUser);
            };
            mp.onClientsClick += () =>
            {
                ShowClientsPage(mp.loggedUser);
            };

            ShowScreen(mp);
        }

        public void ShowTablePage(User loggedUser)
        {
            TablePage tp = new TablePage();
            tp.loggedUser = loggedUser;

            tp.onExit += () =>
            {
                ShowLoginScreen();
            };
            tp.onMainClick += () =>
            {
                ShowMainScreen(tp.loggedUser);
            };
            tp.onClientsClick += () =>
            {
                ShowClientsPage(tp.loggedUser);
            };

            ShowScreen(tp);
        }

        public void ShowClientsPage(User loggedUser)
        {
            ClientsPage cp = new ClientsPage();
            cp.loggedUser = loggedUser;

            cp.onExit += () =>
            {
                ShowLoginScreen();
            };
            cp.onTableClick += () =>
            {
                ShowTablePage(cp.loggedUser);
            };
            cp.onMainClick += () =>
            {
                ShowMainScreen(cp.loggedUser);
            };

            ShowScreen(cp);
        }
    }
}

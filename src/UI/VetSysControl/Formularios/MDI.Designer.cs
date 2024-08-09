namespace VetSysControl.Formularios
{
    partial class MDI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            printSetupToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editMenu = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            viewMenu = new ToolStripMenuItem();
            toolBarToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            toolsMenu = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            windowsMenu = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            BtnClientes = new ToolStripDropDownButton();
            TsmiCadCli = new ToolStripMenuItem();
            TsmiConsultaCli = new ToolStripMenuItem();
            BtnPets = new ToolStripDropDownButton();
            TsmiCadPet = new ToolStripMenuItem();
            TsmiCadEspecieRaca = new ToolStripMenuItem();
            BtnEmpresa = new ToolStripDropDownButton();
            TsmiCadEmpresa = new ToolStripMenuItem();
            TsmiConsultaEmp = new ToolStripMenuItem();
            TsmiCadFornecedor = new ToolStripMenuItem();
            BtnFuncionarios = new ToolStripDropDownButton();
            TsmiCadFunc = new ToolStripMenuItem();
            TsmiConsultaFunc = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnAtendimentos = new ToolStripButton();
            BtnAgendamentos = new ToolStripButton();
            BtnExames = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BtnMedicamento = new ToolStripDropDownButton();
            TsmiCadMed = new ToolStripMenuItem();
            TsmiCadVac = new ToolStripMenuItem();
            BtnServico = new ToolStripDropDownButton();
            TsmiCadServ = new ToolStripMenuItem();
            BtnOutros = new ToolStripDropDownButton();
            BtnConfig = new ToolStripDropDownButton();
            TsmiAlterarSenha = new ToolStripMenuItem();
            TsmiBD = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            TsmiConsultaPet = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, viewMenu, toolsMenu, windowsMenu, helpMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(738, 22);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            menuStrip.Visible = false;
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator3, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator4, printToolStripMenuItem, printPreviewToolStripMenuItem, printSetupToolStripMenuItem, toolStripSeparator5, exitToolStripMenuItem });
            fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(61, 18);
            fileMenu.Text = "&Arquivo";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Black;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(188, 22);
            newToolStripMenuItem.Text = "&Nova";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Black;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(188, 22);
            openToolStripMenuItem.Text = "&Abrir";
            openToolStripMenuItem.Click += OpenFile;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(185, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Black;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(188, 22);
            saveToolStripMenuItem.Text = "&Salvar";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(188, 22);
            saveAsToolStripMenuItem.Text = "Salvar &como";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(185, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Black;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(188, 22);
            printToolStripMenuItem.Text = "Im&primir";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Black;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(188, 22);
            printPreviewToolStripMenuItem.Text = "&Vizualizar impressão";
            // 
            // printSetupToolStripMenuItem
            // 
            printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            printSetupToolStripMenuItem.Size = new Size(188, 22);
            printSetupToolStripMenuItem.Text = "Configurar Impressão";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(188, 22);
            exitToolStripMenuItem.Text = "Sai&r";
            exitToolStripMenuItem.Click += ExitToolsStripMenuItem_Click;
            // 
            // editMenu
            // 
            editMenu.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator6, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator7, selectAllToolStripMenuItem });
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(49, 18);
            editMenu.Text = "&Editar";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Image = (Image)resources.GetObject("undoToolStripMenuItem.Image");
            undoToolStripMenuItem.ImageTransparentColor = Color.Black;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(200, 22);
            undoToolStripMenuItem.Text = "&Desfazer";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Image = (Image)resources.GetObject("redoToolStripMenuItem.Image");
            redoToolStripMenuItem.ImageTransparentColor = Color.Black;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(200, 22);
            redoToolStripMenuItem.Text = "&Refazer";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(197, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Black;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(200, 22);
            cutToolStripMenuItem.Text = "&Recortar";
            cutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Black;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(200, 22);
            copyToolStripMenuItem.Text = "&Copiar";
            copyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Black;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(200, 22);
            pasteToolStripMenuItem.Text = "&Colar";
            pasteToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(197, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(200, 22);
            selectAllToolStripMenuItem.Text = "Selecion&ar Tudo";
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new ToolStripItem[] { toolBarToolStripMenuItem, statusBarToolStripMenuItem });
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(48, 18);
            viewMenu.Text = "&Exibir";
            // 
            // toolBarToolStripMenuItem
            // 
            toolBarToolStripMenuItem.Checked = true;
            toolBarToolStripMenuItem.CheckOnClick = true;
            toolBarToolStripMenuItem.CheckState = CheckState.Checked;
            toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            toolBarToolStripMenuItem.Size = new Size(185, 22);
            toolBarToolStripMenuItem.Text = "&Barra de Ferramentas";
            toolBarToolStripMenuItem.Click += ToolBarToolStripMenuItem_Click;
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckOnClick = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(185, 22);
            statusBarToolStripMenuItem.Text = "&Barra de Status";
            statusBarToolStripMenuItem.Click += StatusBarToolStripMenuItem_Click;
            // 
            // toolsMenu
            // 
            toolsMenu.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            toolsMenu.Name = "toolsMenu";
            toolsMenu.Size = new Size(84, 18);
            toolsMenu.Text = "&Ferramentas";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(114, 22);
            optionsToolStripMenuItem.Text = "&Opções";
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { newWindowToolStripMenuItem, cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(56, 18);
            windowsMenu.Text = "&Janelas";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(179, 22);
            newWindowToolStripMenuItem.Text = "&Nova Janela";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(179, 22);
            cascadeToolStripMenuItem.Text = "&Cascata";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(179, 22);
            tileVerticalToolStripMenuItem.Text = "Empilhar &Vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(179, 22);
            tileHorizontalToolStripMenuItem.Text = "Empilhar &Horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(179, 22);
            closeAllToolStripMenuItem.Text = "Fec&har todos";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(179, 22);
            arrangeIconsToolStripMenuItem.Text = "&Organizar Ícones";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator8, aboutToolStripMenuItem });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(50, 18);
            helpMenu.Text = "&Ajuda";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            contentsToolStripMenuItem.Size = new Size(173, 22);
            contentsToolStripMenuItem.Text = "&Conteúdo";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Image = (Image)resources.GetObject("indexToolStripMenuItem.Image");
            indexToolStripMenuItem.ImageTransparentColor = Color.Black;
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(173, 22);
            indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Image = (Image)resources.GetObject("searchToolStripMenuItem.Image");
            searchToolStripMenuItem.ImageTransparentColor = Color.Black;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(173, 22);
            searchToolStripMenuItem.Text = "&Procurar";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(170, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(173, 22);
            aboutToolStripMenuItem.Text = "&Sobre ... ...";
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Left;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { BtnClientes, BtnPets, BtnEmpresa, BtnFuncionarios, toolStripSeparator1, BtnAtendimentos, BtnAgendamentos, BtnExames, toolStripSeparator2, BtnMedicamento, BtnServico, BtnOutros, BtnConfig });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(201, 595);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // BtnClientes
            // 
            BtnClientes.AutoSize = false;
            BtnClientes.DropDownItems.AddRange(new ToolStripItem[] { TsmiCadCli, TsmiConsultaCli });
            BtnClientes.Image = (Image)resources.GetObject("BtnClientes.Image");
            BtnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnClientes.ImageTransparentColor = Color.Black;
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(198, 40);
            BtnClientes.Text = "Clientes";
            BtnClientes.TextAlign = ContentAlignment.MiddleLeft;
            BtnClientes.Paint += BtnClientes_Paint;
            // 
            // TsmiCadCli
            // 
            TsmiCadCli.Name = "TsmiCadCli";
            TsmiCadCli.Size = new Size(180, 22);
            TsmiCadCli.Text = "Cadastro Cliente";
            TsmiCadCli.Click += TsmiCadCli_Click;
            // 
            // TsmiConsultaCli
            // 
            TsmiConsultaCli.Name = "TsmiConsultaCli";
            TsmiConsultaCli.Size = new Size(180, 22);
            TsmiConsultaCli.Text = "Consulta Cliente";
            TsmiConsultaCli.Click += TsmiConsultaCli_Click;
            // 
            // BtnPets
            // 
            BtnPets.AutoSize = false;
            BtnPets.DropDownItems.AddRange(new ToolStripItem[] { TsmiCadPet, TsmiCadEspecieRaca, TsmiConsultaPet });
            BtnPets.Image = (Image)resources.GetObject("BtnPets.Image");
            BtnPets.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPets.ImageTransparentColor = Color.Black;
            BtnPets.Name = "BtnPets";
            BtnPets.Size = new Size(200, 40);
            BtnPets.Text = "Animais / Pets";
            BtnPets.TextAlign = ContentAlignment.MiddleLeft;
            BtnPets.Paint += BtnPets_Paint;
            // 
            // TsmiCadPet
            // 
            TsmiCadPet.Name = "TsmiCadPet";
            TsmiCadPet.Size = new Size(193, 22);
            TsmiCadPet.Text = "Cadastro Pet";
            TsmiCadPet.Click += TsmiCadPet_Click;
            // 
            // TsmiCadEspecieRaca
            // 
            TsmiCadEspecieRaca.Name = "TsmiCadEspecieRaca";
            TsmiCadEspecieRaca.Size = new Size(193, 22);
            TsmiCadEspecieRaca.Text = "Cadastro Espécie/Raça";
            TsmiCadEspecieRaca.Click += TsmiCadEspecieRaca_Click;
            // 
            // BtnEmpresa
            // 
            BtnEmpresa.AutoSize = false;
            BtnEmpresa.DropDownItems.AddRange(new ToolStripItem[] { TsmiCadEmpresa, TsmiConsultaEmp, TsmiCadFornecedor });
            BtnEmpresa.Image = (Image)resources.GetObject("BtnEmpresa.Image");
            BtnEmpresa.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEmpresa.ImageTransparentColor = Color.Black;
            BtnEmpresa.Name = "BtnEmpresa";
            BtnEmpresa.Size = new Size(200, 40);
            BtnEmpresa.Text = "Empresa";
            BtnEmpresa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TsmiCadEmpresa
            // 
            TsmiCadEmpresa.Name = "TsmiCadEmpresa";
            TsmiCadEmpresa.Size = new Size(184, 22);
            TsmiCadEmpresa.Text = "Cadastro Empresa";
            TsmiCadEmpresa.Click += TsmiCadEmpresa_Click;
            // 
            // TsmiConsultaEmp
            // 
            TsmiConsultaEmp.Name = "TsmiConsultaEmp";
            TsmiConsultaEmp.Size = new Size(184, 22);
            TsmiConsultaEmp.Text = "Consulta Empresa";
            TsmiConsultaEmp.Click += TsmiConsultaEmp_Click;
            // 
            // TsmiCadFornecedor
            // 
            TsmiCadFornecedor.Name = "TsmiCadFornecedor";
            TsmiCadFornecedor.Size = new Size(184, 22);
            TsmiCadFornecedor.Text = "Cadastro Fornecedor";
            TsmiCadFornecedor.Click += TsmiCadFornecedor_Click;
            // 
            // BtnFuncionarios
            // 
            BtnFuncionarios.AutoSize = false;
            BtnFuncionarios.DropDownItems.AddRange(new ToolStripItem[] { TsmiCadFunc, TsmiConsultaFunc });
            BtnFuncionarios.Image = (Image)resources.GetObject("BtnFuncionarios.Image");
            BtnFuncionarios.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFuncionarios.ImageTransparentColor = Color.Black;
            BtnFuncionarios.Name = "BtnFuncionarios";
            BtnFuncionarios.Size = new Size(200, 40);
            BtnFuncionarios.Text = "Funcionarios";
            BtnFuncionarios.TextAlign = ContentAlignment.MiddleLeft;
            BtnFuncionarios.Paint += BtnFuncionarios_Paint;
            // 
            // TsmiCadFunc
            // 
            TsmiCadFunc.Name = "TsmiCadFunc";
            TsmiCadFunc.Size = new Size(187, 22);
            TsmiCadFunc.Text = "Cadastro Funcionário";
            TsmiCadFunc.Click += TsmiCadFunc_Click;
            // 
            // TsmiConsultaFunc
            // 
            TsmiConsultaFunc.Name = "TsmiConsultaFunc";
            TsmiConsultaFunc.Size = new Size(187, 22);
            TsmiConsultaFunc.Text = "Consulta Funcionário";
            TsmiConsultaFunc.Click += TsmiConsultaFunc_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(198, 6);
            // 
            // BtnAtendimentos
            // 
            BtnAtendimentos.AutoSize = false;
            BtnAtendimentos.Image = (Image)resources.GetObject("BtnAtendimentos.Image");
            BtnAtendimentos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAtendimentos.ImageTransparentColor = Color.Black;
            BtnAtendimentos.Name = "BtnAtendimentos";
            BtnAtendimentos.Size = new Size(200, 40);
            BtnAtendimentos.Text = "Atendimentos";
            BtnAtendimentos.TextAlign = ContentAlignment.MiddleLeft;
            BtnAtendimentos.Click += BtnAtendimentos_Click;
            BtnAtendimentos.Paint += BtnAtendimentos_Paint;
            // 
            // BtnAgendamentos
            // 
            BtnAgendamentos.AutoSize = false;
            BtnAgendamentos.Image = (Image)resources.GetObject("BtnAgendamentos.Image");
            BtnAgendamentos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgendamentos.ImageTransparentColor = Color.Black;
            BtnAgendamentos.Name = "BtnAgendamentos";
            BtnAgendamentos.Size = new Size(200, 40);
            BtnAgendamentos.Text = "Agendamentos";
            BtnAgendamentos.TextAlign = ContentAlignment.MiddleLeft;
            BtnAgendamentos.TextDirection = ToolStripTextDirection.Horizontal;
            BtnAgendamentos.Click += BtnAgendamentos_Click;
            BtnAgendamentos.Paint += BtnAgendamentos_Paint;
            // 
            // BtnExames
            // 
            BtnExames.AutoSize = false;
            BtnExames.Image = (Image)resources.GetObject("BtnExames.Image");
            BtnExames.ImageAlign = ContentAlignment.MiddleLeft;
            BtnExames.ImageTransparentColor = Color.Black;
            BtnExames.Name = "BtnExames";
            BtnExames.Size = new Size(200, 40);
            BtnExames.Text = "Exames";
            BtnExames.TextAlign = ContentAlignment.MiddleLeft;
            BtnExames.Click += BtnExames_Click;
            BtnExames.Paint += BtnExames_Paint;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(198, 6);
            // 
            // BtnMedicamento
            // 
            BtnMedicamento.AutoSize = false;
            BtnMedicamento.DropDownItems.AddRange(new ToolStripItem[] { TsmiCadMed, TsmiCadVac });
            BtnMedicamento.Image = (Image)resources.GetObject("BtnMedicamento.Image");
            BtnMedicamento.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMedicamento.ImageTransparentColor = Color.Black;
            BtnMedicamento.Name = "BtnMedicamento";
            BtnMedicamento.Size = new Size(200, 40);
            BtnMedicamento.Text = "Medicamentos";
            BtnMedicamento.TextAlign = ContentAlignment.MiddleLeft;
            BtnMedicamento.Paint += BtnMedicamento_Paint;
            // 
            // TsmiCadMed
            // 
            TsmiCadMed.Name = "TsmiCadMed";
            TsmiCadMed.Size = new Size(198, 22);
            TsmiCadMed.Text = "Cadastro Medicamento";
            TsmiCadMed.Click += TsmiCadMed_Click;
            // 
            // TsmiCadVac
            // 
            TsmiCadVac.Name = "TsmiCadVac";
            TsmiCadVac.Size = new Size(198, 22);
            TsmiCadVac.Text = "Cadastro Vacina";
            TsmiCadVac.Click += TsmiCadVac_Click;
            // 
            // BtnServico
            // 
            BtnServico.AutoSize = false;
            BtnServico.DropDownItems.AddRange(new ToolStripItem[] { TsmiCadServ });
            BtnServico.Image = (Image)resources.GetObject("BtnServico.Image");
            BtnServico.ImageAlign = ContentAlignment.MiddleLeft;
            BtnServico.ImageTransparentColor = Color.Black;
            BtnServico.Name = "BtnServico";
            BtnServico.Size = new Size(200, 40);
            BtnServico.Text = "Serviços";
            BtnServico.TextAlign = ContentAlignment.MiddleLeft;
            BtnServico.Paint += BtnServico_Paint;
            // 
            // TsmiCadServ
            // 
            TsmiCadServ.Name = "TsmiCadServ";
            TsmiCadServ.Size = new Size(162, 22);
            TsmiCadServ.Text = "Cadastro Serviço";
            TsmiCadServ.Click += TsmiCadServ_Click;
            // 
            // BtnOutros
            // 
            BtnOutros.AutoSize = false;
            BtnOutros.Image = (Image)resources.GetObject("BtnOutros.Image");
            BtnOutros.ImageAlign = ContentAlignment.MiddleLeft;
            BtnOutros.ImageTransparentColor = Color.Black;
            BtnOutros.Name = "BtnOutros";
            BtnOutros.Size = new Size(200, 40);
            BtnOutros.Text = "Outros";
            BtnOutros.TextAlign = ContentAlignment.MiddleLeft;
            BtnOutros.Paint += BtnVacinas_Paint;
            // 
            // BtnConfig
            // 
            BtnConfig.AutoSize = false;
            BtnConfig.DropDownItems.AddRange(new ToolStripItem[] { TsmiAlterarSenha, TsmiBD });
            BtnConfig.Image = (Image)resources.GetObject("BtnConfig.Image");
            BtnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            BtnConfig.ImageTransparentColor = Color.Black;
            BtnConfig.Name = "BtnConfig";
            BtnConfig.Size = new Size(200, 40);
            BtnConfig.Text = "Configurações";
            BtnConfig.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TsmiAlterarSenha
            // 
            TsmiAlterarSenha.Name = "TsmiAlterarSenha";
            TsmiAlterarSenha.Size = new Size(159, 22);
            TsmiAlterarSenha.Text = "Alterar Senha";
            TsmiAlterarSenha.Click += TsmiAlterarSenha_Click;
            // 
            // TsmiBD
            // 
            TsmiBD.Name = "TsmiBD";
            TsmiBD.Size = new Size(159, 22);
            TsmiBD.Text = "Banco de Dados";
            TsmiBD.Click += TsmiBD_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(201, 573);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 17, 0);
            statusStrip.Size = new Size(1096, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // TsmiConsultaPet
            // 
            TsmiConsultaPet.Name = "TsmiConsultaPet";
            TsmiConsultaPet.Size = new Size(193, 22);
            TsmiConsultaPet.Text = "Consulta Pet";
            TsmiConsultaPet.Click += TsmiConsultaPet_Click;
            // 
            // MDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 595);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            Name = "MDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VetSysControl";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        public ToolStripButton BtnAtendimentos;
        public ToolStripButton BtnAgendamentos;
        public ToolStripButton BtnExames;
        private ToolStripSeparator toolStripSeparator2;
        public ToolStripDropDownButton BtnPets;
        private ToolStripMenuItem TsmiCadPet;
        private ToolStripMenuItem TsmiCadEspecieRaca;
        public ToolStripDropDownButton BtnClientes;
        private ToolStripMenuItem TsmiCadCli;
        public ToolStripDropDownButton BtnFuncionarios;
        private ToolStripMenuItem TsmiCadFunc;
        private ToolStripMenuItem TsmiConsultaCli;
        private ToolStripMenuItem TsmiConsultaFunc;
        public ToolStripDropDownButton BtnMedicamento;
        private ToolStripMenuItem TsmiCadMed;
        public ToolStripDropDownButton BtnEmpresa;
        private ToolStripMenuItem TsmiCadEmpresa;
        private ToolStripMenuItem TsmiConsultaEmp;
        public ToolStripDropDownButton BtnServico;
        private ToolStripMenuItem TsmiCadServ;
        private ToolStripMenuItem TsmiCadFornecedor;
        private ToolStripMenuItem TsmiCadVac;
        public ToolStripDropDownButton BtnOutros;
        public ToolStripDropDownButton BtnConfig;
        private ToolStripMenuItem TsmiAlterarSenha;
        private ToolStripMenuItem TsmiBD;
        private ToolStripMenuItem TsmiConsultaPet;
    }
}




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
            BtnClientes = new ToolStripButton();
            BtnFuncionarios = new ToolStripButton();
            BtnPets = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnAtendimentos = new ToolStripButton();
            BtnAgendamentos = new ToolStripButton();
            BtnExames = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BtnEspecieRaca = new ToolStripButton();
            BtnMedicamento = new ToolStripButton();
            BtnFornecedor = new ToolStripButton();
            BtnServico = new ToolStripButton();
            BtnVacinas = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
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
            toolStrip.Items.AddRange(new ToolStripItem[] { BtnClientes, BtnFuncionarios, BtnPets, toolStripSeparator1, BtnAtendimentos, BtnAgendamentos, BtnExames, toolStripSeparator2, BtnEspecieRaca, BtnMedicamento, BtnFornecedor, BtnServico, BtnVacinas });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(201, 595);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // BtnClientes
            // 
            BtnClientes.AutoSize = false;
            BtnClientes.Image = (Image)resources.GetObject("BtnClientes.Image");
            BtnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnClientes.ImageTransparentColor = Color.Black;
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(198, 48);
            BtnClientes.Text = "Clientes";
            BtnClientes.TextAlign = ContentAlignment.MiddleLeft;
            BtnClientes.Click += BtnClientes_Click;
            BtnClientes.Paint += BtnClientes_Paint;
            // 
            // BtnFuncionarios
            // 
            BtnFuncionarios.AutoSize = false;
            BtnFuncionarios.Image = (Image)resources.GetObject("BtnFuncionarios.Image");
            BtnFuncionarios.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFuncionarios.ImageTransparentColor = Color.Black;
            BtnFuncionarios.Name = "BtnFuncionarios";
            BtnFuncionarios.Size = new Size(200, 48);
            BtnFuncionarios.Text = "Funcionarios";
            BtnFuncionarios.TextAlign = ContentAlignment.MiddleLeft;
            BtnFuncionarios.Click += BtnFuncionarios_Click;
            BtnFuncionarios.Paint += BtnFuncionarios_Paint;
            // 
            // BtnPets
            // 
            BtnPets.AutoSize = false;
            BtnPets.Image = (Image)resources.GetObject("BtnPets.Image");
            BtnPets.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPets.ImageTransparentColor = Color.Black;
            BtnPets.Name = "BtnPets";
            BtnPets.Size = new Size(200, 48);
            BtnPets.Text = "Animais / Pets";
            BtnPets.TextAlign = ContentAlignment.MiddleLeft;
            BtnPets.Click += BtnPets_Click;
            BtnPets.Paint += BtnPets_Paint;
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
            BtnAtendimentos.Size = new Size(200, 48);
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
            BtnAgendamentos.Size = new Size(200, 48);
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
            BtnExames.Size = new Size(200, 48);
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
            // BtnEspecieRaca
            // 
            BtnEspecieRaca.AutoSize = false;
            BtnEspecieRaca.Image = (Image)resources.GetObject("BtnEspecieRaca.Image");
            BtnEspecieRaca.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEspecieRaca.ImageTransparentColor = Color.Black;
            BtnEspecieRaca.Name = "BtnEspecieRaca";
            BtnEspecieRaca.Size = new Size(200, 48);
            BtnEspecieRaca.Text = "Raças";
            BtnEspecieRaca.TextAlign = ContentAlignment.MiddleLeft;
            BtnEspecieRaca.Click += BtnEspecieRaca_Click;
            BtnEspecieRaca.Paint += BtnEspecieRaca_Paint;
            // 
            // BtnMedicamento
            // 
            BtnMedicamento.AutoSize = false;
            BtnMedicamento.Image = (Image)resources.GetObject("BtnMedicamento.Image");
            BtnMedicamento.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMedicamento.ImageTransparentColor = Color.Black;
            BtnMedicamento.Name = "BtnMedicamento";
            BtnMedicamento.Size = new Size(200, 48);
            BtnMedicamento.Text = "Medicamentos";
            BtnMedicamento.TextAlign = ContentAlignment.MiddleLeft;
            BtnMedicamento.Click += BtnMedicamento_Click;
            BtnMedicamento.Paint += BtnMedicamento_Paint;
            // 
            // BtnFornecedor
            // 
            BtnFornecedor.AutoSize = false;
            BtnFornecedor.Image = (Image)resources.GetObject("BtnFornecedor.Image");
            BtnFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFornecedor.ImageTransparentColor = Color.Black;
            BtnFornecedor.Name = "BtnFornecedor";
            BtnFornecedor.Size = new Size(200, 48);
            BtnFornecedor.Text = "Fornecedores";
            BtnFornecedor.TextAlign = ContentAlignment.MiddleLeft;
            BtnFornecedor.Click += BtnFornecedor_Click;
            BtnFornecedor.Paint += BtnFornecedor_Paint;
            // 
            // BtnServico
            // 
            BtnServico.AutoSize = false;
            BtnServico.Image = (Image)resources.GetObject("BtnServico.Image");
            BtnServico.ImageAlign = ContentAlignment.MiddleLeft;
            BtnServico.ImageTransparentColor = Color.Black;
            BtnServico.Name = "BtnServico";
            BtnServico.Size = new Size(200, 48);
            BtnServico.Text = "Serviços";
            BtnServico.TextAlign = ContentAlignment.MiddleLeft;
            BtnServico.Click += BtnServico_Click;
            BtnServico.Paint += BtnServico_Paint;
            // 
            // BtnVacinas
            // 
            BtnVacinas.AutoSize = false;
            BtnVacinas.Image = (Image)resources.GetObject("BtnVacinas.Image");
            BtnVacinas.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVacinas.ImageTransparentColor = Color.Black;
            BtnVacinas.Name = "BtnVacinas";
            BtnVacinas.Size = new Size(200, 48);
            BtnVacinas.Text = "Vacinas";
            BtnVacinas.TextAlign = ContentAlignment.MiddleLeft;
            BtnVacinas.Click += BtnVacinas_Click;
            BtnVacinas.Paint += BtnVacinas_Paint;
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
        public ToolStripButton BtnClientes;
        public ToolStripButton BtnAtendimentos;
        public ToolStripButton BtnAgendamentos;
        public ToolStripButton BtnExames;
        private ToolStripSeparator toolStripSeparator2;
        public ToolStripButton BtnEspecieRaca;
        public ToolStripButton BtnMedicamento;
        public ToolStripButton BtnFornecedor;
        public ToolStripButton BtnPets;
        public ToolStripButton BtnServico;
        public ToolStripButton BtnFuncionarios;
        public ToolStripButton BtnVacinas;
    }
}




namespace LineCounter2000
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentDirTextBox = new System.Windows.Forms.TextBox();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.checkedFileList = new LineCounter2000.CheckedFileList();
            this.makeSelectedIntoProject = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totUsedLinesTable = new System.Windows.Forms.Label();
            this.totLinesLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1035, 1052);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 985);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.currentDirTextBox);
            this.flowLayoutPanel2.Controls.Add(this.openFolderButton);
            this.flowLayoutPanel2.Controls.Add(this.checkedFileList);
            this.flowLayoutPanel2.Controls.Add(this.makeSelectedIntoProject);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(480, 985);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // currentDirTextBox
            // 
            this.currentDirTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentDirTextBox.Location = new System.Drawing.Point(3, 3);
            this.currentDirTextBox.Name = "currentDirTextBox";
            this.currentDirTextBox.Size = new System.Drawing.Size(310, 26);
            this.currentDirTextBox.TabIndex = 1;
            this.currentDirTextBox.Text = "c://";
            this.currentDirTextBox.TextChanged += new System.EventHandler(this.currentDirTextBox_TextChanged);
            this.currentDirTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentDirTextBox_KeyPress);
            // 
            // openFolderButton
            // 
            this.openFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openFolderButton.Location = new System.Drawing.Point(319, 3);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(84, 31);
            this.openFolderButton.TabIndex = 2;
            this.openFolderButton.Text = "Browse";
            this.openFolderButton.UseVisualStyleBackColor = true;
            // 
            // checkedFileList
            // 
            this.checkedFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedFileList.FormattingEnabled = true;
            this.checkedFileList.Items.AddRange(new object[] {
            "..",
            ((object)(resources.GetObject("checkedFileList.Items"))),
            ((object)(resources.GetObject("checkedFileList.Items1"))),
            ((object)(resources.GetObject("checkedFileList.Items2"))),
            ((object)(resources.GetObject("checkedFileList.Items3"))),
            ((object)(resources.GetObject("checkedFileList.Items4"))),
            ((object)(resources.GetObject("checkedFileList.Items5"))),
            ((object)(resources.GetObject("checkedFileList.Items6"))),
            ((object)(resources.GetObject("checkedFileList.Items7"))),
            ((object)(resources.GetObject("checkedFileList.Items8"))),
            ((object)(resources.GetObject("checkedFileList.Items9"))),
            ((object)(resources.GetObject("checkedFileList.Items10"))),
            ((object)(resources.GetObject("checkedFileList.Items11"))),
            ((object)(resources.GetObject("checkedFileList.Items12"))),
            ((object)(resources.GetObject("checkedFileList.Items13"))),
            ((object)(resources.GetObject("checkedFileList.Items14"))),
            ((object)(resources.GetObject("checkedFileList.Items15"))),
            ((object)(resources.GetObject("checkedFileList.Items16"))),
            ((object)(resources.GetObject("checkedFileList.Items17"))),
            ((object)(resources.GetObject("checkedFileList.Items18"))),
            ((object)(resources.GetObject("checkedFileList.Items19"))),
            ((object)(resources.GetObject("checkedFileList.Items20"))),
            ((object)(resources.GetObject("checkedFileList.Items21"))),
            ((object)(resources.GetObject("checkedFileList.Items22"))),
            ((object)(resources.GetObject("checkedFileList.Items23"))),
            ((object)(resources.GetObject("checkedFileList.Items24"))),
            ((object)(resources.GetObject("checkedFileList.Items25"))),
            ((object)(resources.GetObject("checkedFileList.Items26"))),
            ((object)(resources.GetObject("checkedFileList.Items27"))),
            ((object)(resources.GetObject("checkedFileList.Items28"))),
            ((object)(resources.GetObject("checkedFileList.Items29"))),
            ((object)(resources.GetObject("checkedFileList.Items30"))),
            ((object)(resources.GetObject("checkedFileList.Items31"))),
            ((object)(resources.GetObject("checkedFileList.Items32"))),
            ((object)(resources.GetObject("checkedFileList.Items33"))),
            ((object)(resources.GetObject("checkedFileList.Items34"))),
            ((object)(resources.GetObject("checkedFileList.Items35"))),
            ((object)(resources.GetObject("checkedFileList.Items36"))),
            ((object)(resources.GetObject("checkedFileList.Items37"))),
            ((object)(resources.GetObject("checkedFileList.Items38"))),
            ((object)(resources.GetObject("checkedFileList.Items39"))),
            ((object)(resources.GetObject("checkedFileList.Items40"))),
            ((object)(resources.GetObject("checkedFileList.Items41"))),
            ((object)(resources.GetObject("checkedFileList.Items42"))),
            ((object)(resources.GetObject("checkedFileList.Items43"))),
            ((object)(resources.GetObject("checkedFileList.Items44"))),
            ((object)(resources.GetObject("checkedFileList.Items45"))),
            ((object)(resources.GetObject("checkedFileList.Items46"))),
            ((object)(resources.GetObject("checkedFileList.Items47"))),
            ((object)(resources.GetObject("checkedFileList.Items48"))),
            ((object)(resources.GetObject("checkedFileList.Items49"))),
            ((object)(resources.GetObject("checkedFileList.Items50"))),
            ((object)(resources.GetObject("checkedFileList.Items51"))),
            ((object)(resources.GetObject("checkedFileList.Items52"))),
            ((object)(resources.GetObject("checkedFileList.Items53"))),
            ((object)(resources.GetObject("checkedFileList.Items54"))),
            ((object)(resources.GetObject("checkedFileList.Items55"))),
            ((object)(resources.GetObject("checkedFileList.Items56"))),
            ((object)(resources.GetObject("checkedFileList.Items57"))),
            ((object)(resources.GetObject("checkedFileList.Items58"))),
            ((object)(resources.GetObject("checkedFileList.Items59"))),
            ((object)(resources.GetObject("checkedFileList.Items60"))),
            ((object)(resources.GetObject("checkedFileList.Items61"))),
            ((object)(resources.GetObject("checkedFileList.Items62"))),
            ((object)(resources.GetObject("checkedFileList.Items63"))),
            ((object)(resources.GetObject("checkedFileList.Items64"))),
            ((object)(resources.GetObject("checkedFileList.Items65"))),
            ((object)(resources.GetObject("checkedFileList.Items66"))),
            ((object)(resources.GetObject("checkedFileList.Items67"))),
            ((object)(resources.GetObject("checkedFileList.Items68"))),
            ((object)(resources.GetObject("checkedFileList.Items69"))),
            ((object)(resources.GetObject("checkedFileList.Items70"))),
            ((object)(resources.GetObject("checkedFileList.Items71"))),
            ((object)(resources.GetObject("checkedFileList.Items72"))),
            ((object)(resources.GetObject("checkedFileList.Items73"))),
            ((object)(resources.GetObject("checkedFileList.Items74"))),
            ((object)(resources.GetObject("checkedFileList.Items75"))),
            ((object)(resources.GetObject("checkedFileList.Items76"))),
            ((object)(resources.GetObject("checkedFileList.Items77"))),
            ((object)(resources.GetObject("checkedFileList.Items78"))),
            ((object)(resources.GetObject("checkedFileList.Items79"))),
            ((object)(resources.GetObject("checkedFileList.Items80"))),
            ((object)(resources.GetObject("checkedFileList.Items81"))),
            ((object)(resources.GetObject("checkedFileList.Items82"))),
            ((object)(resources.GetObject("checkedFileList.Items83"))),
            ((object)(resources.GetObject("checkedFileList.Items84"))),
            ((object)(resources.GetObject("checkedFileList.Items85"))),
            ((object)(resources.GetObject("checkedFileList.Items86"))),
            ((object)(resources.GetObject("checkedFileList.Items87"))),
            ((object)(resources.GetObject("checkedFileList.Items88"))),
            ((object)(resources.GetObject("checkedFileList.Items89"))),
            ((object)(resources.GetObject("checkedFileList.Items90"))),
            ((object)(resources.GetObject("checkedFileList.Items91"))),
            ((object)(resources.GetObject("checkedFileList.Items92"))),
            ((object)(resources.GetObject("checkedFileList.Items93"))),
            ((object)(resources.GetObject("checkedFileList.Items94"))),
            ((object)(resources.GetObject("checkedFileList.Items95"))),
            ((object)(resources.GetObject("checkedFileList.Items96"))),
            ((object)(resources.GetObject("checkedFileList.Items97"))),
            ((object)(resources.GetObject("checkedFileList.Items98"))),
            ((object)(resources.GetObject("checkedFileList.Items99"))),
            ((object)(resources.GetObject("checkedFileList.Items100"))),
            ((object)(resources.GetObject("checkedFileList.Items101"))),
            ((object)(resources.GetObject("checkedFileList.Items102"))),
            ((object)(resources.GetObject("checkedFileList.Items103"))),
            ((object)(resources.GetObject("checkedFileList.Items104"))),
            ((object)(resources.GetObject("checkedFileList.Items105"))),
            ((object)(resources.GetObject("checkedFileList.Items106"))),
            ((object)(resources.GetObject("checkedFileList.Items107"))),
            ((object)(resources.GetObject("checkedFileList.Items108"))),
            ((object)(resources.GetObject("checkedFileList.Items109"))),
            ((object)(resources.GetObject("checkedFileList.Items110"))),
            ((object)(resources.GetObject("checkedFileList.Items111"))),
            ((object)(resources.GetObject("checkedFileList.Items112"))),
            ((object)(resources.GetObject("checkedFileList.Items113"))),
            ((object)(resources.GetObject("checkedFileList.Items114"))),
            ((object)(resources.GetObject("checkedFileList.Items115"))),
            ((object)(resources.GetObject("checkedFileList.Items116"))),
            ((object)(resources.GetObject("checkedFileList.Items117"))),
            ((object)(resources.GetObject("checkedFileList.Items118"))),
            ((object)(resources.GetObject("checkedFileList.Items119"))),
            ((object)(resources.GetObject("checkedFileList.Items120"))),
            ((object)(resources.GetObject("checkedFileList.Items121"))),
            ((object)(resources.GetObject("checkedFileList.Items122"))),
            ((object)(resources.GetObject("checkedFileList.Items123"))),
            ((object)(resources.GetObject("checkedFileList.Items124"))),
            ((object)(resources.GetObject("checkedFileList.Items125"))),
            ((object)(resources.GetObject("checkedFileList.Items126"))),
            ((object)(resources.GetObject("checkedFileList.Items127"))),
            ((object)(resources.GetObject("checkedFileList.Items128"))),
            ((object)(resources.GetObject("checkedFileList.Items129"))),
            ((object)(resources.GetObject("checkedFileList.Items130"))),
            ((object)(resources.GetObject("checkedFileList.Items131"))),
            ((object)(resources.GetObject("checkedFileList.Items132"))),
            ((object)(resources.GetObject("checkedFileList.Items133"))),
            ((object)(resources.GetObject("checkedFileList.Items134"))),
            ((object)(resources.GetObject("checkedFileList.Items135"))),
            ((object)(resources.GetObject("checkedFileList.Items136"))),
            ((object)(resources.GetObject("checkedFileList.Items137"))),
            ((object)(resources.GetObject("checkedFileList.Items138"))),
            ((object)(resources.GetObject("checkedFileList.Items139"))),
            ((object)(resources.GetObject("checkedFileList.Items140"))),
            ((object)(resources.GetObject("checkedFileList.Items141"))),
            ((object)(resources.GetObject("checkedFileList.Items142"))),
            ((object)(resources.GetObject("checkedFileList.Items143"))),
            ((object)(resources.GetObject("checkedFileList.Items144"))),
            ((object)(resources.GetObject("checkedFileList.Items145"))),
            ((object)(resources.GetObject("checkedFileList.Items146"))),
            ((object)(resources.GetObject("checkedFileList.Items147"))),
            ((object)(resources.GetObject("checkedFileList.Items148"))),
            ((object)(resources.GetObject("checkedFileList.Items149"))),
            ((object)(resources.GetObject("checkedFileList.Items150"))),
            ((object)(resources.GetObject("checkedFileList.Items151"))),
            ((object)(resources.GetObject("checkedFileList.Items152"))),
            ((object)(resources.GetObject("checkedFileList.Items153"))),
            ((object)(resources.GetObject("checkedFileList.Items154"))),
            ((object)(resources.GetObject("checkedFileList.Items155"))),
            ((object)(resources.GetObject("checkedFileList.Items156"))),
            ((object)(resources.GetObject("checkedFileList.Items157"))),
            ((object)(resources.GetObject("checkedFileList.Items158"))),
            ((object)(resources.GetObject("checkedFileList.Items159"))),
            ((object)(resources.GetObject("checkedFileList.Items160"))),
            ((object)(resources.GetObject("checkedFileList.Items161"))),
            ((object)(resources.GetObject("checkedFileList.Items162"))),
            ((object)(resources.GetObject("checkedFileList.Items163"))),
            ((object)(resources.GetObject("checkedFileList.Items164"))),
            ((object)(resources.GetObject("checkedFileList.Items165"))),
            ((object)(resources.GetObject("checkedFileList.Items166"))),
            ((object)(resources.GetObject("checkedFileList.Items167"))),
            ((object)(resources.GetObject("checkedFileList.Items168"))),
            ((object)(resources.GetObject("checkedFileList.Items169"))),
            ((object)(resources.GetObject("checkedFileList.Items170"))),
            ((object)(resources.GetObject("checkedFileList.Items171"))),
            ((object)(resources.GetObject("checkedFileList.Items172"))),
            ((object)(resources.GetObject("checkedFileList.Items173"))),
            ((object)(resources.GetObject("checkedFileList.Items174"))),
            ((object)(resources.GetObject("checkedFileList.Items175"))),
            ((object)(resources.GetObject("checkedFileList.Items176"))),
            ((object)(resources.GetObject("checkedFileList.Items177"))),
            ((object)(resources.GetObject("checkedFileList.Items178"))),
            ((object)(resources.GetObject("checkedFileList.Items179"))),
            ((object)(resources.GetObject("checkedFileList.Items180"))),
            ((object)(resources.GetObject("checkedFileList.Items181"))),
            ((object)(resources.GetObject("checkedFileList.Items182"))),
            ((object)(resources.GetObject("checkedFileList.Items183"))),
            ((object)(resources.GetObject("checkedFileList.Items184"))),
            ((object)(resources.GetObject("checkedFileList.Items185"))),
            ((object)(resources.GetObject("checkedFileList.Items186"))),
            ((object)(resources.GetObject("checkedFileList.Items187"))),
            ((object)(resources.GetObject("checkedFileList.Items188"))),
            ((object)(resources.GetObject("checkedFileList.Items189"))),
            ((object)(resources.GetObject("checkedFileList.Items190"))),
            ((object)(resources.GetObject("checkedFileList.Items191"))),
            ((object)(resources.GetObject("checkedFileList.Items192"))),
            ((object)(resources.GetObject("checkedFileList.Items193"))),
            ((object)(resources.GetObject("checkedFileList.Items194"))),
            ((object)(resources.GetObject("checkedFileList.Items195"))),
            ((object)(resources.GetObject("checkedFileList.Items196"))),
            ((object)(resources.GetObject("checkedFileList.Items197"))),
            ((object)(resources.GetObject("checkedFileList.Items198"))),
            ((object)(resources.GetObject("checkedFileList.Items199"))),
            ((object)(resources.GetObject("checkedFileList.Items200"))),
            ((object)(resources.GetObject("checkedFileList.Items201"))),
            ((object)(resources.GetObject("checkedFileList.Items202"))),
            ((object)(resources.GetObject("checkedFileList.Items203"))),
            ((object)(resources.GetObject("checkedFileList.Items204"))),
            ((object)(resources.GetObject("checkedFileList.Items205"))),
            ((object)(resources.GetObject("checkedFileList.Items206"))),
            ((object)(resources.GetObject("checkedFileList.Items207"))),
            ((object)(resources.GetObject("checkedFileList.Items208"))),
            ((object)(resources.GetObject("checkedFileList.Items209"))),
            ((object)(resources.GetObject("checkedFileList.Items210"))),
            ((object)(resources.GetObject("checkedFileList.Items211"))),
            ((object)(resources.GetObject("checkedFileList.Items212"))),
            ((object)(resources.GetObject("checkedFileList.Items213"))),
            ((object)(resources.GetObject("checkedFileList.Items214"))),
            ((object)(resources.GetObject("checkedFileList.Items215"))),
            ((object)(resources.GetObject("checkedFileList.Items216"))),
            ((object)(resources.GetObject("checkedFileList.Items217"))),
            ((object)(resources.GetObject("checkedFileList.Items218"))),
            ((object)(resources.GetObject("checkedFileList.Items219"))),
            ((object)(resources.GetObject("checkedFileList.Items220"))),
            ((object)(resources.GetObject("checkedFileList.Items221"))),
            ((object)(resources.GetObject("checkedFileList.Items222"))),
            ((object)(resources.GetObject("checkedFileList.Items223"))),
            ((object)(resources.GetObject("checkedFileList.Items224"))),
            ((object)(resources.GetObject("checkedFileList.Items225"))),
            ((object)(resources.GetObject("checkedFileList.Items226"))),
            ((object)(resources.GetObject("checkedFileList.Items227"))),
            ((object)(resources.GetObject("checkedFileList.Items228"))),
            ((object)(resources.GetObject("checkedFileList.Items229"))),
            ((object)(resources.GetObject("checkedFileList.Items230"))),
            ((object)(resources.GetObject("checkedFileList.Items231"))),
            ((object)(resources.GetObject("checkedFileList.Items232"))),
            ((object)(resources.GetObject("checkedFileList.Items233"))),
            ((object)(resources.GetObject("checkedFileList.Items234"))),
            ((object)(resources.GetObject("checkedFileList.Items235"))),
            ((object)(resources.GetObject("checkedFileList.Items236"))),
            ((object)(resources.GetObject("checkedFileList.Items237"))),
            ((object)(resources.GetObject("checkedFileList.Items238"))),
            ((object)(resources.GetObject("checkedFileList.Items239"))),
            ((object)(resources.GetObject("checkedFileList.Items240"))),
            ((object)(resources.GetObject("checkedFileList.Items241"))),
            ((object)(resources.GetObject("checkedFileList.Items242"))),
            ((object)(resources.GetObject("checkedFileList.Items243"))),
            ((object)(resources.GetObject("checkedFileList.Items244"))),
            ((object)(resources.GetObject("checkedFileList.Items245"))),
            ((object)(resources.GetObject("checkedFileList.Items246"))),
            ((object)(resources.GetObject("checkedFileList.Items247"))),
            ((object)(resources.GetObject("checkedFileList.Items248"))),
            ((object)(resources.GetObject("checkedFileList.Items249"))),
            ((object)(resources.GetObject("checkedFileList.Items250"))),
            ((object)(resources.GetObject("checkedFileList.Items251"))),
            ((object)(resources.GetObject("checkedFileList.Items252"))),
            ((object)(resources.GetObject("checkedFileList.Items253"))),
            ((object)(resources.GetObject("checkedFileList.Items254"))),
            ((object)(resources.GetObject("checkedFileList.Items255"))),
            ((object)(resources.GetObject("checkedFileList.Items256"))),
            ((object)(resources.GetObject("checkedFileList.Items257"))),
            ((object)(resources.GetObject("checkedFileList.Items258"))),
            ((object)(resources.GetObject("checkedFileList.Items259"))),
            ((object)(resources.GetObject("checkedFileList.Items260"))),
            ((object)(resources.GetObject("checkedFileList.Items261"))),
            ((object)(resources.GetObject("checkedFileList.Items262"))),
            ((object)(resources.GetObject("checkedFileList.Items263"))),
            ((object)(resources.GetObject("checkedFileList.Items264"))),
            ((object)(resources.GetObject("checkedFileList.Items265"))),
            ((object)(resources.GetObject("checkedFileList.Items266"))),
            ((object)(resources.GetObject("checkedFileList.Items267"))),
            ((object)(resources.GetObject("checkedFileList.Items268"))),
            ((object)(resources.GetObject("checkedFileList.Items269"))),
            ((object)(resources.GetObject("checkedFileList.Items270"))),
            ((object)(resources.GetObject("checkedFileList.Items271"))),
            ((object)(resources.GetObject("checkedFileList.Items272"))),
            ((object)(resources.GetObject("checkedFileList.Items273"))),
            ((object)(resources.GetObject("checkedFileList.Items274"))),
            ((object)(resources.GetObject("checkedFileList.Items275"))),
            ((object)(resources.GetObject("checkedFileList.Items276"))),
            ((object)(resources.GetObject("checkedFileList.Items277"))),
            ((object)(resources.GetObject("checkedFileList.Items278"))),
            ((object)(resources.GetObject("checkedFileList.Items279"))),
            ((object)(resources.GetObject("checkedFileList.Items280"))),
            ((object)(resources.GetObject("checkedFileList.Items281"))),
            ((object)(resources.GetObject("checkedFileList.Items282"))),
            ((object)(resources.GetObject("checkedFileList.Items283"))),
            ((object)(resources.GetObject("checkedFileList.Items284"))),
            ((object)(resources.GetObject("checkedFileList.Items285"))),
            ((object)(resources.GetObject("checkedFileList.Items286"))),
            ((object)(resources.GetObject("checkedFileList.Items287"))),
            ((object)(resources.GetObject("checkedFileList.Items288"))),
            ((object)(resources.GetObject("checkedFileList.Items289"))),
            ((object)(resources.GetObject("checkedFileList.Items290"))),
            ((object)(resources.GetObject("checkedFileList.Items291"))),
            ((object)(resources.GetObject("checkedFileList.Items292"))),
            ((object)(resources.GetObject("checkedFileList.Items293"))),
            ((object)(resources.GetObject("checkedFileList.Items294"))),
            ((object)(resources.GetObject("checkedFileList.Items295"))),
            ((object)(resources.GetObject("checkedFileList.Items296"))),
            ((object)(resources.GetObject("checkedFileList.Items297"))),
            ((object)(resources.GetObject("checkedFileList.Items298"))),
            ((object)(resources.GetObject("checkedFileList.Items299"))),
            ((object)(resources.GetObject("checkedFileList.Items300"))),
            ((object)(resources.GetObject("checkedFileList.Items301"))),
            ((object)(resources.GetObject("checkedFileList.Items302"))),
            ((object)(resources.GetObject("checkedFileList.Items303"))),
            ((object)(resources.GetObject("checkedFileList.Items304"))),
            ((object)(resources.GetObject("checkedFileList.Items305"))),
            ((object)(resources.GetObject("checkedFileList.Items306"))),
            ((object)(resources.GetObject("checkedFileList.Items307"))),
            ((object)(resources.GetObject("checkedFileList.Items308"))),
            ((object)(resources.GetObject("checkedFileList.Items309"))),
            ((object)(resources.GetObject("checkedFileList.Items310"))),
            ((object)(resources.GetObject("checkedFileList.Items311"))),
            ((object)(resources.GetObject("checkedFileList.Items312"))),
            ((object)(resources.GetObject("checkedFileList.Items313"))),
            ((object)(resources.GetObject("checkedFileList.Items314"))),
            ((object)(resources.GetObject("checkedFileList.Items315"))),
            ((object)(resources.GetObject("checkedFileList.Items316"))),
            ((object)(resources.GetObject("checkedFileList.Items317"))),
            ((object)(resources.GetObject("checkedFileList.Items318"))),
            ((object)(resources.GetObject("checkedFileList.Items319"))),
            ((object)(resources.GetObject("checkedFileList.Items320"))),
            ((object)(resources.GetObject("checkedFileList.Items321"))),
            ((object)(resources.GetObject("checkedFileList.Items322"))),
            ((object)(resources.GetObject("checkedFileList.Items323"))),
            ((object)(resources.GetObject("checkedFileList.Items324"))),
            ((object)(resources.GetObject("checkedFileList.Items325"))),
            ((object)(resources.GetObject("checkedFileList.Items326"))),
            ((object)(resources.GetObject("checkedFileList.Items327"))),
            ((object)(resources.GetObject("checkedFileList.Items328"))),
            ".."});
            this.checkedFileList.Location = new System.Drawing.Point(0, 37);
            this.checkedFileList.Margin = new System.Windows.Forms.Padding(0);
            this.checkedFileList.MinimumSize = new System.Drawing.Size(400, 499);
            this.checkedFileList.Name = "checkedFileList";
            this.checkedFileList.ScrollAlwaysVisible = true;
            this.checkedFileList.Size = new System.Drawing.Size(472, 499);
            this.checkedFileList.TabIndex = 0;
            this.checkedFileList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedFileList_ItemCheck);
            this.checkedFileList.SelectedIndexChanged += new System.EventHandler(this.checkedFileList_SelectedIndexChanged);
            this.checkedFileList.DoubleClick += new System.EventHandler(this.checkedFileList_DoubleClick);
            // 
            // makeSelectedIntoProject
            // 
            this.makeSelectedIntoProject.Location = new System.Drawing.Point(4, 541);
            this.makeSelectedIntoProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.makeSelectedIntoProject.Name = "makeSelectedIntoProject";
            this.makeSelectedIntoProject.Size = new System.Drawing.Size(471, 35);
            this.makeSelectedIntoProject.TabIndex = 3;
            this.makeSelectedIntoProject.Text = "Make selected into project";
            this.makeSelectedIntoProject.UseVisualStyleBackColor = true;
            this.makeSelectedIntoProject.Click += new System.EventHandler(this.makeSelectedIntoProject_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(490, 5);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(526, 981);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.totUsedLinesTable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.totLinesLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 103);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total lines:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total used lines:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totUsedLinesTable
            // 
            this.totUsedLinesTable.AutoSize = true;
            this.totUsedLinesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totUsedLinesTable.Location = new System.Drawing.Point(265, 51);
            this.totUsedLinesTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totUsedLinesTable.Name = "totUsedLinesTable";
            this.totUsedLinesTable.Size = new System.Drawing.Size(253, 52);
            this.totUsedLinesTable.TabIndex = 1;
            this.totUsedLinesTable.Text = "-";
            this.totUsedLinesTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totLinesLabel
            // 
            this.totLinesLabel.AutoSize = true;
            this.totLinesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totLinesLabel.Location = new System.Drawing.Point(265, 0);
            this.totLinesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totLinesLabel.Name = "totLinesLabel";
            this.totLinesLabel.Size = new System.Drawing.Size(253, 51);
            this.totLinesLabel.TabIndex = 2;
            this.totLinesLabel.Text = "-";
            this.totLinesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 1052);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedFileList checkedFileList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox currentDirTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totUsedLinesTable;
        private System.Windows.Forms.Label totLinesLabel;
        private System.Windows.Forms.Button makeSelectedIntoProject;
    }
}


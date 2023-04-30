using System.Windows.Forms;

namespace TestPageNavigation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabComandos = new System.Windows.Forms.TabPage();
            this.btnLedOn = new System.Windows.Forms.Button();
            this.btnLedOff = new System.Windows.Forms.Button();
            this.btnAP = new System.Windows.Forms.Button();
            this.tabPorts = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTestTP = new System.Windows.Forms.Button();
            this.btnTestCC = new System.Windows.Forms.Button();
            this.btnTestVCAP = new System.Windows.Forms.Button();
            this.btnTestESFX = new System.Windows.Forms.Button();
            this.btnTestIMEAS = new System.Windows.Forms.Button();
            this.btnTestHall1LPF = new System.Windows.Forms.Button();
            this.btnTestHall2 = new System.Windows.Forms.Button();
            this.btnTestHall1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnTestRAM = new System.Windows.Forms.Button();
            this.tabRadio = new System.Windows.Forms.TabPage();
            this.btnStartRadio = new System.Windows.Forms.Button();
            this.btnExitRadio = new System.Windows.Forms.Button();
            this.btnCSQ = new System.Windows.Forms.Button();
            this.btnICCID = new System.Windows.Forms.Button();
            this.btnGSN = new System.Windows.Forms.Button();
            this.tbRespuesta = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbHallSel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEFSG1_5 = new System.Windows.Forms.TextBox();
            this.tbEFSG4 = new System.Windows.Forms.TextBox();
            this.tbRatioSel = new System.Windows.Forms.TextBox();
            this.tbLoZinEarth = new System.Windows.Forms.TextBox();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.tbLoZinSky = new System.Windows.Forms.TextBox();
            this.tbLED = new System.Windows.Forms.TextBox();
            this.tbLowerBurden = new System.Windows.Forms.TextBox();
            this.lbEFSG1_5 = new System.Windows.Forms.Label();
            this.lbEFSG4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPuerto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pfCSQ = new System.Windows.Forms.Label();
            this.pfICCID = new System.Windows.Forms.Label();
            this.pfIMEI = new System.Windows.Forms.Label();
            this.pfFLASH = new System.Windows.Forms.Label();
            this.pfRAM = new System.Windows.Forms.Label();
            this.pfTP = new System.Windows.Forms.Label();
            this.pfCapCharge = new System.Windows.Forms.Label();
            this.pfVCAP = new System.Windows.Forms.Label();
            this.pfESFX = new System.Windows.Forms.Label();
            this.pfIMEAS = new System.Windows.Forms.Label();
            this.pfHall1LPF = new System.Windows.Forms.Label();
            this.pfHall2 = new System.Windows.Forms.Label();
            this.tbCSQ = new System.Windows.Forms.TextBox();
            this.tbICCID = new System.Windows.Forms.TextBox();
            this.tbIMEI = new System.Windows.Forms.TextBox();
            this.tbFLASH = new System.Windows.Forms.TextBox();
            this.tbRAM = new System.Windows.Forms.TextBox();
            this.tbTP = new System.Windows.Forms.TextBox();
            this.tbCapCharge = new System.Windows.Forms.TextBox();
            this.tbVCAP = new System.Windows.Forms.TextBox();
            this.tbESFX = new System.Windows.Forms.TextBox();
            this.tbIMEAS = new System.Windows.Forms.TextBox();
            this.tbHall1LPF = new System.Windows.Forms.TextBox();
            this.tbHall2 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHall1 = new System.Windows.Forms.TextBox();
            this.pfHall1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabComandos.SuspendLayout();
            this.tabPorts.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabRadio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInicio);
            this.tabControl1.Controls.Add(this.tabComandos);
            this.tabControl1.Controls.Add(this.tabPorts);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabRadio);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 340);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabInicio
            // 
            this.tabInicio.BackColor = System.Drawing.Color.Gainsboro;
            this.tabInicio.Controls.Add(this.btnRefresh);
            this.tabInicio.Controls.Add(this.btnReboot);
            this.tabInicio.Controls.Add(this.label2);
            this.tabInicio.Controls.Add(this.comboBox1);
            this.tabInicio.Location = new System.Drawing.Point(4, 25);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(313, 311);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(190, 56);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 33);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReboot.Enabled = false;
            this.btnReboot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReboot.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReboot.Location = new System.Drawing.Point(33, 136);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(227, 69);
            this.btnReboot.TabIndex = 3;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.UseVisualStyleBackColor = false;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "-- Seleccione un puerto --";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabComandos
            // 
            this.tabComandos.BackColor = System.Drawing.Color.Gainsboro;
            this.tabComandos.Controls.Add(this.btnLedOn);
            this.tabComandos.Controls.Add(this.btnLedOff);
            this.tabComandos.Controls.Add(this.btnAP);
            this.tabComandos.ForeColor = System.Drawing.Color.Black;
            this.tabComandos.Location = new System.Drawing.Point(4, 25);
            this.tabComandos.Name = "tabComandos";
            this.tabComandos.Padding = new System.Windows.Forms.Padding(3);
            this.tabComandos.Size = new System.Drawing.Size(313, 311);
            this.tabComandos.TabIndex = 1;
            this.tabComandos.Text = "Comandos";
            // 
            // btnLedOn
            // 
            this.btnLedOn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedOn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLedOn.Location = new System.Drawing.Point(80, 35);
            this.btnLedOn.Name = "btnLedOn";
            this.btnLedOn.Size = new System.Drawing.Size(144, 53);
            this.btnLedOn.TabIndex = 4;
            this.btnLedOn.Text = "LED ON";
            this.btnLedOn.UseVisualStyleBackColor = false;
            this.btnLedOn.Click += new System.EventHandler(this.btnLedOn_Click);
            // 
            // btnLedOff
            // 
            this.btnLedOff.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLedOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedOff.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLedOff.Location = new System.Drawing.Point(80, 122);
            this.btnLedOff.Name = "btnLedOff";
            this.btnLedOff.Size = new System.Drawing.Size(144, 53);
            this.btnLedOff.TabIndex = 3;
            this.btnLedOff.Text = "LED OFF";
            this.btnLedOff.UseVisualStyleBackColor = false;
            this.btnLedOff.Click += new System.EventHandler(this.btnLedOff_Click);
            // 
            // btnAP
            // 
            this.btnAP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAP.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAP.Location = new System.Drawing.Point(80, 211);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(144, 54);
            this.btnAP.TabIndex = 1;
            this.btnAP.Text = "AP";
            this.btnAP.UseVisualStyleBackColor = false;
            this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
            // 
            // tabPorts
            // 
            this.tabPorts.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPorts.Controls.Add(this.button4);
            this.tabPorts.Controls.Add(this.button8);
            this.tabPorts.Controls.Add(this.button7);
            this.tabPorts.Controls.Add(this.button6);
            this.tabPorts.Controls.Add(this.button3);
            this.tabPorts.Controls.Add(this.button1);
            this.tabPorts.Controls.Add(this.button5);
            this.tabPorts.Location = new System.Drawing.Point(4, 25);
            this.tabPorts.Name = "tabPorts";
            this.tabPorts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorts.Size = new System.Drawing.Size(313, 311);
            this.tabPorts.TabIndex = 2;
            this.tabPorts.Text = "Pines";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(6, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 50);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SteelBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(173, 151);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 50);
            this.button8.TabIndex = 6;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SteelBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(173, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 50);
            this.button7.TabIndex = 5;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SteelBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(173, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 50);
            this.button6.TabIndex = 4;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(6, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(6, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(6, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btnTestTP);
            this.tabPage1.Controls.Add(this.btnTestCC);
            this.tabPage1.Controls.Add(this.btnTestVCAP);
            this.tabPage1.Controls.Add(this.btnTestESFX);
            this.tabPage1.Controls.Add(this.btnTestIMEAS);
            this.tabPage1.Controls.Add(this.btnTestHall1LPF);
            this.tabPage1.Controls.Add(this.btnTestHall2);
            this.tabPage1.Controls.Add(this.btnTestHall1);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.btnTestRAM);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(313, 311);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Pruebas";
            // 
            // btnTestTP
            // 
            this.btnTestTP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTestTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestTP.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTestTP.Location = new System.Drawing.Point(176, 132);
            this.btnTestTP.Name = "btnTestTP";
            this.btnTestTP.Size = new System.Drawing.Size(96, 43);
            this.btnTestTP.TabIndex = 9;
            this.btnTestTP.Text = "Temp";
            this.btnTestTP.UseVisualStyleBackColor = false;
            this.btnTestTP.Click += new System.EventHandler(this.btnTestTP_Click);
            // 
            // btnTestCC
            // 
            this.btnTestCC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTestCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestCC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTestCC.Location = new System.Drawing.Point(176, 74);
            this.btnTestCC.Name = "btnTestCC";
            this.btnTestCC.Size = new System.Drawing.Size(96, 43);
            this.btnTestCC.TabIndex = 8;
            this.btnTestCC.Text = "Carga";
            this.btnTestCC.UseVisualStyleBackColor = false;
            this.btnTestCC.Click += new System.EventHandler(this.btnTestCC_Click);
            // 
            // btnTestVCAP
            // 
            this.btnTestVCAP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTestVCAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestVCAP.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTestVCAP.Location = new System.Drawing.Point(176, 19);
            this.btnTestVCAP.Name = "btnTestVCAP";
            this.btnTestVCAP.Size = new System.Drawing.Size(96, 43);
            this.btnTestVCAP.TabIndex = 7;
            this.btnTestVCAP.Text = "VCAP";
            this.btnTestVCAP.UseVisualStyleBackColor = false;
            this.btnTestVCAP.Click += new System.EventHandler(this.btnTestVCAP_Click);
            // 
            // btnTestESFX
            // 
            this.btnTestESFX.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTestESFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestESFX.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTestESFX.Location = new System.Drawing.Point(30, 240);
            this.btnTestESFX.Name = "btnTestESFX";
            this.btnTestESFX.Size = new System.Drawing.Size(96, 43);
            this.btnTestESFX.TabIndex = 6;
            this.btnTestESFX.Text = "EFSX";
            this.btnTestESFX.UseVisualStyleBackColor = false;
            this.btnTestESFX.Click += new System.EventHandler(this.btnTestESFX_Click);
            // 
            // btnTestIMEAS
            // 
            this.btnTestIMEAS.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTestIMEAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestIMEAS.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTestIMEAS.Location = new System.Drawing.Point(30, 188);
            this.btnTestIMEAS.Name = "btnTestIMEAS";
            this.btnTestIMEAS.Size = new System.Drawing.Size(96, 43);
            this.btnTestIMEAS.TabIndex = 5;
            this.btnTestIMEAS.Text = "IMEAS";
            this.btnTestIMEAS.UseVisualStyleBackColor = false;
            this.btnTestIMEAS.Click += new System.EventHandler(this.btnTestIMEAS_Click);
            // 
            // btnTestHall1LPF
            // 
            this.btnTestHall1LPF.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTestHall1LPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestHall1LPF.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTestHall1LPF.Location = new System.Drawing.Point(30, 132);
            this.btnTestHall1LPF.Name = "btnTestHall1LPF";
            this.btnTestHall1LPF.Size = new System.Drawing.Size(96, 43);
            this.btnTestHall1LPF.TabIndex = 4;
            this.btnTestHall1LPF.Text = "Hall1 LPF";
            this.btnTestHall1LPF.UseVisualStyleBackColor = false;
            this.btnTestHall1LPF.Click += new System.EventHandler(this.btnTestHall1LPF_Click);
            // 
            // btnTestHall2
            // 
            this.btnTestHall2.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTestHall2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestHall2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTestHall2.Location = new System.Drawing.Point(30, 74);
            this.btnTestHall2.Name = "btnTestHall2";
            this.btnTestHall2.Size = new System.Drawing.Size(96, 43);
            this.btnTestHall2.TabIndex = 3;
            this.btnTestHall2.Text = "Hall2";
            this.btnTestHall2.UseVisualStyleBackColor = false;
            this.btnTestHall2.Click += new System.EventHandler(this.btnTestHall2_Click);
            // 
            // btnTestHall1
            // 
            this.btnTestHall1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTestHall1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestHall1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTestHall1.Location = new System.Drawing.Point(30, 19);
            this.btnTestHall1.Name = "btnTestHall1";
            this.btnTestHall1.Size = new System.Drawing.Size(96, 43);
            this.btnTestHall1.TabIndex = 2;
            this.btnTestHall1.Text = "Hall1";
            this.btnTestHall1.UseVisualStyleBackColor = false;
            this.btnTestHall1.Click += new System.EventHandler(this.btnTestHall1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SteelBlue;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(176, 240);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 43);
            this.button9.TabIndex = 1;
            this.button9.Text = "FLASH";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnTestRAM
            // 
            this.btnTestRAM.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTestRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestRAM.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTestRAM.Location = new System.Drawing.Point(176, 188);
            this.btnTestRAM.Name = "btnTestRAM";
            this.btnTestRAM.Size = new System.Drawing.Size(96, 43);
            this.btnTestRAM.TabIndex = 0;
            this.btnTestRAM.Text = " RAM";
            this.btnTestRAM.UseVisualStyleBackColor = false;
            this.btnTestRAM.Click += new System.EventHandler(this.btnTestRAM_Click);
            // 
            // tabRadio
            // 
            this.tabRadio.BackColor = System.Drawing.Color.Gainsboro;
            this.tabRadio.Controls.Add(this.btnStartRadio);
            this.tabRadio.Controls.Add(this.btnExitRadio);
            this.tabRadio.Controls.Add(this.btnCSQ);
            this.tabRadio.Controls.Add(this.btnICCID);
            this.tabRadio.Controls.Add(this.btnGSN);
            this.tabRadio.Location = new System.Drawing.Point(4, 25);
            this.tabRadio.Name = "tabRadio";
            this.tabRadio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRadio.Size = new System.Drawing.Size(313, 311);
            this.tabRadio.TabIndex = 3;
            this.tabRadio.Text = "Radio";
            // 
            // btnStartRadio
            // 
            this.btnStartRadio.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStartRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRadio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartRadio.Location = new System.Drawing.Point(77, 5);
            this.btnStartRadio.Name = "btnStartRadio";
            this.btnStartRadio.Size = new System.Drawing.Size(144, 42);
            this.btnStartRadio.TabIndex = 4;
            this.btnStartRadio.Text = "INICIAR";
            this.btnStartRadio.UseVisualStyleBackColor = false;
            this.btnStartRadio.Click += new System.EventHandler(this.btnStartRadio_Click);
            // 
            // btnExitRadio
            // 
            this.btnExitRadio.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExitRadio.Enabled = false;
            this.btnExitRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitRadio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExitRadio.Location = new System.Drawing.Point(77, 248);
            this.btnExitRadio.Name = "btnExitRadio";
            this.btnExitRadio.Size = new System.Drawing.Size(144, 42);
            this.btnExitRadio.TabIndex = 3;
            this.btnExitRadio.Text = "SALIR";
            this.btnExitRadio.UseVisualStyleBackColor = false;
            this.btnExitRadio.Click += new System.EventHandler(this.btnExitRadio_Click);
            // 
            // btnCSQ
            // 
            this.btnCSQ.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCSQ.Enabled = false;
            this.btnCSQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSQ.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCSQ.Location = new System.Drawing.Point(77, 176);
            this.btnCSQ.Name = "btnCSQ";
            this.btnCSQ.Size = new System.Drawing.Size(144, 42);
            this.btnCSQ.TabIndex = 2;
            this.btnCSQ.Text = "AT+CSQ";
            this.btnCSQ.UseVisualStyleBackColor = false;
            this.btnCSQ.Click += new System.EventHandler(this.btnCSQ_Click);
            // 
            // btnICCID
            // 
            this.btnICCID.BackColor = System.Drawing.Color.SteelBlue;
            this.btnICCID.Enabled = false;
            this.btnICCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnICCID.ForeColor = System.Drawing.SystemColors.Control;
            this.btnICCID.Location = new System.Drawing.Point(77, 128);
            this.btnICCID.Name = "btnICCID";
            this.btnICCID.Size = new System.Drawing.Size(144, 42);
            this.btnICCID.TabIndex = 1;
            this.btnICCID.Text = "AT+ICCID";
            this.btnICCID.UseVisualStyleBackColor = false;
            this.btnICCID.Click += new System.EventHandler(this.btnICCID_Click);
            // 
            // btnGSN
            // 
            this.btnGSN.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGSN.Enabled = false;
            this.btnGSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGSN.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGSN.Location = new System.Drawing.Point(77, 80);
            this.btnGSN.Name = "btnGSN";
            this.btnGSN.Size = new System.Drawing.Size(144, 42);
            this.btnGSN.TabIndex = 0;
            this.btnGSN.Text = "AT+GSN";
            this.btnGSN.UseVisualStyleBackColor = false;
            this.btnGSN.Click += new System.EventHandler(this.btnGSN_Click);
            // 
            // tbRespuesta
            // 
            this.tbRespuesta.BackColor = System.Drawing.Color.White;
            this.tbRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRespuesta.Location = new System.Drawing.Point(12, 428);
            this.tbRespuesta.Multiline = true;
            this.tbRespuesta.Name = "tbRespuesta";
            this.tbRespuesta.ReadOnly = true;
            this.tbRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRespuesta.Size = new System.Drawing.Size(698, 171);
            this.tbRespuesta.TabIndex = 1;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.White;
            this.tbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatus.Location = new System.Drawing.Point(12, 389);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(698, 30);
            this.tbStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "RESPUESTA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(344, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 314);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.74419F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.60465F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.04736F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.10585F));
            this.tableLayoutPanel1.Controls.Add(this.tbHallSel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbEFSG1_5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbEFSG4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbRatioSel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbLoZinEarth, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbLoZinSky, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbLED, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbLowerBurden, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbEFSG1_5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbEFSG4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPuerto, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(344, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.95588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.32353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.22059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.11765F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.38235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 272);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tbHallSel
            // 
            this.tbHallSel.BackColor = System.Drawing.Color.White;
            this.tbHallSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHallSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbHallSel.Location = new System.Drawing.Point(98, 240);
            this.tbHallSel.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.tbHallSel.Name = "tbHallSel";
            this.tbHallSel.ReadOnly = true;
            this.tbHallSel.Size = new System.Drawing.Size(60, 21);
            this.tbHallSel.TabIndex = 27;
            this.tbHallSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 51);
            this.label9.TabIndex = 26;
            this.label9.Text = "HALL_SEL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEFSG1_5
            // 
            this.tbEFSG1_5.BackColor = System.Drawing.Color.White;
            this.tbEFSG1_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEFSG1_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbEFSG1_5.Location = new System.Drawing.Point(296, 240);
            this.tbEFSG1_5.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.tbEFSG1_5.Name = "tbEFSG1_5";
            this.tbEFSG1_5.ReadOnly = true;
            this.tbEFSG1_5.Size = new System.Drawing.Size(60, 21);
            this.tbEFSG1_5.TabIndex = 25;
            this.tbEFSG1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEFSG4
            // 
            this.tbEFSG4.BackColor = System.Drawing.Color.White;
            this.tbEFSG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEFSG4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbEFSG4.Location = new System.Drawing.Point(296, 188);
            this.tbEFSG4.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.tbEFSG4.Name = "tbEFSG4";
            this.tbEFSG4.ReadOnly = true;
            this.tbEFSG4.Size = new System.Drawing.Size(60, 21);
            this.tbEFSG4.TabIndex = 24;
            this.tbEFSG4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRatioSel
            // 
            this.tbRatioSel.BackColor = System.Drawing.Color.White;
            this.tbRatioSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRatioSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbRatioSel.Location = new System.Drawing.Point(98, 188);
            this.tbRatioSel.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.tbRatioSel.Name = "tbRatioSel";
            this.tbRatioSel.ReadOnly = true;
            this.tbRatioSel.Size = new System.Drawing.Size(60, 21);
            this.tbRatioSel.TabIndex = 23;
            this.tbRatioSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLoZinEarth
            // 
            this.tbLoZinEarth.BackColor = System.Drawing.Color.White;
            this.tbLoZinEarth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLoZinEarth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbLoZinEarth.Location = new System.Drawing.Point(296, 133);
            this.tbLoZinEarth.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.tbLoZinEarth.Name = "tbLoZinEarth";
            this.tbLoZinEarth.ReadOnly = true;
            this.tbLoZinEarth.Size = new System.Drawing.Size(60, 21);
            this.tbLoZinEarth.TabIndex = 22;
            this.tbLoZinEarth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAP
            // 
            this.tbAP.BackColor = System.Drawing.Color.White;
            this.tbAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbAP.Location = new System.Drawing.Point(98, 133);
            this.tbAP.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.tbAP.Name = "tbAP";
            this.tbAP.ReadOnly = true;
            this.tbAP.Size = new System.Drawing.Size(60, 21);
            this.tbAP.TabIndex = 21;
            this.tbAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLoZinSky
            // 
            this.tbLoZinSky.BackColor = System.Drawing.Color.White;
            this.tbLoZinSky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLoZinSky.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbLoZinSky.Location = new System.Drawing.Point(296, 75);
            this.tbLoZinSky.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.tbLoZinSky.Name = "tbLoZinSky";
            this.tbLoZinSky.ReadOnly = true;
            this.tbLoZinSky.Size = new System.Drawing.Size(60, 21);
            this.tbLoZinSky.TabIndex = 20;
            this.tbLoZinSky.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLED
            // 
            this.tbLED.BackColor = System.Drawing.Color.White;
            this.tbLED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbLED.Location = new System.Drawing.Point(98, 75);
            this.tbLED.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.tbLED.Name = "tbLED";
            this.tbLED.ReadOnly = true;
            this.tbLED.Size = new System.Drawing.Size(60, 21);
            this.tbLED.TabIndex = 19;
            this.tbLED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLowerBurden
            // 
            this.tbLowerBurden.BackColor = System.Drawing.Color.White;
            this.tbLowerBurden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLowerBurden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbLowerBurden.Location = new System.Drawing.Point(296, 19);
            this.tbLowerBurden.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.tbLowerBurden.Name = "tbLowerBurden";
            this.tbLowerBurden.ReadOnly = true;
            this.tbLowerBurden.Size = new System.Drawing.Size(60, 21);
            this.tbLowerBurden.TabIndex = 18;
            this.tbLowerBurden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbEFSG1_5
            // 
            this.lbEFSG1_5.AutoSize = true;
            this.lbEFSG1_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEFSG1_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbEFSG1_5.Location = new System.Drawing.Point(164, 221);
            this.lbEFSG1_5.Name = "lbEFSG1_5";
            this.lbEFSG1_5.Size = new System.Drawing.Size(126, 51);
            this.lbEFSG1_5.TabIndex = 16;
            this.lbEFSG1_5.Text = "EFS_G1/2";
            this.lbEFSG1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEFSG4
            // 
            this.lbEFSG4.AutoSize = true;
            this.lbEFSG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEFSG4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbEFSG4.Location = new System.Drawing.Point(164, 169);
            this.lbEFSG4.Name = "lbEFSG4";
            this.lbEFSG4.Size = new System.Drawing.Size(126, 52);
            this.lbEFSG4.TabIndex = 14;
            this.lbEFSG4.Text = "EFS_G4 ";
            this.lbEFSG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(3, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 52);
            this.label16.TabIndex = 12;
            this.label16.Text = "RATIO_SEL";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(164, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 55);
            this.label14.TabIndex = 10;
            this.label14.Text = "LO_ZIN_EARTH";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(3, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 55);
            this.label12.TabIndex = 8;
            this.label12.Text = "AP";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(164, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 58);
            this.label10.TabIndex = 6;
            this.label10.Text = "LO_ZIN_SKY";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 58);
            this.label8.TabIndex = 4;
            this.label8.Text = "LED";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(164, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 56);
            this.label6.TabIndex = 2;
            this.label6.Text = "LOWER_BURDEN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 56);
            this.label4.TabIndex = 0;
            this.label4.Text = "Puerto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPuerto
            // 
            this.tbPuerto.BackColor = System.Drawing.Color.White;
            this.tbPuerto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbPuerto.Location = new System.Drawing.Point(98, 19);
            this.tbPuerto.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
            this.tbPuerto.Name = "tbPuerto";
            this.tbPuerto.ReadOnly = true;
            this.tbPuerto.Size = new System.Drawing.Size(60, 21);
            this.tbPuerto.TabIndex = 17;
            this.tbPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(716, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 575);
            this.panel2.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.18919F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.81081F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Controls.Add(this.pfCSQ, 2, 12);
            this.tableLayoutPanel2.Controls.Add(this.pfICCID, 2, 11);
            this.tableLayoutPanel2.Controls.Add(this.pfIMEI, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.pfFLASH, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.pfRAM, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.pfTP, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.pfCapCharge, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.pfVCAP, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.pfESFX, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.pfIMEAS, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.pfHall1LPF, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.pfHall2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbCSQ, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.tbICCID, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.tbIMEI, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.tbFLASH, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.tbRAM, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.tbTP, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.tbCapCharge, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.tbVCAP, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbESFX, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbIMEAS, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbHall1LPF, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbHall2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label38, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.label36, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.label34, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label32, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label30, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label28, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label26, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label24, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbHall1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pfHall1, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.014572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.285975F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(241, 549);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pfCSQ
            // 
            this.pfCSQ.AutoSize = true;
            this.pfCSQ.BackColor = System.Drawing.Color.White;
            this.pfCSQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfCSQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfCSQ.Location = new System.Drawing.Point(225, 504);
            this.pfCSQ.Name = "pfCSQ";
            this.pfCSQ.Size = new System.Drawing.Size(13, 45);
            this.pfCSQ.TabIndex = 50;
            // 
            // pfICCID
            // 
            this.pfICCID.AutoSize = true;
            this.pfICCID.BackColor = System.Drawing.Color.White;
            this.pfICCID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfICCID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfICCID.Location = new System.Drawing.Point(225, 462);
            this.pfICCID.Name = "pfICCID";
            this.pfICCID.Size = new System.Drawing.Size(13, 42);
            this.pfICCID.TabIndex = 49;
            // 
            // pfIMEI
            // 
            this.pfIMEI.AutoSize = true;
            this.pfIMEI.BackColor = System.Drawing.Color.White;
            this.pfIMEI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfIMEI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfIMEI.Location = new System.Drawing.Point(225, 420);
            this.pfIMEI.Name = "pfIMEI";
            this.pfIMEI.Size = new System.Drawing.Size(13, 42);
            this.pfIMEI.TabIndex = 48;
            // 
            // pfFLASH
            // 
            this.pfFLASH.AutoSize = true;
            this.pfFLASH.BackColor = System.Drawing.Color.White;
            this.pfFLASH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfFLASH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfFLASH.Location = new System.Drawing.Point(225, 378);
            this.pfFLASH.Name = "pfFLASH";
            this.pfFLASH.Size = new System.Drawing.Size(13, 42);
            this.pfFLASH.TabIndex = 47;
            // 
            // pfRAM
            // 
            this.pfRAM.AutoSize = true;
            this.pfRAM.BackColor = System.Drawing.Color.White;
            this.pfRAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfRAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfRAM.Location = new System.Drawing.Point(225, 336);
            this.pfRAM.Name = "pfRAM";
            this.pfRAM.Size = new System.Drawing.Size(13, 42);
            this.pfRAM.TabIndex = 46;
            // 
            // pfTP
            // 
            this.pfTP.AutoSize = true;
            this.pfTP.BackColor = System.Drawing.Color.White;
            this.pfTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfTP.Location = new System.Drawing.Point(225, 296);
            this.pfTP.Name = "pfTP";
            this.pfTP.Size = new System.Drawing.Size(13, 40);
            this.pfTP.TabIndex = 45;
            // 
            // pfCapCharge
            // 
            this.pfCapCharge.AutoSize = true;
            this.pfCapCharge.BackColor = System.Drawing.Color.White;
            this.pfCapCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfCapCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfCapCharge.Location = new System.Drawing.Point(225, 252);
            this.pfCapCharge.Name = "pfCapCharge";
            this.pfCapCharge.Size = new System.Drawing.Size(13, 44);
            this.pfCapCharge.TabIndex = 44;
            // 
            // pfVCAP
            // 
            this.pfVCAP.AutoSize = true;
            this.pfVCAP.BackColor = System.Drawing.Color.White;
            this.pfVCAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfVCAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfVCAP.Location = new System.Drawing.Point(225, 210);
            this.pfVCAP.Name = "pfVCAP";
            this.pfVCAP.Size = new System.Drawing.Size(13, 42);
            this.pfVCAP.TabIndex = 43;
            // 
            // pfESFX
            // 
            this.pfESFX.AutoSize = true;
            this.pfESFX.BackColor = System.Drawing.Color.White;
            this.pfESFX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfESFX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfESFX.Location = new System.Drawing.Point(225, 168);
            this.pfESFX.Name = "pfESFX";
            this.pfESFX.Size = new System.Drawing.Size(13, 42);
            this.pfESFX.TabIndex = 42;
            // 
            // pfIMEAS
            // 
            this.pfIMEAS.AutoSize = true;
            this.pfIMEAS.BackColor = System.Drawing.Color.White;
            this.pfIMEAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfIMEAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfIMEAS.Location = new System.Drawing.Point(225, 126);
            this.pfIMEAS.Name = "pfIMEAS";
            this.pfIMEAS.Size = new System.Drawing.Size(13, 42);
            this.pfIMEAS.TabIndex = 41;
            // 
            // pfHall1LPF
            // 
            this.pfHall1LPF.AutoSize = true;
            this.pfHall1LPF.BackColor = System.Drawing.Color.White;
            this.pfHall1LPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfHall1LPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfHall1LPF.Location = new System.Drawing.Point(225, 84);
            this.pfHall1LPF.Name = "pfHall1LPF";
            this.pfHall1LPF.Size = new System.Drawing.Size(13, 42);
            this.pfHall1LPF.TabIndex = 40;
            // 
            // pfHall2
            // 
            this.pfHall2.AutoSize = true;
            this.pfHall2.BackColor = System.Drawing.Color.White;
            this.pfHall2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfHall2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfHall2.Location = new System.Drawing.Point(225, 42);
            this.pfHall2.Name = "pfHall2";
            this.pfHall2.Size = new System.Drawing.Size(13, 42);
            this.pfHall2.TabIndex = 39;
            // 
            // tbCSQ
            // 
            this.tbCSQ.BackColor = System.Drawing.Color.White;
            this.tbCSQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCSQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCSQ.Location = new System.Drawing.Point(90, 517);
            this.tbCSQ.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbCSQ.Name = "tbCSQ";
            this.tbCSQ.ReadOnly = true;
            this.tbCSQ.Size = new System.Drawing.Size(129, 21);
            this.tbCSQ.TabIndex = 37;
            this.tbCSQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbICCID
            // 
            this.tbICCID.BackColor = System.Drawing.Color.White;
            this.tbICCID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbICCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbICCID.Location = new System.Drawing.Point(90, 475);
            this.tbICCID.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbICCID.Name = "tbICCID";
            this.tbICCID.ReadOnly = true;
            this.tbICCID.Size = new System.Drawing.Size(129, 21);
            this.tbICCID.TabIndex = 36;
            this.tbICCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIMEI
            // 
            this.tbIMEI.BackColor = System.Drawing.Color.White;
            this.tbIMEI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIMEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbIMEI.Location = new System.Drawing.Point(90, 433);
            this.tbIMEI.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbIMEI.Name = "tbIMEI";
            this.tbIMEI.ReadOnly = true;
            this.tbIMEI.Size = new System.Drawing.Size(129, 21);
            this.tbIMEI.TabIndex = 35;
            this.tbIMEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFLASH
            // 
            this.tbFLASH.BackColor = System.Drawing.Color.White;
            this.tbFLASH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFLASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbFLASH.Location = new System.Drawing.Point(90, 391);
            this.tbFLASH.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbFLASH.Name = "tbFLASH";
            this.tbFLASH.ReadOnly = true;
            this.tbFLASH.Size = new System.Drawing.Size(129, 21);
            this.tbFLASH.TabIndex = 34;
            this.tbFLASH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRAM
            // 
            this.tbRAM.BackColor = System.Drawing.Color.White;
            this.tbRAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbRAM.Location = new System.Drawing.Point(90, 349);
            this.tbRAM.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.ReadOnly = true;
            this.tbRAM.Size = new System.Drawing.Size(129, 21);
            this.tbRAM.TabIndex = 33;
            this.tbRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTP
            // 
            this.tbTP.BackColor = System.Drawing.Color.White;
            this.tbTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbTP.Location = new System.Drawing.Point(90, 309);
            this.tbTP.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbTP.Name = "tbTP";
            this.tbTP.ReadOnly = true;
            this.tbTP.Size = new System.Drawing.Size(129, 21);
            this.tbTP.TabIndex = 32;
            this.tbTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCapCharge
            // 
            this.tbCapCharge.BackColor = System.Drawing.Color.White;
            this.tbCapCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCapCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCapCharge.Location = new System.Drawing.Point(90, 265);
            this.tbCapCharge.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbCapCharge.Name = "tbCapCharge";
            this.tbCapCharge.ReadOnly = true;
            this.tbCapCharge.Size = new System.Drawing.Size(129, 21);
            this.tbCapCharge.TabIndex = 31;
            this.tbCapCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbVCAP
            // 
            this.tbVCAP.BackColor = System.Drawing.Color.White;
            this.tbVCAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVCAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbVCAP.Location = new System.Drawing.Point(90, 223);
            this.tbVCAP.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbVCAP.Name = "tbVCAP";
            this.tbVCAP.ReadOnly = true;
            this.tbVCAP.Size = new System.Drawing.Size(129, 21);
            this.tbVCAP.TabIndex = 30;
            this.tbVCAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbESFX
            // 
            this.tbESFX.BackColor = System.Drawing.Color.White;
            this.tbESFX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbESFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbESFX.Location = new System.Drawing.Point(90, 181);
            this.tbESFX.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbESFX.Name = "tbESFX";
            this.tbESFX.ReadOnly = true;
            this.tbESFX.Size = new System.Drawing.Size(129, 21);
            this.tbESFX.TabIndex = 29;
            this.tbESFX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIMEAS
            // 
            this.tbIMEAS.BackColor = System.Drawing.Color.White;
            this.tbIMEAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIMEAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbIMEAS.Location = new System.Drawing.Point(90, 139);
            this.tbIMEAS.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbIMEAS.Name = "tbIMEAS";
            this.tbIMEAS.ReadOnly = true;
            this.tbIMEAS.Size = new System.Drawing.Size(129, 21);
            this.tbIMEAS.TabIndex = 28;
            this.tbIMEAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHall1LPF
            // 
            this.tbHall1LPF.BackColor = System.Drawing.Color.White;
            this.tbHall1LPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHall1LPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbHall1LPF.Location = new System.Drawing.Point(90, 97);
            this.tbHall1LPF.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbHall1LPF.Name = "tbHall1LPF";
            this.tbHall1LPF.ReadOnly = true;
            this.tbHall1LPF.Size = new System.Drawing.Size(129, 21);
            this.tbHall1LPF.TabIndex = 27;
            this.tbHall1LPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHall2
            // 
            this.tbHall2.BackColor = System.Drawing.Color.White;
            this.tbHall2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHall2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbHall2.Location = new System.Drawing.Point(90, 55);
            this.tbHall2.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbHall2.Name = "tbHall2";
            this.tbHall2.ReadOnly = true;
            this.tbHall2.Size = new System.Drawing.Size(129, 21);
            this.tbHall2.TabIndex = 26;
            this.tbHall2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(3, 504);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(81, 45);
            this.label38.TabIndex = 24;
            this.label38.Text = "CSQ";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(3, 462);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(81, 42);
            this.label36.TabIndex = 22;
            this.label36.Text = "ICCID";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(3, 420);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(81, 42);
            this.label34.TabIndex = 20;
            this.label34.Text = "IMEI";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.LightGray;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 378);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(81, 42);
            this.label32.TabIndex = 18;
            this.label32.Text = "FLASH";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.LightGray;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(3, 336);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(81, 42);
            this.label30.TabIndex = 16;
            this.label30.Text = "RAM";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(3, 296);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 40);
            this.label28.TabIndex = 14;
            this.label28.Text = "TP";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 252);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 44);
            this.label26.TabIndex = 12;
            this.label26.Text = "CapCharge";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 210);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 42);
            this.label24.TabIndex = 10;
            this.label24.Text = "VCAP";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 168);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 42);
            this.label22.TabIndex = 8;
            this.label22.Text = "EFSX";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 42);
            this.label19.TabIndex = 6;
            this.label19.Text = "IMEAS";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 42);
            this.label15.TabIndex = 4;
            this.label15.Text = "Hall1 LPF";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 42);
            this.label11.TabIndex = 2;
            this.label11.Text = "Hall2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 42);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hall1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHall1
            // 
            this.tbHall1.BackColor = System.Drawing.Color.White;
            this.tbHall1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHall1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbHall1.Location = new System.Drawing.Point(90, 13);
            this.tbHall1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tbHall1.Name = "tbHall1";
            this.tbHall1.ReadOnly = true;
            this.tbHall1.Size = new System.Drawing.Size(129, 21);
            this.tbHall1.TabIndex = 25;
            this.tbHall1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pfHall1
            // 
            this.pfHall1.AutoSize = true;
            this.pfHall1.BackColor = System.Drawing.Color.White;
            this.pfHall1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfHall1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfHall1.Location = new System.Drawing.Point(225, 0);
            this.pfHall1.Name = "pfHall1";
            this.pfHall1.Size = new System.Drawing.Size(13, 42);
            this.pfHall1.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Measurements";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbRespuesta);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AGM GUI Tester ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabComandos.ResumeLayout(false);
            this.tabPorts.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabRadio.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabComandos;
        private System.Windows.Forms.TextBox tbRespuesta;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TabPage tabPorts;
        private System.Windows.Forms.TabPage tabRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLedOn;
        private System.Windows.Forms.Button btnLedOff;
        private System.Windows.Forms.Button btnAP;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnExitRadio;
        private System.Windows.Forms.Button btnCSQ;
        private System.Windows.Forms.Button btnICCID;
        private System.Windows.Forms.Button btnGSN;
        private System.Windows.Forms.Button btnStartRadio;
        private Button btnRefresh;
        private Panel panel1;
        private Label label3;
        private TabPage tabPage1;
        private Panel panel2;
        private Label label5;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button3;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbHallSel;
        private Label label9;
        private TextBox tbEFSG1_5;
        private TextBox tbEFSG4;
        private TextBox tbRatioSel;
        private TextBox tbLoZinEarth;
        private TextBox tbAP;
        private TextBox tbLoZinSky;
        private TextBox tbLED;
        private TextBox tbLowerBurden;
        private Label lbEFSG1_5;
        private Label lbEFSG4;
        private Label label16;
        private Label label14;
        private Label label12;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label4;
        private TextBox tbPuerto;
        private Button button4;
        private Timer timer1;
        private Button btnTestTP;
        private Button btnTestCC;
        private Button btnTestVCAP;
        private Button btnTestESFX;
        private Button btnTestIMEAS;
        private Button btnTestHall1LPF;
        private Button btnTestHall2;
        private Button btnTestHall1;
        private Button button9;
        private Button btnTestRAM;
        private TableLayoutPanel tableLayoutPanel2;
        private Label pfCSQ;
        private Label pfICCID;
        private Label pfIMEI;
        private Label pfFLASH;
        private Label pfRAM;
        private Label pfTP;
        private Label pfCapCharge;
        private Label pfVCAP;
        private Label pfESFX;
        private Label pfIMEAS;
        private Label pfHall1LPF;
        private Label pfHall2;
        private TextBox tbCSQ;
        private TextBox tbICCID;
        private TextBox tbIMEI;
        private TextBox tbFLASH;
        private TextBox tbRAM;
        private TextBox tbTP;
        private TextBox tbCapCharge;
        private TextBox tbVCAP;
        private TextBox tbESFX;
        private TextBox tbIMEAS;
        private TextBox tbHall1LPF;
        private TextBox tbHall2;
        private Label label38;
        private Label label36;
        private Label label34;
        private Label label32;
        private Label label30;
        private Label label28;
        private Label label26;
        private Label label24;
        private Label label22;
        private Label label19;
        private Label label15;
        private Label label11;
        private Label label7;
        private TextBox tbHall1;
        private Label pfHall1;
    }
}


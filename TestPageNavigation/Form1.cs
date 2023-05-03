using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;



namespace TestPageNavigation
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        string[] puertos;
        string mcResponse;
        float mcValue;
        bool connectedBoard = false;
        bool modoRadio = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            puertos = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(puertos);
            tbRespuesta.Text = "Antes de presionar reboot asegúrate de que:\r\n\r\n" +
                "■ La fuente esté encendida y configurada a 5V+\r\n" +
                "■ La unidad esté programada con firmware de debug\r\n" +
                "■ El puerto seleccionado sea el correcto";

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connectedBoard == false)
            {
                tabControl1.SelectTab(0);
            }
            else if(modoRadio == true)
            {
                tabControl1.SelectTab(4);
            }

        }
        private void resetForm()
        {

            timer1.Stop();



            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

            


            pfHall1.BackColor = System.Drawing.Color.White;
            pfHall2.BackColor = System.Drawing.Color.White;
            pfHall1LPF.BackColor = System.Drawing.Color.White;
            pfIMEAS.BackColor = System.Drawing.Color.White;
            pfESFX.BackColor = System.Drawing.Color.White;
            pfVCAP.BackColor = System.Drawing.Color.White;
            pfCapCharge.BackColor = System.Drawing.Color.White;
            pfTP.BackColor = System.Drawing.Color.White;
            pfRAM.BackColor = System.Drawing.Color.White;
            pfFLASH.BackColor = System.Drawing.Color.White;
            pfIMEI.BackColor = System.Drawing.Color.White;
            pfICCID.BackColor = System.Drawing.Color.White;
            pfCSQ.BackColor = System.Drawing.Color.White;
            
            tabControl1.SelectTab(0);
            comboBox1.Text = "";

            showMessageOnResponseBox("");
            showMessageOnStatusBox("");

            modoRadio = false;
            connectedBoard = false;
            btnReboot.Enabled = false;
            getPorts();
            


            


        }
        private void getPorts()
        {
            comboBox1.Items.Clear();
            puertos = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(puertos);
        }

        private string sendCommand(string comando, int timeout, bool waitEcho = true, string expected = "mvm>", string customMessage = "Esperando respuesta...")
        {
            string respuesta;
            serialPort.ReadTimeout = timeout;

            timer1.Stop();

            showMessageOnResponseBox("");
            showMessageOnStatusBox(customMessage);

            try
            {
                for (int i = 0; i < comando.Length; i++)
                {
                    serialPort.Write(comando[i].ToString());
                    if (waitEcho) serialPort.ReadTo(comando[i].ToString());

                }

                respuesta = serialPort.ReadTo(expected);


                respuesta = respuesta.Replace("\n", "").Trim();


            }
            catch (TimeoutException)
            {
                if (connectedBoard == false || modoRadio == true)

                {
                    throw new TimeoutException();
                }
                else
                {
                    respuesta = " =:ERROR ";
                }
            }


            showMessageOnStatusBox("");
            timer1.Start();
            return respuesta;
        }

        private string sendCommandOnRadioMode(string comandoRadio, int timeoutRadio)
        {
            string respuestaRadio;
            serialPort.ReadTimeout = timeoutRadio;

            showMessageOnResponseBox("");

            showMessageOnStatusBox("Esperando respuesta del módulo...");

            
            try
            {
                for (int i = 0; i < comandoRadio.Length; i++)
                {
                    serialPort.Write(comandoRadio[i].ToString());
                    serialPort.ReadTo(comandoRadio[i].ToString());
                }

                serialPort.Write("\r");
                respuestaRadio = serialPort.ReadTo("OK");
                
            }
            catch(TimeoutException)
            {
                respuestaRadio = serialPort.ReadExisting().Replace("\n", "").Trim();
            }

            showMessageOnStatusBox("");
            return respuestaRadio;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string puerto = comboBox1.Text;

            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }

            serialPort.PortName = puerto;
            tbPuerto.Text = puerto;
            serialPort.Open();
            btnReboot.Enabled = true;


        }

        private void swapAP()
        {
            mcResponse = sendCommand("AP\n", 3000);
            showMessageOnResponseBox(mcResponse);
            tbAP.Text = mcResponse.Split('=')[1].Trim();
        }
        
      
        private bool isMeasureOK(int min, int max, float value)
        {
            if (value > min && value < max)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private float getNumFromString(string strNum)
        {
            float num;
            try
            {
                float.TryParse(strNum, out num);
                return num;
            }
            catch
            {
                num = -1;
                return num;
            }
        }

        private bool isStringANumber(string str)
        {
            bool isNumeric = float.TryParse(str, out _);
            return isNumeric;
        }

        private string convertToTrueOrFalse(string valor)
        {
            if (valor == "1")
            {
                return "TRUE";
            }
            else
            {
                return "FALSE";
            }

        }

        private void showMessageOnStatusBox(string statusMessage)
        {
            tbStatus.Text = statusMessage;
        }

        private void showMessageOnResponseBox(string responseMessage, bool append = false)
        {
            if (append)
            {
                tbRespuesta.Text += "\r\n" + responseMessage;
            }
            else
            {
                tbRespuesta.Text = responseMessage;
            }

        }
        private void btnReboot_Click(object sender, EventArgs e)
        {
            try
            {
                sendCommand("\n", 2000);
                sendCommand("boot\n", 5000, expected: "(y/n)>", customMessage: "Enviando comando para booteo...");
                sendCommand("y", 5000, waitEcho: false, customMessage: "Esperando a que la unidad inicie...");
                //showMessageOnResponseBox(uResponse);
                if (connectedBoard == true)
                {
                    string tempPuerto;

                    int tempComboBoxIndex;

                    tempComboBoxIndex = comboBox1.SelectedIndex;
                    tempPuerto = tbPuerto.Text;

                    resetForm();
                    tbPuerto.Text = tempPuerto;
                    comboBox1.SelectedIndex = tempComboBoxIndex;
                    btnReboot.Enabled = true;
                }


                connectedBoard = true;

                //Valores por defaul al iniciar la unidad
                tbLED.Text = "ON";
                tbAP.Text = "FALSE";
                tbRatioSel.Text = "FALSE";
                tbHallSel.Text = "TRUE";
                tbLowerBurden.Text = "FALSE";
                tbLoZinSky.Text = "FALSE";
                tbLoZinEarth.Text = "FALSE";
                tbEFSG4.Text = "FALSE";
                tbEFSG1_5.Text = "FALSE";


                showMessageOnResponseBox(
                    "Unidad iniciada con éxito\r\n\r\n" +
                    "Ya puedes enviar comandos, hacer pruebas o comunicarte con el módulo celular");


                timer1.Start();
            }
            catch(TimeoutException)
            {
                resetForm();
                MessageBox.Show(
                    "Ocurrió un error.\r\n" +
                    "No se recibió respuesta.");
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getPorts();
        }

        private void btnLedOff_Click(object sender, EventArgs e)
        {
            mcResponse = sendCommand("flash off\n", 3000);
            showMessageOnResponseBox(mcResponse);
            tbLED.Text = "OFF";
            
        }

        private void btnLedOn_Click(object sender, EventArgs e)
        {
            mcResponse = sendCommand("flash on\n", 3000);
            showMessageOnResponseBox(mcResponse);
            tbLED.Text = "ON";
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            swapAP();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            serialPort.WriteTimeout = 500;
            serialPort.ReadTimeout = 500;
            try
            {
                serialPort.Write("\n");
                serialPort.ReadTo("mvm>");
                timer1.Start();
            }
            catch
            {
                try
                {
                    serialPort.Close();
                }
                finally
                {
                    MessageBox.Show("Se perdió comunicación con la unidad");
                    resetForm();
                }
                

            }

        }

        private void exitRadio(bool errorRadio = false)
        {
            //string bufferExit; 

            modoRadio = false;
            btnGSN.Enabled = false;
            btnICCID.Enabled = false;
            btnCSQ.Enabled = false;
            btnExitRadio.Enabled = false;
            btnStartRadio.Enabled = true;

            checkIfRadioRestartedTimer.Stop();

            showMessageOnResponseBox("");
            showMessageOnStatusBox("");

            if (connectedBoard == false) 
            {
                try
                {


                    serialPort.DiscardInBuffer();
                    serialPort.ReadTimeout = 3000;
                    serialPort.Write("\u001A");


                    //bufferExit = 
                    serialPort.ReadTo("mvm>");

                    //MessageBox.Show(bufferExit);
                    if (errorRadio == true)
                    {
                        showMessageOnResponseBox(
                        "Comunicación con módulo abortada por error de comunicación con el módulo.\r\n" +
                        "Ya puedes volver a utilizar comandos normales.");
                    }
                    else
                    {
                        showMessageOnResponseBox(
                        "Te desconectaste del módulo con éxito\r\n" +
                        "Ya puedes volver a utilizar comandos normales.");
                    }

                    timer1.Start();
                }
                catch (TimeoutException)
                {
                    try
                    {
                        serialPort.Close();
                    }
                    finally
                    {
                        resetForm();
                        if (errorRadio == true)
                        {
                            showMessageOnResponseBox(
                            "Se trató de cerrar la comunicación con el módulo debido a un error pero ocurrió otro error. Por favor, haz reboot a la unidad.\r\n" +
                            "Si el error persiste al hacer reboot, apaga y enciende la fuente de poder.");
                        }
                        else
                        {
                            showMessageOnResponseBox(
                            "Ocurrió un error al tratar de cerrar la comunicación con el módulo. Por favor, haz reboot a la unidad.\r\n" +
                            "Si el error persiste al hacer reboot, apaga y enciende la fuente de poder.");
                        }

                    }

                }
            }
            

 
            
        }

        

        private void btnStartRadio_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                modoRadio = true;
                sendCommand("S F.54 1\n", 3000);
                sendCommand("S F.54 0\n", 3000);
                sendCommand("LINK RADIO 115200\n", 8000, expected: "link...", customMessage: "Iniciando comunicación...");
                timer1.Stop();
                checkIfRadioRestartedTimer.Start();
                btnGSN.Enabled = true;
                btnICCID.Enabled = true;
                btnCSQ.Enabled = true;
                btnExitRadio.Enabled = true;
                btnStartRadio.Enabled = false;


                showMessageOnResponseBox(
                    "Te has conectado con el módulo\r\n\r\n" +
                    "En este modo no puedes usar otros comandos que no estén en Radio\r\n" +
                    "Podras usar otros comandos cuando te desconectes del módulo\r\n" +
                    "Para desconectarte haz click en 'Salir'");
                //tbAP.Text = uResponse.Split('=')[1].Trim();
            }
            catch
            {

                exitRadio(errorRadio: true);
            }


        }

        private void btnGSN_Click(object sender, EventArgs e)
        {
            mcResponse = sendCommandOnRadioMode("AT+GSN", 6000);
            if (isStringANumber(mcResponse))
            {
                showMessageOnResponseBox($"IMEI: {mcResponse}");
                tbIMEI.Text = mcResponse;
                pfIMEI.BackColor = System.Drawing.Color.Green;
            }
            else if(mcResponse == "ERROR")
            {
                showMessageOnResponseBox($"IMEI: {mcResponse}");
                tbIMEI.Text = mcResponse;
                pfIMEI.BackColor = System.Drawing.Color.Red;
            }
            else if(mcResponse.Contains("MV Monitor"))
            {
                connectedBoard = false;
                exitRadio();
                resetForm();
                showMessageOnResponseBox("Ocurrió un error de comunicación con el módulo");
              
       
            }
            else
            {
                exitRadio(errorRadio: true);
            }

   

            
            //showMessageOnResponseBox(uResponse);
        }

        private void btnICCID_Click(object sender, EventArgs e)
        {
            mcResponse = sendCommandOnRadioMode("AT+ICCID", 6000);
            mcResponse = mcResponse.Replace("+CCID: ", "");
            
            if (isStringANumber(mcResponse))
            {
                showMessageOnResponseBox($"ICCID: {mcResponse}");
                tbICCID.Text = mcResponse;
                pfICCID.BackColor = System.Drawing.Color.Green;
            }
            else if (mcResponse == "ERROR")
            {
                showMessageOnResponseBox($"ICCID: {mcResponse}");
                tbICCID.Text = mcResponse;
                pfICCID.BackColor = System.Drawing.Color.Red;
            }
            else if (mcResponse.Contains("MV Monitor"))
            {
                connectedBoard = false;
                exitRadio();
                resetForm();
                showMessageOnResponseBox("Ocurrió un error de comunicación con el módulo");


            }
            else
            {
                exitRadio(errorRadio: true);
            }


            //showMessageOnResponseBox(uResponse);
        }

        private void btnCSQ_Click(object sender, EventArgs e)
        {
            mcResponse = sendCommandOnRadioMode("AT+CSQ", 6000);
            mcResponse = mcResponse.Replace("+CSQ: ", "");
            
            if (isStringANumber(mcResponse))
            {
                showMessageOnResponseBox($"CSQ: {mcResponse}");
                tbCSQ.Text = mcResponse;
                pfCSQ.BackColor = System.Drawing.Color.Green;
            }
            else if (mcResponse == "ERROR")
            {
                showMessageOnResponseBox($"CSQ: {mcResponse}");
                tbCSQ.Text = mcResponse;
                pfCSQ.BackColor = System.Drawing.Color.Red;
            }
            else if (mcResponse.Contains("MV Monitor"))
            {
                connectedBoard = false;
                exitRadio();
                resetForm();
                showMessageOnResponseBox("Ocurrió un error de comunicación con el módulo");

                                                                                                                                                                                                                                                                                                                                                                                                                         
            }
            else
            {
                exitRadio(errorRadio: true);
            }


            //btnExitRadio.PerformClick();
            //showMessageOnResponseBox(uResponse);
        }

        private void btnExitRadio_Click(object sender, EventArgs e)
        {
            
            exitRadio();
        }

        private void btnTestRAM_Click(object sender, EventArgs e)
        {
            DialogResult respuestaAlertaRam;
            respuestaAlertaRam = MessageBox.Show(
                "Si ya realizaste la prueba de RAM o FLASH a esta unidad es probable que al intentar hacerla de nuevo se reinicie\r\n" +
                "En caso de que se reinicie, normalmente bastará con intentar de nuevo\r\n" +
                "Si el error persiste podría haber un problema con la unidad\r\n\r\n" +
                "¿Deseas realizar la prueba?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuestaAlertaRam == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    mcResponse = sendCommand("mt ram\n", 20000, customMessage: "Realizando prueba de RAM, esto puede demorar un poco...");
                    showMessageOnResponseBox(mcResponse);
                    mcResponse = mcResponse.Split('=')[1].Trim();
                    if (mcResponse == "SUCCESS!")
                    {
                        pfRAM.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        pfRAM.BackColor = System.Drawing.Color.Red;
                    }
                    tbRAM.Text = mcResponse;
                }
                catch
                {
                    resetForm();
                    showMessageOnResponseBox(
                        "Parece que ocurrió un problema\r\n" +
                        "Si la unidad no inicia al tratar de bootear apaga y enciende la fuente e inténtalo de nuevo");
                }
            }

            
        }

        private void btnTestHall1_Click(object sender, EventArgs e)
        {

            

            if (tbAP.Text == "FALSE")
            {
                swapAP();
            }

            if (tbHallSel.Text == "TRUE")
            {
                sendCommand("s p2.2 0\n", 2000);
                mcResponse = sendCommand("r p2.2\n", 2000);
                mcResponse = convertToTrueOrFalse(mcResponse.Split(':')[1].Trim());
                tbHallSel.Text = mcResponse;
               
            }
            mcResponse = sendCommand("ihall\n", 5000);
            showMessageOnResponseBox(mcResponse);
            mcResponse = mcResponse.Split('=')[1].Trim();

            tbHall1.Text = mcResponse;

            mcValue = getNumFromString(mcResponse);


            if (isMeasureOK(min: 2000, max: 2100, value: mcValue))
            {
                pfHall1.BackColor = System.Drawing.Color.Green;
                showMessageOnResponseBox("\r\nValor dentro del rango aceptable", append: true);

            }
            else
            {
                pfHall1.BackColor = System.Drawing.Color.Red;
                showMessageOnResponseBox("\r\nHay un problema, el valor está fuera del rango aceptable", append: true);
                showMessageOnResponseBox("Debe ser mayor de 2000 y menor de 2100", append: true);
            }



        }

        private void btnTestHall2_Click(object sender, EventArgs e)
        {

            

            if (tbAP.Text == "FALSE")
            {
                swapAP();
            }

            if (tbHallSel.Text == "FALSE")
            {
                sendCommand("s p2.2 1\n", 2000);
                mcResponse = sendCommand("r p2.2\n", 2000);
                mcResponse = convertToTrueOrFalse(mcResponse.Split(':')[1].Trim());
                tbHallSel.Text = mcResponse;

            }
            mcResponse = sendCommand("ihall\n", 5000);
            showMessageOnResponseBox(mcResponse);

            mcResponse = mcResponse.Split('=')[1].Trim();

            tbHall2.Text = mcResponse;

            mcValue = getNumFromString(mcResponse);


            if (isMeasureOK(min: 2000, max: 2100, value: mcValue))
            {
                pfHall2.BackColor = System.Drawing.Color.Green;
                showMessageOnResponseBox("\r\nValor dentro del rango aceptable", append: true);

            }
            else
            {
                pfHall2.BackColor = System.Drawing.Color.Red;
                showMessageOnResponseBox("\r\nHay un problema, el valor está fuera del rango aceptable", append: true);
                showMessageOnResponseBox("Debe ser mayor de 2000 y menor de 2100", append: true);
            }

        }

        private void btnTestHall1LPF_Click(object sender, EventArgs e)
        {
            
            if (tbAP.Text == "FALSE")
            {
                swapAP();
            }
            mcResponse = sendCommand("ihall1\n", 7000);
            showMessageOnResponseBox(mcResponse);
            mcResponse = mcResponse.Split('=')[1].Trim();
            tbHall1LPF.Text = mcResponse;

            mcValue = getNumFromString(mcResponse);

            
            if (isMeasureOK(min: 2000, max: 2100, value: mcValue))
            {
                pfHall1LPF.BackColor = System.Drawing.Color.Green;
                showMessageOnResponseBox("\r\nValor dentro del rango aceptable", append: true);

            }
            else
            {
                pfHall1LPF.BackColor = System.Drawing.Color.Red;
                showMessageOnResponseBox("\r\nHay un problema, el valor está fuera del rango aceptable", append: true);
                showMessageOnResponseBox("Debe ser mayor de 2000 y menor de 2100", append: true);
            }

        }

        private void btnTestIMEAS_Click(object sender, EventArgs e)
        {
            

            if (tbAP.Text == "FALSE")
            {
                swapAP();
            }
            mcResponse = sendCommand("imeas\n", 5000);
            showMessageOnResponseBox(mcResponse);
            mcResponse = mcResponse.Split('=')[1].Trim();
            tbIMEAS.Text = mcResponse;
            mcValue = getNumFromString(mcResponse);

            
            if (isMeasureOK(min: 2000, max: 2100, value: mcValue))
            {
                pfIMEAS.BackColor = System.Drawing.Color.Green;
                showMessageOnResponseBox("\r\nValor dentro del rango aceptable", append: true);

            }
            else
            {
                pfIMEAS.BackColor = System.Drawing.Color.Red;
                showMessageOnResponseBox("\r\nHay un problema, el valor está fuera del rango aceptable", append: true);
                showMessageOnResponseBox("Debe ser mayor de 2000 y menor de 2100", append: true);
            }

        }

        private void btnTestESFX_Click(object sender, EventArgs e)
        {
            if (tbAP.Text == "FALSE")
            {
                swapAP();
            }
            mcResponse = sendCommand("efsx\n", 5000);
            showMessageOnResponseBox(mcResponse);
            mcResponse = mcResponse.Split('=')[1].Trim();
            tbESFX.Text = mcResponse;

            mcValue = getNumFromString(mcResponse);


            if (isMeasureOK(min: 2000, max: 2100, value: mcValue))
            {
                pfESFX.BackColor = System.Drawing.Color.Green;
                showMessageOnResponseBox("\r\nValor dentro del rango aceptable", append: true);

            }
            else
            {
                pfESFX.BackColor = System.Drawing.Color.Red;
                showMessageOnResponseBox("\r\nHay un problema, el valor está fuera del rango aceptable", append: true);
                showMessageOnResponseBox("Debe ser mayor de 2000 y menor de 2100", append: true);
            }
        }

        private void btnTestVCAP_Click(object sender, EventArgs e)
        {

            float volts;

            if (tbAP.Text == "FALSE")
            {
                swapAP();
            }

            mcResponse = sendCommand("vcap\n", 5000);
            mcResponse = mcResponse.Split('=')[1].Trim();

            mcValue = getNumFromString(mcResponse);
            volts = ((mcValue * 2) / 1000);
            showMessageOnResponseBox($"VCAP: {volts.ToString("0.00")}V");
            tbVCAP.Text = volts.ToString("0.00") + "V";

            if (isMeasureOK(min: 4, max: 5, value: volts))
            {
                pfVCAP.BackColor = System.Drawing.Color.Green;
                showMessageOnResponseBox("\r\nValor dentro del rango aceptable", append: true);

            }
            else
            {
                pfVCAP.BackColor = System.Drawing.Color.Red;
                showMessageOnResponseBox("\r\nHay un problema, el valor está fuera del rango aceptable", append: true);
                showMessageOnResponseBox("Debe ser mayor a 3V y menor a 5V", append: true);
            }
        }

        private void btnTestCC_Click(object sender, EventArgs e)
        {
            if (tbAP.Text == "FALSE")
            {
                swapAP();
            }

            mcResponse = sendCommand("capcharged\n", 7000);
            showMessageOnResponseBox(mcResponse);
            mcResponse = mcResponse.Split('=')[1].Trim();
            tbCapCharge.Text = mcResponse;
            mcValue = getNumFromString(mcResponse);


            if (isMeasureOK(min: 4090, max: 4100, value: mcValue))
            {
                pfCapCharge.BackColor = System.Drawing.Color.Green;
                showMessageOnResponseBox("\r\nEl microcontrolador indica que VCAP está en su máximo voltaje", append: true);

            }
            else
            {
                pfCapCharge.BackColor = System.Drawing.Color.Red;
                showMessageOnResponseBox("\r\nEl microcontrolador indica que VCAP no está en su máximo voltaje", append: true);
               
            }
        }

        private void btnTestTP_Click(object sender, EventArgs e)
        {
            float temperature;

            if (tbAP.Text == "FALSE")
            {
                swapAP();
            }
            mcResponse = sendCommand("tp\n", 5000);
   
            mcResponse = mcResponse.Split('=')[1].Trim();

            mcValue = getNumFromString(mcResponse);

            //la formula para la temperatura se sacó del datasheet del componente
            temperature = (((mcValue - 372) - 424)/ 6.25f);
            tbTP.Text = temperature.ToString("0.00") + "°C";
            showMessageOnResponseBox($"Temp: {temperature.ToString("0.00") + "°C"}");

            if (isMeasureOK(min: 0, max: 35, value: temperature))
            {
                pfTP.BackColor = System.Drawing.Color.Green;
                showMessageOnResponseBox("\r\nValor dentro del rango aceptable", append: true);

            }
            else
            {
                pfTP.BackColor = System.Drawing.Color.Red;
                showMessageOnResponseBox("\r\nHay un problema, el valor está fuera del rango aceptable", append: true);
                showMessageOnResponseBox("Debe ser mayor de 0°C y menor de 35°C", append: true);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult respuestaAlertaRam;
            respuestaAlertaRam = MessageBox.Show(
                "Si ya realizaste la prueba de RAM o FLASH a esta unidad es probable que al intentar hacerla de nuevo se reinicie\r\n" +
                "En caso de que se reinicie, normalmente bastará con intentar de nuevo\r\n" +
                "Si el error persiste podría haber un problema con la unidad\r\n\r\n" +
                "¿Deseas realizar la prueba?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuestaAlertaRam == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    mcResponse = sendCommand("mt flash\n", 10000, customMessage: "Realizando prueba de FLASH...");
                    showMessageOnResponseBox(mcResponse);
                    mcResponse = mcResponse.Split('=')[1].Trim();
                    showMessageOnStatusBox(mcResponse);
                    if (mcResponse == "SUCCESS!")
                    {
                        pfFLASH.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        pfFLASH.BackColor = System.Drawing.Color.Red;
                    }
                    tbFLASH.Text = mcResponse;
                }
                catch
                {
                    resetForm();
                    showMessageOnResponseBox(
                        "Parece que ocurrió un problema...\r\n" +
                        "Si la unidad no inicia al tratar de bootear apaga y enciende la fuente e inténtalo de nuevo");
                }
            }
        }

        private void checkIfRadioRestartedTimer_Tick(object sender, EventArgs e)
        {

            string buffer;

            checkIfRadioRestartedTimer.Stop();

            buffer = serialPort.ReadExisting();
            if(buffer.Contains("MV Monitor"))
            {
                resetForm();
                showMessageOnResponseBox("Ocurrió un error de comunicación con el módulo");
            }
            else
            {
                checkIfRadioRestartedTimer.Start();
            }
            

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
//using System.IO;


namespace chatServer
{

    public partial class Server : Form
    {
        public static Server instance;
        public Socket _serversocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private  List<SocketT2h> _clientsockets = new List<SocketT2h>();
        private byte[] _buffer = new byte[1716964];
        List<string> Student_Name = new List<string>();

        public Button b1;
        public Button b2;

        public Server()
        {
            InitializeComponent();
            instance = this;
            b1 = ssbtn;
            b2 = btnMonitor;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        { 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupServer();
           
        }

        private void SetupServer()
        {
          
            _serversocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serversocket.Listen(1);
            _serversocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void AppceptCallback(IAsyncResult ar)
        {
            Socket socket = _serversocket.EndAccept(ar);
            _clientsockets.Add(new SocketT2h(socket));

            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            _serversocket.BeginAccept(new AsyncCallback(AppceptCallback), null);

        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;

            if(socket.Connected)
            {
                int received;
                try
                {
                     received = socket.EndReceive(ar);
                }
                catch(Exception)
                {
                    for (int i = 0; i < _clientsockets.Count; i++)
                    {
                        if (_clientsockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            _clientsockets.RemoveAt(i);
                        }
                    }
                    return;
                }

                if (received != 0)
                {
                    byte[] dataBuf = new byte[received];
                    Array.Copy(_buffer, dataBuf, received);

                    try
                    {
                        
                        ScreenShot.instance.pic.Invoke((MethodInvoker)(() => ScreenShot.instance.pic.Image =
                                                                        (Bitmap)(new ImageConverter()).ConvertFrom(dataBuf)));                     
                    }                  
                    catch (Exception) { }

                    try
                    {
                        LiveMonitor.instance.pic1.Invoke((MethodInvoker)(() => LiveMonitor.instance.pic1.Image =                                                                        (Bitmap)(new ImageConverter()).ConvertFrom(dataBuf)));
                    }
                    catch (Exception) { }

                    string text = Encoding.ASCII.GetString(dataBuf);

                    string[] client_details = text.Split(',');
                    Student_Name.Add(client_details[0].ToUpper() + " ");

                    string address = (string)socket.RemoteEndPoint.ToString();
                    string[] ip_port = address.Split(':');

                    string[] name = text.Split(':');


                    try
                    {                       
                        if (client_details[2].Equals("Connect"))
                        {

                            checked_list.Invoke((MethodInvoker)(() => checked_list.Items.Add(socket.RemoteEndPoint.ToString() + ":" + client_details[0] + ":" + client_details[1])));
                            dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.Rows.Add(client_details[0].ToUpper(), client_details[1], ip_port[0], ip_port[1])));
                        }
                    }
                    catch(Exception)
                    {

                        List<string> myList = Student_Name.Distinct().ToList();
                        foreach (string obj in myList)
                        {
                            if (name[0].Equals(obj))
                            {
                                txtmsg.Invoke((MethodInvoker)(() => txtmsg.AppendText(text + "\r\n")));                                
                            }                         
                        }
                    }


                    try
                    {
                        switch (name[1])
                        {
                            case " INSERTED USB":
                                //this.ShowDialog();
                                MessageBox.Show(text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;

                            case " REMOVED USB":
                                MessageBox.Show(text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                        }
                    }
                    catch (Exception) { }

                }
                else
                {
                    for (int i = 0; i < _clientsockets.Count; i++)
                    {
                        if (_clientsockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            _clientsockets.RemoveAt(i);
                            dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.Rows.RemoveAt(i)));
                            checked_list.Invoke((MethodInvoker)(() => checked_list.Items.RemoveAt(i)));
                        }
                    }
                }
            }

            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);

        }

        private void byteArrayToImage(byte[] bytesArr)
        {
            //return (Bitmap)(new ImageConverter()).ConvertFrom(bytesArr);
            try
            {
                ScreenShot.instance.pic.Invoke((MethodInvoker)(() => ScreenShot.instance.pic.Image =
                                                                         (Bitmap)(new ImageConverter()).ConvertFrom(bytesArr)));
                LiveMonitor.instance.pic1.Invoke((MethodInvoker)(() => LiveMonitor.instance.pic1.Image =
                                                                    (Bitmap)(new ImageConverter()).ConvertFrom(bytesArr)));
            }
            catch (Exception) { }
        }

        //public Image byteArrayToImage(byte[] byteArrayIn)
        //{
        //    MemoryStream ms = new MemoryStream(byteArrayIn);
        //    Image returnImage = Image.FromStream(ms);
        //    return returnImage;
        //}

        public void Sendata(Socket socket, string text)
        {
            byte[] data = Encoding.ASCII.GetBytes(text);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            _serversocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void SendCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            socket.EndSend(ar);
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {

            SendMsg("Server : " + txtchat.Text);
            
            txtmsg.AppendText("You : " + txtchat.Text + "\r\n");
            txtchat.Text = "";
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Checked_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SendMsg(string text)
        {
            List<int> list = new List<int>();

            foreach (int index in checked_list.CheckedIndices)
            {
                list.Add(index);
            }

            for (int i = 0; i < checked_list.CheckedItems.Count; i++)
            {
                Sendata(_clientsockets[list[i]]._Socket,text);
            }

        }

        private void Ssbtn_Click(object sender, EventArgs e)
        {
            btnMonitor.Enabled = false; 

            ScreenShot ss = new ScreenShot();
            ss.Show();
            

        }
        private void BtnMonitor_Click(object sender, EventArgs e)
        {
            ssbtn.Enabled = false;
            
            LiveMonitor l = new LiveMonitor();
            l.Show();
            // LiveMonitor.instance.pic1.Image = null;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SendMsg("Shutdown");
        }

        private void Restart_Btn_Click(object sender, EventArgs e)
        {
            SendMsg("Restart");
        }

        private void Lock_Btn_Click(object sender, EventArgs e)
        {
            SendMsg("Lock");
        }

        private void Btnpdf_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception)
                        {
                          // MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}

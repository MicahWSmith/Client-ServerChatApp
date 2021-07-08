using System;
using System.Windows.Forms;
using BusinessClass;
using System.Threading;
using ChatLogger;

namespace ChatForm
{
    public partial class Form1 : Form
    {
        String output;
        //refactored vars
        IMessaging th;// = new TaskHandler();
        ILoggingService lg; //= new Logger();
        ILoggingService cl;
        private Thread clientThread;
        private Thread serverThread;
        event EventHandler<MessageArgs> SendMessage;
        /// <summary>
        /// Append sending and logging methods to corresponding delegates
        /// Initialize form
        /// </summary>
        public Form1(ILoggingService logger, IMessaging handler)//Refactored
        {
            th = handler; // Refactored
            lg = logger; // Refactored

            cl = new ConsoleLogger();
            cl.NewLog();
            // Add events to delegate
            SendMessage += th.SendClient;
            SendMessage += lg.LogMessage;
            SendMessage += cl.LogMessage;
            th.GetMessage += ReceiveMessage;
            th.GetMessage += lg.LogMessage;
            th.GetMessage += cl.LogMessage;
            InitializeComponent();
        }

        private void placeHolderLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// On connect button pressed create threads and log file
        /// Start processes
        /// enable sending from client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientThread = new Thread(th.Connect);
            clientThread.Name = "Client Thread";
            clientThread.IsBackground = true;
            clientThread.Start();

            serverThread = new Thread(th.ListenMode);
            serverThread.Name = "Server thread";
            serverThread.IsBackground = true;
            serverThread.Start();

            lg.NewLog();
            sendButton.Enabled = true;
        }
        /// <summary>
        /// Write message to convo text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReceiveMessage(object sender, MessageArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                convoTextBox.AppendText("<< " + e.Message);
                convoTextBox.AppendText(Environment.NewLine);
            }));
            
        }

        private void ConvoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// End connection and extra threads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th.StopTasks();
            clientThread?.Join();
            serverThread?.Join();
            sendButton.Enabled = false;
        }
        /// <summary>
        /// End connection and close application GRACEFULLY!!!!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th.StopTasks();
            clientThread?.Join();
            serverThread?.Join();
            Close();
        }
        /// <summary>
        /// On button click invoke send message delegate event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendButton_Click(object sender, EventArgs e)
        {
            output = msgTextBox.Text;
            SendMessage(this, new MessageArgs() { Message = "Client: " + output });
            convoTextBox.AppendText(">> " + output);
            convoTextBox.AppendText(Environment.NewLine);
        }

        private void networkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

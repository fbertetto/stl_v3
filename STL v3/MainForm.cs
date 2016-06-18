using STL_v3.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STL_v3
{
    public partial class MainForm : Form
    {
        //  Static form instance to access in a static way to controls.
        static MainForm frm;
        //  Voice Recognition Service.
        private VoiceRecognitionService voiceRecognitionService = new VoiceRecognitionService();

        /// <summary>
        /// Default constructor for class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            frm = this;
        }
        
        /// <summary>
        /// Event on click at start recognizing button. Starts speech recognition.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                btn_start.Enabled = false;
                voiceRecognitionService.startSpeechRecognition();
            }
            catch (InvalidOperationException exception)
            {
                btn_start.Enabled = true;
                voiceRecognitionService.stopSpeechRecognition();
                MessageBox.Show("Could not recognize input from default aduio device. Is a microphone or sound card available?" + exception.Source, exception.Message);
            }
        }

        /// <summary>
        /// Sets text to resut recognized text label.
        /// </summary>
        /// <param name="recognizedText">Recognized text to set.</param>
        public static void setRecognizedText(String recognizedText)
        {
            frm.lbl_recogition.Text += recognizedText;
        }

        /// <summary>
        /// Event on click at stop recognizing button. Stops speech recognition.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            voiceRecognitionService.stopSpeechRecognition();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace STL_v3.Services
{
    /// <summary>
    /// Voice recognition service, it has the complete functionality to start the service,
    /// recognize voice and stop the service.
    /// </summary>
    public class VoiceRecognitionService
    {
        //  Speech recognition engine.
        private SpeechRecognitionEngine recognizer;

        /// <summary>
        /// Initilize the engine, load a grammar and start the service.
        /// </summary>
        public void startSpeechRecognition()
        {
            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-ES"));
            Grammar dictationGrammar = new DictationGrammar();
            dictationGrammar.Enabled = true;
            recognizer.LoadGrammar(dictationGrammar);
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sRecognize_SpeechRecognized);
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        /// <summary>
        /// Event call when an speech is recgnized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //if (e.Result.Confidence >= 0.3)
            string recognizedText = e.Result.Text.ToString().PadRight(1);
            MainForm.setRecognizedText(recognizedText);

        }

        /// <summary>
        /// Unload the grammar and stop the service.
        /// </summary>
        public void stopSpeechRecognition()
        {
            recognizer.UnloadAllGrammars();
        }
    }
}

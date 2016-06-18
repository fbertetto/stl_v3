using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace STL_v3
{
    public class VoiceRecognitionService
    {
        SpeechRecognitionEngine recognizer;
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

        private void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

        }

        public void stopSpeechRecognition()
        {
            recognizer.UnloadAllGrammars();
        }
    }
}

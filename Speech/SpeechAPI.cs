using System.Speech.Recognition;
using System;
using System.Speech.Synthesis;

namespace obedtwLAPI.Speech
{
    /// <summary>
    /// Beta API. Some Bug on it!
    /// </summary>
    public class SpeechAPI
    {
        public System.Speech.Synthesis.SpeechSynthesizer speechCore;
        /// <summary>
        /// Beta API. Some Bug on it!
        /// </summary>
        public SpeechAPI(System.Speech.Synthesis.SpeechSynthesizer Core)
        {
              speechCore = Core;
        }
        /// <summary>
        /// Beta API. Some Bug on it!
        /// </summary>
        public SpeechAPI()
        {
            speechCore = new System.Speech.Synthesis.SpeechSynthesizer();
            
        }
        /// <summary>
        /// Text to Sound and Play it
        /// </summary>
        /// <param name="Text"></param>
        public void Said(string Text)
        {
            speechCore.Speak(Text);
        }
        /// <summary>
        /// Recognize Audio to en-US Format Text with old API.
        /// </summary>
        public void StartRecognizer(EventHandler<SpeechRecognizedEventArgs> recognizer_SpeechRecognized)
        {
            using (
             SpeechRecognitionEngine recognizer =
              new SpeechRecognitionEngine(
               new System.Globalization.CultureInfo("en-US")))
            {

                // Create and load a dictation grammar.  
                recognizer.LoadGrammar(new DictationGrammar());

                // Add a handler for the speech recognized event.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.  
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous, continuous speech recognition.  
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                
            }
        }
        /// <summary>
        /// Recognize Audio to Text with old API.
        /// </summary>
        /// <param name="cultureInfo"> Culture code</param>
        public void StartRecognizer(EventHandler<SpeechRecognizedEventArgs> recognizer_SpeechRecognized, System.Globalization.CultureInfo cultureInfo)
        {
            using (
             SpeechRecognitionEngine recognizer =
              new SpeechRecognitionEngine(
              cultureInfo))
            {

                // Create and load a dictation grammar.  
                recognizer.LoadGrammar(new DictationGrammar());

                // Add a handler for the speech recognized event.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.  
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous, continuous speech recognition.  
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

              
            }
        }
        /// <summary>
        /// Recognize Audio to Text with old API.
        /// </summary>
        /// <param name="cultureInfo"> Culture code</param>
        public void StartRecognizer(EventHandler<SpeechRecognizedEventArgs> recognizer_SpeechRecognized, string cultureInfo)
        {
            using (
             SpeechRecognitionEngine recognizer =
              new SpeechRecognitionEngine(
              new System.Globalization.CultureInfo(cultureInfo)))
            {

                // Create and load a dictation grammar.  
                recognizer.LoadGrammar(new DictationGrammar());

                // Add a handler for the speech recognized event.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.  
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous, continuous speech recognition.  
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                
            }
        }

    }


}



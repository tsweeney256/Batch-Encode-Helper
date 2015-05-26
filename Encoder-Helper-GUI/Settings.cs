using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder_Helper_GUI
{
    [Serializable]
    public class Settings
    {
        public string[] x264Args { get; set; }
        public int[] encoder { get; set; }
        public string[] fileNamePrefix { get; set; }
        public string[] fileNameBody { get; set; }
        public string[] fileNameSuffix { get; set; }
        public string videoTrackName { get; set; }
        public string videoLanguageCode { get; set; }
        public string avisynthTemplate { get; set; }
        public decimal[] quality { get; set; }
        public string[] audioTrackName { get; set; }
        public string[] audioLanguageCode { get; set; }
        public int counterIndex { get; set; }
        public int counterValue { get; set; }

        public Settings() { }

        public Settings(Settings settings)
        {
            x264Args = (string[])settings.x264Args.Clone();
            encoder = (int[])settings.encoder.Clone();
            fileNamePrefix = (string[])settings.fileNamePrefix.Clone();
            fileNameBody = (string[])settings.fileNameBody.Clone();
            fileNameSuffix = (string[])settings.fileNameSuffix.Clone();
            videoTrackName = settings.videoTrackName;
            videoLanguageCode = settings.videoLanguageCode;
            avisynthTemplate = settings.avisynthTemplate;
            quality = (decimal[])settings.quality.Clone();
            audioTrackName = (string[])settings.audioTrackName.Clone();
            audioLanguageCode = (string[])settings.audioLanguageCode.Clone();
            counterIndex = settings.counterIndex;
            counterValue = settings.counterValue;
        }

        public virtual void Initialize()
        {
            x264Args = new string[1];
            encoder = new int[1];
            fileNamePrefix = new string[1];
            fileNameBody = new string[1];
            fileNameSuffix = new string[1];
            quality = new decimal[1];
            audioTrackName = new string[1];
            audioLanguageCode = new string[1];
            counterValue = 1;
        }
    }
}

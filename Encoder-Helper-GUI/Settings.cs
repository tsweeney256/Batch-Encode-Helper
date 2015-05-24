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
        public string videoTrackName { get; set; }
        public string videoLanguageCode { get; set; }
        public string avisynthTemplate { get; set; }
        public decimal[] quality { get; set; }
        public string[] audioTrackName { get; set; }
        public string[] audioLanguageCode { get; set; }

        public Settings() { }

        public Settings(Settings settings)
        {
            x264Args = (string[])settings.x264Args.Clone();
            encoder = (int[])settings.encoder.Clone();
            videoTrackName = settings.videoTrackName;
            videoLanguageCode = settings.videoLanguageCode;
            avisynthTemplate = settings.avisynthTemplate;
            quality = (decimal[])settings.quality.Clone();
            audioTrackName = (string[])settings.audioTrackName.Clone();
            audioLanguageCode = (string[])settings.audioLanguageCode.Clone();
        }

        public virtual void Initialize()
        {
            x264Args = new string[1];
            encoder = new int[1];
            quality = new decimal[1];
            audioTrackName = new string[1];
            audioLanguageCode = new string[1];
        }
    }
}

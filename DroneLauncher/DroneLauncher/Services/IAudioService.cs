using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLauncher.Services
{
    public interface IAudioService
    {
        void AdjustVolume(double volume);
        void KillEngine();
        void ToggleEngine();
        Action OnFinishedPlaying { get; set; }
    }
}
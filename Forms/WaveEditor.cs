using kanagawa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanagawa
{
    /// <summary>
    /// Wave editor functions and properties within the main form.
    /// </summary>
    public partial class Main
    {
        //The wave being edited.
        Wave wave = null;

        /// <summary>
        /// Sets the wave editor to edit the given wave object.
        /// </summary>
        private void UpdateWave(Wave toEdit)
        {
            wave = toEdit;

            //Update field bindings.
            waveSoundTxt.DataBindings.Clear();
            waveSoundTxt.DataBindings.Add("Text", wave, "Sound");
            waveCheckpointCb.DataBindings.Clear();
            waveCheckpointCb.DataBindings.Add("Checked", wave, "SetCheckpoint");
        }
    }
}

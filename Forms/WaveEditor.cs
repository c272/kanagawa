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

            //Update fields to match new wave.
            waveCheckpointCb.Checked = wave.SetCheckpoint;
            waveSoundTxt.Text = wave.Sound;
        }

        /// <summary>
        /// Triggered when the wave sound text box is edited.
        /// </summary>
        private void waveSoundChanged(object sender, EventArgs e)
        {
            //Edit data bindings.
            wave.Sound = waveSoundTxt.Text;
        }

        /// <summary>
        /// Triggered when the wave checkpoint checkbox is edited.
        /// </summary>
        private void waveCheckpointChanged(object sender, EventArgs e)
        {
            //Edit data bindings.
            wave.SetCheckpoint = waveCheckpointCb.Checked;
        }
    }
}

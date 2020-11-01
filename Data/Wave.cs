using kanagawa.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanagawa.Data
{
    /// <summary>
    /// Represents a single wave of robots in Kanagawa.
    /// </summary>
    class Wave : Equatable
    {
        /// <summary>
        /// The squads contained in this wave.
        /// </summary>
        public List<Squad> Squads { get; set; } = new List<Squad>();

        /// <summary>
        /// The entity output that runs at the start of this wave.
        /// </summary>
        [PopName("StartWaveOutput")]
        public IOOutput WaveStartAction { get; set; } = new IOOutput()
        {
            Target = "wave_start_relay",
            Action = "trigger"
        };

        /// <summary>
        /// The entity output that runs at the end of this wave.
        /// </summary>
        [PopName("DoneOutput")]
        public IOOutput WaveEndAction { get; set; } = new IOOutput()
        {
            Target = "wave_end_relay",
            Action = "trigger"
        };

        /// <summary>
        /// Whether or not to set a checkpoint at the end of this wave.
        /// </summary>
        [PopName("Checkpoint")]
        public bool SetCheckpoint { get; set; } = true;

        /// <summary>
        /// The sound to make when the wave begins.
        /// </summary>
        public string Sound { get; set; } = "";

        /// <summary>
        /// I have no idea what this does.
        /// </summary>
        //public bool WaitWhenDone = true;
    }
}

using kanagawa.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanagawa.Data
{
    /// <summary>
    /// Represents a single MvM mission in Kanagawa.
    /// </summary>
    class Mission
    {
        /// <summary>
        /// The objective of the mission (destroy sentries, spy, etc.)
        /// </summary>
        public MissionObjective Objective { get; set; }

        /// <summary>
        /// The time after a wave starts before the mission becomes active.
        /// </summary>
        public int InitialCooldown { get; set; }

        /// <summary>
        /// The location to spawn the mission entities at.
        /// </summary>
        [PopName("Where")]
        [PopExpandList]
        public List<string> Location { get; set; }

        /// <summary>
        /// The wave to start the mission on.
        /// </summary>
        [PopName("BeginAtWave")]
        public int StartWave { get; set; } = 1;

        /// <summary>
        /// How many waves to run the mission for.
        /// </summary>
        [PopName("RunForThisManyWaves")]
        public int WaveLength { get; set; } = 1;

        /// <summary>
        /// The period of time between mission entities being spawned.
        /// </summary>
        public int CooldownTime { get; set; } = 30;

        /// <summary>
        /// The number of entities to spawn each time this mission is triggered.
        /// </summary>
        [PopName("DesiredCount")]
        public int NumToSpawn { get; set; } = 1;

        /// <summary>
        /// The entity this mission spawns.
        /// </summary>
        public Bot Entity { get; set; } = null;
    }

    /// <summary>
    /// Possible mission objectives in a popfile.
    /// </summary>
    public enum MissionObjective
    {
        Spy,
        Sniper,
        DestroySentries,
        Engineer,
        SeekAndDestroy
    }
}

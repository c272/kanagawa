using kanagawa.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanagawa.Data
{
    /// <summary>
    /// Represents a single squad of robots in Kanagawa.
    /// </summary>
    [PopName("WaveSpawn")]
    class Squad
    {
        /// <summary>
        /// The total number of individual bots to spawn.
        /// </summary>
        public int TotalCount = 0;

        /// <summary>
        /// The maximum number of bots from this squad that can be alive at once.
        /// </summary>
        public int MaxActive = 999;

        /// <summary>
        /// The amount of bots to spawn at a time.
        /// </summary>
        public int SpawnCount = 1;

        /// <summary>
        /// The amount of time to wait before starting to spawn the squad.
        /// </summary>
        public float WaitBeforeStarting = 0;

        /// <summary>
        /// The amount of time to wait between spawning each group of robots.
        /// </summary>
        public float WaitBetweenSpawns = 0;

        /// <summary>
        /// The sound to play when this squad starts.
        /// </summary>
        [PopName("StartWaveWarningSound")]
        public string StartSound = "";

        /// <summary>
        /// The sound to play when the first robot from this squad spawns.
        /// </summary>
        [PopName("FirstSpawnWarningSound")]
        public string FirstSpawnSound = "";

        /// <summary>
        /// The sound to play when the last robot from this squad spawns.
        /// </summary>
        [PopName("LastSpawnWarningSound")]
        public string LastSpawnSound = "";

        /// <summary>
        /// The sound to play when the squad is over.
        /// </summary>
        [PopName("DoneWarningSound")]
        public string DoneSound = "";

        /// <summary>
        /// The total currency that the robots drop. 
        /// </summary>
        public int TotalCurrency = -1;

        /// <summary>
        /// The name of this squad.
        /// </summary>
        public string Name = "New Squad";

        /// <summary>
        /// The squad to wait for all bots to be spawned in before starting this squad.
        /// </summary>
        public string WaitForAllSpawned = "";

        /// <summary>
        /// The squad to wait for all bots to be dead from before starting this squad.
        /// </summary>
        [PopSerializeOnCondition("WFAChecker")]
        public string WaitForAllDead = "";
        public bool WFAChecker() { return WaitForAllSpawned == "" || WaitForAllSpawned == null; }

        /// <summary>
        /// Whether support should abide by the TotalCount or not.
        /// </summary>
        [PopName("Support")]
        public string SupportLimitedByTotalCount = "";
    }
}

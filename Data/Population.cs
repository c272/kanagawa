using kanagawa.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanagawa.Data
{
    /// <summary>
    /// Represents the overall popfile root in Kanagawa.
    /// </summary>
    class Population
    {
        /// <summary>
        /// List of all missions occuring during the game.
        /// </summary>
        [PopExpandList]
        public List<Mission> Missions { get; set; } = new List<Mission>();

        /// <summary>
        /// List of all waves occuring during the game.
        /// </summary>
        [PopExpandList]
        public List<Wave> Waves { get; set; } = new List<Wave>();

        /// <summary>
        /// A list of available templates from the parsed population file.
        /// </summary>
        public Templates Templates { get; set; }

        /// <summary>
        /// Whether bots can attack while players are in their spawn room.
        /// </summary>
        [PopName("CanBotsAttackWhileInSpawnRoom")]
        public bool BotsAttackInSpawn = false;

        /// <summary>
        /// After how many robot kills a sentry buster should be deployed.
        /// </summary>
        [PopName("AddSentryBusterWhenKillCountExceeds")]
        public int SentryBusterKillThreshold = 50;

        /// <summary>
        /// After how much damage a sentry buster should be deployed.
        /// </summary>
        [PopName("AddSentryBusterWhenDamageDealtExceeds")]
        public int SentryBusterDamageThreshold = 5000;

        /// <summary>
        /// How much currency each player is given at the start of the game.
        /// </summary>
        public int StartingCurrency = 200;

        /// <summary>
        /// Maximum respawn time across the whole game, respawn time grows 2 seconds a round.
        /// </summary>
        [PopName("RespawnWaveTime")]
        public int MaxRespawnTime = 10;

        /// <summary>
        /// Whether the respawn wave time is fixed (does not grow).
        /// </summary>
        public bool FixedRespawnWaveTime = false;
    }
}

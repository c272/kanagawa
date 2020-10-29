using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kanagawa.Serialization;

namespace kanagawa.Data
{
    /// <summary>
    /// Represents a single TFBot entity in the popfile tree.
    /// </summary>
    class Bot
    {
        /// <summary>
        /// The icon to be used in the wave bar for this robot.
        /// </summary>
        public string ClassIcon { get; set; } = null;

        /// <summary>
        /// The class of the robot.
        /// </summary>
        public TFClass Class { get; set; }

        /// <summary>
        /// The skill of the robot.
        /// </summary>
        public BotSkill Skill { get; set; }

        /// <summary>
        /// The name of this robot.
        /// </summary>
        public string Name { get; set; } = "New Robot";

        /// <summary>
        /// The health that this robot starts with.
        /// </summary>
        public int Health { get; set; } = 125;

        /// <summary>
        /// Item attributes for this TFBot.
        /// </summary>
        public ItemAttributes Attributes = null;

        /// <summary>
        /// The template name to use as a base.
        /// </summary>
        [PopSerializeOnCondition("TemplateUsed")]
        public string Template = null;
        public bool TemplateUsed() { return Template == null || Template == ""; }


    }

    /// <summary>
    /// The possible skill levels for bots.
    /// </summary>
    public enum BotSkill
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    /// <summary>
    /// The possible team fortress bot classes.
    /// </summary>
    public enum TFClass
    {
        Scout,
        Soldier,
        Pyro,
        Demoman,
        Heavy,
        Engineer,
        Medic,
        Sniper,
        Spy
    }
}

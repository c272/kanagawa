using kanagawa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanagawa
{
    public partial class Main
    {
        //The squad being edited.
        Squad squad = null;

        /// <summary>
        /// Changes the squad being edited to a new squad.
        /// </summary>
        void UpdateSquad(Squad toUpdate)
        {
            squad = toUpdate;

            //Update bindings.
            //general settings
            squadCurrencyNum.DataBindings.Clear();
            squadCurrencyNum.DataBindings.Add("Value", squad, "TotalCurrency");
            squadNameTxt.DataBindings.Clear();
            squadNameTxt.DataBindings.Add("Text", squad, "Name");

            //sounds
            squadStartSnd.DataBindings.Clear();
            squadStartSnd.DataBindings.Add("Text", squad, "StartSound");
            squadSpawnSnd.DataBindings.Clear();
            squadSpawnSnd.DataBindings.Add("Text", squad, "FirstSpawnSound");
            squadSpawnLastSnd.DataBindings.Clear();
            squadSpawnLastSnd.DataBindings.Add("Text", squad, "LastSpawnSound");
            squadFinishedSnd.DataBindings.Clear();
            squadFinishedSnd.DataBindings.Add("Text", squad, "DoneSound");

            //spawn settings
            squadTotalCountNum.DataBindings.Clear();
            squadTotalCountNum.DataBindings.Add("Value", squad, "TotalCount");
            squadMaxActiveNum.DataBindings.Clear();
            squadMaxActiveNum.DataBindings.Add("Value", squad, "MaxActive");
            squadSpawnCountNum.DataBindings.Clear();
            squadSpawnCountNum.DataBindings.Add("Value", squad, "SpawnCount");
            squadStartDelayNum.DataBindings.Clear();
            squadStartDelayNum.DataBindings.Add("Value", squad, "WaitBeforeStarting");
            squadSpawnDelayNum.DataBindings.Clear();
            squadSpawnDelayNum.DataBindings.Add("Value", squad, "WaitBetweenSpawns");
            squadWaitTillSpawn.DataBindings.Clear();
            squadWaitTillSpawn.DataBindings.Add("Text", squad, "WaitForAllSpawned");
            squadWaitTillDeath.DataBindings.Clear();
            squadWaitTillDeath.DataBindings.Add("Text", squad, "WaitForAllDead");
        }

        /// <summary>
        /// Triggered when a squad's name is changed in the editor.
        /// </summary>
        private void squadNameChanged(object sender, EventArgs e)
        {
            //Update the title.
            squadTitle.Text = "Editing Squad \"" + squadNameTxt.Text + "\"";
        }
    }
}

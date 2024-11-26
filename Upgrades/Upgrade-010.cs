﻿using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmaMonkeyLeadMOAB
{
    internal class MoreRange : ModUpgrade<ExampleMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 1;

        public override int Cost => 300;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetAttackModel().weapons[0];
            var projectileModel = weaponModel.projectile;

            towerModel.range += 10;
            attackModel.range += 10;
        }
    }
}

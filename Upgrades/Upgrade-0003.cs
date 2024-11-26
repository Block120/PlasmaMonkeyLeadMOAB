﻿using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using PathsPlusPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmaMonkeyLeadMOAB.Upgrades
{
    internal class SomeMorePierce : UpgradePlusPlus<ExampleFourthPath>
    {
        public override int Cost => 3000;

        public override int Tier => 3;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetAttackModel().weapons[0];
            var projectileModel = weaponModel.projectile;

            projectileModel.pierce += 3;
        }
    }
}

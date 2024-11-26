using MelonLoader;
using BTD_Mod_Helper;
using PlasmaMonkeyLeadMOAB;

[assembly: MelonInfo(typeof(PlasmaMonkeyLeadMOAB.PlasmaMonkeyLeadMOAB), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace PlasmaMonkeyLeadMOAB;

public class PlasmaMonkeyLeadMOAB : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<PlasmaMonkeyLeadMOAB>("PlasmaMonkeyLeadMOAB loaded!");
    }
}
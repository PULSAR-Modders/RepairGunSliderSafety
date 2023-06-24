using PulsarModLoader;

namespace Repair_gun_slider_safety
{
    public class Mod : PulsarMod
    {
        public override string Version => "0.0.1";

        public override string Author => "18107";

        public override string ShortDescription => "Prevents system power sliders from being moved if a Repair Gun, Repair Grenade Launcher, or FB MultiTool is equipped.";

        public override string Name => "Repair gun slider safety";

        public override string ModID => "repairgunslidersafety";

        public override string HarmonyIdentifier()
        {
            return "id107.repairgunslidersafety";
        }
    }
}

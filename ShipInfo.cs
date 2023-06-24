using HarmonyLib;

namespace Repair_gun_slider_safety
{
    [HarmonyPatch(typeof(PLShipInfo), "OnSysInstValueChanged")]
    internal class ShipInfo
    {
        static bool Prefix()
        {
            string itemName = PLNetworkManager.Instance.LocalPlayer.MyInventory.ActiveItem.GetItemName(true);
            if ((itemName.StartsWith("Repair Gun") || itemName.StartsWith("Repair Grenade Launcher") || itemName.StartsWith("FB MultiTool")) && !PLInput.Instance.GetButton(PLInputBase.EInputActionName.unlock_mouse))
            {
                return false; //skip method
            }
            return true; //allow method to run
        }
    }
}

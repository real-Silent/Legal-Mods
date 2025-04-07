using BepInEx;
using TMPro;
using UnityEngine;

[BepInPlugin("com.silent.stump", "Old Stump", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    private GameObject OldRamp;
    private GameObject NewRamp;

    public void Start()
    {
        OldRamp = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/tree/stubbranch");
        NewRamp = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Terrain/longbranch/ramp");
        if (OldRamp != null && NewRamp != null)
        {
            OldRamp.SetActive(true);
            NewRamp.SetActive(false);
        }
        // Shouldnt need explaining on what everything does
    }
}

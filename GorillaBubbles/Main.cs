using BepInEx;
using UnityEngine;
namespace GorillaBubbles
{
    [BepInPlugin("OctoBurr.GorillaBubbles","GorillaBubbles","1.0.0")]
    public class Main : BaseUnityPlugin
    {
        GameObject bubbles;
        void Update()
        {
            if (bubbles == null)
                bubbles = GameObject.Find("Player Objects/Player VR Controller/GorillaPlayer/TurnParent/Main Camera/UnderwaterVisualEffects/UnderwaterParticleEffects/UnderwaterBubbles");
            else
            {
                if (!bubbles.activeSelf)
                {
                    bubbles.SetActive(true);
                    bubbles.transform.localPosition = new Vector3(0, 0.3f, 0);
                }
            }
        }
    }
}
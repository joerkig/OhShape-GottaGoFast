using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace GottaGoFast
{
    public class MyMod : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            MelonLogger.Msg("OnSceneWasLoaded was called");
            GameObject sliderVelocity = GameObject.Find("GameSetting/SliderVelocity/Slider");
            if (sliderVelocity != null)
            {
                Slider slider = sliderVelocity.GetComponent<Slider>();
                if (slider != null)
                {
                    slider.maxValue = 12;
                    slider.minValue = -7;
                }
                else
                {
                    MelonLogger.Msg("OSWL Failed to get Component");
                }
            }
            else
            {
                MelonLogger.Msg("OSWL Failed to find GameObject");
            }
        }
        public override void OnApplicationStart()
        {

        }
        public override void OnApplicationQuit()
        {

        }
    }
}

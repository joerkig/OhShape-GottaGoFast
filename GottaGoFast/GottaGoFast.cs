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
        public override void OnLateUpdate()
        {
            GameObject partyToggle = GameObject.Find("ModeToggle_PARTY");
            if (partyToggle != null)
            {
                Toggle partyModeToggle = partyToggle.GetComponent<Toggle>();
                if (partyModeToggle != null)
                {
                    GameObject sliderVelocity = GameObject.Find("GameSetting/SliderVelocity/Slider");
                    if (sliderVelocity != null)
                    {
                        Slider slider = sliderVelocity.GetComponent<Slider>();
                        if (slider != null)
                        {
                            if (slider.value < 0)
                            {
                                if (partyModeToggle.isOn == false)
                                {
                                    partyModeToggle.isOn = true;
                                }
                                GameObject scoreMultiplier = GameObject.Find("UI Config/SongCanvas/Content/ScoreMultiplier/ScoreMultiplier");
                                if (scoreMultiplier != null)
                                {
                                    Text scoreText = scoreMultiplier.GetComponent<Text>();
                                    if (scoreText != null)
                                    {
                                        scoreText.text = "Party Mode Forced";
                                    }
                                }
                            }
                            else if (slider.value > 4)
                            {
                                if (partyModeToggle.isOn == false)
                                {
                                    partyModeToggle.isOn = true;
                                }
                                GameObject scoreMultiplier = GameObject.Find("UI Config/SongCanvas/Content/ScoreMultiplier/ScoreMultiplier");
                                if (scoreMultiplier != null)
                                {
                                    Text scoreText = scoreMultiplier.GetComponent<Text>();
                                    if (scoreText != null)
                                    {
                                        scoreText.text = "Party Mode Forced";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName == "MenuScene")
            {
                MelonLogger.Msg("Menu Scene loaded. Changing Velocity Slider");
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
                        MelonLogger.Error("Failed to get Component");
                    }
                }
                else
                {
                    MelonLogger.Error("Failed to find GameObject");
                }
            }
        }
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("Vroom vroom");
        }
        public override void OnApplicationQuit()
        {

        }
    }
}

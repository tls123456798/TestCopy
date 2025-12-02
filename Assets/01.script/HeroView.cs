using UnityEngine;

public class HeroView : CombatantView
{
    public void Setup(HeroData heroData)
    {
        SetupBass(heroData.Health, heroData.Image);
    }
}

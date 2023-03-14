using UnityEngine;

public class MovingObjectBaseClass : MonoBehaviour
{
    protected float _slowTimeMultiplier;

    void Awake()
    {
        SlowTime.SlowTimeEvent.AddListener(SlowTimeMultiplierUpdated);
    }

    private void SlowTimeMultiplierUpdated(float multiplier)
    {
        _slowTimeMultiplier = multiplier;
    }
}

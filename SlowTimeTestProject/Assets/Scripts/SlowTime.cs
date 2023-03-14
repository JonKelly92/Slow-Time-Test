using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class SlowTime : MonoBehaviour
{
    [SerializeField] private float _normalTime;
    [SerializeField] private float _slowedTime;

    public static UnityEvent<float> SlowTimeEvent = new UnityEvent<float>();

    void Start()
    {
        SlowTimeEvent.Invoke(_normalTime);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SlowTimeEvent.Invoke(_normalTime);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            SlowTimeEvent.Invoke(_slowedTime);
        }
    }
}

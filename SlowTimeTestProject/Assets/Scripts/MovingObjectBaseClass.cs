using UnityEngine;

public abstract class MovingObjectBaseClass : MonoBehaviour
{
    [field: SerializeField] private Transform Position_1 { get; set; }
    [field: SerializeField] private Transform Position_2 { get; set; }

    [SerializeField] private float _speed = 2.5f;

    private Vector3 _desitnation;

    protected float _slowTimeMultiplier;

    protected virtual void Awake()
    {
        SlowTime.SlowTimeEvent.AddListener(SlowTimeMultiplierUpdated);
    }

    private void SlowTimeMultiplierUpdated(float multiplier)
    {
        _slowTimeMultiplier = multiplier;
    }

    protected virtual void Start()
    {
        _desitnation = Position_2.position;
        transform.position = Position_1.position;
    }

    protected virtual void Update()
    {
        if (Vector2.Distance(transform.position, _desitnation) > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, _desitnation, (_speed * _slowTimeMultiplier) * Time.deltaTime);
        }
        else
        {
            transform.position = _desitnation;

            if (_desitnation == Position_1.position)
                _desitnation = Position_2.position;

            else
                _desitnation = Position_1.position;
        }
    }
}

using UnityEngine;

public class MovingSquare : MovingObjectBaseClass
{
    [SerializeField] private float _rotationSpeed;

    private Vector3 _rotateDirection = new Vector3(0f, 0f, 1f);

    protected override void Update()
    {
        base.Update();

        transform.Rotate(_rotateDirection * (_rotationSpeed * _slowTimeMultiplier) * Time.deltaTime);
    }
}

using UnityEngine;

public class ControllerEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        MoveInCurrentDirection();
    }

    private void MoveInCurrentDirection()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
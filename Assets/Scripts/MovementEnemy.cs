using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    public Vector3 DirectionMovement;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += DirectionMovement * _speed * Time.deltaTime;
    }
}

using UnityEngine;
using System.Collections;

public class SpawnerEnemies : MonoBehaviour
{
    [SerializeField] private MovementEnemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPositions;

    private Vector3[] _drivingDirections = new Vector3[4] { Vector3.left, Vector3.right, Vector3.forward, Vector3.back };

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void CreateEnemies()
    {
        Instantiate(_enemyPrefab);
    }

    private void SetupEnemy(Vector3 spawnPoint)
    {
        _enemyPrefab.transform.position = spawnPoint;
        _enemyPrefab.GetComponent<MovementEnemy>().DirectionMovement = _drivingDirections[Random.Range(0, _drivingDirections.Length)];
    }

    private IEnumerator SpawnEnemies()
    {
        WaitForSeconds waitTime = new WaitForSeconds(2f);

        while (enabled)
        {
            int randomIndex = Random.Range(0, _spawnPositions.Length);
            Vector3 spawnPosition = new Vector3(_spawnPositions[randomIndex].position.x, 1, _spawnPositions[randomIndex].position.z);
            
            SetupEnemy(spawnPosition);
            CreateEnemies();
            
            yield return waitTime;
        }
    }
}
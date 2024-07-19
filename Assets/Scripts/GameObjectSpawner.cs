using UnityEngine;
using System.Collections;

public class GameObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject _spawnOne;
    [SerializeField] private GameObject _spawnTwo;
    [SerializeField] private GameObject _spawnThree;
    [SerializeField] private GameObject _spawnFour;
    [SerializeField] private Material _material;
    [SerializeField] private int _spawnTime;

    private GameObject[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = new GameObject[4] { _spawnOne, _spawnTwo, _spawnThree, _spawnFour };
        StartCoroutine(SpawnEnemies());
    }

    private void CreateEnemies()
    {
        Instantiate(_enemyPrefab);
    }

    private void SetupEnemyInPosition(GameObject spawn)
    {
        _enemyPrefab.GetComponent<Renderer>().material = _material;
        _enemyPrefab.transform.position = spawn.transform.position;
        _enemyPrefab.transform.rotation = spawn.transform.rotation;
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, _spawnPoints.Length);

            SetupEnemyInPosition(_spawnPoints[randomIndex]);
            CreateEnemies();

            yield return new WaitForSeconds(_spawnTime);
        }
    }
}
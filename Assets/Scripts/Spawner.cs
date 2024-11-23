using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private bool spawn = true;
    
    private Transform[] _spawnPoints;
    private float _duration = 2f;

    private void Awake()
    {
        _spawnPoints = new Transform[transform.childCount];

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _spawnPoints[i] = transform.GetChild(i);
        }
        
        StartCoroutine(SpawnEnemies(_duration));
    }

    private IEnumerator SpawnEnemies(float duration)
    {
        while (spawn)
        {
            int currentPoint = Random.Range(0, _spawnPoints.Length);
        
            Instantiate(_enemyPrefab, _spawnPoints[currentPoint].position, _spawnPoints[currentPoint].localRotation);
        
            yield return new WaitForSeconds(duration);
        }
    }
}

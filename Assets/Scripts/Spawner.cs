using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _timeToSpawn;
    [SerializeField] private GameObject _template;

    private float _elapsedTime;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _timeToSpawn)
        {
            Instantiate(_template, transform.position, transform.rotation);
            _elapsedTime = 0;
        }
    }
}

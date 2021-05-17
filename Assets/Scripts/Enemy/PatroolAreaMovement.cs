using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatroolAreaMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;

    private Transform[] _points;
    private Transform _target;
    private int _currentPointIndex = 0;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        _target = _points[_currentPointIndex];

        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);

        if(transform.position == _target.position)
        {
            _currentPointIndex++;
            if(_currentPointIndex >= _points.Length)
            {
                _currentPointIndex = 0;
            }
        }
    }
}

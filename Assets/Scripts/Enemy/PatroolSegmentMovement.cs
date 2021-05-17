using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PatroolSegmentMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _patroolDistanceX;

    private Vector3[] _points = new Vector3[2];
    private Vector3 _patroolPoint;
    private SpriteRenderer _spriteRenderer;
    private int _currentPoint;
    private Vector3 _startPosition;
    private Vector3 _target;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _startPosition = transform.position;
        _patroolPoint = transform.position + new Vector3(_patroolDistanceX, 0, 0);

        _target = _patroolPoint;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);

        if (transform.position == _patroolPoint)
            ChangeTarget(_startPosition);
        else if (transform.position == _startPosition)
            ChangeTarget(_patroolPoint);
    }

    private void ChangeTarget(Vector3 newTarget)
    {
        _target = newTarget;
        _spriteRenderer.flipX = !_spriteRenderer.flipX;
    }
}

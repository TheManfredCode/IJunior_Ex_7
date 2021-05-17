using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private float _yOffset;

    private void Update()
    {
        float yDelta = Mathf.Lerp(transform.position.y, _target.position.y + _yOffset, _speed * Time.deltaTime);
        Vector3 targetPosition = new Vector3(_target.position.x, yDelta, transform.position.z);

        transform.position = targetPosition;
    }
}

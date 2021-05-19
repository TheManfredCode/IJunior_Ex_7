using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private float _offsetY;

    private void Update()
    {
        float deltaY = Mathf.Lerp(transform.position.y, _target.position.y + _offsetY, _speed * Time.deltaTime);
        Vector3 targetPosition = new Vector3(_target.position.x, deltaY, transform.position.z);

        transform.position = targetPosition;
    }
}

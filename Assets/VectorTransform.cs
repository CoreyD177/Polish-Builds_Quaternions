using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTransform : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private bool _isNormalized;
    [SerializeField] private Quaternion _myRotation;
    [SerializeField] private bool _applyRotation = false;

    private void Update()
    {
        if (_isNormalized)
        {
            Debug.DrawRay(transform.position, _direction.normalized, Color.red);
        }
        else
        {
            Debug.DrawLine(transform.position, _direction, Color.red);
        }
        if (_applyRotation)
        {
            _direction = _myRotation * _direction;
            _applyRotation = false;
        }
    }
}

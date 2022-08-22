using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] Quaternion _rotateQuaternion;
    [SerializeField] Vector3 _rotateEuler;
    Vector3 _oldEuler;
    Quaternion _oldQuaternion;

    private void Start()
    {
        _oldEuler = _rotateEuler;
        _oldQuaternion = _rotateQuaternion;
    }

    private void OnValidate()
    {
        if (_rotateEuler != _oldEuler)
        {
            _rotateQuaternion = Quaternion.Euler(_rotateEuler);
            _oldEuler = _rotateEuler;
        }
        else if (_rotateQuaternion != _oldQuaternion)
        {
            _rotateEuler = _rotateQuaternion.eulerAngles;
            _oldEuler = _rotateEuler;
            _oldQuaternion = _rotateQuaternion;
        }
        transform.rotation = _rotateQuaternion;
    }
}

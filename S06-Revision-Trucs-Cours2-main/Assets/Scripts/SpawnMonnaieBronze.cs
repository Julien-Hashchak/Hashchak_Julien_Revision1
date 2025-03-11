using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonnaieBronze : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;
    void Start()
    {
        Vector3 positionActuel = transform.position;
        Quaternion _rotationActuel = transform.rotation;

        Instantiate(_prefabOriginal, positionActuel, _rotationActuel);
    }
}

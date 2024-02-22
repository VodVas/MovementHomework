using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StareDestinationMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        Vector3 direction = transform.forward;

        transform.position += _speed * Time.deltaTime * direction;
    }
}

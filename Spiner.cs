using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiner : MonoBehaviour
{
    [SerializeField] private float _spinSpeed;

    private void Update()
    {
        transform.Rotate(0, _spinSpeed, 0);
    }
}

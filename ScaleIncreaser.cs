using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleIncreaser : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;
    
    private void Update()
    {
        transform.localScale += new Vector3(_increaseSpeed, _increaseSpeed, _increaseSpeed);
    }
}

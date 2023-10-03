using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float xTilt;
    
    private void Start()
    {
        if (target != null) return;
        target = gameObject.transform;
        Debug.Log("Target não encontrado ou especificado, padronizado para o proprio objeto");
    }
    
    private void Update()
    {
        transform.RotateAround(target.position, new Vector3(xTilt, 1, 0), speed * Time.deltaTime);
    }
}

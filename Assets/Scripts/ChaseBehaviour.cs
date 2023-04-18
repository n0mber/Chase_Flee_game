using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseBehaviour : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;

        if (direction.magnitude < 5f)
        {
            transform.Translate(direction.normalized * Time.deltaTime, Space.World);
            transform.forward = direction.normalized;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeBehaviour : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = transform.position - target.position;

        if(direction.magnitude < 5f)
        {
            transform.Translate(direction.normalized * Time.deltaTime, Space.World);
            transform.forward = direction.normalized;
        }
    }
}

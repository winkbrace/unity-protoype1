using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBus : MonoBehaviour
{
    public GameObject bus;
    private readonly Vector3 offset = new Vector3(0, 8, -8);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame. LateUpdate is called after all the normal updates.
    void LateUpdate()
    {
        transform.position = bus.transform.position + offset;
    }
}

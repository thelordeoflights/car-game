using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset = new Vector3(0,7,-11);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // camera behind bus        
        transform.position = player.transform.position + offset;
    }
}

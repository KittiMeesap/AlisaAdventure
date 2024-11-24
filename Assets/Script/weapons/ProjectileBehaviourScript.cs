using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviourScript : MonoBehaviour
{
    public float destoryafterSec;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,destoryafterSec);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

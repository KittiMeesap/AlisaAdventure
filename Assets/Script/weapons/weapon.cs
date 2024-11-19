using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefad;
    public float damege;
    public float speed;
    public float cooldowmDuration;
    public float currentCooldowm;
    public int pierce;
    protected virtual void Start()
    {
        currentCooldowm = cooldowmDuration;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        currentCooldowm -= Time.deltaTime;
        if (currentCooldowm <= 0f) 
        {
             Attack();
        }
    }

    protected  virtual void Attack()
    {
        currentCooldowm = cooldowmDuration;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float damege;
    
    public float cooldowmDuration;
    public float currentCooldowm;
    public int pierce;
    public Transform WeaponControll;
    public Playercontroll pc;
    
    protected virtual void Start()
    {
        pc = FindObjectOfType<Playercontroll>();
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

using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Arrow : weapon
{
    public GameObject prefad;
    public float speed;
    weapon wp ;
    public float muti ;
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        
    }

    // Update is called once per frame
    protected override void Attack()
    {
        
        base.Attack();
        //Quaternion rotation = new Quaternion(0,0,0,0);
        //rotation = rotation * WeaponControll.rotation;
        for (int i = 0; i < muti; i++)
        {
            GameObject projectile = Instantiate(prefad, WeaponControll.position,WeaponControll.rotation);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(WeaponControll.up * speed,ForceMode2D.Impulse);
        }
    }
}
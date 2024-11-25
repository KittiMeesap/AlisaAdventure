using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : weapon
{
    public GameObject prefad;
    public float speed;
    public float muti=2;
    weapon wp ;
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        
    }

    // Update is called once per frame
    protected override void Attack()
    {
        for (int i = 0; i < muti; i++)
        {
            base.Attack();
        }
        GameObject spwanedKnife = Instantiate(prefad, WeaponControll.position,WeaponControll.rotation );
        Rigidbody2D rb = spwanedKnife.GetComponent<Rigidbody2D>();
        rb.AddForce(WeaponControll.up * speed,ForceMode2D.Impulse);
    }
}
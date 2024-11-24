using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Knife : weapon
{
    public GameObject prefad;
    public float speed;
    weapon wp ;
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        
    }

    // Update is called once per frame
    protected override void Attack()
    {
        base.Attack();
        GameObject spwanedKnife = Instantiate(prefad, WeaponControll.position,WeaponControll.rotation );
        Rigidbody2D rb = spwanedKnife.GetComponent<Rigidbody2D>();
        rb.AddForce(WeaponControll.up * speed,ForceMode2D.Impulse);
    }
}
    

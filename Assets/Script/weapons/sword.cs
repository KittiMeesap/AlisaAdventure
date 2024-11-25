using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : weapon
{
    public GameObject prefad;
    public float size;
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
        GameObject  spwanedSword = Instantiate(prefad);
        Rigidbody2D rb = spwanedSword.GetComponent<Rigidbody2D>();
        spwanedSword.transform.position = transform.position;
        spwanedSword.layer = 20;
        spwanedSword.transform.parent = transform;
        spwanedSword.transform.localScale = new Vector3(size, size, size);
        rb.AddForce(WeaponControll.right * 0,ForceMode2D.Impulse);
        
    }
}

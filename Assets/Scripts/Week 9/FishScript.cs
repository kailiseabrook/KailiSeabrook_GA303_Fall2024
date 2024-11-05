using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : BaseEnemy 
{
    public Transform bulletSpawn;
    public GameObject Bullet;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
      base.Update();
        this.transform.LookAt(player.transform);
        this.transform.Rotate(0, 90, 0);
    }

    protected override void Attack()
    {
        Instantiate(Bullet, bulletSpawn.position, bulletSpawn.rotation);
    }
}

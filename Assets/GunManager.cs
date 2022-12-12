using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    [SerializeField] private GunStatsSO currGun;
    [SerializeField] private GunStatsSO[] guns;

    [SerializeField] private GameObject bullet;

    [SerializeField] private GameObject bulletSpawn;
    private float _nextFire;

    // Start is called before the first frame update
    void Start()
    {
        _nextFire = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && Time.time > _nextFire)
        {
            _nextFire = Time.time + currGun.fireRateS;
            Instantiate(bullet, bulletSpawn.transform.position, transform.rotation);
        }
    }
}

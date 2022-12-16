using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
   [SerializeField] private int _currGun = 0;
    [SerializeField] private GunStatsSO[] guns;

    [SerializeField] private GameObject bullet;

    [SerializeField] private GameObject bulletSpawn;
    private float _nextFire;

    public static GunManager Instance;


    public void IncrementGun()
    {
        if (_currGun + 1 >= guns.Length)
        {
            return;
        }

        _currGun += 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
            return;
        }

        Instance = this;
        _nextFire = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && Time.time > _nextFire)
        {
            _nextFire = Time.time + guns[_currGun].fireRateS;
            Instantiate(bullet, bulletSpawn.transform.position, transform.rotation);
        }
    }
}

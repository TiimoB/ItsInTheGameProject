using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "GunStats", menuName = "Gun Stats")]
public class GunStatsSO : ScriptableObject
{
    public float fireRateS;
    public int damage;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firingbehavior : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform projectileSpawnPoint;

     public void FireProjectile()
    {
        Instantiate(projectile, projectileSpawnPoint.position, Quaternion.identity);
       

        Debug.Log("fired ball");

    }
        


}

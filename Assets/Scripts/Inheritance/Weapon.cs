using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    protected string weaponName;
    protected int weaponStrength;

    protected string WeaponName { get => weaponName; set => weaponName = value; }

    //Protected allows child classes access
    protected virtual void TakeDamage(int damage)
    {
        weaponStrength -= damage;
    }
}

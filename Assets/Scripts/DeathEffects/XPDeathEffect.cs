using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class XPDeathEffect : MonoBehaviour, IDeathEffect {
    public float xpDropped = 25;
    
    public void PerformOn(GameObject hero) {
        hero.GetComponent<HeroScript>().xp += xpDropped;
    }
}

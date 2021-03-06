using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HandleTurn 
{
    public string Attacker; // Saldıranın ismi
    public string Type;
    public GameObject AttackersGameObject; // Kim saldırıyor
    public GameObject AttackersTarget; // Kim saldırıya uğruyor

    // Hangi saldırı gerçekleştirildi
    public BaseAttack choosenAttack;
}

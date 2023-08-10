using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
     void Start()
    {
        Instantiate(GameManager.instance.currentCharacter.prefab, transform.position,
            Quaternion.identity);
    }
}

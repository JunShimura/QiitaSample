using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum CharacterType {　// キャラクターのタイプ
        player, 
        monster, 
        citizen , 
        animal
    }
    /*
    public CharacterType type;
    */
    // Update is called once per frame
    void Update()
    {
        /*
        全タイプの処理がここにある
        */
        Debug.Log("Update on Character");
    }
}

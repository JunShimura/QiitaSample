using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public enum CharacterType {　// キャラクターのタイプ
        player, 
        monster, 
        citizen , 
        animal
    }
    public CharacterType type;

    // Update is called once per frame
    void Update()
    {
        /*
        全タイプの処理がここにある
        */
        //タイプで分かれる処理

        if (type == CharacterType.player)
        {
            //　Playerの処理
        }
        else if (type == CharacterType.monster) {
            //　Monsterの処理
        }
        if (type == CharacterType.citizen|| type== CharacterType.player)
        {
            // 人型の処理
        }
    }
}

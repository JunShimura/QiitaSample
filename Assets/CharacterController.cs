using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public enum CharacterType {�@// �L�����N�^�[�̃^�C�v
        player, 
        monster, 
        citizen , 
        animal
    }
    public CharacterType type;

    // Update is called once per frame
    void Update()
    {
        if (type == CharacterType.player)
        {
            //�@Player�̏���
        }
        else if (type == CharacterType.monster) {
            //�@Monster�̏���
        }
        if (type == CharacterType.citizen|| type== CharacterType.player)
        {
            // �l�^�̏���
        }
    }
}

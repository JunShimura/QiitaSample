using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum CharacterType {�@// �L�����N�^�[�̃^�C�v
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
        �S�^�C�v�̏����������ɂ���
        */
        Debug.Log("Update on Character");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CharacterControllerEx : MonoBehaviour
{
    public enum CharacterType {�@// �L�����N�^�[�̃^�C�v
        player, 
        monster, 
        citizen , 
        animal
    }
    private Action charactorAction=null;
    private CharacterType _characterType;
    public CharacterType type {
        get => _characterType;
        set
        {
            _characterType = value;
            SetAction();
        }
    }
    [SerializeField]CharacterType defaultType = CharacterType.player;
    private void AllAction()
    {
        //�@�S�v���C���[�̏���
        Debug.Log("Action All Character");
    }

    private void PlayerAction()
    {
        //�@�S�v���C���[�̏���
        Debug.Log("Action Player");
    }
    private void MonsterAction()
    {
        //�@�S�v���C���[�̏���
        Debug.Log("Action monster");
    }
    private void HumanAction()
    {
        //�@�S�v���C���[�̏���
        Debug.Log("Action Human");
    }
    private void SetAction()
    {
        charactorAction = AllAction;
        if (type == CharacterType.player)
        {
            //�@Player�̏���
            charactorAction += PlayerAction;
        }
        else if (type == CharacterType.monster)
        {
            //�@Monster�̏���
            charactorAction += MonsterAction;
        }
        if (type == CharacterType.citizen || type == CharacterType.player)
        {
            // �l�^�̏���
            charactorAction += HumanAction;
        }
    }

    private void Awake()
    {
        type = defaultType;
    }
    // Update is called once per frame
    void Update()
    {
        charactorAction();
    }
}

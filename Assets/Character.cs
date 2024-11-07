using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//init enum
public enum CharacterType
{
    Warrior,
    Mage,
    Archer
}

//create SO
[CreateAssetMenu(fileName = "NewCharacterStats", menuName = "Character Stats")]
public class CharacterStats : ScriptableObject
{
    public CharacterType characterType;
    public int health;
    public int attackPower;
    public int defense;
}

public class Character : MonoBehaviour
{
    //ref to SO
    public CharacterStats characterStats;

    //character init
    private void Start()
    {
        if (characterStats == null)
        {
            Debug.LogError("no characterStats assigned");
            return;
        }

        //print stats to console
        Debug.Log($"Character Type: {characterStats.characterType}");
        Debug.Log($"Health: {characterStats.health}");
        Debug.Log($"Attack Power: {characterStats.attackPower}");
        Debug.Log($"Defense: {characterStats.defense}");

        //switch character type in for unique statement
        switch (characterStats.characterType)
        {
            case CharacterType.Warrior:
                Debug.Log("The Warrior charges into battle!");
                break;
            case CharacterType.Mage:
                Debug.Log("The Mage conjures a powerful spell!");
                break;
            case CharacterType.Archer:
                Debug.Log("The Archer takes aim from afar!");
                break;
        }
    }


}

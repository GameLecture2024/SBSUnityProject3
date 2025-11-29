using UnityEngine;

[System.Serializable]
public class PlayerData  // GameObject 컴포넌트로 부착을 할 수 있게 해준다.
{
    public string Name;
    public int MONEY;
    public int ATK;
    public int HP;

    public PlayerData(string name, int money, int atk, int hp)
    {
        Name = name;
        MONEY = money;
        ATK = atk;
        HP = hp;
    }
}
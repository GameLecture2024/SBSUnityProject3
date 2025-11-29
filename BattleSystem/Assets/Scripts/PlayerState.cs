using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public string playerName;
    public int lives;
    public float health;

    private void Start()
    {
        Debug.Log(SaveToString());
    }

    public string SaveToString()
    {
        return JsonUtility.ToJson(this);
    }

    // Given:
    // playerName = "Dr Charles"
    // lives = 3
    // health = 0.8f
    // SaveToString returns:
    // {"playerName":"Dr Charles","lives":3,"health":0.8}
}
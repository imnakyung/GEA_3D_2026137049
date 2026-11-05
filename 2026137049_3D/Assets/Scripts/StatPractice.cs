using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName;
    public int level;
    public float attack = 12.5f; 
    public bool isBoss;

    [ContextMenu("스탯")]
    public void ShowStat()
    {
        Debug.Log("플레이어 이름 : " + playerName);
        Debug.Log("레벨 : " + level);
        Debug.Log("공격력 : " + attack);
        Debug.Log("보스 여부 : " + isBoss);
    }
}


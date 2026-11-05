using UnityEngine;

public class HpPractice : MonoBehaviour
{
    // 유니티 인스펙터 창에서 조절할 수 있도록 변수를 선언해 줍니다.
    public int currentHp = 7;
    public int maxHp = 10;

    [ContextMenu("체력")]
    void PrintHp()
    {
        int a = (int)((float)currentHp / maxHp * 100);
        Debug.Log("HP " + a + "%");
    }
}
 
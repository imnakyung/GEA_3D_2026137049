using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    // 과제 요구사항 필드 선언 및 초기값 할당
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;

    public float expRate = 1.5f;

    // [ContextMenu("정산")] 함수 Settle 생성
    [ContextMenu("정산")]
    public void Settle()
    {
        // 1. 플레이 시간 계산 (ToString 없이 /, % 연산만 사용, 두 자리 형식 맞춤)
        int hours = playSeconds / 3600;
        int minutes = (playSeconds % 3600) / 60;
        int seconds = playSeconds % 60;
        
        // 두 자리 형식을 맞추기 위해 10보다 작으면 앞에 "0"을 붙여서 문자열로 합성
        string strHours = hours.ToString(); 
        string strMinutes = (minutes < 10) ? "0" + minutes : minutes.ToString();
        string strSeconds = (seconds < 10) ? "0" + seconds : seconds.ToString();
        
        Debug.Log("플레이 시간 " + strHours + ":" + strMinutes + ":" + strSeconds);

        // 2. 골드 분배 계산 (1인당 골드, 남은 골드는 리더 보너스)
        int goldPerMember = gold / members;
        int leaderBonus = gold % members;
        Debug.Log("1인당 " + goldPerMember + "G, 리더 보너스 " + leaderBonus + "G");

        // 3. 경험치 계산 (기본 경험치, 배율을 곱한 최종 경험치 소수점 버림)
        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);
        Debug.Log("경험치 " + finalExp + " (기본 " + baseExp + ")");

        // 4. 레벨 계산 (레벨마다 100 필요, 레벨은 1부터 시작)
        int level = (finalExp / 100) + 1;
        int nextExp = 100 - (finalExp % 100);
        Debug.Log("Lv " + level + ", 다음 레벨까지 " + nextExp);

        // 5. 평균 데미지 계산 (소수점까지 출력하기 위해 float 형변환 사용)
        float avgDamage = (float)totalDamage / hits;
        Debug.Log("평균 데미지 " + avgDamage);
    }
}


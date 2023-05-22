using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles; // 장애물 오브젝트들
    private bool stepped = false; // 플레이어 캐릭터가 밟았는가

    // 컴포넌트가 활성화될 때마다 매번 실행되는 메서드
    private void OnEnable()
    {
        // 발판을 리셋하는 처리
    }

    void OnCollisionEnter2D()
    {
        // 플레이어 캐릭터가 자신을 밟았을 때 점수를 추가하는 처리
    }
}

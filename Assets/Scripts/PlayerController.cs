
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int hp = 100;

    // 게임 시작 시 한 번 실행
    void Start()
    {
        Debug.Log("게임 시작!");
        Debug.Log("플레이어 체력: " + hp);
    }

    // 매 프레임 실행
    void Update()
    {
        // 체력이 0이면 입력 처리 중단
        if (hp == 0)
        {
            return;
        }

        // D 키를 누르면 데미지 10
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D 키 입력 감지!");
            TakeDamage(10);
        }
    }

    // 데미지를 받는 메서드
    void TakeDamage(int damage)
    {
        // 이미 체력이 0이면 추가 데미지 방지
        if (hp == 0)
        {
            return;
        }

        hp -= damage;

        // 체력이 음수가 되지 않도록 처리
        if (hp < 0)
        {
            hp = 0;
        }

        Debug.Log("현재 체력: " + hp);

        // 체력이 0이면 게임 오버
        if (hp == 0)
        {
            Debug.Log("게임 오버!");
        }
    }
}
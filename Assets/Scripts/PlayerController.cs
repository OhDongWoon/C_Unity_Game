
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerStats stats;

    // 플레이어 이동 속도
    public float moveSpeed = 5f;

    void Start()
    {
        stats = new PlayerStats(100);

        Debug.Log("게임 시작!");
        Debug.Log("현재 체력: " + stats.GetHP());
    }

    void Update()
    {
        // 좌우 이동
        float moveX = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveX = -1f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveX = 1f;
        }

        // 실제 위치 변경
        transform.position +=
            new Vector3(moveX, 0f, 0f)
            * moveSpeed * Time.deltaTime;

        // 기존 체력 감소 기능
        if (stats.IsDead())
            return;

        if (Input.GetKeyDown(KeyCode.D))
        {
            stats.TakeDamage(10);

            Debug.Log("현재 체력: " + stats.GetHP());

            if (stats.IsDead())
            {
                Debug.Log("게임 오버!");
            }
        }
    }
}
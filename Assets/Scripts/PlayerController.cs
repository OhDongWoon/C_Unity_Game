
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerStats stats;

    void Start()
    {
        stats = new PlayerStats(100);

        Debug.Log("게임 시작!");
        Debug.Log("현재 체력: " + stats.GetHP());
    }

    void Update()
    {
        if (stats.IsDead())
            return;

        if (Input.GetKeyDown(KeyCode.D))
        {
            stats.TakeDamage(10);

            Debug.Log("D 키 입력 감지!");
            Debug.Log("현재 체력: " + stats.GetHP());

            if (stats.IsDead())
            {
                Debug.Log("게임 오버!");
            }
        }
    }
}
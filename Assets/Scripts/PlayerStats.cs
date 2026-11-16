
public class PlayerStats
{
    private int hp;

    // 생성자에서 초기 체력 설정
    public PlayerStats(int initialHP)
    {
        hp = initialHP;
    }

    public void TakeDamage(int damage)
    {
        if (hp <= 0 || damage <= 0)
            return;

        hp -= damage;

        if (hp < 0)
            hp = 0;
    }

    public int GetHP()
    {
        return hp;
    }

    // 플레이어 사망 여부 bool로 반환
    public bool IsDead()
    {
        return hp <= 0;
    }
}

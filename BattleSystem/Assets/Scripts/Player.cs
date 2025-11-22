using UnityEngine;

public class Player : Entity
{
    private int Money;
    public int GetMoney() => Money;
    public int SetMoney(int value) => Money = value;

    // 업그레이드 비용이 레벨업 마다 증가하게 만들고 싶다. => 현재 레벨, 레벨 당 비용, 레벨 증가 수치

    const int HealPrice = 30;
    const int UpgradeHPPrice = 50;
    const int UpgradeAtkPrice = 5;

    protected override void Dead()
    {
        base.Dead();

        Debug.Log("Player가 사망했습니다.");
    }

    private bool CanBuy(int price)
    {
        if (Money < price)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void UpgradeHP(int amount)
    {
        if (CanBuy(UpgradeHPPrice) == false) return;

        SetMaxHP( GetMaxHP() + amount);

        Money -= UpgradeHPPrice;
    }

    public void HealHP(int amount)
    {
        if (CanBuy(HealPrice) == false) return;

        // 최대 체력보다 더 많은 수치를 증가시키면 넘어가요.
        int healAmount = GetHP() + amount;
        if( healAmount > GetMaxHP())
        {
            healAmount = GetMaxHP();
        }

        SetHP(healAmount);

        Money -= HealPrice;
    }

    public void UpgradeATK(int amount)
    {
        if (CanBuy(UpgradeAtkPrice) == false) return;

        SetAttackPower(GetAttackPower() + amount);

        Money -= UpgradeAtkPrice;
    }
}

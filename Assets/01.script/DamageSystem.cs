using DG.Tweening;
using System.Collections;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    [SerializeField] private Knife knife;
    private void OnEnable()
    {
        ActionSystem.AttachPerformer<DealDamageGA>(DealDamagePerformer);
    }
    void OnDisable()
    {
        ActionSystem.DetachPerformer<DealDamageGA>();
    }
    private IEnumerator DealDamagePerformer(DealDamageGA dealDamageGA)
    {
        int damageAmount = dealDamageGA.Amount;
        Vector2 knifeStart = knife.transform.position;
        Tween tween = knife.transform.DOMove(health.transform.position, 0.25f);
        yield return tween.WaitForCompletion();
        knife.transform.DOMove(knifeStart, 0.5f);
        yield return health.ReduceHealth(damageAmount);
    }
}

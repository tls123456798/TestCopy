using TMPro;
using UnityEngine;

public class CardView : MonoBehaviour
{
    [SerializeField] private TMP_Text title; // 카드의 스킬 이름 텍스트
    [SerializeField] private TMP_Text description; // 카드 효과 설명 텍스트
    [SerializeField] private TMP_Text mana; // 사용하는 마나(코스트) 양 텍스트
    [SerializeField] private SpriteRenderer imageSR; // 카드의 이미지
    [SerializeField] private GameObject wrapper;
    public Card Card {  get; private set; }
    public void Setup(Card card)
    {
        Card = card;
        title.text = card.Title;
        description.text = card.Description;
        mana.text = card.Mana.ToString();
        imageSR.sprite = card.Image;

    }
    private void OnMouseEnter()
    {
        wrapper.SetActive(false);
        Vector3 pos = new(transform.position.x, -2, 0);
        CardViewHoverSystem.Instance.Show(Card, pos);
    }
    private void OnMouseExit()
    {
        CardViewHoverSystem.Instance.Hide();
        wrapper.SetActive(true);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    private float hp = 100.0f;
    public AudioSource audio;
    public AudioClip hurt;
    public Text text_hpValue;

    private void Start()
    {
        hp = 100;
        text_hpValue.text = "" + 100;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "bullet")
        {
            damage(10);
        }
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="value">受到的傷害</param>
    private void damage(float value)
    {
        audio.PlayOneShot(hurt);
        hp -= value;

        if (hp <= 0)
        {
            Destroy(gameObject, 0);
        }
        displayCurHp();
    }

    /// <summary>
    /// 顯示目前血量
    /// </summary>
    private void displayCurHp()
    {
        text_hpValue.text = "" + hp;
    }
    #endregion
}

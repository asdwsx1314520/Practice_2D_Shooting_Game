using UnityEngine;
using UnityEngine.EventSystems;

public class White : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    public Transform bullet;
    public Transform tag_bullet;

    public AudioSource audio;
    public AudioClip shooting;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audio.PlayOneShot(shooting);
            Instantiate(bullet, tag_bullet.position, tag_bullet.rotation);
        }
    }
    #endregion

    #region KID 區域 - 不要偷看 @3@
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 1.5f;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        rig.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * speed);
    }
    #endregion
}

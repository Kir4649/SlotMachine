using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject Reel;
    public GameObject Reel2;//スロットのリールを取得
    public GameObject Reel3;

    Vector3 initialpos;   
    Vector3 initialpos2;//初期位置 
    Vector3 initialpos3;

    float speed1;
    float speed2;//リールの
    float speed3;
    

    private void Awake()
    {
        initialpos = this.Reel.transform.position;//初期位置を取得  
        initialpos2 = this.Reel2.transform.position;
        initialpos3 = this.Reel3.transform.position;

        speed1 = -0.1f;
        speed2 = -0.1f;//回転速度
        speed3 = -0.1f;
    }
   
    void Update()
    {
        this.Reel.transform.Translate(0, speed1, 0);//リールを下に回転させる   
        this.Reel2.transform.Translate(0, speed2, 0);
        this.Reel3.transform.Translate(0, speed3, 0);

        if(Reel.transform.position.y < -7f)//リールが下に行ったら
        {
            this.Reel.transform.position = initialpos;//初期化する
        }
        if (Reel2.transform.position.y < -7f)
        {
            this.Reel2.transform.position = initialpos2;
        }
        if (Reel3.transform.position.y < -7f)
        {
            this.Reel3.transform.position = initialpos3;
        }
    }
    public void stopReel()
    {
        speed1 = 0;
    }
    public void stopReel2()
    {
        speed2 = 0;
    }
    public void stopReel3()
    {
        speed3 = 0;
    }
}

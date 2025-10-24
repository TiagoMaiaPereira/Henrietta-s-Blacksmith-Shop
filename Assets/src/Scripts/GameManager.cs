using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton
    public static GameManager instance {get; private set;}

    //UI display values
    public int dayCount = 1;
    public int money = 0;

    //Serialized Fields
    [SerializeField] private TextMeshProUGUI dayCountText;
    [SerializeField] private TextMeshProUGUI moneyText;


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(instance);

        dayCountText.text = dayCount.ToString();
        moneyText.text = money.ToString();
    }
}

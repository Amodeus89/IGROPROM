using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TextFade : MonoBehaviour
{
    private Text txt;
    private Outline Oline;
    private void Start()
    {
        txt = GetComponent<Text>();
        Oline = GetComponent<Outline>();
    }
    private void Update()
    {
        txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, Mathf.PingPong(Time.time, 1.0f));
        Oline.effectColor = new Color(Oline.effectColor.r, Oline.effectColor.g,
                                      Oline.effectColor.b,
                                      txt.color.a - 0.3f);
    }
}
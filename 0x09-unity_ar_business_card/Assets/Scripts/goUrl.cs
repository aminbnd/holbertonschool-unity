using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goUrl : MonoBehaviour
{
    public void ToGithub() {
        Application.OpenURL ("https://github.com/aminbnd");
    }
    public void ToTwitter() {
        Application.OpenURL ("https://twitter.com/AminBondi");
    }
    public void ToMail() {
        Application.OpenURL ("mailto:2212@holbertonschool.com");
    }
    public void ToLinkedin() {
        Application.OpenURL ("https://www.linkedin.com/in/mohamed-amine-bondi-67bb1b171/");
    }
}

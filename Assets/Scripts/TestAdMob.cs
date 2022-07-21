    using System;
    using UnityEngine;
    using UnityEngine.UI;

    public class TestAdMob :MonoBehaviour
    {
        public Button btn1;

        private void Start()
        {
            btn1.onClick.AddListener(OnClickButton1);
        }

        private void OnClickButton1()
        {
            AdMobManager.Instance.RequestAndLoadRewardedAd();
        }
    }

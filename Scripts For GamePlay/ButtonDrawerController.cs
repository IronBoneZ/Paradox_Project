using UnityEngine;
using System.Collections;

namespace AdventurePuzzleKit
{
    public class ButtonDrawerController : MonoBehaviour
    {
        [Header("Dresser Object")]
        [SerializeField] private Animator doorAnim = null;

        [SerializeField] private bool drawerOpen = false;

        [Header("Dresser Animation Names")]
        [SerializeField] private string openAnimationName = "DresserOpen";
        [SerializeField] private string closeAnimationName = "DresserClose";

        [Header("Sounds")]
        [SerializeField] private string doorOpenSound = "OpenDresserSound";
        [SerializeField] private string doorCloseSound = "CloseDresserSound";

        [Header("Pause Timer")]
        [SerializeField] private int waitTimer = 1;
        private bool pauseInteraction = false;

         [SerializeField] private GameObject Tigger = null;

        [SerializeField] private GameObject Dummy = null;

        void Start()
        {
            Tigger.gameObject.SetActive(false);
            Dummy.gameObject.SetActive(true);
        }

        private IEnumerator PauseDoorInteraction()
        {
            pauseInteraction = true;
            yield return new WaitForSeconds(waitTimer);
            pauseInteraction = false;

        }

        public void PlayAnimation()
        {
            if (!drawerOpen && !pauseInteraction)
            {
                doorAnim.Play(openAnimationName, 0, 0.0f);
                drawerOpen = true;
                Tigger.gameObject.SetActive(true);
                Dummy.gameObject.SetActive(false);
                AKAudioManager.instance.Play(doorOpenSound);
                StartCoroutine(PauseDoorInteraction());
            }

            else if (drawerOpen && !pauseInteraction)
            {
                doorAnim.Play(closeAnimationName, 0, 0.0f);
                drawerOpen = false;
                
                
                AKAudioManager.instance.Play(doorCloseSound);
                StartCoroutine(PauseDoorInteraction());
            }
        }
    }
}

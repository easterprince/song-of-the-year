using UnityEngine;

namespace SongOfTheYear {

    public abstract class AbstractScreen : MonoBehaviour {

        public void Show() {
            gameObject.SetActive(true);
        }

        public void Hide() {
            gameObject.SetActive(false);
        }
    }
}
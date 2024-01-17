using UnityEngine;

namespace SongOfTheYear {

    public class ProgramManager : MonoBehaviour {

        [SerializeField]
        private PreparationScreen _preparationScreen;

        [SerializeField]
        private RankingsScreen _rankingsScreen;

        private bool _started = false;

        private void Update() {
            if (!_started) {
                _started = true;
                _preparationScreen.Show();
            }
        }
    }
}
using UnityEngine;

namespace RPG.Saving
{
    [ExecuteAlways]
    public class SaveableEntity : MonoBehaviour
    {

        [SerializeField] string uniqueIdentifier = "";
        
        public string GetUniqueIdentifier()
        {
            return (string)uniqueIdentifier;
        }

        public object CaptureState()
        {
            print("capturing state for " + GetUniqueIdentifier());
            return null;
        }

        public void RestoreState(object state)
        {
            print("Restoring state for " + GetUniqueIdentifier());
        }
        private void Update() {
            if (Application.IsPlaying(gameObject)) return;
            print("Editing");
        }
    }
}
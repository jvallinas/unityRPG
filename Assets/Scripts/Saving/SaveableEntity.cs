using UnityEngine;

namespace RPG.Saving
{
    public class SaveableEntity : MonoBehaviour
    {
        public string GetUniqueIdentifier()
        {
            return (string) gameObject.name;
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
    }
}
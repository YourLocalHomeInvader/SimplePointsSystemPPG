using UnityEngine; 
using System.Collections;
namespace Points
{
    public class Points
    {
        public static void Main()
        { 
            var Points = 0f; //Starting Amount
            ModAPI.OnDeath += (sender, life) => { //Start on Death
                Points += 25; //Amount of Points
                ModAPI.Notify("<color=green>" + "+25 Points. " + "\n <color=orange>" + "Score: " + "<color=yellow>" + Mathf.Round(Points * 10) / 10); //Message that will appear
            };

            ModAPI.OnItemSpawned += (sender, args) => { //Start on Item Spawned
                Points += 1; //Amount of Points
                ModAPI.Notify("<color=green>" + "+1 Point. " + "\n <color=orange>" + "Score: " + "<color=yellow>" + Mathf.Round(Points * 10) / 10); //Message that will appear
	    };
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneProfile : MonoBehaviour
{
    //SwingRate, WhiffRate, Whiffs/Swing, Groundballs, Linedrives, Flyballs, Popups, BA, Slg, ISO, BABIP, HR/BIP
    private Dictionary<int, string> ZONE_PROFILE_TYPE = new Dictionary<int, string>()
    {
        {0, "Swing Rate" },
        {1, "Whiff Rate" },
        {2, "Whiffs per Swing" },
        {3, "Groundballs" },
        {4, "Linedrives" },
        {5, "Flyballs" },
        {6, "Popups" },
        {7, "BA" },
        {8, "SLG" },
        {9, "ISO" },
        {10, "BABIP" },
        {11, "HR per BIP" }
    };

    //ZoneProfile Constructor takes type, team, batter and all 25 bins are populated from "DB"

    //ChangeType method called when new Zone Profile Type selected, repopulates all 25 bins and recolors heatmap accordingly

}
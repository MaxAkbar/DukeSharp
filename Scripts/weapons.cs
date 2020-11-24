﻿public partial class ConScript
{
    public void DisplayPistol(int weapon_xoffset, int look_ang, int looking_arc, int kickback_pic, int gun_pos, sbyte gs, char o, int pal)
    {
        if (kickback_pic < 5)
        {
            short[] kb_frames = { 0, 1, 2, 0, 0 };
            short l;

            l = (short)(195 - 12 + weapon_xoffset);

            if (kickback_pic == 2)
            {
                l -= 3;
            }
            traps.myospal((l - (look_ang >> 1)), (looking_arc + 244 - gun_pos), FIRSTGUN + kb_frames[kickback_pic], gs, 2, pal);
        }
        else
        {
            if (kickback_pic < 10)
            {
                traps.myospal(194 - (look_ang >> 1), looking_arc + 230 - gun_pos, FIRSTGUN + 4, gs, o, pal);
            }
            else if (kickback_pic < 15)
            {
                traps.myospal(244 - (kickback_pic << 3) - (look_ang >> 1), looking_arc + 130 - gun_pos + (kickback_pic << 4), FIRSTGUN + 6, gs, o, pal);
                traps.myospal(224 - (look_ang >> 1), looking_arc + 220 - gun_pos, FIRSTGUN + 5, gs, o, pal);
            }
            else if (kickback_pic < 20)
            {
                traps.myospal(124 + (kickback_pic << 1) - (look_ang >> 1), looking_arc + 430 - gun_pos - (kickback_pic << 3), FIRSTGUN + 6, gs, o, pal);
                traps.myospal(224 - (look_ang >> 1), looking_arc + 220 - gun_pos, FIRSTGUN + 5, gs, o, pal);
            }
            else if (kickback_pic < 23)
            {
                traps.myospal(184 - (look_ang >> 1), looking_arc + 235 - gun_pos, FIRSTGUN + 8, gs, o, pal);
                traps.myospal(224 - (look_ang >> 1), looking_arc + 210 - gun_pos, FIRSTGUN + 5, gs, o, pal);
            }
            else if (kickback_pic < 25)
            {
                traps.myospal(164 - (look_ang >> 1), looking_arc + 245 - gun_pos, FIRSTGUN + 8, gs, o, pal);
                traps.myospal(224 - (look_ang >> 1), looking_arc + 220 - gun_pos, FIRSTGUN + 5, gs, o, pal);
            }
            else if (kickback_pic < 27)
            {
                traps.myospal(194 - (look_ang >> 1), looking_arc + 235 - gun_pos, FIRSTGUN + 5, gs, o, pal);
            }
        }
    }
}
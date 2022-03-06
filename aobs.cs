using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrainers
{
    internal class aobs
    {

        //The Hunter Call Of The Wild
        public const string OneHitKill_aob = "0F 28 C8 F3 43 0F 59 4C 10 0C";
        public const string OneHitKill_Org = "0F 28 CA F3 43 0F 59 4C 02 0C";
        public const string ScaredNoMove_aob = "B0 01 48 8B 4D F8 48 33 CC E8 66";
        public const string ScaredNoMove_Org = "B0 00 48 8B 4D F8 48 33 CC E8 66";
        public const string KeenEyeTimer_aob = "0F 82 ? ? ? ? 4C 8B 05 ? ? ? ? 33";
        public const string KeenEyeTimer_Org = "0F 82 ? ? ? ? 4C 8B 05 ? ? ? ? 33";
        public const string KeenEyeDistance_aob = "C3 CC CC CC CC CC CC CC CC 48 83 EC 28 80 79 3C 00 74 27 44 8B 49 34";
        public const string KeenEyeDistance_Org = "C3 CC CC CC CC CC CC CC CC 48 83 EC 28 80 79 3C 00 74 27 44 8B 49 34";

        // Just Die Already
        public const string infAmmo_Org = "89 8B B8 00 00 00 80 B8";
        public const string infAmmo_aob = "C7 83 B8 00 00 00 03 00";

        //Greak Memories Of Azur
        public const string invibleAoB_Org = "55 48 8B EC 48 81 EC 50 02";
        public const string invibleAoB_aob = "C3 55 48 8B EC 48 81 EC 50";

        //Drup Dealer Simulator

        //Greak Memories Of Azur
        public const string greakOneHitKill_aob = "";
        public const string greakOneHitKill_Org = "";
        public const string greakHealth_aob = "";
        public const string greakMana_Org = "";
        public const string greakMana_aob = "";
        public const string greakHealth_Org = "";
        public const string greakArrows_aob = "";
        public const string greakArrows_Org = "";
        public const string greakMoney_aob = "";
        public const string greakMoney_Org = "";
        public const string greakJump_aob = "C6 86 A2 03 00 00 01 48 8B 46";
        public const string greakJump_Org = "C6 86 A2 03 00 00 00";
        public const string greakInvincible_aob = "";
        public const string greakInvincible_Org = "00 00 00 00 00 00 00 00 00 55 48 8B EC 48 81 EC 50 02 00 00 48 89 5D";

    }
}

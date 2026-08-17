using System;
using System.Collections.Generic;
using System.Text;

namespace BerryAP.Mappings
{
    class PropMapping
    {
        public static Dictionary<int, (int itemid, string internal_name, string ap_name)> mapping = new Dictionary<int, (int itemid, string internal_name, string ap_name)>
        {
            /// Mapping the consumable props. Format is  Zone (AP ID, Internal Name, AP Name)

            /// Area 1 (26)

            /// Area 1 - Speech Bubbles
            {0, (1001, "PickUp_SpeechBubble_Basic Controls and throwing - INCLUDE WITH MILESTONE", "Speech Bubble - Basic Controls") },
            {1, (1002, "PickUp_SpeechBubble_ Broom- INCLUDE WITH MILESTONE", "Test") },
            {2, (1003, "PickUp_SpeechBubble Hole Move Tutorial INCLUDE WITH MILESTONE", "Test") },
            {3, (1004, "PickUp_SpeechBubble_Hammer- INCLUDE WITH MILESTONE", "Test") },
            {4, (1005, "PickUp_SpeechBubble Berry Blitz Ability - INCLUDE WITH MILESTONE", "Test") },
            {5, (1006, "PickUp_SpeechBubble_Bubble - INCLUDE WITH MILESTONE", "Test") },
            {6, (1007, "PickUp_SpeechBubble_Tutorial - NOT included in *m*i*l*e*s*t*o*n*e*s", "Test") },
            {7, (1008, "PickUp_SpeechBubble_Tutorial - NOT included in *m*i*l*e*s*t*o*n*e*s (2)", "Test") },
            {8, (1009, "PickUp_SpeechBubble_StarPipe - INCLUDE WITH MILESTONE", "Test") },
            {9, (1010, "PickUp_SpeechBubble_Chainsaw- INCLUDE WITH MILESTONE", "Test") },
            {10, (1011, "PickUp_SpeechBubble Popgun Tutorial INCLUDE WITH MILESTONE", "Test") },
            {11, (1012, "PickUp_SpeechBubble_SunBeamTimer - INCLUDE WITH MILESTONE", "Test") },
            {12, (1013, "PickUp_SpeechBubble Big Hole Ability - INCLUDE WITH MILESTONE (1)", "Test") },
            {13, (1014, "PickUp_SpeechBubble_StarWand - INCLUDE WITH MILESTONE", "Test") },
            {14, (1015, "PickUp_SpeechBubble_ Vacuum - INCLUDE WITH MILESTONE", "Speech Bubble - Vaccuum") },
            {15, (1016, "PickUp_SpeechBubble_StarWand - INCLUDE WITH MILESTONE", "Test") },
            {16, (1017, "PickUp_SpeechBubble_SunBeamTimer - INCLUDE WITH MILESTONE", "Test") },
            {17, (1018, "PickUp_SpeechBubble Berry Blitz Ability - INCLUDE WITH MILESTONE", "Test") },
            {18, (1019, "PickUp_SpeechBubble Popgun Tutorial INCLUDE WITH MILESTONE", "Test") },

            /// Area 1 - Gnomes (5)
            {2, (102, "Milestone_Gnome1 (1)", "Test") },
            {2, (102, "Milestone_Gnome1 (2)", "Test") },
            {2, (102, "Milestone_Gnome2 (1)", "Test") },
            {2, (102, "Milestone_Gnome2 (2)", "Test") },
            {2, (102, "Milestone_Gnome3 (1)", "Test") },

            /// Area 1 - Rocks (5)
            {2, (102, "Milestone_Rock2 (1)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock2 With Hole Move Tut X", "Rock [1,2]") },
            {2, (102, "Milestone_Rock6 (1)", "Rock [1,3]") },
            {2, (102, "Milestone_Rock6 (2)", "Rock [1,3]") },
            {2, (102, "Milestone_Rock7 (1)", "Rock [1,1]") },

            /// Area 1 - Plant Pots (9)
            {2, (102, "Milestone_PlantPot (2)", "Test") },
            {2, (102, "Milestone_PlantPot (3)", "Test") },
            {2, (102, "Milestone_PlantPot (4)", "Test") },
            {2, (102, "Milestone_PlantPot (113)", "Test") },
            {2, (102, "Milestone_PlantPot (114)", "Test") },
            {2, (102, "Milestone_PlantPot (115)", "Test") },
            {2, (102, "Milestone_PlantPot (116)", "Test") },
            {2, (102, "Milestone_PlantPot (117)", "Test") },
            {2, (102, "Milestone_PlantPot (118)", "Test") },

            /// Area 1 - Flamingos (2)
            {2, (102, "Milestone_Flamingo (21)", "Test") },
            {2, (102, "Milestone_Flamingo (56)", "Test") },

            /// Area 1 - Watering Can (1)
            {2, (102, "Milestone_WateringCan (1)", "Test") },

            /// Area 1 - Patio Chair (2)
            {2, (102, "Milestone_PatioChair Blue (1)", "Test") },
            {2, (102, "Milestone_PatioChair Green (1)", "Test") },

            /// Area 1 - Bug Zapper (1)
            {2, (102, "Milestone_BugZapper (1)", "Test") },

            /// Area 1 - Trellis (1)
            {2, (102, "Milestone_Trellis (1)", "Test") },

            /// AREA 2 (167)

            /// Area 2 - Gnomes (24)
            {2, (102, "Milestone_Gnome1 (3)", "Test") },
            {2, (102, "Milestone_Gnome1 (4)", "Test") },
            {2, (102, "Milestone_Gnome1 (6)", "Test") },
            {2, (102, "Milestone_Gnome1 (7)", "Test") },
            {2, (102, "Milestone_Gnome1 (8)", "Test") },
            {2, (102, "Milestone_Gnome1 (9)", "Test") },
            {2, (102, "Milestone_Gnome1 (10)", "Test") },
            {2, (102, "Milestone_Gnome2 (3)", "Test") },
            {2, (102, "Milestone_Gnome2 (4)", "Test") },
            {2, (102, "Milestone_Gnome2 (5)", "Test") },
            {2, (102, "Milestone_Gnome2 (6)", "Test") },
            {2, (102, "Milestone_Gnome2 (7)", "Test") },
            {2, (102, "Milestone_Gnome2 (8)", "Test") },
            {2, (102, "Milestone_Gnome2 (9)", "Test") },
            {2, (102, "Milestone_Gnome3 (4)", "Test") },
            {2, (102, "Milestone_Gnome3 (5)", "Test") },
            {2, (102, "Milestone_Gnome3 (6)", "Test") },
            {2, (102, "Milestone_Gnome3 (7)", "Test") },
            {2, (102, "Milestone_Gnome3 (8)", "Test") },
            {2, (102, "Milestone_Gnome2 (10)", "Test") },
            {2, (102, "Milestone_Gnome2 (11)", "Test") },
            {2, (102, "Milestone_Gnome2 (12)", "Test") },
            {2, (102, "Milestone_Gnome2 (13)", "Test") },
            {2, (102, "Milestone_Gnome2 (14)", "Test") },
            {2, (102, "Milestone_Gnome2 (15)", "Test") },

            /// Area 2 - Rocks (16)
            {2, (102, "Milestone_Rock1 (1)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock1 (2)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock1 (3)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock1 (4)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock1 (5)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock2 (4)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock3 (1)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock3 (2)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock3 (3)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock3 (4)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock3 (5)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock3 (9)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock3 (10)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock5 (2)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock5 (3)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock7 (2)", "Rock [1,2]") },

            /// Area 2 - Plant Pots (61)
            {2, (102, "Milestone_PlantPot (5)", "Test") },
            {2, (102, "Milestone_PlantPot (6)", "Test") },
            {2, (102, "Milestone_PlantPot (7)", "Test") },
            {2, (102, "Milestone_PlantPot (8)", "Test") },
            {2, (102, "Milestone_PlantPot (9)", "Test") },
            {2, (102, "Milestone_PlantPot (10)", "Test") },
            {2, (102, "Milestone_PlantPot (11)", "Test") },
            {2, (102, "Milestone_PlantPot (12)", "Test") },
            {2, (102, "Milestone_PlantPot (58)", "Test") },
            {2, (102, "Milestone_PlantPot (59)", "Test") },
            {2, (102, "Milestone_PlantPot (60)", "Test") },
            {2, (102, "Milestone_PlantPot (61)", "Test") },
            {2, (102, "Milestone_PlantPot (62)", "Test") },
            {2, (102, "Milestone_PlantPot (63)", "Test") },
            {2, (102, "Milestone_PlantPot (64)", "Test") },
            {2, (102, "Milestone_PlantPot (65)", "Test") },
            {2, (102, "Milestone_PlantPot (66)", "Test") },
            {2, (102, "Milestone_PlantPot (67)", "Test") },
            {2, (102, "Milestone_PlantPot (68)", "Test") },
            {2, (102, "Milestone_PlantPot (69)", "Test") },
            {2, (102, "Milestone_PlantPot (70)", "Test") },
            {2, (102, "Milestone_PlantPot (71)", "Test") },
            {2, (102, "Milestone_PlantPot (72)", "Test") },
            {2, (102, "Milestone_PlantPot (73)", "Test") },
            {2, (102, "Milestone_PlantPot (74)", "Test") },
            {2, (102, "Milestone_PlantPot (75)", "Test") },
            {2, (102, "Milestone_PlantPot (76)", "Test") },
            {2, (102, "Milestone_PlantPot (77)", "Test") },
            {2, (102, "Milestone_PlantPot (78)", "Test") },
            {2, (102, "Milestone_PlantPot (79)", "Test") },
            {2, (102, "Milestone_PlantPot (80)", "Test") },
            {2, (102, "Milestone_PlantPot (81)", "Test") },
            {2, (102, "Milestone_PlantPot (82)", "Test") },
            {2, (102, "Milestone_PlantPot (83)", "Test") },
            {2, (102, "Milestone_PlantPot (84)", "Test") },
            {2, (102, "Milestone_PlantPot (85)", "Test") },
            {2, (102, "Milestone_PlantPot (86)", "Test") },
            {2, (102, "Milestone_PlantPot (87)", "Test") },
            {2, (102, "Milestone_PlantPot (88)", "Test") },
            {2, (102, "Milestone_PlantPot (89)", "Test") },
            {2, (102, "Milestone_PlantPot (90)", "Test") },
            {2, (102, "Milestone_PlantPot (91)", "Test") },
            {2, (102, "Milestone_PlantPot (92)", "Test") },
            {2, (102, "Milestone_PlantPot (93)", "Test") },
            {2, (102, "Milestone_PlantPot (94)", "Test") },
            {2, (102, "Milestone_PlantPot (95)", "Test") },
            {2, (102, "Milestone_PlantPot (96)", "Test") },
            {2, (102, "Milestone_PlantPot (97)", "Test") },
            {2, (102, "Milestone_PlantPot (98)", "Test") },
            {2, (102, "Milestone_PlantPot (99)", "Test") },
            {2, (102, "Milestone_PlantPot (100)", "Test") },
            {2, (102, "Milestone_PlantPot (101)", "Test") },
            {2, (102, "Milestone_PlantPot (102)", "Test") },
            {2, (102, "Milestone_PlantPot (103)", "Test") },
            {2, (102, "Milestone_PlantPot (104)", "Test") },
            {2, (102, "Milestone_PlantPot (105)", "Test") },
            {2, (102, "Milestone_PlantPot (106)", "Test") },
            {2, (102, "Milestone_PlantPot (107)", "Test") },
            {2, (102, "Milestone_PlantPot (108)", "Test") },
            {2, (102, "Milestone_PlantPot (109)", "Test") },
            {2, (102, "Milestone_PlantPot (110)", "Test") },

            /// Area 2 - Flamingos (15)
            {2, (102, "Milestone_Flamingo (1)", "Test") },
            {2, (102, "Milestone_Flamingo (4)", "Test") },
            {2, (102, "Milestone_Flamingo (5)", "Test") },
            {2, (102, "Milestone_Flamingo (5)", "Test") },
            {2, (102, "Milestone_Flamingo (6)", "Test") },
            {2, (102, "Milestone_Flamingo (8)", "Test") },
            {2, (102, "Milestone_Flamingo (9)", "Test") },
            {2, (102, "Milestone_Flamingo (12)", "Test") },
            {2, (102, "Milestone_Flamingo (13)", "Test") },
            {2, (102, "Milestone_Flamingo (14)", "Test") },
            {2, (102, "Milestone_Flamingo (15)", "Test") },
            {2, (102, "Milestone_Flamingo (16)", "Test") },
            {2, (102, "Milestone_Flamingo (17)", "Test") },
            {2, (102, "Milestone_Flamingo (18)", "Test") },
            {2, (102, "Milestone_Flamingo (19)", "Test") },
            {2, (102, "Milestone_Flamingo (20)", "Test") },

            /// Area 2 - Watering Can
            {2, (102, "Milestone_WateringCan (2)", "Test") },
            {2, (102, "Milestone_WateringCan (3)", "Test") },

            /// Area 2 - Patio Chair (6)
            {2, (102, "Milestone_PatioChair Blue (2)", "Test") },
            {2, (102, "Milestone_PatioChair Green (2)", "Test") },
            {2, (102, "Milestone_PatioChair Green (3)", "Test") },
            {2, (102, "Milestone_PatioChair Green (4)", "Test") },
            {2, (102, "Milestone_PatioChair Red (1)", "Test") },
            {2, (102, "Milestone_PatioChair Red (2)", "Test") },

            /// Area 2 - See Saw Board
            {2, (102, "Milestone_SeeSaw Board", "Test") },

            /// Area 2 - Paint Can (18)
            {2, (102, "Milestone_PaintCan (1)", "Test") },
            {2, (102, "Milestone_PaintCan (2)", "Test") },
            {2, (102, "Milestone_PaintCan (3)", "Test") },
            {2, (102, "Milestone_PaintCan (4)", "Test") },
            {2, (102, "Milestone_PaintCan (5)", "Test") },
            {2, (102, "Milestone_PaintCan (6)", "Test") },
            {2, (102, "Milestone_PaintCan (7)", "Test") },
            {2, (102, "Milestone_PaintCan (8)", "Test") },
            {2, (102, "Milestone_PaintCan (9)", "Test") },
            {2, (102, "Milestone_PaintCan (10)", "Test") },
            {2, (102, "Milestone_PaintCan (11)", "Test") },
            {2, (102, "Milestone_PaintCan (12)", "Test") },
            {2, (102, "Milestone_PaintCan (13)", "Test") },
            {2, (102, "Milestone_PaintCan (14)", "Test") },
            {2, (102, "Milestone_PaintCan (15)", "Test") },
            {2, (102, "Milestone_PaintCan (16)", "Test") },
            {2, (102, "Milestone_PaintCan (17)", "Test") },
            {2, (102, "Milestone_PaintCan (18)", "Test") },
            {2, (102, "Milestone_PaintCan (19)", "Test") },

            /// Area 2 - Recycling Bin (3)
            {2, (102, "Milestone_RecyclingBin Blue (1)", "Test") },
            {2, (102, "Milestone_RecyclingBin Blue (2)", "Test") },
            {2, (102, "Milestone_RecyclingBin Green (2)", "Test") },

            /// Area 2 - Beams and Boards (12)
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },
            {2, (102, "Milestone_BeamsAndBoards", "Test") },

            /// Area 2 - Grill
            {2, (102, "Milestone_Grill (1)", "Test") },
            {2, (102, "Milestone_Grill (2)", "Test") },

            /// Area 2 - Sun Umbrella
            {2, (102, "Milestone_SunUmbrella (1)", "Test") },

            /// Area 2 - Picnic Table
            {2, (102, "Milestone_PicnicTable (1)", "Test") },

            /// Area 2 - Patio Table
            {2, (102, "Milestone_PatioTable (1)", "Test") },

            /// Area 2 - Bird bath
            {2, (102, "Milestone_BirdBath (1)", "Test") },

            /// Area 2 - Trash Can
            {2, (102, "Milestone_TrashCan (5)", "Test") },

            /// Area 2 - Lawn Mower
            {2, (102, "Milestone_Lawnmower (1)", "Test") },
            {2, (102, "Milestone_Lawnmower (2)", "Test") },

            /// Area 2 - Wheelbarrow
            {2, (102, "Milestone_WheelBarrow (2)", "Test") },

            /// AREA 3 (172)
            
            /// Area 3 - Speech Bubbles
            {0, (100, "PickUp_SpeechBubble_Chainsaw- INCLUDE WITH MILESTONE", "Test") },

            /// Area 3 - Gnomes (29)
            {2, (102, "Milestone_Gnome1 (11)", "Test") },
            {2, (102, "Milestone_Gnome1 (13)", "Test") },
            {2, (102, "Milestone_Gnome1 (14)", "Test") },
            {2, (102, "Milestone_Gnome1 (15)", "Test") },
            {2, (102, "Milestone_Gnome1 (16)", "Test") },
            {2, (102, "Milestone_Gnome1 (17)", "Test") },
            {2, (102, "Milestone_Gnome1 (18)", "Test") },
            {2, (102, "Milestone_Gnome1 (19)", "Test") },
            {2, (102, "Milestone_Gnome1 (20)", "Test") },
            {2, (102, "Milestone_Gnome1 (21)", "Test") },
            {2, (102, "Milestone_Gnome1 (22)", "Test") },
            {2, (102, "Milestone_Gnome2 (16)", "Test") },
            {2, (102, "Milestone_Gnome2 (18)", "Test") },
            {2, (102, "Milestone_Gnome2 (19)", "Test") },
            {2, (102, "Milestone_Gnome2 (20)", "Test") },
            {2, (102, "Milestone_Gnome2 (21)", "Test") },
            {2, (102, "Milestone_Gnome2 (22)", "Test") },
            {2, (102, "Milestone_Gnome2 (23)", "Test") },
            {2, (102, "Milestone_Gnome2 (24)", "Test") },
            {2, (102, "Milestone_Gnome2 (25)", "Test") },
            {2, (102, "Milestone_Gnome2 (26)", "Test") },
            {2, (102, "Milestone_Gnome2 (27)", "Test") },
            {2, (102, "Milestone_Gnome2 (28)", "Test") },
            {2, (102, "Milestone_Gnome3 (9)", "Test") },
            {2, (102, "Milestone_Gnome3 (10)", "Test") },
            {2, (102, "Milestone_Gnome3 (13)", "Test") },
            {2, (102, "Milestone_Gnome3 (14)", "Test") },
            {2, (102, "Milestone_Gnome3 (15)", "Test") },
            {2, (102, "Milestone_Gnome3 (16)", "Test") },
            {2, (102, "Milestone_Gnome3 (17)", "Test") },

            /// Area 3 - Rocks (16)
            {2, (102, "Milestone_Rock1 (6)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock2 (5)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock3 (6)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock3 (7)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock3 (8)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock4 (1)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock5 (1)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock5 (4)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock6 (3)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock6 (4)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock6 (5)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock7 (3)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock7 (4)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock7 (5)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock7 (6)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock7 (7)", "Rock [1,2]") },
            {2, (102, "Milestone_Rock7 (8)", "Rock [1,2]") },

            /// Area 3 - Plant Pots (11)
            {2, (102, "Milestone_PlantPot (119)", "Test") },
            {2, (102, "Milestone_PlantPot (120)", "Test") },
            {2, (102, "Milestone_PlantPot (121)", "Test") },
            {2, (102, "Milestone_PlantPot (122)", "Test") },
            {2, (102, "Milestone_PlantPot (123)", "Test") },
            {2, (102, "Milestone_PlantPot (124)", "Test") },
            {2, (102, "Milestone_PlantPot (125)", "Test") },
            {2, (102, "Milestone_PlantPot (126)", "Test") },
            {2, (102, "Milestone_PlantPot (127)", "Test") },
            {2, (102, "Milestone_PlantPot (128)", "Test") },
            {2, (102, "Milestone_PlantPot (129)", "Test") },

            /// Area 3 - Flamingos (27)
            {2, (102, "Milestone_Flamingo (10)", "Test") },
            {2, (102, "Milestone_Flamingo (22)", "Test") },
            {2, (102, "Milestone_Flamingo (23)", "Test") },
            {2, (102, "Milestone_Flamingo (24)", "Test") },
            {2, (102, "Milestone_Flamingo (25)", "Test") },
            {2, (102, "Milestone_Flamingo (26)", "Test") },
            {2, (102, "Milestone_Flamingo (27)", "Test") },
            {2, (102, "Milestone_Flamingo (28)", "Test") },
            {2, (102, "Milestone_Flamingo (29)", "Test") },
            {2, (102, "Milestone_Flamingo (30)", "Test") },
            {2, (102, "Milestone_Flamingo (31)", "Test") },
            {2, (102, "Milestone_Flamingo (32)", "Test") },
            {2, (102, "Milestone_Flamingo (33)", "Test") },
            {2, (102, "Milestone_Flamingo (34)", "Test") },
            {2, (102, "Milestone_Flamingo (35)", "Test") },
            {2, (102, "Milestone_Flamingo (36)", "Test") },
            {2, (102, "Milestone_Flamingo (37)", "Test") },
            {2, (102, "Milestone_Flamingo (38)", "Test") },
            {2, (102, "Milestone_Flamingo (39)", "Test") },
            {2, (102, "Milestone_Flamingo (40)", "Test") },
            {2, (102, "Milestone_Flamingo (41)", "Test") },
            {2, (102, "Milestone_Flamingo (42)", "Test") },
            {2, (102, "Milestone_Flamingo (43)", "Test") },
            {2, (102, "Milestone_Flamingo (44)", "Test") },
            {2, (102, "Milestone_Flamingo (45)", "Test") },
            {2, (102, "Milestone_Flamingo (57)", "Test") },
            {2, (102, "Milestone_Flamingo (58)", "Test") },
            {2, (102, "Milestone_Flamingo (59)", "Test") },

            /// Area 3 - Watering Can
            {2, (102, "Milestone_WateringCan (4)", "Test") },
            {2, (102, "Milestone_WateringCan (5)", "Test") },

            /// Area 3 - Patio Chair (8)
            {2, (102, "Milestone_PatioChair Blue (3)", "Test") },
            {2, (102, "Milestone_PatioChair Blue (4)", "Test") },
            {2, (102, "Milestone_PatioChair Blue (5)", "Test") },
            {2, (102, "Milestone_PatioChair Green (5)", "Test") },
            {2, (102, "Milestone_PatioChair Green (6)", "Test") },
            {2, (102, "Milestone_PatioChair Green (7)", "Test") },
            {2, (102, "Milestone_PatioChair Red (3)", "Test") },
            {2, (102, "Milestone_PatioChair Red (4)", "Test") },

            /// Area 3 - Trellis
            {2, (102, "Milestone_Trellis (2)", "Test") },

            /// Area 3 - Tree (16)
            {2, (102, "Milestone_Tree (1)", "Test") },
            {2, (102, "Milestone_Tree (2)", "Test") },
            {2, (102, "Milestone_Tree (3)", "Test") },
            {2, (102, "Milestone_Tree (4)", "Test") },
            {2, (102, "Milestone_Tree (5)", "Test") },
            {2, (102, "Milestone_Tree (6)", "Test") },
            {2, (102, "Milestone_Tree (7)", "Test") },
            {2, (102, "Milestone_Tree (8)", "Test") },
            {2, (102, "Milestone_Tree (9)", "Test") },
            {2, (102, "Milestone_Tree (10)", "Test") },
            {2, (102, "Milestone_Tree (11)", "Test") },
            {2, (102, "Milestone_Tree (12)", "Test") },
            {2, (102, "Milestone_Tree (13)", "Test") },
            {2, (102, "Milestone_Tree (14)", "Test") },
            {2, (102, "Milestone_Tree (15)", "Test") },
            {2, (102, "Milestone_Tree (16)", "Test") },
            {2, (102, "Milestone_Tree (17)", "Test") },

            /// Area 3 - Tree Stump (7)
            {2, (102, "Milestone_TreeStump (1)", "Test") },
            {2, (102, "Milestone_TreeStump (2)", "Test") },
            {2, (102, "Milestone_TreeStump (3)", "Test") },
            {2, (102, "Milestone_TreeStump (4)", "Test") },
            {2, (102, "Milestone_TreeStump (5)", "Test") },
            {2, (102, "Milestone_TreeStump (6)", "Test") },
            {2, (102, "Milestone_TreeStump (9)", "Test") },

            /// Area 3 - Hotdog Stick
            {2, (102, "Milestone_HotdogStick (1)", "Test") },
            {2, (102, "Milestone_HotdogStick (2)", "Test") },

            /// Area 3 - Marshmallow Stick (3)
            {2, (102, "Milestone_MarshmallowStick (1)", "Test") },
            {2, (102, "Milestone_MarshmallowStick (2)", "Test") },
            {2, (102, "Milestone_MarshmallowStick (3)", "Test") },

            /// Area 3 - Bonfire
            {2, (102, "Milestone_Bonfire (1)", "Test") },
            {2, (102, "Milestone_Bonfire (2)", "Test") },
            {2, (102, "Milestone_Bonfire (3)", "Test") },

            /// Area 3 - Backpack
            {2, (102, "Milestone_Backpack (1)", "Test") },
            {2, (102, "Milestone_Backpack (2)", "Test") },
            {2, (102, "Milestone_Backpack (3)", "Test") },
            {2, (102, "Milestone_Backpack (4)", "Test") },

            /// Area 3 - Tent
            {2, (102, "Milestone_Tent (1)", "Test") },
            {2, (102, "Milestone_Tent (2)", "Test") },
            {2, (102, "Milestone_Tent (3)", "Test") },

            /// Area 3 - Trash Can
            {2, (102, "Milestone_TrashCan (3)", "Test") },
            {2, (102, "Milestone_TrashCan (4)", "Test") },

            /// Area 3 - Patio Table
            {2, (102, "Milestone_PatioTable (2)", "Test") },
            {2, (102, "Milestone_PatioTable (3)", "Test") },
            {2, (102, "Milestone_PatioTable (4)", "Test") },
            {2, (102, "Milestone_PatioTable (5)", "Test") },

            /// Area 3 - Picnic Table
            {2, (102, "Milestone_PicnicTable (3)", "Test") },
            {2, (102, "Milestone_PicnicTable (4)", "Test") },

            /// Area 3 - Traffic Cone
            {2, (102, "Milestone_TrafficCone (1)", "Test") },
            {2, (102, "Milestone_TrafficCone (2)", "Test") },

            /// Area 3 - Recycling Bin
            {2, (102, "Milestone_RecyclingBin Blue (4)", "Test") },
            {2, (102, "Milestone_RecyclingBin Blue (5)", "Test") },
            {2, (102, "Milestone_RecyclingBin Green (1)", "Test") },

            /// Area 3 - Sun Umbrella
            {2, (102, "Milestone_SunUmbrella (3)", "Test") },

            /// Area 3 - Kid Slide
            {2, (102, "Milestone_KidSlide (2)", "Test") },

            /// Area 3 - Paint Can
            {2, (102, "Milestone_PaintCan (20)", "Test") },
            {2, (102, "Milestone_PaintCan (21)", "Test") },

            /// Area 3 - Lookout Tower
            {2, (102, "Milestone_LookoutTower (1)", "Test") },
            {2, (102, "Milestone_LookoutTower (2)", "Test") },
            {2, (102, "Milestone_LookoutTower (3)", "Test") },

            /// Area 3 - Wheelbarrow
            {2, (102, "Milestone_WheelBarrow (5)", "Test") },
            {2, (102, "Milestone_WheelBarrow (6)", "Test") },

            /// Area 3 - Log Bench (6)
            {2, (102, "Milestone_LogBench (1)", "Test") },
            {2, (102, "Milestone_LogBench (2)", "Test") },
            {2, (102, "Milestone_LogBench (3)", "Test") },
            {2, (102, "Milestone_LogBench (4)", "Test") },
            {2, (102, "Milestone_LogBench (5)", "Test") },
            {2, (102, "Milestone_LogBench (6)", "Test") },

            /// Area 3 - Trash Can
            {2, (102, "Milestone_TrashCan (1)", "Test") },
            {2, (102, "Milestone_TrashCan (2)", "Test") },
            {2, (102, "Milestone_TrashCan (6)", "Test") },

            /// Area 3 - Grill
            {2, (102, "Milestone_Grill (4)", "Test") },

            /// Area 3 - Retro Camper
            {2, (102, "Milestone_RetroCamper (2)", "Test") },
            {2, (102, "Milestone_RetroCamper (3)", "Test") },

            /// Area 3 - Mail Box
            {2, (102, "Milestone_Mailbox (1)", "Test") },

            /// Area 3 - Bug Zapper
            {2, (102, "Milestone_BugZapper (2)", "Test") },

            /// Area 3 - Lawn Mower
            {2, (102, "Milestone_Lawnmower (3)", "Test") },

            /// Area 3 - Yield Sign
            {2, (102, "Milestone_YieldSign (1)", "Test") },

            /// Area 3 - Shed
            {2, (102, "Milestone_Shed (3)", "Test") },

            /// Area 3 - Bird bath
            {2, (102, "Milestone_BirdBath (5)", "Test") },

            /// AREA 4
            
            /// Area 4 - Speech Bubbles
            {0, (100, "PickUp_SpeechBubble_Chainsaw- INCLUDE WITH MILESTONE", "Test") },

            /// Area 4 - Bird bath
            {2, (102, "Milestone_BirdBath (2)", "Test") },
            {2, (102, "Milestone_BirdBath (3)", "Test") },
            {2, (102, "Milestone_BirdBath (4)", "Test") },

            /// Area 4 - Bus
            {2, (102, "Milestone_Bus (1)", "Test") },

            /// Area 4 - Bus Stop
            {2, (102, "Milestone_BusStop (1)", "Test") },
            {2, (102, "Milestone_BusStop (2)", "Test") },

            /// Area 4 - Car
            {2, (102, "Milestone_Car (1)", "Test") },
            {2, (102, "Milestone_Car (2)", "Test") },
            {2, (102, "Milestone_Car (3)", "Test") },
            {2, (102, "Milestone_Car (4)", "Test") },
            {2, (102, "Milestone_Car (5)", "Test") },

            /// Area 4 - Flamingos
            {2, (102, "Milestone_Flamingo (46)", "Test") },
            {2, (102, "Milestone_Flamingo (47)", "Test") },
            {2, (102, "Milestone_Flamingo (48)", "Test") },
            {2, (102, "Milestone_Flamingo (49)", "Test") },
            {2, (102, "Milestone_Flamingo (50)", "Test") },
            {2, (102, "Milestone_Flamingo (51)", "Test") },
            {2, (102, "Milestone_Flamingo (52)", "Test") },
            {2, (102, "Milestone_Flamingo (53)", "Test") },
            {2, (102, "Milestone_Flamingo (54)", "Test") },
            {2, (102, "Milestone_Flamingo (55)", "Test") },
            {2, (102, "Milestone_Flamingo (60)", "Test") },
            {2, (102, "Milestone_Flamingo (61)", "Test") },
            {2, (102, "Milestone_Flamingo (62)", "Test") },
            {2, (102, "Milestone_Flamingo (63)", "Test") },

            /// Area 4 - Gnomes
            {2, (102, "Milestone_Gnome1 (5)", "Test") },
            {2, (102, "Milestone_Gnome1 (23)", "Test") },
            {2, (102, "Milestone_Gnome1 (24)", "Test") },
            {2, (102, "Milestone_Gnome1 (25)", "Test") },
            {2, (102, "Milestone_Gnome1 (26)", "Test") },
            {2, (102, "Milestone_Gnome1 (27)", "Test") },
            {2, (102, "Milestone_Gnome1 (28)", "Test") },
            {2, (102, "Milestone_Gnome1 (29)", "Test") },
            {2, (102, "Milestone_Gnome1 (30)", "Test") },
            {2, (102, "Milestone_Gnome1 (31)", "Test") },
            {2, (102, "Milestone_Gnome2 (29)", "Test") },
            {2, (102, "Milestone_Gnome2 (30)", "Test") },
            {2, (102, "Milestone_Gnome2 (31)", "Test") },
            {2, (102, "Milestone_Gnome2 (32)", "Test") },
            {2, (102, "Milestone_Gnome2 (33)", "Test") },
            {2, (102, "Milestone_Gnome2 (34)", "Test") },
            {2, (102, "Milestone_Gnome2 (35)", "Test") },
            {2, (102, "Milestone_Gnome2 (36)", "Test") },
            {2, (102, "Milestone_Gnome2 (37)", "Test") },
            {2, (102, "Milestone_Gnome2 (38)", "Test") },
            {2, (102, "Milestone_Gnome2 (39)", "Test") },
            {2, (102, "Milestone_Gnome2 (40)", "Test") },
            {2, (102, "Milestone_Gnome2 (41)", "Test") },
            {2, (102, "Milestone_Gnome2 (42)", "Test") },
            {2, (102, "Milestone_Gnome2 (43)", "Test") },
            {2, (102, "Milestone_Gnome2 (44)", "Test") },
            {2, (102, "Milestone_Gnome2 (45)", "Test") },
            {2, (102, "Milestone_Gnome2 (46)", "Test") },
            {2, (102, "Milestone_Gnome2 (47)", "Test") },
            {2, (102, "Milestone_Gnome3 (12)", "Test") },
            {2, (102, "Milestone_Gnome3 (18)", "Test") },
            {2, (102, "Milestone_Gnome3 (19)", "Test") },
            {2, (102, "Milestone_Gnome3 (20)", "Test") },
            {2, (102, "Milestone_Gnome3 (21)", "Test") },
            {2, (102, "Milestone_Gnome3 (22)", "Test") },
            {2, (102, "Milestone_Gnome3 (23)", "Test") },
            {2, (102, "Milestone_Gnome3 (24)", "Test") },
            {2, (102, "Milestone_Gnome3 (25)", "Test") },
            {2, (102, "Milestone_Gnome3 (26)", "Test") },
            {2, (102, "Milestone_Gnome3 (27)", "Test") },
            {2, (102, "Milestone_Gnome3 (28)", "Test") },
            {2, (102, "Milestone_Gnome3 (29)", "Test") },

            /// Area 4 - House (Minimum Hole Size 13?)
            {2, (102, "Milestone_House (1)", "Test") },
            {2, (102, "Milestone_House (2)", "Test") },
            {2, (102, "Milestone_House (3)", "Test") },
            {2, (102, "Milestone_House (4)", "Test") },
            {2, (102, "Milestone_House (5)", "Test") },
            {2, (102, "Milestone_House (6)", "Test") },
            {2, (102, "Milestone_House (7)", "Test") },
            {2, (102, "Milestone_House (8)", "Test") },
            {2, (102, "Milestone_House (9)", "Test") },
            {2, (102, "Milestone_House (10)", "Test") },
            {2, (102, "Milestone_House (11)", "Test") },

            /// Area 4 - Kid Slide
            {2, (102, "Milestone_KidSlide (3)", "Test") },

            /// Area 4 - Lawn Mower
            {2, (102, "Milestone_Lawnmower (4)", "Test") },
            {2, (102, "Milestone_Lawnmower (5)", "Test") },
            {2, (102, "Milestone_Lawnmower (6)", "Test") },
            {2, (102, "Milestone_Lawnmower (7)", "Test") },
            {2, (102, "Milestone_Lawnmower (8)", "Test") },
            {2, (102, "Milestone_Lawnmower (9)", "Test") },
            {2, (102, "Milestone_Lawnmower (10)", "Test") },
            {2, (102, "Milestone_Lawnmower (11)", "Test") },
            {2, (102, "Milestone_Lawnmower (12)", "Test") },
            {2, (102, "Milestone_Lawnmower (13)", "Test") },

            /// Area 4 - Mail Box
            {2, (102, "Milestone_Mailbox (2)", "Test") },
            {2, (102, "Milestone_Mailbox (3)", "Test") },
            {2, (102, "Milestone_Mailbox (4)", "Test") },
            {2, (102, "Milestone_Mailbox (5)", "Test") },
            {2, (102, "Milestone_Mailbox (6)", "Test") },
            {2, (102, "Milestone_Mailbox (7)", "Test") },
            {2, (102, "Milestone_Mailbox (8)", "Test") },
            {2, (102, "Milestone_Mailbox (9)", "Test") },
            {2, (102, "Milestone_Mailbox (10)", "Test") },
            {2, (102, "Milestone_Mailbox (11)", "Test") },
            {2, (102, "Milestone_Mailbox (12)", "Test") },
            {2, (102, "Milestone_Mailbox (13)", "Test") },

            /// Area 4 - Paint Can
            {2, (102, "Milestone_PaintCan (22)", "Test") },
            {2, (102, "Milestone_PaintCan (23)", "Test") },
            {2, (102, "Milestone_PaintCan (24)", "Test") },
            {2, (102, "Milestone_PaintCan (25)", "Test") },
            {2, (102, "Milestone_PaintCan (26)", "Test") },
            {2, (102, "Milestone_PaintCan (27)", "Test") },

            /// Area 4 - Patio Chair
            {2, (102, "Milestone_PatioChair Blue (6)", "Test") },
            {2, (102, "Milestone_PatioChair Green (8)", "Test") },
            {2, (102, "Milestone_PatioChair Red (5)", "Test") },

            /// Area 4 - Patio Table
            {2, (102, "Milestone_PatioTable (6)", "Test") },

            /// Area 4 - Picket Fence
            {2, (102, "Milestone_PicketFence_Panel (1)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (2)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (3)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (4)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (6)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (7)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (8)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (9)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (10)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (11)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (12)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (13)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (15)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (16)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (17)", "Test") },
            {2, (102, "Milestone_PicketFence_Panel (18)", "Test") },
            {2, (102, "Milestone_PicketFence_Post (1)", "Test") },
            {2, (102, "Milestone_PicketFence_Post (3)", "Test") },

            /// Area 4 - Picnic Table
            {2, (102, "Milestone_PicnicTable (2)", "Test") },
            {2, (102, "Milestone_PicnicTable (5)", "Test") },

            /// Area 4 - Plant Pots
            {2, (102, "Milestone_PlantPot (13)", "Test") },
            {2, (102, "Milestone_PlantPot (14)", "Test") },
            {2, (102, "Milestone_PlantPot (15)", "Test") },
            {2, (102, "Milestone_PlantPot (16)", "Test") },
            {2, (102, "Milestone_PlantPot (17)", "Test") },
            {2, (102, "Milestone_PlantPot (18)", "Test") },
            {2, (102, "Milestone_PlantPot (19)", "Test") },
            {2, (102, "Milestone_PlantPot (20)", "Test") },
            {2, (102, "Milestone_PlantPot (21)", "Test") },
            {2, (102, "Milestone_PlantPot (22)", "Test") },
            {2, (102, "Milestone_PlantPot (23)", "Test") },
            {2, (102, "Milestone_PlantPot (24)", "Test") },
            {2, (102, "Milestone_PlantPot (25)", "Test") },
            {2, (102, "Milestone_PlantPot (26)", "Test") },
            {2, (102, "Milestone_PlantPot (27)", "Test") },
            {2, (102, "Milestone_PlantPot (28)", "Test") },
            {2, (102, "Milestone_PlantPot (29)", "Test") },
            {2, (102, "Milestone_PlantPot (30)", "Test") },
            {2, (102, "Milestone_PlantPot (31)", "Test") },
            {2, (102, "Milestone_PlantPot (32)", "Test") },
            {2, (102, "Milestone_PlantPot (33)", "Test") },
            {2, (102, "Milestone_PlantPot (34)", "Test") },
            {2, (102, "Milestone_PlantPot (35)", "Test") },
            {2, (102, "Milestone_PlantPot (36)", "Test") },
            {2, (102, "Milestone_PlantPot (37)", "Test") },
            {2, (102, "Milestone_PlantPot (38)", "Test") },
            {2, (102, "Milestone_PlantPot (39)", "Test") },
            {2, (102, "Milestone_PlantPot (40)", "Test") },
            {2, (102, "Milestone_PlantPot (41)", "Test") },
            {2, (102, "Milestone_PlantPot (42)", "Test") },
            {2, (102, "Milestone_PlantPot (43)", "Test") },
            {2, (102, "Milestone_PlantPot (44)", "Test") },
            {2, (102, "Milestone_PlantPot (45)", "Test") },
            {2, (102, "Milestone_PlantPot (46)", "Test") },
            {2, (102, "Milestone_PlantPot (47)", "Test") },
            {2, (102, "Milestone_PlantPot (48)", "Test") },
            {2, (102, "Milestone_PlantPot (49)", "Test") },
            {2, (102, "Milestone_PlantPot (50)", "Test") },
            {2, (102, "Milestone_PlantPot (51)", "Test") },
            {2, (102, "Milestone_PlantPot (52)", "Test") },
            {2, (102, "Milestone_PlantPot (53)", "Test") },
            {2, (102, "Milestone_PlantPot (54)", "Test") },
            {2, (102, "Milestone_PlantPot (55)", "Test") },
            {2, (102, "Milestone_PlantPot (56)", "Test") },
            {2, (102, "Milestone_PlantPot (57)", "Test") },
            {2, (102, "Milestone_PlantPot (130)", "Test") },
            {2, (102, "Milestone_PlantPot (131)", "Test") },
            {2, (102, "Milestone_PlantPot (132)", "Test") },

            /// Area 4 - Recycling Bin
            {2, (102, "Milestone_RecyclingBin Blue (6)", "Test") },
            {2, (102, "Milestone_RecyclingBin Blue (7)", "Test") },
            {2, (102, "Milestone_RecyclingBin Blue (8)", "Test") },
            {2, (102, "Milestone_RecyclingBin Blue (9)", "Test") },
            {2, (102, "Milestone_RecyclingBin Green (3)", "Test") },
            {2, (102, "Milestone_RecyclingBin Green (4)", "Test") },
            {2, (102, "Milestone_RecyclingBin Green (5)", "Test") },

            /// Area 4 - Retro Camper
            {2, (102, "Milestone_RetroCamper (4)", "Test") },

            /// Area 4 - Road Blockade
            {2, (102, "Milestone_RoadBlockade (1)", "Test") },
            {2, (102, "Milestone_RoadBlockade (2)", "Test") },
            {2, (102, "Milestone_RoadBlockade (3)", "Test") },
            {2, (102, "Milestone_RoadBlockade (4)", "Test") },
            {2, (102, "Milestone_RoadBlockade (5)", "Test") },
            {2, (102, "Milestone_RoadBlockade (6)", "Test") },
            {2, (102, "Milestone_RoadBlockade (7)", "Test") },
            {2, (102, "Milestone_RoadBlockade (8)", "Test") },
            {2, (102, "Milestone_RoadBlockade (10)", "Test") },
            {2, (102, "Milestone_RoadBlockade (12)", "Test") },
            {2, (102, "Milestone_RoadBlockade (13)", "Test") },
            {2, (102, "Milestone_RoadBlockade (14)", "Test") },
            {2, (102, "Milestone_RoadBlockade (15)", "Test") },
            {2, (102, "Milestone_RoadBlockade (16)", "Test") },

            /// Area 4 - Sidewalk Panel
            {2, (102, "Milestone_SidewalkPanel (1)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (2)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (3)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (4)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (5)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (6)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (7)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (8)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (9)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (10)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (11)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (12)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (13)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (14)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (15)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (16)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (17)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (18)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (19)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (20)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (21)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (22)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (23)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (24)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (25)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (26)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (27)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (28)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (29)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (30)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (31)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (32)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (33)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (34)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (35)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (36)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (37)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (38)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (39)", "Test") },

            /// Area 4 - Stop Sign
            {2, (102, "Milestone_StopSign (1)", "Test") },
            {2, (102, "Milestone_StopSign (2)", "Test") },
            {2, (102, "Milestone_StopSign (3)", "Test") },
            {2, (102, "Milestone_StopSign (4)", "Test") },
            {2, (102, "Milestone_StopSign (5)", "Test") },
            {2, (102, "Milestone_StopSign (6)", "Test") },

            /// Area 4 - Street Sign
            {2, (102, "Milestone_StreetSign (1)", "Test") },
            {2, (102, "Milestone_StreetSign (2)", "Test") },
            {2, (102, "Milestone_StreetSign (3)", "Test") },
            {2, (102, "Milestone_StreetSign (4)", "Test") },

            /// Area 4 - Sun Umbrella
            {2, (102, "Milestone_SunUmbrella (2)", "Test") },
            {2, (102, "Milestone_SunUmbrella (4)", "Test") },

            /// Area 4 - Traffic Cone
            {2, (102, "Milestone_TrafficCone (3)", "Test") },
            {2, (102, "Milestone_TrafficCone (4)", "Test") },
            {2, (102, "Milestone_TrafficCone (5)", "Test") },
            {2, (102, "Milestone_TrafficCone (6)", "Test") },
            {2, (102, "Milestone_TrafficCone (7)", "Test") },
            {2, (102, "Milestone_TrafficCone (8)", "Test") },
            {2, (102, "Milestone_TrafficCone (9)", "Test") },
            {2, (102, "Milestone_TrafficCone (10)", "Test") },
            {2, (102, "Milestone_TrafficCone (11)", "Test") },
            {2, (102, "Milestone_TrafficCone (12)", "Test") },
            {2, (102, "Milestone_TrafficCone (13)", "Test") },
            {2, (102, "Milestone_TrafficCone (14)", "Test") },
            {2, (102, "Milestone_TrafficCone (15)", "Test") },
            {2, (102, "Milestone_TrafficCone (16)", "Test") },
            {2, (102, "Milestone_TrafficCone (17)", "Test") },
            {2, (102, "Milestone_TrafficCone (18)", "Test") },
            {2, (102, "Milestone_TrafficCone (19)", "Test") },
            {2, (102, "Milestone_TrafficCone (20)", "Test") },
            {2, (102, "Milestone_TrafficCone (21)", "Test") },
            {2, (102, "Milestone_TrafficCone (22)", "Test") },
            {2, (102, "Milestone_TrafficCone (23)", "Test") },
            {2, (102, "Milestone_TrafficCone (24)", "Test") },

            /// Area 4 - Trash Can
            {2, (102, "Milestone_TrashCan (7)", "Test") },
            {2, (102, "Milestone_TrashCan (8)", "Test") },
            {2, (102, "Milestone_TrashCan (9)", "Test") },
            {2, (102, "Milestone_TrashCan (10)", "Test") },
            {2, (102, "Milestone_TrashCan (11)", "Test") },
            {2, (102, "Milestone_TrashCan (12)", "Test") },
            {2, (102, "Milestone_TrashCan (13)", "Test") },

            /// Area 4 - Tree
            {2, (102, "Milestone_Tree (18)", "Test") },
            {2, (102, "Milestone_Tree (19)", "Test") },
            {2, (102, "Milestone_Tree (20)", "Test") },
            {2, (102, "Milestone_Tree (21)", "Test") },
            {2, (102, "Milestone_Tree (22)", "Test") },
            {2, (102, "Milestone_Tree (23)", "Test") },
            {2, (102, "Milestone_Tree (24)", "Test") },
            {2, (102, "Milestone_Tree (25)", "Test") },
            {2, (102, "Milestone_Tree (26)", "Test") },
            {2, (102, "Milestone_Tree (27)", "Test") },
            {2, (102, "Milestone_Tree (28)", "Test") },

            /// Area 4 - Trellis
            {2, (102, "Milestone_Trellis (3)", "Test") },
            {2, (102, "Milestone_Trellis (4)", "Test") },

            /// Area 4 - Truck
            {2, (102, "Milestone_Truck (1)", "Test") },
            {2, (102, "Milestone_Truck (2)", "Test") },
            {2, (102, "Milestone_Truck (3)", "Test") },
            {2, (102, "Milestone_Truck (4)", "Test") },

            /// Area 4 - Van
            {2, (102, "Milestone_Van (1)", "Test") },
            {2, (102, "Milestone_Van (2)", "Test") },
            {2, (102, "Milestone_Van (3)", "Test") },

            /// Area 4 - Water Tower
            {2, (102, "Milestone_WaterTower (1)", "Test") },

            /// Area 4 - Yield Sign
            {2, (102, "Milestone_YieldSign (5)", "Test") },
            {2, (102, "Milestone_YieldSign (4)", "Test") },
            {2, (102, "Milestone_YieldSign (3)", "Test") },
            {2, (102, "Milestone_YieldSign (2)", "Test") },
            {2, (102, "Milestone_YieldSign (7)", "Test") },
            {2, (102, "Milestone_YieldSign (6)", "Test") },

            /// AREA 5
            
            /// Area 5 - Speech Bubbles
            {0, (100, "PickUp_SpeechBubble_Chainsaw- INCLUDE WITH MILESTONE", "Test") },

            /// Area 5 - Bird bath
            {2, (102, "Milestone_BirdBath (6)", "Test") },

            /// Area 5 - Bonfire
            {2, (102, "Milestone_Bonfire (4)", "Test") },

            /// Area 5 - Bus
            {2, (102, "Milestone_Bus (2)", "Test") },
            {2, (102, "Milestone_Bus (3)", "Test") },
            {2, (102, "Milestone_Bus (4)", "Test") },
            {2, (102, "Milestone_Bus (5)", "Test") },
            {2, (102, "Milestone_Bus (6)", "Test") },

            /// Area 5 - Bus Stop
            {2, (102, "Milestone_BusStop (3)", "Test") },

            /// Area 5 - Car
            {2, (102, "Milestone_Car (6)", "Test") },
            {2, (102, "Milestone_Car (7)", "Test") },
            {2, (102, "Milestone_Car (8)", "Test") },
            {2, (102, "Milestone_Car (9)", "Test") },
            {2, (102, "Milestone_Car (10)", "Test") },

            /// Area 5 - Flamingos
            {2, (102, "Milestone_Flamingo (64)", "Test") },
            {2, (102, "Milestone_Flamingo (65)", "Test") },
            {2, (102, "Milestone_Flamingo (66)", "Test") },
            {2, (102, "Milestone_Flamingo (67)", "Test") },
            {2, (102, "Milestone_Flamingo (68)", "Test") },
            {2, (102, "Milestone_Flamingo (69)", "Test") },

            /// Area 5 - Gnomes
            {2, (102, "Milestone_Gnome1 (32)", "Test") },
            {2, (102, "Milestone_Gnome1 (33)", "Test") },
            {2, (102, "Milestone_Gnome1 (34)", "Test") },
            {2, (102, "Milestone_Gnome1 (35)", "Test") },
            {2, (102, "Milestone_Gnome2 (48)", "Test") },
            {2, (102, "Milestone_Gnome2 (49)", "Test") },
            {2, (102, "Milestone_Gnome2 (50)", "Test") },
            {2, (102, "Milestone_Gnome2 (51)", "Test") },
            {2, (102, "Milestone_Gnome2 (52)", "Test") },
            {2, (102, "Milestone_Gnome2 (53)", "Test") },
            {2, (102, "Milestone_Gnome2 (54)", "Test") },
            {2, (102, "Milestone_Gnome3 (30)", "Test") },
            {2, (102, "Milestone_Gnome3 (31)", "Test") },
            {2, (102, "Milestone_Gnome3 (32)", "Test") },

            /// Area 5 - Grill
            {2, (102, "Milestone_Grill (3)", "Test") },

            /// Area 5 - Hotdog Stick
            {2, (102, "Milestone_HotdogStick (3)", "Test") },
            {2, (102, "Milestone_HotdogStick (4)", "Test") },
            {2, (102, "Milestone_HotdogStick (5)", "Test") },
            {2, (102, "Milestone_HotdogStick (6)", "Test") },
            {2, (102, "Milestone_HotdogStick (7)", "Test") },

            /// Area 5 - House (Minimum Hole Size 13?)
            {2, (102, "Milestone_House (12)", "Test") },
            {2, (102, "Milestone_House (13)", "Test") },
            {2, (102, "Milestone_House (14)", "Test") },
            {2, (102, "Milestone_House (15)", "Test") },
            {2, (102, "Milestone_House (16)", "Test") },
            {2, (102, "Milestone_House (17)", "Test") },
            {2, (102, "Milestone_House (18)", "Test") },
            {2, (102, "Milestone_House (19)", "Test") },
            {2, (102, "Milestone_House (20)", "Test") },
            {2, (102, "Milestone_House (21)", "Test") }, // REquires hole size 18 + Fountain

            /// Area 5 - Kid Slide
            {2, (102, "Milestone_KidSlide (4)", "Test") },

            /// Area 5 - Lawn Mower
            {2, (102, "Milestone_Lawnmower (14)", "Test") },

            /// Area 5 - Log Bench
            {2, (102, "Milestone_LogBench (7)", "Test") },
            {2, (102, "Milestone_LogBench (8)", "Test") },
            {2, (102, "Milestone_LogBench (9)", "Test") },
            {2, (102, "Milestone_LogBench (10)", "Test") },
            {2, (102, "Milestone_LogBench (11)", "Test") },
            {2, (102, "Milestone_LogBench (12)", "Test") },
            {2, (102, "Milestone_LogBench (13)", "Test") },
            {2, (102, "Milestone_LogBench (14)", "Test") },
            {2, (102, "Milestone_LogBench (15)", "Test") },
            {2, (102, "Milestone_LogBench (16)", "Test") },
            {2, (102, "Milestone_LogBench (17)", "Test") },
            {2, (102, "Milestone_LogBench (18)", "Test") },
            {2, (102, "Milestone_LogBench (19)", "Test") },
            {2, (102, "Milestone_LogBench (20)", "Test") },
            {2, (102, "Milestone_LogBench (21)", "Test") },
            {2, (102, "Milestone_LogBench (22)", "Test") },
            {2, (102, "Milestone_LogBench (23)", "Test") },
            {2, (102, "Milestone_LogBench (24)", "Test") },
            {2, (102, "Milestone_LogBench (25)", "Test") },
            {2, (102, "Milestone_LogBench (26)", "Test") },
            {2, (102, "Milestone_LogBench (27)", "Test") },
            {2, (102, "Milestone_LogBench (28)", "Test") },
            {2, (102, "Milestone_LogBench (29)", "Test") },
            {2, (102, "Milestone_LogBench (30)", "Test") },
            {2, (102, "Milestone_LogBench (31)", "Test") },
            {2, (102, "Milestone_LogBench (32)", "Test") },

            /// Area 5 - Lookout Tower
            {2, (102, "Milestone_LookoutTower (4)", "Test") },
            {2, (102, "Milestone_LookoutTower (5)", "Test") },

            /// Area 5 - Mail Box
            {2, (102, "Milestone_Mailbox (14)", "Test") },
            {2, (102, "Milestone_Mailbox (15)", "Test") },
            {2, (102, "Milestone_Mailbox (16)", "Test") },
            {2, (102, "Milestone_Mailbox (17)", "Test") },
            {2, (102, "Milestone_Mailbox (18)", "Test") },
            {2, (102, "Milestone_Mailbox (19)", "Test") },
            {2, (102, "Milestone_Mailbox (20)", "Test") },
            {2, (102, "Milestone_Mailbox (21)", "Test") },
            {2, (102, "Milestone_Mailbox (22)", "Test") },
            {2, (102, "Milestone_Mailbox (23)", "Test") },
            {2, (102, "Milestone_Mailbox (24)", "Test") },
            {2, (102, "Milestone_Mailbox (25)", "Test") },
            {2, (102, "Milestone_Mailbox (26)", "Test") },
            {2, (102, "Milestone_Mailbox (27)", "Test") },
            {2, (102, "Milestone_Mailbox (28)", "Test") },
            {2, (102, "Milestone_Mailbox (29)", "Test") },
            {2, (102, "Milestone_Mailbox (30)", "Test") },
            {2, (102, "Milestone_Mailbox (31)", "Test") },
            {2, (102, "Milestone_Mailbox (32)", "Test") },
            {2, (102, "Milestone_Mailbox (33)", "Test") },

            /// Area 5 - Marshmallow Stick
            {2, (102, "Milestone_MarshmallowStick (5)", "Test") },
            {2, (102, "Milestone_MarshmallowStick (6)", "Test") },
            {2, (102, "Milestone_MarshmallowStick (7)", "Test") },
            {2, (102, "Milestone_MarshmallowStick (8)", "Test") },
            {2, (102, "Milestone_MarshmallowStick (10)", "Test") },

            /// Area 5 - Paint Can
            {2, (102, "Milestone_PaintCan (28)", "Test") },

            /// Area 5 - Patio Chair
            {2, (102, "Milestone_PatioChair Blue (7)", "Test") },
            {2, (102, "Milestone_PatioChair Green (9)", "Test") },
            {2, (102, "Milestone_PatioChair Red (6)", "Test") },

            /// Area 5 - Patio Table
            {2, (102, "Milestone_PatioTable (7)", "Test") },
            {2, (102, "Milestone_PatioTable (8)", "Test") },
            {2, (102, "Milestone_PatioTable (9)", "Test") },
            {2, (102, "Milestone_PatioTable (10)", "Test") },
            {2, (102, "Milestone_PatioTable (11)", "Test") },
            {2, (102, "Milestone_PatioTable (12)", "Test") },
            {2, (102, "Milestone_PatioTable (13)", "Test") },
            {2, (102, "Milestone_PatioTable (14)", "Test") },
            {2, (102, "Milestone_PatioTable (15)", "Test") },
            {2, (102, "Milestone_PatioTable (16)", "Test") },
            {2, (102, "Milestone_PatioTable (17)", "Test") },
            {2, (102, "Milestone_PatioTable (18)", "Test") },

            /// Area 5 - Picnic Table
            {2, (102, "Milestone_PicnicTable (6)", "Test") },
            {2, (102, "Milestone_PicnicTable (7)", "Test") },

            /// Area 5 - Plant Pots
            {2, (102, "Milestone_PlantPot (133)", "Test") },
            {2, (102, "Milestone_PlantPot (134)", "Test") },
            {2, (102, "Milestone_PlantPot (135)", "Test") },
            {2, (102, "Milestone_PlantPot (136)", "Test") },
            {2, (102, "Milestone_PlantPot (137)", "Test") },
            {2, (102, "Milestone_PlantPot (138)", "Test") },
            {2, (102, "Milestone_PlantPot (139)", "Test") },
            {2, (102, "Milestone_PlantPot (140)", "Test") },
            {2, (102, "Milestone_PlantPot (141)", "Test") },
            {2, (102, "Milestone_PlantPot (142)", "Test") },
            {2, (102, "Milestone_PlantPot (143)", "Test") },
            {2, (102, "Milestone_PlantPot (144)", "Test") },
            {2, (102, "Milestone_PlantPot (145)", "Test") },
            {2, (102, "Milestone_PlantPot (146)", "Test") },
            {2, (102, "Milestone_PlantPot (147)", "Test") },
            {2, (102, "Milestone_PlantPot (148)", "Test") },
            {2, (102, "Milestone_PlantPot (149)", "Test") },
            {2, (102, "Milestone_PlantPot (150)", "Test") },
            {2, (102, "Milestone_PlantPot (151)", "Test") },
            {2, (102, "Milestone_PlantPot (152)", "Test") },
            {2, (102, "Milestone_PlantPot (153)", "Test") },
            {2, (102, "Milestone_PlantPot (154)", "Test") },
            {2, (102, "Milestone_PlantPot (155)", "Test") },
            {2, (102, "Milestone_PlantPot (156)", "Test") },
            {2, (102, "Milestone_PlantPot (157)", "Test") },
            {2, (102, "Milestone_PlantPot (158)", "Test") },
            {2, (102, "Milestone_PlantPot (159)", "Test") },
            {2, (102, "Milestone_PlantPot (160)", "Test") },
            {2, (102, "Milestone_PlantPot (161)", "Test") },
            {2, (102, "Milestone_PlantPot (162)", "Test") },
            {2, (102, "Milestone_PlantPot (163)", "Test") },
            {2, (102, "Milestone_PlantPot (164)", "Test") },
            {2, (102, "Milestone_PlantPot (165)", "Test") },
            {2, (102, "Milestone_PlantPot (166)", "Test") },
            {2, (102, "Milestone_PlantPot (167)", "Test") },
            {2, (102, "Milestone_PlantPot (168)", "Test") },
            {2, (102, "Milestone_PlantPot (169)", "Test") },
            {2, (102, "Milestone_PlantPot (170)", "Test") },
            {2, (102, "Milestone_PlantPot (171)", "Test") },
            {2, (102, "Milestone_PlantPot (188)", "Test") },
            {2, (102, "Milestone_PlantPot (189)", "Test") },
            {2, (102, "Milestone_PlantPot (190)", "Test") },
            {2, (102, "Milestone_PlantPot (191)", "Test") },
            {2, (102, "Milestone_PlantPot (192)", "Test") },
            {2, (102, "Milestone_PlantPot (193)", "Test") },
            {2, (102, "Milestone_PlantPot (194)", "Test") },
            {2, (102, "Milestone_PlantPot (195)", "Test") },
            {2, (102, "Milestone_PlantPot (196)", "Test") },
            {2, (102, "Milestone_PlantPot (197)", "Test") },
            {2, (102, "Milestone_PlantPot (198)", "Test") },
            {2, (102, "Milestone_PlantPot (199)", "Test") },
            {2, (102, "Milestone_PlantPot (200)", "Test") },
            {2, (102, "Milestone_PlantPot (201)", "Test") },
            {2, (102, "Milestone_PlantPot (202)", "Test") },
            {2, (102, "Milestone_PlantPot (203)", "Test") },
            {2, (102, "Milestone_PlantPot (204)", "Test") },
            {2, (102, "Milestone_PlantPot (205)", "Test") },
            {2, (102, "Milestone_PlantPot (206)", "Test") },
            {2, (102, "Milestone_PlantPot (207)", "Test") },
            {2, (102, "Milestone_PlantPot (208)", "Test") },
            {2, (102, "Milestone_PlantPot (209)", "Test") },
            {2, (102, "Milestone_PlantPot (210)", "Test") },
            {2, (102, "Milestone_PlantPot (211)", "Test") },
            {2, (102, "Milestone_PlantPot (212)", "Test") },
            {2, (102, "Milestone_PlantPot (213)", "Test") },
            {2, (102, "Milestone_PlantPot (214)", "Test") },
            {2, (102, "Milestone_PlantPot (215)", "Test") },
            {2, (102, "Milestone_PlantPot (216)", "Test") },
            {2, (102, "Milestone_PlantPot (217)", "Test") },
            {2, (102, "Milestone_PlantPot (218)", "Test") },
            {2, (102, "Milestone_PlantPot (219)", "Test") },
            {2, (102, "Milestone_PlantPot (220)", "Test") },
            {2, (102, "Milestone_PlantPot (221)", "Test") },
            {2, (102, "Milestone_PlantPot (222)", "Test") },
            {2, (102, "Milestone_PlantPot (223)", "Test") },
            {2, (102, "Milestone_PlantPot (224)", "Test") },
            {2, (102, "Milestone_PlantPot (225)", "Test") },
            {2, (102, "Milestone_PlantPot (226)", "Test") },
            {2, (102, "Milestone_PlantPot (227)", "Test") },
            {2, (102, "Milestone_PlantPot (229)", "Test") },
            {2, (102, "Milestone_PlantPot (231)", "Test") },
            {2, (102, "Milestone_PlantPot (232)", "Test") },
            {2, (102, "Milestone_PlantPot (233)", "Test") },
            {2, (102, "Milestone_PlantPot (234)", "Test") },
            {2, (102, "Milestone_PlantPot (235)", "Test") },
            {2, (102, "Milestone_PlantPot (237)", "Test") },
            {2, (102, "Milestone_PlantPot (239)", "Test") },
            {2, (102, "Milestone_PlantPot (240)", "Test") },
            {2, (102, "Milestone_PlantPot (241)", "Test") },
            {2, (102, "Milestone_PlantPot (242)", "Test") },
            {2, (102, "Milestone_PlantPot (243)", "Test") },
            {2, (102, "Milestone_PlantPot (245)", "Test") },
            {2, (102, "Milestone_PlantPot (247)", "Test") },
            {2, (102, "Milestone_PlantPot (248)", "Test") },
            {2, (102, "Milestone_PlantPot (249)", "Test") },
            {2, (102, "Milestone_PlantPot (251)", "Test") },
            {2, (102, "Milestone_PlantPot (253)", "Test") },
            {2, (102, "Milestone_PlantPot (255)", "Test") },
            {2, (102, "Milestone_PlantPot (256)", "Test") },
            {2, (102, "Milestone_PlantPot (257)", "Test") },
            {2, (102, "Milestone_PlantPot (259)", "Test") },
            {2, (102, "Milestone_PlantPot (261)", "Test") },
            {2, (102, "Milestone_PlantPot (263)", "Test") },
            {2, (102, "Milestone_PlantPot (264)", "Test") },
            {2, (102, "Milestone_PlantPot (265)", "Test") },
            {2, (102, "Milestone_PlantPot (267)", "Test") },
            {2, (102, "Milestone_PlantPot (269)", "Test") },
            {2, (102, "Milestone_PlantPot (271)", "Test") },
            {2, (102, "Milestone_PlantPot (272)", "Test") },
            {2, (102, "Milestone_PlantPot (273)", "Test") },
            {2, (102, "Milestone_PlantPot (275)", "Test") },
            {2, (102, "Milestone_PlantPot (277)", "Test") },
            {2, (102, "Milestone_PlantPot (279)", "Test") },
            {2, (102, "Milestone_PlantPot (280)", "Test") },
            {2, (102, "Milestone_PlantPot (281)", "Test") },
            {2, (102, "Milestone_PlantPot (283)", "Test") },
            {2, (102, "Milestone_PlantPot (285)", "Test") },
            {2, (102, "Milestone_PlantPot (287)", "Test") },
            {2, (102, "Milestone_PlantPot (288)", "Test") },
            {2, (102, "Milestone_PlantPot (289)", "Test") },
            {2, (102, "Milestone_PlantPot (291)", "Test") },
            {2, (102, "Milestone_PlantPot (293)", "Test") },
            {2, (102, "Milestone_PlantPot (295)", "Test") },
            {2, (102, "Milestone_PlantPot (297)", "Test") },
            {2, (102, "Milestone_PlantPot (299)", "Test") },
            {2, (102, "Milestone_PlantPot (301)", "Test") },
            {2, (102, "Milestone_PlantPot (303)", "Test") },
            {2, (102, "Milestone_PlantPot (304)", "Test") },
            {2, (102, "Milestone_PlantPot (305)", "Test") },
            {2, (102, "Milestone_PlantPot (306)", "Test") },
            {2, (102, "Milestone_PlantPot (307)", "Test") },
            {2, (102, "Milestone_PlantPot (308)", "Test") },
            {2, (102, "Milestone_PlantPot (309)", "Test") },
            {2, (102, "Milestone_PlantPot (310)", "Test") },
            {2, (102, "Milestone_PlantPot (311)", "Test") },
            {2, (102, "Milestone_PlantPot (312)", "Test") },
            {2, (102, "Milestone_PlantPot (313)", "Test") },
            {2, (102, "Milestone_PlantPot (314)", "Test") },
            {2, (102, "Milestone_PlantPot (315)", "Test") },
            {2, (102, "Milestone_PlantPot (316)", "Test") },
            {2, (102, "Milestone_PlantPot (317)", "Test") },
            {2, (102, "Milestone_PlantPot (318)", "Test") },
            {2, (102, "Milestone_PlantPot (319)", "Test") },
            {2, (102, "Milestone_PlantPot (320)", "Test") },
            {2, (102, "Milestone_PlantPot (321)", "Test") },
            {2, (102, "Milestone_PlantPot (322)", "Test") },
            {2, (102, "Milestone_PlantPot (323)", "Test") },
            {2, (102, "Milestone_PlantPot (324)", "Test") },
            {2, (102, "Milestone_PlantPot (325)", "Test") },
            {2, (102, "Milestone_PlantPot (326)", "Test") },
            {2, (102, "Milestone_PlantPot (327)", "Test") },
            {2, (102, "Milestone_PlantPot (328)", "Test") },
            {2, (102, "Milestone_PlantPot (329)", "Test") },
            {2, (102, "Milestone_PlantPot (330)", "Test") },
            {2, (102, "Milestone_PlantPot (331)", "Test") },
            {2, (102, "Milestone_PlantPot (332)", "Test") },
            {2, (102, "Milestone_PlantPot (333)", "Test") },
            {2, (102, "Milestone_PlantPot (334)", "Test") },
            {2, (102, "Milestone_PlantPot (335)", "Test") },
            {2, (102, "Milestone_PlantPot (336)", "Test") },
            {2, (102, "Milestone_PlantPot (337)", "Test") },
            {2, (102, "Milestone_PlantPot (338)", "Test") },
            {2, (102, "Milestone_PlantPot (339)", "Test") },
            {2, (102, "Milestone_PlantPot (340)", "Test") },
            {2, (102, "Milestone_PlantPot (341)", "Test") },
            {2, (102, "Milestone_PlantPot (342)", "Test") },
            {2, (102, "Milestone_PlantPot (343)", "Test") },
            {2, (102, "Milestone_PlantPot (344)", "Test") },
            {2, (102, "Milestone_PlantPot (345)", "Test") },
            {2, (102, "Milestone_PlantPot (347)", "Test") },
            {2, (102, "Milestone_PlantPot (349)", "Test") },
            {2, (102, "Milestone_PlantPot (351)", "Test") },
            {2, (102, "Milestone_PlantPot (353)", "Test") },
            {2, (102, "Milestone_PlantPot (355)", "Test") },
            {2, (102, "Milestone_PlantPot (357)", "Test") },
            {2, (102, "Milestone_PlantPot (359)", "Test") },
            {2, (102, "Milestone_PlantPot (361)", "Test") },
            {2, (102, "Milestone_PlantPot (363)", "Test") },
            {2, (102, "Milestone_PlantPot (365)", "Test") },
            {2, (102, "Milestone_PlantPot (367)", "Test") },
            {2, (102, "Milestone_PlantPot (369)", "Test") },
            {2, (102, "Milestone_PlantPot (371)", "Test") },
            {2, (102, "Milestone_PlantPot (373)", "Test") },
            {2, (102, "Milestone_PlantPot (375)", "Test") },
            {2, (102, "Milestone_PlantPot (377)", "Test") },
            {2, (102, "Milestone_PlantPot (379)", "Test") },
            {2, (102, "Milestone_PlantPot (381)", "Test") },

            /// Area 5 - Recycling Bin
            {2, (102, "Milestone_RecyclingBin Blue (10)", "Test") },
            {2, (102, "Milestone_RecyclingBin Blue (11)", "Test") },
            {2, (102, "Milestone_RecyclingBin Blue (12)", "Test") },
            {2, (102, "Milestone_RecyclingBin Blue (13)", "Test") },
            {2, (102, "Milestone_RecyclingBin Green (6)", "Test") },
            {2, (102, "Milestone_RecyclingBin Green (7)", "Test") },
            {2, (102, "Milestone_RecyclingBin Green (8)", "Test") },
            {2, (102, "Milestone_RecyclingBin Green (9)", "Test") },

            /// Area 5 - Retro Camper
            {2, (102, "Milestone_RetroCamper (5)", "Test") },
            {2, (102, "Milestone_RetroCamper (6)", "Test") },
            {2, (102, "Milestone_RetroCamper (7)", "Test") },
            {2, (102, "Milestone_RetroCamper (8)", "Test") },
            {2, (102, "Milestone_RetroCamper (9)", "Test") },
            {2, (102, "Milestone_RetroCamper (10)", "Test") },
            {2, (102, "Milestone_RetroCamper (11)", "Test") },

            /// Area 5 - Road Blockade
            {2, (102, "Milestone_RoadBlockade (9)", "Test") },
            {2, (102, "Milestone_RoadBlockade (11)", "Test") },
            {2, (102, "Milestone_RoadBlockade (17)", "Test") },
            {2, (102, "Milestone_RoadBlockade (18)", "Test") },
            {2, (102, "Milestone_RoadBlockade (19)", "Test") },
            {2, (102, "Milestone_RoadBlockade (20)", "Test") },
            {2, (102, "Milestone_RoadBlockade (21)", "Test") },
            {2, (102, "Milestone_RoadBlockade (22)", "Test") },
            {2, (102, "Milestone_RoadBlockade (23)", "Test") },
            {2, (102, "Milestone_RoadBlockade (24)", "Test") },
            {2, (102, "Milestone_RoadBlockade (25)", "Test") },
            {2, (102, "Milestone_RoadBlockade (26)", "Test") },
            {2, (102, "Milestone_RoadBlockade (27)", "Test") },
            {2, (102, "Milestone_RoadBlockade (28)", "Test") },
            {2, (102, "Milestone_RoadBlockade (29)", "Test") },
            {2, (102, "Milestone_RoadBlockade (30)", "Test") },
            {2, (102, "Milestone_RoadBlockade (31)", "Test") },
            {2, (102, "Milestone_RoadBlockade (32)", "Test") },
            {2, (102, "Milestone_RoadBlockade (33)", "Test") },
            {2, (102, "Milestone_RoadBlockade (34)", "Test") },
            {2, (102, "Milestone_RoadBlockade (35)", "Test") },
            {2, (102, "Milestone_RoadBlockade (36)", "Test") },
            {2, (102, "Milestone_RoadBlockade (37)", "Test") },
            {2, (102, "Milestone_RoadBlockade (38)", "Test") },
            {2, (102, "Milestone_RoadBlockade (39)", "Test") },
            {2, (102, "Milestone_RoadBlockade (40)", "Test") },
            {2, (102, "Milestone_RoadBlockade (41)", "Test") },
            {2, (102, "Milestone_RoadBlockade (42)", "Test") },
            {2, (102, "Milestone_RoadBlockade (43)", "Test") },
            {2, (102, "Milestone_RoadBlockade (44)", "Test") },
            {2, (102, "Milestone_RoadBlockade (45)", "Test") },

            /// Area 5 - Shed
            {2, (102, "Milestone_Shed (1)", "Test") },

            /// Area 5 - Sidewalk Panel
            {2, (102, "Milestone_SidewalkPanel (40)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (41)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (42)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (43)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (44)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (45)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (46)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (47)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (48)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (49)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (50)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (51)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (52)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (53)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (54)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (55)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (56)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (57)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (58)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (59)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (60)", "Test") },
            {2, (102, "Milestone_SidewalkPanel (61)", "Test") },

            /// Area 5 - Stop Sign
            {2, (102, "Milestone_StopSign (7)", "Test") },
            {2, (102, "Milestone_StopSign (8)", "Test") },
            {2, (102, "Milestone_StopSign (9)", "Test") },
            {2, (102, "Milestone_StopSign (10)", "Test") },
            {2, (102, "Milestone_StopSign (11)", "Test") },
            {2, (102, "Milestone_StopSign (12)", "Test") },
            {2, (102, "Milestone_StopSign (13)", "Test") },
            {2, (102, "Milestone_StopSign (14)", "Test") },

            /// Area 5 - Street Sign
            {2, (102, "Milestone_StreetSign (5)", "Test") },

            /// Area 5 - Sun Umbrella
            {2, (102, "Milestone_SunUmbrella (5)", "Test") },

            /// Area 5 - Taxi
            {2, (102, "Milestone_Taxi", "Test") },

            /// Area 5 - Tent
            {2, (102, "Milestone_Tent (4)", "Test") },
            {2, (102, "Milestone_Tent (5)", "Test") },
            {2, (102, "Milestone_Tent (6)", "Test") },
            {2, (102, "Milestone_Tent (7)", "Test") },
            {2, (102, "Milestone_Tent (8)", "Test") },
            {2, (102, "Milestone_Tent (9)", "Test") },
            {2, (102, "Milestone_Tent (10)", "Test") },
            {2, (102, "Milestone_Tent (11)", "Test") },

            /// Area 5 - Traffic Cone
            {2, (102, "Milestone_TrafficCone (25)", "Test") },

            /// Area 5 - Trash Can
            {2, (102, "Milestone_TrashCan (14)", "Test") },
            {2, (102, "Milestone_TrashCan (15)", "Test") },
            {2, (102, "Milestone_TrashCan (16)", "Test") },
            {2, (102, "Milestone_TrashCan (17)", "Test") },
            {2, (102, "Milestone_TrashCan (18)", "Test") },
            {2, (102, "Milestone_TrashCan (19)", "Test") },
            {2, (102, "Milestone_TrashCan (20)", "Test") },
            {2, (102, "Milestone_TrashCan (21)", "Test") },
            {2, (102, "Milestone_TrashCan (22)", "Test") },

            /// Area 5 - Tree
            {2, (102, "Milestone_Tree (29)", "Test") },
            {2, (102, "Milestone_Tree (30)", "Test") },
            {2, (102, "Milestone_Tree (31)", "Test") },
            {2, (102, "Milestone_Tree (32)", "Test") },
            {2, (102, "Milestone_Tree (33)", "Test") },
            {2, (102, "Milestone_Tree (34)", "Test") },
            {2, (102, "Milestone_Tree (35)", "Test") },
            {2, (102, "Milestone_Tree (36)", "Test") },
            {2, (102, "Milestone_Tree (37)", "Test") },
            {2, (102, "Milestone_Tree (38)", "Test") },
            {2, (102, "Milestone_Tree (39)", "Test") },
            {2, (102, "Milestone_Tree (40)", "Test") },
            {2, (102, "Milestone_Tree (41)", "Test") },
            {2, (102, "Milestone_Tree (42)", "Test") },
            {2, (102, "Milestone_Tree (43)", "Test") },
            {2, (102, "Milestone_Tree (44)", "Test") },
            {2, (102, "Milestone_Tree (45)", "Test") },

            /// Area 5 - Tree Stump
            {2, (102, "Milestone_TreeStump (7)", "Test") },
            {2, (102, "Milestone_TreeStump (8)", "Test") },
            {2, (102, "Milestone_TreeStump (10)", "Test") },

            /// Area 5 - Trellis
            {2, (102, "Milestone_Trellis (5)", "Test") },

            /// Area 5 - Truck
            {2, (102, "Milestone_Truck (5)", "Test") },
            {2, (102, "Milestone_Truck (6)", "Test") },
            {2, (102, "Milestone_Truck (7)", "Test") },

            /// Area 5 - Van
            {2, (102, "Milestone_Van (4)", "Test") },
            {2, (102, "Milestone_Van (5)", "Test") },

            /// Area 5 - Watering Can
            {2, (102, "Milestone_WateringCan (6)", "Test") },

            /// Area 5 - Wheelbarrow
            {2, (102, "Milestone_WheelBarrow (7)", "Test") },
            {2, (102, "Milestone_WheelBarrow (8)", "Test") },
            {2, (102, "Milestone_WheelBarrow (9)", "Test") },
            {2, (102, "Milestone_WheelBarrow (10)", "Test") },
            {2, (102, "Milestone_WheelBarrow (11)", "Test") },
            {2, (102, "Milestone_WheelBarrow (12)", "Test") },

            /// Area 5 - Yield Sign
            {2, (102, "Milestone_YieldSign (8)", "Test") },
            {2, (102, "Milestone_YieldSign (9)", "Test") },
            {2, (102, "Milestone_YieldSign (10)", "Test") },
            {2, (102, "Milestone_YieldSign (11)", "Test") },
            {2, (102, "Milestone_YieldSign (12)", "Test") },
            {2, (102, "Milestone_YieldSign (13)", "Test") }
        };
    }
}

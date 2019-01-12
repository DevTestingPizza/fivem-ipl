using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace IPL
{
    public class Ipl : BaseScript
    {
        public enum BlipIcon
        {
            Default = 1,
            Waypoint = 8,
            Store = 11,
            Store2 = 52,
            Jet = 16,
            CableCart = 36,
            RaceFinish = 38,
            Safehouse = 40,
            Helicopter = 43,
            Garage = 50,
            Pill = 51,
            Taxi = 56,
            PoliceBadge = 60,
            Hospital = 61,
            QuestionMark = 66,
            ArmoredVan = 67,
            FishHook = 68,
            Barber = 71,
            Lsc = 72,
            ClothesShop = 73,
            Tattoo = 73,
            A = 76,
            L = 77,
            M = 78,
            T = 79,
            H = 80,
            Rampage = 84,
            TourBus = 85,
            F = 88,
            C = 89,
            Plane = 90,
            Cocktail = 93,
            Parachute = 94,
            Carwash = 100,
            Disguise = 102,
            Darts = 103,
            B = 106,
            DollarSign = 108,
            Golf = 109,
            Gun = 110,
            Target = 119,
            S = 120,
            StripClub = 121,
            Tennis = 122,
            Triathlon = 126,
            RaceHelemetAndFlag = 127,
            ChatBubble = 133,
            Film = 135,
            Music = 136,
            Weed = 140,
            Deer = 141,
            DuneBuggy = 147,
            NQuestionMark = 149,
            Rifle = 150,
            Bat = 151,
            Grenade = 152,
            Health = 153,
            Knife = 154,
            Bat2 = 155,
            Pistol = 156,
            Rpg = 157,
            Shotgun = 158,
            Smg = 159,
            SniperRifle = 160,
            POI = 162,
            PassiveMode = 163,
            Flag = 164,
            Minigun = 173,
            Rifle2 = 174,
            BodyArmor = 175,
            Castle = 181,
            Camera = 184,
            Handcuffs = 188,
            Yoga = 197,
            Taxi2 = 198,
            Shrink = 205,
            Epsilon = 206,
            DollarSign2 = 207,
            Car = 255,
            Bike = 226,
            CarWithGun = 229,
            Fence = 238,
            Plane2 = 251,
            Key = 255,
            Fairground = 266,
            P = 267,
            Altruist = 269,
            Bone = 273,
            Dead = 274,
            DollarSignSmall = 277,
            LipsMakeup = 279,
            PersonWaving = 280,
            FenceBig = 285,
            MissionStar = 304,
            MissionShieldWithCross = 305,
            QuestionMarkInSquare = 306,
            BigPlane = 307,
            Sub = 308,
            Rampage2 = 310,
            Muscle = 311,
            GunRange = 313,
            AirRace = 314,
            LandRace = 315,
            SeaRace = 316,
            TrashTruck = 318,
            SafeHouseBlack = 350,
            SmallBriefcase = 351,
            Mz = 352,
            LightningZap = 354,
            D = 355,
            MarinaDock = 356,
            SafehouseGarage = 357,
            GolfHoleFlagRed = 358,
            PlaneHangar = 359,
            HelicopterPad = 360,
            JerryCan = 361,
            Mask = 362,
            Hs = 363,
            RecycleSign = 364,
            BoilerSuit = 365,
            Checkmark = 367,
            Rocket = 368,
            GarageBlack = 369,
            HelicopterPadBlack = 370,
            MarinaDockBlack = 371,
            PlaneHangarBlack = 372,
            HouseForSale = 374,
            HouseForSaleBlack = 375,
            BicycleRace = 376,
            Jetpack = 377,
            Rampage3 = 378,
            RacePerson = 379,
            CarCollision = 380,
            Blimp = 401,
            Wrench = 402,
            SmallPill = 403,
            Dinghy = 404,
            Briefcase = 408,
            Trophy = 409,
            Sailboat = 410,
            HouseOutline = 411,
            TinyJerryCan = 415,
            AmericanFlag = 419,
            WhiteFlag = 420,
            Tank = 421,
            SpeedBoat = 427,
            Stopwatch = 430,
            DollarSignInCircle = 431,
            Target2 = 432,
            Target3 = 433,
            DollarSignInSquare = 434,
            RaceJump = 435,
            Fire = 436,
            Rampage4 = 437,
            Crown = 439,
            BriefcaseWithCross = 440,
            CrossArrows = 441,
            Wolf = 442,
            LD = 445,
            Mechanic = 446,
            Yacht = 455,
            QuestionMark2 = 456,
            Target4 = 458,
            Wifi = 459,
            Insurgant = 460,
            ShieldWithCross = 461,
            SmallWolf = 463,
            Hourglass = 464,
            QuestionMarkSmall = 465,
            StopwatchTimer = 466,
            CircleArrows = 467,
            Eye = 468,
            Weed2 = 469,
            Shotgun2 = 470,
            Jetski = 471,
            EyeDisabled = 472,
            Hangar = 473,
            HangarBlack = 474,
            CeoOffice = 475,
            CeoOfficeBlack = 476,
            BigTruck = 477,
            Crate = 478,
            LargeTrailer = 479,
            PersonStanding = 480,
            HelicopterWithHook = 481,
            Speedometer = 483,
            Ghost = 484,
            RemoteControl = 485,
            Bomb = 486,
            Shield = 487,
            BurningWheel = 488,
            Heart = 489,
            BurningDollarSign = 490,
            MissionVs = 491,
            HouseWithGarage = 492,
            BikeInCircleWithCrossArrows = 493,
            BikeInCircle = 494,
            BikeWithFlags = 494,
            Weed3 = 496,
            Ticket = 497,
            IdCard = 498,
            Lab = 499,
            DollarNote = 500,
            DrugsPackage = 501,
            QuadAtv = 512,
            PrisonBus = 513,
            DrugsPackage2 = 514,
            UploadIcon = 515,
            LaptopBlack = 521
        }

        public struct IPL
        {
            public string name;
            public Vector3 location;
            public Dictionary<string, List<string>> interiorVariants;
            public BlipIcon sprite;
            public Dictionary<string, int> interiorProps;
        }
        List<IPL> ipls = new List<IPL>();

        public Ipl()
        {
            #region add IPLs to list
            ipls.Add(new IPL()
            {
                name = "Simeon's Showroom",
                sprite = BlipIcon.GarageBlack,
                location = new Vector3(-47.16170f, -1115.3327f, 26.5f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "shr_int" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Trevor's Trailer",
                sprite = BlipIcon.Safehouse,
                location = new Vector3(1985.48132f, 3828.76757f, 32.5f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "trevorstrailertidy" }, // clean
                    ["trash"] = new List<string>() { "TrevorsTrailerTrash" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Jewel Store",
                sprite = BlipIcon.Crown,
                location = new Vector3(-637.20159f, -239.16250f, 38.1f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "post_hiest_unload" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Rooftop Construction",
                sprite = BlipIcon.Wrench,
                location = new Vector3(-585.8247f, -282.72f, 35.45475f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "refit_unload" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Heist Union Depository",
                sprite = BlipIcon.DollarNote,
                location = new Vector3(2.69689322f, -667.0166f, 16.1306286f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "FINBANK", "v_tunnel_hole" },
                    ["default_no_hole"] = new List<string>() { "FINBANK", "v_tunnel_hole_swap" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Morgue",
                sprite = BlipIcon.Dead,
                location = new Vector3(239.75195f, -1360.64965f, 39.53437f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "Coroner_Int_on", "coronertrash" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Cluckin Bell",
                sprite = BlipIcon.Crate,
                location = new Vector3(-146.3837f, 6161.5f, 30.2062f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "CS1_02_cf_onmission1", "CS1_02_cf_onmission2", "CS1_02_cf_onmission3", "CS1_02_cf_onmission4" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Grapeseed's Farm",
                sprite = BlipIcon.SafeHouseBlack,
                location = new Vector3(2447.9f, 4973.4f, 47.7f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "farm", "farmint", "farm_lod", "farm_props", "des_farmhouse" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "FIB",
                sprite = BlipIcon.CeoOffice,
                location = new Vector3(105.4557f, -745.4835f, 44.7548f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "FIBlobby" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Lester's factory",
                sprite = BlipIcon.Hangar,
                location = new Vector3(716.84f, -962.05f, 31.59f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "id2_14_during_door", "id2_14_during1" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Life Invader lobby",
                sprite = BlipIcon.CeoOffice,
                location = new Vector3(-1047.9f, -233.0f, 39.0f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "facelobby" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Carwash",
                sprite = BlipIcon.Carwash,
                location = new Vector3(55.7f, -1391.3f, 30.5f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "Carwash_with_spinners" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Fame Or Shame",
                sprite = BlipIcon.CeoOffice,
                location = new Vector3(-248.4915f, -2010.5090f, 34.5742f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "sp1_10_real_interior", "sp1_10_real_interior_lod" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Mission House",
                sprite = BlipIcon.SafeHouseBlack,
                location = new Vector3(-3086.428f, 339.2523f, 6.3717f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "ch1_02_open" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Mod Shop",
                sprite = BlipIcon.Mechanic,
                location = new Vector3(970.27453f, -1826.56982f, 31.11477f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "bkr_bi_id1_23_door" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Grave",
                sprite = BlipIcon.Dead,
                location = new Vector3(-282.46380000f, 2835.84500000f, 55.91446000f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "lr_cs6_08_grave_closed" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Stab City",
                sprite = BlipIcon.BikeWithFlags,
                location = new Vector3(49.49379000f, 3744.47200000f, 46.38629000f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "methtrailer_grp1" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "The Lost Clubhouse",
                sprite = BlipIcon.BikeWithFlags,
                location = new Vector3(984.1552f, -95.3662f, 74.50f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "bkr_bi_hw1_13_int" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Raton Canyon River",
                sprite = BlipIcon.SmallWolf,
                location = new Vector3(-1652.83f, 4445.28f, 2.52f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "CanyonRvrShallow" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Pillbox Hospital",
                sprite = BlipIcon.Hospital,
                location = new Vector3(305f, -583f, 50f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "rc12b_default" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Mission House",
                sprite = BlipIcon.Safehouse,
                location = new Vector3(-1117.1632080078f, 303.090698f, 66.52217f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "bh1_47_joshhse_unburnt", "bh1_47_joshhse_unburnt_lod" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Zancudo River",
                sprite = BlipIcon.SmallWolf,
                location = new Vector3(86.815f, 3191.649f, 30.463f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "cs3_05_water_grp1", "cs3_05_water_grp1_lod", "cs3_05_water_grp2", "cs3_05_water_grp2_lod" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Cassidy Creek",
                sprite = BlipIcon.SmallWolf,
                location = new Vector3(-425.677f, 4433.404f, 27.3253f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "canyonriver01", "canyonriver01_lod" },
                }
            });
            ipls.Add(new IPL()
            {
                name = "Heist Aircraft Carrier",
                sprite = BlipIcon.Yacht,
                location = new Vector3(3082.3117f, -4717.1191f, 15.2622f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>()
                    {
                        "hei_carrier",
                        "hei_carrier_distantlights",
                        "hei_Carrier_int1",
                        "hei_Carrier_int2",
                        "hei_Carrier_int3",
                        "hei_Carrier_int4",
                        "hei_Carrier_int5",
                        "hei_Carrier_int6",
                        "hei_carrier_lodlights",
                        "hei_carrier_slod"
                    }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Heist Yacht",
                sprite = BlipIcon.Yacht,
                location = new Vector3(-2043.974f, -1031.582f, 11.981f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>()
                    {
                        "hei_yacht_heist",
                        "hei_yacht_heist_Bar",
                        "hei_yacht_heist_Bedrm",
                        "hei_yacht_heist_Bridge",
                        "hei_yacht_heist_DistantLights",
                        "hei_yacht_heist_enginrm",
                        "hei_yacht_heist_LODLights",
                        "hei_yacht_heist_Lounge",
                    }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(848f, 3004f, 44f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case0_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(2118f, 3330f, 46f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case1_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(2491f, 3150f, 50f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case2_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(486f, 3005f, 42f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case3_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(-391f, 4354f, 57f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case4_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(1815f, 4706f, 41f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case5_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(1571f, 2241f, 79f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case6_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(-772f, 5938f, 23f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case7_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(31f, 2945f, 58f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case9_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(-3046f, 3331f, 11f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case10_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker",
                sprite = BlipIcon.Hangar,
                location = new Vector3(-3171f, 1375f, 18f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "gr_case11_bunkerclosed" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bunker Interior",
                sprite = BlipIcon.LaptopBlack,
                location = new Vector3(892.6384f, -3245.8664f, -98.2645f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>()
                    {
                        "grdlc_int_01_shell",
                        "gr_grdlc_int_01",
                        "gr_grdlc_int_02",
                        "gr_entrance_placement",
                        "gr_grdlc_interior_placement",
                        "gr_grdlc_interior_placement_interior_0_grdlc_int_01_milo_",
                        "gr_grdlc_interior_placement_interior_1_grdlc_int_02_milo_",
                    }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Red Carpet",
                sprite = BlipIcon.Trophy,
                location = new Vector3(300.5927f, 199.7589f, 104.3776f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "redCarpet" }
                }
            });
            ipls.Add(new IPL()
            {
                name = "Bahama Mamas",
                sprite = BlipIcon.Cocktail,
                location = new Vector3(-1388.0013f, -618.41967f, 30.819599f),
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>() { "hei_sm_16_interior_v_bahama_milo_" }
                }
            });
            ipls.Add(new IPL()
            {
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>()
                    {
                        "sm_smugdlc_interior_placement_interior_0_smugdlc_int_01_milo_",
                        "sm_smugdlc_interior_placement"
                    }
                },
                interiorProps = new Dictionary<string, int>()
                {
                    ["set_lighting_hangar_a"] = -1,
                    ["set_floor_1"] = -1,
                    ["set_bedroom_modern"] = -1,
                    ["set_office_modern"] = -1,
                    ["set_bedroom_blinds_open"] = -1,
                    ["set_lighting_wall_tint01"] = -1,
                    ["set_tint_shell"] = 1,
                    ["set_bedroom_tint"] = 1,
                    ["set_crane_tint"] = 1,
                    ["set_modarea"] = 1,
                    ["set_lighting_tint_props"] = 1,
                    ["set_floor_decal_1"] = 1,
                },
                location = new Vector3(-1152.17f, -3410.83f, 13.95f),
                name = "Aircraft Hangar",
                sprite = BlipIcon.PlaneHangar

            });
            ipls.Add(new IPL()
            {
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>()
                    {
                        "sm_smugdlc_interior_placement_interior_0_smugdlc_int_01_milo_",
                        "sm_smugdlc_interior_placement"
                    }
                },
                interiorProps = new Dictionary<string, int>()
                {
                    ["set_lighting_hangar_a"] = -1,
                    ["set_floor_1"] = -1,
                    ["set_bedroom_modern"] = -1,
                    ["set_office_modern"] = -1,
                    ["set_bedroom_blinds_open"] = -1,
                    ["set_lighting_wall_tint01"] = -1,
                    ["set_tint_shell"] = 2,
                    ["set_bedroom_tint"] = 2,
                    ["set_crane_tint"] = 2,
                    ["set_modarea"] = 2,
                    ["set_lighting_tint_props"] = 2,
                    ["set_floor_decal_1"] = 2,
                },
                location = new Vector3(-1395.4f, -3266.66f, 13.95f),
                name = "Aircraft Hangar",
                sprite = BlipIcon.PlaneHangar
            });
            ipls.Add(new IPL()
            {
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>()
                    {
                        "sm_smugdlc_interior_placement_interior_0_smugdlc_int_01_milo_",
                        "sm_smugdlc_interior_placement"
                    }
                },
                interiorProps = new Dictionary<string, int>()
                {
                    ["set_lighting_hangar_a"] = -1,
                    ["set_floor_1"] = -1,
                    ["set_bedroom_modern"] = -1,
                    ["set_office_modern"] = -1,
                    ["set_bedroom_blinds_open"] = -1,
                    ["set_lighting_wall_tint01"] = -1,
                    ["set_tint_shell"] = 3,
                    ["set_bedroom_tint"] = 3,
                    ["set_crane_tint"] = 3,
                    ["set_modarea"] = 3,
                    ["set_lighting_tint_props"] = 3,
                    ["set_floor_decal_1"] = 3,
                },
                location = new Vector3(-2470.22f, 3274.79f, 32.83f),
                name = "Aircraft Hangar",
                sprite = BlipIcon.PlaneHangar
            });
            ipls.Add(new IPL()
            {
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>()
                    {
                        "sm_smugdlc_interior_placement_interior_0_smugdlc_int_01_milo_",
                        "sm_smugdlc_interior_placement"
                    }
                },
                interiorProps = new Dictionary<string, int>()
                {
                    ["set_lighting_hangar_a"] = -1,
                    ["set_floor_1"] = -1,
                    ["set_bedroom_modern"] = -1,
                    ["set_office_modern"] = -1,
                    ["set_bedroom_blinds_open"] = -1,
                    ["set_lighting_wall_tint01"] = -1,
                    ["set_tint_shell"] = 4,
                    ["set_bedroom_tint"] = 4,
                    ["set_crane_tint"] = 4,
                    ["set_modarea"] = 4,
                    ["set_lighting_tint_props"] = 4,
                    ["set_floor_decal_1"] = 4,
                },
                location = new Vector3(-2021.5f, 3157.4f, 32.81f),
                name = "Aircraft Hangar",
                sprite = BlipIcon.PlaneHangar
            });
            ipls.Add(new IPL()
            {
                interiorVariants = new Dictionary<string, List<string>>()
                {
                    ["default"] = new List<string>()
                    {
                        "sm_smugdlc_interior_placement_interior_0_smugdlc_int_01_milo_",
                        "sm_smugdlc_interior_placement"
                    }
                },
                interiorProps = new Dictionary<string, int>()
                {
                    ["set_lighting_hangar_a"] = -1,
                    ["set_floor_1"] = -1,
                    ["set_bedroom_modern"] = -1,
                    ["set_office_modern"] = -1,
                    ["set_bedroom_blinds_open"] = -1,
                    ["set_lighting_wall_tint01"] = -1,
                    ["set_tint_shell"] = 5,
                    ["set_bedroom_tint"] = 5,
                    ["set_crane_tint"] = 5,
                    ["set_modarea"] = 5,
                    ["set_lighting_tint_props"] = 5,
                    ["set_floor_decal_1"] = 5,
                },
                location = new Vector3(-1878.01f, 3108.85f, 32.81f),
                name = "Aircraft Hangar",
                sprite = BlipIcon.PlaneHangar
            });
            #endregion



            EnableInteriorProp(GetInteriorAtCoordsWithType(-38.62f, -1099.01f, 27.31f, "v_carshowroom"), "csr_beforeMission");
            EnableInteriorProp(GetInteriorAtCoordsWithType(-38.62f, -1099.01f, 27.31f, "v_carshowroom"), "shutter_open");

            #region latest DLC IPLs (exact location per ipl is unknown)
            List<string> dlcIpls = new List<string>()
            {
                "xm_x17dlc_int_placement",
                "xm_x17dlc_int_placement_interior_0_x17dlc_int_base_ent_milo_",
                "xm_x17dlc_int_placement_interior_10_x17dlc_int_tun_straight_milo_",
                "xm_x17dlc_int_placement_interior_11_x17dlc_int_tun_slope_flat_milo_",
                "xm_x17dlc_int_placement_interior_12_x17dlc_int_tun_flat_slope_milo_",
                "xm_x17dlc_int_placement_interior_13_x17dlc_int_tun_30d_r_milo_",
                "xm_x17dlc_int_placement_interior_14_x17dlc_int_tun_30d_l_milo_",
                "xm_x17dlc_int_placement_interior_15_x17dlc_int_tun_straight_milo_",
                "xm_x17dlc_int_placement_interior_16_x17dlc_int_tun_straight_milo_",
                "xm_x17dlc_int_placement_interior_17_x17dlc_int_tun_slope_flat_milo_",
                "xm_x17dlc_int_placement_interior_18_x17dlc_int_tun_slope_flat_milo_",
                "xm_x17dlc_int_placement_interior_19_x17dlc_int_tun_flat_slope_milo_",
                "xm_x17dlc_int_placement_interior_1_x17dlc_int_base_loop_milo_",
                "xm_x17dlc_int_placement_interior_20_x17dlc_int_tun_flat_slope_milo_",
                "xm_x17dlc_int_placement_interior_21_x17dlc_int_tun_30d_r_milo_",
                "xm_x17dlc_int_placement_interior_22_x17dlc_int_tun_30d_r_milo_",
                "xm_x17dlc_int_placement_interior_23_x17dlc_int_tun_30d_r_milo_",
                "xm_x17dlc_int_placement_interior_24_x17dlc_int_tun_30d_r_milo_",
                "xm_x17dlc_int_placement_interior_25_x17dlc_int_tun_30d_l_milo_",
                "xm_x17dlc_int_placement_interior_26_x17dlc_int_tun_30d_l_milo_",
                "xm_x17dlc_int_placement_interior_27_x17dlc_int_tun_30d_l_milo_",
                "xm_x17dlc_int_placement_interior_28_x17dlc_int_tun_30d_l_milo_",
                "xm_x17dlc_int_placement_interior_29_x17dlc_int_tun_30d_l_milo_",
                "xm_x17dlc_int_placement_interior_2_x17dlc_int_bse_tun_milo_",
                "xm_x17dlc_int_placement_interior_30_v_apart_midspaz_milo_",
                "xm_x17dlc_int_placement_interior_31_v_studio_lo_milo_",
                "xm_x17dlc_int_placement_interior_32_v_garagem_milo_",
                "xm_x17dlc_int_placement_interior_33_x17dlc_int_02_milo_",
                "xm_x17dlc_int_placement_interior_34_x17dlc_int_lab_milo_",
                "xm_x17dlc_int_placement_interior_35_x17dlc_int_tun_entry_milo_",
                "xm_x17dlc_int_placement_interior_3_x17dlc_int_base_milo_",
                "xm_x17dlc_int_placement_interior_4_x17dlc_int_facility_milo_",
                "xm_x17dlc_int_placement_interior_5_x17dlc_int_facility2_milo_",
                "xm_x17dlc_int_placement_interior_6_x17dlc_int_silo_01_milo_",
                "xm_x17dlc_int_placement_interior_7_x17dlc_int_silo_02_milo_",
                "xm_x17dlc_int_placement_interior_8_x17dlc_int_sub_milo_",
                "xm_x17dlc_int_placement_interior_9_x17dlc_int_01_milo_",
                "xm_x17dlc_int_placement_strm_0",
                "xm_bunkerentrance_door",
                "xm_hatch_01_cutscene",
                "xm_hatch_02_cutscene",
                "xm_hatch_03_cutscene",
                "xm_hatch_04_cutscene",
                "xm_hatch_06_cutscene",
                "xm_hatch_07_cutscene",
                "xm_hatch_08_cutscene",
                "xm_hatch_09_cutscene",
                "xm_hatch_10_cutscene",
                "xm_hatch_closed",
                "xm_hatch_open",
                "xm_hatches_terrain",
                "xm_hatches_terrain_lod",
                "xm_mpchristmasadditions",
                "xm_siloentranceclosed_x17",
            };

            foreach (string dlcipl in dlcIpls)
            {
                if (!IsIplActive(dlcipl))
                {
                    RequestIpl(dlcipl);
                    //RemoveIpl(dlcipl);
                }
                else
                {
                    RemoveIpl(dlcipl);
                    RequestIpl(dlcipl);
                }
            }

            //int interiorID = GetInteriorAtCoords(-1266.0f, -3014.0f, -47.0f);
            //if (IsValidInterior(interiorID))
            //{
            //EnableInteriorProp(interiorID, "set_lighting_hangar_a");
            //EnableInteriorProp(interiorID, "set_tint_shell");
            //EnableInteriorProp(interiorID, "set_bedroom_tint");
            //EnableInteriorProp(interiorID, "set_crane_tint");
            //EnableInteriorProp(interiorID, "set_modarea");
            //EnableInteriorProp(interiorID, "set_lighting_tint_props");
            //EnableInteriorProp(interiorID, "set_floor_1");
            //EnableInteriorProp(interiorID, "set_floor_decal_1");
            //EnableInteriorProp(interiorID, "set_bedroom_modern");
            //EnableInteriorProp(interiorID, "set_office_modern");
            //EnableInteriorProp(interiorID, "set_bedroom_blinds_open");
            //EnableInteriorProp(interiorID, "set_lighting_wall_tint01");
            // SetInteriorPropColor(interiorID, "set_tint_shell", 4);
            // SetInteriorPropColor(interiorID, "set_bedroom_tint", 4);
            // SetInteriorPropColor(interiorID, "set_crane_tint", 4);
            // SetInteriorPropColor(interiorID, "set_modarea", 4);
            // SetInteriorPropColor(interiorID, "set_lighting_tint_props", 4);
            // SetInteriorPropColor(interiorID, "set_floor_decal_1", 4);

            //    RefreshInterior(interiorID);
            //}
            #endregion

            #region Creating teleports
            foreach (IPL ipl in ipls)
            {
                if (ipl.interiorVariants != null)
                {
                    foreach (string name in ipl.interiorVariants["default"])
                    {
                        if (!IsIplActive(name))
                        {
                            RequestIpl(name);
                        }
                        else
                        {
                            RemoveIpl(name);
                            RequestIpl(name);
                        }
                    }
                }
                if (ipl.interiorProps != null)
                {
                    var interior = GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z);

                    Debug.WriteLine("interior for ipl: " + ipl.name);
                    if (IsValidInterior(interior))
                    {
                        //Debug.WriteLine("valid interior for ipl: " + ipl.name);
                        foreach (KeyValuePair<string, int> iprop in ipl.interiorProps)
                        {
                            if (!IsInteriorPropEnabled(interior, iprop.Key))
                            {
                                Debug.WriteLine($"enabling interior prop {iprop.Key} for ipl {ipl.name}");
                                EnableInteriorProp(interior, iprop.Key);
                            }
                            if (iprop.Value != -1)
                            {
                                Debug.WriteLine($"setting interior prop color {iprop.Value} for ipl {ipl.name} for prop {iprop.Key}");
                                SetInteriorPropColor(interior, iprop.Key, iprop.Value);
                            }
                        }
                        RefreshInterior(interior);
                    }
                }
                if (ipl.name != "Bunker Interior")
                {
                    //var blip = AddBlipForCoord(ipl.location.X, ipl.location.Y, ipl.location.Z);
                    //SetBlipSprite(blip, (int)ipl.sprite);
                    //BeginTextCommandSetBlipName("STRING");
                    //AddTextComponentString(ipl.name);
                    //EndTextCommandSetBlipName(blip);
                    //SetBlipAsShortRange(blip, true);
                    if (ipl.name == "Bunker")
                    {
                        CreateTeleport(ipl.location, new Vector3(892.6384f, -3245.8664f, -98.2645f));
                    }
                    else if (ipl.name == "Aircraft Hangar")
                    {
                        CreateTeleport(ipl.location, new Vector3(-1267.2f, -2970.02f, -48.49f));

                    }
                    ////{"name": "Example Blip","coordinates": {"x": 472.94,"y": -3035.96,"z": 6.2},"spriteID": 1,"color": 1}
                    //Debug.Write("{" + $"\"name\":\"{ipl.name}\",\"coordinates\":" + "{" + $"\"x\":{ipl.location.X}, \"y\":{ipl.location.Y},\"z\":{ipl.location.Z}" + "}, \"spriteID\":" + ((int)ipl.sprite).ToString() + ",\"color\":1},\n");
                }
                else
                {
                    /*
                    standard_bunker_set
                    upgrade_bunker_set

                    standard_security_set
                    security_upgrade
                    Office_blocker_set
                    Office_Upgrade_set
                    gun_range_blocker_set
                    gun_wall_blocker
                    gun_range_lights
                    gun_locker_upgrade
                    Gun_schematic_set

                    */


                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "standard_bunker_set");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "upgrade_bunker_set");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "standard_security_set");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "security_upgrade");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Office_blocker_set");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Office_Upgrade_set");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "gun_range_blocker_set");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "gun_wall_blocker");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "gun_range_lights");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "gun_locker_upgrade");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Gun_schematic_set");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Bunker_Style_A");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Bunker_Style_B");
                    DisableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Bunker_Style_C");


                    // style
                    EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Bunker_Style_A");

                    // prop sets
                    EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "upgrade_bunker_set");
                    //EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Office_blocker_set");
                    EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Office_Upgrade_set");
                    //EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "gun_range_blocker_set");
                    //EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "standard_security_set");
                    EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "security_upgrade");
                    //EnableInteriorProp(258561, "standard_bunker_set");

                    // props
                    //EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "gun_wall_blocker");
                    EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "gun_range_lights");
                    EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "gun_locker_upgrade");
                    EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Gun_schematic_set");

                    //EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Office_Upgrade_set");
                    //EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "Gun_schematic_set");
                    //EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "security_upgrade");
                    //EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "gun_range_lights");
                    //EnableInteriorProp(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z), "gun_locker_upgrade");

                    // refresh interior
                    RefreshInterior(GetInteriorAtCoords(ipl.location.X, ipl.location.Y, ipl.location.Z));
                    //SetRadarBigmapEnabled(true, true);

                }

            }
            #endregion

            Tick += OnTick;

            Tick += DesObjectVaultTick;

        }

        private readonly Vector3 triggerLocation = new Vector3(9f, -650f, 16f);

        private async Task DesObjectVaultTick()
        {
            var dist = Game.PlayerPed.Position.DistanceToSquared(triggerLocation);

            if (dist < 2000f)
            {
                if (dist < 500f)
                {
                    var desObj1 = GetDesObject(7.25f, -656.98f, 17.14f, 50.0f, "des_finale_vault");
                    var desObj2 = GetDesObject(7.25f, -656.98f, 17.14f, 50.0f, "des_finale_tunnel");

                    if (DoesDesObjectExist(desObj1) && DoesDesObjectExist(desObj2))
                    {
                        var state1 = GetDesObjectState(desObj1);
                        var state2 = GetDesObjectState(desObj2);

                        if (state1 < 6 || state2 < 6)
                        {
                            SetDesObjectState(desObj1, 4);
                            SetDesObjectState(desObj2, 4);
                        }

                        if (state1 < 6 && state2 < 6)
                        {
                            DrawMarker(1, triggerLocation.X, triggerLocation.Y, triggerLocation.Z - 1.2f, 0f, 0f, 0f, 0f, 0f, 0f, 1.5f, 1.5f, 1f, 255, 255, 60, 100, false, false, 0, false, null, null, false);
                        }
                        else
                        {
                            if (state1 >= 9 && state2 >= 9)
                            {
                                DrawMarker(1, triggerLocation.X, triggerLocation.Y, triggerLocation.Z - 1.2f, 0f, 0f, 0f, 0f, 0f, 0f, 1.5f, 1.5f, 1f, 255, 60, 60, 100, false, false, 0, false, null, null, false);
                            }
                        }


                        if (dist < 1f)
                        {
                            if (state1 < 6 || state2 < 6)
                            {
                                CitizenFX.Core.UI.Screen.DisplayHelpTextThisFrame("Press ~INPUT_TALK~ to trigger this scene.");
                                if (Game.IsControlJustReleased(0, Control.Talk))
                                {
                                    SetDesObjectState(desObj1, 6);
                                    SetDesObjectState(desObj2, 6);
                                }
                            }
                            else if (state1 >= 9 && state2 >= 9)
                            {
                                CitizenFX.Core.UI.Screen.DisplayHelpTextThisFrame("Press ~INPUT_TALK~ to reset this scene.");
                                if (Game.IsControlJustReleased(0, Control.Talk))
                                {
                                    SetDesObjectState(desObj1, 4);
                                    SetDesObjectState(desObj2, 4);
                                }
                            }

                        }
                    }
                }
            }
            else
            {
                await Delay(1000);
            }
        }

        private Vector3 previousCoords;
        private Dictionary<Vector3, Vector3> teleports = new Dictionary<Vector3, Vector3>();

        private void CreateTeleport(Vector3 fromPos, Vector3 toPos)
        {
            teleports.Add(fromPos, toPos);
        }

        private async Task OnTick()
        {
            if (GetInteriorFromEntity(Game.PlayerPed.Handle) != 0)
            {
                //SetRadarAsInteriorThisFrame(GetInteriorFromEntity(Game.PlayerPed.Handle), Game.PlayerPed.Position.X, Game.PlayerPed.Position.Y, Game.PlayerPed.Position.Z, )
            }

            foreach (KeyValuePair<Vector3, Vector3> tp in teleports)
            {
                DrawMarker(1, tp.Key.X, tp.Key.Y, tp.Key.Z - 1f, 0f, 0f, 0f, 0f, 0f, 0f, 1.5f, 1.5f, 1f, 250, 220, 60, 100, false, false, 0, false, null, null, false);
                var pos = GetEntityCoords(PlayerPedId(), true);
                var target = tp.Key;
                var targetInt = tp.Value;
                if (Vdist(pos.X, pos.Y, pos.Z, target.X, target.Y, target.Z) <= 1f)
                {
                    CitizenFX.Core.UI.Screen.DisplayHelpTextThisFrame("Press ~INPUT_TALK~ to enter the interior.");
                    if (Game.IsControlJustReleased(0, Control.Talk))
                    {
                        previousCoords = pos;
                        DoScreenFadeOut(500);
                        await Delay(500);
                        foreach (IPL _ipl in ipls)
                        {
                            if (_ipl.name == "Aircraft Hangar" && _ipl.location.X == target.X && _ipl.location.Y == target.Y && _ipl.location.Z == target.Z)
                            {
                                Debug.Write("same\n");
                                var interior = GetInteriorAtCoords(targetInt.X, targetInt.Y, targetInt.Z);

                                if (IsValidInterior(interior))
                                {
                                    Debug.Write("valid interior\n");
                                    foreach (KeyValuePair<string, int> iprop in _ipl.interiorProps)
                                    {
                                        Debug.Write("prop\n");
                                        if (!IsInteriorPropEnabled(interior, iprop.Key))
                                        {
                                            EnableInteriorProp(interior, iprop.Key);
                                        }
                                        if (iprop.Value != -1)
                                        {
                                            SetInteriorPropColor(interior, iprop.Key, iprop.Value);
                                        }
                                    }
                                    RefreshInterior(interior);
                                }
                                break;
                            }
                        }
                        StartPlayerTeleport(PlayerId(), targetInt.X, targetInt.Y, targetInt.Z, GetEntityHeading(PlayerPedId()), true, true, true);
                        await Delay(500);
                        DoScreenFadeIn(500);
                    }
                }
                else if (Vdist(pos.X, pos.Y, pos.Z, targetInt.X, targetInt.Y, targetInt.Z) <= 1f)
                {
                    CitizenFX.Core.UI.Screen.DisplayHelpTextThisFrame("Press ~INPUT_TALK~ to exit the interior.");
                    if (Game.IsControlJustReleased(0, Control.Talk))
                    {
                        DoScreenFadeOut(500);
                        await Delay(500);
                        if (previousCoords != null && !previousCoords.IsZero)
                        {
                            StartPlayerTeleport(PlayerId(), previousCoords.X, previousCoords.Y, previousCoords.Z, GetEntityHeading(PlayerPedId()), true, true, true);
                        }
                        else
                        {

                            StartPlayerTeleport(PlayerId(), target.X, target.Y, target.Z, GetEntityHeading(PlayerPedId()), true, true, true);
                        }

                        await Delay(500);
                        DoScreenFadeIn(500);
                    }
                }
            }

            DrawMarker(1, 892.6384f, -3245.8664f, -99.3f, 0f, 0f, 0f, 0f, 0f, 0f, 1.5f, 1.5f, 1f, 250, 220, 60, 100, false, false, 0, false, null, null, false);
            DrawMarker(1, -1267.2f, -2970.02f, -49.45f, 0f, 0f, 0f, 0f, 0f, 0f, 1.5f, 1.5f, 1f, 250, 220, 60, 100, false, false, 0, false, null, null, false);
        }


    }
}

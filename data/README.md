# Stationpedia Reference Library

Extracted directly from live game data via a BepInEx/Harmony plugin on a headless dedicated server.
2435 pages total, chunked alphabetically by title.

**Known gap:** per-device "Logic Types" (which LogicType values a specific structure reads/writes, e.g. what Volume Pump supports) are populated by the game per placed *instance*, not per page template - a fresh/empty world has nothing to source that from, so most device pages won't show a Logic Types section even though the field exists and is dumped when populated. It's not missing data on purpose; forcing full coverage would need spawning one of every constructible prefab into a world first. However, every individual `LogicType.*` enum value (On, Setting, PressureInternal, etc.) has its own dedicated glossary page with a clean description - search for `## LogicType.` across these files for that reference instead.

- [<N:EN:CompositeWallRoundedCornerPanel1> - <N:EN:Text_Y>](00__N_EN_CompositeWallRoundedCornerPanel1_-_N_EN_Text_Y_.md) (100 pages)
- [<N:EN:Text_Z> - Bobble Head (Hard Suit)](01__N_EN_Text_Z_-Bobble_Head_(Hard_Suit).md) (100 pages)
- [Bobble Head (Marine) - Catalytic Filter (Ozone)](02_Bobble_Head_(Marine)-Catalytic_Filter_(Ozone).md) (100 pages)
- [Catalytic Filter (Pollutants) - Composite Roll Cover](03_Catalytic_Filter_(Pollutants)-Composite_Roll_Cover.md) (100 pages)
- [Composite Wall (Type 1) - Crew Module Screen](04_Composite_Wall_(Type_1)-Crew_Module_Screen.md) (100 pages)
- [Crowbar - Filtration](05_Crowbar-Filtration.md) (100 pages)
- [Filtration Liquid - Heavy Cable (Corner)](06_Filtration_Liquid-Heavy_Cable_(Corner).md) (100 pages)
- [Heavy Cable (Straight 10) - Insulated Liquid Pipe (Corner)](07_Heavy_Cable_(Straight_10)-Insulated_Liquid_Pipe_(Corner).md) (100 pages)
- [Insulated Liquid Pipe (Cross Junction) - Kit (Flat Wall)](08_Insulated_Liquid_Pipe_(Cross_Junction)-Kit_(Flat_Wall).md) (100 pages)
- [Kit (Flood Light Large) - Kit (Pipe Igniter)](09_Kit_(Flood_Light_Large)-Kit_(Pipe_Igniter).md) (100 pages)
- [Kit (Pipe Label) - Kit Picture Frame](10_Kit_(Pipe_Label)-Kit_Picture_Frame.md) (100 pages)
- [Kit Portable A Frame Sign (Stripes) - Letter J (Medium)](11_Kit_Portable_A_Frame_Sign_(Stripes)-Letter_J_(Medium).md) (100 pages)
- [Letter K (Large) - Logic Dial](12_Letter_K_(Large)-Logic_Dial.md) (100 pages)
- [Logic Dial Small - LogicType.Discover](13_Logic_Dial_Small-LogicType.Discover.md) (100 pages)
- [LogicType.Dispense - LogicType.RatioHydrochloricAcidInput2](14_LogicType.Dispense-LogicType.RatioHydrochloricAcidInput2.md) (100 pages)
- [LogicType.RatioHydrochloricAcidOutput - LogicType.RatioPollutantInput2](15_LogicType.RatioHydrochloricAcidOutput-LogicType.RatioPollutantInput2.md) (100 pages)
- [LogicType.RatioPollutantOutput - Low temperature resistance](16_LogicType.RatioPollutantOutput-Low_temperature_resistance.md) (100 pages)
- [Low temperature tolerance - Monorail Sloped Rail (14m)](17_Low_temperature_tolerance-Monorail_Sloped_Rail_(14m).md) (100 pages)
- [Monorail Sloped Rail Entry (14m) - Overalls (Paintable)](18_Monorail_Sloped_Rail_Entry_(14m)-Overalls_(Paintable).md) (100 pages)
- [Overalls (Russia) - Power Control](19_Overalls_(Russia)-Power_Control.md) (100 pages)
- [Power Pylon - Security Camera](20_Power_Pylon-Security_Camera.md) (100 pages)
- [Security Printer - Stairwell (Front Right)](21_Security_Printer-Stairwell_(Front_Right).md) (100 pages)
- [Stairwell (No Doors) - Umbilical Socket Angle (Gas)](22_Stairwell_(No_Doors)-Umbilical_Socket_Angle_(Gas).md) (100 pages)
- [Umbilical Socket Angle (Liquid) - Wheat](23_Umbilical_Socket_Angle_(Liquid)-Wheat.md) (100 pages)
- [Wheat - Yellow Coloring](24_Wheat-Yellow_Coloring.md) (35 pages)

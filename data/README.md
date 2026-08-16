# Stationpedia Reference Library

Extracted directly from live game data via a BepInEx/Harmony plugin on a headless dedicated server.
2435 pages total, chunked alphabetically by title.

**Known gap:** per-device "Logic Types" (which LogicType values a specific structure reads/writes, e.g. what Volume Pump supports) are populated by the game per placed *instance*, not per page template - a fresh/empty world has nothing to source that from, so most device pages won't show a Logic Types section even though the field exists and is dumped when populated. It's not missing data on purpose; forcing full coverage would need spawning one of every constructible prefab into a world first. However, every individual `LogicType.*` enum value (On, Setting, PressureInternal, etc.) has its own dedicated glossary page with a clean description - search for `## LogicType.` across these files for that reference instead.

- [Access Bridge - Bobble Head (Marine)](00_Access_Bridge-Bobble_Head_(Marine).md) (100 pages)
- [Body Bag - Catalytic Filter (Pollutants)](01_Body_Bag-Catalytic_Filter_(Pollutants).md) (100 pages)
- [Catalytic Filter (Polluted Water) - Composite Wall (Type 1)](02_Catalytic_Filter_(Polluted_Water)-Composite_Wall_(Type_1).md) (100 pages)
- [Composite Wall (Type 2) - Crew Light](03_Composite_Wall_(Type_2)-Crew_Light.md) (100 pages)
- [Crew Module Active Vent - Filter (Nitrous Oxide)](04_Crew_Module_Active_Vent-Filter_(Nitrous_Oxide).md) (100 pages)
- [Filter (Oxygen) - Hastelloy](05_Filter_(Oxygen)-Hastelloy.md) (100 pages)
- [Hay - Ingot (Steel)](06_Hay-Ingot_(Steel).md) (100 pages)
- [Ingot (Stellite) - Kit (Deep Miner)](07_Ingot_(Stellite)-Kit_(Deep_Miner).md) (100 pages)
- [Kit (Digital Valve) - Kit (OGRE)](08_Kit_(Digital_Valve)-Kit_(OGRE).md) (100 pages)
- [Kit (OmniBridge) - Kit (Vending Machine)](09_Kit_(OmniBridge)-Kit_(Vending_Machine).md) (100 pages)
- [Kit (Very Important Button) - Letter E (Medium)](10_Kit_(Very_Important_Button)-Letter_E_(Medium).md) (100 pages)
- [Letter F (Large) - Liquid Volume Pump](11_Letter_F_(Large)-Liquid_Volume_Pump.md) (100 pages)
- [Liquid Volume Regulator - LogicType.CombustionOutput2](12_Liquid_Volume_Regulator-LogicType.CombustionOutput2.md) (100 pages)
- [LogicType.CompletionRatio - LogicType.RatioHeliumInput2](13_LogicType.CompletionRatio-LogicType.RatioHeliumInput2.md) (100 pages)
- [LogicType.RatioHeliumOutput - LogicType.RatioOxygenInput2](14_LogicType.RatioHeliumOutput-LogicType.RatioOxygenInput2.md) (100 pages)
- [LogicType.RatioOxygenOutput - LogicType.WattsReachingContact](15_LogicType.RatioOxygenOutput-LogicType.WattsReachingContact.md) (100 pages)
- [LogicType.Weight - Monorail Rail (18m)](16_LogicType.Weight-Monorail_Rail_(18m).md) (100 pages)
- [Monorail Rail (2m) - Organics](17_Monorail_Rail_(2m)-Organics.md) (100 pages)
- [Overalls (Australia) - Portable Liquid Tank](18_Overalls_(Australia)-Portable_Liquid_Tank.md) (100 pages)
- [Portable Liquid Tank Mk II - Rubbish](19_Portable_Liquid_Tank_Mk_II-Rubbish.md) (100 pages)
- [Safety Glasses - Spray Paint (Yellow)](20_Safety_Glasses-Spray_Paint_(Yellow).md) (100 pages)
- [Stacker - Super-Heavy Cable (Straight 10)](21_Stacker-Super-Heavy_Cable_(Straight_10).md) (100 pages)
- [Super-Heavy Cable (Straight 3) - Umbilical Socket Angle (Gas)](22_Super-Heavy_Cable_(Straight_3)-Umbilical_Socket_Angle_(Gas).md) (100 pages)
- [Umbilical Socket Angle (Liquid) - Wheat](23_Umbilical_Socket_Angle_(Liquid)-Wheat.md) (100 pages)
- [Wheat - Yellow Coloring](24_Wheat-Yellow_Coloring.md) (35 pages)

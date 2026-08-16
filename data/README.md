# Stationpedia Reference Library

Extracted directly from live game data via a BepInEx/Harmony plugin on a headless dedicated server.
1985 pages total, chunked alphabetically by title.

**Known gap:** per-device "Logic Types" (which LogicType values a specific structure reads/writes, e.g. what Volume Pump supports) are populated by the game per placed *instance*, not per page template - a fresh/empty world has nothing to source that from, so most device pages won't show a Logic Types section even though the field exists and is dumped when populated. It's not missing data on purpose; forcing full coverage would need spawning one of every constructible prefab into a world first. However, every individual `LogicType.*` enum value (On, Setting, PressureInternal, etc.) has its own dedicated glossary page with a clean description - search for `## LogicType.` across these files for that reference instead.

- [<N:EN:ItemWreckageSteelCornerSmall> - Burnt Cable (5-Way Junction)](00__N_EN_ItemWreckageSteelCornerSmall_-Burnt_Cable_(5-Way_Junction).md) (100 pages)
- [Burnt Cable (6-Way Junction) - Chair (Thick Single)](01_Burnt_Cable_(6-Way_Junction)-Chair_(Thick_Single).md) (100 pages)
- [Charcoal - Corn](02_Charcoal-Corn.md) (100 pages)
- [Corn - Fertilizer](03_Corn-Fertilizer.md) (100 pages)
- [Filter (Alcohol) - Headlamp](04_Filter_(Alcohol)-Headlamp.md) (100 pages)
- [Heavy Cable (3-Way Corner) - Insulated Liquid Pipe (Cross Junction)](05_Heavy_Cable_(3-Way_Corner)-Insulated_Liquid_Pipe_(Cross_Junction).md) (100 pages)
- [Insulated Liquid Pipe (Straight 10) - Kit (Fuselage Type C)](06_Insulated_Liquid_Pipe_(Straight_10)-Kit_(Fuselage_Type_C).md) (100 pages)
- [Kit (Fuselage Type D) - Kit (Power Connector)](07_Kit_(Fuselage_Type_D)-Kit_(Power_Connector).md) (100 pages)
- [Kit (Power Pylon) - Landingpad Gas Output](08_Kit_(Power_Pylon)-Landingpad_Gas_Output.md) (100 pages)
- [Landingpad Liquid Input - Logic Math](09_Landingpad_Liquid_Input-Logic_Math.md) (100 pages)
- [Logic Memory - LogicType.ElevatorLevel](10_Logic_Memory-LogicType.ElevatorLevel.md) (100 pages)
- [LogicType.ElevatorSpeed - LogicType.RatioLiquidAlcohol](11_LogicType.ElevatorSpeed-LogicType.RatioLiquidAlcohol.md) (100 pages)
- [LogicType.RatioLiquidAlcoholInput - LogicType.RatioSilanol](12_LogicType.RatioLiquidAlcoholInput-LogicType.RatioSilanol.md) (100 pages)
- [LogicType.RatioSilanolInput - Marine Uniform](13_LogicType.RatioSilanolInput-Marine_Uniform.md) (100 pages)
- [Math Unary - Overalls (Germany)](14_Math_Unary-Overalls_(Germany).md) (100 pages)
- [Overalls (Japan) - Powdered Eggs](15_Overalls_(Japan)-Powdered_Eggs.md) (100 pages)
- [Power Connector - Security Printer](16_Power_Connector-Security_Printer.md) (100 pages)
- [Sensor Lenses - Steam](17_Sensor_Lenses-Steam.md) (100 pages)
- [Steel - Valve (Gas)](18_Steel-Valve_(Gas).md) (100 pages)
- [Valve (Liquid) - Yellow Coloring](19_Valve_(Liquid)-Yellow_Coloring.md) (85 pages)

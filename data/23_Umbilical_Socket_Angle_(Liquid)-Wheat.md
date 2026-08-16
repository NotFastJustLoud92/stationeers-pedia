# Umbilical Socket Angle (Liquid) - Wheat

## Umbilical Socket Angle (Liquid)

- **Key:** ThingStructureLiquidUmbilicalFemaleSide
- **Prefab Name:** StructureLiquidUmbilicalFemaleSide
- **Prefab Hash:** 1220870319
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Liquid Umbilical)
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Liquid Umbilical), PrefabHash=1571996765, PageLink=ThingItemKitLiquidUmbilical

---

## Umbilical Socket Angle (Power)

- **Key:** ThingStructurePowerUmbilicalFemaleSide
- **Prefab Name:** StructurePowerUmbilicalFemaleSide
- **Prefab Hash:** 1922506192
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Power Umbilical)
**Connections:**
  - LogicName=Power Output, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Power Umbilical), PrefabHash=1603046970, PageLink=ThingItemKitElectricUmbilical

---

## Uniform Commander

- **Key:** ThingUniformCommander
- **Prefab Name:** UniformCommander
- **Prefab Hash:** -2083426457
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=3
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=4
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Unloader

The Xigo Re:Gurge is a handy unit for unloading any items inserted into it, and feeding them into a chute network. For instance, if you add a full Mining Belt, the Re:Gurge will empty a mining belt of its contents, insert them into the chute network, then insert the mining belt itself. A Sorter is recommended to reclaim the mining belt. Output = 0 exporting the main item Output = 1 exporting items inside and eventually the main item.

- **Key:** ThingStructureUnloader
- **Prefab Name:** StructureUnloader
- **Prefab Hash:** 750118160
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1
  - LogicName=OccupantHash, LogicAccessTypes=0, 1
  - LogicName=Quantity, LogicAccessTypes=0, 1
  - LogicName=Damage, LogicAccessTypes=0, 1
  - LogicName=Class, LogicAccessTypes=0, 1
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1
  - LogicName=PrefabHash, LogicAccessTypes=0, 1
  - LogicName=SortingClass, LogicAccessTypes=0, 1
  - LogicName=ReferenceId, LogicAccessTypes=0, 1
  - LogicName=FreeSlots, LogicAccessTypes=0, 1
  - LogicName=TotalSlots, LogicAccessTypes=0, 1
**Slots:**
  - SlotName=Import, SlotType=Import, SlotIndex=0
  - SlotName=Export, SlotType=Export, SlotIndex=1
**Build States:**
  - Description=1 x Kit (Stacker)
**Mode Options:**
  - LogicName=Automatic, LogicAccessTypes=0
  - LogicName=Logic, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Chute Output, LogicAccessTypes=1
  - LogicName=Chute Input, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Stacker), PrefabHash=1013244511, PageLink=ThingItemKitStacker

---

## Upright Wind Turbine

The wind turbine is optimized to produce power even on low atmosphere worlds (up to 200W), it performs best in denser environments. Output varies with wind speed, and during storms, may increase dramatically (up to 1,000W), so be careful to design your power networks with that in mind.

- **Key:** ThingStructureUprightWindTurbine
- **Prefab Name:** StructureUprightWindTurbine
- **Prefab Hash:** 1622183451
- **Power Generation:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Upright Wind Turbine)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Upright Wind Turbine), PrefabHash=-1798044015, PageLink=ThingItemKitUprightWindTurbine

---

## Uranium

- **Key:** ReagentUranium
- **Reagents Type:** Uranium
**Found In Ore:**
  - NameOfThing=Ore (Uranium), QuantityOfThing=1

---

## Utility Button

Big Button for important tasks. Can be labeled and painted, add a "*" at the end to hide the text.

- **Key:** ThingModularDeviceUtilityButton2x2
- **Prefab Name:** ModularDeviceUtilityButton2x2
- **Prefab Hash:** -1446063838
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Inputs)
**Constructed Things:**
  - NameOfThing=Kit (Modular Console Inputs), PrefabHash=1496399356, PageLink=ThingItemKitModularConsoleInputs

---

## Valve (Gas)

- **Key:** ThingStructureValve
- **Prefab Name:** StructureValve
- **Prefab Hash:** -692036078
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Pipe Valve)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Pipe Valve), PrefabHash=799323450, PageLink=ThingItemPipeValve

---

## Valve (Liquid)

- **Key:** ThingStructureLiquidValve
- **Prefab Name:** StructureLiquidValve
- **Prefab Hash:** 1849974453
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Liquid Pipe Valve)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Liquid Pipe Valve), PrefabHash=-2126113312, PageLink=ThingItemLiquidPipeValve

---

## Vending Machine

The Xigo-designed 'Slot Mate' vending machine allows storage of almost any item, while also operating as a distribution point for working with Traders. You cannot trade without a vending machine, or its more advanced equivalent, the Refrigerated Vending Machine. Each vending machine can hold up to 100 stacks.

- **Key:** ThingStructureVendingMachine
- **Prefab Name:** StructureVendingMachine
- **Prefab Hash:** -443130773
- **Base Power Draw:** 5 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
  - LogicName=Damage, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
  - LogicName=Class, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
  - LogicName=SortingClass, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
  - LogicName=FreeSlots, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
  - LogicName=TotalSlots, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101
**Slots:**
  - SlotName=Import, SlotType=Import, SlotIndex=0
  - SlotName=Export, SlotType=Export, SlotIndex=1
  - SlotName=Storage, SlotType=Storage, SlotIndex=2
  - SlotName=Storage, SlotType=Storage, SlotIndex=3
  - SlotName=Storage, SlotType=Storage, SlotIndex=4
  - SlotName=Storage, SlotType=Storage, SlotIndex=5
  - SlotName=Storage, SlotType=Storage, SlotIndex=6
  - SlotName=Storage, SlotType=Storage, SlotIndex=7
  - SlotName=Storage, SlotType=Storage, SlotIndex=8
  - SlotName=Storage, SlotType=Storage, SlotIndex=9
  - SlotName=Storage, SlotType=Storage, SlotIndex=10
  - SlotName=Storage, SlotType=Storage, SlotIndex=11
  - SlotName=Storage, SlotType=Storage, SlotIndex=12
  - SlotName=Storage, SlotType=Storage, SlotIndex=13
  - SlotName=Storage, SlotType=Storage, SlotIndex=14
  - SlotName=Storage, SlotType=Storage, SlotIndex=15
  - SlotName=Storage, SlotType=Storage, SlotIndex=16
  - SlotName=Storage, SlotType=Storage, SlotIndex=17
  - SlotName=Storage, SlotType=Storage, SlotIndex=18
  - SlotName=Storage, SlotType=Storage, SlotIndex=19
  - SlotName=Storage, SlotType=Storage, SlotIndex=20
  - SlotName=Storage, SlotType=Storage, SlotIndex=21
  - SlotName=Storage, SlotType=Storage, SlotIndex=22
  - SlotName=Storage, SlotType=Storage, SlotIndex=23
  - SlotName=Storage, SlotType=Storage, SlotIndex=24
  - SlotName=Storage, SlotType=Storage, SlotIndex=25
  - SlotName=Storage, SlotType=Storage, SlotIndex=26
  - SlotName=Storage, SlotType=Storage, SlotIndex=27
  - SlotName=Storage, SlotType=Storage, SlotIndex=28
  - SlotName=Storage, SlotType=Storage, SlotIndex=29
  - SlotName=Storage, SlotType=Storage, SlotIndex=30
  - SlotName=Storage, SlotType=Storage, SlotIndex=31
  - SlotName=Storage, SlotType=Storage, SlotIndex=32
  - SlotName=Storage, SlotType=Storage, SlotIndex=33
  - SlotName=Storage, SlotType=Storage, SlotIndex=34
  - SlotName=Storage, SlotType=Storage, SlotIndex=35
  - SlotName=Storage, SlotType=Storage, SlotIndex=36
  - SlotName=Storage, SlotType=Storage, SlotIndex=37
  - SlotName=Storage, SlotType=Storage, SlotIndex=38
  - SlotName=Storage, SlotType=Storage, SlotIndex=39
  - SlotName=Storage, SlotType=Storage, SlotIndex=40
  - SlotName=Storage, SlotType=Storage, SlotIndex=41
  - SlotName=Storage, SlotType=Storage, SlotIndex=42
  - SlotName=Storage, SlotType=Storage, SlotIndex=43
  - SlotName=Storage, SlotType=Storage, SlotIndex=44
  - SlotName=Storage, SlotType=Storage, SlotIndex=45
  - SlotName=Storage, SlotType=Storage, SlotIndex=46
  - SlotName=Storage, SlotType=Storage, SlotIndex=47
  - SlotName=Storage, SlotType=Storage, SlotIndex=48
  - SlotName=Storage, SlotType=Storage, SlotIndex=49
  - SlotName=Storage, SlotType=Storage, SlotIndex=50
  - SlotName=Storage, SlotType=Storage, SlotIndex=51
  - SlotName=Storage, SlotType=Storage, SlotIndex=52
  - SlotName=Storage, SlotType=Storage, SlotIndex=53
  - SlotName=Storage, SlotType=Storage, SlotIndex=54
  - SlotName=Storage, SlotType=Storage, SlotIndex=55
  - SlotName=Storage, SlotType=Storage, SlotIndex=56
  - SlotName=Storage, SlotType=Storage, SlotIndex=57
  - SlotName=Storage, SlotType=Storage, SlotIndex=58
  - SlotName=Storage, SlotType=Storage, SlotIndex=59
  - SlotName=Storage, SlotType=Storage, SlotIndex=60
  - SlotName=Storage, SlotType=Storage, SlotIndex=61
  - SlotName=Storage, SlotType=Storage, SlotIndex=62
  - SlotName=Storage, SlotType=Storage, SlotIndex=63
  - SlotName=Storage, SlotType=Storage, SlotIndex=64
  - SlotName=Storage, SlotType=Storage, SlotIndex=65
  - SlotName=Storage, SlotType=Storage, SlotIndex=66
  - SlotName=Storage, SlotType=Storage, SlotIndex=67
  - SlotName=Storage, SlotType=Storage, SlotIndex=68
  - SlotName=Storage, SlotType=Storage, SlotIndex=69
  - SlotName=Storage, SlotType=Storage, SlotIndex=70
  - SlotName=Storage, SlotType=Storage, SlotIndex=71
  - SlotName=Storage, SlotType=Storage, SlotIndex=72
  - SlotName=Storage, SlotType=Storage, SlotIndex=73
  - SlotName=Storage, SlotType=Storage, SlotIndex=74
  - SlotName=Storage, SlotType=Storage, SlotIndex=75
  - SlotName=Storage, SlotType=Storage, SlotIndex=76
  - SlotName=Storage, SlotType=Storage, SlotIndex=77
  - SlotName=Storage, SlotType=Storage, SlotIndex=78
  - SlotName=Storage, SlotType=Storage, SlotIndex=79
  - SlotName=Storage, SlotType=Storage, SlotIndex=80
  - SlotName=Storage, SlotType=Storage, SlotIndex=81
  - SlotName=Storage, SlotType=Storage, SlotIndex=82
  - SlotName=Storage, SlotType=Storage, SlotIndex=83
  - SlotName=Storage, SlotType=Storage, SlotIndex=84
  - SlotName=Storage, SlotType=Storage, SlotIndex=85
  - SlotName=Storage, SlotType=Storage, SlotIndex=86
  - SlotName=Storage, SlotType=Storage, SlotIndex=87
  - SlotName=Storage, SlotType=Storage, SlotIndex=88
  - SlotName=Storage, SlotType=Storage, SlotIndex=89
  - SlotName=Storage, SlotType=Storage, SlotIndex=90
  - SlotName=Storage, SlotType=Storage, SlotIndex=91
  - SlotName=Storage, SlotType=Storage, SlotIndex=92
  - SlotName=Storage, SlotType=Storage, SlotIndex=93
  - SlotName=Storage, SlotType=Storage, SlotIndex=94
  - SlotName=Storage, SlotType=Storage, SlotIndex=95
  - SlotName=Storage, SlotType=Storage, SlotIndex=96
  - SlotName=Storage, SlotType=Storage, SlotIndex=97
  - SlotName=Storage, SlotType=Storage, SlotIndex=98
  - SlotName=Storage, SlotType=Storage, SlotIndex=99
  - SlotName=Storage, SlotType=Storage, SlotIndex=100
  - SlotName=Storage, SlotType=Storage, SlotIndex=101
**Build States:**
  - Description=2 x Kit (Vending Machine)
  - Description=2 x Plastic Sheets
  - Description=Screwdriver
**Connections:**
  - LogicName=Chute Input, LogicAccessTypes=0
  - LogicName=Chute Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Vending Machine), PrefabHash=-2038384332, PageLink=ThingItemKitVendingMachine

---

## Vending Machine Small

- **Key:** ThingStructureVendingMachineSmall
- **Prefab Name:** StructureVendingMachineSmall
- **Prefab Hash:** 19591354
- **Base Power Draw:** 5 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
  - LogicName=Damage, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
  - LogicName=Class, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
  - LogicName=SortingClass, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
  - LogicName=FreeSlots, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
  - LogicName=TotalSlots, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
**Slots:**
  - SlotName=Import, SlotType=Import, SlotIndex=0
  - SlotName=Export, SlotType=Export, SlotIndex=1
  - SlotName=Storage, SlotType=Storage, SlotIndex=2
  - SlotName=Storage, SlotType=Storage, SlotIndex=3
  - SlotName=Storage, SlotType=Storage, SlotIndex=4
  - SlotName=Storage, SlotType=Storage, SlotIndex=5
  - SlotName=Storage, SlotType=Storage, SlotIndex=6
  - SlotName=Storage, SlotType=Storage, SlotIndex=7
  - SlotName=Storage, SlotType=Storage, SlotIndex=8
  - SlotName=Storage, SlotType=Storage, SlotIndex=9
  - SlotName=Storage, SlotType=Storage, SlotIndex=10
  - SlotName=Storage, SlotType=Storage, SlotIndex=11
**Build States:**
  - Description=1 x Kit (Vending Machine)
  - Description=2 x Plastic Sheets
**Connections:**
  - LogicName=Chute Input, LogicAccessTypes=0
  - LogicName=Chute Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Vending Machine), PrefabHash=-2038384332, PageLink=ThingItemKitVendingMachine

---

## Venjent Glasses

A pair of Venjent glasses.

- **Key:** ThingVenjentGlasses
- **Prefab Name:** VenjentGlasses
- **Prefab Hash:** 1102075735
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 10 x Iron (from Ingot (Iron)) + 5 x Silicon (from Ingot (Silicon))


---

## Very Important Button

- **Key:** ThingStructureVeryImportantButton
- **Prefab Name:** StructureVeryImportantButton
- **Prefab Hash:** -1802673373
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Very Important Button)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Very Important Button), PrefabHash=-1726714475, PageLink=ThingItemKitVeryImportantButton

---

## Visor

A Visor.

- **Key:** ThingVisor
- **Prefab Name:** Visor
- **Prefab Hash:** 1032242318
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 500 x Energy + 10 x Gold (from Ingot (Gold)) + 15 x Steel (from Ingot (Steel)) + 10 x Silicon (from Ingot (Silicon))


---

## Volume Pump

The volume pump pumps pumpable gases. It also separates out pipe networks into separate networks.

- **Key:** ThingStructureVolumePump
- **Prefab Name:** StructureVolumePump
- **Prefab Hash:** -321403609
- **Base Power Draw:** 200 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Volume Pump)
**Connections:**
  - LogicName=Pipe Output, LogicAccessTypes=0
  - LogicName=Pipe Input, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Volume Pump), PrefabHash=-1766301997, PageLink=ThingItemPipeVolumePump

---

## Wall (Arch Arrow)

- **Key:** ThingStructureWallArchArrow
- **Prefab Name:** StructureWallArchArrow
- **Prefab Hash:** 1649708822
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Arched Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Arched Wall), PrefabHash=1625214531, PageLink=ThingItemKitWallArch

---

## Wall (Arch Corner Round)

- **Key:** ThingStructureWallArchCornerRound
- **Prefab Name:** StructureWallArchCornerRound
- **Prefab Hash:** 1794588890
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Arched Wall)
**Constructed Things:**
  - NameOfThing=Kit (Arched Wall), PrefabHash=1625214531, PageLink=ThingItemKitWallArch

---

## Wall (Arch Corner Square)

- **Key:** ThingStructureWallArchCornerSquare
- **Prefab Name:** StructureWallArchCornerSquare
- **Prefab Hash:** -1963016580
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Arched Wall)
**Constructed Things:**
  - NameOfThing=Kit (Arched Wall), PrefabHash=1625214531, PageLink=ThingItemKitWallArch

---

## Wall (Arch Corner Triangle)

- **Key:** ThingStructureWallArchCornerTriangle
- **Prefab Name:** StructureWallArchCornerTriangle
- **Prefab Hash:** 1281911841
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Arched Wall)
**Constructed Things:**
  - NameOfThing=Kit (Arched Wall), PrefabHash=1625214531, PageLink=ThingItemKitWallArch

---

## Wall (Arch Plating)

- **Key:** ThingStructureWallArchPlating
- **Prefab Name:** StructureWallArchPlating
- **Prefab Hash:** 1182510648
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Arched Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Arched Wall), PrefabHash=1625214531, PageLink=ThingItemKitWallArch

---

## Wall (Arch Two Tone)

- **Key:** ThingStructureWallArchTwoTone
- **Prefab Name:** StructureWallArchTwoTone
- **Prefab Hash:** 782529714
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Arched Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Arched Wall), PrefabHash=1625214531, PageLink=ThingItemKitWallArch

---

## Wall (Arch)

- **Key:** ThingStructureWallArch
- **Prefab Name:** StructureWallArch
- **Prefab Hash:** -858143148
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Arched Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Arched Wall), PrefabHash=1625214531, PageLink=ThingItemKitWallArch

---

## Wall (Base Cap 1)

- **Key:** ThingCompositeWallRoundedBaseCap1
- **Prefab Name:** CompositeWallRoundedBaseCap1
- **Prefab Hash:** -196483074
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Base Cap 2)

- **Key:** ThingCompositeWallRoundedBaseCap2
- **Prefab Name:** CompositeWallRoundedBaseCap2
- **Prefab Hash:** 1832957508
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Base)

- **Key:** ThingCompositeWallRoundedBase
- **Prefab Name:** CompositeWallRoundedBase
- **Prefab Hash:** 1058398766
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Cap 1)

- **Key:** ThingCompositeWallTubeCap1
- **Prefab Name:** CompositeWallTubeCap1
- **Prefab Hash:** -226007136
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Cap 2)

- **Key:** ThingCompositeWallTubeCap2
- **Prefab Name:** CompositeWallTubeCap2
- **Prefab Hash:** 1804482074
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Corner 1)

- **Key:** ThingCompositeWallRoundedCorner1
- **Prefab Name:** CompositeWallRoundedCorner1
- **Prefab Hash:** -1194323534
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Corner 2)

- **Key:** ThingCompositeWallRoundedCorner2
- **Prefab Name:** CompositeWallRoundedCorner2
- **Prefab Hash:** 567885832
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Corner Padded 2)

- **Key:** ThingStructureCompositeWallRoundedCorner2
- **Prefab Name:** StructureCompositeWallRoundedCorner2
- **Prefab Hash:** -1004748598
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Corner Padded)

- **Key:** ThingStructureCompositeWallRoundedCorner
- **Prefab Name:** StructureCompositeWallRoundedCorner
- **Prefab Hash:** 1927283437
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Cuplola Padded)

- **Key:** ThingStructureCompositeWallRoundedCupola2
- **Prefab Name:** StructureCompositeWallRoundedCupola2
- **Prefab Hash:** -904679633
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Cuplola)

- **Key:** ThingCompositeWallRoundedCupola
- **Prefab Name:** CompositeWallRoundedCupola
- **Prefab Hash:** -1237771736
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Flat Corner Round)

- **Key:** ThingStructureWallFlatCornerRound
- **Prefab Name:** StructureWallFlatCornerRound
- **Prefab Hash:** 898708250
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Flat Corner Square)

- **Key:** ThingStructureWallFlatCornerSquare
- **Prefab Name:** StructureWallFlatCornerSquare
- **Prefab Hash:** 298130111
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Flat Corner Triangle Flat)

- **Key:** ThingStructureWallFlatCornerTriangleFlat
- **Prefab Name:** StructureWallFlatCornerTriangleFlat
- **Prefab Hash:** -1161662836
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Flat Corner Triangle)

- **Key:** ThingStructureWallFlatCornerTriangle
- **Prefab Name:** StructureWallFlatCornerTriangle
- **Prefab Hash:** 2097419366
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Flat)

- **Key:** ThingStructureWallFlat
- **Prefab Name:** StructureWallFlat
- **Prefab Hash:** 1635864154
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Geometry Corner)

- **Key:** ThingStructureWallGeometryCorner
- **Prefab Name:** StructureWallGeometryCorner
- **Prefab Hash:** 1979212240
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Geometric Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Geometric Wall), PrefabHash=-784733231, PageLink=ThingItemKitWallGeometry

---

## Wall (Geometry Straight)

- **Key:** ThingStructureWallGeometryStreight
- **Prefab Name:** StructureWallGeometryStreight
- **Prefab Hash:** 1049735537
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Geometric Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Geometric Wall), PrefabHash=-784733231, PageLink=ThingItemKitWallGeometry

---

## Wall (Geometry T Mirrored)

- **Key:** ThingStructureWallGeometryTMirrored
- **Prefab Name:** StructureWallGeometryTMirrored
- **Prefab Hash:** -1427845483
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Geometric Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Geometric Wall), PrefabHash=-784733231, PageLink=ThingItemKitWallGeometry

---

## Wall (Geometry T)

- **Key:** ThingStructureWallGeometryT
- **Prefab Name:** StructureWallGeometryT
- **Prefab Hash:** 1602758612
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Geometric Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Geometric Wall), PrefabHash=-784733231, PageLink=ThingItemKitWallGeometry

---

## Wall (Large Panel Arrow)

- **Key:** ThingStructureWallLargePanelArrow
- **Prefab Name:** StructureWallLargePanelArrow
- **Prefab Hash:** -776581573
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Large Panel)

- **Key:** ThingStructureWallLargePanel
- **Prefab Name:** StructureWallLargePanel
- **Prefab Hash:** 1492930217
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Padded Arch Corner)

- **Key:** ThingStructureWallPaddedArchCorner
- **Prefab Name:** StructureWallPaddedArchCorner
- **Prefab Hash:** -1126688298
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded Arch Light Fitting Top)

- **Key:** ThingStructureWallPaddedArchLightFittingTop
- **Prefab Name:** StructureWallPaddedArchLightFittingTop
- **Prefab Hash:** 1171987947
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=2 x Plastic Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded Arch Lights Fittings)

- **Key:** ThingStructureWallPaddedArchLightsFittings
- **Prefab Name:** StructureWallPaddedArchLightsFittings
- **Prefab Hash:** -1546743960
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=2 x Plastic Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded Arch)

- **Key:** ThingStructureWallPaddedArch
- **Prefab Name:** StructureWallPaddedArch
- **Prefab Hash:** 1590330637
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=2 x Plastic Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded Corner Thin)

- **Key:** ThingStructureWallPaddedCornerThin
- **Prefab Name:** StructureWallPaddedCornerThin
- **Prefab Hash:** 1183203913
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded Corner)

- **Key:** ThingStructureWallPaddedCorner
- **Prefab Name:** StructureWallPaddedCorner
- **Prefab Hash:** -155945899
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded No Border Corner)

- **Key:** ThingStructureWallPaddedNoBorderCorner
- **Prefab Name:** StructureWallPaddedNoBorderCorner
- **Prefab Hash:** 179694804
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded No Border)

- **Key:** ThingStructureWallPaddedNoBorder
- **Prefab Name:** StructureWallPaddedNoBorder
- **Prefab Hash:** 8846501
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=1 x Plastic Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded Thin No Border Corner)

- **Key:** ThingStructureWallPaddedThinNoBorderCorner
- **Prefab Name:** StructureWallPaddedThinNoBorderCorner
- **Prefab Hash:** 1769527556
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded Thin No Border)

- **Key:** ThingStructureWallPaddedThinNoBorder
- **Prefab Name:** StructureWallPaddedThinNoBorder
- **Prefab Hash:** -1611559100
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=2 x Plastic Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded Window Thin)

- **Key:** ThingStructureWallPaddedWindowThin
- **Prefab Name:** StructureWallPaddedWindowThin
- **Prefab Hash:** -37302931
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=1 x Plastic Sheets
  - Description=1 x Glass Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padded Window)

- **Key:** ThingStructureWallPaddedWindow
- **Prefab Name:** StructureWallPaddedWindow
- **Prefab Hash:** 2087628940
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=1 x Plastic Sheets
  - Description=1 x Glass Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padding Arch Vent)

- **Key:** ThingStructureWallPaddingArchVent
- **Prefab Name:** StructureWallPaddingArchVent
- **Prefab Hash:** -1243329828
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=2 x Plastic Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padding Light Fitting)

- **Key:** ThingStructureWallPaddingLightFitting
- **Prefab Name:** StructureWallPaddingLightFitting
- **Prefab Hash:** 2024882687
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=2 x Plastic Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padding Thin)

- **Key:** ThingStructureWallPaddingThin
- **Prefab Name:** StructureWallPaddingThin
- **Prefab Hash:** -1102403554
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=2 x Plastic Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Padding)

- **Key:** ThingStructureWallPadding
- **Prefab Name:** StructureWallPadding
- **Prefab Hash:** 635995024
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Padded Wall)
  - Description=2 x Plastic Sheets
**Constructed Things:**
  - NameOfThing=Kit (Padded Wall), PrefabHash=-821868990, PageLink=ThingItemKitWallPadded

---

## Wall (Panel 1)

- **Key:** ThingCompositeWallRoundedPanel
- **Prefab Name:** CompositeWallRoundedPanel
- **Prefab Hash:** 1144073746
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Panel 2)

- **Key:** ThingCompositeWallRoundedPanel2
- **Prefab Name:** CompositeWallRoundedPanel2
- **Prefab Hash:** -383189397
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Plate)

- **Key:** ThingCompositeWallRoundedPlate
- **Prefab Name:** CompositeWallRoundedPlate
- **Prefab Hash:** -1761465786
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Plating)

- **Key:** ThingStructureWallPlating
- **Prefab Name:** StructureWallPlating
- **Prefab Hash:** 26167457
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Ring Flat)

- **Key:** ThingCompositeWallRoundedRingWall
- **Prefab Name:** CompositeWallRoundedRingWall
- **Prefab Hash:** 1380149835
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Ring)

- **Key:** ThingCompositeWallRoundedRing
- **Prefab Name:** CompositeWallRoundedRing
- **Prefab Hash:** 1887299897
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Round Padded)

- **Key:** ThingStructureCompositeWallRounded
- **Prefab Name:** StructureCompositeWallRounded
- **Prefab Hash:** -1926750425
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Round)

- **Key:** ThingCompositeWallRounded
- **Prefab Name:** CompositeWallRounded
- **Prefab Hash:** 1843726092
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (T.U.B.E.)
**Constructed Things:**
  - NameOfThing=Kit (T.U.B.E.), PrefabHash=-344057907, PageLink=ThingItemKitTUBE

---

## Wall (Small Panels And Hatch)

- **Key:** ThingStructureWallSmallPanelsAndHatch
- **Prefab Name:** StructureWallSmallPanelsAndHatch
- **Prefab Hash:** 619828719
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Small Panels Arrow)

- **Key:** ThingStructureWallSmallPanelsArrow
- **Prefab Name:** StructureWallSmallPanelsArrow
- **Prefab Hash:** -639306697
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Small Panels Mono Chrome)

- **Key:** ThingStructureWallSmallPanelsMonoChrome
- **Prefab Name:** StructureWallSmallPanelsMonoChrome
- **Prefab Hash:** 386820253
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Small Panels Open)

- **Key:** ThingStructureWallSmallPanelsOpen
- **Prefab Name:** StructureWallSmallPanelsOpen
- **Prefab Hash:** -1407480603
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall (Small Panels Two Tone)

- **Key:** ThingStructureWallSmallPanelsTwoTone
- **Prefab Name:** StructureWallSmallPanelsTwoTone
- **Prefab Hash:** 1709994581
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Flat Wall)
  - Description=1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Flat Wall), PrefabHash=-846838195, PageLink=ThingItemKitWallFlat

---

## Wall Cooler

The Xigo Freezy Boi wall cooler complements the wall heater, which can only raise the temperature. The wall cooler functions by drawing heat from the surrounding atmosphere and adding that heat into its pipe network. In order to run the wall cooler properly, you will need to connect pipes to the wall cooler and fill the connected pipe network with any type of gas. The gas's heat capacity and volume will determine how fast it reacts to temperature changes. EFFICIENCY The higher the difference in temperature between the gas stored in the pipes and the room, the less efficient the wall cooler will be. So to keep the wall cooler running at an acceptable efficiency you will need to get rid of the heat that accumulates in the pipes connected to it. A common practice would be to run the pipes to the outside and use radiators on the outside section of the pipes to get rid of the heat. The less efficient the wall cooler, the less power it consumes. It will consume 1010W at max efficiency. The wall cooler can be controlled by logic chips to run when the temperature hits a certain degree. ERRORS If the wall cooler is flashing an error then it is missing one of the following: - Pipe connection to the wall cooler. - Gas in the connected pipes, or pressure is too low. - Atmosphere in the surrounding environment or pressure is too low. For more information about how to control temperatures, consult the temperature control Guides page.

- **Key:** ThingStructureWallCooler
- **Prefab Name:** StructureWallCooler
- **Prefab Hash:** -739292323
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0
  - LogicName=OccupantHash, LogicAccessTypes=0
  - LogicName=Quantity, LogicAccessTypes=0
  - LogicName=Damage, LogicAccessTypes=0
  - LogicName=Class, LogicAccessTypes=0
  - LogicName=MaxQuantity, LogicAccessTypes=0
  - LogicName=PrefabHash, LogicAccessTypes=0
  - LogicName=SortingClass, LogicAccessTypes=0
  - LogicName=ReferenceId, LogicAccessTypes=0
  - LogicName=FreeSlots, LogicAccessTypes=0
  - LogicName=TotalSlots, LogicAccessTypes=0
**Slots:**
  - SlotName=Data Disk, SlotType=Data Disk, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Wall Cooler)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Wall Cooler), PrefabHash=-1567752627, PageLink=ThingItemWallCooler

---

## Wall Heater

The wall heater is a simple device that can be installed on a wall or frame and connected to power. When switched on, it will start heating the surrounding environment. Adds 1000 joules of heat per tick to the contents of your pipe network. It will only operate when the pressure is above the armstrong limit (6.3kPa) and the temperature is below 2500 Kelvin.

- **Key:** ThingStructureWallHeater
- **Prefab Name:** StructureWallHeater
- **Prefab Hash:** 24258244
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0
  - LogicName=OccupantHash, LogicAccessTypes=0
  - LogicName=Quantity, LogicAccessTypes=0
  - LogicName=Damage, LogicAccessTypes=0
  - LogicName=Class, LogicAccessTypes=0
  - LogicName=MaxQuantity, LogicAccessTypes=0
  - LogicName=PrefabHash, LogicAccessTypes=0
  - LogicName=SortingClass, LogicAccessTypes=0
  - LogicName=ReferenceId, LogicAccessTypes=0
  - LogicName=FreeSlots, LogicAccessTypes=0
  - LogicName=TotalSlots, LogicAccessTypes=0
**Slots:**
  - SlotName=Data Disk, SlotType=Data Disk, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Wall Heater)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Wall Heater), PrefabHash=1880134612, PageLink=ThingItemWallHeater

---

## Wall Light

- **Key:** ThingStructureWallLight
- **Prefab Name:** StructureWallLight
- **Prefab Hash:** -1860064656
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Lights)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Lights), PrefabHash=1108423476, PageLink=ThingItemWallLight

---

## Wall Light (Battery)

- **Key:** ThingStructureWallLightBattery
- **Prefab Name:** StructureWallLightBattery
- **Prefab Hash:** -1306415132
- **Base Power Draw:** 25 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0
  - LogicName=OccupantHash, LogicAccessTypes=0
  - LogicName=Quantity, LogicAccessTypes=0
  - LogicName=Damage, LogicAccessTypes=0
  - LogicName=Charge, LogicAccessTypes=0
  - LogicName=ChargeRatio, LogicAccessTypes=0
  - LogicName=Class, LogicAccessTypes=0
  - LogicName=MaxQuantity, LogicAccessTypes=0
  - LogicName=PrefabHash, LogicAccessTypes=0
  - LogicName=SortingClass, LogicAccessTypes=0
  - LogicName=ReferenceId, LogicAccessTypes=0
  - LogicName=FreeSlots, LogicAccessTypes=0
  - LogicName=TotalSlots, LogicAccessTypes=0
**Slots:**
  - SlotName=Battery, SlotType=Battery, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Lights)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Lights), PrefabHash=1108423476, PageLink=ThingItemWallLight

---

## Wall Light (Long Angled)

- **Key:** ThingStructureLightLongAngled
- **Prefab Name:** StructureLightLongAngled
- **Prefab Hash:** 1847265835
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Lights)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Lights), PrefabHash=1108423476, PageLink=ThingItemWallLight

---

## Wall Light (Long Wide)

- **Key:** ThingStructureLightLongWide
- **Prefab Name:** StructureLightLongWide
- **Prefab Hash:** 555215790
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Lights)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Lights), PrefabHash=1108423476, PageLink=ThingItemWallLight

---

## Wall Light (Long)

- **Key:** ThingStructureLightLong
- **Prefab Name:** StructureLightLong
- **Prefab Hash:** 797794350
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Lights)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Lights), PrefabHash=1108423476, PageLink=ThingItemWallLight

---

## Waspaloy

- **Key:** ReagentWaspaloy
- **Reagents Type:** Waspaloy
**Found In Ore:**
  - NameOfThing=Ingot (Waspaloy), QuantityOfThing=1

---

## Waste Bag

A disposable bag that can be used to clear sanitation needs. Cannot be used when wearing the Suit.

- **Key:** ThingItemWasteBagEmpty
- **Prefab Name:** ItemWasteBagEmpty
- **Prefab Hash:** -1042122917
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 10
- **Paintable:** No
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 2 x Silicon (from Ingot (Silicon))


---

## Waste Bag (Filled)

A partially or completely used disposable bag that can be used to clear sanitation needs, so long as is there is room remaining. Cannot be used when wearing the Suit.

- **Key:** ThingItemWasteBagFilled
- **Prefab Name:** ItemWasteBagFilled
- **Prefab Hash:** -113462501
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No

---

## Water

You can obtain water by smelting or crushing Ice (Water) using a Furnace or an Ice Crusher. Water is critical for plants to stay alive, and grow food. It is also an exceptional coolant with a very high specific heat capacity. Water will evaporate into Steam if it's temperature is raised above its boiling point.

- **Key:** GasWater
- **Specific Heat:** 72 J/K
- **Freeze Temperature:** 273K (0C)
- **Boiling Temperature:** 384K (111C) at 100kPa
**Found In Ore:**
  - NameOfThing=Ice (Water), QuantityOfThing=20 mol

---

## Water Bottle

Delicious and pure H20, refined from local sources as varied as Venusian ice and trans-Solar comets. Empty bottles can be refilled using the Water Bottle Filler.

- **Key:** ThingItemWaterBottle
- **Prefab Name:** ItemWaterBottle
- **Prefab Hash:** 107741229
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1.5
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 120 x Energy + 2 x Iron (from Ingot (Iron)) + 4 x Silicon (from Ingot (Silicon))


---

## Water Bottle Bag

- **Key:** ThingItemWaterBottleBag
- **Prefab Name:** ItemWaterBottleBag
- **Prefab Hash:** 1476318823
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=None, SlotType=None, SlotIndex=2
  - SlotName=None, SlotType=None, SlotIndex=3
  - SlotName=None, SlotType=None, SlotIndex=4
  - SlotName=None, SlotType=None, SlotIndex=5

---

## Water Bottle Package

- **Key:** ThingItemWaterBottlePackage
- **Prefab Name:** ItemWaterBottlePackage
- **Prefab Hash:** -971586619
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=None, SlotType=None, SlotIndex=2
  - SlotName=None, SlotType=None, SlotIndex=3
  - SlotName=None, SlotType=None, SlotIndex=4
  - SlotName=None, SlotType=None, SlotIndex=5

---

## Water Packet

- **Key:** ThingItemWaterPacket
- **Prefab Name:** ItemWaterPacket
- **Prefab Hash:** -1769730804
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1.5
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)

---

## Water Purifier

Cleans Polluted Water and outputs Water. The purification process requires Charcoal which can be added to the machine via the import bin. The procesing throughput can be improved by increasing the gas pressure of the input pipe relative to the gas pressure of the output pipe.

- **Key:** ThingStructureWaterPurifier
- **Prefab Name:** StructureWaterPurifier
- **Prefab Hash:** 887383294
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0
  - LogicName=OccupantHash, LogicAccessTypes=0
  - LogicName=Quantity, LogicAccessTypes=0
  - LogicName=Damage, LogicAccessTypes=0
  - LogicName=Class, LogicAccessTypes=0
  - LogicName=MaxQuantity, LogicAccessTypes=0
  - LogicName=PrefabHash, LogicAccessTypes=0
  - LogicName=SortingClass, LogicAccessTypes=0
  - LogicName=ReferenceId, LogicAccessTypes=0
  - LogicName=FreeSlots, LogicAccessTypes=0
  - LogicName=TotalSlots, LogicAccessTypes=0
**Slots:**
  - SlotName=Import, SlotType=Import, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Water Purifier)
  - Description=2 x Kit (Liquid Pipe)
  - Description=Screwdriver 2 x Cable Coil
**Resources Used:**
  - NameOfThing=Charcoal, PrefabHash=252561409, PageLink=ThingItemCharcoal
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Pipe Liquid Input, LogicAccessTypes=1
  - LogicName=Pipe Liquid Output, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
  - LogicName=Chute Input, LogicAccessTypes=4
**Constructed Things:**
  - NameOfThing=Kit (Water Purifier), PrefabHash=611181283, PageLink=ThingItemKitWaterPurifier

---

## Water usage

The amount of water this plant consumes.

- **Key:** GeneWaterUsage

---

## Waterbottle Filler

- **Key:** ThingStructureWaterBottleFillerPowered
- **Prefab Name:** StructureWaterBottleFillerPowered
- **Prefab Hash:** -756587791
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1
  - LogicName=OccupantHash, LogicAccessTypes=0, 1
  - LogicName=Quantity, LogicAccessTypes=0, 1
  - LogicName=Damage, LogicAccessTypes=0, 1
  - LogicName=Pressure, LogicAccessTypes=0, 1
  - LogicName=Temperature, LogicAccessTypes=0, 1
  - LogicName=Class, LogicAccessTypes=0, 1
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1
  - LogicName=PrefabHash, LogicAccessTypes=0, 1
  - LogicName=Volume, LogicAccessTypes=0, 1
  - LogicName=Open, LogicAccessTypes=0, 1
  - LogicName=SortingClass, LogicAccessTypes=0, 1
  - LogicName=ReferenceId, LogicAccessTypes=0, 1
  - LogicName=FreeSlots, LogicAccessTypes=0, 1
  - LogicName=TotalSlots, LogicAccessTypes=0, 1
**Slots:**
  - SlotName=Bottle Slot, SlotType=Bottle Slot, SlotIndex=0
  - SlotName=Bottle Slot, SlotType=Bottle Slot, SlotIndex=1
**Build States:**
  - Description=1 x Kit (Water Bottle Filler)
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Water Bottle Filler), PrefabHash=159886536, PageLink=ThingItemKitWaterBottleFiller

---

## Waterbottle Filler

- **Key:** ThingStructureWaterBottleFillerPoweredBottom
- **Prefab Name:** StructureWaterBottleFillerPoweredBottom
- **Prefab Hash:** 1986658780
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1
  - LogicName=OccupantHash, LogicAccessTypes=0, 1
  - LogicName=Quantity, LogicAccessTypes=0, 1
  - LogicName=Damage, LogicAccessTypes=0, 1
  - LogicName=Pressure, LogicAccessTypes=0, 1
  - LogicName=Temperature, LogicAccessTypes=0, 1
  - LogicName=Class, LogicAccessTypes=0, 1
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1
  - LogicName=PrefabHash, LogicAccessTypes=0, 1
  - LogicName=Volume, LogicAccessTypes=0, 1
  - LogicName=Open, LogicAccessTypes=0, 1
  - LogicName=SortingClass, LogicAccessTypes=0, 1
  - LogicName=ReferenceId, LogicAccessTypes=0, 1
  - LogicName=FreeSlots, LogicAccessTypes=0, 1
  - LogicName=TotalSlots, LogicAccessTypes=0, 1
**Slots:**
  - SlotName=Bottle Slot, SlotType=Bottle Slot, SlotIndex=0
  - SlotName=Bottle Slot, SlotType=Bottle Slot, SlotIndex=1
**Build States:**
  - Description=1 x Kit (Water Bottle Filler)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Water Bottle Filler), PrefabHash=159886536, PageLink=ThingItemKitWaterBottleFiller

---

## Watermelon

- **Key:** ThingItemWatermelon
- **Prefab Name:** ItemWatermelon
- **Prefab Hash:** -1392622903
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 5
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Growth Time:** 4h 20min 1s
- **Stack Size:** 10
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Constructed From Kits:**
  - NameOfThing=Watermelon Seeds, PrefabHash=315264172, PageLink=ThingSeedBag_Watermelon
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=40 mol
  - NameOfThing=Polluted Water, QuantityOfThing=2 mol
**Used In:**
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Watermelon Seeds

- **Key:** ThingSeedBag_Watermelon
- **Prefab Name:** SeedBag_Watermelon
- **Prefab Hash:** 315264172
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 0
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Stack Size:** 10
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=6 mol
  - NameOfThing=Polluted Water, QuantityOfThing=0.3 mol
**Used In:**
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Weather

The Solar System's planets are not as calm as they may seem. After seven days on any world with an atmosphere, the inscrutable forces of nature swing into action – hitting unwary Stationeers with blizzards, dust storms and volcanic events. As such, the ODA recommends that freshly deployed Stationeers create an airtight base within 7 days of landing. Any dynamic objects left outside in a storm – on Mars, Loulan, Vulcan or Europa – risks being blown far, far away, including your lander. Likewise, be aware that solar panels are fragile and may have their glass shattered, or occasionally even be destroyed by a sufficiently ferocious storm. During storms, their output is also drastically reduced.

- **Key:** WeatherPage

---

## Weather Station

- **Key:** ThingStructureWeatherStation
- **Prefab Name:** StructureWeatherStation
- **Prefab Hash:** 1997212478
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Weather Station)
  - Description=Welding Torch 3 x Plastic Sheets
**Mode Options:**
  - LogicName=NoStorm, LogicAccessTypes=0
  - LogicName=StormIncoming, LogicAccessTypes=1
  - LogicName=InStorm, LogicAccessTypes=2
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Weather Station), PrefabHash=337505889, PageLink=ThingItemKitWeatherStation

---

## Welding Goggles

Welding Goggles.

- **Key:** ThingWeldingGoggles
- **Prefab Name:** WeldingGoggles
- **Prefab Hash:** 1261401717
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 15 x Steel (from Ingot (Steel)) + 10 x Silicon (from Ingot (Silicon))


---

## Welding Helmet

A Welding Helmet.

- **Key:** ThingWeldingHelmet
- **Prefab Name:** WeldingHelmet
- **Prefab Hash:** -20287128
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 500 x Energy + 10 x Gold (from Ingot (Gold)) + 5 x Steel (from Ingot (Steel)) + 10 x Silicon (from Ingot (Silicon))


---

## Welding Torch

Stored in the standard issue Stationeers Tool Belt, the Arlite welding torch is used to construct a range of essential structures. An upgraded version of the classic 'Zairo' model first manufactured by ExMin for modular space habitat assembly, the Arlite is powered by a single Canister (Fuel) and designed to function equally well in deep space and deep gravity wells.

- **Key:** ThingItemWeldingTorch
- **Prefab Name:** ItemWeldingTorch
- **Prefab Hash:** -2066892079
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=Gas Canister, SlotType=Gas Canister, SlotIndex=0
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 3 x Iron (from Ingot (Iron)) + 1 x Copper (from Ingot (Copper))


---

## Wheat

- **Key:** ReagentWheat
- **Reagents Type:** Wheat
**Found In Ore:**
  - NameOfThing=Wheat, QuantityOfThing=1

---


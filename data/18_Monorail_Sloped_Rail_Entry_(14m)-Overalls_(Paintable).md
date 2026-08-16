# Monorail Sloped Rail Entry (14m) - Overalls (Paintable)

## Monorail Sloped Rail Entry (14m)

A sloped monorail track segment for elevation changes. Use this rail to transition trains between different height levels. Connects end-to-end with straight rails, curves, and stations. Place slopes where your track needs to climb or descend. See also: Monorail A - Start Here

- **Key:** ThingStructureRailSlopeEntry14
- **Prefab Name:** StructureRailSlopeEntry14
- **Prefab Hash:** 541195008
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=2 x Monorail Rails Kit
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Monorail Rails Kit, PrefabHash=-1514871690, PageLink=ThingItemMonorailsKit

---

## Monorail Sloped Rail Exit (14m)

A sloped monorail track segment for elevation changes. Use this rail to transition trains between different height levels. Connects end-to-end with straight rails, curves, and stations. Place slopes where your track needs to climb or descend. See also: Monorail A - Start Here

- **Key:** ThingStructureRailSlopeExit14
- **Prefab Name:** StructureRailSlopeExit14
- **Prefab Hash:** 545284919
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=2 x Monorail Rails Kit
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Monorail Rails Kit, PrefabHash=-1514871690, PageLink=ThingItemMonorailsKit

---

## Monorail Stations Kit

A construction kit for building monorail stations. Stations are named destinations where trains can stop to transfer cargo, gas, or passengers. See also: Monorail B - Stations and Transfer

- **Key:** ThingItemMonorailStationKit
- **Prefab Name:** ItemMonorailStationKit
- **Prefab Hash:** -511293804
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 10
- **Paintable:** No
**Build Recipe:**
  - Printer: Autolathe (Tier Two)
    - 10000 x Energy + 3 x Gold (from Ingot (Gold)) + 3 x Copper (from Ingot (Copper)) + 10 x Steel (from Ingot (Steel)) + 2 x Solder (from Ingot (Solder))

**Constructed From Kits:**
  - NameOfThing=Monorail Unified Station, PrefabHash=1598629069, PageLink=ThingStructureRailUnifiedStation
  - NameOfThing=Monorail Passenger Station, PrefabHash=-1558303138, PageLink=ThingStructureRailPassengerStation

---

## Monorail Step Rail

A monorail track segment for stepping 2 meters up or down in elevation. Connects end-to-end with straight rails, curves, and stations. Place slopes where your track needs to climb or descend. See also: Monorail A - Start Here

- **Key:** ThingStructureRailStep
- **Prefab Name:** StructureRailStep
- **Prefab Hash:** 1868531189
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Monorail Rails Kit
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Monorail Rails Kit, PrefabHash=-1514871690, PageLink=ThingItemMonorailsKit

---

## Monorail Switches Kit

A construction kit for building the left- and right-branching three-ended monorail switches available in normal play. This kit can build: Monorail Left Rail Switch - left branch Monorail Right Rail Switch - right branch Each switch has one common stem A and two branches B and C. Toggle its physical interactable or write Setting through IC10: 0 connects A-B (straight) and 1 connects A-C (branch). A switch remains conductive for data and power through all three ends regardless of the switch blade position. Routing and automation: Monorail C - Switches and Routing

- **Key:** ThingItemMonorailSwitchesKit
- **Prefab Name:** ItemMonorailSwitchesKit
- **Prefab Hash:** 496624275
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 10
- **Paintable:** No
**Build Recipe:**
  - Printer: Autolathe (Tier Two)
    - 3500 x Energy + 2 x Copper (from Ingot (Copper)) + 5 x Steel (from Ingot (Steel)) + 1 x Solder (from Ingot (Solder)) + 2 x Silicon (from Ingot (Silicon))

**Constructed From Kits:**
  - NameOfThing=Monorail Left Rail Switch, PrefabHash=455106217, PageLink=ThingStructureRailSwitchLeft
  - NameOfThing=Monorail Right Rail Switch, PrefabHash=1489551499, PageLink=ThingStructureRailSwitchRight

---

## Monorail Unified Station

A combined cargo, gas, and liquid station that can operate in both input and output setups. Transfer starts about two seconds after a compatible train docks with Open=1. The station ports already contain a Turbo Volume Pump. Do NOT add an external pump in front of them. The Maximum IC10 value sets the integrated pump speed from 0-200 L/tick; the default is 40. Placing an external pump before the station can lead to unexpected results or very high pressures. The station already contains its own integrated pump with the typical safety constraints. Use Mode for direction (0 imports into the train, 1 exports from the train) and Setting for material (0 gas/liquid, 1 cargo). Activate reads 1 while a train is connected. See also: Monorail B - Stations and Transfer Connects to Logic Transmitter

- **Key:** ThingStructureRailUnifiedStation
- **Prefab Name:** StructureRailUnifiedStation
- **Prefab Hash:** 1598629069
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
  - SlotName=, SlotType=, SlotIndex=0
**Build States:**
  - Description=1 x Monorail Stations Kit
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
  - LogicName=Chute Input, LogicAccessTypes=2
  - LogicName=Pipe Input, LogicAccessTypes=3
  - LogicName=Pipe Liquid Input, LogicAccessTypes=4
**Constructed Things:**
  - NameOfThing=Monorail Stations Kit, PrefabHash=-511293804, PageLink=ThingItemMonorailStationKit

---

## More Cladding (Angled 2 Long)

- **Key:** ThingStructureCompositeCladdingAngled2Long
- **Prefab Name:** StructureCompositeCladdingAngled2Long
- **Prefab Hash:** -1890369877
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Angled 2)

- **Key:** ThingStructureCompositeCladdingAngled2
- **Prefab Name:** StructureCompositeCladdingAngled2
- **Prefab Hash:** 1192785394
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Angled 3 Long)

- **Key:** ThingStructureCompositeCladdingAngled3Long
- **Prefab Name:** StructureCompositeCladdingAngled3Long
- **Prefab Hash:** -1305274597
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Angled 4 Long)

- **Key:** ThingStructureCompositeCladdingAngled4Long
- **Prefab Name:** StructureCompositeCladdingAngled4Long
- **Prefab Hash:** 1297163
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Angled 5 Long)

- **Key:** ThingStructureCompositeCladdingAngled5Long
- **Prefab Name:** StructureCompositeCladdingAngled5Long
- **Prefab Hash:** 1031004859
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Angled 5)

- **Key:** ThingStructureCompositeCladdingAngled5
- **Prefab Name:** StructureCompositeCladdingAngled5
- **Prefab Hash:** -646127535
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Angled 6 Long)

- **Key:** ThingStructureCompositeCladdingAngled6Long
- **Prefab Name:** StructureCompositeCladdingAngled6Long
- **Prefab Hash:** 2060687467
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 375 K (102oC)
- **Auto Ignition:** 575 K (302oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Angled 7 Long)

- **Key:** ThingStructureCompositeCladdingAngled7Long
- **Prefab Name:** StructureCompositeCladdingAngled7Long
- **Prefab Hash:** 1202958811
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 375 K (102oC)
- **Auto Ignition:** 575 K (302oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Angled 8 Long)

- **Key:** ThingStructureCompositeCladdingAngled8Long
- **Prefab Name:** StructureCompositeCladdingAngled8Long
- **Prefab Hash:** -974969334
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 375 K (102oC)
- **Auto Ignition:** 575 K (302oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Angled Panel)

- **Key:** ThingStructureMoreCladdingAngledPanel
- **Prefab Name:** StructureMoreCladdingAngledPanel
- **Prefab Hash:** 799294245
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Angled To Panel)

- **Key:** ThingStructureMoreCladdingAngledToPanel
- **Prefab Name:** StructureMoreCladdingAngledToPanel
- **Prefab Hash:** 1187205050
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Cylindrical Inner To Panel)

- **Key:** ThingStructureMoreCladdingCylindricalInnerToPanel
- **Prefab Name:** StructureMoreCladdingCylindricalInnerToPanel
- **Prefab Hash:** -929007556
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Cylindrical Inner)

- **Key:** ThingStructureMoreCladdingCylindricalInner
- **Prefab Name:** StructureMoreCladdingCylindricalInner
- **Prefab Hash:** 73492298
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Cylindrical Panel Inner Porthole 2)

- **Key:** ThingStructureMoreCladdingCylindricalPanelInnerPorthole2
- **Prefab Name:** StructureMoreCladdingCylindricalPanelInnerPorthole2
- **Prefab Hash:** 1645742614
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Cylindrical Panel Inner Porthole)

- **Key:** ThingStructureMoreCladdingCylindricalPanelInnerPorthole
- **Prefab Name:** StructureMoreCladdingCylindricalPanelInnerPorthole
- **Prefab Hash:** -897730232
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Cylindrical Panel Inner)

- **Key:** ThingStructureMoreCladdingCylindricalPanelInner
- **Prefab Name:** StructureMoreCladdingCylindricalPanelInner
- **Prefab Hash:** 149277076
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Panel Porthole 2)

- **Key:** ThingStructureMoreCladdingPanelPorthole2
- **Prefab Name:** StructureMoreCladdingPanelPorthole2
- **Prefab Hash:** -1377115864
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Panel Porthole)

- **Key:** ThingStructureMoreCladdingPanelPorthole
- **Prefab Name:** StructureMoreCladdingPanelPorthole
- **Prefab Hash:** -2113724802
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Panel Rounded Inner)

- **Key:** ThingStructureMoreCladdingPanelRoundedInner
- **Prefab Name:** StructureMoreCladdingPanelRoundedInner
- **Prefab Hash:** -2029872754
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Rounded Inner To Panel)

- **Key:** ThingStructureMoreCladdingCornerRoundedInnerToPanel
- **Prefab Name:** StructureMoreCladdingCornerRoundedInnerToPanel
- **Prefab Hash:** -1198451346
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Rounded Inner To Panel)

- **Key:** ThingStructureMoreCladdingRoundedInnerToPanel
- **Prefab Name:** StructureMoreCladdingRoundedInnerToPanel
- **Prefab Hash:** -1215717292
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Rounded Inner To Rounded)

- **Key:** ThingStructureMoreCladdingCornerRoundedInnerToRounded
- **Prefab Name:** StructureMoreCladdingCornerRoundedInnerToRounded
- **Prefab Hash:** -426233220
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Rounded Inner)

- **Key:** ThingStructureMoreCladdingRoundedInner
- **Prefab Name:** StructureMoreCladdingRoundedInner
- **Prefab Hash:** 1234659578
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Rounded Panel)

- **Key:** ThingStructureMoreCladdingRoundedPanel
- **Prefab Name:** StructureMoreCladdingRoundedPanel
- **Prefab Hash:** -2046054340
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Rounded To Panel)

- **Key:** ThingStructureMoreCladdingRoundedToPanel
- **Prefab Name:** StructureMoreCladdingRoundedToPanel
- **Prefab Hash:** -109581141
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## More Cladding (Rounded To Panels)

- **Key:** ThingStructureMoreCladdingRoundedToPanels
- **Prefab Name:** StructureMoreCladdingRoundedToPanels
- **Prefab Hash:** 1525924487
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (More Cladding)
**Constructed Things:**
  - NameOfThing=Kit (More Cladding), PrefabHash=1716960538, PageLink=ThingItemKitMoreCladding

---

## Motion Sensor

Originally developed to monitor dance marathons, the motion sensor can also be connected to Logic systems for security purposes, automatic lighting, doors and various other applications. The sensor activates whenever a player enters the grid it is placed on.

- **Key:** ThingStructureMotionSensor
- **Prefab Name:** StructureMotionSensor
- **Prefab Hash:** -1713470563
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Sensors)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Sensors), PrefabHash=-1776897113, PageLink=ThingItemKitSensor

---

## Muffin

A delicious, semi-healthful snack, nothing comforts a Stationeer 800 million kilometers from home like a hand-made muffin.

- **Key:** ThingItemMuffin
- **Prefab Name:** ItemMuffin
- **Prefab Hash:** -1864982322
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 215
- **Nutrition Quality:** Best (+75% hydration capacity)
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Automated Oven (Tier One)
    - 50 x Flour (from Flour) + 10 x Milk (from Milk) + 1 x Egg (from Egg, Egg)
  - Printer: Microwave (Tier One)
    - 50 x Flour (from Flour) + 10 x Milk (from Milk) + 1 x Egg (from Egg, Egg)


---

## Mushroom

- **Key:** ReagentMushroom
- **Reagents Type:** Mushroom
**Found In Ore:**
  - NameOfThing=Cooked Mushroom, QuantityOfThing=1
  - NameOfThing=Mushroom, QuantityOfThing=1

---

## Mushroom

A tasty food item. Unlike normal plants, it consumes Oxygen and outputs Carbon Dioxide. Mushrooms will only mature at a moderate rate in darkness, and prolonged light will kill it.

- **Key:** ThingItemMushroom
- **Prefab Name:** ItemMushroom
- **Prefab Hash:** 2044798572
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 10
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Growth Time:** 1h 0min 1s
- **Stack Size:** 20
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Constructed From Kits:**
  - NameOfThing=Mushroom Seeds, PrefabHash=311593418, PageLink=ThingSeedBag_Mushroom
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=2 mol
  - NameOfThing=Polluted Water, QuantityOfThing=0.1 mol
**Used In:**
  - NameOfThing=Microwave, PrefabHash=-1136173965, PageLink=ThingApplianceMicrowave
  - NameOfThing=Automated Oven, PrefabHash=-1672404896, PageLink=ThingStructureAutomatedOven
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Mushroom Seeds

Grow a Mushroom.

- **Key:** ThingSeedBag_Mushroom
- **Prefab Name:** SeedBag_Mushroom
- **Prefab Hash:** 311593418
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

## Nickel

- **Key:** ReagentNickel
- **Reagents Type:** Nickel
**Found In Ore:**
  - NameOfThing=Ingot (Nickel), QuantityOfThing=1
  - NameOfThing=Ore (Nickel), QuantityOfThing=1

---

## Night Vision Goggles

- **Key:** ThingItemNVG
- **Prefab Name:** ItemNVG
- **Prefab Hash:** 982514123
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
  - LogicName=ReferenceId, LogicAccessTypes=0
**Slots:**
  - SlotName=Battery, SlotType=Battery, SlotIndex=0
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 2750 x Energy + 5 x Steel (from Ingot (Steel)) + 5 x Silicon (from Ingot (Silicon)) + 10 x Hastelloy (from Ingot (Hastelloy))


---

## Nitrogen

Nitrogen can be mixed with Oxygen to stabilize its flammability and avoid Oxygen toxicity, and is a resource in its own right, useful for creating, a breathable atmosphere (at roughly 3:1 Nitrogen and Oxygen). The most efficient source of Nitrogen is from Ice (Nitrice) deposites found around the Solar System. You can Condense Nitrogen into Liquid Nitrogen by lowering its temperature below its boiling point.

- **Key:** GasNitrogen
- **Specific Heat:** 20.6 J/K
- **Freeze Temperature:** 40K (-233C)
- **Boiling Temperature:** 75.2K (-198C) at 100kPa
**Found In Ore:**
  - NameOfThing=Ore (Cobalt), QuantityOfThing=3 mol
  - NameOfThing=Ore (Copper), QuantityOfThing=0.5 mol
  - NameOfThing=Ore (Gold), QuantityOfThing=0.5 mol
  - NameOfThing=Ice (Water), QuantityOfThing=5 mol
  - NameOfThing=Ore (Lead), QuantityOfThing=1 mol
  - NameOfThing=Ore (Nickel), QuantityOfThing=0.5 mol
  - NameOfThing=Ice (Nitrice), QuantityOfThing=22.5 mol
  - NameOfThing=Ice (Oxite), QuantityOfThing=2.5 mol
  - NameOfThing=Ore (Silicon), QuantityOfThing=1 mol
  - NameOfThing=Ore (Silver), QuantityOfThing=0.4 mol

---

## Nitrolyzer

This device is used to create Nitrous Oxide from Oxygen, Nitrogen, and a large amount of energy. The process does not completely transform all the available gas at once, so the output is a mix of all three gasses, which may need further processing. More NOS will be created, if the gas inside the machine is close to a 1/1 ratio of Oxygen to Nitrogen. The second gas input line in optional, and not required if the gas is pre mixed.

- **Key:** ThingStructureNitrolyzer
- **Prefab Name:** StructureNitrolyzer
- **Prefab Hash:** 1898243702
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
**Logic Bindings:**
  - Header=db, Label=DEVICE
  - Header=d0, Label=SCREW_0
  - Header=d1, Label=SCREW_1
**Slots:**
  - SlotName=Programmable Chip, SlotType=Programmable Chip, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Atmospherics)
**Mode Options:**
  - LogicName=Idle, LogicAccessTypes=0
  - LogicName=Active, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Pipe Input, LogicAccessTypes=1
  - LogicName=Pipe Input 2, LogicAccessTypes=2
  - LogicName=Pipe Output, LogicAccessTypes=3
  - LogicName=Connection, LogicAccessTypes=4
**Constructed Things:**
  - NameOfThing=Kit (Atmospherics), PrefabHash=1222286371, PageLink=ThingItemKitAtmospherics

---

## Nitrous Oxide

Nitrous oxide is a reactive gas that will knock players out if inhaled. It acts as an oxidizer for combustion, and allows volatile gasses to burn significantly hotter, faster, and at a lower autoignition temperature. It can be produced in an energy intensive process inside of a Nitrolyzer.

- **Key:** GasNitrousOxide
- **Specific Heat:** 37.2 J/K
- **Freeze Temperature:** 251K (-21.7C)
- **Boiling Temperature:** N/A
**Found In Ore:**
  - NameOfThing=Ore (Lead), QuantityOfThing=0.4 mol
  - NameOfThing=Ice (Nitrice), QuantityOfThing=2.5 mol
  - NameOfThing=Ore (Silver), QuantityOfThing=1 mol

---

## Norsec

With its roots in early 20th Century defense industry, Norsec (a.k.a. Northern Security Systems) was an early adopter of asteroid mining – one of its tugs being involved in the infamous Sisyphus Hit on the fledgling Martian colony at Sanders. Norsec was officially cleared of any wrong-doing, but when the ODA banned asteroidal relocation, the company shifted its focus to infrastructure and manufacturing. Norsec’s orbitally-based Space Systems Division is responsible for the design and production of ODA’s core transport systems, while also being rumoured to hold a large interest in ExMin. The company is also noted for its willingness to engage in experimental robotic technology.

- **Key:** Norsec

---

## Number 0 (Large)

- **Key:** ThingLText_0
- **Prefab Name:** LText_0
- **Prefab Hash:** 1048791911
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Large), PrefabHash=114270805, PageLink=ThingItemKitLettersLarge

---

## Number 0 (Medium)

- **Key:** ThingMText_0
- **Prefab Name:** MText_0
- **Prefab Hash:** -1728823085
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Medium), PrefabHash=-235611444, PageLink=ThingItemKitLettersMedium

---

## Number 1 (Large)

- **Key:** ThingLText_1
- **Prefab Name:** LText_1
- **Prefab Hash:** 1233419249
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Large), PrefabHash=114270805, PageLink=ThingItemKitLettersLarge

---

## Number 1 (Medium)

- **Key:** ThingMText_1
- **Prefab Name:** MText_1
- **Prefab Hash:** -269258683
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Medium), PrefabHash=-235611444, PageLink=ThingItemKitLettersMedium

---

## Number 2 (Large)

- **Key:** ThingLText_2
- **Prefab Name:** LText_2
- **Prefab Hash:** -796054965
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Large), PrefabHash=114270805, PageLink=ThingItemKitLettersLarge

---

## Number 2 (Medium)

- **Key:** ThingMText_2
- **Prefab Name:** MText_2
- **Prefab Hash:** 1996104191
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Medium), PrefabHash=-235611444, PageLink=ThingItemKitLettersMedium

---

## Number 3 (Large)

- **Key:** ThingLText_3
- **Prefab Name:** LText_3
- **Prefab Hash:** -1484121379
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Large), PrefabHash=114270805, PageLink=ThingItemKitLettersLarge

---

## Number 3 (Medium)

- **Key:** ThingMText_3
- **Prefab Name:** MText_3
- **Prefab Hash:** 33362281
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Medium), PrefabHash=-235611444, PageLink=ThingItemKitLettersMedium

---

## Number 4 (Large)

- **Key:** ThingLText_4
- **Prefab Name:** LText_4
- **Prefab Hash:** 971935614
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Large), PrefabHash=114270805, PageLink=ThingItemKitLettersLarge

---

## Number 4 (Medium)

- **Key:** ThingMText_4
- **Prefab Name:** MText_4
- **Prefab Hash:** -1617328950
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Medium), PrefabHash=-235611444, PageLink=ThingItemKitLettersMedium

---

## Number 5 (Large)

- **Key:** ThingLText_5
- **Prefab Name:** LText_5
- **Prefab Hash:** 1323941864
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Large), PrefabHash=114270805, PageLink=ThingItemKitLettersLarge

---

## Number 5 (Medium)

- **Key:** ThingMText_5
- **Prefab Name:** MText_5
- **Prefab Hash:** -392252324
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Medium), PrefabHash=-235611444, PageLink=ThingItemKitLettersMedium

---

## Number 6 (Large)

- **Key:** ThingLText_6
- **Prefab Name:** LText_6
- **Prefab Hash:** -673124782
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Large), PrefabHash=114270805, PageLink=ThingItemKitLettersLarge

---

## Number 6 (Medium)

- **Key:** ThingMText_6
- **Prefab Name:** MText_6
- **Prefab Hash:** 1905780198
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Medium), PrefabHash=-235611444, PageLink=ThingItemKitLettersMedium

---

## Number 7 (Large)

- **Key:** ThingLText_7
- **Prefab Name:** LText_7
- **Prefab Hash:** -1595416892
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Large), PrefabHash=114270805, PageLink=ThingItemKitLettersLarge

---

## Number 7 (Medium)

- **Key:** ThingMText_7
- **Prefab Name:** MText_7
- **Prefab Hash:** 110155120
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Medium), PrefabHash=-235611444, PageLink=ThingItemKitLettersMedium

---

## Number 8 (Large)

- **Key:** ThingLText_8
- **Prefab Name:** LText_8
- **Prefab Hash:** 811123541
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Large), PrefabHash=114270805, PageLink=ThingItemKitLettersLarge

---

## Number 8 (Medium)

- **Key:** ThingMText_8
- **Prefab Name:** MText_8
- **Prefab Hash:** -1775253279
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Medium), PrefabHash=-235611444, PageLink=ThingItemKitLettersMedium

---

## Number 9 (Large)

- **Key:** ThingLText_9
- **Prefab Name:** LText_9
- **Prefab Hash:** 1197470659
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Large), PrefabHash=114270805, PageLink=ThingItemKitLettersLarge

---

## Number 9 (Medium)

- **Key:** ThingMText_9
- **Prefab Name:** MText_9
- **Prefab Hash:** -517408649
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Constructed Things:**
  - NameOfThing=Kit (Letters Medium), PrefabHash=-235611444, PageLink=ThingItemKitLettersMedium

---

## NutritionPageTemplate

{0}

- **Key:** NutritionPageTemplate

---

## Occupancy Sensor

Will be triggered if there is a player in the same room as the sensor. The quantity variable will show the number of players. You can use configure it to only detect players who hold the correct Access Card using a Cartridge (Access Controller) in a Handheld Tablet. This sensor only works when placed in a room.

- **Key:** ThingStructureOccupancySensor
- **Prefab Name:** StructureOccupancySensor
- **Prefab Hash:** 322782515
- **Memory Size:** 144 B
- **Memory Access:** Read
- **Has Memory:** true
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Types:**
  - Text=OccupancyInstruction.Entity OP_CODE: 1, Index=1, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-39 | PREFAB_HASH | UINT_32 | | 40-63 | UNUSED | 24 | | HASH REPORTED UNSIGNED - MUST BE MANUALLY SIGNED |
  - Text=OccupancyInstruction.Inventory OP_CODE: 2, Index=2, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | SLOT_INDEX | BYTE_8 | | 16-47 | PREFAB_HASH | UINT_32 | | 48-63 | UNUSED | 16 | | HASH REPORTED UNSIGNED - MUST BE MANUALLY SIGNED |
**Build States:**
  - Description=1 x Kit (Sensors)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Sensors), PrefabHash=-1776897113, PageLink=ThingItemKitSensor

---

## ODA

In the aftermath of the Earth Crisis, humanity’s focus on space diminished. Yet many felt that, without ambitions beyond our home planet, our species might falter. Created in 2070CE by a newly revamped United Nations, the Offworld Development Agency was given a very specific goal - to guide and encourage human space exploration at a time the cosmos was fading from the public mind. It inaugurated the Stationeer Program in 2095. Understanding that funding would be difficult to come by, the ODA conceived the program as a slow-burn, low-outlay space initiative. While some derided Stationeers as 'cut-price cosmic castaways', the success of the program is testament to the wisdom and pragmatism of ODA's vision.

- **Key:** ODA

---

## OGRE

The Recurso OGRE (Orthogonal Ground Rotating Excavator) is a base structure with attached mining vehicle, which will mine a horizontal shaft up to X meters long. When full, the mining vehicle will return to the base to empty itself, before returning to dig. If it encounters empty space, it will also return to base and await instruction. The unit will return if deactivated. The OGRE can be connected to a chute system, and is controllable by a logic network. Note that the OGRE outputs more ore than a conventional Mining Drill over the same area, due to more efficient processing. MODES Idle - 0 Mining - 1 Returning - 2 DepostingOre - 3 Finished - 4

- **Key:** ThingStructureHorizontalAutoMiner
- **Prefab Name:** StructureHorizontalAutoMiner
- **Prefab Hash:** 1070427573
- **Base Power Draw:** 350 W
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
  - Description=1 x Kit (OGRE)
  - Description=Welding Torch 1 x Electronic Parts
  - Description=Welding Torch 2 x Iron Sheets
  - Description=Welding Torch 2 x Steel Sheets
**Mode Options:**
  - LogicName=Mode0, LogicAccessTypes=0
  - LogicName=Mode1, LogicAccessTypes=1
**Connections:**
  - LogicName=Chute Input, LogicAccessTypes=0
  - LogicName=Chute Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (OGRE), PrefabHash=844391171, PageLink=ThingItemKitHorizontalAutoMiner

---

## Oil

- **Key:** ReagentOil
- **Reagents Type:** Oil
**Found In Ore:**
  - NameOfThing=Soy Oil, QuantityOfThing=1

---

## OmniBridge Monitor Board

Computer motherboard that wirelessly monitors virtual wireless power and data grids, load metrics, and router diagnostics.

- **Key:** ThingItemCircuitboardOmniBridge
- **Prefab Name:** ItemCircuitboardOmniBridge
- **Prefab Hash:** 56660157
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 393 K (120oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 800 x Energy Temperature: 0 K (-273oC) to 0 K (-273oC) Pressure: 0 Pa to 0 Pa + 2 x Gold (from Ingot (Gold)) + 1 x Copper (from Ingot (Copper)) + 2 x Electrum (from Ingot (Electrum)) + 3 x Silicon (from Ingot (Silicon))


---

## OmniBridge Router

Granular 4-port wireless power and data bridge. Transmits/receives data and power virtual network paths across 4 physical ports.

- **Key:** ThingStructureOmniBridgeRouter
- **Prefab Name:** StructureOmniBridgeRouter
- **Prefab Hash:** 1480823343
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (OmniBridge)
**Mode Options:**
  - LogicName=Mode0, LogicAccessTypes=0
  - LogicName=Mode1, LogicAccessTypes=1
**Connections:**
  - LogicName=Power and Data Input, LogicAccessTypes=0
  - LogicName=Power and Data Input, LogicAccessTypes=1
  - LogicName=Power and Data Input, LogicAccessTypes=2
  - LogicName=Power and Data Input, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (OmniBridge), PrefabHash=-749299557, PageLink=ThingItemKitOmniBridge

---

## OmniBridge Wall Monitor

Dedicated wall-mounted low-power diagnostics display. Shows active virtual data networks, virtual power grid metrics, and router status.

- **Key:** ThingStructureOmniBridgeMonitor
- **Prefab Name:** StructureOmniBridgeMonitor
- **Prefab Hash:** 31318523
- **Base Power Draw:** 450 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
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
  - LogicName=Mode, LogicAccessTypes=0, 1
  - LogicName=FreeSlots, LogicAccessTypes=0, 1
  - LogicName=TotalSlots, LogicAccessTypes=0, 1
**Slots:**
  - SlotName=Circuitboard, SlotType=Circuitboard, SlotIndex=0
  - SlotName=Data Disk, SlotType=Data Disk, SlotIndex=1
**Build States:**
  - Description=1 x Kit (OmniBridge)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (OmniBridge), PrefabHash=-749299557, PageLink=ThingItemKitOmniBridge

---

## One Way Valve (Gas)

- **Key:** ThingStructurePipeOneWayValveLever
- **Prefab Name:** StructurePipeOneWayValveLever
- **Prefab Hash:** 1289581593
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Pipe Valve)
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Output, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Pipe Valve), PrefabHash=799323450, PageLink=ThingItemPipeValve

---

## One Way Valve (Liquid)

- **Key:** ThingStructurePipeLiquidOneWayValveLever
- **Prefab Name:** StructurePipeLiquidOneWayValveLever
- **Prefab Hash:** -523832822
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Liquid Pipe Valve)
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Output, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Liquid Pipe Valve), PrefabHash=-2126113312, PageLink=ThingItemLiquidPipeValve

---

## Orange Coloring

- **Key:** ReagentOrange Coloring

---

## Orbital Launch Mount

A launch mount deployed in low orbit using a Orbital Launch Mount Payload carried in a Payload Bay Large. Rockets can be constructed and/or landed here. Each Orbital Launch Mount will be allocated a slot on the Space Map and assigned a Location Code.

- **Key:** ThingStructureLaunchMountOrbital
- **Prefab Name:** StructureLaunchMountOrbital
- **Prefab Hash:** 640969314
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Orbital Launch Mount)
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Orbital Launch Mount), PrefabHash=-766450968, PageLink=ThingItemKitLaunchMountOrbital

---

## Orbital Launch Mount Payload

When attached to a Payload Bay Large the Orbital Launch Mount Payload can be deployed in Low Orbit, where it unpacks into a Orbital Launch Mount. Rockets can then be constructed and landed there, and crewed rockets can travel between it and launch mounts on the surface.

- **Key:** ThingDynamicOrbitalLaunchMountPayload
- **Prefab Name:** DynamicOrbitalLaunchMountPayload
- **Prefab Hash:** -1538309510
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Constructed Things:**
  - NameOfThing=Kit (Orbital Launch Mount Payload), PrefabHash=1102804329, PageLink=ThingItemKitOrbitalLaunchMountPayload

---

## Ore (Coal)

Humanity wouldn't have got to space without humble, combustible coal. Burn it in a Generator (Solid Fuel), smelt it in the Furnace to create alloys, or use it in the Reagent Processor to make Spray Paint (Black).

- **Key:** ThingItemCoalOre
- **Prefab Name:** ItemCoalOre
- **Prefab Hash:** 1724793494
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 323 K (50oC)
- **Auto Ignition:** 373 K (100oC)
**Build Recipe:**
  - Printer: Centrifuge (Tier One)
    - 1 x Hydrocarbon

**Found In Gas:**
  - NameOfThing=Pollutant, QuantityOfThing=3 mol
  - NameOfThing=Carbon Dioxide, QuantityOfThing=10 mol
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner
  - SubText=100 kW, SubValue=Energy, NameOfThing=Generator (Solid Fuel), PrefabHash=813146305, PageLink=ThingStructureSolidFuelGenerator

---

## Ore (Cobalt)

Cobalt is a chemical element with the symbol "Co" and is typically found in only small deposits. Cobalt is a rare substance, but used create the Heal Pill and several alloys.

- **Key:** ThingItemCobaltOre
- **Prefab Name:** ItemCobaltOre
- **Prefab Hash:** -983091249
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Centrifuge (Tier One)
    - 1 x Cobalt

**Found In Gas:**
  - NameOfThing=Nitrogen, QuantityOfThing=3 mol
  - NameOfThing=Methane, QuantityOfThing=1 mol
**Used In:**
  - NameOfThing=Chemistry Station, PrefabHash=1365789392, PageLink=ThingApplianceChemistryStation
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Ore (Copper)

Copper is a chemical element with the symbol "Cu". This common and highly conductive material is found on most astronomical bodies and is used in a variety of manufacturing processes including electronic components, alloys, and wires.

- **Key:** ThingItemCopperOre
- **Prefab Name:** ItemCopperOre
- **Prefab Hash:** -707307845
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Centrifuge (Tier One)
    - 1 x Copper

**Found In Gas:**
  - NameOfThing=Nitrogen, QuantityOfThing=0.5 mol
  - NameOfThing=Carbon Dioxide, QuantityOfThing=1 mol
  - NameOfThing=Pollutant, QuantityOfThing=1 mol
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Arc Furnace, PrefabHash=-247344692, PageLink=ThingStructureArcFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Ore (Gold)

Surprisingly common throughout the Solar System, Gold is thought to originate in the heart of supernovas, gathering as dust in the early stages of solar formation, then incorporating into the slowly accreting planetary bodies. Now a prized element in Stationeer construction, Gold is valued not for its beauty, but its reliability: inert, durable, conductive and highly stable, gold's strength is that it does nothing.

- **Key:** ThingItemGoldOre
- **Prefab Name:** ItemGoldOre
- **Prefab Hash:** -1348105509
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Centrifuge (Tier One)
    - 1 x Gold

**Found In Gas:**
  - NameOfThing=Oxygen, QuantityOfThing=0.2 mol
  - NameOfThing=Nitrogen, QuantityOfThing=0.5 mol
  - NameOfThing=Carbon Dioxide, QuantityOfThing=0.2 mol
  - NameOfThing=Pollutant, QuantityOfThing=2 mol
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Arc Furnace, PrefabHash=-247344692, PageLink=ThingStructureArcFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Ore (Iron)

Abundant throughout the Solar System, iron is the ore most commonly used by Stationeers constructing offworld bases. It can be smelted into both Ingot (Iron)s and Ingot (Steel)s.

- **Key:** ThingItemIronOre
- **Prefab Name:** ItemIronOre
- **Prefab Hash:** 1758427767
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Centrifuge (Tier One)
    - 1 x Iron

**Found In Gas:**
  - NameOfThing=Carbon Dioxide, QuantityOfThing=0.5 mol
  - NameOfThing=Pollutant, QuantityOfThing=2 mol
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Arc Furnace, PrefabHash=-247344692, PageLink=ThingStructureArcFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Ore (Lead)

Lead is a chemical element with the symbol "Pb". It is a dense, heavy metal with a low melting point. Lead is a used to make a variety of things such as alloys like Ingot (Solder) and munitions.

- **Key:** ThingItemLeadOre
- **Prefab Name:** ItemLeadOre
- **Prefab Hash:** -190236170
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Centrifuge (Tier One)
    - 1 x Lead

**Found In Gas:**
  - NameOfThing=Nitrous Oxide, QuantityOfThing=0.4 mol
  - NameOfThing=Nitrogen, QuantityOfThing=1 mol
  - NameOfThing=Carbon Dioxide, QuantityOfThing=0.4 mol
  - NameOfThing=Pollutant, QuantityOfThing=2 mol
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Arc Furnace, PrefabHash=-247344692, PageLink=ThingStructureArcFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Ore (Nickel)

Nickel is a chemical element with the symbol "Ni" and is a rare metal commonly used as a plating to prevent corrosion. Sought after by many Stationeers, Nickel is also commonly used to create several alloys.

- **Key:** ThingItemNickelOre
- **Prefab Name:** ItemNickelOre
- **Prefab Hash:** 1830218956
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Centrifuge (Tier One)
    - 1 x Nickel

**Found In Gas:**
  - NameOfThing=Nitrogen, QuantityOfThing=0.5 mol
  - NameOfThing=Carbon Dioxide, QuantityOfThing=1 mol
  - NameOfThing=Pollutant, QuantityOfThing=1 mol
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Arc Furnace, PrefabHash=-247344692, PageLink=ThingStructureArcFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Ore (Silicon)

Silicon is a chemical element with the symbol "Si" and is one of the most useful elements to Stationeers. Readily available throughout the universe, silicon is used in a range of alloys, glass, plastics and various electronic components a Stationeer may need to complete their mission.

- **Key:** ThingItemSiliconOre
- **Prefab Name:** ItemSiliconOre
- **Prefab Hash:** 1103972403
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Centrifuge (Tier One)
    - 1 x Silicon

**Found In Gas:**
  - NameOfThing=Nitrogen, QuantityOfThing=1 mol
  - NameOfThing=Carbon Dioxide, QuantityOfThing=1 mol
  - NameOfThing=Pollutant, QuantityOfThing=1 mol
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Arc Furnace, PrefabHash=-247344692, PageLink=ThingStructureArcFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Ore (Silver)

Silver is a chemical element with the symbol "Ag". Valued by many Stationeers for its attractive luster and sheen, it is also used in a variety of electronics components and alloys.

- **Key:** ThingItemSilverOre
- **Prefab Name:** ItemSilverOre
- **Prefab Hash:** -916518678
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Centrifuge (Tier One)
    - 1 x Silver

**Found In Gas:**
  - NameOfThing=Nitrogen, QuantityOfThing=0.4 mol
  - NameOfThing=Nitrous Oxide, QuantityOfThing=1 mol
  - NameOfThing=Pollutant, QuantityOfThing=1 mol
**Used In:**
  - NameOfThing=Chemistry Station, PrefabHash=1365789392, PageLink=ThingApplianceChemistryStation
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Arc Furnace, PrefabHash=-247344692, PageLink=ThingStructureArcFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Ore (Uranium)

In 1934, Enrico Fermi noticed that bombarding uranium with neutrons produced a burst of beta rays, and a new material. This process was named 'nuclear fission', and resulted in cheap energy, the Cold War, and countless thousand deaths. While reasonably common throughout the Solar System, Stationeers are wary of the material.

- **Key:** ThingItemUraniumOre
- **Prefab Name:** ItemUraniumOre
- **Prefab Hash:** -1516581844
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Centrifuge (Tier One)
    - 1 x Uranium

**Found In Gas:**
  - NameOfThing=Pollutant, QuantityOfThing=35 mol
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Ore Detector

A device for locating specific ores. The closer the player is to the selected type of ore, the more indicators will light up.

- **Key:** ThingItemOreDetector
- **Prefab Name:** ItemOreDetector
- **Prefab Hash:** 259902657
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 523 K (250oC)
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
  - LogicName=ReferenceId, LogicAccessTypes=0
**Slots:**
  - SlotName=Battery, SlotType=Battery, SlotIndex=0
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 5 x Gold (from Ingot (Gold)) + 5 x Copper (from Ingot (Copper)) + 2 x Solder (from Ingot (Solder))

**Mode Options:**
  - LogicName=Iron, LogicAccessTypes=0
  - LogicName=Coal, LogicAccessTypes=1
  - LogicName=Copper, LogicAccessTypes=2
  - LogicName=Gold, LogicAccessTypes=3
  - LogicName=Ice, LogicAccessTypes=4
  - LogicName=Nickel, LogicAccessTypes=5
  - LogicName=Lead, LogicAccessTypes=6
  - LogicName=Silver, LogicAccessTypes=7
  - LogicName=Silicon, LogicAccessTypes=8
  - LogicName=Oxite, LogicAccessTypes=9
  - LogicName=Volatiles, LogicAccessTypes=10
  - LogicName=Cobalt, LogicAccessTypes=11
  - LogicName=Nitrice, LogicAccessTypes=12

---

## Ores

These are items that are mined and can often be smelted. You can also get mixed ore by recycling items in the Recycler and then passing it through the Centrifuge which will break it into ore for smelting. There are some ores that will melt when exposed to sunlight or heat and produce gases. For example Ice (Water) melts into Water and Oxygen. Be careful to keep these out of heat or sunlight until you actually want them to melt.

- **Key:** OrePage

---

## Organics

- **Key:** OrganicPage

---

## Overalls (Australia)

- **Key:** ThingItemClothingBagOveralls_Aus
- **Prefab Name:** ItemClothingBagOveralls_Aus
- **Prefab Hash:** -869697826
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Overalls (Brazil)

- **Key:** ThingItemClothingBagOveralls_Brazil
- **Prefab Name:** ItemClothingBagOveralls_Brazil
- **Prefab Hash:** 611886665
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Overalls (Canada)

- **Key:** ThingItemClothingBagOveralls_Canada
- **Prefab Name:** ItemClothingBagOveralls_Canada
- **Prefab Hash:** 1265354377
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Overalls (China)

- **Key:** ThingItemClothingBagOveralls_China
- **Prefab Name:** ItemClothingBagOveralls_China
- **Prefab Hash:** -271773907
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Overalls (EU)

- **Key:** ThingItemClothingBagOveralls_EU
- **Prefab Name:** ItemClothingBagOveralls_EU
- **Prefab Hash:** 1969872429
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Overalls (France)

- **Key:** ThingItemClothingBagOveralls_France
- **Prefab Name:** ItemClothingBagOveralls_France
- **Prefab Hash:** 670416861
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Overalls (Germany)

- **Key:** ThingItemClothingBagOveralls_Germany
- **Prefab Name:** ItemClothingBagOveralls_Germany
- **Prefab Hash:** 1858014029
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Overalls (Japan)

- **Key:** ThingItemClothingBagOveralls_Japan
- **Prefab Name:** ItemClothingBagOveralls_Japan
- **Prefab Hash:** -1694123145
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Overalls (Korea)

- **Key:** ThingItemClothingBagOveralls_Korea
- **Prefab Name:** ItemClothingBagOveralls_Korea
- **Prefab Hash:** -1309808369
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Overalls (NZ)

- **Key:** ThingItemClothingBagOveralls_NZ
- **Prefab Name:** ItemClothingBagOveralls_NZ
- **Prefab Hash:** 102898295
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---

## Overalls (Paintable)

Overalls that can be coloured using the Spray Paints.

- **Key:** ThingItemClothingBagOveralls_Paintable
- **Prefab Name:** ItemClothingBagOveralls_Paintable
- **Prefab Hash:** 687536657
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=Access Card, SlotType=Access Card, SlotIndex=2
  - SlotName=Credit Card, SlotType=Credit Card, SlotIndex=3
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 25 x Silicon (from Ingot (Silicon))


---


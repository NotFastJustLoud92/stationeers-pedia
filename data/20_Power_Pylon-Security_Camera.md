# Power Pylon - Security Camera

## Power Pylon

Carries power across ground where laying cable is impractical. Pylons are strung with Cable Coil (Super Heavy). Hold a coil, click one node to start a run and another node to finish it. A single run reaches 40m and costs between 5 and 30 coil depending on how far it spans, and the cable must have a clear path, so terrain, walls and structures between the two nodes will refuse the link. A pylon carries two nodes and each node accepts one run, so a pylon passes a line onward rather than branching it. Cut a run with the Wire Cutters to recover its cable; deconstructing a pylon returns the cable of every run still attached.

- **Key:** ThingStructurePowerPylon
- **Prefab Name:** StructurePowerPylon
- **Prefab Hash:** 980657345
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=2 x Kit (Power Pylon)
  - Description=Welding Torch 2 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Power Pylon), PrefabHash=824902754, PageLink=ThingItemKitPowerPylon

---

## Power Pylon Terminus

Ties a pylon line into an ordinary cable network. The terminus counts as a length of super heavy cable, so everything reachable through the line becomes one network with everything wired to the terminus. It has a single node, which takes one run of Cable Coil (Super Heavy). A terminus cannot link straight to another terminus; the run has to pass through at least one Power Pylon.

- **Key:** ThingStructurePowerPylonTerminus
- **Prefab Name:** StructurePowerPylonTerminus
- **Prefab Hash:** -1234910677
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Power Pylon)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Power Pylon), PrefabHash=824902754, PageLink=ThingItemKitPowerPylon

---

## Power Transmitter Omni

- **Key:** ThingStructurePowerTransmitterOmni
- **Prefab Name:** StructurePowerTransmitterOmni
- **Prefab Hash:** -327468845
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Power Transmitter Omni)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Power Input, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Power Transmitter Omni), PrefabHash=-831211676, PageLink=ThingItemKitPowerTransmitterOmni

---

## Powered Bench

When it's time to sit, nothing supports you like a bench. This bench is powered, so you can use appliances like the Microwave.

- **Key:** ThingStructureBench
- **Prefab Name:** StructureBench
- **Prefab Hash:** -2042448192
- **Base Power Draw:** 10 W
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
  - LogicName=On, LogicAccessTypes=0, 1
  - LogicName=SortingClass, LogicAccessTypes=0, 1
  - LogicName=ReferenceId, LogicAccessTypes=0, 1
  - LogicName=FreeSlots, LogicAccessTypes=0, 1
  - LogicName=TotalSlots, LogicAccessTypes=0, 1
**Slots:**
  - SlotName=Appliance 1, SlotType=Appliance 1, SlotIndex=0
  - SlotName=Appliance 2, SlotType=Appliance 2, SlotIndex=1
**Build States:**
  - Description=1 x Kit (Tables)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Tables), PrefabHash=-1361598922, PageLink=ThingItemKitTables

---

## Powered Vent

Great for moving large quantities of air into a pipe network. Its primary purpose is for the creation of multi-grid airlocks. It can effeciently pull a vacuum on a small to medium sized room.

- **Key:** ThingStructurePoweredVent
- **Prefab Name:** StructurePoweredVent
- **Prefab Hash:** 938836756
- **Base Power Draw:** 250 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Powered Vent)
  - Description=Screwdriver 2 x Kit (Pipe)
  - Description=Welding Torch 2 x Plastic Sheets
**Mode Options:**
  - LogicName=Outward, LogicAccessTypes=0
  - LogicName=Inward, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Pipe Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Powered Vent), PrefabHash=2015439334, PageLink=ThingItemKitPoweredVent

---

## Powered Vent Large

For building large scale airlock systems and pressurised hangers, a bigger and bolder version of the Powered Vent that can effeciently pull a vacuum in large room.

- **Key:** ThingStructurePoweredVentLarge
- **Prefab Name:** StructurePoweredVentLarge
- **Prefab Hash:** -785498334
- **Base Power Draw:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=2 x Kit (Powered Vent)
  - Description=Screwdriver 2 x Electronic Parts
  - Description=Welding Torch 4 x Plastic Sheets
**Mode Options:**
  - LogicName=Outward, LogicAccessTypes=0
  - LogicName=Inward, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Pipe Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Powered Vent), PrefabHash=2015439334, PageLink=ThingItemKitPoweredVent

---

## Pressurant Valve

Pumps gas into a liquid pipe in order to raise the pressure

- **Key:** ThingStructurePressurantValve
- **Prefab Name:** StructurePressurantValve
- **Prefab Hash:** 23052817
- **Base Power Draw:** 100 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Pressure Regulator)
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Pressure Regulator), PrefabHash=1181371795, PageLink=ThingItemKitRegulator

---

## Pressure Fed Gas Engine

Inefficient but very powerful, the Pressure Fed Gas Engine moves gas from each of its two inputs based on the pressure of the input pipes. Control the mixing ratio of fuels by tweaking the input pressures to target a 2:1 mix of Methane to Oxygen gas. Chilling propellant gasses or using Nitrous Oxide as an oxydizer will result in even higher thrust outputs.

- **Key:** ThingStructurePressureFedGasEngine
- **Prefab Name:** StructurePressureFedGasEngine
- **Prefab Hash:** -624011170
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 500kg
**Build States:**
  - Description=1 x Kit (Pressure Fed Gas Engine)
  - Description=5 x Kit (Insulated Pipe)
  - Description=Welding Torch 4 x Steel Sheets
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Input 2, LogicAccessTypes=1
  - LogicName=Power and Data Output, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Pressure Fed Gas Engine), PrefabHash=-121514007, PageLink=ThingItemKitPressureFedGasEngine

---

## Pressure Fed Liquid Engine

Highly efficient and powerful, the Pressure Fed Liquid Engine is a challenging engine to run in a stable configuration. Liquid is pulled from the input into the engine based on the input gas pressure. Some gas is also moved in this process so Stationeers will need to devise a system to maintain a high gas pressure in the liquid input pipe. The second liquid pipe connection is an optional heat-exchanger connection which exchanges heat between the pipes contents and the engine bell, the Setting variable drives the effectiveness of the heat-exchanger.

- **Key:** ThingStructurePressureFedLiquidEngine
- **Prefab Name:** StructurePressureFedLiquidEngine
- **Prefab Hash:** 379750958
- **Base Power Draw:** 20 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 500kg
**Build States:**
  - Description=1 x Kit (Pressure Fed Liquid Engine)
  - Description=4 x Kit (Insulated Liquid Pipe)
  - Description=Welding Torch 4 x Steel Sheets
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Input 2, LogicAccessTypes=1
  - LogicName=Power and Data Output, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Pressure Fed Liquid Engine), PrefabHash=-99091572, PageLink=ThingItemKitPressureFedLiquidEngine

---

## Pressure Regulator

Controlling the flow of gas between two pipe networks, pressure regulators shift gas until a set pressure on the outlet side is achieved, or the gas supply is exhausted. The back pressure regulator, by contrast, will only operate when pressure on the intake side exceeds the set value. With a max pressure of over 20,000kPa, it requires power to operate.

- **Key:** ThingStructurePressureRegulator
- **Prefab Name:** StructurePressureRegulator
- **Prefab Hash:** 209854039
- **Base Power Draw:** 100 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Pressure Regulator)
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Pressure Regulator), PrefabHash=1181371795, PageLink=ThingItemKitRegulator

---

## Proximity Sensor

Will be triggered if there is a player in the range of the sensor (as defined by the setting dial). The quantity variable will show the number of players. You can configure the sensor to only detect players who hold the correct Access Card using a Cartridge (Access Controller) in a Handheld Tablet.

- **Key:** ThingStructureProximitySensor
- **Prefab Name:** StructureProximitySensor
- **Prefab Hash:** 568800213
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Sensors)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Sensors), PrefabHash=-1776897113, PageLink=ThingItemKitSensor

---

## Pumped Gas Engine

The most reliable of all the rocket engines, the Pumped Gas Engine runs on a 2:1 mix of Methane to Oxygen gas.

- **Key:** ThingStructureGovernedGasEngine
- **Prefab Name:** StructureGovernedGasEngine
- **Prefab Hash:** -214232602
- **Base Power Draw:** 200 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 500kg
**Build States:**
  - Description=1 x Kit (Pumped Gas Rocket Engine)
  - Description=5 x Kit (Pipe)
  - Description=Welding Torch 4 x Steel Sheets
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Pumped Gas Rocket Engine), PrefabHash=206848766, PageLink=ThingItemKitGovernedGasRocketEngine

---

## Pumped Liquid Engine

Liquid propellants bring greater efficiencies with Pumped Liquid Engine. Two inputs are provided so Stationeers can seperate their fuels, the Setting variable controls the mixing ratio of the inputs. The engine is designed to run on Liquid Methane and Liquid Oxygen, some Stationeers have reported excessive thrust values by switching to Liquid Nitrous Oxide

- **Key:** ThingStructurePumpedLiquidEngine
- **Prefab Name:** StructurePumpedLiquidEngine
- **Prefab Hash:** -2031440019
- **Base Power Draw:** 200 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 500kg
**Build States:**
  - Description=1 x Kit (Pumped Liquid Engine)
  - Description=5 x Kit (Liquid Pipe)
  - Description=Welding Torch 4 x Steel Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
  - LogicName=Power and Data Output, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Pumped Liquid Engine), PrefabHash=1921918951, PageLink=ThingItemKitPumpedLiquidEngine

---

## Pumpkin

- **Key:** ReagentPumpkin
- **Reagents Type:** Pumpkin
**Found In Ore:**
  - NameOfThing=Cooked Pumpkin, QuantityOfThing=1
  - NameOfThing=Pumpkin, QuantityOfThing=1

---

## Pumpkin

Pumpkins are a perennial plant, with both a long growth time, and a long time between harvests. Its low requirement for darkness allows for accelerated growing if provided with extra light.

- **Key:** ThingItemPumpkin
- **Prefab Name:** ItemPumpkin
- **Prefab Hash:** 1277828144
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 50
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Growth Time:** 4h 0min 1s
- **Stack Size:** 20
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Constructed From Kits:**
  - NameOfThing=Pumpkin Seeds, PrefabHash=1423199840, PageLink=ThingSeedBag_Pumpkin
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=18 mol
  - NameOfThing=Polluted Water, QuantityOfThing=0.9 mol
**Used In:**
  - NameOfThing=Microwave, PrefabHash=-1136173965, PageLink=ThingApplianceMicrowave
  - NameOfThing=Automated Oven, PrefabHash=-1672404896, PageLink=ThingStructureAutomatedOven
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Pumpkin Pie

- **Key:** ThingItemPumpkinPie
- **Prefab Name:** ItemPumpkinPie
- **Prefab Hash:** 62768076
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 300
- **Nutrition Quality:** Best (+75% hydration capacity)
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Automated Oven (Tier One)
    - 100 x Flour (from Flour) + 10 x Milk (from Milk) + 1 x Egg (from Egg, Egg) + 10 x Pumpkin (from Pumpkin)
  - Printer: Microwave (Tier One)
    - 100 x Flour (from Flour) + 10 x Milk (from Milk) + 1 x Egg (from Egg, Egg) + 10 x Pumpkin (from Pumpkin)


---

## Pumpkin Seeds

Grow a Pumpkin.

- **Key:** ThingSeedBag_Pumpkin
- **Prefab Name:** SeedBag_Pumpkin
- **Prefab Hash:** 1423199840
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

## Pumpkin Soup

Made using Cooked Pumpkin and an Empty Can in a Basic Packaging Machine or Advanced Packaging Machine. Fairly high in nutrition, canned food does not decay

- **Key:** ThingItemPumpkinSoup
- **Prefab Name:** ItemPumpkinSoup
- **Prefab Hash:** 1277979876
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 160
- **Nutrition Quality:** Good (+25% hydration capacity)
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Advanced Packaging Machine (Tier One)
    - 1 x Steel (from Empty Can) + 1 x Oil (from Soy Oil) + 2 x Pumpkin (from Cooked Pumpkin)
  - Printer: Basic Packaging Machine (Tier One)
    - 1 x Steel (from Empty Can) + 1 x Oil (from Soy Oil) + 2 x Pumpkin (from Cooked Pumpkin)


---

## Pure Ice Carbon Dioxide

A frozen chunk of pure Carbon Dioxide

- **Key:** ThingItemPureIceCarbonDioxide
- **Prefab Name:** ItemPureIceCarbonDioxide
- **Prefab Hash:** -1251009404
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 218 K (-55.3 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Hydrazine

A frozen chunk of Hydrazine

- **Key:** ThingItemPureIceHydrazine
- **Prefab Name:** ItemPureIceHydrazine
- **Prefab Hash:** 1225192790
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 246 K (-26.9 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Hydrochloric Acid

A frozen chunk of Hydrochloric Acid

- **Key:** ThingItemPureIceHydrochloricAcid
- **Prefab Name:** ItemPureIceHydrochloricAcid
- **Prefab Hash:** -2141998355
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 247 K (-25.9 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Hydrogen

A frozen chunk of pure Hydrogen

- **Key:** ThingItemPureIceHydrogen
- **Prefab Name:** ItemPureIceHydrogen
- **Prefab Hash:** 944530361
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 15.2 K (-258 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Alcohol

A frozen chunk of Liquid Alcohol

- **Key:** ThingItemPureIceLiquidAlcohol
- **Prefab Name:** ItemPureIceLiquidAlcohol
- **Prefab Hash:** -1149758986
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 232 K (-41.5 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Carbon Dioxide

A frozen chunk of pure Liquid Carbon Dioxide

- **Key:** ThingItemPureIceLiquidCarbonDioxide
- **Prefab Name:** ItemPureIceLiquidCarbonDioxide
- **Prefab Hash:** -1715945725
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 218 K (-55.3 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Hydrazine

A frozen chunk of Liquid Hydrazine

- **Key:** ThingItemPureIceLiquidHydrazine
- **Prefab Name:** ItemPureIceLiquidHydrazine
- **Prefab Hash:** 555924824
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 246 K (-26.9 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Hydrochloric Acid

A frozen chunk of Liquid Hydrochloric Acid

- **Key:** ThingItemPureIceLiquidHydrochloricAcid
- **Prefab Name:** ItemPureIceLiquidHydrochloricAcid
- **Prefab Hash:** -105637991
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 247 K (-25.9 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Hydrogen

A frozen chunk of pure Liquid Hydrogen

- **Key:** ThingItemPureIceLiquidHydrogen
- **Prefab Name:** ItemPureIceLiquidHydrogen
- **Prefab Hash:** -1044933269
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 15.2 K (-258 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Methane

A frozen chunk of pure Liquid Methane

- **Key:** ThingItemPureIceLiquidVolatiles
- **Prefab Name:** ItemPureIceLiquidVolatiles
- **Prefab Hash:** -1306628937
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 81.5 K (-192 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Nitrogen

A frozen chunk of pure Liquid Nitrogen

- **Key:** ThingItemPureIceLiquidNitrogen
- **Prefab Name:** ItemPureIceLiquidNitrogen
- **Prefab Hash:** 1674576569
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 40 K (-233 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Nitrous

A frozen chunk of pure Liquid Nitrous Oxide

- **Key:** ThingItemPureIceLiquidNitrous
- **Prefab Name:** ItemPureIceLiquidNitrous
- **Prefab Hash:** 1428477399
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 251 K (-21.7 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Oxygen

A frozen chunk of pure Liquid Oxygen

- **Key:** ThingItemPureIceLiquidOxygen
- **Prefab Name:** ItemPureIceLiquidOxygen
- **Prefab Hash:** 541621589
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 56.4 K (-217 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Pollutant

A frozen chunk of pure Liquid Pollutant

- **Key:** ThingItemPureIceLiquidPollutant
- **Prefab Name:** ItemPureIceLiquidPollutant
- **Prefab Hash:** -1748926678
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 173 K (-99.8 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Liquid Silanol

A frozen chunk of Liquid Silanol

- **Key:** ThingItemPureIceLiquidSilanol
- **Prefab Name:** ItemPureIceLiquidSilanol
- **Prefab Hash:** 2113311218
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 143 K (-130 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Methane

A frozen chunk of pure Methane

- **Key:** ThingItemPureIceVolatiles
- **Prefab Name:** ItemPureIceVolatiles
- **Prefab Hash:** -633723719
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 81.5 K (-192 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Nitrogen

A frozen chunk of pure Nitrogen

- **Key:** ThingItemPureIceNitrogen
- **Prefab Name:** ItemPureIceNitrogen
- **Prefab Hash:** -1708395413
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 40 K (-233 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice NitrousOxide

A frozen chunk of pure Nitrous Oxide

- **Key:** ThingItemPureIceNitrous
- **Prefab Name:** ItemPureIceNitrous
- **Prefab Hash:** 386754635
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 251 K (-21.7 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Oxygen

A frozen chunk of pure Oxygen

- **Key:** ThingItemPureIceOxygen
- **Prefab Name:** ItemPureIceOxygen
- **Prefab Hash:** -1150448260
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 56.4 K (-217 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Ozone

A frozen chunk of Liquid Ozone

- **Key:** ThingItemPureIceLiquidOzone
- **Prefab Name:** ItemPureIceLiquidOzone
- **Prefab Hash:** 1274165821
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 51 K (-222 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Ozone

A frozen chunk of Ozone

- **Key:** ThingItemPureIceOzone
- **Prefab Name:** ItemPureIceOzone
- **Prefab Hash:** 180397053
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 51 K (-222 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Pollutant

A frozen chunk of pure Pollutant

- **Key:** ThingItemPureIcePollutant
- **Prefab Name:** ItemPureIcePollutant
- **Prefab Hash:** -1755356
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 173 K (-99.8 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Polluted Water

A frozen chunk of Polluted Water

- **Key:** ThingItemPureIcePollutedWater
- **Prefab Name:** ItemPureIcePollutedWater
- **Prefab Hash:** -2073202179
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 276 K (3 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Silanol

A frozen chunk of Silanol

- **Key:** ThingItemPureIceSilanol
- **Prefab Name:** ItemPureIceSilanol
- **Prefab Hash:** 1071590510
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 143 K (-130 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Steam

A frozen chunk of pure Steam

- **Key:** ThingItemPureIceSteam
- **Prefab Name:** ItemPureIceSteam
- **Prefab Hash:** -874791066
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 273 K (0 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Pure Ice Water

A frozen chunk of pure Water

- **Key:** ThingItemPureIce
- **Prefab Name:** ItemPureIce
- **Prefab Hash:** -1616308158
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 273 K (0 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Purge Valve

Allows for removal of pressurant gas and evaporated liquids from a liquid pipe. Similar in function to a Back Pressure Regulator the Purge Valve moves gas from the input liquid pipe to the output gas pipe aiming to keep the pressure of the input at the target setting.

- **Key:** ThingStructurePurgeValve
- **Prefab Name:** StructurePurgeValve
- **Prefab Hash:** -737232128
- **Base Power Draw:** 100 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Pressure Regulator)
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Pressure Regulator), PrefabHash=1181371795, PageLink=ThingItemKitRegulator

---

## Railing Elegant (Type 1)

- **Key:** ThingRailingElegant01
- **Prefab Name:** RailingElegant01
- **Prefab Hash:** 399661231
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Railing)
**Constructed Things:**
  - NameOfThing=Kit (Railing), PrefabHash=750176282, PageLink=ThingItemKitRailing

---

## Railing Elegant (Type 2)

- **Key:** ThingRailingElegant02
- **Prefab Name:** RailingElegant02
- **Prefab Hash:** -1898247915
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Railing)
**Constructed Things:**
  - NameOfThing=Kit (Railing), PrefabHash=750176282, PageLink=ThingItemKitRailing

---

## Railing Industrial (Type 1)

"Safety third."

- **Key:** ThingStructureRailing
- **Prefab Name:** StructureRailing
- **Prefab Hash:** -1756913871
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Railing)
**Constructed Things:**
  - NameOfThing=Kit (Railing), PrefabHash=750176282, PageLink=ThingItemKitRailing

---

## Railing Industrial (Type 2)

- **Key:** ThingRailingIndustrial02
- **Prefab Name:** RailingIndustrial02
- **Prefab Hash:** -2072792175
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Railing)
**Constructed Things:**
  - NameOfThing=Kit (Railing), PrefabHash=750176282, PageLink=ThingItemKitRailing

---

## Reagent Mix

Reagent mix is pure potential. A slurry of undifferentiated ores, it is output by the Recycler and can be fed into the Centrifuge to separate and recover the individual materials. Reagent mix is also output by the Furnace when the current contents are ejected without smelting a specific ingot.

- **Key:** ThingItemReagentMix
- **Prefab Name:** ItemReagentMix
- **Prefab Hash:** -1641500434
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Reagent Processor

Sitting somewhere between a high powered juicer and an alchemist's alembic, the Xigo reagent processor turns certain raw materials and food items into cooking and crafting ingredients. Indispensible in any space kitchen, just bolt it to the bench, and you're ready to go.

- **Key:** ThingApplianceReagentProcessor
- **Prefab Name:** ApplianceReagentProcessor
- **Prefab Hash:** 1260918085
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 973 K (700oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Slots:**
  - SlotName=Input, SlotType=Input, SlotIndex=0
  - SlotName=Output, SlotType=Output, SlotIndex=1
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 1500 x Energy + 5 x Iron (from Ingot (Iron)) + 1 x Gold (from Ingot (Gold)) + 2 x Copper (from Ingot (Copper))

**Resources Used:**
  - NameOfThing=Wheat, PrefabHash=-1057658015, PageLink=ThingItemWheat
  - NameOfThing=Sugarcane, PrefabHash=-1335056202, PageLink=ThingItemSugarCane
  - NameOfThing=Cocoa, PrefabHash=680051921, PageLink=ThingItemCocoaTree
  - NameOfThing=Soybean, PrefabHash=1924673028, PageLink=ThingItemSoybean

---

## Reagent Reader

- **Key:** ThingStructureLogicReagentReader
- **Prefab Name:** StructureLogicReagentReader
- **Prefab Hash:** -124308857
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic I/O)
**Connections:**
  - LogicName=Data Input, LogicAccessTypes=0
  - LogicName=Data Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Logic I/O), PrefabHash=1997293610, PageLink=ThingItemKitLogicInputOutput

---

## ReagentPageTemplate

A reagent, often usable when in Ingots form. Unit {1} {2}

- **Key:** ReagentPageTemplate

---

## Reagents

These are chemical quantities of certain types.

- **Key:** ReagentPage

---

## Recurso Espaciais

This long-standing Brazilian mining group branched into space in the late 21st century. Focused primarily on bulk minerals and metals, the company is perhaps best understood as an extension of the Brazilian government – very few upper echelon political figures in modern Brazil are not implicated in one arm or another of this industrial behemoth. Enmeshment with South American politics has given the company heavy influence over the Manaus space elevator. This deep state control has led to other groups – the ODA included – to exercise a certain ‘flexibility’ toward Recurso. Accusations of illegal asteroid relocation, safety violations and numerous commercial infringements have barely touched it. Meanwhile, defenders point out that very little has been proven in court, and Recurso is hardly alone – hence the truism: 'In space, we all live in glass houses.'

- **Key:** Recurso

---

## Recycler

A device for collecting the raw resources while destroying an item. Produces Reagent Mix containing packages of reagents. Pass these through the Centrifuge to gain back the source ores. Plants and organic matter passed through will create Biomass, which when passed through the Centrifuge will produce Biomass.

- **Key:** ThingStructureRecycler
- **Prefab Name:** StructureRecycler
- **Prefab Hash:** -1633947337
- **Base Power Draw:** 100 W
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
  - Description=1 x Kit (Recycler)
**Connections:**
  - LogicName=Chute Input, LogicAccessTypes=0
  - LogicName=Chute Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Recycler), PrefabHash=849148192, PageLink=ThingItemKitRecycler

---

## Red Coloring

- **Key:** ReagentRed Coloring

---

## Refrigerated Vending Machine

The refrigerated OmniKool vending machine is an advanced version of the standard Vending Machine, which maintains an optimum pressure and constant temperature of -130 degrees C, to prevent food spoilage. It can hold up to 100 stacks. The OmniKool also has an in-built Stacker, allowing players to set the stack sizes of any items ADDED to the device. The unit's default stack size is 50. NOTE: altering stack sizes DOES NOT update existing stacks within the machine, only those subsequently added.

- **Key:** ThingStructureRefrigeratedVendingMachine
- **Prefab Name:** StructureRefrigeratedVendingMachine
- **Prefab Hash:** -1577831321
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
  - Description=1 x Kit (Vending Machine Refrigerated)
  - Description=2 x Plastic Sheets
  - Description=Screwdriver
**Connections:**
  - LogicName=Chute Input, LogicAccessTypes=0
  - LogicName=Chute Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Vending Machine Refrigerated), PrefabHash=-1867508561, PageLink=ThingItemKitVendingMachineRefrigerated

---

## Reinforced Wall

- **Key:** ThingStructureReinforcedWall
- **Prefab Name:** StructureReinforcedWall
- **Prefab Hash:** -475746988
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 573 K (300oC)
- **Auto Ignition:** 873 K (600oC)
**Build States:**
  - Description=1 x Kit (Reinforced Walls)
  - Description=Welding Torch 1 x Astroloy Sheets
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Reinforced Walls), PrefabHash=1459985302, PageLink=ThingItemKitReinforcedWindows

---

## Reinforced Window (Composite Steel)

Enjoy vistas of even the most savage, alien landscapes with these heavy duty window frames, which are resistant to high pressure differentials.

- **Key:** ThingStructureReinforcedCompositeWindowSteel
- **Prefab Name:** StructureReinforcedCompositeWindowSteel
- **Prefab Hash:** -816454272
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Reinforced Walls)
  - Description=1 x Steel Sheets
  - Description=1 x Stellite Glass Sheets
**Constructed Things:**
  - NameOfThing=Kit (Reinforced Walls), PrefabHash=1459985302, PageLink=ThingItemKitReinforcedWindows

---

## Reinforced Window (Composite)

Enjoy vistas of even the most savage, alien landscapes with these heavy duty window frames, which are resistant to high pressure differentials.

- **Key:** ThingStructureReinforcedCompositeWindow
- **Prefab Name:** StructureReinforcedCompositeWindow
- **Prefab Hash:** 2027713511
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Reinforced Walls)
  - Description=1 x Plastic Sheets
  - Description=1 x Stellite Glass Sheets
**Constructed Things:**
  - NameOfThing=Kit (Reinforced Walls), PrefabHash=1459985302, PageLink=ThingItemKitReinforcedWindows

---

## Reinforced Window (Padded)

Enjoy vistas of even the most savage, alien landscapes with these heavy duty window frames, which are resistant to high pressure differentials.

- **Key:** ThingStructureReinforcedWallPaddedWindow
- **Prefab Name:** StructureReinforcedWallPaddedWindow
- **Prefab Hash:** 1939061729
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Reinforced Walls)
  - Description=1 x Plastic Sheets
  - Description=1 x Stellite Glass Sheets
**Constructed Things:**
  - NameOfThing=Kit (Reinforced Walls), PrefabHash=1459985302, PageLink=ThingItemKitReinforcedWindows

---

## Reinforced Window (Thin)

Enjoy vistas of even the most savage, alien landscapes with these heavy duty window frames, which are resistant to high pressure differentials.

- **Key:** ThingStructureReinforcedWallPaddedWindowThin
- **Prefab Name:** StructureReinforcedWallPaddedWindowThin
- **Prefab Hash:** 158502707
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Reinforced Walls)
  - Description=1 x Plastic Sheets
  - Description=1 x Stellite Glass Sheets
**Constructed Things:**
  - NameOfThing=Kit (Reinforced Walls), PrefabHash=1459985302, PageLink=ThingItemKitReinforcedWindows

---

## Remote Detonator

- **Key:** ThingItemRemoteDetonator
- **Prefab Name:** ItemRemoteDetonator
- **Prefab Hash:** 678483886
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
  - Printer: Tool Manufactory (Tier Two)
    - 1500 x Energy + 5 x Copper (from Ingot (Copper)) + 5 x Steel (from Ingot (Steel)) + 5 x Solder (from Ingot (Solder))

**Mode Options:**
  - LogicName=Mode0, LogicAccessTypes=0
  - LogicName=Mode1, LogicAccessTypes=1

---

## Residential Supplies Package

- **Key:** ThingItemResidentialPackage
- **Prefab Name:** ItemResidentialPackage
- **Prefab Hash:** 509629504
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

## Resources

These are Items that are consumed during Construction and other tasks.

- **Key:** ResourcePage

---

## Respawn Point

Place a respawn point to set a player entry point to your base when loading in, or returning from the dead.

- **Key:** ThingRespawnPoint
- **Prefab Name:** RespawnPoint
- **Prefab Hash:** -788672929
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Respawn)
**Constructed Things:**
  - NameOfThing=Kit (Respawn), PrefabHash=1574688481, PageLink=ThingItemKitRespawnPointWallMounted

---

## Respawn Point (Mounted)

- **Key:** ThingRespawnPointWallMounted
- **Prefab Name:** RespawnPointWallMounted
- **Prefab Hash:** -491247370
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Respawn)
**Constructed Things:**
  - NameOfThing=Kit (Respawn), PrefabHash=1574688481, PageLink=ThingItemKitRespawnPointWallMounted

---

## Rice

- **Key:** ReagentRice
- **Reagents Type:** Rice
**Found In Ore:**
  - NameOfThing=Cooked Rice, QuantityOfThing=1
  - NameOfThing=Rice, QuantityOfThing=1

---

## Rice

Rice grows at a moderate rate as long as its supplied with plenty of water. Being more dependant on water, rice plants can easily die during periods of drought.

- **Key:** ThingItemRice
- **Prefab Name:** ItemRice
- **Prefab Hash:** 658916791
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 3
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Growth Time:** 1h 0min 1s
- **Stack Size:** 50
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Constructed From Kits:**
  - NameOfThing=Rice Seeds, PrefabHash=-1691151239, PageLink=ThingSeedBag_Rice
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=8 mol
  - NameOfThing=Polluted Water, QuantityOfThing=0.4 mol
**Used In:**
  - NameOfThing=Microwave, PrefabHash=-1136173965, PageLink=ThingApplianceMicrowave
  - NameOfThing=Automated Oven, PrefabHash=-1672404896, PageLink=ThingStructureAutomatedOven
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Rice Seeds

Grow some Rice.

- **Key:** ThingSeedBag_Rice
- **Prefab Name:** SeedBag_Rice
- **Prefab Hash:** -1691151239
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

## Road Flare

Designed to burn anywhere in the Solar System, the EZC magnesium fusee supplies its own oxygen to fuel combustion, and dispel the eternal night of space.

- **Key:** ThingItemRoadFlare
- **Prefab Name:** ItemRoadFlare
- **Prefab Hash:** 871811564
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 20
- **Paintable:** Yes
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Rocket Avionics

- **Key:** ThingStructureRocketAvionics
- **Prefab Name:** StructureRocketAvionics
- **Prefab Hash:** 808389066
- **Base Power Draw:** 10 W
- **Memory Size:** 512 B
- **Memory Access:** Read Write
- **Has Memory:** true
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Logic Types:**
  - Text=RocketAvionicsInstruction.StackPointer OP_CODE: 1, Index=1, Info=| VALID ONLY AT ADDRESS 63 | | 0-7 | OP_CODE | BYTE_8 | | 8-23 | INDEX | USHORT_16 | | 24-63 | UNUSED | 40 |
  - Text=RocketAvionicsInstruction.JumpToAddress OP_CODE: 2, Index=2, Info=| VALID ONLY AT ADDRESSES 0 TO 53 | | 0-7 | OP_CODE | BYTE_8 | | 8-23 | STACK_ADDRESS | USHORT_16 | | 24-63 | UNUSED | 40 |
  - Text=RocketAvionicsInstruction.ResourceSite OP_CODE: 3, Index=3, Info=| VALID ONLY AT ADDRESSES 54 TO 62 | | 0-7 | OP_CODE | BYTE_8 | | 8-15 | RESOURCE_TYPE | BYTE_8 | | 16-23 | DENSITY_RATIO_10 | BYTE_8 | | 24-31 | RICHNESS_RATIO_10 | BYTE_8 | | 32-39 | SIZE_RATIO_10 | BYTE_8 | | 40-63 | UNUSED | 24 |
  - Text=RocketAvionicsInstruction.SurveySite OP_CODE: 4, Index=4, Info=| VALID ONLY AT ADDRESSES 54 TO 62 | | 0-7 | OP_CODE | BYTE_8 | | 8-15 | RESOURCE_TYPE | BYTE_8 | | 16-31 | SURVEY_PROGRESS | USHORT_16 | | 32-63 | UNUSED | 32 |
  - Text=RocketAvionicsInstruction.ChildResourceSite OP_CODE: 5, Index=5, Info=| VALID ONLY AT ADDRESSES 54 TO 62 | | 0-7 | OP_CODE | BYTE_8 | | 8-15 | RESOURCE_TYPE | BYTE_8 | | 16-23 | DENSITY_RATIO_10 | BYTE_8 | | 24-31 | RICHNESS_RATIO_10 | BYTE_8 | | 32-39 | SIZE_RATIO_10 | BYTE_8 | | 40-63 | UNUSED | 24 |
  - Text=RocketAvionicsInstruction.ChildSurveySite OP_CODE: 6, Index=6, Info=| VALID ONLY AT ADDRESSES 54 TO 62 | | 0-7 | OP_CODE | BYTE_8 | | 8-15 | RESOURCE_TYPE | BYTE_8 | | 16-31 | SURVEY_PROGRESS | USHORT_16 | | 32-63 | UNUSED | 32 |
**Build States:**
  - Description=1 x Kit (Avionics)
  - Description=Screwdriver 2 x Electronic Parts
  - Description=Welding Torch 4 x Steel Sheets
**Mode Options:**
  - LogicName=Invalid, LogicAccessTypes=0
  - LogicName=None, LogicAccessTypes=1
  - LogicName=Mine, LogicAccessTypes=2
  - LogicName=Survey, LogicAccessTypes=3
  - LogicName=Discover, LogicAccessTypes=4
  - LogicName=Chart, LogicAccessTypes=5
  - LogicName=Deploy, LogicAccessTypes=6
  - LogicName=Surface Scan, LogicAccessTypes=7
  - LogicName=Transfer, LogicAccessTypes=8
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Avionics), PrefabHash=1396305045, PageLink=ThingItemKitRocketAvionics

---

## Rocket Celestial Tracker

The Celestial Tracker can be placed in Rockets and when turned on will provide data that can be used to orientate devices such as the Telescope. The Horizontal and Vertical output is localized to the orientation of the tracker. You can calibrate your alignment by comparing the result for the primary body with the output from the Daylight Sensor. Full functionality will only be available in orbit, but you can configure using the primary body. For aligning with the telescope, have the face plate facing up and the cables facing in the same direction as for the telescope and the output values will be aligned.

- **Key:** ThingStructureRocketCelestialTracker
- **Prefab Name:** StructureRocketCelestialTracker
- **Prefab Hash:** 997453927
- **Base Power Draw:** 10 W
- **Memory Size:** 96 B
- **Memory Access:** Read
- **Has Memory:** true
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Logic Types:**
  - Text=CelestialTracking.BodyOrientation OP_CODE: 1, Index=1, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | CELESTIAL_INDEX | BYTE_8 | | 16-31 | HORIZONTAL_DECI_DEGREES | SHORT_16 | | 32-47 | VERTICAL_DECI_DEGREES | SHORT_16 | | 48-63 | UNUSED | 16 |
**Build States:**
  - Description=1 x Kit (Rocket Celestial Tracker)
  - Description=Screwdriver 2 x Electronic Parts
  - Description=Welding Torch 4 x Steel Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Rocket Celestial Tracker), PrefabHash=-303008602, PageLink=ThingItemKitRocketCelestialTracker

---

## Rocket Circuit Housing

- **Key:** ThingStructureRocketCircuitHousing
- **Prefab Name:** StructureRocketCircuitHousing
- **Prefab Hash:** 150135861
- **Base Power Draw:** 5 W
- **Memory Size:** 0 B
- **Memory Access:** Read Write
- **Has Memory:** true
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
- **Placeable In Rocket:** True
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0
  - LogicName=OccupantHash, LogicAccessTypes=0
  - LogicName=Quantity, LogicAccessTypes=0
  - LogicName=Damage, LogicAccessTypes=0
  - LogicName=Class, LogicAccessTypes=0
  - LogicName=MaxQuantity, LogicAccessTypes=0
  - LogicName=PrefabHash, LogicAccessTypes=0
  - LogicName=LineNumber, LogicAccessTypes=0
  - LogicName=SortingClass, LogicAccessTypes=0
  - LogicName=ReferenceId, LogicAccessTypes=0
  - LogicName=FreeSlots, LogicAccessTypes=0
  - LogicName=TotalSlots, LogicAccessTypes=0
**Logic Bindings:**
  - Header=db, Label=HOUSING
  - Header=d0, Label=SCREW_0
  - Header=d1, Label=SCREW_1
  - Header=d2, Label=SCREW_2
  - Header=d3, Label=SCREW_3
  - Header=d4, Label=SCREW_4
  - Header=d5, Label=SCREW_5
**Slots:**
  - SlotName=Programmable Chip, SlotType=Programmable Chip, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Rocket Circuit Housing)
**Mode Options:**
  - LogicName=Number, LogicAccessTypes=0
  - LogicName=String, LogicAccessTypes=1
**Connections:**
  - LogicName=Power and Data Input, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Rocket Circuit Housing), PrefabHash=721251202, PageLink=ThingItemKitRocketCircuitHousing

---

## Rocket Control Motherboard

- **Key:** ThingMotherboardRockets
- **Prefab Name:** MotherboardRockets
- **Prefab Hash:** -806986392
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 500 x Energy + 5 x Electrum (from Ingot (Electrum)) + 5 x Solder (from Ingot (Solder))


---

## Rocket Engine (Tiny)

- **Key:** ThingStructureRocketEngineTiny
- **Prefab Name:** StructureRocketEngineTiny
- **Prefab Hash:** 178472613
- **Base Power Draw:** 5 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - StationBuildCostInsert
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1

---

## Rocket Gas Collector

When fitted on a Rocket, this device will allow the collection of gaseous atmospheres from various planetoids.

- **Key:** ThingStructureRocketGasCollector
- **Prefab Name:** StructureRocketGasCollector
- **Prefab Hash:** -1720125735
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 20kg
**Build States:**
  - Description=1 x Kit (Rocket Atmospherics)
  - Description=1 x Kit (Passive Vent) Wrench
**Connections:**
  - LogicName=Pipe Output, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Rocket Atmospherics), PrefabHash=925932637, PageLink=ThingItemKitRocketAtmospherics

---

## Rocket Gas Filtration

Allows for basic gas filtration onboard a Rocket.

- **Key:** ThingStructureRocketFiltrationGas
- **Prefab Name:** StructureRocketFiltrationGas
- **Prefab Hash:** -1061194321
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 20kg
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0
  - LogicName=OccupantHash, LogicAccessTypes=0
  - LogicName=Quantity, LogicAccessTypes=0
  - LogicName=Damage, LogicAccessTypes=0
  - LogicName=Class, LogicAccessTypes=0
  - LogicName=MaxQuantity, LogicAccessTypes=0
  - LogicName=PrefabHash, LogicAccessTypes=0
  - LogicName=SortingClass, LogicAccessTypes=0
  - LogicName=FilterType, LogicAccessTypes=0
  - LogicName=ReferenceId, LogicAccessTypes=0
  - LogicName=FreeSlots, LogicAccessTypes=0
  - LogicName=TotalSlots, LogicAccessTypes=0
**Logic Bindings:**
  - Header=db, Label=DEVICE
  - Header=d0, Label=SCREW_0
  - Header=d1, Label=SCREW_1
**Slots:**
  - SlotName=Gas Filter, SlotType=Gas Filter, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Rocket Atmospherics)
  - Description=Wrench 4 x Kit (Pipe)
**Mode Options:**
  - LogicName=Idle, LogicAccessTypes=0
  - LogicName=Active, LogicAccessTypes=1
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Output, LogicAccessTypes=1
  - LogicName=Pipe Waste, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Rocket Atmospherics), PrefabHash=925932637, PageLink=ThingItemKitRocketAtmospherics

---

## Rocket Manufactory

- **Key:** ThingStructureRocketManufactory
- **Prefab Name:** StructureRocketManufactory
- **Prefab Hash:** 1781051034
- **Base Power Draw:** 100 W
- **Memory Size:** 512 B
- **Memory Access:** Read Write
- **Has Memory:** true
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Types:**
  - Text=PrinterInstruction.StackPointer OP_CODE: 1, Index=1, Info=| VALID ONLY AT ADDRESS 63 | | 0-7 | OP_CODE | BYTE_8 | | 8-23 | INDEX | USHORT_16 | | 24-63 | UNUSED | 40 |
  - Text=PrinterInstruction.ExecuteRecipe OP_CODE: 2, Index=2, Info=| VALID ONLY AT ADDRESSES 0 TO 53 | | 0-7 | OP_CODE | BYTE_8 | | 8-15 | QUANTITY | BYTE_8 | | 16-47 | PREFAB_HASH | INT_32 | | 48-63 | UNUSED | 16 |
  - Text=PrinterInstruction.WaitUntilNextValid OP_CODE: 3, Index=3, Info=| VALID ONLY AT ADDRESSES 0 TO 53 | | 0-7 | OP_CODE | BYTE_8 | | 8-63 | UNUSED | 56 |
  - Text=PrinterInstruction.JumpIfNextInvalid OP_CODE: 4, Index=4, Info=| VALID ONLY AT ADDRESSES 0 TO 53 | | 0-7 | OP_CODE | BYTE_8 | | 8-23 | STACK_ADDRESS | USHORT_16 | | 24-63 | UNUSED | 40 |
  - Text=PrinterInstruction.JumpToAddress OP_CODE: 5, Index=5, Info=| VALID ONLY AT ADDRESSES 0 TO 53 | | 0-7 | OP_CODE | BYTE_8 | | 8-23 | STACK_ADDRESS | USHORT_16 | | 24-63 | UNUSED | 40 |
  - Text=PrinterInstruction.DeviceSetLock OP_CODE: 6, Index=6, Info=| VALID ONLY AT ADDRESSES 0 TO 53 | | 0-7 | OP_CODE | BYTE_8 | | 8-15 | LOCK_STATE | BOOL_8 | | 16-63 | UNUSED | 48 |
  - Text=PrinterInstruction.EjectReagent OP_CODE: 7, Index=7, Info=| VALID ONLY AT ADDRESSES 0 TO 53 | | 0-7 | OP_CODE | BYTE_8 | | 8-39 | REAGENT_HASH | INT_32 | | 40-63 | UNUSED | 24 |
  - Text=PrinterInstruction.EjectAllReagents OP_CODE: 8, Index=8, Info=| VALID ONLY AT ADDRESSES 0 TO 53 | | 0-7 | OP_CODE | BYTE_8 | | 8-63 | UNUSED | 56 |
  - Text=PrinterInstruction.MissingRecipeReagent OP_CODE: 9, Index=9, Info=| VALID ONLY AT ADDRESSES 54 TO 62 | | 0-7 | OP_CODE | BYTE_8 | | 8-15 | QUANTITY_CEIL | BYTE_8 | | 16-47 | REAGENT_HASH | UINT_32 | | 48-63 | UNUSED | 16 | | HASH REPORTED UNSIGNED - MUST BE MANUALLY SIGNED |
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
  - Description=1 x Kit (Rocket Manufactory)
  - Description=Welding Torch 2 x Steel Sheets
  - Description=4 x Cable Coil
  - Description=Welding Torch 2 x Plastic Sheets
  - Details=Manufactures at Tier One , Description=Screwdriver
**Resources Used:**
  - NameOfThing=Ingots, PrefabHash=0, PageLink=IngotPage
**Connections:**
  - LogicName=Chute Input, LogicAccessTypes=0
  - LogicName=Chute Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Rocket Manufactory), PrefabHash=-636127860, PageLink=ThingItemKitRocketManufactory

---

## Rocket Miner

Gathers available resources at the rocket's current space location. Mining also generates a small trickle of survey points at the location.

- **Key:** ThingStructureRocketMiner
- **Prefab Name:** StructureRocketMiner
- **Prefab Hash:** -2087223687
- **Base Power Draw:** 100 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
- **Placeable In Rocket:** True
- **Rocket Mass:** 500kg
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
  - SlotName=Export, SlotType=Export, SlotIndex=0
  - SlotName=Drill Head Slot, SlotType=Drill Head Slot, SlotIndex=1
**Build States:**
  - Description=1 x Kit (Rocket Miner)
  - Description=2 x Electronic Parts
**Connections:**
  - LogicName=Chute Output, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Rocket Miner), PrefabHash=-867969909, PageLink=ThingItemKitRocketMiner

---

## Rocket Scanner

- **Key:** ThingStructureRocketScanner
- **Prefab Name:** StructureRocketScanner
- **Prefab Hash:** 2014252591
- **Base Power Draw:** 200 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
- **Placeable In Rocket:** True
- **Rocket Mass:** 50kg
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
  - SlotName=Scanner Head Slot, SlotType=Scanner Head Slot, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Rocket Scanner)
  - Description=Welding Torch 1 x Steel Sheets
**Connections:**
  - LogicName=Power and Data Output, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Rocket Scanner), PrefabHash=1753647154, PageLink=ThingItemKitRocketScanner

---

## Rocket Scanner Head

- **Key:** ThingItemRocketScanningHead
- **Prefab Name:** ItemRocketScanningHead
- **Prefab Hash:** -1198702771
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** Yes
**Build Recipe:**
  - Printer: Rocket Manufactory (Tier One)
    - 60000 x Energy + 2 x Gold (from Ingot (Gold)) + 3 x Copper (from Ingot (Copper))


---

## Rocket Surface Scanner Head

When placed in a Rocket Scanner, the Surface Scanner Head will scan the map for deep mining regions.

- **Key:** ThingItemRocketDeepScanningHead
- **Prefab Name:** ItemRocketDeepScanningHead
- **Prefab Hash:** 532208167
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** Yes
**Build Recipe:**
  - Printer: Rocket Manufactory (Tier One)
    - 60000 x Energy + 2 x Gold (from Ingot (Gold)) + 3 x Copper (from Ingot (Copper))


---

## Rockets

Rocket parts are printed on the Rocket Manufactory. Fuselage (Type A1) must be built upon a Launch Mount. A Pumped Gas Engine must be placed in an Engine Mount (Type A1). Resource Umbilicals are placed on the Launch Tower and connect between Umbilical (Gas) and Umbilical Socket (Gas) placed inside the rocket. A Computer (Modern) with the Rocket Control Motherboard provides a user interface to control the rocket. A Pair of datalinks are used to create a planet-side Logic Uplink and a rocket-side Logic Rocket Downlink which must be hooked up to the Computer (Modern). An Rocket Avionics should be placed in the rocket to act as the main rocket controller. On the Rocket Control Motherboard Map Screen you can set the rocket destination. Igniting the rocket without a destination set allows you to see rocket performance and fuel usage without launching the rocket. Expect to use 5-20Kmol of fuel per rocket trip, depending on rocket size. A Rocket Scanner is used to chart unknown locations and discover minable asteroids. More complex rockets may use Rocket Miner and Cargo Storage (Small).

- **Key:** AutomatedRocketPage

---

## Rover MkI

A distant cousin of the jeep, the Mk I {Sinotai electric rover is one of the most simple and durable light vehicles in the known universe. Able to carry two passengers and cargo such as the Portable Gas Tank (Air) or , it is powered by up to three batteries, accepting everything including Battery Cell (Nuclear). A quad-array of hub-mounted electric engines propels the reinforced aluminium frame over most terrain and modest obstacles. While the Mk I is designed for stability in low-horizontality circumstances, if it rolls, try using your Crowbar to put it right way up.Connects to Logic Transmitter

- **Key:** ThingRover_MkI
- **Prefab Name:** Rover_MkI
- **Prefab Hash:** -2049946335
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
  - LogicName=Damage, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
  - LogicName=Charge, LogicAccessTypes=2, 3, 4
  - LogicName=ChargeRatio, LogicAccessTypes=2, 3, 4
  - LogicName=Class, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
**Slots:**
  - SlotName=Entity, SlotType=Entity, SlotIndex=0
  - SlotName=Entity, SlotType=Entity, SlotIndex=1
  - SlotName=Battery, SlotType=Battery, SlotIndex=2
  - SlotName=Battery, SlotType=Battery, SlotIndex=3
  - SlotName=Battery, SlotType=Battery, SlotIndex=4
  - SlotName=, SlotType=, SlotIndex=5
  - SlotName=, SlotType=, SlotIndex=6
  - SlotName=, SlotType=, SlotIndex=7
  - SlotName=, SlotType=, SlotIndex=8
  - SlotName=, SlotType=, SlotIndex=9
  - SlotName=, SlotType=, SlotIndex=10

---

## Rover MKI

- **Key:** ThingRover_MkI_build_states
- **Prefab Name:** Rover_MkI_build_states
- **Prefab Hash:** 861674123
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Rover Mk I)
  - Description=Wrench 5 x Plastic Sheets
  - Description=Welding Torch 5 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Rover Mk I), PrefabHash=197243872, PageLink=ThingItemKitRoverMKI

---

## Rubber Duck

A rubber duck.

- **Key:** ThingRubberDuck
- **Prefab Name:** RubberDuck
- **Prefab Hash:** 1668254384
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Silicon (from Ingot (Silicon))


---

## Rubbish

- **Key:** RubbishPage

---

## Safety Glasses

A pair of safety glasses.

- **Key:** ThingSafetyGlasses
- **Prefab Name:** SafetyGlasses
- **Prefab Hash:** 1028590147
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 5 x Iron (from Ingot (Iron)) + 15 x Silicon (from Ingot (Silicon))


---

## Salicylic Acid

- **Key:** ReagentSalicylic Acid

---

## Salt

A solid chunk of Liquid Sodium Chloride. It has a very high melt temperature and can only be melted either in a hot furnace or a hot melting room. It cannot be processed by the Ice Crusher or Arc Furnace.

- **Key:** ThingItemPureIceLiquidSodiumChloride
- **Prefab Name:** ItemPureIceLiquidSodiumChloride
- **Prefab Hash:** 1294338082
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
- **Freeze Temperature:** 606 K (333 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Sanitation

Over time satisfying thirst and hunger of Stationeers will cause them to need to relieve themselves. The ODA recommends that Stationeers set up a Modern Toilet within their base after landing, requiring an atmosphere and Water to operate. This will output Polluted Water which can be recycled using a Water Purifier and then used for other purposes, such as farming or drinking. The Waste Bag can be used as a portable alternative to the toilet but the contents are not recoverable.

- **Key:** SanitationPage

---

## Santa Hat

A Santa Hat.

- **Key:** ThingSantaHat
- **Prefab Name:** SantaHat
- **Prefab Hash:** 2071717861
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 10 x Energy + 30 x Silicon (from Ingot (Silicon))


---

## Screwdriver

This standard issue frictional adherence adjustor is a top of the line, bi-rotational model with a columnated uni-grip. It's definitely not just a screwdriver. Use it for construction and deconstruction of certain kits, and setting values on logic units.

- **Key:** ThingItemScrewdriver
- **Prefab Name:** ItemScrewdriver
- **Prefab Hash:** 687940869
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Auto Ignition:** 523 K (250oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 2 x Iron (from Ingot (Iron))


---

## SDB Hopper

- **Key:** ThingStructureSDBHopper
- **Prefab Name:** StructureSDBHopper
- **Prefab Hash:** -1875856925
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
  - Description=1 x Kit (SDB Hopper)
  - Description=Welding Torch 4 x Iron Sheets
**Connections:**
  - LogicName=Chute Input, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (SDB Hopper), PrefabHash=323957548, PageLink=ThingItemKitSDBHopper

---

## SDB Hopper Advanced

- **Key:** ThingStructureSDBHopperAdvanced
- **Prefab Name:** StructureSDBHopperAdvanced
- **Prefab Hash:** 467225612
- **Base Power Draw:** 5 W
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
  - Description=1 x Kit (SDB Hopper)
  - Description=Welding Torch 4 x Iron Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
  - LogicName=Chute Input, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (SDB Hopper), PrefabHash=323957548, PageLink=ThingItemKitSDBHopper

---

## SDB Silo

The majestic silo holds large quantities of almost anything. While it is doing that, it cannot be deconstructed. Note also, that any food you put into a silo is likely to decay extremely rapidly. The silo can hold up to 600 stacks.

- **Key:** ThingStructureSDBSilo
- **Prefab Name:** StructureSDBSilo
- **Prefab Hash:** 1155865682
- **Base Power Draw:** 1 W
- **Memory Size:** 4800 KB
- **Memory Access:** Read
- **Has Memory:** true
- **Paintable:** Yes
**Logic Types:**
  - Text=SiloInstruction.SlotContents OP_CODE: 1, Index=1, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-20 | QUANTITY | UINT13_13 | | 21-52 | PREFAB_HASH | UINT_32 | | 53-63 | UNUSED | 11 | | HASH REPORTED UNSIGNED - MUST BE MANUALLY SIGNED |
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
  - Description=1 x Kit (SDB Silo)
  - Description=Welding Torch 15 x Steel Sheets
  - Description=Welding Torch 10 x Plastic Sheets
  - Description=Screwdriver 5 x Cable Coil
**Mode Options:**
  - LogicName=Mode0, LogicAccessTypes=0
  - LogicName=Mode1, LogicAccessTypes=1
**Connections:**
  - LogicName=Chute Input, LogicAccessTypes=0
  - LogicName=Chute Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (SDB Silo), PrefabHash=1932952652, PageLink=ThingKitSDBSilo

---

## Search

- **Key:** Search

---

## Security Camera

Security cameras can be paired with a Motion Sensor, then connected to a Console fitted with a Camera Display for that 'always watched' feeling.

- **Key:** ThingItemSecurityCamera
- **Prefab Name:** ItemSecurityCamera
- **Prefab Hash:** -1981101032
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 5
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Constructed From Kits:**
  - NameOfThing=Camera, PrefabHash=-342072665, PageLink=ThingStructureCamera

---


# Corn - Fertilizer

## Corn

A long growth time staple crop. Its low requirement for darkness allows for accelerated growing if provided with extra light.

- **Key:** ThingItemCorn
- **Prefab Name:** ItemCorn
- **Prefab Hash:** 258339687
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 10
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Growth Time:** 2h 0min 1s
- **Stack Size:** 20
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Constructed From Kits:**
  - NameOfThing=Corn Seeds, PrefabHash=-1290755415, PageLink=ThingSeedBag_Corn
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=40 mol
  - NameOfThing=Polluted Water, QuantityOfThing=2 mol
**Used In:**
  - NameOfThing=Microwave, PrefabHash=-1136173965, PageLink=ThingApplianceMicrowave
  - NameOfThing=Automated Oven, PrefabHash=-1672404896, PageLink=ThingStructureAutomatedOven
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Corn Seeds

Grow a Corn.

- **Key:** ThingSeedBag_Corn
- **Prefab Name:** SeedBag_Corn
- **Prefab Hash:** -1290755415
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

## Corn Soup

Made using Cooked Corn and an Empty Can in a Basic Packaging Machine or Advanced Packaging Machine. Fairly high in nutrition, canned food does not decay.

- **Key:** ThingItemCornSoup
- **Prefab Name:** ItemCornSoup
- **Prefab Hash:** 545034114
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 150
- **Nutrition Quality:** Good (+25% hydration capacity)
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Advanced Packaging Machine (Tier One)
    - 1 x Steel (from Empty Can) + 1 x Oil (from Soy Oil) + 5 x Corn (from Cooked Corn)
  - Printer: Basic Packaging Machine (Tier One)
    - 1 x Steel (from Empty Can) + 1 x Oil (from Soy Oil) + 5 x Corn (from Cooked Corn)


---

## Corner Locker

- **Key:** ThingStructureCornerLocker
- **Prefab Name:** StructureCornerLocker
- **Prefab Hash:** -1968255729
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2, 3, 4, 5
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2, 3, 4, 5
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2, 3, 4, 5
  - LogicName=Damage, LogicAccessTypes=0, 1, 2, 3, 4, 5
  - LogicName=Class, LogicAccessTypes=0, 1, 2, 3, 4, 5
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2, 3, 4, 5
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2, 3, 4, 5
  - LogicName=SortingClass, LogicAccessTypes=0, 1, 2, 3, 4, 5
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2, 3, 4, 5
  - LogicName=FreeSlots, LogicAccessTypes=0, 1, 2, 3, 4, 5
  - LogicName=TotalSlots, LogicAccessTypes=0, 1, 2, 3, 4, 5
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=None, SlotType=None, SlotIndex=2
  - SlotName=None, SlotType=None, SlotIndex=3
  - SlotName=None, SlotType=None, SlotIndex=4
  - SlotName=None, SlotType=None, SlotIndex=5
**Build States:**
  - Description=1 x Kit (Locker)
**Constructed Things:**
  - NameOfThing=Kit (Locker), PrefabHash=882301399, PageLink=ThingItemKitLocker

---

## CounterFlow Heat Exchanger - Gas + Gas

Exchange heat from one pipe network to another. By drawing down the pressure of the outputs with a pump or regulator and regulating input pressures, the temperatures of two counterflowing networks can be effectively exchanged. Balancing the throughput of both inputs is key to creating a good exhange of temperatures.

- **Key:** ThingStructurePassthroughHeatExchangerGasToGas
- **Prefab Name:** StructurePassthroughHeatExchangerGasToGas
- **Prefab Hash:** -1674187440
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (CounterFlow Heat Exchanger)
  - Description=Welding Torch 1 x Steel Sheets
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Input 2, LogicAccessTypes=1
  - LogicName=Pipe Output, LogicAccessTypes=2
  - LogicName=Pipe Output 2, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (CounterFlow Heat Exchanger), PrefabHash=636112787, PageLink=ThingItemKitPassthroughHeatExchanger

---

## CounterFlow Heat Exchanger - Gas + Liquid

Exchange heat from one pipe network to another. By drawing down the pressure of the outputs with a pump or regulator and regulating input pressures, the temperatures of two counterflowing networks can be effectively exchanged. Balancing the throughput of both inputs is key to creating a good exhange of temperatures.

- **Key:** ThingStructurePassthroughHeatExchangerGasToLiquid
- **Prefab Name:** StructurePassthroughHeatExchangerGasToLiquid
- **Prefab Hash:** 1928991265
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (CounterFlow Heat Exchanger)
  - Description=Welding Torch 1 x Steel Sheets
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Input 2, LogicAccessTypes=1
  - LogicName=Pipe Output, LogicAccessTypes=2
  - LogicName=Pipe Liquid Output 2, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (CounterFlow Heat Exchanger), PrefabHash=636112787, PageLink=ThingItemKitPassthroughHeatExchanger

---

## CounterFlow Heat Exchanger - Liquid + Liquid

Exchange heat from one pipe network to another. By drawing down the pressure of the outputs with a pump or regulator and regulating input pressures, the temperatures of two counterflowing networks can be effectively exchanged. Balancing the throughput of both inputs is key to creating a good exchange of temperatures.

- **Key:** ThingStructurePassthroughHeatExchangerLiquidToLiquid
- **Prefab Name:** StructurePassthroughHeatExchangerLiquidToLiquid
- **Prefab Hash:** -1472829583
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (CounterFlow Heat Exchanger)
  - Description=Welding Torch 1 x Steel Sheets
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Input 2, LogicAccessTypes=1
  - LogicName=Pipe Liquid Output, LogicAccessTypes=2
  - LogicName=Pipe Liquid Output 2, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (CounterFlow Heat Exchanger), PrefabHash=636112787, PageLink=ThingItemKitPassthroughHeatExchanger

---

## Crate Mk II

A more heavily reinforced version of the iconic Dynamic Crate, the Crate Mk II is resistant to incredibly high pressures and temperatures. Short of disposing of it in a black hole, the Mk II is about as safe as luggage gets.

- **Key:** ThingCrateMkII
- **Prefab Name:** CrateMkII
- **Prefab Hash:** 8709219
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 0 K (-273oC)
- **Auto Ignition:** 0 K (-273oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=None, SlotType=None, SlotIndex=2
  - SlotName=None, SlotType=None, SlotIndex=3
  - SlotName=None, SlotType=None, SlotIndex=4
  - SlotName=None, SlotType=None, SlotIndex=5
  - SlotName=None, SlotType=None, SlotIndex=6
  - SlotName=None, SlotType=None, SlotIndex=7
  - SlotName=None, SlotType=None, SlotIndex=8
  - SlotName=None, SlotType=None, SlotIndex=9
**Constructed Things:**
  - NameOfThing=Kit (Crate Mk II), PrefabHash=-1585956426, PageLink=ThingItemKitCrateMkII

---

## CreatedGasesTemplate

{0}

- **Key:** CreatedGasesTemplate

---

## CreatedHeaderTemplate

{0}

- **Key:** CreatedHeaderTemplate

---

## CreatedReagentTemplate

{0}

- **Key:** CreatedReagentTemplate

---

## CreatorsHeaderTemplate

{0}

- **Key:** CreatorsHeaderTemplate

---

## CreatorTemplate

{0}{1}

- **Key:** CreatorTemplate

---

## Credit Card

- **Key:** ThingItemCreditCard
- **Prefab Name:** ItemCreditCard
- **Prefab Hash:** -1756772618
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100000
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 200 x Energy + 2 x Copper (from Ingot (Copper)) + 5 x Silicon (from Ingot (Silicon))


---

## Crew Light

- **Key:** ThingStructureCrewModuleLight
- **Prefab Name:** StructureCrewModuleLight
- **Prefab Hash:** 950595166
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Crew Electronics)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Crew Electronics), PrefabHash=1332869314, PageLink=ThingItemKitCrewModuleElectronics

---

## Crew Module Active Vent

- **Key:** ThingStructureCrewModuleActiveVent
- **Prefab Name:** StructureCrewModuleActiveVent
- **Prefab Hash:** -1817129150
- **Base Power Draw:** 100 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Active Vent)
**Mode Options:**
  - LogicName=Outward, LogicAccessTypes=0
  - LogicName=Inward, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Active Vent), PrefabHash=-842048328, PageLink=ThingItemActiveVent

---

## Crew Module Cable Connector A

- **Key:** ThingStructureCrewModuleCableConnectorA
- **Prefab Name:** StructureCrewModuleCableConnectorA
- **Prefab Hash:** -1760040957
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 413 K (140oC)
- **Auto Ignition:** 523 K (250oC)
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Crew Module Screen)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
  - LogicName=Connection, LogicAccessTypes=4
  - LogicName=Connection, LogicAccessTypes=5
  - LogicName=Connection, LogicAccessTypes=6
  - LogicName=Connection, LogicAccessTypes=7
  - LogicName=Connection, LogicAccessTypes=8
  - LogicName=Connection, LogicAccessTypes=9
  - LogicName=Connection, LogicAccessTypes=10
**Constructed Things:**
  - NameOfThing=Kit (Crew Module Cable Connector), PrefabHash=-227570471, PageLink=ThingItemKitCrewModuleCableConnector

---

## Crew Module Cable Connector B

- **Key:** ThingStructureCrewModuleCableConnectorB
- **Prefab Name:** StructureCrewModuleCableConnectorB
- **Prefab Hash:** 236894649
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 413 K (140oC)
- **Auto Ignition:** 523 K (250oC)
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Crew Module Screen)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
  - LogicName=Connection, LogicAccessTypes=4
  - LogicName=Connection, LogicAccessTypes=5
  - LogicName=Connection, LogicAccessTypes=6
  - LogicName=Connection, LogicAccessTypes=7
  - LogicName=Connection, LogicAccessTypes=8
  - LogicName=Connection, LogicAccessTypes=9
  - LogicName=Connection, LogicAccessTypes=10
  - LogicName=Connection, LogicAccessTypes=11
  - LogicName=Connection, LogicAccessTypes=12
**Constructed Things:**
  - NameOfThing=Kit (Crew Module Cable Connector), PrefabHash=-227570471, PageLink=ThingItemKitCrewModuleCableConnector

---

## Crew Module Chair

Seat for crewing a rocket. While the seat is occupied the rocket can only travel between launch mounts, and the seat can only be exited while the rocket is landed on one.

- **Key:** ThingStructureCrewModuleChair
- **Prefab Name:** StructureCrewModuleChair
- **Prefab Hash:** -156109268
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
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
  - LogicName=SortingClass, LogicAccessTypes=0
  - LogicName=ReferenceId, LogicAccessTypes=0
  - LogicName=FreeSlots, LogicAccessTypes=0
  - LogicName=TotalSlots, LogicAccessTypes=0
**Slots:**
  - SlotName=Seat, SlotType=Seat, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Crew Module Chair)
**Constructed Things:**
  - NameOfThing=Kit (Crew Module Chair), PrefabHash=218541228, PageLink=ThingItemKitCrewModuleChair

---

## Crew Module Fuselage (Type A)

Compact crew compartment for rockets. Board by interacting with the module.

- **Key:** ThingStructureCrewModuleFuselageSimple
- **Prefab Name:** StructureCrewModuleFuselageSimple
- **Prefab Hash:** 1702557794
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 1200kg
**Build States:**
  - Description=1 x Kit (Crew Parts)
  - Description=Welding Torch 10 x Steel Sheets
  - Description=Welding Torch 10 x Plastic Sheets
  - Description=Screwdriver
  - Description=Screwdriver
**Constructed Things:**
  - NameOfThing=Kit (Crew Parts), PrefabHash=-275431032, PageLink=ThingItemKitCrewParts

---

## Crew Module Fuselage (Type C)

Streamlined crew compartment for rockets. Board by interacting with the module.

- **Key:** ThingStructureCrewModuleFuselage
- **Prefab Name:** StructureCrewModuleFuselage
- **Prefab Hash:** 455538614
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 1200kg
**Build States:**
  - Description=1 x Kit (Crew Parts)
  - Description=Welding Torch 10 x Steel Sheets
  - Description=Welding Torch 10 x Plastic Sheets
  - Description=Screwdriver
  - Description=Screwdriver
**Constructed Things:**
  - NameOfThing=Kit (Crew Parts), PrefabHash=-275431032, PageLink=ThingItemKitCrewParts

---

## Crew Module Passive Vent

- **Key:** ThingStructureCrewModulePassiveVent
- **Prefab Name:** StructureCrewModulePassiveVent
- **Prefab Hash:** 1393516022
- **Volume:** 100L
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Passive Vent)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Passive Vent), PrefabHash=238631271, PageLink=ThingItemPassiveVent

---

## Crew Module Screen

- **Key:** ThingStructureCrewModuleScreen
- **Prefab Name:** StructureCrewModuleScreen
- **Prefab Hash:** 1880475854
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Crew Module Screen)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Crew Module Screen), PrefabHash=-1655243596, PageLink=ThingItemKitCrewModuleScreen

---

## Crowbar

Recurso's entry-level crowbar is useful in a variety of everyday Stationeer settings, from opening Area Power Controls and unpowered Airlocks, to splatting pan-dimensional headcrabs, should the need arise.

- **Key:** ThingItemCrowbar
- **Prefab Name:** ItemCrowbar
- **Prefab Hash:** 856108234
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Auto Ignition:** 523 K (250oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 5 x Iron (from Ingot (Iron))


---

## Cryo Tube Horizontal

The exact operation of the Longsleep cryotube remains a commercial secret, with Norsec merely licensing the design. A pipe connection is provided to maintain suitable internal atmosphere connected to the occupant via breathing tubes. When the liquid pipe connection is supplied super cooled Liquid Nitrogen occupants will regenerate organs and even revive if deceased. Nothing can be worn when entering the device.

- **Key:** ThingStructureCryoTubeHorizontal
- **Prefab Name:** StructureCryoTubeHorizontal
- **Prefab Hash:** 1443059329
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Slots:**
  - SlotName=Player, SlotType=Player, SlotIndex=0
  - SlotName=Mask, SlotType=Mask, SlotIndex=1
**Build States:**
  - Description=1 x Kit (Cryo Tube)
  - Description=Welding Torch 2 x Plastic Sheets
  - Description=Screwdriver 1 x Glass Sheets
**Mode Options:**
  - LogicName=Standby, LogicAccessTypes=0
  - LogicName=Error, LogicAccessTypes=1
  - LogicName=Inactive, LogicAccessTypes=2
  - LogicName=Occupied, LogicAccessTypes=3
  - LogicName=Dead, LogicAccessTypes=4
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Pipe Input, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Pipe Liquid Input 2, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Cryo Tube), PrefabHash=-545234195, PageLink=ThingItemKitCryoTube

---

## Cryo Tube Vertical

The exact operation of the Longsleep cryotube remains a commercial secret, with Norsec merely licensing the design. A pipe connection is provided to maintain suitable internal atmosphere connected to the occupant via breathing tubes. When the liquid pipe connection is supplied super cooled Liquid Nitrogen occupants will regenerate organs and even revive if deceased. Nothing can be worn when entering the device.

- **Key:** ThingStructureCryoTubeVertical
- **Prefab Name:** StructureCryoTubeVertical
- **Prefab Hash:** -1381321828
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Slots:**
  - SlotName=Player, SlotType=Player, SlotIndex=0
  - SlotName=Mask, SlotType=Mask, SlotIndex=1
**Build States:**
  - Description=1 x Kit (Cryo Tube)
  - Description=Welding Torch 2 x Plastic Sheets
  - Description=Screwdriver 1 x Glass Sheets
**Mode Options:**
  - LogicName=Standby, LogicAccessTypes=0
  - LogicName=Error, LogicAccessTypes=1
  - LogicName=Inactive, LogicAccessTypes=2
  - LogicName=Occupied, LogicAccessTypes=3
  - LogicName=Dead, LogicAccessTypes=4
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Pipe Input, LogicAccessTypes=1
  - LogicName=Pipe Liquid Input 2, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Cryo Tube), PrefabHash=-545234195, PageLink=ThingItemKitCryoTube

---

## Cryogenic Suit Upgrade

Enables suits with basic cooling functionality to work with cryogenic liquid.

- **Key:** ThingItemSuitModCryogenicUpgrade
- **Prefab Name:** ItemSuitModCryogenicUpgrade
- **Prefab Hash:** -1274308304
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes

---

## Darga Fern

A fern adapted by Agrizeroto process a much greater volume of Carbon Dioxide into Oxygen than an average plant.

- **Key:** ThingItemFilterFern
- **Prefab Name:** ItemFilterFern
- **Prefab Hash:** 266654416
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 0
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Growth Time:** 1h 0min 1s
- **Stack Size:** 10
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Constructed From Kits:**
  - NameOfThing=Darga Fern Seeds, PrefabHash=980397232, PageLink=ThingSeedBag_DargaFern
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=2 mol
  - NameOfThing=Polluted Water, QuantityOfThing=0.1 mol
**Used In:**
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Darga Fern Seeds

- **Key:** ThingSeedBag_DargaFern
- **Prefab Name:** SeedBag_DargaFern
- **Prefab Hash:** 980397232
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

## Darkness per day

The length of time a plant needs to be in darkness each day-cycle to thrive. The standard length day-cycle is 20 minutes.

- **Key:** GeneDarkPerDay

---

## Darkness tolerance

The length of time a plant can stay in darkness before it starts taking damage.

- **Key:** GeneDarknessTolerance

---

## Data Disk

- **Key:** ThingItemDataDisk
- **Prefab Name:** ItemDataDisk
- **Prefab Hash:** 1005843700
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 100 x Energy + 5 x Gold (from Ingot (Gold)) + 5 x Copper (from Ingot (Copper))


---

## Daylight Sensor

Daylight sensors provide data on whether the current region of your base is in sunlight, and report the exact solar angle. Note that the orientation of the sensor alters the reported solar angle, while Logic systems can be used to offset it.

- **Key:** ThingStructureDaylightSensor
- **Prefab Name:** StructureDaylightSensor
- **Prefab Hash:** 1076425094
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Sensors)
**Mode Options:**
  - LogicName=Default, LogicAccessTypes=0
  - LogicName=Horizontal, LogicAccessTypes=1
  - LogicName=Vertical, LogicAccessTypes=2
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Sensors), PrefabHash=-1776897113, PageLink=ThingItemKitSensor

---

## Decayed Food

When your food decays, it turns into this. ODA scientists have attempted to determine the exact constituents of this substance, but it remains evasive and mysterious. Suffice to say, eating it is a bad idea. Research has determined, however, that The exact speed of decay varies individually by: - TEMPERATURE - Refrigeration will slow decay, but many foods will be damaged by exposure to extreme low pressure, as well as extreme heat. The optimum temperature is 0 kelvin (-272 C). - FOOD TYPE - Each food type has its own decay properties. Tomato Soup lasts a lot longer than a Tomato, for instance. - PRESSURE - Food decays faster when the pressure drops below 1 atmosphere (101kPa). Decay happens exponentially more quickly as the atmosphere approaches a perfect vacuum. There is no effect from higher pressures. - ATMOSPHERE - Different gases can slow and accelerate the decay process. The process will take account of respective gas ratios in mixed atmospheres in calculating the decay modifier. The following rates apply across all foods: > Oxygen x 1.3 > Nitrogen x 0.6 > Carbon Dioxide x 0.8 > Methane x 1 > Pollutant x 3 > Nitrous Oxide x 1.5 > Steam x 2 > Vacuum (see PRESSURE above)

- **Key:** ThingDecayedFood
- **Prefab Name:** DecayedFood
- **Prefab Hash:** 1531087544
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 25
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=1 mol
  - NameOfThing=Polluted Water, QuantityOfThing=0.05 mol
**Used In:**
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Deep Miner

Drills through terrain until it hits bedrock. Once inside bedrock Dirty Ore is produced roughly every 90s. The type of ore mined will vary by location, you can read the make-up of ore mined at any position using the Cartridge (Deep Miner)

- **Key:** ThingStructureDeepMiner
- **Prefab Name:** StructureDeepMiner
- **Prefab Hash:** 265720906
- **Base Power Draw:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Bindings:**
  - Header=db, Label=DEVICE
  - Header=d0, Label=SCREW_0
  - Header=d1, Label=SCREW_1
**Slots:**
  - SlotName=Export, SlotType=Export, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Deep Miner)
  - Description=Welding Torch 12 x Steel Sheets
  - Description=Screwdriver 5 x Cable Coil
  - Description=Screwdriver 4 x Electronic Parts
**Connections:**
  - LogicName=Chute Output, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Deep Miner), PrefabHash=-1935075707, PageLink=ThingItemKitDeepMiner

---

## Demolition Charge

- **Key:** ThingItemExplosive
- **Prefab Name:** ItemExplosive
- **Prefab Hash:** 235361649
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 3
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Security Printer (Tier Two)
    - 500 x Energy + 1 x Electrum (from Ingot (Electrum)) + 1 x Solder (from Ingot (Solder)) + 3 x Silicon (from Ingot (Silicon))
  - Printer: Tool Manufactory (Tier Two)
    - 9000 x Energy + 1 x Electrum (from Ingot (Electrum)) + 2 x Solder (from Ingot (Solder)) + 7 x Silicon (from Ingot (Silicon))


---

## Device Step Unit

- **Key:** ThingDeviceStepUnit
- **Prefab Name:** DeviceStepUnit
- **Prefab Hash:** 1762696475
- **Base Power Draw:** 5 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Music Machines)
**Mode Options:**
  - LogicName=C-2, LogicAccessTypes=0
  - LogicName=C#-2, LogicAccessTypes=1
  - LogicName=D-2, LogicAccessTypes=2
  - LogicName=D#-2, LogicAccessTypes=3
  - LogicName=E-2, LogicAccessTypes=4
  - LogicName=F-2, LogicAccessTypes=5
  - LogicName=F#-2, LogicAccessTypes=6
  - LogicName=G-2, LogicAccessTypes=7
  - LogicName=G#-2, LogicAccessTypes=8
  - LogicName=A-2, LogicAccessTypes=9
  - LogicName=A#-2, LogicAccessTypes=10
  - LogicName=B-2, LogicAccessTypes=11
  - LogicName=C-1, LogicAccessTypes=12
  - LogicName=C#-1, LogicAccessTypes=13
  - LogicName=D-1, LogicAccessTypes=14
  - LogicName=D#-1, LogicAccessTypes=15
  - LogicName=E-1, LogicAccessTypes=16
  - LogicName=F-1, LogicAccessTypes=17
  - LogicName=F#-1, LogicAccessTypes=18
  - LogicName=G-1, LogicAccessTypes=19
  - LogicName=G#-1, LogicAccessTypes=20
  - LogicName=A-1, LogicAccessTypes=21
  - LogicName=A#-1, LogicAccessTypes=22
  - LogicName=B-1, LogicAccessTypes=23
  - LogicName=C0, LogicAccessTypes=24
  - LogicName=C#0, LogicAccessTypes=25
  - LogicName=D0, LogicAccessTypes=26
  - LogicName=D#0, LogicAccessTypes=27
  - LogicName=E0, LogicAccessTypes=28
  - LogicName=F0, LogicAccessTypes=29
  - LogicName=F#0, LogicAccessTypes=30
  - LogicName=G0, LogicAccessTypes=31
  - LogicName=G#0, LogicAccessTypes=32
  - LogicName=A0, LogicAccessTypes=33
  - LogicName=A#0, LogicAccessTypes=34
  - LogicName=B0, LogicAccessTypes=35
  - LogicName=C1, LogicAccessTypes=36
  - LogicName=C#1, LogicAccessTypes=37
  - LogicName=D1, LogicAccessTypes=38
  - LogicName=D#1, LogicAccessTypes=39
  - LogicName=E1, LogicAccessTypes=40
  - LogicName=F1, LogicAccessTypes=41
  - LogicName=F#1, LogicAccessTypes=42
  - LogicName=G1, LogicAccessTypes=43
  - LogicName=G#1, LogicAccessTypes=44
  - LogicName=A1, LogicAccessTypes=45
  - LogicName=A#1, LogicAccessTypes=46
  - LogicName=B1, LogicAccessTypes=47
  - LogicName=C2, LogicAccessTypes=48
  - LogicName=C#2, LogicAccessTypes=49
  - LogicName=D2, LogicAccessTypes=50
  - LogicName=D#2, LogicAccessTypes=51
  - LogicName=E2, LogicAccessTypes=52
  - LogicName=F2, LogicAccessTypes=53
  - LogicName=F#2, LogicAccessTypes=54
  - LogicName=G2, LogicAccessTypes=55
  - LogicName=G#2, LogicAccessTypes=56
  - LogicName=A2, LogicAccessTypes=57
  - LogicName=A#2, LogicAccessTypes=58
  - LogicName=B2, LogicAccessTypes=59
  - LogicName=C3, LogicAccessTypes=60
  - LogicName=C#3, LogicAccessTypes=61
  - LogicName=D3, LogicAccessTypes=62
  - LogicName=D#3, LogicAccessTypes=63
  - LogicName=E3, LogicAccessTypes=64
  - LogicName=F3, LogicAccessTypes=65
  - LogicName=F#3, LogicAccessTypes=66
  - LogicName=G3, LogicAccessTypes=67
  - LogicName=G#3, LogicAccessTypes=68
  - LogicName=A3, LogicAccessTypes=69
  - LogicName=A#3, LogicAccessTypes=70
  - LogicName=B3, LogicAccessTypes=71
  - LogicName=C4, LogicAccessTypes=72
  - LogicName=C#4, LogicAccessTypes=73
  - LogicName=D4, LogicAccessTypes=74
  - LogicName=D#4, LogicAccessTypes=75
  - LogicName=E4, LogicAccessTypes=76
  - LogicName=F4, LogicAccessTypes=77
  - LogicName=F#4, LogicAccessTypes=78
  - LogicName=G4, LogicAccessTypes=79
  - LogicName=G#4, LogicAccessTypes=80
  - LogicName=A4, LogicAccessTypes=81
  - LogicName=A#4, LogicAccessTypes=82
  - LogicName=B4, LogicAccessTypes=83
  - LogicName=C5, LogicAccessTypes=84
  - LogicName=C#5, LogicAccessTypes=85
  - LogicName=D5, LogicAccessTypes=86
  - LogicName=D#5, LogicAccessTypes=87
  - LogicName=E5, LogicAccessTypes=88
  - LogicName=F5, LogicAccessTypes=89
  - LogicName=F#5, LogicAccessTypes=90
  - LogicName=G5 , LogicAccessTypes=91
  - LogicName=G#5, LogicAccessTypes=92
  - LogicName=A5, LogicAccessTypes=93
  - LogicName=A#5, LogicAccessTypes=94
  - LogicName=B5, LogicAccessTypes=95
  - LogicName=C6, LogicAccessTypes=96
  - LogicName=C#6, LogicAccessTypes=97
  - LogicName=D6, LogicAccessTypes=98
  - LogicName=D#6, LogicAccessTypes=99
  - LogicName=E6, LogicAccessTypes=100
  - LogicName=F6, LogicAccessTypes=101
  - LogicName=F#6, LogicAccessTypes=102
  - LogicName=G6, LogicAccessTypes=103
  - LogicName=G#6, LogicAccessTypes=104
  - LogicName=A6, LogicAccessTypes=105
  - LogicName=A#6, LogicAccessTypes=106
  - LogicName=B6, LogicAccessTypes=107
  - LogicName=C7, LogicAccessTypes=108
  - LogicName=C#7, LogicAccessTypes=109
  - LogicName=D7, LogicAccessTypes=110
  - LogicName=D#7, LogicAccessTypes=111
  - LogicName=E7, LogicAccessTypes=112
  - LogicName=F7, LogicAccessTypes=113
  - LogicName=F#7, LogicAccessTypes=114
  - LogicName=G7, LogicAccessTypes=115
  - LogicName=G#7, LogicAccessTypes=116
  - LogicName=A7, LogicAccessTypes=117
  - LogicName=A#7, LogicAccessTypes=118
  - LogicName=B7, LogicAccessTypes=119
  - LogicName=C8, LogicAccessTypes=120
  - LogicName=C#8, LogicAccessTypes=121
  - LogicName=D8, LogicAccessTypes=122
  - LogicName=D#8, LogicAccessTypes=123
  - LogicName=E8, LogicAccessTypes=124
  - LogicName=F8, LogicAccessTypes=125
  - LogicName=F#8, LogicAccessTypes=126
  - LogicName=G8, LogicAccessTypes=127
**Connections:**
  - LogicName=Data Input, LogicAccessTypes=0
  - LogicName=Power Input, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Music Machines), PrefabHash=-2038889137, PageLink=ThingItemKitMusicMachines

---

## Devices

These are Structures, typically powered, that have specialist functions including Logic, Atmospherics, and more. They are constructed in the same way as other structures.

- **Key:** DevicePage

---

## DeviceTemplate

{0}W

- **Key:** DeviceTemplate

---

## Dial

An assignable dial with up to 1000 modes.

- **Key:** ThingStructureLogicDial
- **Prefab Name:** StructureLogicDial
- **Prefab Hash:** 554524804
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic Switch)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Logic Switch), PrefabHash=124499454, PageLink=ThingItemKitLogicSwitch

---

## Digital Valve

The digital valve allows Stationeers to create logic-controlled valves and pipe networks.

- **Key:** ThingStructureDigitalValve
- **Prefab Name:** StructureDigitalValve
- **Prefab Hash:** -1280984102
- **Base Power Draw:** 5 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Digital Valve)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Digital Valve), PrefabHash=-1532448832, PageLink=ThingItemPipeDigitalValve

---

## Diode Slide

- **Key:** ThingStructureDiodeSlide
- **Prefab Name:** StructureDiodeSlide
- **Prefab Hash:** 576516101
- **Base Power Draw:** 25 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Lights)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Lights), PrefabHash=1108423476, PageLink=ThingItemWallLight

---

## Dirt Canister

A container the will fill with Dirt when using a Mining Drill when placed inside a Mining Belt. You can then use this Dirt Canister with the Terrain Manipulator to adjust the terrain to suit your needs.

- **Key:** ThingItemDirtCanister
- **Prefab Name:** ItemDirtCanister
- **Prefab Hash:** 902565329
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 1800 x Energy + 10 x Iron (from Ingot (Iron)) + 2 x Electrum (from Ingot (Electrum)) + 2 x Solder (from Ingot (Solder))


---

## Dirty Ore

Ore mined from bedrock via the Deep Miner which then can be processed in the Centrifuge, or Combustion Centrifuge. The type of ore created once processed will vary depending on the area in which the deep ore was mined. To found out what minerals can be mined in any area use the {Thing:CartridgeDeepMiner}.

- **Key:** ThingItemDirtyOre
- **Prefab Name:** ItemDirtyOre
- **Prefab Hash:** -1234745580
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 50
- **Paintable:** No
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Dirty Ore

Ore mined from asteroids via the Rocket Miner which then must be processed in the Centrifuge, or Combustion Centrifuge to produce smeltable ores.

- **Key:** ThingItemSpaceOre
- **Prefab Name:** ItemSpaceOre
- **Prefab Hash:** 2131916219
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Disposable Battery Charger

Consumable battery the recharges your suit battery. If used on a HEM-Droid it will recharge the HEM-Droids internal battery.

- **Key:** ThingItemDisposableBatteryCharger
- **Prefab Name:** ItemDisposableBatteryCharger
- **Prefab Hash:** -2124435700
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 1000 x Energy + 2 x Iron (from Ingot (Iron)) + 2 x Gold (from Ingot (Gold)) + 5 x Copper (from Ingot (Copper))


---

## Door Control

A basic tool of Stationeer base construction, this circuit board provides a way to open and close a Composite Door, Blast Door or Glass Door remotely, when connected to a Console. This system can be further linked to Motion Sensor to create automatic doors.

- **Key:** ThingCircuitboardDoorControl
- **Prefab Name:** CircuitboardDoorControl
- **Prefab Hash:** 855694771
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 393 K (120oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 100 x Energy + 5 x Gold (from Ingot (Gold)) + 5 x Copper (from Ingot (Copper))


---

## Drinking Fountain

The Drinking Fountain can be interacted with directly to increase hydration. It needs a Water supply.

- **Key:** ThingStructureDrinkingFountain2x1
- **Prefab Name:** StructureDrinkingFountain2x1
- **Prefab Hash:** -739488459
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Drinking Fountain)
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Drinking Fountain), PrefabHash=-1743663875, PageLink=ThingItemKitDrinkingFountain

---

## Droid Sleeper Vertical

The Droid Sleeper will recharge robot batteries and equiped suit batteries if present. This sleeper variant is only safe for robots. Entering as a non robot character will cause you to take damage.

- **Key:** ThingStructureSleeperVerticalDroid
- **Prefab Name:** StructureSleeperVerticalDroid
- **Prefab Hash:** 1382098999
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Slots:**
  - SlotName=Player, SlotType=Player, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Sleeper)
  - Description=Welding Torch 1 x Steel Sheets
  - Description=Screwdriver 1 x Cable Coil
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Sleeper), PrefabHash=326752036, PageLink=ThingItemKitSleeper

---

## Drought tolerance

The length of time a plant can be dehydrated before it starts taking damage.

- **Key:** GeneDroughtTolerance

---

## Duct Tape

In the distant past, one of Earth's great champions taught a generation of 'Fix-It People' that duct tape was the answer to any problem. Stationeers have demonstrated that this is truth holds strong, so long as the problem is a damaged Eva Suit, Jetpack Basic, Space Helmet, or even a Solar Panel. To use on yourself: put duct tape in your active hand, hold RIGHT MOUSE BUTTON to automatically repair damage.

- **Key:** ThingItemDuctTape
- **Prefab Name:** ItemDuctTape
- **Prefab Hash:** -1943134693
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 323 K (50oC)
- **Auto Ignition:** 373 K (100oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 2 x Iron (from Ingot (Iron))


---

## Dynamic Crate

The humble dynamic crate has become a symbol of Stationeer invention and independence. With twelve slots and handles at either end for ease of carriage, it's both standard issue and critical kit for cadets and Commanders alike.

- **Key:** ThingDynamicCrate
- **Prefab Name:** DynamicCrate
- **Prefab Hash:** 1941079206
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=None, SlotType=None, SlotIndex=2
  - SlotName=None, SlotType=None, SlotIndex=3
  - SlotName=None, SlotType=None, SlotIndex=4
  - SlotName=None, SlotType=None, SlotIndex=5
  - SlotName=None, SlotType=None, SlotIndex=6
  - SlotName=None, SlotType=None, SlotIndex=7
  - SlotName=None, SlotType=None, SlotIndex=8
  - SlotName=None, SlotType=None, SlotIndex=9
**Constructed Things:**
  - NameOfThing=Kit (Crate), PrefabHash=429365598, PageLink=ThingItemKitCrate

---

## Dynamic GPR

- **Key:** ThingDynamicGPR
- **Prefab Name:** DynamicGPR
- **Prefab Hash:** -2085885850
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

---

## Egg

- **Key:** ReagentEgg
- **Reagents Type:** Egg
**Found In Ore:**
  - NameOfThing=Powdered Eggs, QuantityOfThing=1
  - NameOfThing=Egg, QuantityOfThing=1
  - NameOfThing=Egg, QuantityOfThing=1

---

## Egg

When incubated will hatch into a Chick. If exposed to temperatures below 10 degrees it will no longer be viable.

- **Key:** ThingItemFertilizedEgg
- **Prefab Name:** ItemFertilizedEgg
- **Prefab Hash:** -383972371
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 0
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Paintable:** No
- **Flashpoint:** 313 K (40oC)
- **Auto Ignition:** 533 K (260oC)
**Used In:**
  - NameOfThing=Microwave, PrefabHash=-1136173965, PageLink=ThingApplianceMicrowave
  - NameOfThing=Automated Oven, PrefabHash=-1672404896, PageLink=ThingStructureAutomatedOven

---

## Egg Carton

Within, eggs reside in mysterious, marmoreal silence.

- **Key:** ThingItemEggCarton
- **Prefab Name:** ItemEggCarton
- **Prefab Hash:** -524289310
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 531 K (258oC)
- **Auto Ignition:** 533 K (260oC)
**Slots:**
  - SlotName=Egg, SlotType=Egg, SlotIndex=0
  - SlotName=Egg, SlotType=Egg, SlotIndex=1
  - SlotName=Egg, SlotType=Egg, SlotIndex=2
  - SlotName=Egg, SlotType=Egg, SlotIndex=3
  - SlotName=Egg, SlotType=Egg, SlotIndex=4
  - SlotName=Egg, SlotType=Egg, SlotIndex=5
**Build Recipe:**
  - Printer: Autolathe (Tier One)
    - 100 x Energy + 2 x Silicon (from Ingot (Silicon))


---

## Electrical Belt

A belt with two tool slots and six slots restricted to Cable Coil, Cable Coil (Heavy) and Cable Coil (Super Heavy). When worn, the belt reloads the Cable Gun with a matching coil once the gun's own coil is empty, and catches deconstructed cable that will not fit in your hands.

- **Key:** ThingItemCableToolBelt
- **Prefab Name:** ItemCableToolBelt
- **Prefab Hash:** 975362046
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Slots:**
  - SlotName=Tool, SlotType=Tool, SlotIndex=0
  - SlotName=Tool, SlotType=Tool, SlotIndex=1
  - SlotName=Cable Ammo, SlotType=Cable Ammo, SlotIndex=2
  - SlotName=Cable Ammo, SlotType=Cable Ammo, SlotIndex=3
  - SlotName=Cable Ammo, SlotType=Cable Ammo, SlotIndex=4
  - SlotName=Cable Ammo, SlotType=Cable Ammo, SlotIndex=5
  - SlotName=Cable Ammo, SlotType=Cable Ammo, SlotIndex=6
  - SlotName=Cable Ammo, SlotType=Cable Ammo, SlotIndex=7
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 3 x Iron (from Ingot (Iron))


---

## Electrolyzer

The Norsec-designed Electrolyzer splits Water into hydrogen and Oxygen. Employing unknown proprietary technology, the device uses water's latent heat as the energy to drive the electrosis process. If there is a downside to this near-miraculous fission, it's that the device is limited by the quantity of power available, which is used to maintain the temperature output. In other words, the machine works best with hot gas.

- **Key:** ThingStructureElectrolyzer
- **Prefab Name:** StructureElectrolyzer
- **Prefab Hash:** -1668992663
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Bindings:**
  - Header=db, Label=DEVICE
  - Header=d0, Label=SCREW_0
  - Header=d1, Label=SCREW_1
**Slots:**
  - SlotName=Programmable Chip, SlotType=Programmable Chip, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Atmospherics)
  - Description=2 x Kit (Pipe)
  - Description=Screwdriver 2 x Cable Coil
**Mode Options:**
  - LogicName=Idle, LogicAccessTypes=0
  - LogicName=Active, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Pipe Liquid Input, LogicAccessTypes=1
  - LogicName=Pipe Output, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Atmospherics), PrefabHash=1222286371, PageLink=ThingItemKitAtmospherics

---

## Electronic Parts

- **Key:** ThingItemElectronicParts
- **Prefab Name:** ItemElectronicParts
- **Prefab Hash:** 731250882
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 20
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 10 x Energy + 3 x Iron (from Ingot (Iron)) + 2 x Gold (from Ingot (Gold)) + 3 x Copper (from Ingot (Copper))


---

## Electronic Printer Mod

Apply to an Electronics Printer with a Welding Torch or Arc Welder to upgrade for increased processing speed and more recipe options.

- **Key:** ThingElectronicPrinterMod
- **Prefab Name:** ElectronicPrinterMod
- **Prefab Hash:** -311170652
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 72000 x Energy + 35 x Steel (from Ingot (Steel)) + 8 x Electrum (from Ingot (Electrum)) + 8 x Constantan (from Ingot (Constantan)) + 8 x Solder (from Ingot (Solder))


---

## Electronics

- **Key:** ElectronicPage

---

## Electronics Printer

The electronic printer will create any electronic part you need. From circuit boards and electronic devices to solar panels. The choice is yours. Upgrade the device using a Electronic Printer Mod for additional recipes and faster processing speeds.

- **Key:** ThingStructureElectronicsPrinter
- **Prefab Name:** StructureElectronicsPrinter
- **Prefab Hash:** 1307165496
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
**Slots:**
  - SlotName=Import, SlotType=Import, SlotIndex=0
  - SlotName=Export, SlotType=Export, SlotIndex=1
**Build States:**
  - Description=1 x Kit (Electronics Printer)
  - Description=Welding Torch 2 x Iron Sheets
  - Description=4 x Cable Coil
  - Description=Welding Torch 2 x Plastic Sheets
  - Details=Manufactures at Tier One , Description=Screwdriver
  - Details=Manufactures at Tier Two Build Time operates at 66% Energy Cost operates at 110% , Description=Screwdriver Electronic Printer Mod
**Resources Used:**
  - NameOfThing=Ingots, PrefabHash=0, PageLink=IngotPage
**Connections:**
  - LogicName=Chute Input, LogicAccessTypes=0
  - LogicName=Chute Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Electronics Printer), PrefabHash=-1181922382, PageLink=ThingItemKitElectronicsPrinter

---

## Electrum

- **Key:** ReagentElectrum
- **Reagents Type:** Electrum
**Found In Ore:**
  - NameOfThing=Ingot (Electrum), QuantityOfThing=1

---

## Elevator

- **Key:** ThingElevatorCarrage
- **Prefab Name:** ElevatorCarrage
- **Prefab Hash:** -110788403
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)

---

## Elevator Level

- **Key:** ThingStructureElevatorLevelIndustrial
- **Prefab Name:** StructureElevatorLevelIndustrial
- **Prefab Hash:** 2060648791
- **Base Power Draw:** 5 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Elevator)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Elevator), PrefabHash=-945806652, PageLink=ThingItemKitElevator

---

## Elevator Level (Cabled)

- **Key:** ThingStructureElevatorLevelFront
- **Prefab Name:** StructureElevatorLevelFront
- **Prefab Hash:** -827912235
- **Base Power Draw:** 5 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Elevator)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Elevator), PrefabHash=-945806652, PageLink=ThingItemKitElevator

---

## Elevator Shaft

- **Key:** ThingStructureElevatorShaftIndustrial
- **Prefab Name:** StructureElevatorShaftIndustrial
- **Prefab Hash:** 1998354978
- **Base Power Draw:** 5 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Elevator)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Elevator), PrefabHash=-945806652, PageLink=ThingItemKitElevator

---

## Elevator Shaft (Cabled)

- **Key:** ThingStructureElevatorShaft
- **Prefab Name:** StructureElevatorShaft
- **Prefab Hash:** 826144419
- **Base Power Draw:** 5 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Elevator)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Elevator), PrefabHash=-945806652, PageLink=ThingItemKitElevator

---

## Emergency Angle Grinder

- **Key:** ThingItemEmergencyAngleGrinder
- **Prefab Name:** ItemEmergencyAngleGrinder
- **Prefab Hash:** -351438780
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
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

---

## Emergency Arc Welder

- **Key:** ThingItemEmergencyArcWelder
- **Prefab Name:** ItemEmergencyArcWelder
- **Prefab Hash:** -1056029600
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
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

---

## Emergency Crowbar

- **Key:** ThingItemEmergencyCrowbar
- **Prefab Name:** ItemEmergencyCrowbar
- **Prefab Hash:** 976699731
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Auto Ignition:** 523 K (250oC)

---

## Emergency Drill

- **Key:** ThingItemEmergencyDrill
- **Prefab Name:** ItemEmergencyDrill
- **Prefab Hash:** -2052458905
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
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

---

## Emergency Eva Suit

- **Key:** ThingItemEmergencyEvaSuit
- **Prefab Name:** ItemEmergencyEvaSuit
- **Prefab Hash:** 1791306431
- **Volume:** 10L
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 393 K (120oC)
- **Auto Ignition:** 573 K (300oC)
**Slots:**
  - SlotName=Air Tank, SlotType=Air Tank, SlotIndex=0
  - SlotName=Waste Tank, SlotType=Waste Tank, SlotIndex=1
  - SlotName=Life Support, SlotType=Life Support, SlotIndex=2
  - SlotName=Filter, SlotType=Filter, SlotIndex=3
  - SlotName=Filter, SlotType=Filter, SlotIndex=4
  - SlotName=Filter, SlotType=Filter, SlotIndex=5

---

## Emergency Pickaxe

- **Key:** ThingItemEmergencyPickaxe
- **Prefab Name:** ItemEmergencyPickaxe
- **Prefab Hash:** -1061510408
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Auto Ignition:** 523 K (250oC)

---

## Emergency Screwdriver

- **Key:** ThingItemEmergencyScrewdriver
- **Prefab Name:** ItemEmergencyScrewdriver
- **Prefab Hash:** 266099983
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Auto Ignition:** 523 K (250oC)

---

## Emergency Space Helmet

- **Key:** ThingItemEmergencySpaceHelmet
- **Prefab Name:** ItemEmergencySpaceHelmet
- **Prefab Hash:** 205916793
- **Volume:** 3L
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 483 K (210oC)
- **Auto Ignition:** 623 K (350oC)

---

## Emergency Supplies

- **Key:** ThingItemEmergencySuppliesBox
- **Prefab Name:** ItemEmergencySuppliesBox
- **Prefab Hash:** 851103794
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=None, SlotType=None, SlotIndex=2
  - SlotName=None, SlotType=None, SlotIndex=3
  - SlotName=None, SlotType=None, SlotIndex=4
  - SlotName=None, SlotType=None, SlotIndex=5

---

## Emergency Tool Belt

- **Key:** ThingItemEmergencyToolBelt
- **Prefab Name:** ItemEmergencyToolBelt
- **Prefab Hash:** 1661941301
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Slots:**
  - SlotName=Tool, SlotType=Tool, SlotIndex=0
  - SlotName=Tool, SlotType=Tool, SlotIndex=1
  - SlotName=Tool, SlotType=Tool, SlotIndex=2
  - SlotName=Tool, SlotType=Tool, SlotIndex=3
  - SlotName=Tool, SlotType=Tool, SlotIndex=4
  - SlotName=Tool, SlotType=Tool, SlotIndex=5
  - SlotName=Tool, SlotType=Tool, SlotIndex=6
  - SlotName=Tool, SlotType=Tool, SlotIndex=7

---

## Emergency Wire Cutters

- **Key:** ThingItemEmergencyWireCutters
- **Prefab Name:** ItemEmergencyWireCutters
- **Prefab Hash:** 2102803952
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Auto Ignition:** 523 K (250oC)

---

## Emergency Wrench

- **Key:** ThingItemEmergencyWrench
- **Prefab Name:** ItemEmergencyWrench
- **Prefab Hash:** 162553030
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Auto Ignition:** 523 K (250oC)

---

## Empty Can

Used for making soups when combined with food in the Basic Packaging Machine or Advanced Packaging Machine. Fairly high in nutrition, canned food does not decay.

- **Key:** ThingItemEmptyCan
- **Prefab Name:** ItemEmptyCan
- **Prefab Hash:** 1013818348
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 10
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Autolathe (Tier One)
    - 70 x Energy + 1 x Steel (from Ingot (Steel))

**Used In:**
  - NameOfThing=Basic Packaging Machine, PrefabHash=-749191906, PageLink=ThingAppliancePackagingMachine
  - NameOfThing=Advanced Packaging Machine, PrefabHash=-463037670, PageLink=ThingStructureAdvancedPackagingMachine

---

## Engine Mount (Type A1)

- **Key:** ThingStructureEngineMountTypeA1
- **Prefab Name:** StructureEngineMountTypeA1
- **Prefab Hash:** 2035781224
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 100kg
**Build States:**
  - Description=1 x Kit (Fuselage)
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Fuselage), PrefabHash=-366262681, PageLink=ThingItemKitFuselage
  - NameOfThing=Kit (Fuselage Type A), PrefabHash=1438837103, PageLink=ThingItemKitFuselageTypeA

---

## Engine Mount (Type E1)

- **Key:** ThingStructureEngineMountTypeE1
- **Prefab Name:** StructureEngineMountTypeE1
- **Prefab Hash:** 490425196
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 100kg
**Build States:**
  - Description=1 x Kit (Fuselage Type E)
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Fuselage Type E), PrefabHash=1387212150, PageLink=ThingItemKitFuselageTypeE

---

## Engine Mount (Type E2)

- **Key:** ThingStructureEngineMountTypeE2
- **Prefab Name:** StructureEngineMountTypeE2
- **Prefab Hash:** -2077091114
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 100kg
**Build States:**
  - Description=1 x Kit (Fuselage Type E)
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Fuselage Type E), PrefabHash=1387212150, PageLink=ThingItemKitFuselageTypeE

---

## Eva Suit

The EVA suit is the basic suit Stationeers need to survive in the inhospitable environment of space. For more information on EVA suits, consult the EVA suit guide.

- **Key:** ThingItemEvaSuit
- **Prefab Name:** ItemEvaSuit
- **Prefab Hash:** 1677018918
- **Volume:** 10L
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 393 K (120oC)
- **Auto Ignition:** 573 K (300oC)
**Slots:**
  - SlotName=Air Tank, SlotType=Air Tank, SlotIndex=0
  - SlotName=Waste Tank, SlotType=Waste Tank, SlotIndex=1
  - SlotName=Life Support, SlotType=Life Support, SlotIndex=2
  - SlotName=Filter, SlotType=Filter, SlotIndex=3
  - SlotName=Filter, SlotType=Filter, SlotIndex=4
  - SlotName=Filter, SlotType=Filter, SlotIndex=5
**Build Recipe:**
  - Printer: Autolathe (Tier One)
    - 500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Copper (from Ingot (Copper))
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 5 x Iron (from Ingot (Iron)) + 2 x Copper (from Ingot (Copper))


---

## EVA Suits

Your spacesuit provides you with a portable atmosphere, with adjustable pressure and air conditioning (temperature) settings, as well as an warning system that will alert you should the atmosphere inside the suit become hazardous. It functions in conjunction with a suitable helmet to function properly, as well as suitable gas canisters and filters in the suit's various slots. These will need to be changed regularly, and can also be recharged (or drained) using a Suit Storage. There are several suits, including the Eva Suit and the more pressure- and temperature-resistant Hardsuit. Your suit various readouts are at the bottom-right of the screen. Pressing the appropriate numeric key (2will bring up a panel showing its slots and settings. These include: - A/C On / Off (i.e. Temperature control on/off) - Filters On / Off - Air On / Off - Pressure Up / Down (with a range of 0kPA to 202kPa, or 0-2 Earth atmospheres) - Temperature Up / Down (with a range of 0°C to 60°C) Suits contains 6-8 slots: - Air tank (x1) - insert a canister or smart canister containing a breathable gas mix, eg Oxygen or Nitrogen/Oxygen 35/65. - Waste tank (x1) - collects gases removed by the filters - Life support (x1) - holds one battery, which powers your A/C, lights, etc. - Gas Filter (x3) - requires at least one Filter (Carbon Dioxide) (if human), depending on your breathable gas mix. Note that a Hardsuit has 4 filter slots. - IC - Hardsuit only. Pressure: should be set to 50-100 KPa (0.5 to 1 Earth atmospheres). Humans in-game tolerate up to ~250kPa and can survive up to ~300kPA. Temperature: normally set to 18-21°C, with humans in-game preferring 10-29°C, tolerating 0-39°C and surviving around up to 49°C. In higher temperatures, your A/C will consume more battery power to maintain internal temperature. Filters: the default filter is the Carbon Dioxide filter, which captures the gas generated by humans when breathing out. If you are not using 100% Oxygen in your breathing gas, add additional filters, eg if you mix 25% Oxygen + 75% Nitrogen, the nitrogen will accumulate in your suit over time and suffocate you, unless you have a nitrogen filter. If you have the correct filters and breathable gas, but are still experiencing problems, use the 'Flush' function on your Space Helmet. Low/critical oxygen warnings will sound as your filters cease to function. If damaged, your suit can be patched by holding duct tape in your hand and using 'activate' button.

- **Key:** EVAPage

---

## Evaporation Chamber

A device for safely evaporating liquids into gasses. Liquids and Gasses will both exist safely inside the device. Lowering the pressure target of the in-built back pressure regulator using the setting wheel will change the boiling temperature of liquids inside. The secondary gas input on the left is a heat-exchanger input and allows for heat exchange between the secondary input pipe and the internal atmosphere of the Evaporation Chamber. Paired with Condensation Chamber Stationeers can exploit the phase change properties of gases to build a DIY air conditioner.

- **Key:** ThingStructureEvaporationChamber
- **Prefab Name:** StructureEvaporationChamber
- **Prefab Hash:** -1429782576
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Phase Change Device)
  - Description=Wrench 2 x Steel Sheets
  - Description=Welding Torch 2 x Steel Sheets
**Connections:**
  - LogicName=Pipe Input 2, LogicAccessTypes=0
  - LogicName=Pipe Output, LogicAccessTypes=1
  - LogicName=Pipe Liquid Input, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
  - LogicName=Power Input, LogicAccessTypes=4
**Constructed Things:**
  - NameOfThing=Kit (Phase Change Device), PrefabHash=1587787610, PageLink=ThingItemKitEvaporationChamber

---

## ExMin

In the aftermath of the Sisyphus disaster on Mars in 2079, asteroid shifting was officially banned by the ODA. This sea-change forced the newborn space mining industry to reconsider its strategies, but until the opening of the Manaus Space Elevator, marginal economics meant offworld resource extraction was effectively impossible. Formed in 2095 by a long-standing Swiss-German mining conglomerate and a consortium of other interests, ExMin was more an idea than a commercial reality for several decades. Created with the certainty that a space elevator would eventually arrive, ExMin was one of the first to exploit the access it offered. Subsequently it has become one of the Solar System's most powerful commercial entities. With access to space secure, ExMin became a central player in the flow of resources to the Inner System. It has competition, principally from Brazilian mining giant Recurso, but the company has never entirely lost its lead on off-world mining. Synonymous with rare earth metals and pioneering off-world resource extraction, it stands at the forefront of development throughout the Solar System.

- **Key:** ExMin

---

## Expansion Valve

Allows for moving liquids from a liquid pipe into a gas pipe. Only allows liquids to pass in one direction. Typically this is done to allow the liquid to evaporate into a gas as part of an airconditioning loop.

- **Key:** ThingStructureExpansionValve
- **Prefab Name:** StructureExpansionValve
- **Prefab Hash:** 195298587
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Pipe Valve)
**Connections:**
  - LogicName=Pipe Output, LogicAccessTypes=0
  - LogicName=Pipe Liquid Input, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Pipe Valve), PrefabHash=799323450, PageLink=ThingItemPipeValve

---

## Fabricators

These are powered Structures that can be used to Manufacture things you need in the game. They usually take Ingots to provide the Reagents they need to make things.

- **Key:** FabricatorPage

---

## Factions

- **Key:** LorePage

---

## Fairing (Type A1)

- **Key:** ThingStructureFairingTypeA1
- **Prefab Name:** StructureFairingTypeA1
- **Prefab Hash:** 1622567418
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 0kg
**Build States:**
  - Description=1 x Kit (Fuselage)
  - Description=Welding Torch 2 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Fuselage), PrefabHash=-366262681, PageLink=ThingItemKitFuselage
  - NameOfThing=Kit (Fuselage Type A), PrefabHash=1438837103, PageLink=ThingItemKitFuselageTypeA

---

## Fairing (Type A2)

- **Key:** ThingStructureFairingTypeA2
- **Prefab Name:** StructureFairingTypeA2
- **Prefab Hash:** -104908736
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 0kg
**Build States:**
  - Description=1 x Kit (Fuselage)
  - Description=Welding Torch 2 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Fuselage), PrefabHash=-366262681, PageLink=ThingItemKitFuselage
  - NameOfThing=Kit (Fuselage Type A), PrefabHash=1438837103, PageLink=ThingItemKitFuselageTypeA

---

## Fairing (Type A3)

- **Key:** ThingStructureFairingTypeA3
- **Prefab Name:** StructureFairingTypeA3
- **Prefab Hash:** -1900541738
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 0kg
**Build States:**
  - Description=1 x Kit (Fuselage)
  - Description=Welding Torch 2 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Fuselage), PrefabHash=-366262681, PageLink=ThingItemKitFuselage
  - NameOfThing=Kit (Fuselage Type A), PrefabHash=1438837103, PageLink=ThingItemKitFuselageTypeA

---

## Fairing (Type E1)

- **Key:** ThingStructureFairingTypeE1
- **Prefab Name:** StructureFairingTypeE1
- **Prefab Hash:** 81439998
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
- **Rocket Mass:** 0kg
**Build States:**
  - Description=1 x Kit (Fuselage Type E)
  - Description=Welding Torch 2 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Fuselage Type E), PrefabHash=1387212150, PageLink=ThingItemKitFuselageTypeE

---

## Fenoxitone

- **Key:** ReagentFenoxitone
- **Reagents Type:** Fenoxitone
**Found In Ore:**
  - NameOfThing=Fern, QuantityOfThing=1

---

## Fermenter

- **Key:** ThingStructureFermenter
- **Prefab Name:** StructureFermenter
- **Prefab Hash:** 1103525139
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Bindings:**
  - Header=db, Label=DEVICE
  - Header=d0, Label=SCREW_0
  - Header=d1, Label=SCREW_1
**Slots:**
  - SlotName=Import, SlotType=Import, SlotIndex=0
  - SlotName=Programmable Chip, SlotType=Programmable Chip, SlotIndex=1
**Build States:**
  - Description=1 x Kit (Atmospherics)
  - Description=2 x Kit (Pipe)
  - Description=Welding Torch 5 x Steel Sheets
**Resources Used:**
  - NameOfThing=Decayed Food, PrefabHash=1531087544, PageLink=ThingDecayedFood
  - NameOfThing=Alien Mushroom, PrefabHash=176446172, PageLink=ThingItemAlienMushroom
  - NameOfThing=Biomass, PrefabHash=-831480639, PageLink=ThingItemBiomass
  - NameOfThing=Hay, PrefabHash=215486157, PageLink=ThingItemCropHay
  - NameOfThing=Peace Lily, PrefabHash=2042955224, PageLink=ThingItemPeaceLily
  - NameOfThing=Tropical Lily, PrefabHash=-800947386, PageLink=ThingItemTropicalPlant
  - NameOfThing=Switch Grass, PrefabHash=-532672323, PageLink=ThingItemPlantSwitchGrass
  - NameOfThing=Switchgrass Seed, PrefabHash=488360169, PageLink=ThingSeedBag_Switchgrass
  - NameOfThing=Strawberry, PrefabHash=-906450470, PageLink=ThingItemStrawberry
  - NameOfThing=Strawberry Seeds, PrefabHash=2009884607, PageLink=ThingSeedBag_Strawberry
  - NameOfThing=Tomato, PrefabHash=-998592080, PageLink=ThingItemTomato
  - NameOfThing=Tomato Seeds, PrefabHash=-1922066841, PageLink=ThingSeedBag_Tomato
  - NameOfThing=Blueberry, PrefabHash=173826094, PageLink=ThingItemBlueberry
  - NameOfThing=Blueberry Seeds, PrefabHash=897717596, PageLink=ThingSeedBag_Blueberry
  - NameOfThing=Watermelon, PrefabHash=-1392622903, PageLink=ThingItemWatermelon
  - NameOfThing=Watermelon Seeds, PrefabHash=315264172, PageLink=ThingSeedBag_Watermelon
  - NameOfThing=Potato, PrefabHash=1929046963, PageLink=ThingItemPotato
  - NameOfThing=Potato Seeds, PrefabHash=1005571172, PageLink=ThingSeedBag_Potato
  - NameOfThing=Corn, PrefabHash=258339687, PageLink=ThingItemCorn
  - NameOfThing=Corn Seeds, PrefabHash=-1290755415, PageLink=ThingSeedBag_Corn
  - NameOfThing=Darga Fern, PrefabHash=266654416, PageLink=ThingItemFilterFern
  - NameOfThing=Darga Fern Seeds, PrefabHash=980397232, PageLink=ThingSeedBag_DargaFern
  - NameOfThing=Fern, PrefabHash=892110467, PageLink=ThingItemFern
  - NameOfThing=Fern Seeds, PrefabHash=-1990600883, PageLink=ThingSeedBag_Fern
  - NameOfThing=Cocoa, PrefabHash=680051921, PageLink=ThingItemCocoaTree
  - NameOfThing=Cocoa Seeds, PrefabHash=1139887531, PageLink=ThingSeedBag_Cocoa
  - NameOfThing=Sugarcane, PrefabHash=-1335056202, PageLink=ThingItemSugarCane
  - NameOfThing=Sugarcane Seeds, PrefabHash=-1884103228, PageLink=ThingSeedBag_SugarCane
  - NameOfThing=Wheat, PrefabHash=-1057658015, PageLink=ThingItemWheat
  - NameOfThing=Wheat Seeds, PrefabHash=-654756733, PageLink=ThingSeedBag_Wheet
  - NameOfThing=Soybean, PrefabHash=1924673028, PageLink=ThingItemSoybean
  - NameOfThing=Soybean Seeds, PrefabHash=1783004244, PageLink=ThingSeedBag_Soybean
  - NameOfThing=Rice, PrefabHash=658916791, PageLink=ThingItemRice
  - NameOfThing=Rice Seeds, PrefabHash=-1691151239, PageLink=ThingSeedBag_Rice
  - NameOfThing=Pumpkin, PrefabHash=1277828144, PageLink=ThingItemPumpkin
  - NameOfThing=Pumpkin Seeds, PrefabHash=1423199840, PageLink=ThingSeedBag_Pumpkin
  - NameOfThing=Mushroom, PrefabHash=2044798572, PageLink=ThingItemMushroom
  - NameOfThing=Mushroom Seeds, PrefabHash=311593418, PageLink=ThingSeedBag_Mushroom
  - NameOfThing=Winterspawn (Alpha strain), PrefabHash=851290561, PageLink=ThingItemPlantEndothermic_Genepool1
  - NameOfThing=Winterspawn Seed (Alpha strain), PrefabHash=-1740754636, PageLink=ThingSeedBag_WinterspawnAlpha
  - NameOfThing=Winterspawn (Beta strain), PrefabHash=-1414203269, PageLink=ThingItemPlantEndothermic_Genepool2
  - NameOfThing=Winterspawn Seed (Beta strain), PrefabHash=-475065916, PageLink=ThingSeedBag_WinterspawnBeta
  - NameOfThing=Hades Flower (Alpha strain), PrefabHash=-177792789, PageLink=ThingItemPlantThermogenic_Genepool1
  - NameOfThing=Hades Seed (Alpha strain), PrefabHash=-1066145654, PageLink=ThingSeedBag_HadesAlpha
  - NameOfThing=Hades Flower (Beta strain), PrefabHash=1819167057, PageLink=ThingItemPlantThermogenic_Genepool2
  - NameOfThing=Hades Seed (Beta strain), PrefabHash=-969228551, PageLink=ThingSeedBag_HadesBeta
  - NameOfThing=Grass, PrefabHash=2116552372, PageLink=ThingItemGrass
  - NameOfThing=Flax, PrefabHash=-1345959473, PageLink=ThingItemFlax
  - NameOfThing=Gorse, PrefabHash=921641358, PageLink=ThingItemGorse
**Mode Options:**
  - LogicName=Idle, LogicAccessTypes=0
  - LogicName=Active, LogicAccessTypes=1
**Connections:**
  - LogicName=Data Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Output, LogicAccessTypes=1
  - LogicName=Power Input, LogicAccessTypes=2
  - LogicName=Chute Input, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Atmospherics), PrefabHash=1222286371, PageLink=ThingItemKitAtmospherics

---

## Fern

There was a time, when Stationeers had to make Fenoxitone Powder using the Reagent Processor. Recent advances in technology allow you to use equivalent quantities of fern directly in recipes.

- **Key:** ThingItemFern
- **Prefab Name:** ItemFern
- **Prefab Hash:** 892110467
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 0
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Growth Time:** 40min 1s
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Constructed From Kits:**
  - NameOfThing=Fern Seeds, PrefabHash=-1990600883, PageLink=ThingSeedBag_Fern
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=2 mol
  - NameOfThing=Polluted Water, QuantityOfThing=0.1 mol
**Used In:**
  - NameOfThing=Chemistry Station, PrefabHash=1365789392, PageLink=ThingApplianceChemistryStation
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Fern Seeds

Grow a Fern.

- **Key:** ThingSeedBag_Fern
- **Prefab Name:** SeedBag_Fern
- **Prefab Hash:** -1990600883
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

## Fertilizer

Fertilizer alters plant growth processes, and is created by the basic composter and the Advanced Composter using organic matter. Fertilizer's affects depend on its ingredients: - Food increases PLANT YIELD up to two times - Decayed Food increases plant GROWTH SPEED up to two times - Biomass increases the NUMBER OF GROWTH CYCLES the fertilizer lasts for The effect of these ingredients depends on their respective proportions in the composter when processing is activated.

- **Key:** ThingFertilizer
- **Prefab Name:** Fertilizer
- **Prefab Hash:** 1517856652
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 10
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)

---


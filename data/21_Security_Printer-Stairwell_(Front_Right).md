# Security Printer - Stairwell (Front Right)

## Security Printer

Any Stationeer concerned about security needs the Harkwell-designed Vigilant-E security printer. Use the Vigilant-E to create a Cartridge (Access Controller), in order to restrict access to different parts of your base via keycards like the Access Card (Blue). The printer also makes a variety of weapons and ammunitions to defend your base against any hostile, aggressive or just slightly rude entites you encounter as you explore the Solar System.

- **Key:** ThingStructureSecurityPrinter
- **Prefab Name:** StructureSecurityPrinter
- **Prefab Hash:** -641491515
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
  - Description=1 x Kit (Security Printer)
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
  - NameOfThing=Kit (Security Printer), PrefabHash=578078533, PageLink=ThingItemKitSecurityPrinter

---

## Sensor Lenses

These Norsec glasses might not be the most fashionable thing, but when a Sensor Processing Unit (Ore Scanner) is inserted, Stationeers can use these handy glasses to x-ray the ground and find ores that are hidden beneath the surface.

- **Key:** ThingItemSensorLenses
- **Prefab Name:** ItemSensorLenses
- **Prefab Hash:** -1176140051
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
  - LogicName=Charge, LogicAccessTypes=0
  - LogicName=ChargeRatio, LogicAccessTypes=0
  - LogicName=Class, LogicAccessTypes=0, 1
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1
  - LogicName=PrefabHash, LogicAccessTypes=0, 1
  - LogicName=ReferenceId, LogicAccessTypes=0, 1
**Slots:**
  - SlotName=Battery, SlotType=Battery, SlotIndex=0
  - SlotName=Sensor Processing Unit, SlotType=Sensor Processing Unit, SlotIndex=1
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 3500 x Energy + 5 x Steel (from Ingot (Steel)) + 5 x Silicon (from Ingot (Silicon)) + 5 x Inconel (from Ingot (Inconel))


---

## Sensor Processing Unit (Celestial Scanner)

- **Key:** ThingItemSensorProcessingUnitCelestialScanner
- **Prefab Name:** ItemSensorProcessingUnitCelestialScanner
- **Prefab Hash:** -1154200014
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 100 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Electrum (from Ingot (Electrum)) + 5 x Silicon (from Ingot (Silicon)) + 5 x Waspaloy (from Ingot (Waspaloy))


---

## Sensor Processing Unit (Monorail Blocks)

A sensor processing unit for use in the Sensor Lenses. When inserted and powered on, it displays the directional blocks created by Monorail Block Signal signals. Blocks are rendered as colored bands following the actual rail nodes through segments, switches, merges, and splits. Opposite directions are drawn at slightly different heights. A train occupying shared track protects every directional block view which uses that track. See also: Monorail D - Signals and Shared Track

- **Key:** ThingItemSensorProcessingUnitMonorailBlocks
- **Prefab Name:** ItemSensorProcessingUnitMonorailBlocks
- **Prefab Hash:** 120731786
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Electronics Printer (Tier Two)
    - 1000 x Energy + 3 x Gold (from Ingot (Gold)) + 4 x Solder (from Ingot (Solder)) + 10 x Silicon (from Ingot (Silicon))


---

## Sensor Processing Unit (Ore Scanner)

The Sensor Processing unit can be inserted into Sensor Lenses to reveal underground minerals in a HUD.

- **Key:** ThingItemSensorProcessingUnitOreScanner
- **Prefab Name:** ItemSensorProcessingUnitOreScanner
- **Prefab Hash:** -1219128491
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 100 x Energy + 5 x Electrum (from Ingot (Electrum)) + 5 x Silicon (from Ingot (Silicon)) + 5 x Waspaloy (from Ingot (Waspaloy))


---

## Sensor Processing Unit (T-Ray Scanner)

The T-Ray Scanner Sensor Processing Unit can be inserted into the Sensor Lenses to show an overlay of pipes and cables. This can be useful when building behind walls or other structures.

- **Key:** ThingItemSensorProcessingUnitMesonScanner
- **Prefab Name:** ItemSensorProcessingUnitMesonScanner
- **Prefab Hash:** -1730464583
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 100 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Electrum (from Ingot (Electrum)) + 5 x Silicon (from Ingot (Silicon)) + 5 x Waspaloy (from Ingot (Waspaloy))


---

## Server Motherboard

A specialized motherboard designed to manage and monitor connected Server Racks within a computer system. It aggregates computational output and power usage across the network, displaying real-time performance data on the computer interface. Ideal for overseeing distributed compute systems and optimizing power efficiency in your Stationeer base.

- **Key:** ThingServerMotherboard
- **Prefab Name:** ServerMotherboard
- **Prefab Hash:** 1723978457
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 1500 x Energy + 2 x Gold (from Ingot (Gold)) + 5 x Copper (from Ingot (Copper)) + 10 x Silicon (from Ingot (Silicon))


---

## Server Rack

Built using the Kit (Server Rack), this device represents a high-density computational unit within your Stationeer base. It continuously draws power and produces heat, making it ideal for stress-testing electrical networks, cooling setups, and atmospheric control systems.

- **Key:** ThingServerRack
- **Prefab Name:** ServerRack
- **Prefab Hash:** -1592120858
- **Base Power Draw:** 100 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Server Rack)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Pipe Liquid Input, LogicAccessTypes=1
  - LogicName=Pipe Liquid Output, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Server Rack), PrefabHash=1459811168, PageLink=ThingItemKitServerRack

---

## Shelf

- **Key:** ThingStructureShelf
- **Prefab Name:** StructureShelf
- **Prefab Hash:** 1172114950
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=None, SlotType=None, SlotIndex=2
  - SlotName=None, SlotType=None, SlotIndex=3
  - SlotName=None, SlotType=None, SlotIndex=4
**Build States:**
  - Description=1 x Kit (Locker)
**Constructed Things:**
  - NameOfThing=Kit (Locker), PrefabHash=882301399, PageLink=ThingItemKitLocker

---

## Shelf Medium

A shelf for putting things on, so you can see them.

- **Key:** ThingStructureShelfMedium
- **Prefab Name:** StructureShelfMedium
- **Prefab Hash:** 182006674
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=Damage, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=Class, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=SortingClass, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=FreeSlots, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=TotalSlots, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
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
  - SlotName=None, SlotType=None, SlotIndex=10
  - SlotName=None, SlotType=None, SlotIndex=11
  - SlotName=None, SlotType=None, SlotIndex=12
  - SlotName=None, SlotType=None, SlotIndex=13
  - SlotName=None, SlotType=None, SlotIndex=14
**Build States:**
  - Description=1 x Kit (Locker)
**Constructed Things:**
  - NameOfThing=Kit (Locker), PrefabHash=882301399, PageLink=ThingItemKitLocker

---

## Short Corner Locker

- **Key:** ThingStructureShortCornerLocker
- **Prefab Name:** StructureShortCornerLocker
- **Prefab Hash:** 1330754486
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
  - LogicName=Class, LogicAccessTypes=0, 1
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1
  - LogicName=PrefabHash, LogicAccessTypes=0, 1
  - LogicName=SortingClass, LogicAccessTypes=0, 1
  - LogicName=ReferenceId, LogicAccessTypes=0, 1
  - LogicName=FreeSlots, LogicAccessTypes=0, 1
  - LogicName=TotalSlots, LogicAccessTypes=0, 1
**Slots:**
  - SlotName=None, SlotType=None, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
**Build States:**
  - Description=1 x Kit (Locker)
**Constructed Things:**
  - NameOfThing=Kit (Locker), PrefabHash=882301399, PageLink=ThingItemKitLocker

---

## Short Locker

- **Key:** ThingStructureShortLocker
- **Prefab Name:** StructureShortLocker
- **Prefab Hash:** -554553467
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=Damage, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=Class, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=SortingClass, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=FreeSlots, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=TotalSlots, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
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
**Build States:**
  - Description=1 x Kit (Locker)
**Constructed Things:**
  - NameOfThing=Kit (Locker), PrefabHash=882301399, PageLink=ThingItemKitLocker

---

## Shower

The fastest way to remove low hygiene. You must remove your Jump Suit (Orange) and Eva Suit when using the Shower. It outputs Polluted Water when in use. Polluted Water will interfere with many other Water systems so make sure to collect and treat it using a Water Purifier or dump it.

- **Key:** ThingStructureShower
- **Prefab Name:** StructureShower
- **Prefab Hash:** -775128944
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Shower)
  - Description=Screwdriver 1 x Kit (Liquid Pipe)
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Output, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Shower), PrefabHash=735858725, PageLink=ThingItemKitShower

---

## Shower (Powered)

The fastest way to remove low hygiene. You must remove your Jump Suit (Orange) and Eva Suit when using the Shower (Powered). It outputs Polluted Water when in use. Polluted Water will interfere with many other Water systems so make sure to collect and treat it using a Water Purifier or dump it.

- **Key:** ThingStructureShowerPowered
- **Prefab Name:** StructureShowerPowered
- **Prefab Hash:** -1081797501
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Shower)
  - Description=Screwdriver 1 x Kit (Liquid Pipe)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Pipe Liquid Input, LogicAccessTypes=1
  - LogicName=Pipe Liquid Output, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Shower), PrefabHash=735858725, PageLink=ThingItemKitShower

---

## Sign 1x1

- **Key:** ThingStructureSign1x1
- **Prefab Name:** StructureSign1x1
- **Prefab Hash:** 879058460
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Sign)
**Constructed Things:**
  - NameOfThing=Kit (Sign), PrefabHash=529996327, PageLink=ThingItemKitSign

---

## Sign 2x1

- **Key:** ThingStructureSign2x1
- **Prefab Name:** StructureSign2x1
- **Prefab Hash:** 908320837
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=2 x Kit (Sign)
**Constructed Things:**
  - NameOfThing=Kit (Sign), PrefabHash=529996327, PageLink=ThingItemKitSign

---

## Silanol

Silanol is the premium refrigerant gas for utilising phase change to pump heat. It has a wide liquid range an is more commonly found in it's liquid form Liquid Silanol.

- **Key:** GasSilanol
- **Specific Heat:** 101 J/K
- **Freeze Temperature:** 143K (-130C)
- **Boiling Temperature:** N/A

---

## Silicon

- **Key:** ReagentSilicon
- **Reagents Type:** Silicon
**Found In Ore:**
  - NameOfThing=Ingot (Silicon), QuantityOfThing=0.1
  - NameOfThing=Ore (Silicon), QuantityOfThing=1
  - NameOfThing=Bowling Ball, QuantityOfThing=1
  - NameOfThing=Bowling Pin, QuantityOfThing=1

---

## Silver

- **Key:** ReagentSilver
- **Reagents Type:** Silver
**Found In Ore:**
  - NameOfThing=Ingot (Silver), QuantityOfThing=1
  - NameOfThing=Ore (Silver), QuantityOfThing=1

---

## Single Bed

- **Key:** ThingStructureSingleBed
- **Prefab Name:** StructureSingleBed
- **Prefab Hash:** -492611
- **Base Power Draw:** 10 W
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
  - SlotName=Bed, SlotType=Bed, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Beds)
**Constructed Things:**
  - NameOfThing=Kit (Beds), PrefabHash=-1241256797, PageLink=ThingItemKitBeds

---

## Sinotai

The sole 'traditional' state entity to survive offworld politics, Sinotai’s reach and power is second only to the ODA itself. In many ways a relic – a sub-agency of a staggeringly complicated Earth-bound corporate-bureaucracy – its structure has allowed Sinotai to achieve incredible things. Proving its mettle in the early 21st Century by putting the first humans on Mars, establishing the first offworld gigawatt power system, and the first space-borne fuel refinery, few space-going organisations lack some degree of relationship with Sinotai. A common joke has it that it's impossible to do anything in space without them. Regardless of the truth, Sinotai's approach to off-world development has involved a 'soft power' approach, from MOU's with Recurso (giving them preferential access to the Manaus space elevator) to murkier alliances of convenience with a range of Trader groups.

- **Key:** Sinotai

---

## Skeleton

- **Key:** ThingDynamicSkeleton
- **Prefab Name:** DynamicSkeleton
- **Prefab Hash:** 106953348
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No

---

## Sleeper

- **Key:** ThingStructureSleeper
- **Prefab Name:** StructureSleeper
- **Prefab Hash:** -1467449329
- **Base Power Draw:** 100 W
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
  - SlotName=Bed, SlotType=Bed, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Sleeper)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Pipe Input, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2

---

## Sleeper Left

A horizontal variant of the sleeper. Will keep players hydrated and fed while they are logged out - as long as a breathable atmosphere is provided.

- **Key:** ThingStructureSleeperLeft
- **Prefab Name:** StructureSleeperLeft
- **Prefab Hash:** 1213495833
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
  - SlotName=Player, SlotType=Player, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Sleeper)
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
**Constructed Things:**
  - NameOfThing=Kit (Sleeper), PrefabHash=326752036, PageLink=ThingItemKitSleeper

---

## Sleeper Right

A horizontal variant of the sleeper. Will keep players hydrated and fed while they are logged out - as long as a breathable atmosphere is provided.

- **Key:** ThingStructureSleeperRight
- **Prefab Name:** StructureSleeperRight
- **Prefab Hash:** -1812330717
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
  - SlotName=Player, SlotType=Player, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Sleeper)
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
**Constructed Things:**
  - NameOfThing=Kit (Sleeper), PrefabHash=326752036, PageLink=ThingItemKitSleeper

---

## Sleeper Vertical

The vertical variant of the sleeper. Will keep players hydrated and fed while they are logged out - as long as a breathable atmosphere is provided.

- **Key:** ThingStructureSleeperVertical
- **Prefab Name:** StructureSleeperVertical
- **Prefab Hash:** -1300059018
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
  - SlotName=Player, SlotType=Player, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Sleeper)
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
**Constructed Things:**
  - NameOfThing=Kit (Sleeper), PrefabHash=326752036, PageLink=ThingItemKitSleeper

---

## Slot Reader

- **Key:** ThingStructureLogicSlotReader
- **Prefab Name:** StructureLogicSlotReader
- **Prefab Hash:** -767867194
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

## Small (Table Backless Double)

- **Key:** ThingStructureSmallTableBacklessDouble
- **Prefab Name:** StructureSmallTableBacklessDouble
- **Prefab Hash:** -1633000411
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Tables)
**Constructed Things:**
  - NameOfThing=Kit (Tables), PrefabHash=-1361598922, PageLink=ThingItemKitTables

---

## Small (Table Backless Single)

- **Key:** ThingStructureSmallTableBacklessSingle
- **Prefab Name:** StructureSmallTableBacklessSingle
- **Prefab Hash:** -1897221677
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Tables)
**Constructed Things:**
  - NameOfThing=Kit (Tables), PrefabHash=-1361598922, PageLink=ThingItemKitTables

---

## Small (Table Dinner Single)

- **Key:** ThingStructureSmallTableDinnerSingle
- **Prefab Name:** StructureSmallTableDinnerSingle
- **Prefab Hash:** 1260651529
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Tables)
**Constructed Things:**
  - NameOfThing=Kit (Tables), PrefabHash=-1361598922, PageLink=ThingItemKitTables

---

## Small (Table Rectangle Double)

- **Key:** ThingStructureSmallTableRectangleDouble
- **Prefab Name:** StructureSmallTableRectangleDouble
- **Prefab Hash:** -660451023
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Tables)
**Constructed Things:**
  - NameOfThing=Kit (Tables), PrefabHash=-1361598922, PageLink=ThingItemKitTables

---

## Small (Table Rectangle Single)

- **Key:** ThingStructureSmallTableRectangleSingle
- **Prefab Name:** StructureSmallTableRectangleSingle
- **Prefab Hash:** -924678969
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Tables)
**Constructed Things:**
  - NameOfThing=Kit (Tables), PrefabHash=-1361598922, PageLink=ThingItemKitTables

---

## Small (Table Thick Double)

- **Key:** ThingStructureSmallTableThickDouble
- **Prefab Name:** StructureSmallTableThickDouble
- **Prefab Hash:** -19246131
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Tables)
**Constructed Things:**
  - NameOfThing=Kit (Tables), PrefabHash=-1361598922, PageLink=ThingItemKitTables

---

## Small Direct Heat Exchanger - Gas + Gas

Direct Heat Exchangers equalize the temperature of the two input networks.

- **Key:** ThingStructureSmallDirectHeatExchangeGastoGas
- **Prefab Name:** StructureSmallDirectHeatExchangeGastoGas
- **Prefab Hash:** 1310303582
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Small Direct Heat Exchanger)
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Input 2, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Small Direct Heat Exchanger), PrefabHash=-1332682164, PageLink=ThingItemKitSmallDirectHeatExchanger

---

## Small Direct Heat Exchanger - Liquid + Gas

Direct Heat Exchangers equalize the temperature of the two input networks.

- **Key:** ThingStructureSmallDirectHeatExchangeLiquidtoGas
- **Prefab Name:** StructureSmallDirectHeatExchangeLiquidtoGas
- **Prefab Hash:** 1825212016
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Small Direct Heat Exchanger)
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Input 2, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Small Direct Heat Exchanger), PrefabHash=-1332682164, PageLink=ThingItemKitSmallDirectHeatExchanger

---

## Small Direct Heat Exchanger - Liquid + Liquid

Direct Heat Exchangers equalize the temperature of the two input networks.

- **Key:** ThingStructureSmallDirectHeatExchangeLiquidtoLiquid
- **Prefab Name:** StructureSmallDirectHeatExchangeLiquidtoLiquid
- **Prefab Hash:** -507770416
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Small Direct Heat Exchanger)
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Input 2, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Small Direct Heat Exchanger), PrefabHash=-1332682164, PageLink=ThingItemKitSmallDirectHeatExchanger

---

## Small Flag

- **Key:** ThingStructureFlagSmall
- **Prefab Name:** StructureFlagSmall
- **Prefab Hash:** -1529819532
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Small Flag)
**Constructed Things:**
  - NameOfThing=Kit (Small Flag), PrefabHash=2011191088, PageLink=ThingItemFlagSmall

---

## Small Hangar Door

1 x 1 modular door piece for building hangar doors.

- **Key:** ThingStructureAirlockGate
- **Prefab Name:** StructureAirlockGate
- **Prefab Hash:** 1736080881
- **Base Power Draw:** 25 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Hangar Door)
**Mode Options:**
  - LogicName=Operate, LogicAccessTypes=0
  - LogicName=Logic, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Hangar Door), PrefabHash=682546947, PageLink=ThingItemKitAirlockGate

---

## Small Satellite Dish

This small communications unit can be used to communicate with nearby trade vessels. When connected to a Computer (Modern) containing a Communications Motherboard motherboard, a Landingpad Center, and a Vending Machine, this allows Stationeers to contact traders. Adjust its horizontal and vertical attributes either directly or through logic.

- **Key:** ThingStructureSmallSatelliteDish
- **Prefab Name:** StructureSmallSatelliteDish
- **Prefab Hash:** -2138748650
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Small Satellite Dish)
  - Description=Welding Torch 1 x Iron Sheets
  - Description=1 x Cable Coil
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Power Input, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Small Satellite Dish), PrefabHash=1960952220, PageLink=ThingItemKitSmallSatelliteDish

---

## Small Table (Thick Single)

- **Key:** ThingStructureSmallTableThickSingle
- **Prefab Name:** StructureSmallTableThickSingle
- **Prefab Hash:** -291862981
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Tables)
**Constructed Things:**
  - NameOfThing=Kit (Tables), PrefabHash=-1361598922, PageLink=ThingItemKitTables

---

## Small Tank

- **Key:** ThingStructureTankSmallInLine
- **Prefab Name:** StructureTankSmallInLine
- **Prefab Hash:** -1474141050
- **Volume:** 6000L
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Tank)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Tank), PrefabHash=771439840, PageLink=ThingItemKitTank

---

## Smelting

Once you have ore, you need to turn it into ingots so you can use their reagents. Smelting will often produce gases. This occurs in either the Arc Furnace (for simple recipes) and the Furnace for more complicated Alloys, and finally the Advanced Furnace for very complicated Superalloys. For the complex alloys, you will need to achieve mixtures at perfect ratios, Temperature, and Pressure.

- **Key:** SmeltingPage

---

## Solar Control

Adding a solar control board to a Console lets you manually control the horizontal and vertical angles of any connected Solar Panel.

- **Key:** ThingCircuitboardSolarControl
- **Prefab Name:** CircuitboardSolarControl
- **Prefab Hash:** 2020180320
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 393 K (120oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 100 x Energy + 5 x Gold (from Ingot (Gold)) + 5 x Copper (from Ingot (Copper))


---

## Solar Panel

Sinotai's standard solar panels are used for generating power from sunlight. They can be connected to Logic systems, in order to track sunlight, but their reduced during storms and when damaged. You can repair these using some trusty Duct Tape.

- **Key:** ThingStructureSolarPanel
- **Prefab Name:** StructureSolarPanel
- **Prefab Hash:** -2045627372
- **Power Generation:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Solar Panel)
  - Description=1 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel), PrefabHash=-1924492105, PageLink=ThingItemKitSolarPanel

---

## Solar Panel (1x5)

- **Key:** ThingStructureSolarPanel1x5Single
- **Prefab Name:** StructureSolarPanel1x5Single
- **Prefab Hash:** -295209029
- **Power Generation:** 2.75 kW
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=4 x Kit (Solar Panel)
  - Description=2 x Steel Sheets
  - Description=4 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel), PrefabHash=-1924492105, PageLink=ThingItemKitSolarPanel

---

## Solar Panel (Angled)

Sinotai basic solar panels generate power from sunlight, sitting at 45 degrees to the ground. Their efficiency is reduced during storms and when damaged. You can repair these using some trusty Duct Tape.

- **Key:** ThingStructureSolarPanel45
- **Prefab Name:** StructureSolarPanel45
- **Prefab Hash:** -1554349863
- **Power Generation:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Solar Panel Basic)
  - Description=1 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel Basic), PrefabHash=844961456, PageLink=ThingItemKitSolarPanelBasic

---

## Solar Panel (Dual 1x5)

- **Key:** ThingStructureSolarPanel1x5
- **Prefab Name:** StructureSolarPanel1x5
- **Prefab Hash:** 939649277
- **Power Generation:** 2.75 kW
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=4 x Kit (Solar Panel)
  - Description=2 x Steel Sheets
  - Description=4 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel), PrefabHash=-1924492105, PageLink=ThingItemKitSolarPanel

---

## Solar Panel (Dual)

Sinotai dual solar panels are used for generating power from sunlight, with dedicated data and power ports. They can be connected to {Logic systems, in order to track sunlight, but their efficiency is reduced during storms and when damaged. You can repair these using some trusty Duct Tape.

- **Key:** ThingStructureSolarPanelDual
- **Prefab Name:** StructureSolarPanelDual
- **Prefab Hash:** -539224550
- **Power Generation:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Solar Panel)
  - Description=1 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel), PrefabHash=-1924492105, PageLink=ThingItemKitSolarPanel

---

## Solar Panel (Flat)

Sinotai basic solar panels generate power from sunlight. They lie flat to the ground, and their efficiency is reduced during storms and when damaged. You can repair these using some trusty Duct Tape.

- **Key:** ThingStructureSolarPanelFlat
- **Prefab Name:** StructureSolarPanelFlat
- **Prefab Hash:** 1968102968
- **Power Generation:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Solar Panel Basic)
  - Description=1 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel Basic), PrefabHash=844961456, PageLink=ThingItemKitSolarPanelBasic

---

## Solar Panel (Heavy 1x5)

- **Key:** ThingStructureSolarPanel1x5ReinforcedSingle
- **Prefab Name:** StructureSolarPanel1x5ReinforcedSingle
- **Prefab Hash:** -2049226859
- **Power Generation:** 2.75 kW
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=4 x Kit (Solar Panel Heavy)
  - Description=10 x Steel Sheets
  - Description=10 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel Heavy), PrefabHash=-364868685, PageLink=ThingItemKitSolarPanelReinforced

---

## Solar Panel (Heavy Angled)

This solar panel is resistant to storm damage.

- **Key:** ThingStructureSolarPanel45Reinforced
- **Prefab Name:** StructureSolarPanel45Reinforced
- **Prefab Hash:** 930865127
- **Power Generation:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Solar Panel Basic Heavy)
  - Description=Welding Torch 5 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel Basic Heavy), PrefabHash=-528695432, PageLink=ThingItemKitSolarPanelBasicReinforced

---

## Solar Panel (Heavy Dual 1x5)

- **Key:** ThingStructureSolarPanel1x5Reinforced
- **Prefab Name:** StructureSolarPanel1x5Reinforced
- **Prefab Hash:** 1945473703
- **Power Generation:** 2.75 kW
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=4 x Kit (Solar Panel Heavy)
  - Description=10 x Steel Sheets
  - Description=10 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel Heavy), PrefabHash=-364868685, PageLink=ThingItemKitSolarPanelReinforced

---

## Solar Panel (Heavy Dual)

This solar panel is resistant to storm damage.

- **Key:** ThingStructureSolarPanelDualReinforced
- **Prefab Name:** StructureSolarPanelDualReinforced
- **Prefab Hash:** -1545574413
- **Power Generation:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Solar Panel Heavy)
  - Description=Welding Torch 5 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel Heavy), PrefabHash=-364868685, PageLink=ThingItemKitSolarPanelReinforced

---

## Solar Panel (Heavy Flat)

This solar panel is resistant to storm damage.

- **Key:** ThingStructureSolarPanelFlatReinforced
- **Prefab Name:** StructureSolarPanelFlatReinforced
- **Prefab Hash:** 1697196770
- **Power Generation:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Solar Panel Basic Heavy)
  - Description=Welding Torch 5 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel Basic Heavy), PrefabHash=-528695432, PageLink=ThingItemKitSolarPanelBasicReinforced

---

## Solar Panel (Heavy)

This solar panel is resistant to storm damage.

- **Key:** ThingStructureSolarPanelReinforced
- **Prefab Name:** StructureSolarPanelReinforced
- **Prefab Hash:** -934345724
- **Power Generation:** 500 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Solar Panel Heavy)
  - Description=Welding Torch 5 x Glass Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Solar Panel Heavy), PrefabHash=-364868685, PageLink=ThingItemKitSolarPanelReinforced

---

## Solder

- **Key:** ReagentSolder
- **Reagents Type:** Solder
**Found In Ore:**
  - NameOfThing=Ingot (Solder), QuantityOfThing=1

---

## Solid Fuel (Hydrocarbon)

- **Key:** ThingItemSolidFuel
- **Prefab Name:** ItemSolidFuel
- **Prefab Hash:** -365253871
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 500
- **Paintable:** No
- **Flashpoint:** 323 K (50oC)
- **Auto Ignition:** 373 K (100oC)
**Build Recipe:**
  - Printer: Advanced Furnace / Furnace
    - 1 Methane + 1 Hydrocarbon (from Ore (Coal)) | Temp: 950 K (677oC) to 100 kK (99726oC) | Pressure: 1 MPa to 100 MPa Requires a pure gas mixture of only the listed types

**Used In:**
  - NameOfThing=Autolathe, PrefabHash=336213101, PageLink=ThingStructureAutolathe
  - NameOfThing=Electronics Printer, PrefabHash=1307165496, PageLink=ThingStructureElectronicsPrinter
  - NameOfThing=Hydraulic Pipe Bender, PrefabHash=-1888248335, PageLink=ThingStructureHydraulicPipeBender
  - NameOfThing=Rocket Manufactory, PrefabHash=1781051034, PageLink=ThingStructureRocketManufactory
  - NameOfThing=Security Printer, PrefabHash=-641491515, PageLink=ThingStructureSecurityPrinter
  - SubText=200 kW, SubValue=Energy, NameOfThing=Generator (Solid Fuel), PrefabHash=813146305, PageLink=ThingStructureSolidFuelGenerator
  - NameOfThing=Terraforming Manufactory, PrefabHash=1549873866, PageLink=ThingStructureTerraformingManufactory
  - NameOfThing=Tool Manufactory, PrefabHash=-465741100, PageLink=ThingStructureToolManufactory

---

## Sorter

No amount of automation is complete without some way of moving different items to different parts of a system. The Xigo A2B sorter can be programmed via a computer with a Sorter Motherboard to direct various items into different chute networks. Filtered items are always passed out the righthand side of the sorter, while non filtered items continue straight through.

- **Key:** ThingStructureSorter
- **Prefab Name:** StructureSorter
- **Prefab Hash:** -1009150565
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2
  - LogicName=Damage, LogicAccessTypes=0, 1, 2
  - LogicName=Class, LogicAccessTypes=0, 1, 2
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2
  - LogicName=SortingClass, LogicAccessTypes=0, 1, 2
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2
  - LogicName=FreeSlots, LogicAccessTypes=0, 1, 2
  - LogicName=TotalSlots, LogicAccessTypes=0, 1, 2
**Slots:**
  - SlotName=Import, SlotType=Import, SlotIndex=0
  - SlotName=Export, SlotType=Export, SlotIndex=1
  - SlotName=Export 2, SlotType=Export 2, SlotIndex=2
**Build States:**
  - Description=1 x Kit (Sorter)
**Mode Options:**
  - LogicName=Split, LogicAccessTypes=0
  - LogicName=Filter, LogicAccessTypes=1
  - LogicName=Logic, LogicAccessTypes=2
**Connections:**
  - LogicName=Chute Output 2, LogicAccessTypes=0
  - LogicName=Chute Input, LogicAccessTypes=1
  - LogicName=Chute Output, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Sorter), PrefabHash=969522478, PageLink=ThingItemKitSorter

---

## Sorter Motherboard

Motherboards are connected to Computer (Modern)s to perform various technical functions. The Norsec-designed K-cops 10-10 sorter motherboard permits Stationeers to control which items a Sorter does, and does not, permit to pass.

- **Key:** ThingMotherboardSorter
- **Prefab Name:** MotherboardSorter
- **Prefab Hash:** -1908268220
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 500 x Energy + 5 x Gold (from Ingot (Gold)) + 5 x Silver (from Ingot (Silver))


---

## Sound Cartridge Bass

- **Key:** ThingItemSoundCartridgeBass
- **Prefab Name:** ItemSoundCartridgeBass
- **Prefab Hash:** -1883441704
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 100 x Energy + 2 x Gold (from Ingot (Gold)) + 2 x Copper (from Ingot (Copper)) + 2 x Silicon (from Ingot (Silicon))


---

## Sound Cartridge Drums

- **Key:** ThingItemSoundCartridgeDrums
- **Prefab Name:** ItemSoundCartridgeDrums
- **Prefab Hash:** -1901500508
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 100 x Energy + 2 x Gold (from Ingot (Gold)) + 2 x Copper (from Ingot (Copper)) + 2 x Silicon (from Ingot (Silicon))


---

## Sound Cartridge Leads

- **Key:** ThingItemSoundCartridgeLeads
- **Prefab Name:** ItemSoundCartridgeLeads
- **Prefab Hash:** -1174735962
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 100 x Energy + 2 x Gold (from Ingot (Gold)) + 2 x Copper (from Ingot (Copper)) + 2 x Silicon (from Ingot (Silicon))


---

## Sound Cartridge Synth

- **Key:** ThingItemSoundCartridgeSynth
- **Prefab Name:** ItemSoundCartridgeSynth
- **Prefab Hash:** -1971419310
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 100 x Energy + 2 x Gold (from Ingot (Gold)) + 2 x Copper (from Ingot (Copper)) + 2 x Silicon (from Ingot (Silicon))


---

## Soy

- **Key:** ReagentSoy
- **Reagents Type:** Soy
**Found In Ore:**
  - NameOfThing=Cooked Soybean, QuantityOfThing=1
  - NameOfThing=Soybean, QuantityOfThing=1

---

## Soy Oil

- **Key:** ThingItemSoyOil
- **Prefab Name:** ItemSoyOil
- **Prefab Hash:** 1387403148
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 10
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Steps:**
  - PrinterName=Reagent Processor, TierName=Tier One, Description=Soybean , PageLink=ThingApplianceReagentProcessor
**Used In:**
  - NameOfThing=Chemistry Station, PrefabHash=1365789392, PageLink=ThingApplianceChemistryStation
  - NameOfThing=Microwave, PrefabHash=-1136173965, PageLink=ThingApplianceMicrowave
  - NameOfThing=Basic Packaging Machine, PrefabHash=-749191906, PageLink=ThingAppliancePackagingMachine
  - NameOfThing=Advanced Packaging Machine, PrefabHash=-463037670, PageLink=ThingStructureAdvancedPackagingMachine
  - NameOfThing=Automated Oven, PrefabHash=-1672404896, PageLink=ThingStructureAutomatedOven

---

## Soybean

Soybeans grow at a moderate rate, but require atmospheric Nitrogen to grow. Its main use is to create Soy Oil

- **Key:** ThingItemSoybean
- **Prefab Name:** ItemSoybean
- **Prefab Hash:** 1924673028
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 5
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Growth Time:** 1h 0min 1s
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Constructed From Kits:**
  - NameOfThing=Soybean Seeds, PrefabHash=1783004244, PageLink=ThingSeedBag_Soybean
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=6 mol
  - NameOfThing=Polluted Water, QuantityOfThing=0.3 mol
**Used In:**
  - NameOfThing=Microwave, PrefabHash=-1136173965, PageLink=ThingApplianceMicrowave
  - NameOfThing=Reagent Processor, PrefabHash=1260918085, PageLink=ThingApplianceReagentProcessor
  - NameOfThing=Automated Oven, PrefabHash=-1672404896, PageLink=ThingStructureAutomatedOven
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Soybean Seeds

Grow some Soybean.

- **Key:** ThingSeedBag_Soybean
- **Prefab Name:** SeedBag_Soybean
- **Prefab Hash:** 1783004244
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

## Space Helmet

The basic space helmet insulates Stationeers against everything from hard vacuum to weird cooking smells. Providing a pressure-controlled, breathable atmosphere, it comes with a built-in light powered by your Eva Suit Battery Cell (Small). It also incorporates a lock/unlock feature to avoid accidental opening, as well as a flush function to expel and replace the internal atmosphere. If damaged, use Duct Tape to fix it, or paint it any color you like using the Paint Mixer.

- **Key:** ThingItemSpaceHelmet
- **Prefab Name:** ItemSpaceHelmet
- **Prefab Hash:** 714830451
- **Volume:** 3L
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 483 K (210oC)
- **Auto Ignition:** 623 K (350oC)
**Build Recipe:**
  - Printer: Autolathe (Tier One)
    - 500 x Energy + 2 x Gold (from Ingot (Gold)) + 2 x Copper (from Ingot (Copper))
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 2 x Gold (from Ingot (Gold)) + 2 x Copper (from Ingot (Copper))


---

## Space Ice

- **Key:** ThingItemSpaceIce
- **Prefab Name:** ItemSpaceIce
- **Prefab Hash:** 675686937
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Freeze Temperature:** 1 K (-272 oC))
- **Flashpoint:** 273 K (0oC)
**Used In:**
  - NameOfThing=Advanced Furnace, PrefabHash=545937711, PageLink=ThingStructureAdvancedFurnace
  - NameOfThing=Furnace, PrefabHash=1947944864, PageLink=ThingStructureFurnace
  - NameOfThing=Industrial Burner, PrefabHash=1493870235, PageLink=ThingStructureIndustrialBurner

---

## Spacepack

The basic CHAC spacepack isn't 'technically' a jetpack, it's a gas thruster. It can be powered by any gas, so long as the internal pressure of the canister is higher than the ambient external pressure. If the external pressure is greater, the spacepack will not function. Indispensable for building, mining and general movement, it has ten storage slots and lets Stationeers fly at 3m/s, compared to the more powerful Jetpack Basic or Hardsuit Jetpack. Adjusting the thrust value alters your rate of acceleration, while activating the stablizer causes the spacepack to hover when a given height is reached. USE: 'J' to activate; 'space' to fly up; 'left ctrl' to descend; and 'WASD' to move.

- **Key:** ThingItemSpacepack
- **Prefab Name:** ItemSpacepack
- **Prefab Hash:** -1260618380
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=Damage, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=Pressure, LogicAccessTypes=0
  - LogicName=Temperature, LogicAccessTypes=0
  - LogicName=Class, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9
**Slots:**
  - SlotName=Propellant, SlotType=Propellant, SlotIndex=0
  - SlotName=None, SlotType=None, SlotIndex=1
  - SlotName=None, SlotType=None, SlotIndex=2
  - SlotName=None, SlotType=None, SlotIndex=3
  - SlotName=None, SlotType=None, SlotIndex=4
  - SlotName=None, SlotType=None, SlotIndex=5
  - SlotName=None, SlotType=None, SlotIndex=6
  - SlotName=None, SlotType=None, SlotIndex=7
  - SlotName=None, SlotType=None, SlotIndex=8
  - SlotName=None, SlotType=None, SlotIndex=9
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 5 x Iron (from Ingot (Iron)) + 2 x Copper (from Ingot (Copper))


---

## Spotlight

It’s a spotlight... bright, focused, and it cuts through the dark. Connect it to logic, and it becomes a searchlight, sweeping across your perimeter. Adjustable speed - set Mode from 0-10.

- **Key:** ThingStructureSpotlight
- **Prefab Name:** StructureSpotlight
- **Prefab Hash:** 1668317094
- **Base Power Draw:** 80 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Spotlight)
**Mode Options:**
  - LogicName=Mode0, LogicAccessTypes=0
  - LogicName=Mode1, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Spotlight), PrefabHash=-535822999, PageLink=ThingItemKitSpotlight

---

## Spray Gun

Use with Spray cans in the Spray Can to paint structures, cables and pipes. Much more efficient and faster than doing it with individual spray cans.

- **Key:** ThingItemSprayGun
- **Prefab Name:** ItemSprayGun
- **Prefab Hash:** 1289723966
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Auto Ignition:** 523 K (250oC)
**Slots:**
  - SlotName=Spray Can, SlotType=Spray Can, SlotIndex=0
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 2000 x Energy + 10 x Steel (from Ingot (Steel)) + 5 x Invar (from Ingot (Invar)) + 10 x Silicon (from Ingot (Silicon))


---

## Spray Paint (Black)

Black spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanBlack
- **Prefab Name:** ItemSprayCanBlack
- **Prefab Hash:** -688107795
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Blue)

Blue spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanBlue
- **Prefab Name:** ItemSprayCanBlue
- **Prefab Hash:** -498464883
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Bronze)

Metallic bronze spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanMetallicBronze
- **Prefab Name:** ItemSprayCanMetallicBronze
- **Prefab Hash:** 1325336924
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Brown)

Brown spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanBrown
- **Prefab Name:** ItemSprayCanBrown
- **Prefab Hash:** 845176977
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Gold)

Metallic gold spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanMetallicGold
- **Prefab Name:** ItemSprayCanMetallicGold
- **Prefab Hash:** -746587514
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Green)

Green spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanGreen
- **Prefab Name:** ItemSprayCanGreen
- **Prefab Hash:** -1880941852
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Grey)

Grey spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanGrey
- **Prefab Name:** ItemSprayCanGrey
- **Prefab Hash:** -1645266981
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Khaki)

Khaki spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanKhaki
- **Prefab Name:** ItemSprayCanKhaki
- **Prefab Hash:** 1918456047
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Obsidian)

Metallic obsidian spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanMetallicObsidian
- **Prefab Name:** ItemSprayCanMetallicObsidian
- **Prefab Hash:** 2077535842
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Orange)

Orange spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanOrange
- **Prefab Name:** ItemSprayCanOrange
- **Prefab Hash:** -158007629
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Pink)

Pink spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanPink
- **Prefab Name:** ItemSprayCanPink
- **Prefab Hash:** 1344257263
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Purple)

Purple spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanPurple
- **Prefab Name:** ItemSprayCanPurple
- **Prefab Hash:** 30686509
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Red)

Red spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanRed
- **Prefab Name:** ItemSprayCanRed
- **Prefab Hash:** 1514393921
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Silver)

Metallic silver spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanMetallicSilver
- **Prefab Name:** ItemSprayCanMetallicSilver
- **Prefab Hash:** -548624242
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (White)

White spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanWhite
- **Prefab Name:** ItemSprayCanWhite
- **Prefab Hash:** 498481505
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Spray Paint (Yellow)

Yellow spray paint. Using it with a spray gun will extend the usage greatly.

- **Key:** ThingItemSprayCanYellow
- **Prefab Name:** ItemSprayCanYellow
- **Prefab Hash:** 995468116
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 1 x Iron (from Ingot (Iron))


---

## Stacker

A stacker is an important part of any automated chute network. The Xigo ProKompile can be set manually or via logic, to make sure items passing through the stacker are maximized for your storage needs. The ProKompile can stack a wide variety of things such as ingots, as well as splitting stacks into appropriate sizes as needed.

- **Key:** ThingStructureStacker
- **Prefab Name:** StructureStacker
- **Prefab Hash:** -2020231820
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2
  - LogicName=Damage, LogicAccessTypes=0, 1, 2
  - LogicName=Class, LogicAccessTypes=0, 1, 2
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2
  - LogicName=SortingClass, LogicAccessTypes=0, 1, 2
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2
  - LogicName=FreeSlots, LogicAccessTypes=0, 1, 2
  - LogicName=TotalSlots, LogicAccessTypes=0, 1, 2
**Slots:**
  - SlotName=Import, SlotType=Import, SlotIndex=0
  - SlotName=Export, SlotType=Export, SlotIndex=1
  - SlotName=Processing, SlotType=Processing, SlotIndex=2
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

## Stacker

A stacker is an important part of any automated chute network. The Xigo ProKompile can be set manually or via logic, to make sure items passing through the stacker are maximized for your storage needs. The reversed stacker has power and data on the opposite side. The ProKompile can stack a wide variety of things such as ingots, as well as splitting stacks into appropriate sizes as needed.

- **Key:** ThingStructureStackerReverse
- **Prefab Name:** StructureStackerReverse
- **Prefab Hash:** 1585641623
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2
  - LogicName=Damage, LogicAccessTypes=0, 1, 2
  - LogicName=Class, LogicAccessTypes=0, 1, 2
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2
  - LogicName=SortingClass, LogicAccessTypes=0, 1, 2
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2
  - LogicName=FreeSlots, LogicAccessTypes=0, 1, 2
  - LogicName=TotalSlots, LogicAccessTypes=0, 1, 2
**Slots:**
  - SlotName=Import, SlotType=Import, SlotIndex=0
  - SlotName=Export, SlotType=Export, SlotIndex=1
  - SlotName=Processing, SlotType=Processing, SlotIndex=2
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

## Stairs

- **Key:** ThingStructureStairs4x2
- **Prefab Name:** StructureStairs4x2
- **Prefab Hash:** 1405018945
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Stairs)
**Constructed Things:**
  - NameOfThing=Kit (Stairs), PrefabHash=170878959, PageLink=ThingItemKitStairs

---

## Stairs with Rail (Left)

- **Key:** ThingStructureStairs4x2RailL
- **Prefab Name:** StructureStairs4x2RailL
- **Prefab Hash:** 155214029
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Stairs)
**Constructed Things:**
  - NameOfThing=Kit (Stairs), PrefabHash=170878959, PageLink=ThingItemKitStairs

---

## Stairs with Rail (Right)

- **Key:** ThingStructureStairs4x2RailR
- **Prefab Name:** StructureStairs4x2RailR
- **Prefab Hash:** -212902482
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Stairs)
**Constructed Things:**
  - NameOfThing=Kit (Stairs), PrefabHash=170878959, PageLink=ThingItemKitStairs

---

## Stairs with Rails

- **Key:** ThingStructureStairs4x2Rails
- **Prefab Name:** StructureStairs4x2Rails
- **Prefab Hash:** -1088008720
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Stairs)
**Constructed Things:**
  - NameOfThing=Kit (Stairs), PrefabHash=170878959, PageLink=ThingItemKitStairs

---

## Stairwell (Back Left)

- **Key:** ThingStructureStairwellBackLeft
- **Prefab Name:** StructureStairwellBackLeft
- **Prefab Hash:** 505924160
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Stairwell)
  - Description=Welding Torch 1 x Steel Frames
  - Description=Screwdriver
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Stairwell), PrefabHash=-1868555784, PageLink=ThingItemKitStairwell

---

## Stairwell (Back Passthrough)

- **Key:** ThingStructureStairwellBackPassthrough
- **Prefab Name:** StructureStairwellBackPassthrough
- **Prefab Hash:** -862048392
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Stairwell)
  - Description=Welding Torch 1 x Steel Frames
  - Description=Screwdriver
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Stairwell), PrefabHash=-1868555784, PageLink=ThingItemKitStairwell

---

## Stairwell (Back Right)

- **Key:** ThingStructureStairwellBackRight
- **Prefab Name:** StructureStairwellBackRight
- **Prefab Hash:** -2128896573
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Stairwell)
  - Description=Welding Torch 1 x Steel Frames
  - Description=Screwdriver
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Stairwell), PrefabHash=-1868555784, PageLink=ThingItemKitStairwell

---

## Stairwell (Front Left)

- **Key:** ThingStructureStairwellFrontLeft
- **Prefab Name:** StructureStairwellFrontLeft
- **Prefab Hash:** -37454456
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Stairwell)
  - Description=Welding Torch 1 x Steel Frames
  - Description=Screwdriver
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Stairwell), PrefabHash=-1868555784, PageLink=ThingItemKitStairwell

---

## Stairwell (Front Passthrough)

- **Key:** ThingStructureStairwellFrontPassthrough
- **Prefab Name:** StructureStairwellFrontPassthrough
- **Prefab Hash:** -1625452928
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Stairwell)
  - Description=Welding Torch 1 x Steel Frames
  - Description=Screwdriver
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Stairwell), PrefabHash=-1868555784, PageLink=ThingItemKitStairwell

---

## Stairwell (Front Right)

- **Key:** ThingStructureStairwellFrontRight
- **Prefab Name:** StructureStairwellFrontRight
- **Prefab Hash:** 340210934
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Stairwell)
  - Description=Welding Torch 1 x Steel Frames
  - Description=Screwdriver
  - Description=Welding Torch 1 x Steel Sheets
**Constructed Things:**
  - NameOfThing=Kit (Stairwell), PrefabHash=-1868555784, PageLink=ThingItemKitStairwell

---


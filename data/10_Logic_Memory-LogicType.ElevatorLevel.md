# Logic Memory - LogicType.ElevatorLevel

## Logic Memory

- **Key:** ThingStructureLogicMemory
- **Prefab Name:** StructureLogicMemory
- **Prefab Hash:** -851746783
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic Memory)
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Logic Memory), PrefabHash=-2098214189, PageLink=ThingItemKitLogicMemory

---

## Logic Min/Max

- **Key:** ThingStructureLogicMinMax
- **Prefab Name:** StructureLogicMinMax
- **Prefab Hash:** 929022276
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic Processor)
**Mode Options:**
  - LogicName=Greater, LogicAccessTypes=0
  - LogicName=Less, LogicAccessTypes=1
**Connections:**
  - LogicName=Data Input, LogicAccessTypes=0
  - LogicName=Data Input, LogicAccessTypes=1
  - LogicName=Data Output, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Logic Processor), PrefabHash=220644373, PageLink=ThingItemKitLogicProcessor

---

## Logic Mirror

- **Key:** ThingStructureLogicMirror
- **Prefab Name:** StructureLogicMirror
- **Prefab Hash:** 2096189278
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

## Logic Motherboard

Motherboards are connected to Computer (Modern)s to perform various technical functions. The Norsec-designed K-cops logic motherboard allows Stationeers to set variables and actions on specific logic-controlled items.

- **Key:** ThingMotherboardLogic
- **Prefab Name:** MotherboardLogic
- **Prefab Hash:** 502555944
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Steps:**
  - PrinterName=Electronics Printer, TierName=Tier One, Description=500 x Energy 5 x Gold from Ingot (Gold) 5 x Copper from Ingot (Copper) , PageLink=ThingStructureElectronicsPrinter

---

## Logic Reader

- **Key:** ThingStructureLogicReader
- **Prefab Name:** StructureLogicReader
- **Prefab Hash:** -345383640
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

## Logic Rocket Downlink

- **Key:** ThingStructureLogicRocketDownlink
- **Prefab Name:** StructureLogicRocketDownlink
- **Prefab Hash:** 876108549
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Rocket Datalink)
  - Description=4 x Cable Coil
  - Description=Screwdriver 2 x Electronic Parts
**Connections:**
  - LogicName=Power and Data Input, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Kit (Rocket Datalink), PrefabHash=-1256996603, PageLink=ThingItemKitRocketDatalink

---

## Logic Select

- **Key:** ThingStructureLogicSelect
- **Prefab Name:** StructureLogicSelect
- **Prefab Hash:** 1822736084
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic Processor)
**Mode Options:**
  - LogicName=Equals, LogicAccessTypes=0
  - LogicName=Greater, LogicAccessTypes=1
  - LogicName=Less, LogicAccessTypes=2
  - LogicName=NotEquals, LogicAccessTypes=3
**Connections:**
  - LogicName=Data Input, LogicAccessTypes=0
  - LogicName=Data Input, LogicAccessTypes=1
  - LogicName=Data Output, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Logic Processor), PrefabHash=220644373, PageLink=ThingItemKitLogicProcessor

---

## Logic Sorter

Contains an Internal Memory which is assessed to check whether something should be sorted. When an item is in the Import Slot, the stack is checked and if result is true the thing is moved to the Export 2 slot, otherwise it is moved to the Export slot. The Mode is used in how the stack is assessed, by default the mode is ALL, so every instruction in the stack would need to return true.

- **Key:** ThingStructureLogicSorter
- **Prefab Name:** StructureLogicSorter
- **Prefab Hash:** 873418029
- **Base Power Draw:** 5 W
- **Memory Size:** 256 B
- **Memory Access:** Read Write
- **Has Memory:** true
- **Paintable:** Yes
**Logic Types:**
  - Text=SorterInstruction.FilterPrefabHashEquals OP_CODE: 1, Index=1, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-39 | PREFAB_HASH | INT_32 | | 40-63 | UNUSED | 24 |
  - Text=SorterInstruction.FilterPrefabHashNotEquals OP_CODE: 2, Index=2, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-39 | PREFAB_HASH | INT_32 | | 40-63 | UNUSED | 24 |
  - Text=SorterInstruction.FilterSortingClassCompare OP_CODE: 3, Index=3, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | CONDITION_OPERATION | BYTE_8 | | 16-31 | SORTING_CLASS | USHORT_16 | | 32-63 | UNUSED | 32 |
  - Text=SorterInstruction.FilterSlotTypeCompare OP_CODE: 4, Index=4, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | CONDITION_OPERATION | BYTE_8 | | 16-31 | SLOT_TYPE | USHORT_16 | | 32-63 | UNUSED | 32 |
  - Text=SorterInstruction.FilterQuantityCompare OP_CODE: 5, Index=5, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | CONDITION_OPERATION | BYTE_8 | | 16-31 | QUANTITY | USHORT_16 | | 32-63 | UNUSED | 32 |
  - Text=SorterInstruction.LimitNextExecutionByCount OP_CODE: 6, Index=6, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-39 | COUNT | UINT_32 | | 40-63 | UNUSED | 24 |
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
  - LogicName=All, LogicAccessTypes=0
  - LogicName=Any, LogicAccessTypes=1
  - LogicName=None, LogicAccessTypes=2
**Connections:**
  - LogicName=Chute Output 2, LogicAccessTypes=0
  - LogicName=Chute Input, LogicAccessTypes=1
  - LogicName=Chute Output, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Sorter), PrefabHash=969522478, PageLink=ThingItemKitSorter

---

## Logic Step Sequencer

The ODA does not approve of soundtracks or other distractions. As such, Stationeers have had to create their own musical accompaniment to the demanding labor of building and maintaining off-world infrastructure. Central to this pastime is the step sequencer, which allows Stationeers to sequence short musical patterns or loops. DIY MUSIC - GETTING STARTED 1: Connect 8 Device Step Units to your step sequencer via the data port on the left hand side. 2: Label each step unit, then assign step units 1 through 8 on the step sequencer using the screwdriver. 3: Select the output speaker (eg Passive Speaker) where the sequencer will play the sounds. This needs to be connected to the logic network on the right hand side of the sequencer. 4: Place a Stop Watch and use a Logic Reader and Logic Writer to write the time to the time variable on the sequencer. 5: Set the BPM on the sequencer using a Dial and a Logic Writer to write to the sequencer's BPM variable. A higher bpm will play the sequence faster. 6: Insert a sound cartridge of your choosing and select which variant of sound you wish to play by pushing the arrow buttons located above and below the sound cartridge slot. 7: Choose the pitch of the sounds to play by setting the dial on each of your 8 step units to the desired note. With drums, each note is a different drum sounds. You can trial your sounds by pushing the activate button on each step unit (with the sequencer inactive). 8: Get freaky with the Low frequency oscillator. 9: Finally, activate the sequencer, Vibeoneer.

- **Key:** ThingLogicStepSequencer8
- **Prefab Name:** LogicStepSequencer8
- **Prefab Hash:** 1531272458
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
  - SlotName=SoundCartridge, SlotType=SoundCartridge, SlotIndex=0
**Build States:**
  - Description=1 x Kit (Music Machines)
**Mode Options:**
  - LogicName=Whole Note, LogicAccessTypes=0
  - LogicName=Half Note, LogicAccessTypes=1
  - LogicName=Quarter Note, LogicAccessTypes=2
  - LogicName=Eighth Note, LogicAccessTypes=3
  - LogicName=Sixteenth Note, LogicAccessTypes=4
**Connections:**
  - LogicName=Data Input, LogicAccessTypes=0
  - LogicName=Data Input, LogicAccessTypes=1
  - LogicName=Power Input, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Music Machines), PrefabHash=-2038889137, PageLink=ThingItemKitMusicMachines

---

## Logic Transmitter

Connects to Logic Transmitter

- **Key:** ThingStructureLogicTransmitter
- **Prefab Name:** StructureLogicTransmitter
- **Prefab Hash:** -693235651
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic Transmitter)
**Mode Options:**
  - LogicName=Passive, LogicAccessTypes=0
  - LogicName=Active, LogicAccessTypes=1
**Connections:**
  - LogicName=Data Input, LogicAccessTypes=0
  - LogicName=Data Input, LogicAccessTypes=1
  - LogicName=Data Input, LogicAccessTypes=2
  - LogicName=Connection, LogicAccessTypes=3
**Constructed Things:**
  - NameOfThing=Kit (Logic Transmitter), PrefabHash=1005397063, PageLink=ThingItemKitLogicTransmitter

---

## Logic Units

- **Key:** LogicUnitPage

---

## Logic Uplink

- **Key:** ThingStructureLogicRocketUplink
- **Prefab Name:** StructureLogicRocketUplink
- **Prefab Hash:** 546002924
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Rocket Datalink)
  - Description=Screwdriver 2 x Cable Coil
  - Description=Screwdriver 2 x Electronic Parts
  - Description=Welding Torch 2 x Steel Sheets
**Connections:**
  - LogicName=Data Input, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Rocket Datalink), PrefabHash=-1256996603, PageLink=ThingItemKitRocketDatalink

---

## Logic Uplink (Compact)

- **Key:** ThingStructureLogicRocketUplinkCompact
- **Prefab Name:** StructureLogicRocketUplinkCompact
- **Prefab Hash:** -124589902
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Rocket Datalink)
  - Description=Screwdriver 2 x Cable Coil
  - Description=Screwdriver 2 x Electronic Parts
  - Description=Welding Torch 2 x Steel Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Power Input, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Rocket Datalink), PrefabHash=-1256996603, PageLink=ThingItemKitRocketDatalink

---

## Logic Writer

- **Key:** ThingStructureLogicWriter
- **Prefab Name:** StructureLogicWriter
- **Prefab Hash:** -1326019434
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

## Logic Writer Switch

- **Key:** ThingStructureLogicWriterSwitch
- **Prefab Name:** StructureLogicWriterSwitch
- **Prefab Hash:** -1321250424
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

## LogicSlotType.Charge

returns current energy charge the slot occupant is holding

- **Key:** LogicSlotTypeCharge

---

## LogicSlotType.ChargeRatio

returns current energy charge the slot occupant is holding as a ratio between 0 and 1 of its maximum

- **Key:** LogicSlotTypeChargeRatio

---

## LogicSlotType.Class

returns integer representing the class of object

- **Key:** LogicSlotTypeClass

---

## LogicSlotType.Damage

returns the damage state of the item in the slot

- **Key:** LogicSlotTypeDamage

---

## LogicSlotType.Efficiency

returns the growth efficiency of the plant in the slot

- **Key:** LogicSlotTypeEfficiency

---

## LogicSlotType.FilterType

No description available

- **Key:** LogicSlotTypeFilterType

---

## LogicSlotType.FreeSlots

The number of free slots available in this object.

- **Key:** LogicSlotTypeFreeSlots

---

## LogicSlotType.Growth

returns the current growth state of the plant in the slot

- **Key:** LogicSlotTypeGrowth

---

## LogicSlotType.HarvestedHash

No description available

- **Key:** LogicSlotTypeHarvestedHash

---

## LogicSlotType.Health

Returns the health of the plant in the slot

- **Key:** LogicSlotTypeHealth

---

## LogicSlotType.LineNumber

The line number of current execution for an integrated circuit running on this device. While this number can be written, use with caution

- **Key:** LogicSlotTypeLineNumber

---

## LogicSlotType.Lock

No description available

- **Key:** LogicSlotTypeLock

---

## LogicSlotType.Mature

returns 1 if the plant in this slot is mature, 0 when it isn't

- **Key:** LogicSlotTypeMature

---

## LogicSlotType.MaturityRatio

How far the plant is towards maturity represented as a fraction between 0 and 1, with 1 being mature and ready for harvest.

- **Key:** LogicSlotTypeMaturityRatio

---

## LogicSlotType.MaxQuantity

returns the max stack size of the item in the slot

- **Key:** LogicSlotTypeMaxQuantity

---

## LogicSlotType.Mode

No description available

- **Key:** LogicSlotTypeMode

---

## LogicSlotType.None

No description

- **Key:** LogicSlotTypeNone

---

## LogicSlotType.OccupantHash

returns the hash of the current occupant, the unique identifier of the thing

- **Key:** LogicSlotTypeOccupantHash

---

## LogicSlotType.Occupied

returns 0 when slot is not occupied, 1 when it is

- **Key:** LogicSlotTypeOccupied

---

## LogicSlotType.On

No description available

- **Key:** LogicSlotTypeOn

---

## LogicSlotType.Open

No description available

- **Key:** LogicSlotTypeOpen

---

## LogicSlotType.PrefabHash

returns the hash of the structure in the slot

- **Key:** LogicSlotTypePrefabHash

---

## LogicSlotType.Pressure

returns pressure of the slot occupants internal atmosphere

- **Key:** LogicSlotTypePressure

---

## LogicSlotType.PressureAir

returns pressure in the air tank of the jetpack in this slot

- **Key:** LogicSlotTypePressureAir

---

## LogicSlotType.PressureWaste

returns pressure in the waste tank of the jetpack in this slot

- **Key:** LogicSlotTypePressureWaste

---

## LogicSlotType.Quantity

returns the current quantity, such as stack size, of the item in the slot

- **Key:** LogicSlotTypeQuantity

---

## LogicSlotType.ReferenceId

Unique Reference Identifier for this object

- **Key:** LogicSlotTypeReferenceId

---

## LogicSlotType.Seeding

Whether a plant is seeding (ready to harvest seeds from). Returns 1 if seeding or 0 if not.

- **Key:** LogicSlotTypeSeeding

---

## LogicSlotType.SeedingRatio

How far the plant is towards seeding represented as a fraction between 0 and 1, with 1 being seeding and will supply seeds when harvested.

- **Key:** LogicSlotTypeSeedingRatio

---

## LogicSlotType.SortingClass

No description available

- **Key:** LogicSlotTypeSortingClass

---

## LogicSlotType.Temperature

returns temperature of the slot occupants internal atmosphere

- **Key:** LogicSlotTypeTemperature

---

## LogicSlotType.TotalSlots

The total number of slots available in this object.

- **Key:** LogicSlotTypeTotalSlots

---

## LogicSlotType.Volume

No description available

- **Key:** LogicSlotTypeVolume

---

## LogicTransmitHeaderTemplate

{0}

- **Key:** LogicTransmitHeaderTemplate

---

## LogicType.Acceleration

Change in velocity. Rockets that are deccelerating when landing will show this as negative value.

- **Key:** LogicTypeAcceleration

---

## LogicType.Activate

1 if device is activated (usually means running), otherwise 0

- **Key:** LogicTypeActivate

---

## LogicType.AirRelease

The current state of the air release system, for example AirRelease = 1 for a Hardsuit sets Air Release to On

- **Key:** LogicTypeAirRelease

---

## LogicType.AlignmentError

The angular discrepancy between the telescope's current orientation and the target. Indicates how 'off target' the telescope is. Returns NaN when no target.

- **Key:** LogicTypeAlignmentError

---

## LogicType.Altitude

The altitude that the rocket above the planet's surface. -1 if the rocket is in space.

- **Key:** LogicTypeAltitude

---

## LogicType.Apex

The lowest altitude that the rocket will reach before it starts travelling upwards again.

- **Key:** LogicTypeApex

---

## LogicType.AutoLand

Engages the automatic landing algorithm. The rocket will automatically throttle and turn on and off its engines to achieve a smooth landing.

- **Key:** LogicTypeAutoLand

---

## LogicType.AutoShutOff

Turns off all devices in the rocket upon reaching destination

- **Key:** LogicTypeAutoShutOff

---

## LogicType.BestContactFilter

Filters the satellite's auto selection of targets to a single reference ID.

- **Key:** LogicTypeBestContactFilter

---

## LogicType.Bpm

Bpm

- **Key:** LogicTypeBpm

---

## LogicType.BurnTimeRemaining

Estimated time in seconds until fuel is depleted. Calculated based on current fuel usage.

- **Key:** LogicTypeBurnTimeRemaining

---

## LogicType.CelestialHash

The current hash of the targeted celestial object.

- **Key:** LogicTypeCelestialHash

---

## LogicType.CelestialParentHash

The hash for the name of the parent the celestial is orbiting, 0 if there is no parent celestial.

- **Key:** LogicTypeCelestialParentHash

---

## LogicType.Channel0

Channel on a cable network which should be considered volatile

- **Key:** LogicTypeChannel0

---

## LogicType.Channel1

Channel on a cable network which should be considered volatile

- **Key:** LogicTypeChannel1

---

## LogicType.Channel2

Channel on a cable network which should be considered volatile

- **Key:** LogicTypeChannel2

---

## LogicType.Channel3

Channel on a cable network which should be considered volatile

- **Key:** LogicTypeChannel3

---

## LogicType.Channel4

Channel on a cable network which should be considered volatile

- **Key:** LogicTypeChannel4

---

## LogicType.Channel5

Channel on a cable network which should be considered volatile

- **Key:** LogicTypeChannel5

---

## LogicType.Channel6

Channel on a cable network which should be considered volatile

- **Key:** LogicTypeChannel6

---

## LogicType.Channel7

Channel on a cable network which should be considered volatile

- **Key:** LogicTypeChannel7

---

## LogicType.Charge

The current charge the device has

- **Key:** LogicTypeCharge

---

## LogicType.Chart

Progress status of Chart scan at the rocket's target Space Map Location. Returns a clamped normalised value. If Chart scan is not available returns -1.

- **Key:** LogicTypeChart

---

## LogicType.ChartedNavPoints

The number of charted NavPoints at the rocket's target Space Map Location.

- **Key:** LogicTypeChartedNavPoints

---

## LogicType.ClearMemory

When set to 1, clears the counter memory (e.g. ExportCount). Will set itself back to 0 when actioned

- **Key:** LogicTypeClearMemory

---

## LogicType.CollectableGoods

Gets the cost of fuel to return the rocket to your current world.

- **Key:** LogicTypeCollectableGoods

---

## LogicType.Color

Whether driven by concerns for clarity, safety or simple aesthetics, Stationeers have access to a small rainbow of colors for their constructions. These are the color setting for devices, represented as an integer. 0: Blue 1: Grey 2: Green 3: Orange 4: Red 5: Yellow 6: White 7: Black 8: Brown 9: Khaki 10: Pink 11: Purple It is an unwavering universal law that anything higher than 11 will be purple. The ODA is powerless to change this. Similarly, anything lower than 0 will be Blue.

- **Key:** LogicTypeColor

---

## LogicType.Combustion

The assess atmosphere is on fire. Returns 1 if atmosphere is on fire, 0 if not.

- **Key:** LogicTypeCombustion

---

## LogicType.CombustionInput

The assess atmosphere is on fire. Returns 1 if device's input network is on fire, 0 if not.

- **Key:** LogicTypeCombustionInput

---

## LogicType.CombustionInput2

The assess atmosphere is on fire. Returns 1 if device's Input2 network is on fire, 0 if not.

- **Key:** LogicTypeCombustionInput2

---

## LogicType.CombustionLimiter

Retards the rate of combustion inside the machine (range: 0-100), with 0 being the slowest rate of combustion and 100 being the fastest

- **Key:** LogicTypeCombustionLimiter

---

## LogicType.CombustionOutput

The assess atmosphere is on fire. Returns 1 if device's Output network is on fire, 0 if not.

- **Key:** LogicTypeCombustionOutput

---

## LogicType.CombustionOutput2

The assess atmosphere is on fire. Returns 1 if device's Output2 network is on fire, 0 if not.

- **Key:** LogicTypeCombustionOutput2

---

## LogicType.CompletionRatio

How complete the current production is for this device, between 0 and 1

- **Key:** LogicTypeCompletionRatio

---

## LogicType.ContactSlotIndex

The index of the slot in which the trader has spawned. This defines the class of the trader i.e. Utility, Small, Medium etc.

- **Key:** LogicTypeContactSlotIndex

---

## LogicType.ContactTypeId

The type id of the contact.

- **Key:** LogicTypeContactTypeId

---

## LogicType.CurrentCode

The Space Map Address of the rockets current Space Map Location

- **Key:** LogicTypeCurrentCode

---

## LogicType.CurrentNodeType

Returns the NodeType as an integer for the current location for a Rocket

- **Key:** LogicTypeCurrentNodeType

---

## LogicType.CurrentResearchPodType



- **Key:** LogicTypeCurrentResearchPodType

---

## LogicType.Density

The density of the rocket's target site's mine-able deposit.

- **Key:** LogicTypeDensity

---

## LogicType.DerivativeGain

The derivative gain of the PID controller. This value determines how much the controller responds to the rate of change of the error. A higher value can help dampen oscillations and improve stability, but may also lead to noise amplification.

- **Key:** LogicTypeDerivativeGain

---

## LogicType.DestinationCode

The Space Map Address of the rockets target Space Map Location

- **Key:** LogicTypeDestinationCode

---

## LogicType.Discover

Progress status of Discovery scan at the rocket's target Space Map Location. Returns a clamped normalised value. If Discovery scan is not available returns -1.

- **Key:** LogicTypeDiscover

---

## LogicType.Dispense

The device will dispense once, used in logic mode for export devices.

- **Key:** LogicTypeDispense

---

## LogicType.DispenseSlot

Set to the index of a stored item to dispense that specific item once. The device dispenses it then resets this back to -1. A value of -1 means idle.

- **Key:** LogicTypeDispenseSlot

---

## LogicType.DistanceAu

The current distance to the celestial object, measured in astronomical units.

- **Key:** LogicTypeDistanceAu

---

## LogicType.DistanceKm

The current distance to the celestial object, measured in kilometers.

- **Key:** LogicTypeDistanceKm

---

## LogicType.DrillCondition

The current condition of the drill head in this devices drill slot. Expressed as a ratio between 0 and 1.

- **Key:** LogicTypeDrillCondition

---

## LogicType.DryMass

The Mass in kilograms of the rocket excluding fuel. The more massive the rocket the more fuel will be required to move to a new location in space.

- **Key:** LogicTypeDryMass

---

## LogicType.Eccentricity

A measure of how elliptical (oval) an orbit is. Ranges from 0 (a perfect circle) to 1 (a parabolic trajectory).

- **Key:** LogicTypeEccentricity

---

## LogicType.ElevatorLevel

Level the elevator is currently at

- **Key:** LogicTypeElevatorLevel

---


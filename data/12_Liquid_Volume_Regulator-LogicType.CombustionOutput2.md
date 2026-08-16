# Liquid Volume Regulator - LogicType.CombustionOutput2

## Liquid Volume Regulator

Regulates the volume ratio of liquid in the output Liquid pipe. This is expressed as percentage where 100 is totally full and 0 is empty.

- **Key:** ThingStructureLiquidPressureRegulator
- **Prefab Name:** StructureLiquidPressureRegulator
- **Prefab Hash:** 482248766
- **Base Power Draw:** 100 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
**Build States:**
  - Description=1 x Kit (Liquid Regulator)
**Connections:**
| Name | Value |
|---|---|
| Pipe Liquid Input | 0 |
| Pipe Liquid Output | 1 |
| Connection | 2 |

**Constructed Things:**
  - NameOfThing=Kit (Liquid Regulator), PrefabHash=1951126161, PageLink=ThingItemKitLiquidRegulator

---

## Liquid Wall Cooler

- **Key:** ThingStructureWaterWallCooler
- **Prefab Name:** StructureWaterWallCooler
- **Prefab Hash:** -1369060582
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0 |
| OccupantHash | 0 |
| Quantity | 0 |
| Damage | 0 |
| Class | 0 |
| MaxQuantity | 0 |
| PrefabHash | 0 |
| SortingClass | 0 |
| ReferenceId | 0 |
| FreeSlots | 0 |
| TotalSlots | 0 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Data Disk | Data Disk | 0 |

**Build States:**
  - Description=1 x Kit (Liquid Wall Cooler)
**Connections:**
| Name | Value |
|---|---|
| Connection | 0 |
| Connection | 1 |

**Constructed Things:**
  - NameOfThing=Kit (Liquid Wall Cooler), PrefabHash=-1721846327, PageLink=ThingItemWaterWallCooler

---

## Loader

The Loader will take objects from its left slot and put them in the available slots of the object inserted in the right slot. The slots will be filled in order from first to last. If no available slot is found, the left slot object will be ejected. The right slot object will auto eject once full or if the level is pulled.

- **Key:** ThingStructurePacker
- **Prefab Name:** StructurePacker
- **Prefab Hash:** 94539235
- **Base Power Draw:** 50 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0, 1, 2 |
| OccupantHash | 0, 1, 2 |
| Quantity | 0, 1, 2 |
| Damage | 0, 1, 2 |
| Class | 0, 1, 2 |
| MaxQuantity | 0, 1, 2 |
| PrefabHash | 0, 1, 2 |
| SortingClass | 0, 1, 2 |
| ReferenceId | 0, 1, 2 |
| FreeSlots | 0, 1, 2 |
| TotalSlots | 0, 1, 2 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Payload | Payload | 0 |
| Recipient | Recipient | 1 |
| Export | Export | 2 |

**Build States:**
  - Description=2 x Kit (Stacker)
**Mode:**
| Name | Value |
|---|---|
| Auto | 0 |
| Logic | 1 |

**Connections:**
| Name | Value |
|---|---|
| Chute Input | 0 |
| Chute Input 2 | 1 |
| Chute Output | 2 |
| Connection | 3 |

**Constructed Things:**
  - NameOfThing=Kit (Stacker), PrefabHash=1013244511, PageLink=ThingItemKitStacker

---

## Locker

- **Key:** ThingStructureStorageLocker
- **Prefab Name:** StructureStorageLocker
- **Prefab Hash:** -793623899
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |
| OccupantHash | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |
| Quantity | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |
| Damage | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |
| Class | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |
| MaxQuantity | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |
| PrefabHash | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |
| SortingClass | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |
| ReferenceId | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |
| FreeSlots | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |
| TotalSlots | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| None | None | 0 |
| None | None | 1 |
| None | None | 2 |
| None | None | 3 |
| None | None | 4 |
| None | None | 5 |
| None | None | 6 |
| None | None | 7 |
| None | None | 8 |
| None | None | 9 |
| None | None | 10 |
| None | None | 11 |
| None | None | 12 |
| None | None | 13 |
| None | None | 14 |
| None | None | 15 |
| None | None | 16 |
| None | None | 17 |
| None | None | 18 |
| None | None | 19 |
| None | None | 20 |
| None | None | 21 |
| None | None | 22 |
| None | None | 23 |
| None | None | 24 |
| None | None | 25 |
| None | None | 26 |
| None | None | 27 |
| None | None | 28 |
| None | None | 29 |

**Build States:**
  - Description=2 x Kit (Locker)
**Constructed Things:**
  - NameOfThing=Kit (Locker), PrefabHash=882301399, PageLink=ThingItemKitLocker

---

## Locker (Small)

- **Key:** ThingStructureLockerSmall
- **Prefab Name:** StructureLockerSmall
- **Prefab Hash:** -647164662
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0, 1, 2, 3 |
| OccupantHash | 0, 1, 2, 3 |
| Quantity | 0, 1, 2, 3 |
| Damage | 0, 1, 2, 3 |
| Class | 0, 1, 2, 3 |
| MaxQuantity | 0, 1, 2, 3 |
| PrefabHash | 0, 1, 2, 3 |
| SortingClass | 0, 1, 2, 3 |
| ReferenceId | 0, 1, 2, 3 |
| FreeSlots | 0, 1, 2, 3 |
| TotalSlots | 0, 1, 2, 3 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| None | None | 0 |
| None | None | 1 |
| None | None | 2 |
| None | None | 3 |

**Build States:**
  - Description=1 x Kit (Locker)
**Constructed Things:**
  - NameOfThing=Kit (Locker), PrefabHash=882301399, PageLink=ThingItemKitLocker

---

## Logic Alarm

Sound and light beacon for emergencies.

- **Key:** ThingModularDeviceAlarm
- **Prefab Name:** ModularDeviceAlarm
- **Prefab Hash:** 1922318669
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Displays)
**Constructed Things:**
  - NameOfThing=Kit (Modular Console Displays), PrefabHash=210802104, PageLink=ThingItemKitModularConsoleDisplays

---

## Logic Button Round

A round button which sets Activate to 1 when pressed. Has an adjustable Color.

- **Key:** ThingModularDeviceRoundButton
- **Prefab Name:** ModularDeviceRoundButton
- **Prefab Hash:** 489382030
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Inputs)
**Constructed Things:**
  - NameOfThing=Kit (Modular Console Inputs), PrefabHash=1496399356, PageLink=ThingItemKitModularConsoleInputs

---

## Logic Button Square

A square button which sets Activate to 1 when pressed. Has an adjustable Color.

- **Key:** ThingModularDeviceSquareButton
- **Prefab Name:** ModularDeviceSquareButton
- **Prefab Hash:** 1462769197
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Inputs)
**Constructed Things:**
  - NameOfThing=Kit (Modular Console Inputs), PrefabHash=1496399356, PageLink=ThingItemKitModularConsoleInputs

---

## Logic Compare

- **Key:** ThingStructureLogicCompare
- **Prefab Name:** StructureLogicCompare
- **Prefab Hash:** -1489728908
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic Processor)
**Mode:**
| Name | Value |
|---|---|
| Equals | 0 |
| Greater | 1 |
| Less | 2 |
| NotEquals | 3 |

**Connections:**
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Input | 1 |
| Data Output | 2 |
| Connection | 3 |

**Constructed Things:**
  - NameOfThing=Kit (Logic Processor), PrefabHash=220644373, PageLink=ThingItemKitLogicProcessor

---

## Logic Dial

Allows adjusting Setting between 0 and Mode.

- **Key:** ThingModularDeviceDial
- **Prefab Name:** ModularDeviceDial
- **Prefab Hash:** 1465300791
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Inputs)
**Constructed Things:**
  - NameOfThing=Kit (Modular Console Inputs), PrefabHash=1496399356, PageLink=ThingItemKitModularConsoleInputs

---

## Logic Dial Small

Allows adjusting Setting between 0 and Mode.

- **Key:** ThingModularDeviceDialSmall
- **Prefab Name:** ModularDeviceDialSmall
- **Prefab Hash:** -1158984141
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Inputs)
**Constructed Things:**
  - NameOfThing=Kit (Modular Console Inputs), PrefabHash=1496399356, PageLink=ThingItemKitModularConsoleInputs

---

## Logic Gate

A logic device that performs a logical operation on one or more binary inputs that produces a single binary output. An input greater than zero is considered true for operations.

- **Key:** ThingStructureLogicGate
- **Prefab Name:** StructureLogicGate
- **Prefab Hash:** 1942143074
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic Processor)
**Mode:**
| Name | Value |
|---|---|
| AND | 0 |
| OR | 1 |
| XOR | 2 |
| NAND | 3 |
| NOR | 4 |
| XNOR | 5 |

**Connections:**
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Input | 1 |
| Data Output | 2 |
| Connection | 3 |

**Constructed Things:**
  - NameOfThing=Kit (Logic Processor), PrefabHash=220644373, PageLink=ThingItemKitLogicProcessor

---

## Logic Hash Generator

- **Key:** ThingStructureLogicHashGen
- **Prefab Name:** StructureLogicHashGen
- **Prefab Hash:** 2077593121
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic Memory)
**Connections:**
| Name | Value |
|---|---|
| Connection | 0 |
| Connection | 1 |

**Constructed Things:**
  - NameOfThing=Kit (Logic Memory), PrefabHash=-2098214189, PageLink=ThingItemKitLogicMemory

---

## Logic Math

- **Key:** ThingStructureLogicMath
- **Prefab Name:** StructureLogicMath
- **Prefab Hash:** 1657691323
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic Processor)
**Mode:**
| Name | Value |
|---|---|
| Add | 0 |
| Subtract | 1 |
| Multiply | 2 |
| Divide | 3 |
| Mod | 4 |
| Atan2 | 5 |
| Pow | 6 |
| Log | 7 |

**Connections:**
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Input | 1 |
| Data Output | 2 |
| Connection | 3 |

**Constructed Things:**
  - NameOfThing=Kit (Logic Processor), PrefabHash=220644373, PageLink=ThingItemKitLogicProcessor

---

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
| Name | Value |
|---|---|
| Connection | 0 |
| Connection | 1 |

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
**Mode:**
| Name | Value |
|---|---|
| Greater | 0 |
| Less | 1 |

**Connections:**
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Input | 1 |
| Data Output | 2 |
| Connection | 3 |

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
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Output | 1 |
| Connection | 2 |

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
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 500 x Energy + 5 x Gold (from Ingot (Gold)) + 5 x Copper (from Ingot (Copper))


---

## Logic Num Pad

A numeric input device. Sends pulses to Mode when pressing digit buttons. Can change the Setting to other numbers incl. decimals by clicking the screen. Has an adjustable Color

- **Key:** ThingModularDeviceNumpad
- **Prefab Name:** ModularDeviceNumpad
- **Prefab Hash:** -377257892
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Inputs)
**Mode:**
| Name | Value |
|---|---|
| Mode0 | 0 |
| Mode1 | 1 |

**Constructed Things:**
  - NameOfThing=Kit (Modular Console Inputs), PrefabHash=1496399356, PageLink=ThingItemKitModularConsoleInputs

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
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Output | 1 |
| Connection | 2 |

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
| Name | Value |
|---|---|
| Power and Data Input | 0 |

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
**Mode:**
| Name | Value |
|---|---|
| Equals | 0 |
| Greater | 1 |
| Less | 2 |
| NotEquals | 3 |

**Connections:**
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Input | 1 |
| Data Output | 2 |
| Connection | 3 |

**Constructed Things:**
  - NameOfThing=Kit (Logic Processor), PrefabHash=220644373, PageLink=ThingItemKitLogicProcessor

---

## Logic Slider

Drag the slider up and down to adjust the Setting between 0 and 1.

- **Key:** ThingModularDeviceSlider
- **Prefab Name:** ModularDeviceSlider
- **Prefab Hash:** 1070499908
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Inputs)
**Constructed Things:**
  - NameOfThing=Kit (Modular Console Inputs), PrefabHash=1496399356, PageLink=ThingItemKitModularConsoleInputs

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
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0, 1, 2 |
| OccupantHash | 0, 1, 2 |
| Quantity | 0, 1, 2 |
| Damage | 0, 1, 2 |
| Class | 0, 1, 2 |
| MaxQuantity | 0, 1, 2 |
| PrefabHash | 0, 1, 2 |
| SortingClass | 0, 1, 2 |
| ReferenceId | 0, 1, 2 |
| FreeSlots | 0, 1, 2 |
| TotalSlots | 0, 1, 2 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Import | Import | 0 |
| Export | Export | 1 |
| Export 2 | Export 2 | 2 |

**Build States:**
  - Description=1 x Kit (Sorter)
**Mode:**
| Name | Value |
|---|---|
| All | 0 |
| Any | 1 |
| None | 2 |

**Connections:**
| Name | Value |
|---|---|
| Chute Output 2 | 0 |
| Chute Input | 1 |
| Chute Output | 2 |
| Connection | 3 |

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
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0 |
| OccupantHash | 0 |
| Quantity | 0 |
| Damage | 0 |
| Class | 0 |
| MaxQuantity | 0 |
| PrefabHash | 0 |
| SortingClass | 0 |
| ReferenceId | 0 |
| FreeSlots | 0 |
| TotalSlots | 0 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| SoundCartridge | SoundCartridge | 0 |

**Build States:**
  - Description=1 x Kit (Music Machines)
**Mode:**
| Name | Value |
|---|---|
| Whole Note | 0 |
| Half Note | 1 |
| Quarter Note | 2 |
| Eighth Note | 3 |
| Sixteenth Note | 4 |

**Connections:**
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Input | 1 |
| Power Input | 2 |

**Constructed Things:**
  - NameOfThing=Kit (Music Machines), PrefabHash=-2038889137, PageLink=ThingItemKitMusicMachines

---

## Logic Switch

A switch which can be turned On. Has an adjustable Color.

- **Key:** ThingModularDeviceSwitch
- **Prefab Name:** ModularDeviceSwitch
- **Prefab Hash:** -1612655781
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Inputs)
**Constructed Things:**
  - NameOfThing=Kit (Modular Console Inputs), PrefabHash=1496399356, PageLink=ThingItemKitModularConsoleInputs

---

## Logic Throttle

Drag the throttle up and down to adjust the Setting between 0 and 1.

- **Key:** ThingModularDeviceThrottle3x2
- **Prefab Name:** ModularDeviceThrottle3x2
- **Prefab Hash:** -1649777768
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Inputs)
**Constructed Things:**
  - NameOfThing=Kit (Modular Console Inputs), PrefabHash=1496399356, PageLink=ThingItemKitModularConsoleInputs

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
**Mode:**
| Name | Value |
|---|---|
| Passive | 0 |
| Active | 1 |

**Connections:**
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Input | 1 |
| Data Input | 2 |
| Connection | 3 |

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
| Name | Value |
|---|---|
| Data Input | 0 |
| Connection | 1 |

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
| Name | Value |
|---|---|
| Connection | 0 |
| Power Input | 1 |

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
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Output | 1 |
| Connection | 2 |

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
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Output | 1 |
| Connection | 2 |

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


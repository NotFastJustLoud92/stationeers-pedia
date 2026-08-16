# LogicType.Weight - Monorail Rail (18m)

## LogicType.Weight

Weight of Rocket in Newtons (Including fuel and cargo). Weight is effected by local body gravity.

- **Key:** LogicTypeWeight

---

## LogicType.WorkingGasEfficiency

The Working Gas Efficiency reported by the machine, as a float between 0 and 1

- **Key:** LogicTypeWorkingGasEfficiency

---

## LogicTypeHeaderTemplate

{0}

- **Key:** LogicTypeHeaderTemplate

---

## LogicTypePageTemplate

{0}

- **Key:** LogicTypePageTemplate

---

## LogicTypeTemplate

{0}{1} {2}

- **Key:** LogicTypeTemplate

---

## Lore

- **Key:** Lore

---

## Low frequency oscillator

The low frequency oscillator (or LFO) makes everything sound dark, twisted and crunchy by altering the shape of the waves output by a Logic Step Sequencer. To set up an LFO: 1. Place the LFO unit 2. Set the LFO output to a Passive Speaker 2. Set a sequencers' output to LFO - so the sequencer's signal runs through the LFO to a speaker. 3. Place a Stop Watch or use an existing one, then use a Logic Writer to write it to the LFO. 4. Use another logic writer to write the BPM to the LFO. 5. You are ready. This is the future. You're in space. Make it sound cool. For more info, check out the music page.

- **Key:** ThingDeviceLfoVolume
- **Prefab Name:** DeviceLfoVolume
- **Prefab Hash:** -1844430312
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
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
  - LogicName=Power Input, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Music Machines), PrefabHash=-2038889137, PageLink=ThingItemKitMusicMachines

---

## Low pressure resistance

The lower limit of pressure that the plant is able to grow at.

- **Key:** GeneLowPressureResistance

---

## Low pressure tolerance

The length of time a plant can stay below its low pressure limit before it starts taking damage.

- **Key:** GeneLowPressureTolerance

---

## Low temperature resistance

The lower limit of temperature that the plant is able to grow at.

- **Key:** GeneLowTemperatureResistance

---

## Low temperature tolerance

The length of time a plant can stay below its low temperature limit before it starts taking damage.

- **Key:** GeneLowTemperatureTolerance

---

## Making Music

The ODA does not approve of soundtracks or other distractions. As such, Stationeers have had to create their own musical accompaniment to the demanding labor of building and maintaining off-world infrastructure. Central to this pasttime is the step sequencer, which allows Stationeers to sequence short musical patterns or loops. DIY MUSIC - GETTING STARTED 1: Connect 8 Device Step Units to your step sequencer via the data port on the lefthand side. 2: Label each step unit, then assign step units 1 through 8 on the step sequencer using the screwdiver. 3: Select the output speaker (eg Passive Speaker) where the sequencer will play the sounds. This needs to be connected to the logic network on the righthand side of the sequencer. 4: Place a Stop Watch and use a Logic Reader and Logic Writer to write the time to the time variable on the sequencer. 5: Set the BPM on the sequencer using a Dial and a Logic Writer to write to the sequencer's BPM variable. A higher bpm will play the sequence faster. 6: Insert a sound cartridge of your chosing and select which variant of sound you wish to play by pushing the arrow buttons located above and below the sound cartidge slot. 7: Choose the pitch of the sounds to play by setting the dial on each of your 8 step units to the desired note. With drums, each note is a different drum sounds. You can trial your sounds by pushing the activate button on each step unit (with the sequencer inactive). 8: Get freaky with the Low frequency oscillator. 9: Finally, activate the sequencer, Vibeoneer.

- **Key:** MusicPage

---

## Manual Floor Hatch

- **Key:** ThingStructureManualFloorHatch
- **Prefab Name:** StructureManualFloorHatch
- **Prefab Hash:** 1435578852
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Door)
  - Description=Welding Torch 1 x Iron Sheets
**Constructed Things:**
  - NameOfThing=Kit (Door), PrefabHash=168615924, PageLink=ThingItemKitDoor

---

## Manual Hatch

Can be welded using a Welding Torch or Arc Welder to lock it in the current state. Use the welder again to unlock.

- **Key:** ThingStructureManualHatch
- **Prefab Name:** StructureManualHatch
- **Prefab Hash:** -1808154199
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Door)
  - Description=Welding Torch 1 x Iron Sheets
**Mode Options:**
  - LogicName=Operate, LogicAccessTypes=0
  - LogicName=Logic, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Door), PrefabHash=168615924, PageLink=ThingItemKitDoor

---

## Map Motherboard

- **Key:** ThingMotherboardMap
- **Prefab Name:** MotherboardMap
- **Prefab Hash:** 1708439824
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 500 x Energy + 5 x Electrum (from Ingot (Electrum)) + 5 x Solder (from Ingot (Solder))


---

## Marine Armor

- **Key:** ThingItemMarineBodyArmor
- **Prefab Name:** ItemMarineBodyArmor
- **Prefab Hash:** 1399098998
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Slots:**
  - SlotName=Auto-Injector, SlotType=Auto-Injector, SlotIndex=0
  - SlotName=Auto-Injector, SlotType=Auto-Injector, SlotIndex=1
  - SlotName=Auto-Injector, SlotType=Auto-Injector, SlotIndex=2
  - SlotName=None, SlotType=None, SlotIndex=3
  - SlotName=None, SlotType=None, SlotIndex=4
  - SlotName=None, SlotType=None, SlotIndex=5
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 3000 x Energy + 20 x Steel (from Ingot (Steel)) + 10 x Silicon (from Ingot (Silicon))


---

## Marine Helmet

- **Key:** ThingItemMarineHelmet
- **Prefab Name:** ItemMarineHelmet
- **Prefab Hash:** 1073631646
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Slots:**
  - SlotName=Battery, SlotType=Battery, SlotIndex=0
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 1750 x Energy + 4 x Gold (from Ingot (Gold)) + 8 x Steel (from Ingot (Steel)) + 4 x Silicon (from Ingot (Silicon))


---

## Marine Uniform

- **Key:** ThingUniformMarine
- **Prefab Name:** UniformMarine
- **Prefab Hash:** -48342840
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
    - 500 x Energy + 10 x Silicon (from Ingot (Silicon))


---

## Math Unary

- **Key:** ThingStructureLogicMathUnary
- **Prefab Name:** StructureLogicMathUnary
- **Prefab Hash:** -1160020195
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Logic Processor)
**Mode Options:**
  - LogicName=Ceil, LogicAccessTypes=0
  - LogicName=Floor, LogicAccessTypes=1
  - LogicName=Abs, LogicAccessTypes=2
  - LogicName=Log, LogicAccessTypes=3
  - LogicName=Exp, LogicAccessTypes=4
  - LogicName=Round, LogicAccessTypes=5
  - LogicName=Rand, LogicAccessTypes=6
  - LogicName=Sqrt, LogicAccessTypes=7
  - LogicName=Sin, LogicAccessTypes=8
  - LogicName=Cos, LogicAccessTypes=9
  - LogicName=Tan, LogicAccessTypes=10
  - LogicName=Asin, LogicAccessTypes=11
  - LogicName=Acos, LogicAccessTypes=12
  - LogicName=Atan, LogicAccessTypes=13
  - LogicName=Not, LogicAccessTypes=14
**Connections:**
  - LogicName=Data Input, LogicAccessTypes=0
  - LogicName=Data Output, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Kit (Logic Processor), PrefabHash=220644373, PageLink=ThingItemKitLogicProcessor

---

## Medium Convection Radiator

A stand-alone radiator unit optimized for exchanging heat with its surrounding atmosphere.

- **Key:** ThingStructureMediumConvectionRadiator
- **Prefab Name:** StructureMediumConvectionRadiator
- **Prefab Hash:** -1918215845
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Convection Factor:** 9.38
- **Radiation Factor:** 3
- **Solar Heating Factor:** 1.5
**Build States:**
  - Description=1 x Kit (Medium Radiator)
  - Description=Welding Torch 1 x Steel Sheets
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Output, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Medium Radiator), PrefabHash=-1752768283, PageLink=ThingItemKitPassiveLargeRadiatorGas

---

## Medium Convection Radiator

Has been replaced by Medium Convection Radiator.

- **Key:** ThingStructurePassiveLargeRadiatorGas
- **Prefab Name:** StructurePassiveLargeRadiatorGas
- **Prefab Hash:** 2066977095
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Convection Factor:** 7.5
- **Radiation Factor:** 3
- **Solar Heating Factor:** 1.5
**Build States:**
  - Description=1 x Kit (Medium Radiator)
  - Description=Welding Torch 2 x Steel Sheets
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Output, LogicAccessTypes=1

---

## Medium Convection Radiator Liquid

A stand-alone liquid radiator unit optimized for exchanging heat with its surrounding atmosphere.

- **Key:** ThingStructureMediumConvectionRadiatorLiquid
- **Prefab Name:** StructureMediumConvectionRadiatorLiquid
- **Prefab Hash:** -1169014183
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Convection Factor:** 9.38
- **Radiation Factor:** 3
- **Solar Heating Factor:** 1.5
**Build States:**
  - Description=1 x Kit (Medium Radiator Liquid)
  - Description=Welding Torch 1 x Steel Sheets
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Output, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Medium Radiator Liquid), PrefabHash=1453961898, PageLink=ThingItemKitPassiveLargeRadiatorLiquid

---

## Medium Convection Radiator Liquid

Has been replaced by Medium Convection Radiator Liquid.

- **Key:** ThingStructurePassiveLargeRadiatorLiquid
- **Prefab Name:** StructurePassiveLargeRadiatorLiquid
- **Prefab Hash:** 24786172
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Convection Factor:** 7.5
- **Radiation Factor:** 3
- **Solar Heating Factor:** 1.5
**Build States:**
  - Description=1 x Kit (Medium Radiator Liquid)
  - Description=Welding Torch 2 x Steel Sheets
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Output, LogicAccessTypes=1

---

## Medium Filter (Alcohol)

- **Key:** ThingItemGasFilterAlcoholM
- **Prefab Name:** ItemGasFilterAlcoholM
- **Prefab Hash:** -933073887
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Carbon Dioxide)

- **Key:** ThingItemGasFilterCarbonDioxideM
- **Prefab Name:** ItemGasFilterCarbonDioxideM
- **Prefab Hash:** 416897318
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Helium)

- **Key:** ThingItemGasFilterHeliumM
- **Prefab Name:** ItemGasFilterHeliumM
- **Prefab Hash:** -983937104
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Hydrazine)

- **Key:** ThingItemGasFilterHydrazineM
- **Prefab Name:** ItemGasFilterHydrazineM
- **Prefab Hash:** 233953680
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Hydrochloric Acid)

- **Key:** ThingItemGasFilterHClM
- **Prefab Name:** ItemGasFilterHClM
- **Prefab Hash:** 1785339433
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Hydrogen)

- **Key:** ThingItemGasFilterHydrogenM
- **Prefab Name:** ItemGasFilterHydrogenM
- **Prefab Hash:** -1305100708
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Methane)

- **Key:** ThingItemGasFilterVolatilesM
- **Prefab Name:** ItemGasFilterVolatilesM
- **Prefab Hash:** 1037507240
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Nitrogen)

- **Key:** ThingItemGasFilterNitrogenM
- **Prefab Name:** ItemGasFilterNitrogenM
- **Prefab Hash:** -632657357
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Nitrous Oxide)

- **Key:** ThingItemGasFilterNitrousOxideM
- **Prefab Name:** ItemGasFilterNitrousOxideM
- **Prefab Hash:** 1824284061
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Oxygen)

- **Key:** ThingItemGasFilterOxygenM
- **Prefab Name:** ItemGasFilterOxygenM
- **Prefab Hash:** -1067319543
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Ozone)

- **Key:** ThingItemGasFilterOzoneM
- **Prefab Name:** ItemGasFilterOzoneM
- **Prefab Hash:** 1996342730
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Pollutants)

- **Key:** ThingItemGasFilterPollutantsM
- **Prefab Name:** ItemGasFilterPollutantsM
- **Prefab Hash:** 63677771
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Polluted Water)

- **Key:** ThingItemGasFilterPollutedWaterM
- **Prefab Name:** ItemGasFilterPollutedWaterM
- **Prefab Hash:** 825332435
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Salt)

- **Key:** ThingItemGasFilterSaltM
- **Prefab Name:** ItemGasFilterSaltM
- **Prefab Hash:** -1959236530
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Silanol)

- **Key:** ThingItemGasFilterSilanolM
- **Prefab Name:** ItemGasFilterSilanolM
- **Prefab Hash:** -808900936
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Filter (Water)

- **Key:** ThingItemGasFilterWaterM
- **Prefab Name:** ItemGasFilterWaterM
- **Prefab Hash:** 8804422
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Hydraulic Pipe Bender (Tier One)
    - 2500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Silver (from Ingot (Silver)) + 1 x Constantan (from Ingot (Constantan))


---

## Medium Hangar Door

1 x 2 modular door piece for building hangar doors.

- **Key:** ThingStructureMediumHangerDoor
- **Prefab Name:** StructureMediumHangerDoor
- **Prefab Hash:** -566348148
- **Base Power Draw:** 25 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=2 x Kit (Hangar Door)
  - Description=Welding Torch 2 x Steel Sheets
**Mode Options:**
  - LogicName=Operate, LogicAccessTypes=0
  - LogicName=Logic, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Hangar Door), PrefabHash=682546947, PageLink=ThingItemKitAirlockGate

---

## Medium Radiator

A stand-alone radiator unit optimized for radiating heat in vacuums.

- **Key:** ThingStructureMediumRadiator
- **Prefab Name:** StructureMediumRadiator
- **Prefab Hash:** -975966237
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Convection Factor:** 1.5
- **Radiation Factor:** 30
- **Solar Heating Factor:** 15
**Build States:**
  - Description=1 x Kit (Medium Radiator)
  - Description=Welding Torch 1 x Steel Sheets
**Connections:**
  - LogicName=Pipe Input, LogicAccessTypes=0
  - LogicName=Pipe Output, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Medium Radiator), PrefabHash=-1752768283, PageLink=ThingItemKitPassiveLargeRadiatorGas

---

## Medium Radiator Liquid

A stand-alone liquid radiator unit optimized for radiating heat in vacuums.

- **Key:** ThingStructureMediumRadiatorLiquid
- **Prefab Name:** StructureMediumRadiatorLiquid
- **Prefab Hash:** -1141760613
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Convection Factor:** 1.5
- **Radiation Factor:** 30
- **Solar Heating Factor:** 15
**Build States:**
  - Description=1 x Kit (Medium Radiator Liquid)
  - Description=Welding Torch 1 x Steel Sheets
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Output, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Medium Radiator Liquid), PrefabHash=1453961898, PageLink=ThingItemKitPassiveLargeRadiatorLiquid

---

## Medium Satellite Dish

This medium communications unit can be used to communicate with nearby trade vessels. When connected to a Computer (Modern) containing a Communications Motherboard motherboard, a Landingpad Center, and a Vending Machine, this allows Stationeers to contact traders. Adjust its horizontal and vertical attributes either directly or through logic.

- **Key:** ThingStructureSatelliteDish
- **Prefab Name:** StructureSatelliteDish
- **Prefab Hash:** 439026183
- **Base Power Draw:** 50 W
- **Memory Size:** 256 B
- **Memory Access:** Read Write
- **Has Memory:** true
- **Paintable:** Yes
**Logic Types:**
  - Text=TraderInstruction.WriteTraderData OP_CODE: 1, Index=1, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | WRITE_INDEX | BYTE_8 | | 16-63 | UNUSED | 48 |
  - Text=TraderInstruction.StrongestContactIdHash OP_CODE: 2, Index=2, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-39 | TRADER_ID_HASH | UINT_32 | | 40-63 | UNUSED | 24 | | HASH REPORTED UNSIGNED - MUST BE MANUALLY SIGNED |
  - Text=TraderInstruction.StrongestContactMetaData OP_CODE: 3, Index=3, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | SHUTTLE_TYPE | BYTE_8 | | 16-23 | CONTACT_SLOT_INDEX | BYTE_8 | | 24-31 | CONTACTED | BYTE_8 | | 32-63 | UNUSED | 32 |
  - Text=TraderInstruction.StrongestContactSignalData OP_CODE: 4, Index=4, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-23 | WATTS_TO_RESOLVE | USHORT_16 | | 24-39 | LIFETIME | USHORT_16 | | 40-63 | UNUSED | 24 |
  - Text=TraderInstruction.WriteTraderBuyData OP_CODE: 5, Index=5, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | WRITE_INDEX | BYTE_8 | | 16-23 | WRITE_COUNT | BYTE_8 | | 24-63 | UNUSED | 40 |
  - Text=TraderInstruction.WriteTraderSellData OP_CODE: 6, Index=6, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | WRITE_INDEX | BYTE_8 | | 16-23 | WRITE_COUNT | BYTE_8 | | 24-63 | UNUSED | 40 |
  - Text=TraderInstruction.TraderBuyThingData OP_CODE: 7, Index=7, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | QUANTITY | BYTE_8 | | 16-47 | PREFAB_HASH | UINT_32 | | 48-63 | UNUSED | 16 | | HASH REPORTED UNSIGNED - MUST BE MANUALLY SIGNED |
  - Text=TraderInstruction.TraderBuyThingChildData OP_CODE: 8, Index=8, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | QUANTITY | BYTE_8 | | 16-47 | PREFAB_HASH | UINT_32 | | 48-63 | UNUSED | 16 | | HASH REPORTED UNSIGNED - MUST BE MANUALLY SIGNED |
  - Text=TraderInstruction.TraderBuyGasData OP_CODE: 9, Index=9, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | QUANTITY | BYTE_8 | | 16-47 | GAS_TYPES_BITFLAG | UINT_32 | | 48-63 | UNUSED | 16 |
  - Text=TraderInstruction.TraderSellThingData OP_CODE: 10, Index=A, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | QUANTITY | BYTE_8 | | 16-47 | PREFAB_HASH | UINT_32 | | 48-63 | UNUSED | 16 | | HASH REPORTED UNSIGNED - MUST BE MANUALLY SIGNED |
  - Text=TraderInstruction.TraderSellGasData OP_CODE: 11, Index=B, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | QUANTITY | BYTE_8 | | 16-47 | GAS_TYPES_BITFLAG | UINT_32 | | 48-63 | UNUSED | 16 |
  - Text=TraderInstruction.TraderSellThingChildData OP_CODE: 12, Index=C, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | QUANTITY | BYTE_8 | | 16-47 | PREFAB_HASH | UINT_32 | | 48-63 | UNUSED | 16 | | HASH REPORTED UNSIGNED - MUST BE MANUALLY SIGNED |
  - Text=TraderInstruction.FilterPrefabHashEquals OP_CODE: 13, Index=D, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-39 | PREFAB_HASH | INT_32 | | 40-63 | UNUSED | 24 |
  - Text=TraderInstruction.FilterPrefabHashNotEquals OP_CODE: 14, Index=E, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-39 | PREFAB_HASH | INT_32 | | 40-63 | UNUSED | 24 |
  - Text=TraderInstruction.FilterSortingClassCompare OP_CODE: 15, Index=F, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | CONDITION_OPERATION | BYTE_8 | | 16-31 | SORTING_CLASS | USHORT_16 | | 32-63 | UNUSED | 32 |
  - Text=TraderInstruction.FilterQuantityCompare OP_CODE: 16, Index=10, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-15 | CONDITION_OPERATION | BYTE_8 | | 16-31 | QUANTITY | USHORT_16 | | 32-63 | UNUSED | 32 |
  - Text=TraderInstruction.FilterGasContains OP_CODE: 17, Index=11, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-39 | GAS_TYPES_BITFLAG | UINT_32 | | 40-63 | UNUSED | 24 |
  - Text=TraderInstruction.FilterGasNotContains OP_CODE: 18, Index=12, Info=| 0-7 | OP_CODE | BYTE_8 | | 8-39 | GAS_TYPES_BITFLAG | UINT_32 | | 40-63 | UNUSED | 24 |
**Build States:**
  - Description=1 x Kit (Medium Satellite Dish)
  - Description=Welding Torch 1 x Steel Sheets
  - Description=Wrench
  - Description=1 x Plastic Sheets
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Medium Satellite Dish), PrefabHash=178422810, PageLink=ThingItemKitSatelliteDish

---

## Meter 3x3

Meter that displays Setting within a user defined range. Has an adjustable Color. Text is changeable via Labeller, add a "*" at the end to hide the text.

- **Key:** ThingModularDeviceMeter3x3
- **Prefab Name:** ModularDeviceMeter3x3
- **Prefab Hash:** -1399920604
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Modular Console Displays)
**Constructed Things:**
  - NameOfThing=Kit (Modular Console Displays), PrefabHash=210802104, PageLink=ThingItemKitModularConsoleDisplays

---

## Methane

Methane is a combustible fuel. It is refined from Ice (Volatiles)

- **Key:** GasMethane
- **Gas Type:** Methane
- **Specific Heat:** 20.4 J/K
- **Latent Heat:** 1 kJ/mol
- **Moles Per Litre:** N/A
- **Moles Per Litre (In World):** N/A
- **Freeze Temperature:** 81.5K (-192C)
- **Boiling Temperature:** 116K (-157C) at 100kPa
- **Max Liquid Temperature:** 195K (-78.1C) at 6000kPa
- **Min Liquid Pressure:** 6.3kPa at 81.5K (-192C)
**Combustion:**
  - FuelType=Methane, OxidiserType=Oxygen
  - FuelType=Methane, OxidiserType=LiquidOxygen
  - FuelType=Methane, OxidiserType=NitrousOxide
  - FuelType=Methane, OxidiserType=LiquidNitrousOxide
  - FuelType=Methane, OxidiserType=Ozone
  - FuelType=Methane, OxidiserType=LiquidOzone
**Found In Ore:**
  - NameOfThing=Biomass, QuantityOfThing=8 mol
  - NameOfThing=Ore (Cobalt), QuantityOfThing=1 mol
  - NameOfThing=Ice (Volatiles), QuantityOfThing=20 mol

---

## Microwave

While countless 'better' ways of cooking Food have been invented in the last few hundred years, few are as durable or easy to fabricate as the OK-Zoomer microwave. Licensed from Xigo, the plans are based on a classic model from the mid-21st century, giving it a charmingly retro feel. But don't worry, it oscillates Water molecules more than adequately. Just bolt it to a Powered Bench using a Wrench to power it, follow the recipe, and you're cooking.

- **Key:** ThingApplianceMicrowave
- **Prefab Name:** ApplianceMicrowave
- **Prefab Hash:** -1136173965
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 973 K (700oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Slots:**
  - SlotName=Output, SlotType=Output, SlotIndex=0
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 1500 x Energy + 5 x Iron (from Ingot (Iron)) + 1 x Gold (from Ingot (Gold)) + 2 x Copper (from Ingot (Copper))

**Resources Used:**
  - NameOfThing=Cheese, PrefabHash=1695894944, PageLink=ThingItemCheeseWedge
  - NameOfThing=Cocoa Powder, PrefabHash=457286516, PageLink=ThingItemCocoaPowder
  - NameOfThing=Egg, PrefabHash=-873909936, PageLink=ThingItemEgg
  - NameOfThing=Egg, PrefabHash=-383972371, PageLink=ThingItemFertilizedEgg
  - NameOfThing=Flour, PrefabHash=-665995854, PageLink=ThingItemFlour
  - NameOfThing=Milk, PrefabHash=1327248310, PageLink=ThingItemMilk
  - NameOfThing=Soy Oil, PrefabHash=1387403148, PageLink=ThingItemSoyOil
  - NameOfThing=Sugar, PrefabHash=2111910840, PageLink=ThingItemSugar
  - NameOfThing=Tomato, PrefabHash=-998592080, PageLink=ThingItemTomato
  - NameOfThing=Potato, PrefabHash=1929046963, PageLink=ThingItemPotato
  - NameOfThing=Corn, PrefabHash=258339687, PageLink=ThingItemCorn
  - NameOfThing=Cocoa, PrefabHash=680051921, PageLink=ThingItemCocoaTree
  - NameOfThing=Sugarcane, PrefabHash=-1335056202, PageLink=ThingItemSugarCane
  - NameOfThing=Soybean, PrefabHash=1924673028, PageLink=ThingItemSoybean
  - NameOfThing=Rice, PrefabHash=658916791, PageLink=ThingItemRice
  - NameOfThing=Pumpkin, PrefabHash=1277828144, PageLink=ThingItemPumpkin
  - NameOfThing=Mushroom, PrefabHash=2044798572, PageLink=ThingItemMushroom

---

## Microwave Power Receiver

The Norsec Wireless Power Transmitter is an uni-directional, A-to-B, far field microwave electrical transmission system.The rotatable base transmitter delivers a narrow, non-lethal microwave beam to a dedicated base receiver. The transmitter must be aligned to the base station in order to transmit any power. The brightness of the transmitter's collimator arc provides an indication of transmission intensity. Note that there is an attrition over longer ranges, so the unit requires more power over greater distances to deliver the same output.Connects to Logic Transmitter

- **Key:** ThingStructurePowerTransmitterReceiver
- **Prefab Name:** StructurePowerTransmitterReceiver
- **Prefab Hash:** 1195820278
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Power Transmitter)
  - Description=2 x Iron Sheets
  - Description=1 x Electronic Parts
**Mode Options:**
  - LogicName=Unlinked, LogicAccessTypes=0
  - LogicName=Linked, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Power Output, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Power Transmitter), PrefabHash=291368213, PageLink=ThingItemKitPowerTransmitter

---

## Microwave Power Transmitter

The Norsec Wireless Power Transmitter is an uni-directional, A-to-B, far field microwave electrical transmission system.The rotatable base transmitter delivers a narrow, non-lethal microwave beam to a dedicated base receiver. The transmitter must be aligned to the base station in order to transmit any power. The brightness of the transmitter's collimator arc provides an indication of transmission intensity. Note that there is an attrition over longer ranges, so the unit requires more power over greater distances to deliver the same output.

- **Key:** ThingStructurePowerTransmitter
- **Prefab Name:** StructurePowerTransmitter
- **Prefab Hash:** -65087121
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build States:**
  - Description=1 x Kit (Power Transmitter)
  - Description=2 x Iron Sheets
  - Description=3 x Electronic Parts
**Mode Options:**
  - LogicName=Unlinked, LogicAccessTypes=0
  - LogicName=Linked, LogicAccessTypes=1
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Power Input, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Power Transmitter), PrefabHash=291368213, PageLink=ThingItemKitPowerTransmitter

---

## Milk

Full disclosure, it's not actually 'milk', but an Agrizero-invented synthesis of 5ml Soy Oil and 5g Fern, delicately blended in the Chemistry Station. Surprisingly filling, it can be used as an ingredient to cook other food in the Microwave or Automated Oven. Think, Muffin.

- **Key:** ThingItemMilk
- **Prefab Name:** ItemMilk
- **Prefab Hash:** 1327248310
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 160
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Stack Size:** 100
- **Paintable:** No
- **Flashpoint:** 553 K (280oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Build Recipe:**
  - Printer: Chemistry Station (Tier One)
    - 5 x Oil (from Soy Oil) + 5 x Fenoxitone (from Fern)

**Used In:**
  - NameOfThing=Microwave, PrefabHash=-1136173965, PageLink=ThingApplianceMicrowave
  - NameOfThing=Basic Packaging Machine, PrefabHash=-749191906, PageLink=ThingAppliancePackagingMachine
  - NameOfThing=Advanced Packaging Machine, PrefabHash=-463037670, PageLink=ThingStructureAdvancedPackagingMachine
  - NameOfThing=Automated Oven, PrefabHash=-1672404896, PageLink=ThingStructureAutomatedOven

---

## Milk

- **Key:** ReagentMilk
- **Reagents Type:** Milk
- **Unit:** ml
**Found In Ore:**
  - NameOfThing=Condensed Milk, QuantityOfThing=1
  - NameOfThing=Milk, QuantityOfThing=1

---

## Mining

You can mine ore using a Mining Drill. If you wear a Mining Belt the ore will automatically be placed within it.

- **Key:** MiningPage

---

## Mining Backpack

- **Key:** ThingItemMiningBackPack
- **Prefab Name:** ItemMiningBackPack
- **Prefab Hash:** -1650383245
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Slots:**
  - SlotName=Ore, SlotType=Ore, SlotIndex=0
  - SlotName=Ore, SlotType=Ore, SlotIndex=1
  - SlotName=Ore, SlotType=Ore, SlotIndex=2
  - SlotName=Ore, SlotType=Ore, SlotIndex=3
  - SlotName=Ore, SlotType=Ore, SlotIndex=4
  - SlotName=Ore, SlotType=Ore, SlotIndex=5
  - SlotName=Ore, SlotType=Ore, SlotIndex=6
  - SlotName=Ore, SlotType=Ore, SlotIndex=7
  - SlotName=Ore, SlotType=Ore, SlotIndex=8
  - SlotName=Ore, SlotType=Ore, SlotIndex=9
  - SlotName=Ore, SlotType=Ore, SlotIndex=10
  - SlotName=Ore, SlotType=Ore, SlotIndex=11
  - SlotName=Ore, SlotType=Ore, SlotIndex=12
  - SlotName=Ore, SlotType=Ore, SlotIndex=13
  - SlotName=Ore, SlotType=Ore, SlotIndex=14
  - SlotName=Ore, SlotType=Ore, SlotIndex=15
  - SlotName=Ore, SlotType=Ore, SlotIndex=16
  - SlotName=Ore, SlotType=Ore, SlotIndex=17
  - SlotName=Ore, SlotType=Ore, SlotIndex=18
  - SlotName=Ore, SlotType=Ore, SlotIndex=19
  - SlotName=Ore, SlotType=Ore, SlotIndex=20
  - SlotName=Ore, SlotType=Ore, SlotIndex=21
  - SlotName=Ore, SlotType=Ore, SlotIndex=22
  - SlotName=Ore, SlotType=Ore, SlotIndex=23
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 800 x Energy + 6 x Iron (from Ingot (Iron))


---

## Mining Belt

Originally developed by Recurso Espaciais for asteroid mining, the Stationeer's mining belt has room for two tools and eight ore stacks. While wearing the belt, ore is automatically stored there when mined. Volatile and temperature-dependent remain stable in the environmentally controlled unit.

- **Key:** ThingItemMiningBelt
- **Prefab Name:** ItemMiningBelt
- **Prefab Hash:** -676435305
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Slots:**
  - SlotName=Tool, SlotType=Tool, SlotIndex=0
  - SlotName=Tool, SlotType=Tool, SlotIndex=1
  - SlotName=Ore, SlotType=Ore, SlotIndex=2
  - SlotName=Ore, SlotType=Ore, SlotIndex=3
  - SlotName=Ore, SlotType=Ore, SlotIndex=4
  - SlotName=Ore, SlotType=Ore, SlotIndex=5
  - SlotName=Ore, SlotType=Ore, SlotIndex=6
  - SlotName=Ore, SlotType=Ore, SlotIndex=7
  - SlotName=Ore, SlotType=Ore, SlotIndex=8
  - SlotName=Ore, SlotType=Ore, SlotIndex=9
**Build Recipe:**
  - Printer: Tool Manufactory (Tier One)
    - 500 x Energy + 3 x Iron (from Ingot (Iron))


---

## Mining Belt MK II

A larger and more capacious mining belt, the Mk II is similar to the Mining Belt, but has 13 slots instead of the basic 8, to increase the length of your mining trips. It also has space for two tools.

- **Key:** ThingItemMiningBeltMKII
- **Prefab Name:** ItemMiningBeltMKII
- **Prefab Hash:** 1470787934
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Logic Slot Types:**
  - LogicName=Occupied, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=OccupantHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=Quantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=Damage, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=Class, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=MaxQuantity, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=PrefabHash, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
  - LogicName=ReferenceId, LogicAccessTypes=0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
**Slots:**
  - SlotName=Tool, SlotType=Tool, SlotIndex=0
  - SlotName=Tool, SlotType=Tool, SlotIndex=1
  - SlotName=Ore, SlotType=Ore, SlotIndex=2
  - SlotName=Ore, SlotType=Ore, SlotIndex=3
  - SlotName=Ore, SlotType=Ore, SlotIndex=4
  - SlotName=Ore, SlotType=Ore, SlotIndex=5
  - SlotName=Ore, SlotType=Ore, SlotIndex=6
  - SlotName=Ore, SlotType=Ore, SlotIndex=7
  - SlotName=Ore, SlotType=Ore, SlotIndex=8
  - SlotName=Ore, SlotType=Ore, SlotIndex=9
  - SlotName=Ore, SlotType=Ore, SlotIndex=10
  - SlotName=Ore, SlotType=Ore, SlotIndex=11
  - SlotName=Ore, SlotType=Ore, SlotIndex=12
  - SlotName=Ore, SlotType=Ore, SlotIndex=13
  - SlotName=Ore, SlotType=Ore, SlotIndex=14
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 1000 x Energy + 10 x Steel (from Ingot (Steel)) + 5 x Constantan (from Ingot (Constantan))


---

## Mining Charge

A low cost, high yield explosive with a 10 second timer.

- **Key:** ThingItemMiningCharge
- **Prefab Name:** ItemMiningCharge
- **Prefab Hash:** 15829510
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 3
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Security Printer (Tier One)
    - 200 x Energy + 1 x Iron (from Ingot (Iron)) + 1 x Gold (from Ingot (Gold)) + 3 x Silicon (from Ingot (Silicon))
  - Printer: Tool Manufactory (Tier One)
    - 6000 x Energy + 1 x Iron (from Ingot (Iron)) + 1 x Gold (from Ingot (Gold)) + 5 x Silicon (from Ingot (Silicon))

**Mode Options:**
  - LogicName=Mode0, LogicAccessTypes=0
  - LogicName=Mode1, LogicAccessTypes=1

---

## Mining Drill

The handheld 'Topo' tri-cone rotary mining drill was made for one thing: quick digging. Modeled on a classic Recurso zero-g design, it functions equally well in vacuum and atmosphere, with cemented carbide bits to increase resilience and bearing life, and reduce spalling. As Jenk Murtons once said, 'The Topo don't stopo.'

- **Key:** ThingItemMiningDrill
- **Prefab Name:** ItemMiningDrill
- **Prefab Hash:** 1055173191
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
    - 500 x Energy + 3 x Iron (from Ingot (Iron)) + 2 x Copper (from Ingot (Copper))

**Mode Options:**
  - LogicName=Default, LogicAccessTypes=0
  - LogicName=Flatten, LogicAccessTypes=1

---

## Mining Drill (Heavy)

Sometimes mining trips require something a little bigger to bring home the goods. This scaled up version of the Recurso 'Topo' design Mining Drill can literally move mountains. The heavy mining drill will remove more ground and mine ore more quickly than the standard mining drill. The heavy mining drill is also resilient to temperature and pressure. So no matter what planet or extreme weather conditions may be present, the Recurso heavy mining drill will get the job done.

- **Key:** ThingItemMiningDrillHeavy
- **Prefab Name:** ItemMiningDrillHeavy
- **Prefab Hash:** -1663349918
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 873 K (600oC)
- **Auto Ignition:** 973 K (700oC)
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
    - 2500 x Energy + 10 x Steel (from Ingot (Steel)) + 5 x Electrum (from Ingot (Electrum)) + 10 x Invar (from Ingot (Invar)) + 10 x Solder (from Ingot (Solder))

**Mode Options:**
  - LogicName=Default, LogicAccessTypes=0
  - LogicName=Flatten, LogicAccessTypes=1

---

## Mining Supplies Package

- **Key:** ThingItemMiningPackage
- **Prefab Name:** ItemMiningPackage
- **Prefab Hash:** 384478267
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

## Mining-Drill Head (Basic)

Replaceable drill head for Rocket Miner

- **Key:** ThingItemRocketMiningDrillHead
- **Prefab Name:** ItemRocketMiningDrillHead
- **Prefab Hash:** 2109945337
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** Yes
**Build Recipe:**
  - Printer: Rocket Manufactory (Tier One)
    - 5000 x Energy + 20 x Steel (from Ingot (Steel))


---

## Mining-Drill Head (Durable)

- **Key:** ThingItemRocketMiningDrillHeadDurable
- **Prefab Name:** ItemRocketMiningDrillHeadDurable
- **Prefab Hash:** 1530764483
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** Yes
**Build Recipe:**
  - Printer: Rocket Manufactory (Tier One)
    - 5000 x Energy + 20 x Steel (from Ingot (Steel))


---

## Mining-Drill Head (High Speed Ice)

- **Key:** ThingItemRocketMiningDrillHeadHighSpeedIce
- **Prefab Name:** ItemRocketMiningDrillHeadHighSpeedIce
- **Prefab Hash:** 653461728
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** Yes
**Build Recipe:**
  - Printer: Rocket Manufactory (Tier One)
    - 5000 x Energy + 20 x Steel (from Ingot (Steel)) + 10 x Invar (from Ingot (Invar))


---

## Mining-Drill Head (High Speed Mineral)

- **Key:** ThingItemRocketMiningDrillHeadHighSpeedMineral
- **Prefab Name:** ItemRocketMiningDrillHeadHighSpeedMineral
- **Prefab Hash:** 1440678625
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** Yes
**Build Recipe:**
  - Printer: Rocket Manufactory (Tier One)
    - 5000 x Energy + 20 x Steel (from Ingot (Steel)) + 10 x Invar (from Ingot (Invar))


---

## Mining-Drill Head (Ice)

- **Key:** ThingItemRocketMiningDrillHeadIce
- **Prefab Name:** ItemRocketMiningDrillHeadIce
- **Prefab Hash:** -380904592
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** Yes
**Build Recipe:**
  - Printer: Rocket Manufactory (Tier One)
    - 5000 x Energy + 20 x Steel (from Ingot (Steel)) + 10 x Electrum (from Ingot (Electrum))


---

## Mining-Drill Head (Long Term)

- **Key:** ThingItemRocketMiningDrillHeadLongTerm
- **Prefab Name:** ItemRocketMiningDrillHeadLongTerm
- **Prefab Hash:** -684020753
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** Yes
**Build Recipe:**
  - Printer: Rocket Manufactory (Tier One)
    - 5000 x Energy + 20 x Steel (from Ingot (Steel)) + 10 x Invar (from Ingot (Invar))


---

## Mining-Drill Head (Mineral)

- **Key:** ThingItemRocketMiningDrillHeadMineral
- **Prefab Name:** ItemRocketMiningDrillHeadMineral
- **Prefab Hash:** 1083675581
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 100
- **Paintable:** Yes
**Build Recipe:**
  - Printer: Rocket Manufactory (Tier One)
    - 5000 x Energy + 20 x Steel (from Ingot (Steel)) + 10 x Constantan (from Ingot (Constantan))


---

## Mk II Angle Grinder

Angles-be-gone with the trusty angle grinder. The MK II is more resistant to temperature and pressure.

- **Key:** ThingItemMKIIAngleGrinder
- **Prefab Name:** ItemMKIIAngleGrinder
- **Prefab Hash:** 240174650
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 873 K (600oC)
- **Auto Ignition:** 973 K (700oC)
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
    - 500 x Energy + 3 x Iron (from Ingot (Iron)) + 1 x Copper (from Ingot (Copper)) + 4 x Electrum (from Ingot (Electrum))


---

## Mk II Arc Welder

- **Key:** ThingItemMKIIArcWelder
- **Prefab Name:** ItemMKIIArcWelder
- **Prefab Hash:** -2061979347
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 873 K (600oC)
- **Auto Ignition:** 973 K (700oC)
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
    - 2500 x Energy + 10 x Steel (from Ingot (Steel)) + 14 x Electrum (from Ingot (Electrum)) + 5 x Invar (from Ingot (Invar)) + 10 x Solder (from Ingot (Solder))


---

## Mk II Crowbar

Recurso's entry-level crowbar is useful in a variety of everyday Stationeer settings, from opening Area Power Controls and unpowered Airlocks, to splatting pan-dimensional headcrabs, should the need arise. The MK II is more resistant to temperature and pressure.

- **Key:** ThingItemMKIICrowbar
- **Prefab Name:** ItemMKIICrowbar
- **Prefab Hash:** 1440775434
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 873 K (600oC)
- **Auto Ignition:** 973 K (700oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Electrum (from Ingot (Electrum))


---

## Mk II Drill

The ExMin Off-whirled Hand Drill has been a companion to Stationeers for decades. Essential for assembling and deconstructing various items and structures, regardless of gravity, pressure or temperature.

- **Key:** ThingItemMKIIDrill
- **Prefab Name:** ItemMKIIDrill
- **Prefab Hash:** 324791548
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 873 K (600oC)
- **Auto Ignition:** 973 K (700oC)
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
    - 500 x Energy + 5 x Iron (from Ingot (Iron)) + 5 x Copper (from Ingot (Copper)) + 5 x Electrum (from Ingot (Electrum))


---

## Mk II Duct Tape

In the distant past, one of Earth's great champions taught a generation of 'Fix-It People' that duct tape was the answer to any problem. Stationeers have demonstrated that this is truth holds strong, so long as the problem is a damaged Eva Suit, Jetpack Basic, Space Helmet, or even a Solar Panel. To use on yourself: put duct tape in your active hand, hold RIGHT MOUSE BUTTON to automatically repair damage.

- **Key:** ThingItemMKIIDuctTape
- **Prefab Name:** ItemMKIIDuctTape
- **Prefab Hash:** 388774906
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 1
- **Paintable:** No
- **Flashpoint:** 873 K (600oC)
- **Auto Ignition:** 973 K (700oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 500 x Energy + 2 x Iron (from Ingot (Iron)) + 1 x Electrum (from Ingot (Electrum))


---

## Mk II Mining Drill

The handheld 'Topo' tri-cone rotary mining drill was made for one thing: quick digging. Modeled on a classic Recurso zero-g design, it functions equally well in vacuum and atmosphere, with cemented carbide bits to increase resilience and bearing life, and reduce spalling. As Jenk Murtons once said, 'The Topo don't stopo.' The MK II is more resistant to temperature and pressure.

- **Key:** ThingItemMKIIMiningDrill
- **Prefab Name:** ItemMKIIMiningDrill
- **Prefab Hash:** -1875271296
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 873 K (600oC)
- **Auto Ignition:** 973 K (700oC)
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
    - 500 x Energy + 3 x Iron (from Ingot (Iron)) + 2 x Copper (from Ingot (Copper)) + 5 x Electrum (from Ingot (Electrum))

**Mode Options:**
  - LogicName=Default, LogicAccessTypes=0
  - LogicName=Flatten, LogicAccessTypes=1

---

## Mk II Screwdriver

This standard issue frictional adherence adjustor is a top of the line, bi-rotational model with a columnated uni-grip. It's definitely not just a screwdriver. Use it for construction and deconstruction of certain kits, and setting values on logic units. The MK II is more resistant to temperature and pressure.

- **Key:** ThingItemMKIIScrewdriver
- **Prefab Name:** ItemMKIIScrewdriver
- **Prefab Hash:** -2015613246
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 873 K (600oC)
- **Auto Ignition:** 973 K (700oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 500 x Energy + 2 x Iron (from Ingot (Iron)) + 2 x Electrum (from Ingot (Electrum))


---

## Mk II Wire Cutters

Wirecutters allow you to deconstruct various structures, as well as cross-lay cables when held in your non-active hand, and defuse explosives as needed. Wirecutters are stored in the Tool Belt, along with other essential tools.

- **Key:** ThingItemMKIIWireCutters
- **Prefab Name:** ItemMKIIWireCutters
- **Prefab Hash:** -178893251
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 873 K (600oC)
- **Auto Ignition:** 973 K (700oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 500 x Energy + 3 x Iron (from Ingot (Iron)) + 5 x Electrum (from Ingot (Electrum))


---

## Mk II Wrench

One of humanity's enduring contributions to the cosmos, the wrench represents the essence of our species. A simple, effective and spiritually barren tool, use it to build and deconstruct a variety of structures The MK II is more resistant to temperature and pressure.

- **Key:** ThingItemMKIIWrench
- **Prefab Name:** ItemMKIIWrench
- **Prefab Hash:** 1862001680
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 873 K (600oC)
- **Auto Ignition:** 973 K (700oC)
**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 500 x Energy + 3 x Iron (from Ingot (Iron)) + 3 x Electrum (from Ingot (Electrum))


---

## Mode Control

Can't decide which mode you love most? This circuit board allows you to switch any connected device between operation modes.

- **Key:** ThingCircuitboardModeControl
- **Prefab Name:** CircuitboardModeControl
- **Prefab Hash:** -1134148135
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 393 K (120oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 100 x Energy + 5 x Gold (from Ingot (Gold)) + 5 x Copper (from Ingot (Copper))


---

## Modern Toilet

A device for reducing sanitation needs. Requires Water and outputs Polluted Water from those who use it.

- **Key:** ThingStructureToiletModern
- **Prefab Name:** StructureToiletModern
- **Prefab Hash:** 768716816
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Kit (Toilet)
**Connections:**
  - LogicName=Pipe Liquid Input, LogicAccessTypes=0
  - LogicName=Pipe Liquid Output, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Kit (Toilet), PrefabHash=1484917493, PageLink=ThingItemKitToilet

---

## ModeStringHeaderTemplate

{0}

- **Key:** ModeStringHeaderTemplate

---

## ModeStringItemTemplate

{0}.{1}

- **Key:** ModeStringItemTemplate

---

## Monorail A - Start Here

Your First Train Welcome to the Monorail System. Start with one dock and one other station, then send the train between them. The dock is part of the track, spawns the train, and can be selected as a destination. You do not need a loop, switches, signals, or a timetable for this first line. Choose the dock that provides the train you need: Cargo Monorail Train - carries up to 100 items Atmos Monorail Train - carries gas and liquid in a 16000 L tank Passenger Monorail Train - carries two drivers and eight passengers Cargo and Atmos Monorail Train - carries 50 items and an 8000 L tank 1. Build a continuous line with Monorail Rails Kit. 2. Place your chosen dock inline with the track. 3. Use Labeller to name the dock Home. 4. Place one station inline at the other end and use the Labeller to name it Mine. Use Monorail Unified Station for cargo, gas, or liquid transfer, or Monorail Passenger Station for a passenger platform. 5. Power the dock. Trains can consume large amounts of power at high speeds; the default 5 m/s is slower but uses less. The dock also supplies power and data through connected monorail pieces. 6. Sit in either driver seat. Use the Browse Destination Screen buttons until Mine is the highlighted destination, then press Commit Destination. 7. Your train will now drive itself to Mine. 8. At Mine, select Home and commit it. The dock is a station, so the train can return to it. That is a complete automatic shuttle. A single train may reverse and reuse the same track safely. Choosing A Destination Every dock and renameable station should have a unique Labeller name. The cab screen lets you browse all reachable destinations and Commit Destination starts automatic travel. To select the same destination with IC10, hash the exact visible name, including capitalization: s train Setting HASH("Mine") Point a LogicTransmitter at the train dock, or reach the dock through its connected cable data network. Setting=0 clears the destination. Negative hashes are normal; do not take their absolute value or shorten them. Manual Driving Sit in either driver seat and use the W/S keys for cab-forward throttle. The Q key leaves the seat. Center the throttle near a dock or station and automatic docking will capture the stopping point. Selecting and committing a destination returns the train to automatic control. Manual driving follows the currently selected physical track. Slow down before curves, slopes, switches, and rail ends. A train can derail when it enters an unselected switch branch or the end of the track too quickly; obstructions and collisions also remain real. If It Does Not Move No destinations appear - confirm the dock and station are part of one continuous rail network, then check that the train's lights and dashboard screen are powered. Destination appears but the train waits - confirm the dock has power and On=1. If you added a switch or signal, check that it allows the train to leave. Cargo or gas does not transfer - continue with Monorail B - Stations and Transfer. Continue From Here Load passengers, items, gas, or liquid: Monorail B - Stations and Transfer Add a branch: Monorail C - Switches and Routing Run several trains on shared track: Monorail D - Signals and Shared Track Control a train with IC10: Monorail E - IC10 Train Control Build a self-running schedule: Monorail F - Timetables and LogicStack Browse every part: Monorail H - Parts Catalogue

- **Key:** MonorailGuide

---

## Monorail B - Stations and Transfer

Passenger Stops Use Monorail Passenger Station for a complete boarding platform. A Passenger Monorail Train can stop at any monorail station, not only passenger platforms. Each door has its own button inside the train. Doors can also be controlled with IC10 or a timetable. Close them before departure and make sure passengers are seated. Unified Station The Monorail Unified Station is an inline destination for items, gas, and liquid. Its controls describe movement from the station into or out of the train: Mode 0 Import - load the train from the connected chute or pipe network Mode 1 Export - unload the train into the connected chute or pipe network Setting 0 Atmos - transfer gas and liquid Setting 1 Cargo - transfer items Set Open=1 on the docked Cargo Monorail Train, Atmos Monorail Train, or Cargo and Atmos Monorail Train. After roughly two seconds, the station connects and transfer begins. Open is the train's transfer gate; changing the station Mode or Setting does not open it. For cargo, connect a chute to the station's chute port. For atmospherics, connect the yellow gas port and/or blue liquid port. The station separates gas and liquid during export and can load both during import. Atmospheric Pump The Monorail Unified Station already contains its own pump. Do not add another pump directly in front of its ports. Maximum controls the integrated pump from 0 to 200 L per tick; the default is 40. The Atmos Monorail Train and Cargo and Atmos Monorail Train tanks are rated to 60 MPa. Their contents undergo normal phase changes and temperature changes, including heating from solar radiation. Cover atmospheric docks when solar heating would be a problem. Reliable Transfer Stops For manual operation: 1. Select the Monorail Unified Station as the destination. 2. Wait for the train to arrive and finish docking. 3. Set the station Mode and Setting using IC10 or the station's display computers. 4. Set Open=1 using IC10 or the button beside the physical throttle on the train's arm console. 5. Wait for the cargo to transfer. The station disconnects automatically when the train departs. For automation, use Open and the train's quantity or atmospheric readings through IC10. Timetables provide ToggleCargoBay and WaitForCargoEmpty; see Monorail F - Timetables and LogicStack. See also: Monorail A - Start Here | Monorail E - IC10 Train Control

- **Key:** MonorailStationGuide

---

## Monorail Block Signal

An automatic, directional entrance to a protected rail block. Block shape, signal orientation, placement, and troubleshooting are covered in Monorail D - Signals and Shared Track. A Monorail Route Signal can replace this signal at an ordinary block boundary and adds switch-route alignment. Related: Monorail Signal | Monorail Route Signal Connects to Logic Transmitter

- **Key:** ThingMonorialBlockSignal
- **Prefab Name:** MonorialBlockSignal
- **Prefab Hash:** -1794432543
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Monorail Signals Kit
**Constructed Things:**
  - NameOfThing=Monorail Signals Kit, PrefabHash=-1337434550, PageLink=ThingItemMonorailSignalsKit

---

## Monorail C - Switches and Routing

One Switch, Three Ends The buildable Monorail Left Rail Switch and Monorail Right Rail Switch each have one common stem and two branches: A - common stem B - connected to A when Setting=0 C - connected to A when Setting=1 From the common end A, Setting chooses either B or C. A train cannot cross directly from B to C through this switch. Use the lever or write Setting through IC10. Power and data remain connected through all three ends, but trains can use only the selected physical path. Who Moves The Switch An automatic train can retain a destination beyond a misaligned switch, but the train itself does not normally move that switch. It waits before the unavailable path until the switch is changed. You can change the switch Setting manually or with IC10. Do not change a switch underneath a train. You may also automate switches with a Monorail Route Signal. It can align and reserve the required switches inside its block before releasing an automatic train. See Monorail D - Signals and Shared Track. Train Route Mode The IC10 logic value Mode selects how the train chooses its journey. The model front and rear are identified by the Front and Rear locomotive door-button labels. Mode 0 - shortest distance in either direction, regardless of current switch alignment (default) Mode 1 - depart only toward the model front Mode 2 - depart only toward the model rear Mode 3 - prefer the model front; use the rear only when no frontward journey exists Mode 4 - fewest unsatisfied switch changes in either direction, then shortest distance Modes 1-3 decide which end of the train may lead the departure. In the permitted direction, the train first prefers paths needing fewer switch changes and then the shorter distance. Mode 0 is the exception: it chooses true shortest distance even when another path is already aligned. A destination can still be reachable when a switch currently points the wrong way. The train keeps the selected destination and continues when the physical path is aligned. Selecting the dock or station already beneath the train means stay there; it does not request a lap around a loop. Automatic Direction Marker The Monorail One-Way Marker restricts automatic route planning on one supported straight rail. Automatic trains may cross that rail only in the arrow direction. The marker affects only automatic trains and does not behave like a signal or stop a train. Manual drivers can cross it in either direction. If markers on the same rail point in opposite directions, automatic trains will not use that rail. Troubleshooting The train waits before a switch - align it manually, automate Setting, or protect the route with a Monorail Route Signal. The train chose a longer aligned path in Mode 0 - it should not; Mode 0 is distance-first. Check whether the shorter journey is actually connected and permitted by direction markers. See also: Monorail D - Signals and Shared Track | Monorail G - Designing Large Networks

- **Key:** MonorailSwitchGuide

---

## Monorail Curved Rail (10m)

A curved monorail track segment with a wide 10-meter radius. Use this rail to build gentle, sweeping turns where space allows. Connects end-to-end with all other rail types. See also: Monorail A - Start Here

- **Key:** ThingStructureRailCurve10
- **Prefab Name:** StructureRailCurve10
- **Prefab Hash:** 81735133
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

## Monorail Curved Rail (14m)

A curved monorail track segment with a wide 14-meter radius. Use this rail to build gentle, sweeping turns where space allows. Connects end-to-end with all other rail types. See also: Monorail A - Start Here

- **Key:** ThingStructureRailCurve14
- **Prefab Name:** StructureRailCurve14
- **Prefab Hash:** 62056900
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

## Monorail D - Signals and Shared Track

When You Need Signals One train on one line needs no signals. Add signals when two or more automatic trains can occupy the same track or when a train must wait before a switch route is ready. Signals attach to a rail and face one travel direction. Leave enough clear track before a signal for the complete train to stop. Three Signal Types Monorail Signal - manual, bidirectional red/green stop signal; Setting=0 red and Setting=1 green Monorail Block Signal - automatic, directional entrance to a protected block Monorail Route Signal - automatic directional block signal that can also reserve and align a switch route inside its own block The Monorail Signal is controlled through IC10 and a LogicTransmitter. Automatic block and route signals calculate their own aspects and reject Setting writes. A Monorail Route Signal can replace a Monorail Block Signal at an ordinary block boundary. It performs slightly more routing work, so use it where an approaching train needs switches aligned and prefer Monorail Block Signal elsewhere. How A Block Is Formed Starting behind an automatic signal, the railway follows every connected continuation until it reaches the next correctly facing automatic signal or signals. Current switch Setting does not erase the other authored branches from that protected shape. A backwards-facing automatic signal is transparent to travel in the other direction. Use the Sensor Processing Unit (Monorail Blocks) in Sensor Lenses to see the resulting blocks while building. This lets one block: fan out from one entrance to several exits merge several entrances into one exit cover a chain of conflicting switches protect overlapping bidirectional track from both ends Directional views that overlap the same physical rail share occupancy and reservations. A train in that shared span therefore protects it against conflicting traffic from either direction. Why An Automatic Signal Stays Red An automatic signal remains red when its protected track is occupied or reserved by conflicting traffic. A Monorail Route Signal also remains red until the approaching train's switch path has been established and reserved. Use the Sensor Processing Unit (Monorail Blocks) in Sensor Lenses to see the complete block bands. The Monorail Motherboard shows the network, train positions, switch states, signals, and occupancy. Useful Placement Patterns Bidirectional single track: Put a correctly facing automatic signal for each direction at both ends of the shared section. Merge or split: Put holding signals before trains enter the conflicting switch area and boundaries only after routes have separated. Station throat: Treat a chain of conflicting switches as one protected block. Do not create an internal boundary unless a complete train can safely wait there. Use a Monorail One-Way Marker where automatic traffic through the throat should travel in only one direction. Route setting: Use Monorail Route Signal at the holding point when switches inside the block must be aligned for the selected destination. Manual Drivers Manual driving ignores automatic Monorail Block Signal and Monorail Route Signal decisions, so the driver must watch switch alignment and other trains. Physical obstructions, collisions, and a red manually controlled Monorail Signal still apply. See also: Monorail C - Switches and Routing | Monorail G - Designing Large Networks

- **Key:** MonorailSignalGuide

---

## Monorail Debug SPU

A sensor for your Sensor Lenses. When powered, it visualizes internal train, route, signal, and movement diagnostics. Normal monorail operation does NOT require it - however - if might be useful if you run into issues. You can only SPAWN this item in Creative mode - there is no way so obtain this in Survival mode. When using it, your frame rate WILL drop significantly, especially on large networks. You can limit what is visualized using the monorail debuglens command and the menu it brings up. The sensor will visualize the following: For gameplay diagnostics, use the Monorail Motherboard or Sensor Processing Unit (Monorail Blocks). The debug sensor should only be used if you want to understand how certain things work. It does NOT give you any superpowers in survival mode. You are not missing out if you do not have it.

- **Key:** ThingItemSensorProcessingUnitMonorailDebug
- **Prefab Name:** ItemSensorProcessingUnitMonorailDebug
- **Prefab Hash:** -1087884332
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No

---

## Monorail Docks Kit

A construction kit for building monorail docks. Docks are the home base for your trains - place one to begin a train network or add additional docks to add trains to existing networks. This kit can build: Cargo Monorail Train - Cargo dock (standard freight train) Atmos Monorail Train - Tank dock (atmospheric gas transport train) Passenger Monorail Train - Passenger dock (passenger transport train) Cargo and Atmos Monorail Train - Combined cargo and atmospheric dock Each dock type spawns its own train variant. A dock is also an inline rail and a selectable station. Use Monorail Rails Kit to connect it to other docks and stations. See also: Monorail A - Start Here | Monorail B - Stations and Transfer

- **Key:** ThingItemMonorailDocksKit
- **Prefab Name:** ItemMonorailDocksKit
- **Prefab Hash:** -164820803
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 10
- **Paintable:** No
**Build Recipe:**
  - Printer: Autolathe (Tier Two)
    - 10000 x Energy + 3 x Gold (from Ingot (Gold)) + 25 x Steel (from Ingot (Steel)) + 2 x Solder (from Ingot (Solder)) + 5 x Silicon (from Ingot (Silicon))

**Constructed From Kits:**
  - NameOfThing=Passenger Monorail Train, PrefabHash=-778167576, PageLink=ThingStructureRailDockPassenger
  - NameOfThing=Cargo Monorail Train, PrefabHash=-968345069, PageLink=ThingStructureRailDockCargo
  - NameOfThing=Atmos Monorail Train, PrefabHash=284032212, PageLink=ThingStructureRailDockAtmos
  - NameOfThing=Cargo and Atmos Monorail Train, PrefabHash=1321796820, PageLink=ThingStructureRailDockUniversal

---

## Monorail E - IC10 Train Control

Connect To The Train Point a LogicTransmitter at a train dock or reach the dock through its connected cable data network. The custom logic section on the Stationpedia page for Cargo Monorail Train, Atmos Monorail Train, Passenger Monorail Train, or Cargo and Atmos Monorail Train is the complete value reference. A minimal destination command is: s train Setting HASH("Mine") Setting is the exact signed hash of a named dock or station. Setting=0 clears the destination. Names are case-sensitive and negative hash values are valid. Most Useful Values Setting (R/W) - destination name hash PositionX (R) - current dock/station name hash while parked; 0 elsewhere Idle (R) - 1 only while parked at a dock or station VelocityMagnitude (R) - actual speed TimeToDestination (R) - ETA in seconds, rounded up to 10 seconds Maximum (R/W) - speed limit, clamped to 1-30 Mode (R/W) - journey policy described in Monorail C - Switches and Routing On (R/W) - train enabled Open (R/W) - cargo, gas, and liquid transfer gate Activate (W) - a positive value toggles all passenger doors Quantity (R) - items, or occupied seats on a Passenger Monorail Train Lock (R) - 1 while obstruction braking is active PowerActual (R) - current power draw in watts SoundAlert (R/W) - announcement index; resets to -1 after playback The Atmos Monorail Train and Cargo and Atmos Monorail Train also expose Pressure, Temperature, TotalMoles, Volume, and VolumeOfLiquid. Simple Shuttle Controller This example waits for 10 seconds whenever the train is parked at Home or Mine, then sends it to the other destination. It assumes d0 refers to the train dock. alias train d0 define HOME HASH("Home") define MINE HASH("Mine") start: l r0 train PositionX beq r0 HOME goMine beq r0 MINE goHome yield j start goMine: sleep 10 s train Setting MINE j start goHome: sleep 10 s train Setting HOME j start Use the actual names shown on the dock and station. Without the sleep instructions, this shuttle would depart again immediately. For transfers, add Open control only after the train reports Idle at the intended Monorail Unified Station. Announcements Write one of these indices to SoundAlert. Playback has a seven-second cooldown, is heard inside the train, and resets SoundAlert to -1. 0 Please remain seated so we can continue our journey safely 1 Arriving at next station shortly 2 Next station: Main Station 3 Next station: Main Base 4 Next station: Atmospherics Complex 5 Next station: Rocket Silo 6 Next station: Mining Outpost 7 Next station: Mining Outpost (North) 8 Next station: Mining Outpost (South) 9 Next station: Mining Outpost (East) 10 Next station: Mining Outpost (West) 11 Thank you for choosing the Monorail today 12 Please stand clear of the doors The Passenger Monorail Train also provides: 13 ExMix Corp - Riding on the Monorail 14 WIKUS - KERNKRAFT 400 - Zombie Nation 15 JacksonTheStratocaster - The Monorail Man For a schedule that continues without a running IC10 program, use Monorail F - Timetables and LogicStack.

- **Key:** MonorailLogicGuide

---

## Monorail F - Timetables and LogicStack

What Is This? This feature is optional. Ordinary IC10 logic can control a train through a LogicTransmitter or cable. A timetable is useful when the train should keep executing a schedule after the IC Housing has been switched off or removed. Every Cargo Monorail Train, Atmos Monorail Train, Passenger Monorail Train, and Cargo and Atmos Monorail Train has a built-in 64-slot memory. This stack behaves differently from normal stack devices. An IC10 program writes commands into the dock with put. The dock then executes those commands itself, repeatedly and continuously while the train has power. The timetable persists through world saves. Slots 0-53 - writable timetable instructions Slots 54-62 - live read-only train status Slot 63 - read-only program counter Before You Start You need an IC Housing with an IC chip, data-connected to the train dock. If you know how put and get work, you have enough IC10 knowledge to begin. Load a timetable safely: 1. Write Halt (15) to slot 0. 2. Write every other instruction and data slot. 3. Replace slot 0 with the intended first instruction. The dock executes as soon as values arrive. Halt prevents it from departing with a half-written schedule. Packed Encoding Most instruction slots contain one integer in the same packed format used by normal stack devices: bits 0-7 - opcode bits 8-15 - argument 1, or the low byte of a 16-bit argument bits 16-23 - argument 2, or the high byte of a 16-bit argument Pre-calculate a value with: value = opcode + (arg1 * 256) + (arg2 * 65536) For example, SetSpeed(10) is 2 + (10 * 256) = 2562. Station hashes are the exception. GotoStationHash (1) and WaitForStationHash (20) take two slots. Put the opcode in the first and the complete signed HASH("Station Name") in the next. Never pack, truncate, or take the absolute value of the hash. put d0 1 HASH("Main Station") put d0 0 1 A two-slot instruction cannot begin at slot 53. The Internal Memory section of each train's Stationpedia page also shows every instruction layout. Instruction Reference Movement and transfer 1 GotoStationHash - following slot is the full station-name hash 2 SetSpeed - arg1 is speed in m/s, clamped to 1-30 3 SetDoors - arg1 is 0 close or 1 open; arg2 is the door mask 17 ToggleCargoBay - arg1 is 0 closed or 1 open Wait conditions 9 WaitForIdle - wait until parked at any dock or station 10 WaitForDoorClear - wait until no unseated passenger remains aboard 11 WaitForCargoEmpty - wait until the item count is zero 12 WaitForSleep - bits 8-23 are in-game seconds 14 WaitForPassenger - wait until an unseated passenger is aboard 19 WaitForSeatsOccupied - arg1 is the minimum occupied-seat count 20 WaitForStationHash - following slot is the full hash; wait until parked there Timetable flow control 0 Nop - skip this slot 13 JumpToAddress - bits 8-23 are target slot 0-53 15 Halt - remain here until this slot is overwritten 16 DeleteTimetable - clear the timetable and destination 18 BranchIfSeatsOccupied - jump to the address in bits 8-23 when any seat is occupied Lights and sound 4 SetInteriorLights - arg1 0 off, 1 on, or 255 unchanged; arg2 color 5 SetFrontLights - same layout for the front locomotive 6 SetRearLights - same layout for the rear locomotive 7 PlaySound - arg1 is the index in Monorail E - IC10 Train Control 8 HonkHorn - no arguments Light colors are 0 white, 1 red, 2 green, 3 blue, 4 yellow, 5 cyan, 6 magenta, and 7 orange. Use 255 to leave a light setting unchanged. The executor handles up to 32 non-Nop instructions per tick and scans no more than 54 slots. Blocking waits hold the program counter and retry on the next tick. Reaching the end of slot 53 wraps to slot 0. Passenger Door Masks SetDoors affects only the doors selected by its eight-bit mask. Mask 0 is a special shorthand for all doors. Bit 0 Loco Front Right; bit 1 Loco Front Left Bit 2 Passenger Front Right; bit 3 Passenger Front Left Bit 4 Passenger Rear Right; bit 5 Passenger Rear Left Bit 6 Loco Rear Right; bit 7 Loco Rear Left Useful masks: 0 all doors 3 both front-locomotive doors 12 both front-passenger doors 48 both rear-passenger doors 192 both rear-locomotive doors 170 all left doors 85 all right doors Live Output Read these plain values with get. Writes to slots 54-63 are ignored. 54 current dock/station name hash; 0 unless parked at one 55 target dock/station name hash 56 actual speed in m/s 57 contents count: items, or occupied seats on a Passenger Monorail Train 58 idle: 1 parked at a dock or station, otherwise 0 59 open-door bitmask 60 occupied-seat count 61 ETA in seconds, rounded up to 10 seconds 62 obstruction braking: 1 blocked, 0 clear 63 program counter get r0 d0 54 # current destination hash get r1 d0 58 # idle state get r2 d0 63 # instruction currently executing Useful Pre-Calculated Values SetSpeed(10) 2562; SetSpeed(20) 5122; SetSpeed(30) 7682 Open all doors 259; close all doors 3 Open transfer gate 273; close transfer gate 17 Wait 10 s 2572; wait 30 s 7692; wait 60 s 15372 Wait for one occupied seat 275 WaitForIdle 9; WaitForDoorClear 10; WaitForCargoEmpty 11; WaitForPassenger 14; Halt 15 Example - Passenger Shuttle This program visits Alpha Station and Beta Station, opening all doors for 30 seconds at each. Load slots 1-16 while slot 0 contains Halt (15), then replace slot 0 with 1. put d0 0 15 put d0 1 HASH("Alpha Station") put d0 2 20 put d0 3 HASH("Alpha Station") put d0 4 259 put d0 5 7692 put d0 6 10 put d0 7 3 put d0 8 1 put d0 9 HASH("Beta Station") put d0 10 20 put d0 11 HASH("Beta Station") put d0 12 259 put d0 13 7692 put d0 14 10 put d0 15 3 put d0 16 13 put d0 0 1 Slot 16 is JumpToAddress(0), packed as 13. WaitForStationHash prevents an unexpected stop elsewhere from advancing the schedule. WaitForDoorClear at slots 6 and 14 prevents closing while a passenger is standing. Example - Cargo Shuttle This program unloads completely at Depot, then spends 30 seconds loading at Mine. Configure both destinations with Monorail Unified Station: Depot as Export Cargo and Mine as Import Cargo. put d0 0 15 put d0 1 HASH("Depot") put d0 2 20 put d0 3 HASH("Depot") put d0 4 273 put d0 5 11 put d0 6 17 put d0 7 1 put d0 8 HASH("Mine") put d0 9 20 put d0 10 HASH("Mine") put d0 11 273 put d0 12 7692 put d0 13 17 put d0 14 13 put d0 0 1 There is no WaitForCargoFull instruction. Use a fixed loading time as above, or let a running IC10 controller decide when to close the gate. Troubleshooting The train moved while loading the program - put Halt in slot 0 first. A named destination fails - put the full signed hash in the slot after the opcode. The train leaves after stopping somewhere else - use WaitForStationHash, not only WaitForIdle. Doors close on a standing passenger - add WaitForDoorClear before SetDoors(close). A transfer never begins - confirm the train is at a Monorail Unified Station, Open is enabled, and Mode/Setting match the job. The loop appears stuck - read slot 63 to find the blocking instruction. See also: Monorail E - IC10 Train Control | Monorail B - Stations and Transfer

- **Key:** MonorailStackGuide

---

## Monorail G - Designing Large Networks

Grow A Working Railway A large network uses the same rules as the first shuttle. Rails provide geometry, switches select physical paths, destinations say where a train wants to go, and signals protect shared track. Build in layers: 1. Make one dock and one other named station work on plain track. 2. Add one branch with Monorail Left Rail Switch or Monorail Right Rail Switch. 3. Automate that switch or protect it with a Monorail Route Signal. 4. Add automatic signals when another train shares the track. 5. Expand only after the smaller layout is understandable on the Monorail Motherboard. Passing Places And Parallel Routes A passing place uses a switch at each end to form parallel tracks. Protect the shared approaches and give each path clear entry and exit boundaries. Journey policy matters. Mode 0 takes the shortest physical distance even if that needs switch changes. Mode 4 first minimizes unsatisfied switch changes and then distance. A Monorail Route Signal can align and reserve the selected route; an ordinary Monorail Block Signal protects occupancy but does not set switches. Merges, Splits, And Intersections At a merge, several entrances compete for one shared exit. Put automatic signals before each branch enters the conflict area and end the block only after routes separate. At a split, put the holding signal before the first switch. If several switches form one intersection, treat the conflicting area as one block unless a complete train can safely wait inside it. Rails that merely cross visually are not connected. Confirm real connections and switch paths on the Monorail Motherboard. Large Stations A multi-platform terminal is a fan of ordinary switches and individually named station pieces. Give every platform a unique name, such as Central P01 through Central P08. Put holding signals before the first conflicting switch. Keep the throat as one block unless internal stopping positions are intentionally safe. Put exit boundaries after the complete train clears the shared switches. Use Monorail Route Signal where the selected platform route should be aligned automatically. Leave enough approach track for the longest train to stop. Remember that every dock is also a selectable station. A yard can therefore route another train back to a named Cargo Monorail Train, Atmos Monorail Train, Passenger Monorail Train, or Cargo and Atmos Monorail Train. Several Trains For each shared area, answer: Where can a complete train wait without blocking unrelated traffic? Which automatic signal protects entry from each allowed direction? Which switch settings must be stable before the train enters? Should trains pass through this section in one direction or both? Automatic signals handle occupancy and route reservations. IC10 or Monorail Route Signal handles switch alignment. Never flip a switch underneath a train. Manual drivers bypass automatic block decisions and are responsible for the live route and other traffic. See What The Railway Sees The Monorail Motherboard gives a top-down view of rails, destinations, switches, signals, block occupancy, and trains. Use the Sensor Processing Unit (Monorail Blocks) while placing signals to see the protected block bands directly on the railway. See also: Monorail C - Switches and Routing | Monorail D - Signals and Shared Track | Monorail F - Timetables and LogicStack

- **Key:** MonorailNetworkGuide

---

## Monorail H - Parts Catalogue

TrainMod Parts Select an entry below for its Stationpedia page. For a guided first build, begin with Monorail A - Start Here.

- **Key:** MonorailCatalogGuide

---

## Monorail Left Rail Switch

A left-branching switch. Setting=0 selects the straight A-B path; Setting=1 selects branch A-C. Use the lever or write Setting through IC10. Rail power remains conductive through all three ends. Be careful not to run into a dead end: Trains can derail! See also: Monorail C - Switches and Routing Connects to Logic Transmitter

- **Key:** ThingStructureRailSwitchLeft
- **Prefab Name:** StructureRailSwitchLeft
- **Prefab Hash:** 455106217
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Monorail Switches Kit
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
  - LogicName=Connection, LogicAccessTypes=2
**Constructed Things:**
  - NameOfThing=Monorail Switches Kit, PrefabHash=496624275, PageLink=ThingItemMonorailSwitchesKit

---

## Monorail Motherboard

A motherboard that renders a live track diagram of a monorail network when inserted into a Kit (Computer) or Laptop. The screen fits the track layout into a live top-down overview showing trains, stations, docks, signals, switch states, block occupancy, and physical segments. With this, you can monitor and Debug your networks with ease. See also: Monorail G - Designing Large Networks

- **Key:** ThingItemMonorailMotherboard
- **Prefab Name:** ItemMonorailMotherboard
- **Prefab Hash:** 1272083768
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
**Build Recipe:**
  - Printer: Electronics Printer (Tier Two)
    - 1000 x Energy + 3 x Gold (from Ingot (Gold)) + 4 x Solder (from Ingot (Solder)) + 10 x Silicon (from Ingot (Silicon))


---

## Monorail One-Way Marker

Automatic trains may cross the attached rail only in the direction shown by the marker. The rail remains physically bidirectional: manual driving can cross it in either direction. Multiple markers on one rail stack; opposing markers intentionally make that rail unavailable to automatic routing while leaving it manually traversable. This is NOT actually a signal and creates NO block, reservation, obstacle, or other signal features. It can be attached only to supported straight ordinary rail geometry. See also: Monorail C - Switches and Routing

- **Key:** ThingMonorailRailOneWayMarker
- **Prefab Name:** MonorailRailOneWayMarker
- **Prefab Hash:** 441609344
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Monorail Signals Kit
**Constructed Things:**
  - NameOfThing=Monorail Signals Kit, PrefabHash=-1337434550, PageLink=ThingItemMonorailSignalsKit

---

## Monorail Passenger Station

Players can board and disembark (passenger) trains here. Turnstiles open for approaching players, and the displays can show live arrival / ETA and boarding information. The station receives power through conductive rail from a reachable dock. See also: Monorail B - Stations and Transfer Connects to Logic Transmitter

- **Key:** ThingStructureRailPassengerStation
- **Prefab Name:** StructureRailPassengerStation
- **Prefab Hash:** -1558303138
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=2 x Monorail Stations Kit
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Monorail Stations Kit, PrefabHash=-511293804, PageLink=ThingItemMonorailStationKit

---

## Monorail Power draw Adapter

A device that taps power from the nearest train dock on the same rail network and re-exports it as usable electricity on a cable network. Place it on a straight rail and connect a cable to the output port to supply power to your base or outpost. The rail only bills the dock for what is actually consumed on the output side - if nothing is drawing power, the dock pays nothing. Efficiency: only 83% - for every 20 kW delivered to the cable network, the dock draws approximately 24 kW. Nothing is free, not even in space. Each dock supports any number of Power draw Adapters simultaneously, with a combined output cap of 60 kW. Each rail receives an equal share of that cap regardless of its actual consumption: with 3 rails each gets 20 kW; with 4 rails each gets 15 kW. The dock will never accept power from the same cable network the rail outputs to, preventing feedback loops. Power is lost if the dock is unpowered or turned off. Related: Cargo Monorail Train | Passenger Monorail Train | Atmos Monorail Train See also: Monorail A - Start Here

- **Key:** ThingStructureRailAdapterPower
- **Prefab Name:** StructureRailAdapterPower
- **Prefab Hash:** -1307261915
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=1 x Monorail Power draw Adapter Kit
**Connections:**
  - LogicName=Power and Data Output, LogicAccessTypes=0
**Constructed Things:**
  - NameOfThing=Monorail Power draw Adapter Kit, PrefabHash=-828052736, PageLink=ThingItemMonorailRailAdapterPowerKit

---

## Monorail Power draw Adapter Kit

Kit for constructing a Monorail Power draw Adapter. See also: Monorail Power draw Adapter

- **Key:** ThingItemMonorailRailAdapterPowerKit
- **Prefab Name:** ItemMonorailRailAdapterPowerKit
- **Prefab Hash:** -828052736
- **Memory Size:** 0 B
- **Memory Access:** None
- **Stack Size:** 10
- **Paintable:** No
**Build Recipe:**
  - Printer: Autolathe (Tier Two)
    - 2500 x Energy + 3 x Gold (from Ingot (Gold)) + 2 x Copper (from Ingot (Copper)) + 2 x Steel (from Ingot (Steel)) + 2 x Solder (from Ingot (Solder))

**Constructed From Kits:**
  - NameOfThing=Monorail Power draw Adapter, PrefabHash=-1307261915, PageLink=ThingStructureRailAdapterPower

---

## Monorail Rail (10m)

A straight 10-meter monorail track segment. Snaps to the 2x2 grid and connects end-to-end with other rail segments, docks, and stations to form a rail network. See also: Monorail A - Start Here

- **Key:** ThingStructureRail10
- **Prefab Name:** StructureRail10
- **Prefab Hash:** 1688036069
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=3 x Monorail Rails Kit
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Monorail Rails Kit, PrefabHash=-1514871690, PageLink=ThingItemMonorailsKit

---

## Monorail Rail (14m)

A straight 14-meter monorail track segment. Snaps to the 2x2 grid and connects end-to-end with other rail segments, docks, and stations to form a rail network. See also: Monorail A - Start Here

- **Key:** ThingStructureRail14
- **Prefab Name:** StructureRail14
- **Prefab Hash:** 1676715772
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=3 x Monorail Rails Kit
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Monorail Rails Kit, PrefabHash=-1514871690, PageLink=ThingItemMonorailsKit

---

## Monorail Rail (18m)

A straight 18-meter monorail track segment. Snaps to the 2x2 grid and connects end-to-end with other rail segments, docks, and stations to form a rail network. See also: Monorail A - Start Here

- **Key:** ThingStructureRail18
- **Prefab Name:** StructureRail18
- **Prefab Hash:** 1783032535
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Build States:**
  - Description=4 x Monorail Rails Kit
**Connections:**
  - LogicName=Connection, LogicAccessTypes=0
  - LogicName=Connection, LogicAccessTypes=1
**Constructed Things:**
  - NameOfThing=Monorail Rails Kit, PrefabHash=-1514871690, PageLink=ThingItemMonorailsKit

---


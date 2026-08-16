# Portable Liquid Tank Mk II - Rubbish

## Portable Liquid Tank Mk II

This portable tank stores liquid and is fully insulated. You can bolt one to a Portables Connector using a Wrench, then connect it to a pipe network to refill it. You can refill a Liquid Canister by attaching it to the tank's striped section.

- **Key:** ThingDynamicMKIILiquidCanisterEmpty
- **Prefab Name:** DynamicMKIILiquidCanisterEmpty
- **Prefab Hash:** 2130739600
- **Max Pressure:** 20265 kPa
- **Volume:** 790L
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
- **Convection Factor:** 0
- **Radiation Factor:** 0
- **Solar Heating Factor:** 0
**Slots:**
| Name | Type | Index |
|---|---|---|
| Liquid Canister | Liquid Canister | 0 |

**Constructed Things:**
  - NameOfThing=Kit (Portable Liquid Tank Mk II), PrefabHash=-638019974, PageLink=ThingItemKitDynamicMKIILiquidCanister

---

## Portable Solar Panel

- **Key:** ThingPortableSolarPanel
- **Prefab Name:** PortableSolarPanel
- **Prefab Hash:** 2043318949
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
| Charge | 0 |
| ChargeRatio | 0 |
| Class | 0 |
| MaxQuantity | 0 |
| PrefabHash | 0 |
| ReferenceId | 0 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Battery | Battery | 0 |

**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 200 x Energy + 5 x Iron (from Ingot (Iron)) + 3 x Gold (from Ingot (Gold)) + 5 x Copper (from Ingot (Copper))


---

## Portable Work Cone

- **Key:** ThingDynamicWorkCone
- **Prefab Name:** DynamicWorkCone
- **Prefab Hash:** -1052087580
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
**Constructed Things:**
  - NameOfThing=Kit Portable Work Cone, PrefabHash=-422133032, PageLink=ThingItemKitDynamicWorkCone

---

## Portables Connector

- **Key:** ThingStructurePortablesConnector
- **Prefab Name:** StructurePortablesConnector
- **Prefab Hash:** -899013427
- **Base Power Draw:** 10 W
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** Yes
- **Placeable In Rocket:** True
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
| Portable Slot | Portable Slot | 0 |

**Build States:**
  - Description=1 x Kit (Portables Connector)
**Connections:**
| Name | Value |
|---|---|
| Pipe Input | 0 |
| Pipe Liquid Input 2 | 1 |

**Constructed Things:**
  - NameOfThing=Kit (Portables Connector), PrefabHash=1041148999, PageLink=ThingItemKitPortablesConnector

---

## Portables Package

- **Key:** ThingItemPortablesPackage
- **Prefab Name:** ItemPortablesPackage
- **Prefab Hash:** 1459105919
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Slots:**
| Name | Type | Index |
|---|---|---|
| None | None | 0 |
| None | None | 1 |
| None | None | 2 |
| None | None | 3 |
| None | None | 4 |
| None | None | 5 |


---

## Potato

Potatoes are a simple, fast growing crop that can keep Stationeers alive in emergencies.

- **Key:** ThingItemPotato
- **Prefab Name:** ItemPotato
- **Prefab Hash:** 1929046963
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 10
- **Nutrition Quality:** Low (-25% hydration capacity)
- **Growth Time:** 50min 1s
- **Stack Size:** 20
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 1.47 kK (1200oC)
**Life Requirements:**
  - Name=Inhaled Gasses, Value=Carbon Dioxide 8.64 Moles per hour , Gene=Gas production, ValueSize=18
  - Name=Exhaled Gasses, Value=Oxygen 8.64 Moles per hour , Gene=Gas production, ValueSize=18
  - Name=Toxic Gasses, Value=Pollutant, Methane, Silanol, Hydrochloric Acid, Hydrazine, , Gene=Toxins resistance, ValueSize=18
  - Name=Water usage, Value=0.432 Moles per hour, Gene=Water usage, ValueSize=18
  - Name=Min grow temperature, Value=0°C, Gene=Low temperature resistance, ValueSize=18
  - Name=Max grow temperature, Value=50°C, Gene=High temperature resistance, ValueSize=18
  - Name=Min ideal grow temperature, Value=20°C, Gene=Low temperature resistance, ValueSize=18
  - Name=Max ideal grow temperature, Value=30°C, Gene=High temperature resistance, ValueSize=18
  - Name=Min grow pressure, Value=25kPa, Gene=Low pressure resistance, ValueSize=18
  - Name=Max grow pressure, Value=200kPa, Gene=High pressure resistance, ValueSize=18
  - Name=Min ideal grow pressure, Value=50kPa, Gene=Low pressure resistance, ValueSize=18
  - Name=Max ideal grow pressure, Value=100kPa, Gene=High pressure resistance, ValueSize=18
  - Name=Light per day, Value=5min 0s, Gene=Light per day, ValueSize=18
  - Name=Darkness per day, Value=3min 20s, Gene=Darkness per day, ValueSize=18
  - Name=Time until toxin damage, Value=5min 0s, Gene=Toxins tolerance, ValueSize=18
  - Name=Time until drought damage, Value=30min 0s, Gene=Drought tolerance, ValueSize=18
  - Name=Time until frozen damage, Value=5min 0s, Gene=Low temperature tolerance, ValueSize=18
  - Name=Time until overheat damage, Value=5min 0s, Gene=High temperature tolerance, ValueSize=18
  - Name=Time until suffocate damage, Value=1h 0min 0s, Gene=Suffocation tolerance, ValueSize=18
  - Name=Time until low pressure damage, Value=10min 0s, Gene=Low pressure tolerance, ValueSize=18
  - Name=Time until high pressure damage, Value=10min 0s, Gene=High pressure tolerance, ValueSize=18
  - Name=Time until light damage, Value=1h 0min 0s, Gene=Light tolerance, ValueSize=18
  - Name=Time until darkness damage, Value=1h 0min 0s, Gene=Darkness tolerance, ValueSize=18
**Constructed From Kits:**
  - NameOfThing=Potato Seeds, PrefabHash=1005571172, PageLink=ThingSeedBag_Potato
**Found In Fermentation:**
  - NameOfThing=Liquid Alcohol, QuantityOfThing=8 mol
  - NameOfThing=Polluted Water, QuantityOfThing=0.4 mol
**Used In:**
  - NameOfThing=Microwave, PrefabHash=-1136173965, PageLink=ThingApplianceMicrowave
  - NameOfThing=Automated Oven, PrefabHash=-1672404896, PageLink=ThingStructureAutomatedOven
  - NameOfThing=Fermenter, PrefabHash=1103525139, PageLink=ThingStructureFermenter

---

## Potato

- **Key:** ReagentPotato
- **Reagents Type:** Potato
**Found In Ore:**
  - NameOfThing=Baked Potato, QuantityOfThing=1
  - NameOfThing=Potato, QuantityOfThing=1

---

## Potato Seeds

Grow a Potato.

- **Key:** ThingSeedBag_Potato
- **Prefab Name:** SeedBag_Potato
- **Prefab Hash:** 1005571172
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

## Powdered Eggs

A high-nutrient cooked food, which can be canned.

- **Key:** ThingItemCookedPowderedEggs
- **Prefab Name:** ItemCookedPowderedEggs
- **Prefab Hash:** -1712264413
- **Memory Size:** 0 B
- **Memory Access:** None
- **Nutrition:** 11
- **Nutrition Quality:** Ok
- **Stack Size:** 10
- **Paintable:** No
- **Flashpoint:** 373 K (100oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Automated Oven (Tier One)
    - 4 x Egg (from Egg, Egg)
  - Printer: Microwave (Tier One)
    - 4 x Egg (from Egg, Egg)

**Used In:**
  - NameOfThing=Basic Packaging Machine, PrefabHash=-749191906, PageLink=ThingAppliancePackagingMachine
  - NameOfThing=Advanced Packaging Machine, PrefabHash=-463037670, PageLink=ThingStructureAdvancedPackagingMachine

---

## Power Connector

Attaches a Kit (Portable Generator) to a power network.

- **Key:** ThingStructurePowerConnector
- **Prefab Name:** StructurePowerConnector
- **Prefab Hash:** -782951720
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
| Portable slot | Portable slot | 0 |

**Build States:**
  - Description=1 x Kit (Power Connector)
**Connections:**
| Name | Value |
|---|---|
| Power Input | 0 |

**Constructed Things:**
  - NameOfThing=Kit (Power Connector), PrefabHash=839924019, PageLink=ThingItemPowerConnector

---

## Power Control

Under distant suns and demanding environments, Stationeer systems need to balance reliability, resilience and versatility. The power control board allows remote enabling and disabling of selected devices, disconnecting manual operation. The circuit board has two modes: 'Link' switches all devices on or off; 'Toggle' switches each device to their alternate state.

- **Key:** ThingCircuitboardPowerControl
- **Prefab Name:** CircuitboardPowerControl
- **Prefab Hash:** -1923778429
- **Memory Size:** 0 B
- **Memory Access:** None
- **Paintable:** No
- **Flashpoint:** 393 K (120oC)
- **Auto Ignition:** 573 K (300oC)
**Build Recipe:**
  - Printer: Electronics Printer (Tier One)
    - 100 x Energy + 5 x Gold (from Ingot (Gold)) + 5 x Copper (from Ingot (Copper))


---

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
| Name | Value |
|---|---|
| Connection | 0 |

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
| Name | Value |
|---|---|
| Connection | 0 |
| Power Input | 1 |

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
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0, 1 |
| OccupantHash | 0, 1 |
| Quantity | 0, 1 |
| Damage | 0, 1 |
| Class | 0, 1 |
| MaxQuantity | 0, 1 |
| PrefabHash | 0, 1 |
| On | 0, 1 |
| SortingClass | 0, 1 |
| ReferenceId | 0, 1 |
| FreeSlots | 0, 1 |
| TotalSlots | 0, 1 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Appliance 1 | Appliance 1 | 0 |
| Appliance 2 | Appliance 2 | 1 |

**Build States:**
  - Description=1 x Kit (Tables)
**Connections:**
| Name | Value |
|---|---|
| Connection | 0 |
| Connection | 1 |

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
**Mode:**
| Name | Value |
|---|---|
| Outward | 0 |
| Inward | 1 |

**Connections:**
| Name | Value |
|---|---|
| Connection | 0 |
| Pipe Output | 1 |
| Connection | 2 |

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
**Mode:**
| Name | Value |
|---|---|
| Outward | 0 |
| Inward | 1 |

**Connections:**
| Name | Value |
|---|---|
| Connection | 0 |
| Pipe Output | 1 |
| Connection | 2 |

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
| Name | Value |
|---|---|
| Pipe Input | 0 |
| Pipe Liquid Output | 1 |
| Connection | 2 |

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
| Name | Value |
|---|---|
| Pipe Input | 0 |
| Pipe Input 2 | 1 |
| Power and Data Output | 2 |

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
| Name | Value |
|---|---|
| Pipe Liquid Input | 0 |
| Pipe Liquid Input 2 | 1 |
| Power and Data Output | 2 |

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
| Name | Value |
|---|---|
| Pipe Input | 0 |
| Pipe Output | 1 |
| Connection | 2 |

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
| Name | Value |
|---|---|
| Connection | 0 |

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
| Name | Value |
|---|---|
| Pipe Input | 0 |
| Connection | 1 |

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
| Name | Value |
|---|---|
| Connection | 0 |
| Connection | 1 |
| Power and Data Output | 2 |

**Constructed Things:**
  - NameOfThing=Kit (Pumped Liquid Engine), PrefabHash=1921918951, PageLink=ThingItemKitPumpedLiquidEngine

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
**Life Requirements:**
  - Name=Inhaled Gasses, Value=Carbon Dioxide 8.64 Moles per hour , Gene=Gas production, ValueSize=18
  - Name=Exhaled Gasses, Value=Oxygen 8.64 Moles per hour , Gene=Gas production, ValueSize=18
  - Name=Toxic Gasses, Value=Pollutant, Methane, Silanol, Hydrochloric Acid, Hydrazine, , Gene=Toxins resistance, ValueSize=18
  - Name=Water usage, Value=0.432 Moles per hour, Gene=Water usage, ValueSize=18
  - Name=Min grow temperature, Value=0°C, Gene=Low temperature resistance, ValueSize=18
  - Name=Max grow temperature, Value=50°C, Gene=High temperature resistance, ValueSize=18
  - Name=Min ideal grow temperature, Value=20°C, Gene=Low temperature resistance, ValueSize=18
  - Name=Max ideal grow temperature, Value=30°C, Gene=High temperature resistance, ValueSize=18
  - Name=Min grow pressure, Value=25kPa, Gene=Low pressure resistance, ValueSize=18
  - Name=Max grow pressure, Value=200kPa, Gene=High pressure resistance, ValueSize=18
  - Name=Min ideal grow pressure, Value=50kPa, Gene=Low pressure resistance, ValueSize=18
  - Name=Max ideal grow pressure, Value=100kPa, Gene=High pressure resistance, ValueSize=18
  - Name=Light per day, Value=8min 20s, Gene=Light per day, ValueSize=18
  - Name=Darkness per day, Value=1min 40s, Gene=Darkness per day, ValueSize=18
  - Name=Time until toxin damage, Value=5min 0s, Gene=Toxins tolerance, ValueSize=18
  - Name=Time until drought damage, Value=30min 0s, Gene=Drought tolerance, ValueSize=18
  - Name=Time until frozen damage, Value=5min 0s, Gene=Low temperature tolerance, ValueSize=18
  - Name=Time until overheat damage, Value=5min 0s, Gene=High temperature tolerance, ValueSize=18
  - Name=Time until suffocate damage, Value=1h 0min 0s, Gene=Suffocation tolerance, ValueSize=18
  - Name=Time until low pressure damage, Value=10min 0s, Gene=Low pressure tolerance, ValueSize=18
  - Name=Time until high pressure damage, Value=10min 0s, Gene=High pressure tolerance, ValueSize=18
  - Name=Time until light damage, Value=1h 0min 0s, Gene=Light tolerance, ValueSize=18
  - Name=Time until darkness damage, Value=1h 0min 0s, Gene=Darkness tolerance, ValueSize=18
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

## Pumpkin

- **Key:** ReagentPumpkin
- **Reagents Type:** Pumpkin
**Found In Ore:**
  - NameOfThing=Cooked Pumpkin, QuantityOfThing=1
  - NameOfThing=Pumpkin, QuantityOfThing=1

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
| Name | Value |
|---|---|
| Pipe Liquid Input | 0 |
| Pipe Output | 1 |
| Connection | 2 |

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
| Name | Type | Index |
|---|---|---|
| Input | Input | 0 |
| Output | Output | 1 |

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
| Name | Value |
|---|---|
| Data Input | 0 |
| Data Output | 1 |
| Connection | 2 |

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
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0, 1 |
| OccupantHash | 0, 1 |
| Quantity | 0, 1 |
| Damage | 0, 1 |
| Class | 0, 1 |
| MaxQuantity | 0, 1 |
| PrefabHash | 0, 1 |
| SortingClass | 0, 1 |
| ReferenceId | 0, 1 |
| FreeSlots | 0, 1 |
| TotalSlots | 0, 1 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Import | Import | 0 |
| Export | Export | 1 |

**Build States:**
  - Description=1 x Kit (Recycler)
**Connections:**
| Name | Value |
|---|---|
| Chute Input | 0 |
| Chute Output | 1 |
| Connection | 2 |
| Connection | 3 |

**Constructed Things:**
  - NameOfThing=Kit (Recycler), PrefabHash=849148192, PageLink=ThingItemKitRecycler

---

## Red Coloring

- **Key:** ReagentRed Coloring
- **Unit:** g

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
- **Convection Factor:** 0
- **Radiation Factor:** 0
- **Solar Heating Factor:** 1.63
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |
| OccupantHash | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |
| Quantity | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |
| Damage | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |
| Class | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |
| MaxQuantity | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |
| PrefabHash | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |
| SortingClass | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |
| ReferenceId | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |
| FreeSlots | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |
| TotalSlots | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Import | Import | 0 |
| Export | Export | 1 |
| Storage | Storage | 2 |
| Storage | Storage | 3 |
| Storage | Storage | 4 |
| Storage | Storage | 5 |
| Storage | Storage | 6 |
| Storage | Storage | 7 |
| Storage | Storage | 8 |
| Storage | Storage | 9 |
| Storage | Storage | 10 |
| Storage | Storage | 11 |
| Storage | Storage | 12 |
| Storage | Storage | 13 |
| Storage | Storage | 14 |
| Storage | Storage | 15 |
| Storage | Storage | 16 |
| Storage | Storage | 17 |
| Storage | Storage | 18 |
| Storage | Storage | 19 |
| Storage | Storage | 20 |
| Storage | Storage | 21 |
| Storage | Storage | 22 |
| Storage | Storage | 23 |
| Storage | Storage | 24 |
| Storage | Storage | 25 |
| Storage | Storage | 26 |
| Storage | Storage | 27 |
| Storage | Storage | 28 |
| Storage | Storage | 29 |
| Storage | Storage | 30 |
| Storage | Storage | 31 |
| Storage | Storage | 32 |
| Storage | Storage | 33 |
| Storage | Storage | 34 |
| Storage | Storage | 35 |
| Storage | Storage | 36 |
| Storage | Storage | 37 |
| Storage | Storage | 38 |
| Storage | Storage | 39 |
| Storage | Storage | 40 |
| Storage | Storage | 41 |
| Storage | Storage | 42 |
| Storage | Storage | 43 |
| Storage | Storage | 44 |
| Storage | Storage | 45 |
| Storage | Storage | 46 |
| Storage | Storage | 47 |
| Storage | Storage | 48 |
| Storage | Storage | 49 |
| Storage | Storage | 50 |
| Storage | Storage | 51 |
| Storage | Storage | 52 |
| Storage | Storage | 53 |
| Storage | Storage | 54 |
| Storage | Storage | 55 |
| Storage | Storage | 56 |
| Storage | Storage | 57 |
| Storage | Storage | 58 |
| Storage | Storage | 59 |
| Storage | Storage | 60 |
| Storage | Storage | 61 |
| Storage | Storage | 62 |
| Storage | Storage | 63 |
| Storage | Storage | 64 |
| Storage | Storage | 65 |
| Storage | Storage | 66 |
| Storage | Storage | 67 |
| Storage | Storage | 68 |
| Storage | Storage | 69 |
| Storage | Storage | 70 |
| Storage | Storage | 71 |
| Storage | Storage | 72 |
| Storage | Storage | 73 |
| Storage | Storage | 74 |
| Storage | Storage | 75 |
| Storage | Storage | 76 |
| Storage | Storage | 77 |
| Storage | Storage | 78 |
| Storage | Storage | 79 |
| Storage | Storage | 80 |
| Storage | Storage | 81 |
| Storage | Storage | 82 |
| Storage | Storage | 83 |
| Storage | Storage | 84 |
| Storage | Storage | 85 |
| Storage | Storage | 86 |
| Storage | Storage | 87 |
| Storage | Storage | 88 |
| Storage | Storage | 89 |
| Storage | Storage | 90 |
| Storage | Storage | 91 |
| Storage | Storage | 92 |
| Storage | Storage | 93 |
| Storage | Storage | 94 |
| Storage | Storage | 95 |
| Storage | Storage | 96 |
| Storage | Storage | 97 |
| Storage | Storage | 98 |
| Storage | Storage | 99 |
| Storage | Storage | 100 |
| Storage | Storage | 101 |

**Build States:**
  - Description=1 x Kit (Vending Machine Refrigerated)
  - Description=2 x Plastic Sheets
  - Description=Screwdriver
**Connections:**
| Name | Value |
|---|---|
| Chute Input | 0 |
| Chute Output | 1 |
| Connection | 2 |
| Connection | 3 |

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
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0 |
| OccupantHash | 0 |
| Quantity | 0 |
| Damage | 0 |
| Charge | 0 |
| ChargeRatio | 0 |
| Class | 0 |
| MaxQuantity | 0 |
| PrefabHash | 0 |
| ReferenceId | 0 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Battery | Battery | 0 |

**Build Recipe:**
  - Printer: Tool Manufactory (Tier Two)
    - 1500 x Energy + 5 x Copper (from Ingot (Copper)) + 5 x Steel (from Ingot (Steel)) + 5 x Solder (from Ingot (Solder))

**Mode:**
| Name | Value |
|---|---|
| Mode0 | 0 |
| Mode1 | 1 |


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
| Name | Type | Index |
|---|---|---|
| None | None | 0 |
| None | None | 1 |
| None | None | 2 |
| None | None | 3 |
| None | None | 4 |
| None | None | 5 |


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
**Life Requirements:**
  - Name=Inhaled Gasses, Value=Carbon Dioxide 8.64 Moles per hour , Gene=Gas production, ValueSize=18
  - Name=Exhaled Gasses, Value=Oxygen 8.64 Moles per hour , Gene=Gas production, ValueSize=18
  - Name=Toxic Gasses, Value=Pollutant, Methane, Silanol, Hydrochloric Acid, Hydrazine, , Gene=Toxins resistance, ValueSize=18
  - Name=Water usage, Value=0.864 Moles per hour, Gene=Water usage, ValueSize=18
  - Name=Min grow temperature, Value=0°C, Gene=Low temperature resistance, ValueSize=18
  - Name=Max grow temperature, Value=50°C, Gene=High temperature resistance, ValueSize=18
  - Name=Min ideal grow temperature, Value=20°C, Gene=Low temperature resistance, ValueSize=18
  - Name=Max ideal grow temperature, Value=30°C, Gene=High temperature resistance, ValueSize=18
  - Name=Min grow pressure, Value=25kPa, Gene=Low pressure resistance, ValueSize=18
  - Name=Max grow pressure, Value=200kPa, Gene=High pressure resistance, ValueSize=18
  - Name=Min ideal grow pressure, Value=50kPa, Gene=Low pressure resistance, ValueSize=18
  - Name=Max ideal grow pressure, Value=100kPa, Gene=High pressure resistance, ValueSize=18
  - Name=Light per day, Value=10min 0s, Gene=Light per day, ValueSize=18
  - Name=Darkness per day, Value=5min 0s, Gene=Darkness per day, ValueSize=18
  - Name=Time until toxin damage, Value=5min 0s, Gene=Toxins tolerance, ValueSize=18
  - Name=Time until drought damage, Value=5min 0s, Gene=Drought tolerance, ValueSize=18
  - Name=Time until frozen damage, Value=5min 0s, Gene=Low temperature tolerance, ValueSize=18
  - Name=Time until overheat damage, Value=5min 0s, Gene=High temperature tolerance, ValueSize=18
  - Name=Time until suffocate damage, Value=1h 0min 0s, Gene=Suffocation tolerance, ValueSize=18
  - Name=Time until low pressure damage, Value=10min 0s, Gene=Low pressure tolerance, ValueSize=18
  - Name=Time until high pressure damage, Value=10min 0s, Gene=High pressure tolerance, ValueSize=18
  - Name=Time until light damage, Value=1h 0min 0s, Gene=Light tolerance, ValueSize=18
  - Name=Time until darkness damage, Value=1h 0min 0s, Gene=Darkness tolerance, ValueSize=18
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

## Rice

- **Key:** ReagentRice
- **Reagents Type:** Rice
- **Unit:** g
**Found In Ore:**
  - NameOfThing=Cooked Rice, QuantityOfThing=1
  - NameOfThing=Rice, QuantityOfThing=1

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
**Build States:**
  - Description=1 x Kit (Avionics)
  - Description=Screwdriver 2 x Electronic Parts
  - Description=Welding Torch 4 x Steel Sheets
**Mode:**
| Name | Value |
|---|---|
| Invalid | 0 |
| None | 1 |
| Mine | 2 |
| Survey | 3 |
| Discover | 4 |
| Chart | 5 |
| Deploy | 6 |
| Surface Scan | 7 |
| Transfer | 8 |

**Connections:**
| Name | Value |
|---|---|
| Connection | 0 |

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
**Build States:**
  - Description=1 x Kit (Rocket Celestial Tracker)
  - Description=Screwdriver 2 x Electronic Parts
  - Description=Welding Torch 4 x Steel Sheets
**Connections:**
| Name | Value |
|---|---|
| Connection | 0 |

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
| LineNumber | 0 |
| SortingClass | 0 |
| ReferenceId | 0 |
| FreeSlots | 0 |
| TotalSlots | 0 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Programmable Chip | Programmable Chip | 0 |

**Build States:**
  - Description=1 x Kit (Rocket Circuit Housing)
**Mode:**
| Name | Value |
|---|---|
| Number | 0 |
| String | 1 |

**Connections:**
| Name | Value |
|---|---|
| Power and Data Input | 0 |

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
- **Convection Factor:** 0
- **Radiation Factor:** 0
- **Solar Heating Factor:** 0.271
**Build States:**
  - StationBuildCostInsert
**Connections:**
| Name | Value |
|---|---|
| Pipe Input | 0 |
| Connection | 1 |


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
| Name | Value |
|---|---|
| Pipe Output | 0 |
| Connection | 1 |

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
| FilterType | 0 |
| ReferenceId | 0 |
| FreeSlots | 0 |
| TotalSlots | 0 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Gas Filter | Gas Filter | 0 |

**Build States:**
  - Description=1 x Kit (Rocket Atmospherics)
  - Description=Wrench 4 x Kit (Pipe)
**Mode:**
| Name | Value |
|---|---|
| Idle | 0 |
| Active | 1 |

**Connections:**
| Name | Value |
|---|---|
| Pipe Input | 0 |
| Pipe Output | 1 |
| Pipe Waste | 2 |
| Connection | 3 |

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
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0, 1 |
| OccupantHash | 0, 1 |
| Quantity | 0, 1 |
| Damage | 0, 1 |
| Class | 0, 1 |
| MaxQuantity | 0, 1 |
| PrefabHash | 0, 1 |
| SortingClass | 0, 1 |
| ReferenceId | 0, 1 |
| FreeSlots | 0, 1 |
| TotalSlots | 0, 1 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Import | Import | 0 |
| Export | Export | 1 |

**Build States:**
  - Description=1 x Kit (Rocket Manufactory)
  - Description=Welding Torch 2 x Steel Sheets
  - Description=4 x Cable Coil
  - Description=Welding Torch 2 x Plastic Sheets
  - Details=Manufactures at Tier One , Description=Screwdriver
**Resources Used:**
  - NameOfThing=Ingots, PrefabHash=0, PageLink=IngotPage
**Connections:**
| Name | Value |
|---|---|
| Chute Input | 0 |
| Chute Output | 1 |
| Connection | 2 |
| Connection | 3 |

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
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0, 1 |
| OccupantHash | 0, 1 |
| Quantity | 0, 1 |
| Damage | 0, 1 |
| Class | 0, 1 |
| MaxQuantity | 0, 1 |
| PrefabHash | 0, 1 |
| SortingClass | 0, 1 |
| ReferenceId | 0, 1 |
| FreeSlots | 0, 1 |
| TotalSlots | 0, 1 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Export | Export | 0 |
| Drill Head Slot | Drill Head Slot | 1 |

**Build States:**
  - Description=1 x Kit (Rocket Miner)
  - Description=2 x Electronic Parts
**Connections:**
| Name | Value |
|---|---|
| Chute Output | 0 |
| Connection | 1 |

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
| Scanner Head Slot | Scanner Head Slot | 0 |

**Build States:**
  - Description=1 x Kit (Rocket Scanner)
  - Description=Welding Torch 1 x Steel Sheets
**Connections:**
| Name | Value |
|---|---|
| Power and Data Output | 0 |

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

- **Content Type:** Guide
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
- **Convection Factor:** 4.33
- **Radiation Factor:** 4.33
- **Solar Heating Factor:** 4.33
**Logic Slots:**
| Name | Value |
|---|---|
| Occupied | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 |
| OccupantHash | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 |
| Quantity | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 |
| Damage | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 |
| Charge | 2, 3, 4 |
| ChargeRatio | 2, 3, 4 |
| Class | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 |
| MaxQuantity | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 |
| PrefabHash | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 |
| ReferenceId | 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 |

**Slots:**
| Name | Type | Index |
|---|---|---|
| Entity | Entity | 0 |
| Entity | Entity | 1 |
| Battery | Battery | 2 |
| Battery | Battery | 3 |
| Battery | Battery | 4 |


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


# LogicType.CompletionRatio - LogicType.RatioHeliumInput2

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

## LogicType.ElevatorSpeed

Current speed of the elevator

- **Key:** LogicTypeElevatorSpeed

---

## LogicType.EnergyConvected

The energy convected with the surroundings on the last atmospheric tick, in Joules. Positive values remove heat from the internal atmosphere (cooling); negative values add heat.

- **Key:** LogicTypeEnergyConvected

---

## LogicType.EnergyRadiated

The energy radiated to the surroundings on the last atmospheric tick, in Joules, net of solar heating. Positive values remove heat from the internal atmosphere (cooling); negative values add heat.

- **Key:** LogicTypeEnergyRadiated

---

## LogicType.EntityState

The current entity state, such as whether it is dead, unconscious or alive, expressed as a state integer.

- **Key:** LogicTypeEntityState

---

## LogicType.EnvironmentEfficiency

The Environment Efficiency reported by the machine, as a float between 0 and 1

- **Key:** LogicTypeEnvironmentEfficiency

---

## LogicType.Error

1 if device is in error state, otherwise 0

- **Key:** LogicTypeError

---

## LogicType.ExhaustVelocity

The velocity of the exhaust gas in m/s

- **Key:** LogicTypeExhaustVelocity

---

## LogicType.ExportCount

How many items exported since last ClearMemory

- **Key:** LogicTypeExportCount

---

## LogicType.Extended

Extended

- **Key:** LogicTypeExtended

---

## LogicType.Filtration

The current state of the filtration system, for example Filtration = 1 for a Hardsuit sets filtration to On

- **Key:** LogicTypeFiltration

---

## LogicType.FlightControlRule

Flight control rule of rocket. None = 0, No AutoPilot. Normal = 1, Target Decent Apex of 60m. Alternate = 2, Velocity to High - Full throttle. Alternate2 = 3, Target an appropriate decent velocity as velocity is too low. FinalApproach = 4, Descend towards launch mount in a controlled manner.

- **Key:** LogicTypeFlightControlRule

---

## LogicType.Flush

Set to 1 to activate the flush function on the device

- **Key:** LogicTypeFlush

---

## LogicType.ForceWrite

Forces Logic Writer devices to rewrite value

- **Key:** LogicTypeForceWrite

---

## LogicType.ForwardX

The direction the entity is facing expressed as a normalized vector

- **Key:** LogicTypeForwardX

---

## LogicType.ForwardY

The direction the entity is facing expressed as a normalized vector

- **Key:** LogicTypeForwardY

---

## LogicType.ForwardZ

The direction the entity is facing expressed as a normalized vector

- **Key:** LogicTypeForwardZ

---

## LogicType.Fuel

Gets the cost of fuel to return the rocket to your current world.

- **Key:** LogicTypeFuel

---

## LogicType.Gravity

The gravitational acceleration acting on the rocket, in m/s.

- **Key:** LogicTypeGravity

---

## LogicType.Harvest

Performs the harvesting action for any plant based machinery

- **Key:** LogicTypeHarvest

---

## LogicType.HealthDamage

The total amount of health damage on the entity

- **Key:** LogicTypeHealthDamage

---

## LogicType.Horizontal

Horizontal setting of the device

- **Key:** LogicTypeHorizontal

---

## LogicType.HorizontalRatio

Radio of horizontal setting for device

- **Key:** LogicTypeHorizontalRatio

---

## LogicType.Idle

Returns 1 if the device is currently idle, otherwise 0

- **Key:** LogicTypeIdle

---

## LogicType.ImportCount

How many items imported since last ClearMemory

- **Key:** LogicTypeImportCount

---

## LogicType.Inclination

The tilt of an orbit's plane relative to the equatorial plane, measured in degrees. Defines the orbital plane's angle.

- **Key:** LogicTypeInclination

---

## LogicType.Index

The current index for the device.

- **Key:** LogicTypeIndex

---

## LogicType.IntegralGain

The integral gain of the PID controller. This value determines how much the controller responds to the accumulated error over time. A higher value can help eliminate steady-state errors but may also lead to oscillations or instability.

- **Key:** LogicTypeIntegralGain

---

## LogicType.InterrogationProgress

Progress of this sattellite dish's interrogation of its current target, as a ratio from 0-1

- **Key:** LogicTypeInterrogationProgress

---

## LogicType.LineNumber

The line number of current execution for an integrated circuit running on this device. While this number can be written, use with caution

- **Key:** LogicTypeLineNumber

---

## LogicType.Lock

1 if device is locked, otherwise 0, can be set in most devices and prevents the user from access the values

- **Key:** LogicTypeLock

---

## LogicType.ManualResearchRequiredPod

Sets the pod type to search for a certain pod when breaking down a pods.

- **Key:** LogicTypeManualResearchRequiredPod

---

## LogicType.Mass

The total Mass of the rocket in kilograms including fuel and cargo. The more massive the rocket the more fuel will be required to move to a new location in space.

- **Key:** LogicTypeMass

---

## LogicType.Maximum

Maximum setting of the device

- **Key:** LogicTypeMaximum

---

## LogicType.MineablesInQueue

Returns the amount of mineables AIMEe has queued up to mine.

- **Key:** LogicTypeMineablesInQueue

---

## LogicType.MineablesInVicinity

Returns the amount of potential mineables within an extended area around AIMEe.

- **Key:** LogicTypeMineablesInVicinity

---

## LogicType.MinedQuantity

The total number of resources that have been mined at the rocket's target Space Map Site.

- **Key:** LogicTypeMinedQuantity

---

## LogicType.Minimum

Minimum value for provided logic device.

- **Key:** LogicTypeMinimum

---

## LogicType.MinimumWattsToContact

Minimum required amount of watts from the dish hitting the target trader contact to start interrogating the contact

- **Key:** LogicTypeMinimumWattsToContact

---

## LogicType.Mode

Integer for mode state, different devices will have different mode states available to them

- **Key:** LogicTypeMode

---

## LogicType.NameHash

Provides the hash value for the name of the object as a 32 bit integer.

- **Key:** LogicTypeNameHash

---

## LogicType.NavPoints

The number of NavPoints at the rocket's target Space Map Location.

- **Key:** LogicTypeNavPoints

---

## LogicType.NetworkFault

Attached network is experiencing a fault, such as a pipe burst or other failure.

- **Key:** LogicTypeNetworkFault

---

## LogicType.NextWeatherEventTime

Returns in seconds when the next weather event is inbound.

- **Key:** LogicTypeNextWeatherEventTime

---

## LogicType.NextWeatherHash

NextWeatherHash provides the hash value for the name of the next weather event as a 32 bit integer.

- **Key:** LogicTypeNextWeatherHash

---

## LogicType.On

The current state of the device, 0 for off, 1 for on

- **Key:** LogicTypeOn

---

## LogicType.Open

1 if device is open, otherwise 0

- **Key:** LogicTypeOpen

---

## LogicType.OperationalTemperatureEfficiency

How the input pipe's temperature effects the machines efficiency

- **Key:** LogicTypeOperationalTemperatureEfficiency

---

## LogicType.OrbitPeriod

The time it takes for an object to complete one full orbit around another object, measured in days. Indicates the duration of the orbital cycle.

- **Key:** LogicTypeOrbitPeriod

---

## LogicType.Orientation

The orientation of the entity in degrees in a plane relative towards the north origin

- **Key:** LogicTypeOrientation

---

## LogicType.Output

The output operation for a sort handling device, such as a stacker or sorter, when in logic mode the device will only action one repetition when set zero or above and then back to -1 and await further instructions

- **Key:** LogicTypeOutput

---

## LogicType.PassedMoles

The number of moles that passed through this device on the previous simulation tick

- **Key:** LogicTypePassedMoles

---

## LogicType.Plant

Performs the planting action for any plant based machinery

- **Key:** LogicTypePlant

---

## LogicType.PositionX

The current position in X dimension in world coordinates

- **Key:** LogicTypePositionX

---

## LogicType.PositionY

The current position in Y dimension in world coordinates

- **Key:** LogicTypePositionY

---

## LogicType.PositionZ

The current position in Z dimension in world coordinates

- **Key:** LogicTypePositionZ

---

## LogicType.Power

Can be read to return if the device is correctly powered or not, set via the power system, return 1 if powered and 0 if not

- **Key:** LogicTypePower

---

## LogicType.PowerActual

How much energy the device or network is actually using

- **Key:** LogicTypePowerActual

---

## LogicType.PowerGeneration

Returns how much power is being generated

- **Key:** LogicTypePowerGeneration

---

## LogicType.PowerPotential

How much energy the device or network potentially provides

- **Key:** LogicTypePowerPotential

---

## LogicType.PowerRequired

Power requested from the device and/or network

- **Key:** LogicTypePowerRequired

---

## LogicType.PrefabHash

The hash of the structure

- **Key:** LogicTypePrefabHash

---

## LogicType.Pressure

The current pressure reading of the device

- **Key:** LogicTypePressure

---

## LogicType.PressureEfficiency

How the pressure of the input pipe and waste pipe effect the machines efficiency

- **Key:** LogicTypePressureEfficiency

---

## LogicType.PressureExternal

Setting for external pressure safety, in KPa. Represents the target pressure of the external atmosphere.

- **Key:** LogicTypePressureExternal

---

## LogicType.PressureInput

The current pressure reading of the device's Input Network

- **Key:** LogicTypePressureInput

---

## LogicType.PressureInput2

The current pressure reading of the device's Input2 Network

- **Key:** LogicTypePressureInput2

---

## LogicType.PressureInternal

Setting for internal pressure safety, in KPa. Represents the target pressure of the atmosphere inside the connected pipe network.

- **Key:** LogicTypePressureInternal

---

## LogicType.PressureOutput

The current pressure reading of the device's Output Network

- **Key:** LogicTypePressureOutput

---

## LogicType.PressureOutput2

The current pressure reading of the device's Output2 Network

- **Key:** LogicTypePressureOutput2

---

## LogicType.PressureSetting

The current setting for the internal pressure of the object (e.g. the Hardsuit Air release), in KPa

- **Key:** LogicTypePressureSetting

---

## LogicType.Progress

Progress of the rocket to the next node on the map expressed as a value between 0-1.

- **Key:** LogicTypeProgress

---

## LogicType.ProportionalGain

The proportional gain of the PID controller. This value determines how aggressively the controller responds to the error between the setpoint and the process variable. A higher value results in a faster response but may lead to overshoot or instability.

- **Key:** LogicTypeProportionalGain

---

## LogicType.Quantity

Total quantity on the device

- **Key:** LogicTypeQuantity

---

## LogicType.Ratio

Context specific value depending on device, 0 to 1 based ratio

- **Key:** LogicTypeRatio

---

## LogicType.RatioCarbonDioxide

The ratio of Carbon Dioxide in device atmosphere

- **Key:** LogicTypeRatioCarbonDioxide

---

## LogicType.RatioCarbonDioxideInput

The ratio of Carbon Dioxide in device's input network

- **Key:** LogicTypeRatioCarbonDioxideInput

---

## LogicType.RatioCarbonDioxideInput2

The ratio of Carbon Dioxide in device's Input2 network

- **Key:** LogicTypeRatioCarbonDioxideInput2

---

## LogicType.RatioCarbonDioxideOutput

The ratio of Carbon Dioxide in device's Output network

- **Key:** LogicTypeRatioCarbonDioxideOutput

---

## LogicType.RatioCarbonDioxideOutput2

The ratio of Carbon Dioxide in device's Output2 network

- **Key:** LogicTypeRatioCarbonDioxideOutput2

---

## LogicType.RatioHelium

The ratio of Helium in device's Atmosphere

- **Key:** LogicTypeRatioHelium

---

## LogicType.RatioHeliumInput

The ratio of Helium in device's Input Atmosphere

- **Key:** LogicTypeRatioHeliumInput

---

## LogicType.RatioHeliumInput2

The ratio of Helium in device's Input2 Atmosphere

- **Key:** LogicTypeRatioHeliumInput2

---


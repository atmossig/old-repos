include('shared.lua')

SWEP.PrintName	= "Race Opresser Hammer"	// 'Nice' Weapon name (Shown on HUD)	
SWEP.Slot	= 1	// Slot in the weapon selection menu
SWEP.SlotPos	= 1	// Position in the slot

// Override this in your SWEP to set the icon in the weapon selection
if (file.Exists("../materials/weapons/agentdeserteagle_icon.vmt", "GAME")) then
SWEP.WepSelectIcon	= surface.GetTextureID("weapons/weapon_agentdeserteagle")
end
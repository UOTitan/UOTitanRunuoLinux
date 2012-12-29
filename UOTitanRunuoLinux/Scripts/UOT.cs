using System;

namespace Server
{
	public static class UOT
	{
		#region UOT general constants
		public static int hungryFactor = 7;
		#endregion
		
		#region UOT combat constants
		public static int combatSpeedFactor = 3;
		
		public static float minWeaponSpeed = 5.09f;
		public static float maxWeaponSpeed = 1.5f;
		
		public static float combatCriticalFactor = 20;
		public static float combatCriticalPenalty = 20;
		
		public static float combatMaxDamageWeapon = 0.6f;
		#endregion
		
		public static int Damage( Mobile m, Mobile from, int damage){
			if(damage >= 0)
				m.Damage( damage, from );
			
			return damage;
		}
	}
}


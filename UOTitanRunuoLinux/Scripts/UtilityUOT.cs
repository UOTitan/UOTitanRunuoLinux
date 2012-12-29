using System;
using System.Collections;
using System.Collections.Generic;


namespace Server
{
	public static class UtilityUOT
	{
		public static T check<T>(Dictionary<T,float> collection) {
			float value = (float) Utility.RandomDouble();
			
			/* Correction */
			value = (float) Math.Round(value, 4);
			float rest = -0.0001f;
			
			foreach (KeyValuePair<T, float> kvp in collection) {
				if(value < (kvp.Value/100)+rest) {
					return kvp.Key;
				}
				rest += kvp.Value/100;
			}
			
			T[] keys = new T[collection.Keys.Count];
			
			collection.Keys.CopyTo(keys,0);
			
			return keys[keys.Length-1];
		}
		
		public static bool checkChance(double chance){
			double rand = Utility.RandomDouble();
			
			if(chance > rand)
				return true;
			else return false;
		}
	}
}


//==========================================================================================
//
//		OpenNETCF.Windows.Forms.RandomNumberGenerator
//		Copyright (c) 2003, OpenNETCF.org
//
//		This library is free software; you can redistribute it and/or modify it under 
//		the terms of the OpenNETCF.org Shared Source License.
//
//		This library is distributed in the hope that it will be useful, but 
//		WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or 
//		FITNESS FOR A PARTICULAR PURPOSE. See the OpenNETCF.org Shared Source License 
//		for more details.
//
//		You should have received a copy of the OpenNETCF.org Shared Source License 
//		along with this library; if not, email licensing@opennetcf.org to request a copy.
//
//		If you wish to contact the OpenNETCF Advisory Board to discuss licensing, please 
//		email licensing@opennetcf.org.
//
//		For general enquiries, email enquiries@opennetcf.org or visit our website at:
//		http://www.opennetcf.org
//
//		!!! A HUGE thank-you goes out to Casey Chesnut for supplying this class library !!!
//      !!! You can contact Casey at http://www.brains-n-brawn.com                      !!!
//
//==========================================================================================
using System;

namespace OpenNETCF.Security.Cryptography
{
	public abstract class RandomNumberGenerator
	{
		public RandomNumberGenerator()
		{

		}

		public static RandomNumberGenerator Create()
		{
			return new RNGCryptoServiceProvider();	
		}
		//public static RandomNumberGenerator Create(string rngName);
		public abstract void GetBytes(byte[] data);
		public abstract void GetNonZeroBytes(byte[] data);

	}
}

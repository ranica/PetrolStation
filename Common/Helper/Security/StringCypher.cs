using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Linq;

namespace Common.Helper.Security
{
	/// <summary>
	/// String Cypher class
	/// </summary>
	public static class StringCipher
	{
		#region Variables
		// This constant is used to determine the keysize of the encryption algorithm in bits.
		// We divide this by 8 within the code below to get the equivalent number of bytes.
		private const int		Keysize					= 256;

		// This constant determines the number of iterations for the password bytes generation function.
		private const int		DerivationIterations	= 1000;

		/// <summary>
		/// Pass phrase
		/// </summary>
		public	const string	passPhrase				= 
									@"<Guid(E6F695F1-B5FE-4E38-9842-DDDC98D3881F)>" +
									@"// {84C87F51-1626-475E-97CF-32787BD2B0EF}" +
									@"IMPLEMENT_OLECREATE(<<class>>, <<external_name>>, " +
									@"0x84c87f51, 0x1626, 0x475e, 0x97, 0xcf, 0x32, 0x78, 0x7b, 0xd2, 0xb0, 0xef);";
		#endregion

		#region Methods
		/// <summary>
		/// Encrypt
		/// </summary>
		/// <param name="plainText"></param>
		/// <param name="passPhrase"></param>
		/// <returns></returns>
		public static string encrypt (string plainText, string passPhrase)
		{
			// Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
			// so that the same Salt and IV values can be used when decrypting. 
			byte[] saltStringBytes	= Generate256BitsOfRandomEntropy ();
			byte[] ivStringBytes	= Generate256BitsOfRandomEntropy ();
			byte[] plainTextBytes	= Encoding.UTF8.GetBytes (plainText);

			Rfc2898DeriveBytes password = new Rfc2898DeriveBytes (passPhrase, saltStringBytes, DerivationIterations);
			var keyBytes = password.GetBytes (Keysize / 8);

			using (var symmetricKey = new RijndaelManaged ())
			{
				symmetricKey.BlockSize	= 256;
				symmetricKey.Mode		= CipherMode.CBC;
				symmetricKey.Padding	= PaddingMode.PKCS7;

				using (var encryptor = symmetricKey.CreateEncryptor (keyBytes, ivStringBytes))
				{
					using (var memoryStream = new MemoryStream ())
					{
						using (var cryptoStream = new CryptoStream (memoryStream, encryptor, CryptoStreamMode.Write))
						{
							cryptoStream.Write (plainTextBytes, 0, plainTextBytes.Length);
							cryptoStream.FlushFinalBlock ();

							// Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
							byte[] cipherTextBytes	= saltStringBytes;
							cipherTextBytes			= cipherTextBytes.Concat (ivStringBytes).ToArray ();
							cipherTextBytes			= cipherTextBytes.Concat (memoryStream.ToArray ()).ToArray ();

							memoryStream.Close ();
							cryptoStream.Close ();

							return Convert.ToBase64String (cipherTextBytes);
						}
					}
				}
			}
		}

		/// <summary>
		/// Decrypt
		/// </summary>
		/// <param name="cipherText"></param>
		/// <param name="passPhrase"></param>
		/// <returns></returns>
		public static string decrypt (string cipherText, string passPhrase)
		{
			// Get the complete stream of bytes that represent:
			// [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
			byte[] cipherTextBytesWithSaltAndIv = Convert.FromBase64String (cipherText);

			// Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
			byte[] saltStringBytes = cipherTextBytesWithSaltAndIv.Take (Keysize / 8).ToArray ();
			
			// Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
			byte[] ivStringBytes = cipherTextBytesWithSaltAndIv.Skip (Keysize / 8).Take (Keysize / 8).ToArray ();
			
			// Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
			byte[] cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip ((Keysize / 8) * 2).Take (cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray ();

			Rfc2898DeriveBytes	password = new Rfc2898DeriveBytes (passPhrase, saltStringBytes, DerivationIterations);
			byte[]				keyBytes = password.GetBytes (Keysize / 8);

			using (var symmetricKey = new RijndaelManaged ())
			{
				symmetricKey.BlockSize	= 256;
				symmetricKey.Mode		= CipherMode.CBC;
				symmetricKey.Padding	= PaddingMode.PKCS7;

				using (var decryptor = symmetricKey.CreateDecryptor (keyBytes, ivStringBytes))
				{
					using (var memoryStream = new MemoryStream (cipherTextBytes))
					{
						using (var cryptoStream = new CryptoStream (memoryStream, decryptor, CryptoStreamMode.Read))
						{
							byte[]	plainTextBytes		= new byte[cipherTextBytes.Length];
							int		decryptedByteCount	= cryptoStream.Read (plainTextBytes, 0, plainTextBytes.Length);

							memoryStream.Close ();
							cryptoStream.Close ();

							return Encoding.UTF8.GetString (plainTextBytes, 0, decryptedByteCount);
						}
					}
				}
			}
		}

		/// <summary>
		/// Generate 256 random Bits 
		/// </summary>
		/// <returns></returns>
		private static byte[] Generate256BitsOfRandomEntropy ()
		{
			 // 32 Bytes will give us 256 bits.
			var randomBytes = new byte[32];

			// Get bytes
			new RNGCryptoServiceProvider ().GetBytes (randomBytes);

			return randomBytes;
		} 
		#endregion
	}
}
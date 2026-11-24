
using System;
using System.Security.Cryptography;

namespace PawFect_Match.Services
{
    public class AuthenticationService
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100000;

        // Hash a password before storing it
        public string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException(
                    "Password cannot be empty.");
            }

            byte[] salt = new byte[SaltSize];

            using (RandomNumberGenerator generator =
                RandomNumberGenerator.Create())
            {
                generator.GetBytes(salt);
            }

            using (Rfc2898DeriveBytes pbkdf2 =
                new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                return "PBKDF2$" + Iterations + "$" +
                    Convert.ToBase64String(salt) + "$" +
                    Convert.ToBase64String(hash);
            }
        }

        // Verify a password during login
        public bool VerifyPassword(
            string enteredPassword,
            string storedHash)
        {
            if (string.IsNullOrEmpty(enteredPassword) ||
                string.IsNullOrEmpty(storedHash))
            {
                return false;
            }

            try
            {
                string[] parts = storedHash.Split('$');

                if (parts.Length != 4 || parts[0] != "PBKDF2")
                {
                    return false;
                }

                int iterations = int.Parse(parts[1]);

                if (iterations < 10000 || iterations > 1000000)
                {
                    return false;
                }

                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] originalHash =
                    Convert.FromBase64String(parts[3]);

                if (salt.Length != SaltSize ||
                    originalHash.Length != HashSize)
                {
                    return false;
                }

                using (Rfc2898DeriveBytes pbkdf2 =
                    new Rfc2898DeriveBytes(
                        enteredPassword, salt, iterations))
                {
                    byte[] enteredHash = pbkdf2.GetBytes(HashSize);

                    int difference = 0;

                    for (int i = 0; i < HashSize; i++)
                    {
                        difference |=
                            enteredHash[i] ^ originalHash[i];
                    }

                    return difference == 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // Basic registration validation
        public bool ValidateRegistration(
            string username,
            string email,
            string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            if (password.Length < 8)
            {
                return false;
            }

            return true;
        }
    }
}

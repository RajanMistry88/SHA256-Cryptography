# SHA256-Cryptography
SHA-2 is a set of cryptographic hash functions designed by the United States National Security Agency and first published in 2001.

In this console project you can create static hash code and also create dyanmic hash code with user input.

SHA256 is a one-way hashing algorithm. It is not an encryption algorithm; you can't decrypt it, you can merely encrypt the same bytes again and compare the hashes. 
Note:- hashing algorithms are 100% the correct way to go for storing passwords. You should never be able to decrypt a user's password.

Hash functions are a common way to protect secure sensitive data such as passwords and digital signatures. Some of the modern commonly-used hash functions are MD5, RIPEMD160, SHA1, SHA256, SHA384, and SHA512.

The NET framework provides cryptography-related functionality. using System.Security.Cryptography namespace and its classes. The HashAlgorithm class is the base class for hash algorithms including MD5, RIPEMD160, SHA1, SHA256, SHA384, and SHA512. more detail: https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=netcore-3.1

The ComputeHash method of HashAlgorithm computes a hash. It takes a byte array or stream as an input and returns a hash in the form of a byte array of 256 bits.
No matter how big the input data is, the hash will always be 256 bits. The following code snippet is an example of how to create a hash of a string.

For more detail check this : https://stackoverflow.com/questions/51960247/sha256-encrypt-and-decrypt-the-string-in-c-sharp


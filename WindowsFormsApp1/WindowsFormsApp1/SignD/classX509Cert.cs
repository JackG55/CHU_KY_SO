using Org.BouncyCastle.Cms;
using Org.BouncyCastle.X509.Store;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.SignD
{
    static class classX509Cert
    {

        private static byte[] GetDataHash(string sampleData)
        {
            //choose any hash algorithm    
            SHA1Managed managedHash = new SHA1Managed();

            return managedHash.ComputeHash(Encoding.Unicode.GetBytes(sampleData));
        }

        public static X509Certificate2 GetCertificateFromStore(string certName)
        {

            // Get the certificate store for the current user.
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            try
            {
                store.Open(OpenFlags.ReadOnly);
                // Place all certificates in an X509Certificate2Collection object.
                X509Certificate2Collection certCollection = store.Certificates;
                // If using a certificate with a trusted root you do not need to FindByTimeValid, instead:
                // currentCerts.Find(X509FindType.FindBySubjectDistinguishedName, certName, true);
                X509Certificate2Collection currentCerts = certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
                X509Certificate2Collection signingCert = currentCerts.Find(X509FindType.FindBySubjectDistinguishedName, certName, false);
                if (signingCert.Count == 0)
                    return null;
                // Return the first certificate in the collection, has the right name and is current.
                return signingCert[0];
            }
            finally
            {
                store.Close();
            }
        }
        public static byte[] Sign(byte[] data, X509Certificate2 certificate)
        {
            if (data == null)
                throw new ArgumentNullException("data");
            if (certificate == null)
                throw new ArgumentNullException("certificate");

            // setup the data to sign
            ContentInfo content = new ContentInfo(data);
            SignedCms signedCms = new SignedCms(content, false);
            CmsSigner signer = new CmsSigner(SubjectIdentifierType.IssuerAndSerialNumber, certificate);
            // create the signature
            signedCms.ComputeSignature(signer);
            return signedCms.Encode();
        }
        public static bool VerifySignatures(FileInfo contentFile, Stream signedDataStream)
        {
            CmsProcessable signedContent = null;
            CmsSignedData cmsSignedData = null;
            Org.BouncyCastle.X509.Store.IX509Store store = null;
            ICollection signers = null;
            bool verifiedStatus = false;
            try
            {
                //Org.BouncyCastle.Security.addProvider(new BouncyCastleProvider());
                signedContent = new CmsProcessableFile(contentFile);
                cmsSignedData = new CmsSignedData(signedContent, signedDataStream);
                store = cmsSignedData.GetCertificates("Collection");//.getCertificates();
                IX509Store certStore = cmsSignedData.GetCertificates("Collection");
                signers = cmsSignedData.GetSignerInfos().GetSigners();
                foreach (var item in signers)
                {
                    SignerInformation signer = (SignerInformation)item;
                    var certCollection = certStore.GetMatches(signer.SignerID);
                    IEnumerator iter = certCollection.GetEnumerator();
                    iter.MoveNext();
                    var cert = (Org.BouncyCastle.X509.X509Certificate)iter.Current;
                    verifiedStatus = signer.Verify(cert.GetPublicKey());
                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return verifiedStatus;
        }
    }
}

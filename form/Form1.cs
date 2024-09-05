using Mastercard.Developer.ClientEncryption.Core.Encryption;
using Mastercard.Developer.ClientEncryption.Core.Encryption.JWE;
using Mastercard.Developer.ClientEncryption.Core.Utils;
using Mastercard.Developer.OAuth1Signer.Core.Utils;
using Newtonsoft.Json.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mastercard.Developer.ClientEncryption.Core.Encryption.FieldLevelEncryptionConfig;

namespace form
{
    public partial class Form1 : Form
    {

        private const string basePath = "https://sandbox.api.mastercard.com/mdes";
        private const string certificatePath = "C:\\certificates\\MDES-TR-sandbox-signing.p12";
        private const string certificatePathPEM = "C:\\certificates\\certificate.pem";
        private const string certificatePassword = "Panda1881";
        private const string clientID = "3rxtyb4-tHOAeFEzRyZ-AdheWOdac4sM3HhhRXjWd8c04fdd";
        private const string consumerKey = "3rxtyb4-tHOAeFEzRyZ-AdheWOdac4sM3HhhRXjWd8c04fdd!e6f7540a297e47d0bfc2608a86e1409a0000000000000000";
        private readonly X509Certificate2 encryptionCertificate;
        private readonly System.Security.Cryptography.RSA decryptionKey;
        private readonly X509Certificate2 certificate;
        private readonly HttpClientHandler handler;
        private readonly FormUrlEncodedContent content;
        private readonly FieldLevelEncryptionConfig config;
        private readonly System.Security.Cryptography.RSA signingKey;
        private readonly ApiClient client;
        private ProductConfig Asset;
        public Form1()
        {
            InitializeComponent();
            handler = new HttpClientHandler();
            Asset = new ProductConfig();
            encryptionCertificate = EncryptionUtils.LoadEncryptionCertificate(certificatePathPEM);
            decryptionKey = EncryptionUtils.LoadDecryptionKey(certificatePath, certificatePassword, certificatePassword);
            config = FieldLevelEncryptionConfigBuilder.AFieldLevelEncryptionConfig()
                      .WithEncryptionPath("$.fundingAccountInfo.encryptedPayload.encryptedData", "$.fundingAccountInfo.encryptedPayload")
                      .WithEncryptionPath("$.encryptedPayload.encryptedData", "$.encryptedPayload")
                      .WithDecryptionPath("$.tokenDetail", "$.tokenDetail.encryptedData")
                      .WithDecryptionPath("$.encryptedPayload", "$.encryptedPayload.encryptedData")
                      .WithEncryptionCertificate(encryptionCertificate)
                      .WithDecryptionKey(decryptionKey)
                      .WithOaepPaddingDigestAlgorithm("SHA-512")
                      .WithEncryptedValueFieldName("encryptedData")
                      .WithEncryptedKeyFieldName("encryptedKey")
                      .WithIvFieldName("iv")
                      .WithOaepPaddingDigestAlgorithmFieldName("oaepHashingAlgorithm")
                      .WithEncryptionCertificateFingerprintFieldName("publicKeyFingerprint")
                      .WithValueEncoding(FieldValueEncoding.Hex)
                      .Build();
            signingKey = AuthenticationUtils.LoadSigningKey(certificatePath, certificatePassword, certificatePassword, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable);
            client = new ApiClient(signingKey, basePath, consumerKey, config);
        }

        private void tokenizeBtn_Click(object sender, EventArgs e)
        {

            var tokenizeApi = new TokenizeApi { Client = client };
            var requestDemo = StaticHelper.BuildTokenizeRequestSchema();
            var requestBody = new Tokenize()
            {
                ConsumerLanguage = requestDemo.ConsumerLanguage,
                DecisioningData = requestDemo.DecisioningData,
                FundingAccountInfo = requestDemo.FundingAccountInfo,
                RequestId = requestDemo.RequestId,
                ResponseHost = requestDemo.ResponseHost,
                TaskId = requestDemo.TaskId,
                TokenizationAuthenticationValue = requestDemo.TokenizationAuthenticationValue,
                TokenRequestorId = requestDemo.TokenRequestorId,
                TokenType = requestDemo.TokenType
            };
            TokenizeResults responseBody;
            try
            {
                requestText.Text = JsonSerializer.Serialize(requestBody);
                responseBody = tokenizeApi.CreateTokenize(requestBody);
                Asset = responseBody.ProductConfig;
                responseText.Text = responseBody.ToString();
            }
            catch (Exception ex)
            {
                responseText.Text = ex.Message.ToString();
            }

        }
        private void TransactBtn_Click(object sender, EventArgs e)
        {
            var transacApi = new TransactApi { Client = client };
            var requestBody = new Transact()
            {
                DsrpType = "",
                RequestId = "",
                ResponseHost = "",
                TokenUniqueReference = "",
                UnpredictableNumber = ""
            };
            TransactResults responseBody;
            try
            {
                requestText.Text = JsonSerializer.Serialize(requestBody);
                responseBody = transacApi.CreateTransact(requestBody);
                responseText.Text = responseBody.ToString();
            }
            catch (Exception ex)
            {
                responseText.Text = ex.Message.ToString();
            }
        }
        #region payload
        private string Payload(string value)
        {
            var config = JweConfigBuilder.AJweEncryptionConfig()
            .WithEncryptionCertificate(encryptionCertificate)
            .WithDecryptionKey(decryptionKey)
            .WithEncryptionPath("$.path.to.foo", "$.path.to.encryptedFoo")
            .WithDecryptionPath("$.path.to.encryptedFoo", "$.path.to.foo")
            .WithEncryptedValueFieldName("encryptedValue")
            .Build();
            var encryptedPayload = JweEncryption.EncryptPayload(value, config);
            return encryptedPayload;
        }
        #endregion


        private void NotifyTokenUpdatedBtn_Click(object sender, EventArgs e)
        {

            var notifyTokenUpdatedApi = new NotifyTokenUpdatedApi { Client = client };
            EncryptedPayload payload = new EncryptedPayload()
            {
                EncryptedData = new NotifyTokenEncryptedPayload()
                {
                    Tokens = []
                },
                EncryptedKey = "",
                Iv = "00000000000000000000000000000000",
                OaepHashingAlgorithm = "SHA512",
                PublicKeyFingerprint = ""
            };
            var requestBody = new NotifyTokenUpdated()
            {
                RedigitizationRequired = true,
                RequestId = "",
                ResponseHost = "",
                EncryptedPayload = payload,
            };
            NotifyTokenUpdatedResults responseBody;
            try
            {
                requestText.Text = JsonSerializer.Serialize(requestBody);
                responseBody = notifyTokenUpdatedApi.NotifyTokenUpdateForTokenStateChange(requestBody);
                responseText.Text = JsonSerializer.Serialize(responseBody);
            }
            catch (Exception ex)
            {
                responseText.Text = ex.Message.ToString();
            }
        }

        private void GetAssetBtn_Click(object sender, EventArgs e)
        {
            var getAssetApi = new GetAssetApi { Client = client };
            try
            {
                responseText.Text = JsonSerializer.Serialize(Asset);
            }
            catch (Exception ex)
            {
                responseText.Text = ex.Message.ToString();
            }
        }

        private void SuspendBtn_Click(object sender, EventArgs e)
        {
            var suspendApi = new SuspendApi { Client = client };
            var requestBody = new Suspend()
            {
                RequestId = "",
                ResponseHost = "",
                CausedBy = "",
                PaymentAppInstanceId = "",
                Reason = "",
                ReasonCode = "",
                TokenUniqueReferences = []
            };
            SuspendResults responseBody;
            try
            {
                requestText.Text = JsonSerializer.Serialize(requestBody);
                responseBody = suspendApi.CreateSuspend(requestBody);
                responseText.Text = JsonSerializer.Serialize(responseBody);
            }
            catch (Exception ex)
            {
                responseText.Text = ex.Message.ToString();
            }
        }

        private void UnsuspendBtn_Click(object sender, EventArgs e)
        {
            var unSuspendApi = new UnsuspendApi { Client = client };
            var requestBody = new UnSuspend()
            {
                RequestId = "",
                ResponseHost = "",
                CausedBy = "",
                PaymentAppInstanceId = "",
                Reason = "",
                ReasonCode = "",
                TokenUniqueReferences = []
            };
            UnSuspendResults responseBody;
            try
            {
                requestText.Text = JsonSerializer.Serialize(requestBody);
                responseBody = unSuspendApi.CreateUnsuspend(requestBody);
                responseText.Text = JsonSerializer.Serialize(responseBody);
            }
            catch (Exception ex)
            {
                responseText.Text = ex.Message.ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var deleteApi = new DeleteApi { Client = client };
            var requestBody = new Delete()
            {
                RequestId = "",
                ResponseHost = "",
                CausedBy = "",
                PaymentAppInstanceId = "",
                Reason = "",
                ReasonCode = "",
                TokenUniqueReferences = []
            };
            DeleteResults responseBody;
            try
            {
                requestText.Text = JsonSerializer.Serialize(requestBody);
                responseBody = deleteApi.DeleteDigitization(requestBody);
                responseText.Text = JsonSerializer.Serialize(responseBody);
            }
            catch (Exception ex)
            {
                responseText.Text = ex.Message.ToString();
            }
        }

        private void GetTaskStatusBtn_Click(object sender, EventArgs e)
        {
            var getTaskStatusApi = new GetTaskStatusApi { Client = client };
            var requestBody = new GetTaskStatus()
            {
                RequestId = "",
                ResponseHost = "",
                TaskId = "",
                TokenRequestorId = ""
            };
            GetTaskStatusResults responseBody;
            try
            {
                requestText.Text = JsonSerializer.Serialize(requestBody);
                responseBody = getTaskStatusApi.GetTaskStatus(requestBody);
                responseText.Text = JsonSerializer.Serialize(responseBody);
            }
            catch (Exception ex)
            {
                responseText.Text = ex.Message.ToString();
            }
        }

        private void SearchTokensBtn_Click(object sender, EventArgs e)
        {
            var searchTokenApi = new SearchTokensApi { Client = client };
            FundingAccountInfoEncryptedPayload payload = new()
            {
                EncryptedData = new FundingAccountData()
                {
                    AccountHolderData = new AccountHolderData()
                    {
                        AccountHolderAddress = new BillingAddress()
                        {
                            City = "",
                            Country = "",
                            CountrySubdivision = "",
                            Line1 = "",
                            Line2 = "",
                            PostalCode = ""
                        },
                        AccountHolderEmailAddress = "",
                        AccountHolderMobilePhoneNumber = new PhoneNumber()
                        {
                            CountryDialInCode = 0,
                            VarPhoneNumber = 0
                        },
                        AccountHolderName = "",
                        ConsumerIdentifier = ""
                    },
                    CardAccountData = new CardAccountDataInbound()
                    {
                        AccountNumber = "",
                        ExpiryMonth = "",
                        ExpiryYear = "",
                        SecurityCode = ""
                    },
                    Source = ""
                },
                EncryptedKey = "",
                Iv = "",
                OaepHashingAlgorithm = "",
                PublicKeyFingerprint = ""
            };
            FundingAccountInfo accountInfo = new ()
            {
                EncryptedPayload = payload,
                PanUniqueReference = "",
                TokenUniqueReference = ""
            };
            var requestBody = new SearchTokens()
            {
                RequestId = "",
                ResponseHost = "",
                TokenRequestorId = "",
                FundingAccountInfo = accountInfo
            };
            SearchTokensResults responseBody;
            try
            {
                requestText.Text = JsonSerializer.Serialize(requestBody);
                responseBody = searchTokenApi.SearchTokens(requestBody);
                responseText.Text = JsonSerializer.Serialize(responseBody);
            }
            catch (Exception ex)
            {
                responseText.Text = ex.Message.ToString();
            }
        }

        private void GetTokenBtn_Click(object sender, EventArgs e)
        {
            var getTaskStatusApi = new GetTokenApi { Client = client };
            var requestBody = new GetToken()
            {
                RequestId = "",
                ResponseHost = "",
                IncludeTokenDetail = "",
                PaymentAppInstanceId = "",
                TokenUniqueReference = ""
            };
            GetTokenResults responseBody;
            try
            {
                requestText.Text = JsonSerializer.Serialize(requestBody);
                responseBody = getTaskStatusApi.GetToken(requestBody);
                responseText.Text = JsonSerializer.Serialize(responseBody);
            }
            catch (Exception ex)
            {
                responseText.Text = ex.Message.ToString();
            }
        }

        private void DigitazeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

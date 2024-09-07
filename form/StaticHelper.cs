using Org.OpenAPITools.Model;

namespace form
{
    public static class StaticHelper
    {

        private static AccountHolderData BuildAccountHolderData() =>
            new AccountHolderData(
                "John Doe",
BuildBillingAddress());

        private static BillingAddress BuildBillingAddress() =>
            new BillingAddress
            {
                Line1 = "100 1st Street",
                Line2 = "Apt. 4B",
                City = "St. Louis",
                Country = "USA",
                CountrySubdivision = "MO",
                PostalCode = "61000"
            };

        private static CardAccountDataInbound BuildCardAccountDataInbound() =>
            new CardAccountDataInbound(
                "5123456789012345",
                "09",
                "25",
                "123");

        private static FundingAccountData BuildFundingAccountData() =>
            new FundingAccountData(
BuildCardAccountDataInbound(),
BuildAccountHolderData(),
                "ACCOUNT_ON_FILE");
        private static FundingAccountInfo BuildFundingAccountInfo() =>
          new FundingAccountInfo(
              string.Empty,
              string.Empty,
BuildFundingAccountInfoPayload());

        private static FundingAccountInfoEncryptedPayload BuildFundingAccountInfoPayload() =>
            new FundingAccountInfoEncryptedPayload(
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
BuildFundingAccountData());

        public static TokenizeRequestSchema BuildTokenizeRequestSchema()
        {
            return new TokenizeRequestSchema("site1.your-server.com",
                "123456",
                "CLOUD",
                "98765432101",
                "123456",
BuildFundingAccountInfo(),
                "en",
                "RHVtbXkgYmFzZSA2NCBkYXRhIC0gdGhpcyBpcyBub3QgYSByZWFsIFRBViBleGFtcGxl");
        }
    }
}
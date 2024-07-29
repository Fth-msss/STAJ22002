namespace STAJ22001.Models
{
    public class TestDataModel
    {
       
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public string Balance { get; set; }
        public int CreditCardDept { get; set; }

        public TestDataModel(string customerName, int customerId, string balance, int creditCardDept)
        {
            CustomerName = customerName;
            CustomerId = customerId;
            Balance = balance;
            CreditCardDept = creditCardDept;
        }

       

    }
}

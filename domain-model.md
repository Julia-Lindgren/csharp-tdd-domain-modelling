#Domain Models In Here

#Domain Models In Here

As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.

| Classes       | Methods                                     | Scenario                 | Outputs           |
| ------------- | ------------------------------------------- | ------------------------ | --------------    |
| Basket        | Checkout(Dictionary<String, decimal> products)|  sum all products to total  | decimal totalCost |
|               | private Dictionary<String, decimal> basket { get; set; } | property to get and set products   | Dictionary<String,Decimal> products |
|               | AddProduct(String product, decimal cost) | property to add product   | |

As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.

| Classes       | Methods                                     | Scenario                 | Outputs       |
| ------------- | ------------------------------------------- | ------------------------ | --------------|
| Receipt       | public decimal totalCost { get; set;}       |  property to get and set totalCost   | decimal totalCost |
|               | public Dictionary<String, Decimal> products { get; set; } | property to get and set products           | Dictionary<String,Decimal> products |
|               | public int quantity { get; set; }| property to get and set quantity | int quantity |
|               | PrintReceipt() | print the receipt using the properties | String receipt |
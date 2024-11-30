// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conditionals");

// Suppose you need to quickly determine whether a customer's purchase is eligible for a promotional discount.
// The details for the promotion indicate that when a purchase value is greater than 1000 euros, the purchase
// is eligible for a 100 euro discount. 
// If the purchase amount is 1000 euros or less, the purchase is eligible for a 50 euro discount.

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {discount}");

// Can also do inline, note the brackets for the expression
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

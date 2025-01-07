﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("String interpolation fun yay!");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");

// Display the product shares with one thousandth of a share (0.001) precision
Console.WriteLine($"Product Shares: {productShares:N3}"); // N3: Formats the number with a thousands separator and three decimal places

// Display the subtotal that you charge the customer formatted as currency
Console.WriteLine($"           Tax: {taxPercentage:P2}"); // P2: Formats the number as a percentage with two decimal places

// Finalize the receipt with the total amount due formatted as currency
Console.WriteLine($"  Total Billed: {total:C}"); // C: Formats the number as a currency value with the currency symbol and two decimal places

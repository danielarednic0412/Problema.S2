This project represents the solution for Problem 2 from the Internship Assignment 2026.

SieMarket is an online electronics store that processes hundreds of daily orders across Europe.  
The system models customer orders, applies discount rules, and provides basic analytics.

The solution follows a clean and modular object-oriented design:
SieMarket/
── OrderItem.cs
─ Order.cs
── OrderService.cs
── Program.cs

OrderItem
Represents a single product within an order.
- ProductName
- Quantity
- UnitPrice
- GetTotal() → Calculates item subtotal

  Order
Represents a customer order.
- CustomerName
- OrderDate
- List of OrderItems
- AddItem()
- CalculateFinalPrice()

   OrderService
Contains business logic and analytics methods:
- GetTopSpender()
- GetPopularProducts()

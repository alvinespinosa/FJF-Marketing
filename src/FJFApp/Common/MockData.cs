using FJFApp.IncomeExpenses;
using FJFApp.Model.Products;
using FJFApp.Payables;
using System;
using System.Collections.Generic;

namespace FJFApp.Common
{
    public class MockData
    {
        public static List<Transaction> Transactions()
        {
            var transactions = new List<Transaction>();

            transactions.Add(new Transaction()
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2019, 5, 10),
                BeginningBalance = 2500,
                EndingBalance = 1500,
                Profit = 600,
                Incomes = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 1500,
                        Remarks = "Test1"
                    }
                },
                Expenses = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 1500,
                        Remarks = "Test1"
                    }
                },
                Notes = "test only11111111"
            });
            transactions.Add(new Transaction()
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2019, 5, 22),
                BeginningBalance = 6500,
                EndingBalance = 100,
                Profit = 100,
                Incomes = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 400,
                        Remarks = "Test2"
                    }
                },
                Expenses = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 300,
                        Remarks = "Test1"
                    }
                },
                Notes = "test only"
            });

            transactions.Add(new Transaction()
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2019, 6, 19),
                BeginningBalance = 6500,
                EndingBalance = 100,
                Profit = 100,
                Incomes = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 400,
                        Remarks = "Test2"
                    }
                },
                Expenses = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 300,
                        Remarks = "Test1"
                    }
                },
                Notes = "test only"
            });
            transactions.Add(new Transaction()
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2019, 6, 14),
                BeginningBalance = 6500,
                EndingBalance = 100,
                Profit = 100,
                Incomes = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 400,
                        Remarks = "Test2"
                    }
                },
                Expenses = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 300,
                        Remarks = "Test1"
                    }
                },
                Notes = "test only"
            });

            return transactions;
        }

        public static List<Product> Products()
        {
            var products = new List<Product>();

            products.Add(new Product()
            {
                Id = Guid.NewGuid(),
                Section = "Hardware",
                Category = "BATTERY",
                Item = "ANGLE BAR 5.0 X 25 WHITE",
                Unit = "PCS",
                Srp = 590,
                Fare = 20,
                Price = 469,
                Active = true,
                Notes = "test only"
            });

            products.Add(new Product()
            {
                Id = Guid.NewGuid(),
                Section = "Hardware",
                Category = "BATTERY",
                Item = "ANGLE BAR 3.5 X 38 GREEN",
                Unit = "PCS",
                Srp = 580,
                Fare = 15,
                Price = 453,
                Active = false,
                Notes = "test only 123"
            });

            return products;
        }

        public static List<Payable> Payables()
        {
            var payables = new List<Payable>();

            payables.Add(new Payable()
            {
                Id = Guid.NewGuid(),
                IsPaid = false,
                NotificationDays =10,
                PaymentTerms = 1,
                PurchaseDate = new DateTime(2019,7,2),
                Items = new List<PurchaseItem>()
                {
                    new PurchaseItem
                    {
                        Item = "ANGLE BAR 5.0 X 25 WHITE",
                        Price = 250,
                        Qty = 2
                    },
                    new PurchaseItem
                    {
                        Item = "ANGLE BAR 5.0 X 25 RED",
                        Price = 1250,
                        Qty = 10
                    }
                },
                Notes = "test only"
            });

            payables.Add(new Payable()
            {
                Id = Guid.NewGuid(),
                IsPaid = true,
                NotificationDays = 10,
                PaymentTerms = 1,
                PurchaseDate = new DateTime(2019, 7, 23),
                Items = new List<PurchaseItem>()
                {
                    new PurchaseItem
                    {
                        Item = "ANGLE BAR 5.0 X 25 WHITE",
                        Price = 250,
                        Qty = 2
                    },
                    new PurchaseItem
                    {
                        Item = "ANGLE BAR 5.0 X 25 RED",
                        Price = 1250,
                        Qty = 10
                    }
                },
                Notes = "test only"
            });

            payables.Add(new Payable()
            {
                Id = Guid.NewGuid(),
                IsPaid = false,
                NotificationDays = 10,
                PaymentTerms = 2,
                PurchaseDate = new DateTime(2019, 7, 8),
                Items = new List<PurchaseItem>()
                {
                    new PurchaseItem
                    {
                        Item = "ANGLE BAR 5.0 X 25 WHITE",
                        Price = 250,
                        Qty = 2
                    },
                    new PurchaseItem
                    {
                        Item = "ANGLE BAR 5.0 X 25 RED",
                        Price = 1250,
                        Qty = 10
                    }
                },
                Notes = "test only"
            });

            return payables;
        }
    }
}

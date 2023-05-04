﻿using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands;

public class CreateCreditCardSubscriptionCommand : Notifiable<Notification>, ICommand
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Document { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public string CardHolderName { get; set; } = null!;
    public string CardNumber { get; set; } = string.Empty;
    public string LastTransactionNumber { get; set; } = string.Empty;
    public string PaymentNumber { get; set; } = string.Empty;
    public DateTime PaidDate { get; set; }
    public DateTime ExpireDate { get; set; }
    public decimal Total { get; set; }
    public decimal TotalPaid { get; set; }
    public string Payer { get; set; } = string.Empty;
    public string PayerDocument { get; set; } = string.Empty;
    public EDocumentType PayerDocumentType { get; set; }
    public string PayerEmail { get; set; } = string.Empty;
    
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string Neighborhood { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsGreaterThan(FirstName, 3, "Name.FirstName", "FirstName should have at least 3 chars")
            .IsGreaterThan(LastName, 3, "Name.LastName", "LastName should have at least 3 chars")
            .IsLowerThan(FirstName, 40, "Name.FirstName", "FirstName should have no more than 40 chars")
            .IsLowerThan(LastName, 40, "Name.LastName", "LastName should have no more than 40 chars")
        );
    }
}
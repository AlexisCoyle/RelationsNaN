using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

public class Purchase
{
    public int Id { get; set; }
    [ValidateNever]
    public List<GamePurchase> GamePurchases { get; set; }
}
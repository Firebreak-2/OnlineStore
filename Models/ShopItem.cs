namespace AvaloniaTestApp.Models;

public record ShopItem(float Price, string Name, ShopItemCategory Category);

public enum ShopItemCategory
{
    Sandwich,
    Side,
    Dessert,
    Drink,
    Meal,
}
public enum DigitalProductType
{
    BookingsService,
    MenuService,
    PagesService
}

public static class DigitalProductTypeValue
{
    public static string GetDigitalProductType(DigitalProductType type)
    {
        switch (type)
        {
            case DigitalProductType.BookingsService: return BookingsService.ToString();
            case DigitalProductType.MenuService: return MenuService.ToString();
            default: return PagesService.ToString();
        }
    }

    public static readonly string BookingsService = "Bookings Service";
    public static readonly string MenuService = "Menu Service";
    public static readonly string PagesService = "Pages Service";
}
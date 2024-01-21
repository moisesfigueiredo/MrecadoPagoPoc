using MercadoPagoPoc.Orders;
using MercadoPagoPoc.Requests;

Item item = new Item
{

    sku_number = "A123K9191938",
    category = "marketplace",
    title = "Point Mini",
    description = "This is the Point Mini",
    unit_price = 100,
    quantity = 1,
    unit_measure = "unit",
    total_amount = 1,
};

Sponsor sponsor = new Sponsor
{
    id = 662208785
};

PaymentQrCodeRequest request = new PaymentQrCodeRequest
{
    title = "Product order",
    description = "Purchase description.",
    external_reference = "reference_1",
    notification_url = "https://www.yourserver.com/notifications",
    sponsor = sponsor,
    total_amount = 100,
};

request.items.Add(item);

OrdersQRCode qrcode = new OrdersQRCode();

var result = await qrcode.GeraQrCode(request);


Console.WriteLine("Resultado: ");
Console.WriteLine("QR Code: " + result.qr_data);

Console.ReadKey();

using BusinessObjects.DTOs;
using BusinessObjects.Interfaces.Controllers;
using Sales.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSalesServices(
              builder.Configuration, "ShoppingCenterDB");

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var app = builder.Build();

app.MapPost("/createOrder",
                async (CreateOrderDTO order,
                ICreateOrderController controller) =>
                Results.Ok(await controller.CreateOrder(order)))
.WithName("CreateOrder")
.WithOpenApi();

app.MapPost("/createPayment",
                async (CreatePaymentDTO payment,
                ICreatePaymentController controller) =>
                Results.Ok(await controller.CreatePayment(payment)))
.WithName("CreatePayment")
.WithOpenApi();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();

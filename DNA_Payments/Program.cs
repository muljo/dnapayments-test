using DNA_Payments;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


BankAccountLogic bankAccountLogic = new BankAccountLogic();

app.MapGet("/bankaccount", (string accountNumber) => bankAccountLogic.GetAccount(accountNumber)).WithName("GetAccount");

app.MapPost("/bankaccount", (string name, int bankAccountType) => bankAccountLogic.CreateAccount(name, (BankAccountType) bankAccountType)).WithName("GetBankAccount");

app.MapPut("/bankaccount/freeze", (string accountNumber) => bankAccountLogic.FreezeAccount(accountNumber)).WithName("FreezeBankAccount");

app.MapPut("/bankaccount/unfreeze", (string accountNumber) => bankAccountLogic.UnfreezeAccount(accountNumber)).WithName("UnfreezeBankAccount");

app.Run();
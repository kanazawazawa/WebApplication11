using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// Example of vulnerable code that triggers CodeQL
app.MapGet("/vulnerable", async context =>
{
    var userName = context.Request.Query["username"];
    var query = $"SELECT * FROM Users WHERE Username = '{userName}'";
    
    using (var connection = new SqlConnection("your_connection_string"))
    {
        var command = new SqlCommand(query, connection);
        connection.Open();
        var reader = await command.ExecuteReaderAsync();
        // Process the results
    }
});

app.Run();

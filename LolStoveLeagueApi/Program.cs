using LolStoveLeagueApi.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.AddControllers();
builder.Services.ConfigureLoggerService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseHsts();  // HTTPS ����


app.UseHttpsRedirection();
app.UseStaticFiles();   // ���� ���� ��û ���

// ������ ���Ͻ� ����� �� �ʼ�: ���Ͻ� ����� ���� request�� ������
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthorization();
app.MapControllers();

app.Run();
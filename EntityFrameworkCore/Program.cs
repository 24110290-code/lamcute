
using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<QLNVDBContext>(options =>
    options.UseSqlServer(
        "Server=.;Database=QuanLyNhanVienDB;Trusted_Connection=True;TrustServerCertificate=True"));

var app = builder.Build();

app.Run();

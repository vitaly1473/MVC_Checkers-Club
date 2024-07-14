/*��
�� ������ ������ ���������������� ������� ������� ��� ���� ���� ������. ��������� ��������� ���������, ����. ���� ��� ������ �����.
��� ������ ������� ������� ��������� ������� ������� � ��������� ����� ���� �� ������ ������������ ������ ������.
 */
// ���� Programm.cs

// https://metanit.com/sharp/aspnetmvc/1.4.php

var builder = WebApplication.CreateBuilder(args);

// ����������� �������� MVC
// ��������� ������������ � ���������������
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles(); // ������ � ���������

// ��������� ������������� ��������� � �������������
// ��������� ��������� � �������������
/*  ����� app.MapControllerRoute ��������� ���� ������� � ������ default � �������� "{controller=Home}/{action=Index}/{id?}". 
   ������ ������ ������������� �������������� ��������� ������ �������: controller/action/id. 
   �� ���� � ������ ���� �������� �����������, ����� �������� ��������, � ����� ����� ���� �������������� �������� id.
 */
app.MapControllerRoute(
	name: "default",
	//pattern: "{controller=main}/{action=index}"
	pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();

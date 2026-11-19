\# 🏥 Clinic Booking API



REST API لنظام حجز مواعيد العيادات، مبني بـ ASP.NET Core 8 و SQL Server.



\## Features

\- Authentication بـ JWT مع Roles (Admin / Doctor / Patient)

\- إدارة التخصصات والدكاترة

\- تحديد مواعيد عمل الدكتور

\- عرض الـ slots المتاحة

\- حجز ميعاد مع منع الـ double booking

\- إلغاء الحجز بشروط (قبل الميعاد بـ 24 ساعة)

\- عرض الحجوزات للمريض والدكتور



\## Tech Stack

ASP.NET Core 8 · EF Core · SQL Server · JWT · FluentValidation · Serilog · xUnit · Docker



\## Architecture

Clean Architecture: Domain / Application / Infrastructure / Api



\## Database Design

!\[ERD](docs/erd.png)



\## Status

🚧 قيد التطوير


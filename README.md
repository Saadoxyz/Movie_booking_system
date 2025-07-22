
# 🎬 Movie Booking System

![Blazor](https://img.shields.io/badge/Built%20With-Blazor-blueviolet?style=for-the-badge&logo=blazor)
![CSharp](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp)
![License](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen?style=for-the-badge)

## 📌 Project Overview

**Event Ticket Booking System** is a lightweight, elegant web application developed using **Blazor Server**. It allows users to create, view, edit, and delete movie booking records. This is ideal for small-scale cinema or event management where seat allocation and email notifications are recorded with a stylish and user-friendly interface.

---

## 🚀 Features

- 📝 Create new movie/event ticket bookings  
- 📋 View all bookings in a tabular layout using `QuickGrid`  
- 🧾 Edit existing booking details  
- 🗑️ Delete bookings with confirmation  
- 🔍 View detailed information for each booking  
- 🎨 Fully customized UI with rich golden theme and responsive layout  
- 🗃️ Built-in validation and data annotations

---

## 🛠️ Tech Stack

| Technology | Description |
|------------|-------------|
| **Blazor Server** | UI framework for building interactive C# web apps |
| **.NET 7+** | Backend framework |
| **Entity Framework Core** | ORM used for data access |
| **QuickGrid** | Fast, customizable data grid |
| **CSS** | Custom styling for modern golden UI |
| **SQLite / SQL Server** | Compatible with EF-backed relational databases |

---

## 📂 Project Structure

```

📁 Pages/
├── Index.razor          # List all bookings
├── Create.razor         # Create a new booking
├── Edit.razor           # Edit booking info
├── Delete.razor         # Confirm & delete booking
└── Details.razor        # View detailed info of a booking

📁 Models/
└── Movie.cs             # Movie model with validation attributes

📁 Data/
└── heyContext.cs        # EF DbContext configuration

````

---

## 🧰 Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/YourUsername/EventTicketBookingSystem.git
   cd EventTicketBookingSystem
````
````
2. **Open the project** in Visual Studio or Visual Studio Code.

3. **Configure the database connection** in `appsettings.json` (SQLite, SQL Server, etc.).

4. **Apply Migrations**

   ```bash
   dotnet ef database update
   ```

5. **Run the project**

   ```bash
   dotnet run
   ```

6. Open in browser: `http://localhost:5000`


---

## 📌 Validation Rules

* **Name**: Required
* **Email**: Must be a valid email
* **Number of Seats**: Must be a positive number
* **Booking Date**: Must be a valid date

---

## 🧑‍💻 Author

**Saad Khan**
📧 \[[saad@example.com](mailto:saad@example.com)]
🌐 [GitHub Profile](https://github.com/saadoxyz)

---

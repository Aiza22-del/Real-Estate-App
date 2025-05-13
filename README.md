# Real Estate Web Application

A dynamic and interactive real estate web platform built using ASP.NET MVC and MySQL, enabling users to view, manage, and interact with property listings in real time. SignalR is integrated for instant updates, enhancing the user experience with live property status and communication.

## Features

- Property listing and detail pages
- Advanced search and filtering options
- Real-time updates using SignalR
- Admin panel to manage property listings
- Contact or inquiry forms for users
- Code First & Database First approaches used for flexibility in data modeling

## Tech Stack

- **Frontend:** HTML5, CSS3, JavaScript
- **Backend:** ASP.NET MVC (C#)
- **Database:** MySQL
- **Real-Time Communication:** SignalR
- **ORM:** Entity Framework

## How to Run Locally

### 1. Clone the Repository

```bash
git clone https://github.com/Aiza22-del/RealEstateWebApp.git
cd RealEstateWebApp
````

### 2. Open in Visual Studio

* Open the `.sln` file in **Visual Studio**
* Ensure the **NuGet packages** are restored

### 3. Configure MySQL Connection

Update the `connectionStrings` section in `Web.config`:

```xml
<connectionStrings>
  <add name="DefaultConnection" connectionString="server=localhost;user id=root;password=yourpassword;database=realestate_db;" providerName="MySql.Data.MySqlClient"/>
</connectionStrings>
```

### 4. Build and Run the Application

* Press `F5` or click **Start** in Visual Studio
* The app will launch in your browser (typically on `http://localhost:xxxx`)

## 📂 Folder Structure

```
├── Controllers/
├── Models/
├── Views/
│   ├── Home/
│   ├── Admin/
│   └── Shared/
├── Scripts/
├── Content/
├── App_Start/
├── RealEstateWebApp.sln
├── Web.config
└── README.md
```

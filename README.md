# 🌍 Population Reporting System

A C# console-based application that connects to a MySQL database and generates population-based reports. This system is developed following software engineering best practices using GitHub, GitFlow, CI/CD, and Scrum methodology.

---

## 📌 Project Overview

The application allows users to generate reports based on population statistics using the official MySQL `world` database.

Key reports include:
- Countries, cities, and capital cities sorted by population
- Top N populated locations (custom input)
- Population living in cities vs outside cities
- Language speaker statistics
- Population breakdown by region and continent

---

## 🧰 Technologies Used

- **C# (.NET 6)** – Console Application
- **MySQL** – with sample `world` database
- **Git + GitHub** – version control & collaboration
- **GitHub Actions** – for Continuous Integration (CI)
- **Docker** – optional for deployment
- **Zube.io** – for task management

---

## 🚀 Getting Started

### 🔧 Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- MySQL Server (import the `world` sample DB)
- Git
- Docker (optional)

### 🛠️ How to Build and Run

```bash
# Navigate to app folder
cd src/PopulationApp

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run

**📦 Features**

🔢 List of countries, cities, capital cities by population
🎯 Top N populated countries/cities/capitals (user input)
🌐 Region-wise and continent-wise population stats
📊 City vs non-city population comparison
🗣️ Speaker stats for major world languages
✅ Console-based output formatting
🔄 GitHub Actions CI pipeline (auto build on push)
🧪 Testing
Unit testing will be added as business logic and report services are implemented.

**🧠 Scrum Roles**

Product Owner	[Add Name]
Scrum Master	[Add Name]
Developers	Abdullah Javed, [Add more]

👥 Team Members

Abdullah Javed
[Add your teammates here]

**📄 License**
This project is for academic purposes under the ENI08112 Software Engineering Methods module at Edinburgh Napier University.

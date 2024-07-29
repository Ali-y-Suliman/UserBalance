# UserBalanceAPI


## Installation and Setup:

1- clone the repo
```bash
git clone https://github.com/Ali-y-Suliman/UserBalanceAPI.git
```

2- install dotnet ef:
```bash
dotnet tool install --global dotnet-ef
```

3- run dotnet build:
```bash
dotnet build
```

4- create the database:
```bash
dotnet ef database update
```

5- run the project:
```bash
dotnet run
```

**Note**: to run swagger:
```bash
dotnet watch run
```

---

## Usage:

TopUpAPI provides the following endpoints:

* POST  /api/UserBalance/debit/{email} - Debit on a user balance.

* POST  /api/UserBalance/credit/{email} - Credit on a user balance.

* GET  /api/UserBalance/{email} - Get the balance for a specific user.


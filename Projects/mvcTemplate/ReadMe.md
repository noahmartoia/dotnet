1) installer .net en 9.0.0

2) installer un logiciel comme xampp pour avoir un phpmyadmin et un localhost

3) modifier les information du appsettings.json pour que se soit bien les information de la base de donnée de xampp (login password)

4) ouvrire un cmd a la racine du projet et faire
  1) dotnet ef migrations add initialMigration
  2) dotnet ef database update

5) ouvrir un cmd et et faire dotnet run
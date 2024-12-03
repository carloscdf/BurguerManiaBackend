# Projeto Backend do BURGUER MANIA com ASP.NET Core e MySQL

Este projeto é um backend criado com ASP.NET Core, que utiliza Entity Framework Core para comunicação com o banco de dados MySQL. Ele também está configurado para se integrar com um frontend Angular: [BURGUER MANIA FRONTEND](https://github.com/carloscdf/BurgueMania).

---

## **Pré-requisitos**

Certifique-se de que os seguintes programas estão instalados em sua máquina:

1. **[.NET SDK](https://dotnet.microsoft.com/download)** (versão 7.0 ou superior)
2. **Um banco de dados Mysql: recomendo o XAMPP** (para gerenciar o servidor MySQL)
3. **[Node.js](https://nodejs.org/)** (se for executar o frontend Angular)

---

## **Configurando o MySQL**

1. Atualize o appsettings.json para conectar com o MySql.

2. Através do terminal entre na pasta do projeto e execute o comando `dotnet restore`.

3. Execute o comando `dotnet run`.

4. Vá até o navegador e acesse a API pelo link `http://localhost:5202/swagger`.

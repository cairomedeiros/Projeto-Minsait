# Projeto Minsait
## Projeto de desenvolvimento de uma API em .NET para o treinamento da minsait, ministrada pelo professor <a href="https://www.linkedin.com/in/rodolphopedra/">Rodolpho Pedra</a>

Aplicação em .NET 6 para desenvolvimento de uma API

### Requisitos necessários:
- Criar
- Editar
- Excluir
- Selecionar
- Acesso ao banco de dados

### Desejáveis:
- Docker

## Breve descrição da aplicação
Projeto desenvolvido para gerenciar os pacientes de uma clínica veterinária, onde será cadastrado o tutor e o pet
- cada tutor pode ter mais de um animal (paciente)
- um animal tem apenas um dono
- um animal terá um campo para indicar qual tipo de médico ir pós triagem

# Executando projeto localmente
## Pré-requisitos
- <a href="https://visualstudio.microsoft.com/pt-br/downloads/">Visual Studio</a>
- <a href="https://www.postgresql.org/download/windows/">Postgresql</a>
- Criar no Postgres um banco de dados com o nome "clinica-veterinaria"

## Configuração

1. Agora tem-se que alterar no arquivo "appsettings.json" a connection string, por default o user id é postgres
```
"ConnectionStrings": {
    "PostgreSQLConnection": "User ID={Seu user};Password={Sua senha};Host=localhost;Port=5432;Database=clinica-veterinaria;"
  }
```  
2. Agora basta rodar o projeto no Visual Studio normalmente

# Executando projeto no Docker
## Pré-requisitos
- <a href="https://www.docker.com/products/docker-desktop/">Docker Desktop</a>

## Instalação

Clone o repositório, entre na raíz do projeto e inicie o build do container com o comando "docker-compose up --build"
```
git clone https://github.com/cairomedeiros/Projeto-Minsait.git
cd Projeto-Minsait/ClinicaVeterinaria
docker-compose up --build
```
URL's de exposição no docker, com e sem swagger

```
http:localhost:5000/swagger
http://localhost:5000/api/{endpoint}
```

## Parando a execução do container

Caso queirar parar a execução, digite o seguinte comando:

```
docker-compose down
```

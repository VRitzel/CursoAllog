# Curso Allog
## Aula 07 - Conexão com Banco de Dados - C#

### Config inicial
- Criar o db no PgAdmin
- Adicionar o pacote Npgsql ao projeto
    - dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
    - Será adicionado no arquivo *.csproj do projeto

### Npgsql
- Provedor .NET para o SDBD

### Conexão
- using Npgsql
- DatabaseHelper
- private NpgsqlConnection npgsqlConnection;
- private const string TABELA_NOME = "cliente";
```cs
Construtor

public DatabaseHelper() {
    var builder = new NpgsqlConnectionStringBuilder();
    builder.Host = "localhost";
    builder.Port = 5432;
    builder.Username = "postgres";
    builder.Password = "master";
    builder.Database = "allog_clientes";
    npgsqlConnection = new NpgsqlConnection(builder.ConnectionString);
    npgsqlConnection.Open();
}

Método

public void fecharConexao() {
    npgsqlConnection.Close();
}

```

### Task
- Processo a ser executado
    - Use await na chamada de um método async
```cs
Métodos Classe DatabaseHelper

Método para criar a tabela Cliente, caso ela não existir.

public async Task criarTabela() {
    var comandoSql = $"CREATE TABLE IF NOT EXISTS {TABELA_NOME}" +
    $"(" +
        $"id serial PRIMARY KEY, " +
        $"nome VARCHAR (100), " +
        $"endereco VARCHAR (100), " +
        $"telefone VARCHAR (15), " +
        $"email VARCHAR (255)" +
    $");";
    using var cmd = new NpgsqlCommand(comandoSql, npgsqlConnection);
    await cmd.ExecuteNonQueryAsync();
}

Método para inserir, editar ou excluir Cliente.

private async Task insertOrUpdateOrDeleteCliente (string comandoSql, int id, bool deletar) {
    Cliente cliente = new Cliente();
    if (!deletar) { // para a adição e edição o usuário informa todos os dados do cliente.
        cliente = informarDadosCliente();
    }
    await using (var param = new NpgsqlCommand(comandoSql, npgsqlConnection)) {
        if (id != 0) {
            param.Parameters.AddWithValue("id", id);
        }
        if (cliente.nome != null) {
            param.Parameters.AddWithValue("nome", cliente.nome);
        }
        if (cliente.endereco != null) {
            param.Parameters.AddWithValue("endereco", cliente.endereco);
        }
        if (cliente.telefone != null) {
            param.Parameters.AddWithValue("telefone", cliente.telefone);
        }
        if (cliente.email != null) {
            param.Parameters.AddWithValue("email", cliente.email);
        }
        await param.ExecuteNonQueryAsync();
    }
}

Método principal para inserir um Cliente.

public async Task cadastrar() {
    string comandoSql = $"INSERT INTO {TABELA_NOME} (nome, endereco, 
        telefone, email) VALUES (@nome, @endereco, @telefone, @email)";
    await insertOrUpdateOrDeleteCliente(comandoSql, 0, false);
    Console.WriteLine("Cliente cadastrado!");
}

 Método principal para atualizar um Cliente.

public async Task editar(int id) {
    if (listarPeloId(id).Result == null) {
        Console.WriteLine("ID do cliente não cadastrado!");
    } else {
        var comandoSql = $"UPDATE {TABELA_NOME} SET nome = @nome, 
            endereco = @endereco, telefone = @telefone, email = @email WHERE id 
            = @id";
        await insertOrUpdateOrDeleteCliente(comandoSql, id, false);
        Console.WriteLine("Cliente atualizado!");
    }
}

Método principal para excluir um Cliente.

public async Task excluir(int id) {
    if (listarPeloId(id).Result == null) {
        Console.WriteLine("ID do cliente não cadastrado!");
    } else {
        string comandoSql = $"DELETE FROM {TABELA_NOME} WHERE id=@id";
        await insertOrUpdateOrDeleteCliente(comandoSql, id, true);
        Console.WriteLine("Cliente excluído!");
    }
}

Método para listar um Cliente pelo ID.

public async Task<Cliente?> listarPeloId(int id) {
    string commandText = $"SELECT * FROM {TABELA_NOME} WHERE id = @id";
    await using (var param = new NpgsqlCommand(commandText, 
        npgsqlConnection)) {
        param.Parameters.AddWithValue("id", id);
        await using (var reader = await param.ExecuteReaderAsync())
        while (await reader.ReadAsync()) {
            Cliente cliente = dadosCliente(reader);
            return cliente;
        }
    }
    return null;
}

Método para listar todos os Clientes.

public async Task<List<Cliente>> listarTodos() {
    string commandText = $"SELECT * FROM {TABELA_NOME} ORDER BY id";
    await using (var param = new NpgsqlCommand(commandText, 
        npgsqlConnection)) {
        List<Cliente> clientes = new List<Cliente>();
        await using (var reader = await param.ExecuteReaderAsync())
        while (await reader.ReadAsync()) {
            clientes.Add(dadosCliente(reader));
        }
        return clientes;
    }
}
```

## Não relacional

### Motivação
- Big Data
    - 3V's
        - Velocidade
        - Veracidade
        - Volume

### Conceito
- Atende aos requisitos do ambiente de computação distribuída em 
larga escala:
    - Permite escalabilidade horizontal, alta disponibilidade e alto 
desempenho.

### NoSQL


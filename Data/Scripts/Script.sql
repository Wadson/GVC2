-- SQLite script for bdsiscontrol database
-- Generated from SQL Server Express migration

-- Table: Estado
CREATE TABLE Estado (
    EstadoID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeEstado VARCHAR(75) NOT NULL,
    UF CHAR(2) NOT NULL
);

-- Table: Cidade
CREATE TABLE Cidade (
    CidadeID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeCidade VARCHAR(120) NOT NULL,
    EstadoID INTEGER NOT NULL,
    UNIQUE (NomeCidade, EstadoID),
    FOREIGN KEY (EstadoID) REFERENCES Estado(EstadoID)
);

-- Table: Cliente
CREATE TABLE Cliente (
    ClienteID INTEGER PRIMARY KEY AUTOINCREMENT,
    Nome NVARCHAR(100) NOT NULL,
    Cpf VARCHAR(14),
    Telefone VARCHAR(20),
    Email NVARCHAR(100),
    CidadeID INTEGER,
    FOREIGN KEY (CidadeID) REFERENCES Cidade(CidadeID)
);

-- Table: Fornecedor
CREATE TABLE Fornecedor (
    FornecedorID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeFornecedor NVARCHAR(100) NOT NULL,
    Cnpj VARCHAR(18),
    Telefone VARCHAR(20),
    Email NVARCHAR(100),
    CidadeID INTEGER NOT NULL,
    FOREIGN KEY (CidadeID) REFERENCES Cidade(CidadeID)
);

-- Table: FormaPgto
CREATE TABLE FormaPgto (
    FormaPgtoID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeFormaPgto NVARCHAR(50) NOT NULL
);

-- Table: Produtos
CREATE TABLE Produtos (
    ProdutoID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeProduto VARCHAR(100) NOT NULL,
    Referencia NVARCHAR(15),
    PrecoCusto DECIMAL(10,2) NOT NULL,
    Lucro DECIMAL(10,2) NOT NULL,
    PrecoDeVenda DECIMAL(10,2) NOT NULL,
    Estoque INTEGER NOT NULL,
    DataDeEntrada DATETIME NOT NULL,
    Status VARCHAR(20) NOT NULL,
    UNIQUE (Referencia)
);

-- Table: Usuario
CREATE TABLE
(
    UsuarioID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeUsuario NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    SenhaHash BLOB NOT NULL,
    SenhaSalt BLOB NOT NULL,
    TipoUsuario NVARCHAR(30) NOT NULL,
    Cpf CHAR(11),
    DataNascimento DATE,
    Ativo BOOLEAN NOT NULL,
    DataCadastro DATETIME NOT NULL
);

-- Table: Pedidos
CREATE TABLE Pedidos (
    PedidoID INTEGER PRIMARY KEY AUTOINCREMENT,
    FornecedorID INTEGER NOT NULL,
    DataPedido DATE NOT NULL,
    ValorTotalPedido DECIMAL(12,2) NOT NULL,
    FOREIGN KEY (FornecedorID) REFERENCES Fornecedor(FornecedorID)
);

-- Table: ItensPedido
CREATE TABLE ItensPedido (
    ItensPedidoID INTEGER PRIMARY KEY AUTOINCREMENT,
    PedidoID INTEGER NOT NULL,
    Referencia NVARCHAR(15),
    Quantidade INTEGER NOT NULL,
    FOREIGN KEY (PedidoID) REFERENCES Pedidos(PedidoID)
);

-- Table: Venda (implícita no ItemVenda e Parcela, precisaria ser criada)
-- Nota: Não há tabela Venda no script fornecido, mas ela é referenciada
-- Vou criar uma tabela básica baseada nas referências
CREATE TABLE Venda (
    VendaID INTEGER PRIMARY KEY AUTOINCREMENT,
    ClienteID INTEGER NOT NULL,
    FormaPgtoID INTEGER,
    DataVenda DATETIME NOT NULL,
    ValorTotal DECIMAL(12,2) NOT NULL,
    FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID),
    FOREIGN KEY (FormaPgtoID) REFERENCES FormaPgto(FormaPgtoID)
);

-- Table: ItemVenda
CREATE TABLE ItemVenda (
    ItemVendaID INTEGER PRIMARY KEY AUTOINCREMENT,
    VendaID INTEGER NOT NULL,
    ProdutoID INTEGER NOT NULL,
    Quantidade INTEGER NOT NULL,
    PrecoUnitario DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) GENERATED ALWAYS AS (Quantidade * PrecoUnitario) STORED,
    FOREIGN KEY (VendaID) REFERENCES Venda(VendaID),
    FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID)
);

-- Table: Parcela
CREATE TABLE Parcela (
    ParcelaID INTEGER PRIMARY KEY AUTOINCREMENT,
    VendaID INTEGER NOT NULL,
    NumeroParcela INTEGER NOT NULL,
    DataVencimento DATETIME NOT NULL,
    ValorParcela DECIMAL(12,2) NOT NULL,
    ValorRecebido DECIMAL(12,2) NOT NULL,
    Pago BOOLEAN NOT NULL,
    SaldoRestante DECIMAL(12,2) GENERATED ALWAYS AS (ValorParcela - ValorRecebido) STORED,
    FOREIGN KEY (VendaID) REFERENCES Venda(VendaID)
);

-- Table: PagamentosParciais
CREATE TABLE PagamentosParciais (
    PagamentoID INTEGER PRIMARY KEY AUTOINCREMENT,
    ParcelaID INTEGER NOT NULL,
    ValorPago DECIMAL(12,2) NOT NULL,
    DataPagamento DATE NOT NULL,
    FOREIGN KEY (ParcelaID) REFERENCES Parcela(ParcelaID)
);

-- Criar índices para melhor performance
CREATE INDEX idx_Cidade_EstadoID ON Cidade(EstadoID);
CREATE INDEX idx_Cliente_CidadeID ON Cliente(CidadeID);
CREATE INDEX idx_Fornecedor_CidadeID ON Fornecedor(CidadeID);
CREATE INDEX idx_Pedidos_FornecedorID ON Pedidos(FornecedorID);
CREATE INDEX idx_ItensPedido_PedidoID ON ItensPedido(PedidoID);
CREATE INDEX idx_Venda_ClienteID ON Venda(ClienteID);
CREATE INDEX idx_Venda_FormaPgtoID ON Venda(FormaPgtoID);
CREATE INDEX idx_ItemVenda_VendaID ON ItemVenda(VendaID);
CREATE INDEX idx_ItemVenda_ProdutoID ON ItemVenda(ProdutoID);
CREATE INDEX idx_Parcela_VendaID ON Parcela(VendaID);
CREATE INDEX idx_PagamentosParciais_ParcelaID ON PagamentosParciais(ParcelaID);

-- Inserir dados básicos (opcional)
INSERT INTO Estado (NomeEstado, UF) VALUES 
    ('São Paulo', 'SP'),
    ('Rio de Janeiro', 'RJ'),
    ('Minas Gerais', 'MG');

INSERT INTO FormaPgto (NomeFormaPgto) VALUES 
    ('Dinheiro'),
    ('Cartão de Crédito'),
    ('Cartão de Débito'),
    ('PIX'),
    ('Boleto');

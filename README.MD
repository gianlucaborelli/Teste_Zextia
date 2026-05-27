# Zextia - Teste Técnico

## Observação Importante

Durante o desenvolvimento deste teste, implementei a entidade **Product** para simular a entidade já existente no ERP, permitindo operações completas de cadastro, atualização e exclusão.

A descrição relacionada ao produto foi modelada em uma entidade separada, com relacionamento **1:1** com Product.

Para lotes, considerando que um produto pode possuir mais de um item associado, criei a entidade **ProductSupplement** com relacionamento **1:N** com Product.

## Tecnologias Utilizadas

- .NET Framework 4.8
- Entity Framework 6
- PostgreSQL
- Windows Forms

## Modelagem de Entidades

### Product

Representa a entidade principal já existente no ERP e concentra as operações de CRUD.

### ProductDetail

Entidade separada para dados descritivos do produto.

- Relacionamento: **Product 1:1 ProductDetail**

### ProductSupplement

Entidade para representar múltiplos suplementos/lotes vinculados a um produto.

- Relacionamento: **Product 1:N ProductSupplement**

## Como Executar Localmente

### Pré-requisitos

- Visual Studio (com suporte ao .NET Framework 4.8)
- PostgreSQL em execução
- String de conexão configurada no projeto

### Passos

1. Abrir a solução no Visual Studio.
2. Restaurar os pacotes NuGet (se necessário).
3. Abrir o **Package Manager Console**.
4. Executar o comando abaixo para aplicar as migrations existentes ao banco local:

```powershell
Update-Database
```

5. Executar o projeto.

## View SQL para consultar os dados



```sql
DROP VIEW IF EXISTS dbo."vw_ProductBatchesReport";

CREATE VIEW dbo."vw_ProductBatchesReport" AS
SELECT
	
	p."Id" AS "ProductId",
	p."Name" AS "ProductName",
	p."Code" AS "ProductCode",
	p."CreatedAt" AS "ProductCreatedAt",
	
	pd."Id" AS "DetailId",
	pd."Description" AS "ProductDescription",
	
	ps."Id" AS "SupplementId",
	ps."Batches" AS "BatchNumber",
	ps."CreatedAt" AS "SupplementCreatedAt"

FROM 
	dbo."ProductSupplements" ps
	RIGHT JOIN dbo."Products" p 
		ON ps."ProductId" = p."Id"
	LEFT JOIN dbo."ProductDetails" pd 
		ON p."Id" = pd."Id";

```

Após executar a view, você pode consultar os dados utilizando:

```sql
SELECT * FROM dbo."vw_ProductBatchesReport";
```
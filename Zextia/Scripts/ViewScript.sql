DROP VIEW IF EXISTS dbo."vw_ProductBatchesReport";

CREATE VIEW dbo."vw_ProductBatchesReport" AS
SELECT
	
	p."Id" AS "ProductId",
	p."Name" AS "ProductName",
	p."Code" AS "ProductCode",
	pd."Description" AS "ProductDescription",
	p."CreatedAt" AS "ProductCreatedAt",
	
	ps."Id" AS "SupplementId",
	ps."Batches" AS "BatchNumber",
	ps."CreatedAt" AS "SupplementCreatedAt"

FROM 
	dbo."ProductSupplements" ps
	RIGHT JOIN dbo."Products" p 
		ON ps."ProductId" = p."Id"
	LEFT JOIN dbo."ProductDetails" pd 
		ON p."Id" = pd."Id";
CREATE OR REPLACE FUNCTION fn_delete_product(
    p_product_id UUID
)
RETURNS TABLE(
    success BOOLEAN,
    message TEXT
)
LANGUAGE plpgsql
AS $$
DECLARE
    v_product_exists BOOLEAN;
BEGIN

    SELECT EXISTS(
        SELECT 1
        FROM dbo."Products"
        WHERE "Id" = p_product_id
    )
    INTO v_product_exists;

    IF NOT v_product_exists THEN
        RETURN QUERY
        SELECT FALSE, 'Produto não encontrado';

        RETURN;
    END IF;

    DELETE FROM dbo."ProductSupplements"
    WHERE "ProductId" = p_product_id;

    DELETE FROM dbo."ProductDetails"
    WHERE "ProductId" = p_product_id;

    DELETE FROM dbo."Products"
    WHERE "Id" = p_product_id;

    RETURN QUERY
    SELECT
        TRUE,
        'Produto excluído com sucesso';

EXCEPTION
    WHEN OTHERS THEN

        RETURN QUERY
        SELECT
            FALSE,
            'Erro ao excluir produto: ' || SQLERRM;
END;
$$;
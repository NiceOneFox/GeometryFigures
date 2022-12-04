GeometryFigures

## Решение задания 2
SELECT p.name as product_name, c.name AS category_name <br/>
FROM Products p <br/>
LEFT JOIN ProductsCategories pc ON p.id = pc.product_id <br/>
LEFT JOIN Categories c ON c.id = pc.category_id <br/>

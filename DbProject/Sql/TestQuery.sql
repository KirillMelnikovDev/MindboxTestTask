-- using created database "Mindbox"
use Mindbox;

select Product.Name, Category.Name
from dbo.Products Product
left join dbo.ProductsCategories ProductsToCategories on Product.Id = ProductsToCategories.ProductId
left join dbo.Categories Category on ProductsToCategories.CategoryId = Category.Id;
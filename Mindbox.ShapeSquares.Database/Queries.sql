select P.Name, C.Name 
from [Business].[Product] P 
left join [Business].[ProductLinkCategory] L on P.Id = L.ProductId
left join [Business].[Category] C on L.CategoryId = C.Id
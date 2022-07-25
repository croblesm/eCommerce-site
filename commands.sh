dotnet aspnet-codegenerator controller -name ProductsController -actions -nv -m Product -dc DataContext -outDir Controllers

dotnet aspnet-codegenerator view Index List -outDir Views/Products -udl -m Product
dotnet aspnet-codegenerator view Create Create -outDir Views/Products -udl -m Product
dotnet aspnet-codegenerator view Edit Edit -outDir Views/Products -udl -m Product
dotnet aspnet-codegenerator view Details Details -outDir Views/Products -udl -m Product
dotnet aspnet-codegenerator view Delete Delete -outDir Views/Products -udl -m Product

dotnet aspnet-codegenerator controller -name CategoriesController -actions -nv -m Category -dc DataContext -outDir Controllers

dotnet aspnet-codegenerator view Index List -outDir Views/Categories -udl -m Category
dotnet aspnet-codegenerator view Create Create -outDir Views/Categories -udl -m Category
dotnet aspnet-codegenerator view Edit Edit -outDir Views/Categories -udl -m Category
dotnet aspnet-codegenerator view Details Details -outDir Views/Categories -udl -m Category
dotnet aspnet-codegenerator view Delete Delete -outDir Views/Categories -udl -m Category
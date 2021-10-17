# ApiCompleta

Este projeto foi inspirada no modelo do curso do Eduardo pires sobre mvc onde é criado um projeto em camadas de produtos e fornecedores
resolvi criar mais entidades e fazer uma api completa com tudo que venho aprendendo e praticando, onde modelei, criei a camada de api 
com as controllers, a api é assincrona e usa os padrões de projeto repository e services para tirar o acoplamento das controllers sobre a camada de negocio e de persistencia de dados, a ideia do projeto é para um comercio, onde temos os produtos e os fornecedores, clientes que fazem compras, compras, clientes e fornecedores so tem acesso na api por meio de autenticação gerando um token jwt, sendo que clientes e compras so podem ser vistos por gerentes

Pacotes usados:
AspNetCore
EntityFrameworkCore
Identity
JwtBearer

# Relacionamento
compra n x n produto
compra n x 1 cliente
produto n x 1 fornecedor


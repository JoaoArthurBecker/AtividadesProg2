Projeto ASPnet para fixação de conhecimento
A implementação do projeto será descrita em etapas de criação
O primeiro passo é a criação do projeto ASPnet. Para isso foi utilizada a IIDE Visual Studio Community 2022, com os módulos de desenvolvimento ASPnet instalados. 
Para este paço foi iniciado o programa, selecionado no menu arquivo a opção novo. Na tela que se seguiu foi localizada  nos tipos de projeto o correspondente a aspnet mvc, com template, e desmarcado a opção de configuração de https
Passo 2:
Com o projeto já criado e aberto, o próximo passo foi instalar os pacots nugets com suas respectivas bibliotecas, para o correto funcionamento do projeto sendo eles:
Microsoft.AspNetCore.Identity.EntityFrameworkCore;
Microsoft.EntityFrameworkCore.Design;
Microsoft.EntityFrameworkCore.SqlServer.
Para efetuar a instalação, foi aberta a barra de opções do visual studio, ido até o menu projeto e Gerenciar Pacotes do NuGet. Com o gerenciador aberto, foi navegado até a guia disponíveis, e pesquisado pelo nome de cada um dos pacotes individualmente. Para a instalação de cada o determinado pacote foi selecionado, assim  exibindo suas informações. Na versão foi definida como 6.0.20 para todos, e a instalação foi bem sucedida
O terceiro paço foi a implementação onde foram modificados os modelos com a criação de uma  object class para psicólogo,  ApppDB Context  e a criação  de um  novo namespace para data, tudo isso herdando informações da biblioteca identity. Também foi criada uma string de conexão para MYSQL server no appconfig .json, e as implementações de construção no program.cs.
Para o quarto paço, foi definido o mapeamento das object classes e AppDbContext. Para tal foi feito o seguinte:
Em um terminal Powershell externo foi navegado até a pasta do projeto, e dado o seguinte comando
“dotnet migration add Initial”.
Com o sucesso deste comando, o quinto passo pôde ser procedido já que as alterações de objeto e banco de dados do projeto já haviam sido mapeadas, o momento era de implementá-las e conectá-las ao MISQL server, com o seguinte comando
“update database”. Com este comando, a migration inicial foi dada ao projeto, e os bancos de dados implementados.


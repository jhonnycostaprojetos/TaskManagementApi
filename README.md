<div style="padding-top: 40%;">
    <div style="font-size: 40px; text-align: center;">TaskManagementApi</div>
    <div style="padding: 20px; font-size: 30px; text-align: center;">API desenvolvida para o teste técnico</div>
    <div style="text-align: center; font-size: 20px; padding-top:20%"> Jhonny Costa </div>
</div>

## 1. <span style="color:#7b94cc"> <b>Detalhes Para execução</b> </span>

O projeto foi desenvolvido utilizando o EntityFramework com banco de dados SQLSERVER. 
As migrações já está iniciada e ao executar o comando abaixo, o banco de dados será criado, juntamente com as tabelas utilizadas para o projeto.
Para executar o projeto baixe o docker e siga os passos: 
1. Via prompt de comando, acesse a pasta clonada e digite:
   1. cd TaskManagement/TaskManagement.Api
   2. dotnet build
   3. cd ..
   4. docker-compose up --build
   5. http://localhost:8081/swagger/index.html

Caso não tenha o docker instalado, será necessário:
    1. Instalação do SQLSERVER2019
    2. Acessar o arquivo appsettings.json e trocar o Data Source para o endereço de instalação
    3. Após instalado o banco e ajustado o arquivo anterior, acessar a pasta TaskManagement.Infra.Data via terminal de comandos(prompt) e digitar os seguintes comandos:
        1.     dotnet ef ( verifica a instalação )
        2.     dotnet tool install --global dotnet-ef
        3.     dotnet ef migrations add initialMigration
        4.     dotnet ef database update 
   
---

## 2. <span style="color:#7b94cc"> <b>Perguntas para o PO</b> </span>

---
1. Quais são os campos obrigatórios e opcionais ao se criar uma nova tarefa? Existe alguma validação especifica que devemos implementar?
2. Em relação a remoção de Projetos e Tarefas, existe algum outro critério que precisamos considerar? 
3. Existem desafios ou problemas informados pelos usuários que precisamos abordar?
4. Alguma funcionalidade gerou dificuldades?
5. Há novos recursos que os usuários expressaram interesse?
6. Como está o desempenho da API? Algum ponto de lentidão?
7. Houve alguma situação que podemos tirar com uma lição aprendida?
8. Quais são os próximos passos do projeto?

---

## 3. <span style="color:#7b94cc"> <b>Pontos de Melhoria</b> </span>

---
1. Inclusão de um padrão robousto de autenticação
2. Implementar ferramentas de monitoramente de desempenho para acomapnhar a latência, consumo de dos recursos e possíveis gargalos.
3. Montar uma documentação detalhada.
4. Implementar pipelines de CI/CD para automatizar o processo de build, teste e implantação, para uma entrega mais rapida e confiável.
5. Avaliar  a viabilidade de uma mudança de arquitetura para microserviços.
6. Integração com alguma plataforma de Nuvem, pensando principalmente em escablididade, disponibilidade e recuperação de desastres.
7. Aprimorar os logs, pensando em incluir mais detalhes para resolução de problemas e auditoria. 




<div style="padding-top: 40%;">
    <div style="font-size: 40px; text-align: center;">TaskManagementApi</div>
    <div style="padding: 20px; font-size: 30px; text-align: center;">API desenvolvida para o teste técnico</div>
    <div style="text-align: center; font-size: 20px; padding-top:20%"> Jhonny Costa </div>
</div>

## 1. <span style="color:#7b94cc"> <b>Detalhes Para execução</b> </span>

O projeto foi desenvolvido utilizando o EntityFramework com banco de dados SQLSERVER. 
As migrações está iniciada e ao executar o comando acima, o banco de dados será criado, juntamente com as tabelas utilizadas para o projeto. 
Para executar o projeto no docker: 
1. Acessar a para raiz do projeto e executar o seguinte comando: docker-compose up --build.
   
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




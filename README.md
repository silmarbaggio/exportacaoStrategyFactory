Segue um exemplo da utilização do Design Pattern Strategy e do Factory.

Projeto
O projeto é uma simples simulação de um modulo de exportação para diferentes formatos de arquivos, a ideia é que cada formato com as suas particularidades, simule uma estratégia diferente de negócio.  

Strategy

Qual o seu propósito?
Esse padrão delega uma responsabilidade a um objeto sendo que o comportamento pode ser alternado em tempo de execução.
O padrão Strategy serve para “definir uma família de algoritmos, encapsular cada uma delas e torná-las intercambiáveis. Strategy permite que o algoritmo varie independentemente dos clientes que o utilizam” (como definido no livro do GoF)

Onde uso?
Classes que precisam alternar o seu comportamento em tempo de execução sem mudar a sua própria implementação.
Utileze STRATEGY quando precisar alternar o comportamento de um objeto.

Também é utilizado o padrão Factory (Factory Method) que serve para instanciar classes dinamicamente conhecendo apenas sua interface ou classe abstrata.

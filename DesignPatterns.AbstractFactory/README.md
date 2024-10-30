# Abstract Factory

O padrão Abstract Factory, também conhecido como *Kit*, é um dos padrões criacionais que visa fornecer uma interface para criar famílias de objetos relacionados sem especificar suas classes concretas. Ele é útil quando você deseja garantir que um conjunto de produtos seja compatível entre si e deseja centralizar a lógica de criação desses produtos.

### Principais características
- Cria famílias de objetos relacionados.
- Envolve a criação de várias interfaces ou classes para definir um conjunto de produtos.
- Cada fábrica concreta cria uma família inteira de objetos compatíveis.

## Estrutura do Abstract Factory
- **Abstract Factory:** Interface ou classe abstrata que define métodos para criar objetos (produtos) abstratos de uma família. Ela não implementa a criação dos objetos, apenas define o que precisa ser criado.
- **Concrete Factory:** Implementa a Abstract Factory, criando objetos de classes concretas específicos. Cada fábrica concreta é responsável por criar uma família de produtos relacionada.
- **Abstract Product:** Interface ou classe abstrata que define o comportamento dos produtos a serem criados. Cada tipo de produto terá uma interface correspondente.
- **Concrete Product:** Implementa o Abstract Product, sendo o objeto específico que será criado pela Concrete Factory.

## Caso de uso
Imagine que você está desenvolvendo um aplicativo que precisa gerar interfaces para diferentes sistemas operacionais, como Windows e Mac. Cada sistema operacional tem uma aparência específica para botões e caixas de diálogo.

1. **Abstract Factory:** ```IUIFactory```, que define métodos como ```CreateButton()``` e ```CreateDialog()```.
2. **Concrete Factories:** ```WindowsFactory``` e ```MacFactory```, que implementam ```IUIFactory``` e são responsáveis por criar os componentes específicos para cada sistema operacional.
3. **Abstract Product:** ```IButton``` e ```IDialog```, que definem o comportamento básico de botões e diálogos.
4. **Concrete Product:** ```WindowsButton```, ```WindowsDialog```, ```MacButton``` e ```MacDialog```, que implementam ```IButton``` e ```IDialog``` e contêm a aparência e o comportamento de cada sistema.

## Vantagens
- **Consistência:** Garante que os produtos criados são compatíveis entre si, ideal para sistemas que precisam manter uma aparência ou comportamento coerente.
- **Isolamento de Classes Concretas:** O cliente lida apenas com interfaces ou classes abstratas, facilitando mudanças nas implementações concretas.
- **Escalabilidade:** Facilita a adição de novos produtos ou variantes de produtos sem modificar o código cliente.

## Desvantagens
- **Complexidade de Código:** Usar o Abstract Factory pode aumentar a complexidade do código, especialmente quando você adiciona várias classes e interfaces para lidar com diferentes variantes de produtos. Para sistemas simples, isso pode se tornar um esforço desnecessário e deixar o código mais difícil de entender e manter.
- **Dificuldade em Suporte a Novos Produtos:** O padrão foi desenhado para criar famílias de objetos relacionadas, mas adicionar um novo tipo de produto (ou seja, um novo método na fábrica) exige que todas as fábricas concretas sejam atualizadas para suportar esse novo produto. Isso pode ser uma tarefa trabalhosa, especialmente em sistemas grandes.

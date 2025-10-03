// Antigamente a declaração var era mais usada, porém let tornou-se mais popular por ter um escopo de bloco, diferente do var que tem escopo de função.

let nome = 'Wallace';
let curso = 'JavaScript';
let fruta = 'Morango';

console.log('Meu nome é', nome, 'e estou cursando', curso, ', e minha fruta favorita é', fruta);

// Podemos declarar várias variáveis com let na mesma linha, separando-as por vírgula.
let cidade = 'São Paulo', estado = 'SP', país = 'Brasil';

// Declando uma variável sem valor inicial.
let idade;
idade = 30; // Atribuindo valor à variável depois da declaração.

// Diferença entre var e let
// var tem escopo de função, ou seja, se declarada dentro de uma função, não pode ser acessada fora dela.
// let tem escopo de bloco, ou seja, se declarada dentro de um bloco (entre chaves {}), não pode ser acessada fora dele.

numero1 = 1; // Declarando uma variável sem var, let ou const, ela se torna uma variável global (não recomendado).]

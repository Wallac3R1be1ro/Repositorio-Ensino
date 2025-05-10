# Criando uma classe chamada Circulo
class Circulo():

    # O valor de pi é constante
    pi = 3.14

    # Quando um objeto desta classe for criado, este método será executado e o valor default do raio será 5.
    def __init__(self, raio=5):
        self.raio = raio

    # Esse método calcula a área. Self utiliza os atributos deste mesmo objeto
    def area(self):
        return (self.raio * self.raio) * Circulo.pi

    # Método para gerar um novo raio
    def setRaio(self, novo_raio):
        self.raio = novo_raio

    # Método para obter o raio do circulo
    def getRaio(self):
        return self.raio

# Criando o objeto circ. Uma instância da classe Circulo()
circ = Circulo()

# Criando outro objeto chamado circ1. Uma instância da classe Circulo()
circ1 = Circulo()

# Imprimindo o raio
print('O raio é: ', circ.getRaio())

# Imprimindo a área
print("Área igual a: ", circ.area())

# Criando a classe livro
class Livro():
    def __init__(self, titulo, autor, paginas):
        print ("Livro criado")
        self.titulo - titulo
        self.autor = autor
        self.paginas = paginas

    def __str__(self):
        return "Titulo: %s , autor: %s, página: %s " \
    %(self.titulo, self.autor, self.paginas)

    def __len__(self):
        return self.paginas
    
    def len(self):
        return print("Páginas do livro com método comum: ", self.paginas)
# No exemplo, a função lent() utilizada com o nome do objeto retorna o número de páginas.
livro1 = Livro("Os Lusíadas", "Luis de Camões", 8816)

# Métodos especiais
print(livro1)

str(livro1)


